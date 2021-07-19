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

namespace Google.Apis.Monitoring.v1
{
    /// <summary>The Monitoring Service.</summary>
    public class MonitoringService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MonitoringService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MonitoringService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "monitoring";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://monitoring.googleapis.com/";
        #else
            "https://monitoring.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://monitoring.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Monitoring API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View and write monitoring data for all of your Google and third-party Cloud and API projects
            /// </summary>
            public static string Monitoring = "https://www.googleapis.com/auth/monitoring";

            /// <summary>View monitoring data for all of your Google Cloud and third-party projects</summary>
            public static string MonitoringRead = "https://www.googleapis.com/auth/monitoring.read";

            /// <summary>Publish metric data to your Google Cloud projects</summary>
            public static string MonitoringWrite = "https://www.googleapis.com/auth/monitoring.write";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Monitoring API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View and write monitoring data for all of your Google and third-party Cloud and API projects
            /// </summary>
            public const string Monitoring = "https://www.googleapis.com/auth/monitoring";

            /// <summary>View monitoring data for all of your Google Cloud and third-party projects</summary>
            public const string MonitoringRead = "https://www.googleapis.com/auth/monitoring.read";

            /// <summary>Publish metric data to your Google Cloud projects</summary>
            public const string MonitoringWrite = "https://www.googleapis.com/auth/monitoring.write";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Monitoring requests.</summary>
    public abstract class MonitoringBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MonitoringBaseServiceRequest instance.</summary>
        protected MonitoringBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Monitoring parameter list.</summary>
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
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v1.Data.Operation>
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
                    Pattern = @"^operations/.*$",
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
            Dashboards = new DashboardsResource(service);
        }

        /// <summary>Gets the Dashboards resource.</summary>
        public virtual DashboardsResource Dashboards { get; }

        /// <summary>The "dashboards" collection of methods.</summary>
        public class DashboardsResource
        {
            private const string Resource = "dashboards";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DashboardsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see
            /// Managing dashboards by API (https://cloud.google.com/monitoring/dashboards/api-dashboard). This method
            /// requires the monitoring.dashboards.create permission on the specified project. For more information
            /// about permissions, see Cloud Identity and Access Management (https://cloud.google.com/iam).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The project on which to execute the request. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// The [PROJECT_ID_OR_NUMBER] must match the dashboard resource name.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Monitoring.v1.Data.Dashboard body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see
            /// Managing dashboards by API (https://cloud.google.com/monitoring/dashboards/api-dashboard). This method
            /// requires the monitoring.dashboards.create permission on the specified project. For more information
            /// about permissions, see Cloud Identity and Access Management (https://cloud.google.com/iam).
            /// </summary>
            public class CreateRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v1.Data.Dashboard>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v1.Data.Dashboard body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project on which to execute the request. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER] The [PROJECT_ID_OR_NUMBER] must match the dashboard resource name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>If set, validate the request and preview the review, but do not actually save it.</summary>
                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ValidateOnly { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v1.Data.Dashboard Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/dashboards";

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
            /// Deletes an existing custom dashboard.This method requires the monitoring.dashboards.delete permission on
            /// the specified dashboard. For more information, see Cloud Identity and Access Management
            /// (https://cloud.google.com/iam).
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the Dashboard. The format is:
            /// projects/[PROJECT_ID_OR_NUMBER]/dashboards/[DASHBOARD_ID]
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes an existing custom dashboard.This method requires the monitoring.dashboards.delete permission on
            /// the specified dashboard. For more information, see Cloud Identity and Access Management
            /// (https://cloud.google.com/iam).
            /// </summary>
            public class DeleteRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Dashboard. The format is:
                /// projects/[PROJECT_ID_OR_NUMBER]/dashboards/[DASHBOARD_ID]
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
                        Pattern = @"^projects/[^/]+/dashboards/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Fetches a specific dashboard.This method requires the monitoring.dashboards.get permission on the
            /// specified dashboard. For more information, see Cloud Identity and Access Management
            /// (https://cloud.google.com/iam).
            /// </summary>
            /// <param name="name">
            /// Required. The resource name of the Dashboard. The format is one of: dashboards/[DASHBOARD_ID] (for
            /// system dashboards) projects/[PROJECT_ID_OR_NUMBER]/dashboards/[DASHBOARD_ID] (for custom dashboards).
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Fetches a specific dashboard.This method requires the monitoring.dashboards.get permission on the
            /// specified dashboard. For more information, see Cloud Identity and Access Management
            /// (https://cloud.google.com/iam).
            /// </summary>
            public class GetRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v1.Data.Dashboard>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Dashboard. The format is one of: dashboards/[DASHBOARD_ID] (for
                /// system dashboards) projects/[PROJECT_ID_OR_NUMBER]/dashboards/[DASHBOARD_ID] (for custom
                /// dashboards).
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
                        Pattern = @"^projects/[^/]+/dashboards/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the existing dashboards.This method requires the monitoring.dashboards.list permission on the
            /// specified project. For more information, see Cloud Identity and Access Management
            /// (https://cloud.google.com/iam).
            /// </summary>
            /// <param name="parent">
            /// Required. The scope of the dashboards to list. The format is: projects/[PROJECT_ID_OR_NUMBER]
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists the existing dashboards.This method requires the monitoring.dashboards.list permission on the
            /// specified project. For more information, see Cloud Identity and Access Management
            /// (https://cloud.google.com/iam).
            /// </summary>
            public class ListRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v1.Data.ListDashboardsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The scope of the dashboards to list. The format is: projects/[PROJECT_ID_OR_NUMBER]
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// A positive number that is the maximum number of results to return. If unspecified, a default of 1000
                /// is used.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// If this field is not empty then it must contain the nextPageToken value returned by a previous call
                /// to this method. Using this field causes the method to return additional results from the previous
                /// method call.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/dashboards";

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
            /// Replaces an existing custom dashboard with a new definition.This method requires the
            /// monitoring.dashboards.update permission on the specified dashboard. For more information, see Cloud
            /// Identity and Access Management (https://cloud.google.com/iam).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Immutable. The resource name of the dashboard.</param>
            public virtual PatchRequest Patch(Google.Apis.Monitoring.v1.Data.Dashboard body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Replaces an existing custom dashboard with a new definition.This method requires the
            /// monitoring.dashboards.update permission on the specified dashboard. For more information, see Cloud
            /// Identity and Access Management (https://cloud.google.com/iam).
            /// </summary>
            public class PatchRequest : MonitoringBaseServiceRequest<Google.Apis.Monitoring.v1.Data.Dashboard>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Monitoring.v1.Data.Dashboard body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Immutable. The resource name of the dashboard.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>If set, validate the request and preview the review, but do not actually save it.</summary>
                [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ValidateOnly { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Monitoring.v1.Data.Dashboard Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/dashboards/[^/]+$",
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
        }
    }
}
namespace Google.Apis.Monitoring.v1.Data
{
    /// <summary>
    /// Describes how to combine multiple time series to provide a different view of the data. Aggregation of time
    /// series is done in two steps. First, each time series in the set is aligned to the same time interval boundaries,
    /// then the set of time series is optionally reduced in number.Alignment consists of applying the
    /// per_series_aligner operation to each time series after its data has been divided into regular alignment_period
    /// time intervals. This process takes all of the data points in an alignment period, applies a mathematical
    /// transformation such as averaging, minimum, maximum, delta, etc., and converts them into a single data point per
    /// period.Reduction is when the aligned and transformed time series can optionally be combined, reducing the number
    /// of time series through similar mathematical transformations. Reduction involves applying a cross_series_reducer
    /// to all the time series, optionally sorting the time series into subsets with group_by_fields, and applying the
    /// reducer to each subset.The raw time series data can contain a huge amount of information from multiple sources.
    /// Alignment and reduction transforms this mass of data into a more manageable and representative collection of
    /// data, for example "the 95% latency across the average of all tasks in a cluster". This representative data can
    /// be more easily graphed and comprehended, and the individual time series data is still available for later
    /// drilldown. For more details, see Filtering and aggregation
    /// (https://cloud.google.com/monitoring/api/v3/aggregation).
    /// </summary>
    public class Aggregation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The alignment_period specifies a time interval, in seconds, that is used to divide the data in all the time
        /// series into consistent blocks of time. This will be done before the per-series aligner can be applied to the
        /// data.The value must be at least 60 seconds. If a per-series aligner other than ALIGN_NONE is specified, this
        /// field is required or an error is returned. If no per-series aligner is specified, or the aligner ALIGN_NONE
        /// is specified, then this field is ignored.The maximum value of the alignment_period is 2 years, or 104 weeks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignmentPeriod")]
        public virtual object AlignmentPeriod { get; set; }

        /// <summary>
        /// The reduction operation to be used to combine time series into a single time series, where the value of each
        /// data point in the resulting series is a function of all the already aligned values in the input time
        /// series.Not all reducer operations can be applied to all time series. The valid choices depend on the
        /// metric_kind and the value_type of the original time series. Reduction can yield a time series with a
        /// different metric_kind or value_type than the input time series.Time series data must first be aligned (see
        /// per_series_aligner) in order to perform cross-time series reduction. If cross_series_reducer is specified,
        /// then per_series_aligner must be specified, and must not be ALIGN_NONE. An alignment_period must also be
        /// specified; otherwise, an error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crossSeriesReducer")]
        public virtual string CrossSeriesReducer { get; set; }

        /// <summary>
        /// The set of fields to preserve when cross_series_reducer is specified. The group_by_fields determine how the
        /// time series are partitioned into subsets prior to applying the aggregation operation. Each subset contains
        /// time series that have the same value for each of the grouping fields. Each individual time series is a
        /// member of exactly one subset. The cross_series_reducer is applied to each subset of time series. It is not
        /// possible to reduce across different resource types, so this field implicitly contains resource.type. Fields
        /// not specified in group_by_fields are aggregated away. If group_by_fields is not specified and all the time
        /// series have the same resource type, then the time series are aggregated into a single output time series. If
        /// cross_series_reducer is not defined, this field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupByFields")]
        public virtual System.Collections.Generic.IList<string> GroupByFields { get; set; }

        /// <summary>
        /// An Aligner describes how to bring the data points in a single time series into temporal alignment. Except
        /// for ALIGN_NONE, all alignments cause all the data points in an alignment_period to be mathematically grouped
        /// together, resulting in a single data point for each alignment_period with end timestamp at the end of the
        /// period.Not all alignment operations may be applied to all time series. The valid choices depend on the
        /// metric_kind and value_type of the original time series. Alignment can change the metric_kind or the
        /// value_type of the time series.Time series data must be aligned in order to perform cross-time series
        /// reduction. If cross_series_reducer is specified, then per_series_aligner must be specified and not equal to
        /// ALIGN_NONE and alignment_period must be specified; otherwise, an error is returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perSeriesAligner")]
        public virtual string PerSeriesAligner { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A chart that displays alert policy data.</summary>
    public class AlertChart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the alert policy. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A chart axis.</summary>
    public class Axis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The label of the axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The axis scale. By default, a linear scale is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual string Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options to control visual rendering of a chart.</summary>
    public class ChartOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The chart mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the layout properties and content for a column.</summary>
    public class Column : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative weight of this column. The column weight is used to adjust the width of columns on the screen
        /// (relative to peers). Greater the weight, greater the width of the column on the screen. If omitted, a value
        /// of 1 is used while rendering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<long> Weight { get; set; }

        /// <summary>The display widgets arranged vertically in this column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<Widget> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A simplified layout that divides the available space into vertical columns and arranges a set of widgets
    /// vertically in each column.
    /// </summary>
    public class ColumnLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The columns of content to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<Column> Columns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Google Stackdriver dashboard. Dashboards define the content and layout of pages in the Stackdriver web
    /// application.
    /// </summary>
    public class Dashboard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content is divided into equally spaced columns and the widgets are arranged vertically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnLayout")]
        public virtual ColumnLayout ColumnLayout { get; set; }

        /// <summary>Required. The mutable, human-readable name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. An etag is returned in the response to GetDashboard, and users are expected to
        /// put that etag in the request to UpdateDashboard to ensure that their change will be applied to the same
        /// version of the Dashboard configuration. The field should not be passed during dashboard creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Content is arranged with a basic layout that re-flows a simple list of informational elements like widgets
        /// or tiles.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gridLayout")]
        public virtual GridLayout GridLayout { get; set; }

        /// <summary>
        /// The content is arranged as a grid of tiles, with each content widget occupying one or more grid blocks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mosaicLayout")]
        public virtual MosaicLayout MosaicLayout { get; set; }

        /// <summary>Immutable. The resource name of the dashboard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The content is divided into equally spaced rows and the widgets are arranged horizontally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLayout")]
        public virtual RowLayout RowLayout { get; set; }
    }

    /// <summary>Groups a time series query definition with charting options.</summary>
    public class DataSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A template string for naming TimeSeries in the resulting data set. This should be a string with
        /// interpolations of the form ${label_name}, which will resolve to the label's value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legendTemplate")]
        public virtual string LegendTemplate { get; set; }

        /// <summary>
        /// Optional. The lower bound on data point frequency for this data set, implemented by specifying the minimum
        /// alignment period to use in a time series query For example, if the data is published once every 10 minutes,
        /// the min_alignment_period should be at least 10 minutes. It would not make sense to fetch and align data at
        /// one minute intervals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAlignmentPeriod")]
        public virtual object MinAlignmentPeriod { get; set; }

        /// <summary>How this data should be plotted on the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plotType")]
        public virtual string PlotType { get; set; }

        /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesQuery")]
        public virtual TimeSeriesQuery TimeSeriesQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of (label, value) pairs that were removed from a Distribution time series during aggregation and then
    /// added as an attachment to a Distribution.Exemplar.The full label set for the exemplars is constructed by using
    /// the dropped pairs in combination with the label values that remain on the aggregated Distribution time series.
    /// The constructed full label set can be used to identify the specific entity, such as the instance or job, which
    /// might be contributing to a long-tail. However, with dropped labels, the storage requirements are reduced because
    /// only the aggregated distribution values for a large group of time series are stored.Note that there are no
    /// guarantees on ordering of the labels from exemplar-to-exemplar and from distribution-to-distribution in the same
    /// stream, and there may be duplicates. It is up to clients to resolve any ambiguities.
    /// </summary>
    public class DroppedLabels : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Map from label to its value, for all labels dropped in any aggregation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual System.Collections.Generic.IDictionary<string, string> Label { get; set; }

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

    /// <summary>A single field of a message type.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field cardinality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardinality")]
        public virtual string Cardinality { get; set; }

        /// <summary>The string value of the default value of this field. Proto2 syntax only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; }

        /// <summary>The field JSON name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonName")]
        public virtual string JsonName { get; set; }

        /// <summary>The field type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The field name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The field number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("number")]
        public virtual System.Nullable<int> Number { get; set; }

        /// <summary>
        /// The index of the field type in Type.oneofs, for message or enumeration types. The first type has index 1;
        /// zero means the type is not in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneofIndex")]
        public virtual System.Nullable<int> OneofIndex { get; set; }

        /// <summary>The protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>Whether to use alternative packed wire representation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packed")]
        public virtual System.Nullable<bool> Packed { get; set; }

        /// <summary>
        /// The field type URL, without the scheme, for message or enumeration types. Example:
        /// "type.googleapis.com/google.protobuf.Timestamp".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeUrl")]
        public virtual string TypeUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A gauge chart shows where the current value sits within a pre-defined range. The upper and lower bounds should
    /// define the possible range of values for the scorecard's query (inclusive).
    /// </summary>
    public class GaugeView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The lower bound for this gauge chart. The value of the chart should always be greater than or equal to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBound")]
        public virtual System.Nullable<double> LowerBound { get; set; }

        /// <summary>
        /// The upper bound for this gauge chart. The value of the chart should always be less than or equal to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperBound")]
        public virtual System.Nullable<double> UpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A basic layout divides the available space into vertical columns of equal width and arranges a list of widgets
    /// using a row-first strategy.
    /// </summary>
    public class GridLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of columns into which the view's width is divided. If omitted or set to zero, a system default
        /// will be used while rendering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Nullable<long> Columns { get; set; }

        /// <summary>The informational elements that are arranged into the columns row-first.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<Widget> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The ListDashboards request.</summary>
    public class ListDashboardsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested dashboards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashboards")]
        public virtual System.Collections.Generic.IList<Dashboard> Dashboards { get; set; }

        /// <summary>
        /// If there are more results than have been returned, then this field is set to a non-empty value. To see the
        /// additional results, use that value as page_token in the next call to this method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mosaic layout divides the available space into a grid of blocks, and overlays the grid with tiles. Unlike
    /// GridLayout, tiles may span multiple grid blocks and can be placed at arbitrary locations in the grid.
    /// </summary>
    public class MosaicLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of columns in the mosaic grid. The number of columns must be between 1 and 12, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Nullable<int> Columns { get; set; }

        /// <summary>The tiles to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tiles")]
        public virtual System.Collections.Generic.IList<Tile> Tiles { get; set; }

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

    /// <summary>Contains metadata for longrunning operation for the edit Metrics Scope endpoints.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time when the batch request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Current state of the batch operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The time when the operation result was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protocol buffer option, which can be attached to a message, field, enumeration, etc.</summary>
    public class Option : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The option's name. For protobuf built-in options (options defined in descriptor.proto), this is the short
        /// name. For example, "map_entry". For custom options, it should be the fully-qualified name. For example,
        /// "google.api.http".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The option's value packed in an Any message. If the value is a primitive, the corresponding wrapper type
        /// defined in google/protobuf/wrappers.proto should be used. If the value is an enum, it should be stored as an
        /// int32 value using the google.protobuf.Int32Value type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a ranking-based time series filter. Each input time series is ranked with an aligner. The filter will
    /// allow up to num_time_series time series to pass through it, selecting them based on the relative ranking.For
    /// example, if ranking_method is METHOD_MEAN,direction is BOTTOM, and num_time_series is 3, then the 3 times series
    /// with the lowest mean values will pass through the filter.
    /// </summary>
    public class PickTimeSeriesFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How to use the ranking to select time series that pass through the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>How many time series to allow to pass through the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTimeSeries")]
        public virtual System.Nullable<int> NumTimeSeries { get; set; }

        /// <summary>
        /// ranking_method is applied to each time series independently to produce the value which will be used to
        /// compare the time series to other time series.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankingMethod")]
        public virtual string RankingMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a query to build the numerator or denominator of a TimeSeriesFilterRatio.</summary>
    public class RatioPart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default, the raw time series data is returned. Use this field to combine multiple time series for
        /// different views of the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregation")]
        public virtual Aggregation Aggregation { get; set; }

        /// <summary>
        /// Required. The monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) that identifies the
        /// metric types, resources, and projects to query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the layout properties and content for a row.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relative weight of this row. The row weight is used to adjust the height of rows on the screen (relative
        /// to peers). Greater the weight, greater the height of the row on the screen. If omitted, a value of 1 is used
        /// while rendering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<long> Weight { get; set; }

        /// <summary>The display widgets arranged horizontally in this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widgets")]
        public virtual System.Collections.Generic.IList<Widget> Widgets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A simplified layout that divides the available space into rows and arranges a set of widgets horizontally in
    /// each row.
    /// </summary>
    public class RowLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The rows of content to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A widget showing the latest value of a metric, and how this value relates to one or more thresholds.
    /// </summary>
    public class Scorecard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Will cause the scorecard to show a gauge chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gaugeView")]
        public virtual GaugeView GaugeView { get; set; }

        /// <summary>Will cause the scorecard to show a spark chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkChartView")]
        public virtual SparkChartView SparkChartView { get; set; }

        /// <summary>
        /// The thresholds used to determine the state of the scorecard given the time series' current value. For an
        /// actual value x, the scorecard is in a danger state if x is less than or equal to a danger threshold that
        /// triggers below, or greater than or equal to a danger threshold that triggers above. Similarly, if x is
        /// above/below a warning threshold that triggers above/below, then the scorecard is in a warning state - unless
        /// x also puts it in a danger state. (Danger trumps warning.)As an example, consider a scorecard with the
        /// following four thresholds: { value: 90, category: 'DANGER', trigger: 'ABOVE', }, { value: 70, category:
        /// 'WARNING', trigger: 'ABOVE', }, { value: 10, category: 'DANGER', trigger: 'BELOW', }, { value: 20, category:
        /// 'WARNING', trigger: 'BELOW', }Then: values less than or equal to 10 would put the scorecard in a DANGER
        /// state, values greater than 10 but less than or equal to 20 a WARNING state, values strictly between 20 and
        /// 70 an OK state, values greater than or equal to 70 but less than 90 a WARNING state, and values greater than
        /// or equal to 90 a DANGER state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholds")]
        public virtual System.Collections.Generic.IList<Threshold> Thresholds { get; set; }

        /// <summary>Required. Fields for querying time series data from the Stackdriver metrics API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesQuery")]
        public virtual TimeSeriesQuery TimeSeriesQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SourceContext represents information about the source of a protobuf element, like the file in which it is
    /// defined.
    /// </summary>
    public class SourceContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The path-qualified name of the .proto file that contained the associated protobuf element. For example:
        /// "google/protobuf/source_context.proto".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The context of a span. This is attached to an Exemplar in Distribution values during aggregation.It contains the
    /// name of a span with format: projects/[PROJECT_ID_OR_NUMBER]/traces/[TRACE_ID]/spans/[SPAN_ID]
    /// </summary>
    public class SpanContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the span. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/traces/[TRACE_ID]/spans/[SPAN_ID] [TRACE_ID] is a unique identifier for a
        /// trace within a project; it is a 32-character hexadecimal encoding of a 16-byte array.[SPAN_ID] is a unique
        /// identifier for a span within a trace; it is a 16-character hexadecimal encoding of an 8-byte array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanName")]
        public virtual string SpanName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A sparkChart is a small chart suitable for inclusion in a table-cell or inline in text. This message contains
    /// the configuration for a sparkChart to show up on a Scorecard, showing recent trends of the scorecard's
    /// timeseries.
    /// </summary>
    public class SparkChartView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The lower bound on data point frequency in the chart implemented by specifying the minimum alignment period
        /// to use in a time series query. For example, if the data is published once every 10 minutes it would not make
        /// sense to fetch and align data at one minute intervals. This field is optional and exists only as a hint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAlignmentPeriod")]
        public virtual object MinAlignmentPeriod { get; set; }

        /// <summary>Required. The type of sparkchart to show in this chartView.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sparkChartType")]
        public virtual string SparkChartType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter that ranks streams based on their statistical relation to other streams in a request. Note: This field
    /// is deprecated and completely ignored by the API.
    /// </summary>
    public class StatisticalTimeSeriesFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many time series to output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTimeSeries")]
        public virtual System.Nullable<int> NumTimeSeries { get; set; }

        /// <summary>
        /// rankingMethod is applied to a set of time series, and then the produced value for each individual time
        /// series is used to compare a given time series to others. These are methods that cannot be applied
        /// stream-by-stream, but rather require the full context of a request to evaluate time series.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rankingMethod")]
        public virtual string RankingMethod { get; set; }

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

    /// <summary>A widget that displays textual content.</summary>
    public class Text : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text content to be displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>How the text content is formatted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a threshold for categorizing time series values.</summary>
    public class Threshold : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state color for this threshold. Color is not allowed in a XyChart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual string Color { get; set; }

        /// <summary>The direction for the current threshold. Direction is not allowed in a XyChart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>A label for the threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The value of the threshold. The value should be defined in the native scale of the metric.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single tile in the mosaic. The placement and size of the tile are configurable.</summary>
    public class Tile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The height of the tile, measured in grid blocks. Tiles must have a minimum height of 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>The informational widget contained in the tile. For example an XyChart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widget")]
        public virtual Widget Widget { get; set; }

        /// <summary>The width of the tile, measured in grid blocks. Tiles must have a minimum width of 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>
        /// The zero-indexed position of the tile in grid blocks relative to the left edge of the grid. Tiles must be
        /// contained within the specified number of columns. x_pos cannot be negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xPos")]
        public virtual System.Nullable<int> XPos { get; set; }

        /// <summary>
        /// The zero-indexed position of the tile in grid blocks relative to the top edge of the grid. y_pos cannot be
        /// negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yPos")]
        public virtual System.Nullable<int> YPos { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter that defines a subset of time series data that is displayed in a widget. Time series data is fetched
    /// using the ListTimeSeries (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list)
    /// method.
    /// </summary>
    public class TimeSeriesFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default, the raw time series data is returned. Use this field to combine multiple time series for
        /// different views of the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregation")]
        public virtual Aggregation Aggregation { get; set; }

        /// <summary>
        /// Required. The monitoring filter (https://cloud.google.com/monitoring/api/v3/filters) that identifies the
        /// metric types, resources, and projects to query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>Ranking based time series filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickTimeSeriesFilter")]
        public virtual PickTimeSeriesFilter PickTimeSeriesFilter { get; set; }

        /// <summary>Apply a second aggregation after aggregation is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryAggregation")]
        public virtual Aggregation SecondaryAggregation { get; set; }

        /// <summary>
        /// Statistics based time series filter. Note: This field is deprecated and completely ignored by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statisticalTimeSeriesFilter")]
        public virtual StatisticalTimeSeriesFilter StatisticalTimeSeriesFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A pair of time series filters that define a ratio computation. The output time series is the pair-wise division
    /// of each aligned element from the numerator and denominator time series.
    /// </summary>
    public class TimeSeriesFilterRatio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The denominator of the ratio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denominator")]
        public virtual RatioPart Denominator { get; set; }

        /// <summary>The numerator of the ratio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numerator")]
        public virtual RatioPart Numerator { get; set; }

        /// <summary>Ranking based time series filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickTimeSeriesFilter")]
        public virtual PickTimeSeriesFilter PickTimeSeriesFilter { get; set; }

        /// <summary>Apply a second aggregation after the ratio is computed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryAggregation")]
        public virtual Aggregation SecondaryAggregation { get; set; }

        /// <summary>
        /// Statistics based time series filter. Note: This field is deprecated and completely ignored by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statisticalTimeSeriesFilter")]
        public virtual StatisticalTimeSeriesFilter StatisticalTimeSeriesFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// TimeSeriesQuery collects the set of supported methods for querying time series data from the Stackdriver metrics
    /// API.
    /// </summary>
    public class TimeSeriesQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Filter parameters to fetch time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesFilter")]
        public virtual TimeSeriesFilter TimeSeriesFilter { get; set; }

        /// <summary>Parameters to fetch a ratio between two time series filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesFilterRatio")]
        public virtual TimeSeriesFilterRatio TimeSeriesFilterRatio { get; set; }

        /// <summary>A query used to fetch time series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeriesQueryLanguage")]
        public virtual string TimeSeriesQueryLanguage { get; set; }

        /// <summary>
        /// The unit of data contained in fetched time series. If non-empty, this unit will override any unit that
        /// accompanies fetched data. The format is the same as the unit
        /// (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors) field in
        /// MetricDescriptor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unitOverride")]
        public virtual string UnitOverride { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protocol buffer message type.</summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<Field> Fields { get; set; }

        /// <summary>The fully qualified message name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The list of types appearing in oneof definitions in this type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneofs")]
        public virtual System.Collections.Generic.IList<string> Oneofs { get; set; }

        /// <summary>The protocol buffer options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>The source context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceContext")]
        public virtual SourceContext SourceContext { get; set; }

        /// <summary>The source syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntax")]
        public virtual string Syntax { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Widget contains a single dashboard component and configuration of how to present the component in the dashboard.
    /// </summary>
    public class Widget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A chart of alert policy data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertChart")]
        public virtual AlertChart AlertChart { get; set; }

        /// <summary>A blank space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blank")]
        public virtual Empty Blank { get; set; }

        /// <summary>A scorecard summarizing time series data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scorecard")]
        public virtual Scorecard Scorecard { get; set; }

        /// <summary>A raw string or markdown displaying textual content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual Text Text { get; set; }

        /// <summary>Optional. The title of the widget.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>A chart of time series data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xyChart")]
        public virtual XyChart XyChart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A chart that displays data on a 2D (X and Y axes) plane.</summary>
    public class XyChart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display options for the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartOptions")]
        public virtual ChartOptions ChartOptions { get; set; }

        /// <summary>Required. The data displayed in this chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSets")]
        public virtual System.Collections.Generic.IList<DataSet> DataSets { get; set; }

        /// <summary>Threshold lines drawn horizontally across the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thresholds")]
        public virtual System.Collections.Generic.IList<Threshold> Thresholds { get; set; }

        /// <summary>
        /// The duration used to display a comparison chart. A comparison chart simultaneously shows values from two
        /// similar-length time periods (e.g., week-over-week metrics). The duration must be positive, and it can only
        /// be applied to charts with data sets of LINE plot type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeshiftDuration")]
        public virtual object TimeshiftDuration { get; set; }

        /// <summary>The properties applied to the X axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("xAxis")]
        public virtual Axis XAxis { get; set; }

        /// <summary>The properties applied to the Y axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yAxis")]
        public virtual Axis YAxis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
