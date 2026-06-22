// Copyright 2026 Google LLC
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

namespace Google.Apis.DatabaseCenter.v1beta
{
    /// <summary>The DatabaseCenter Service.</summary>
    public class DatabaseCenterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DatabaseCenterService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DatabaseCenterService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            V1beta = new V1betaResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://databasecenter.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://databasecenter.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "databasecenter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Database Center API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Database Center API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the V1beta resource.</summary>
        public virtual V1betaResource V1beta { get; }
    }

    /// <summary>A base abstract class for DatabaseCenter requests.</summary>
    public abstract class DatabaseCenterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DatabaseCenterBaseServiceRequest instance.</summary>
        protected DatabaseCenterBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DatabaseCenter parameter list.</summary>
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
        }

        /// <summary>AggregateQueryStats provides database resource query execution statistics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
        /// within the `parent`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
        /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g., "folders/1234567") *
        /// organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual AggregateQueryStatsRequest AggregateQueryStats(Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest body, string parent)
        {
            return new AggregateQueryStatsRequest(this.service, body, parent);
        }

        /// <summary>AggregateQueryStats provides database resource query execution statistics.</summary>
        public class AggregateQueryStatsRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsResponse>
        {
            /// <summary>Constructs a new AggregateQueryStats request.</summary>
            public AggregateQueryStatsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
            /// within the `parent`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
            /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g.,
            /// "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "aggregateQueryStats";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+parent}:aggregateQueryStats";

            /// <summary>Initializes AggregateQueryStats parameter list.</summary>
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
        }

        /// <summary>AggregateQueryStats provides database resource query execution statistics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
        /// within the `parent`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
        /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g., "folders/1234567") *
        /// organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual AggregateQueryStatsRequest AggregateQueryStats(Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest body, string parent)
        {
            return new AggregateQueryStatsRequest(this.service, body, parent);
        }

        /// <summary>AggregateQueryStats provides database resource query execution statistics.</summary>
        public class AggregateQueryStatsRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsResponse>
        {
            /// <summary>Constructs a new AggregateQueryStats request.</summary>
            public AggregateQueryStatsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
            /// within the `parent`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
            /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g.,
            /// "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "aggregateQueryStats";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+parent}:aggregateQueryStats";

            /// <summary>Initializes AggregateQueryStats parameter list.</summary>
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
        }

        /// <summary>AggregateQueryStats provides database resource query execution statistics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
        /// within the `parent`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
        /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g., "folders/1234567") *
        /// organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </param>
        public virtual AggregateQueryStatsRequest AggregateQueryStats(Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest body, string parent)
        {
            return new AggregateQueryStatsRequest(this.service, body, parent);
        }

        /// <summary>AggregateQueryStats provides database resource query execution statistics.</summary>
        public class AggregateQueryStatsRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsResponse>
        {
            /// <summary>Constructs a new AggregateQueryStats request.</summary>
            public AggregateQueryStatsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
            /// within the `parent`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
            /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g.,
            /// "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DatabaseCenter.v1beta.Data.AggregateQueryStatsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "aggregateQueryStats";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+parent}:aggregateQueryStats";

            /// <summary>Initializes AggregateQueryStats parameter list.</summary>
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
    }

    /// <summary>The "v1beta" collection of methods.</summary>
    public class V1betaResource
    {
        private const string Resource = "v1beta";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1betaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>AggregateFleet provides statistics about the fleet grouped by various fields.</summary>
        public virtual AggregateFleetRequest AggregateFleet()
        {
            return new AggregateFleetRequest(this.service);
        }

        /// <summary>AggregateFleet provides statistics about the fleet grouped by various fields.</summary>
        public class AggregateFleetRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.AggregateFleetResponse>
        {
            /// <summary>Constructs a new AggregateFleet request.</summary>
            public AggregateFleetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself
            /// or a year and month where the day isn't significant.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("baselineDate.day", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> BaselineDateDay { get; set; }

            /// <summary>
            /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("baselineDate.month", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> BaselineDateMonth { get; set; }

            /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
            [Google.Apis.Util.RequestParameterAttribute("baselineDate.year", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> BaselineDateYear { get; set; }

            /// <summary>
            /// Optional. The expression to filter resources. Supported fields are: `full_resource_name`,
            /// `resource_type`, `container`, `product.type`, `product.engine`, `product.version`, `location`, `labels`,
            /// `issues`, fields of availability_info, data_protection_info, 'resource_name', etc. The expression is a
            /// list of zero or more restrictions combined via logical operators `AND` and `OR`. When `AND` and `OR` are
            /// both used in the expression, parentheses must be appropriately used to group the combinations. Example:
            /// `location="us-east1"` Example: `container="projects/123" OR container="projects/456"` Example:
            /// `(container="projects/123" OR container="projects/456") AND location="us-east1"`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. A field that statistics are grouped by. Valid values are any combination of the following: *
            /// container * product.type * product.engine * product.version * location * sub_resource_type *
            /// management_type * tag.key * tag.value * tag.source * tag.inherited * label.key * label.value *
            /// label.source * has_maintenance_schedule * has_deny_maintenance_schedules Comma separated list.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupBy { get; set; }

            /// <summary>
            /// Optional. Valid values to order by are: * resource_groups_count * resources_count * and all fields
            /// supported by `group_by` The default order is ascending. Add "DESC" after the field name to indicate
            /// descending order. Add "ASC" after the field name to indicate ascending order. It supports ordering using
            /// multiple fields. For example: `order_by = "resource_groups_count"` sorts response in ascending order
            /// `order_by = "resource_groups_count DESC"` sorts response in descending order `order_by = "product.type,
            /// product.version DESC, location"` orders by type in ascending order, version in descending order and
            /// location in ascending order
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. If unspecified, at most 50 items will be returned. The maximum value is 1000; values above
            /// 1000 will be coerced to 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `AggregateFleet` call. Provide this to retrieve the
            /// subsequent page. All other parameters should match the parameters in the call that provided the page
            /// token except for page_size which can be different.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
            /// within the `scope`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
            /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g.,
            /// "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "aggregateFleet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta:aggregateFleet";

            /// <summary>Initializes AggregateFleet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("baselineDate.day", new Google.Apis.Discovery.Parameter
                {
                    Name = "baselineDate.day",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("baselineDate.month", new Google.Apis.Discovery.Parameter
                {
                    Name = "baselineDate.month",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("baselineDate.year", new Google.Apis.Discovery.Parameter
                {
                    Name = "baselineDate.year",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("groupBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupBy",
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>AggregateIssueStats provides database resource issues statistics.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual AggregateIssueStatsRequest AggregateIssueStats(Google.Apis.DatabaseCenter.v1beta.Data.AggregateIssueStatsRequest body)
        {
            return new AggregateIssueStatsRequest(this.service, body);
        }

        /// <summary>AggregateIssueStats provides database resource issues statistics.</summary>
        public class AggregateIssueStatsRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.AggregateIssueStatsResponse>
        {
            /// <summary>Constructs a new AggregateIssueStats request.</summary>
            public AggregateIssueStatsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseCenter.v1beta.Data.AggregateIssueStatsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DatabaseCenter.v1beta.Data.AggregateIssueStatsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "aggregateIssueStats";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta:aggregateIssueStats";

            /// <summary>Initializes AggregateIssueStats parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>QueryDatabaseResourceGroups returns paginated results of database groups.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryDatabaseResourceGroupsRequest QueryDatabaseResourceGroups(Google.Apis.DatabaseCenter.v1beta.Data.QueryDatabaseResourceGroupsRequest body)
        {
            return new QueryDatabaseResourceGroupsRequest(this.service, body);
        }

        /// <summary>QueryDatabaseResourceGroups returns paginated results of database groups.</summary>
        public class QueryDatabaseResourceGroupsRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.QueryDatabaseResourceGroupsResponse>
        {
            /// <summary>Constructs a new QueryDatabaseResourceGroups request.</summary>
            public QueryDatabaseResourceGroupsRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseCenter.v1beta.Data.QueryDatabaseResourceGroupsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DatabaseCenter.v1beta.Data.QueryDatabaseResourceGroupsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryDatabaseResourceGroups";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta:queryDatabaseResourceGroups";

            /// <summary>Initializes QueryDatabaseResourceGroups parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// QueryIssues provides a list of issues and recommendations that a user has access to and that are within the
        /// requested scope.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual QueryIssuesRequest QueryIssues(Google.Apis.DatabaseCenter.v1beta.Data.QueryIssuesRequest body)
        {
            return new QueryIssuesRequest(this.service, body);
        }

        /// <summary>
        /// QueryIssues provides a list of issues and recommendations that a user has access to and that are within the
        /// requested scope.
        /// </summary>
        public class QueryIssuesRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.QueryIssuesResponse>
        {
            /// <summary>Constructs a new QueryIssues request.</summary>
            public QueryIssuesRequest(Google.Apis.Services.IClientService service, Google.Apis.DatabaseCenter.v1beta.Data.QueryIssuesRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.DatabaseCenter.v1beta.Data.QueryIssuesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryIssues";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta:queryIssues";

            /// <summary>Initializes QueryIssues parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// QueryProducts provides a list of all possible products which can be used to filter database resources.
        /// </summary>
        public virtual QueryProductsRequest QueryProducts()
        {
            return new QueryProductsRequest(this.service);
        }

        /// <summary>
        /// QueryProducts provides a list of all possible products which can be used to filter database resources.
        /// </summary>
        public class QueryProductsRequest : DatabaseCenterBaseServiceRequest<Google.Apis.DatabaseCenter.v1beta.Data.QueryProductsResponse>
        {
            /// <summary>Constructs a new QueryProducts request.</summary>
            public QueryProductsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. If unspecified, at most 50 products will be returned. The maximum value is 1000; values above
            /// 1000 will be coerced to 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A page token, received from a previous `ListLocations` call. Provide this to retrieve the
            /// subsequent page. All other parameters except page size should match the call that provided the page page
            /// token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. Parent can be a project, a folder, or an organization. The allowed values are: *
            /// projects/{PROJECT_ID}/locations/{LOCATION} (e.g.,"projects/foo-bar/locations/us-central1") *
            /// projects/{PROJECT_NUMBER}/locations/{LOCATION} (e.g.,"projects/12345678/locations/us-central1") *
            /// folders/{FOLDER_NUMBER}/locations/{LOCATION} (e.g.,"folders/1234567/locations/us-central1") *
            /// organizations/{ORGANIZATION_NUMBER}/locations/{LOCATION}
            /// (e.g.,"organizations/123456/locations/us-central1") * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
            /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g.,
            /// "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "queryProducts";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta:queryProducts";

            /// <summary>Initializes QueryProducts parameter list.</summary>
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.DatabaseCenter.v1beta.Data
{
    /// <summary>Details related to signal.</summary>
    public class AdditionalDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Automated backup policy information applies to signals with type SIGNAL_TYPE_NO_AUTOMATED_BACKUP_POLICY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automatedBackupPolicyInfo")]
        public virtual AutomatedBackupPolicyInfo AutomatedBackupPolicyInfo { get; set; }

        /// <summary>
        /// Backup run information applies to signals with types SIGNAL_TYPE_LAST_BACKUP_FAILED and
        /// SIGNAL_TYPE_LAST_BACKUP_OLD.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupRunInfo")]
        public virtual BackupRunInfo BackupRunInfo { get; set; }

        /// <summary>
        /// Deletion protection information applies to signals with type SIGNAL_TYPE_NO_DELETION_PROTECTION
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtectionInfo")]
        public virtual DeletionProtectionInfo DeletionProtectionInfo { get; set; }

        /// <summary>Inefficient query information applies to signals with type SIGNAL_TYPE_INEFFICIENT_QUERY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inefficientQueryInfo")]
        public virtual InefficientQueryInfo InefficientQueryInfo { get; set; }

        /// <summary>
        /// Maintenance recommendation information applies to signals with type
        /// SIGNAL_TYPE_RECOMMENDED_MAINTENANCE_POLICIES.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceRecommendationInfo")]
        public virtual MaintenanceRecommendationInfo MaintenanceRecommendationInfo { get; set; }

        /// <summary>
        /// Outdated minor version information applies to signals with type SIGNAL_TYPE_OUTDATED_MINOR_VERSION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outdatedMinorVersionInfo")]
        public virtual OutdatedMinorVersionInfo OutdatedMinorVersionInfo { get; set; }

        /// <summary>Recommendation information applies to recommendations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendationInfo")]
        public virtual RecommendationInfo RecommendationInfo { get; set; }

        /// <summary>
        /// Resource suspension information applies to signals with type SIGNAL_TYPE_RESOURCE_SUSPENDED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSuspensionInfo")]
        public virtual ResourceSuspensionInfo ResourceSuspensionInfo { get; set; }

        /// <summary>SCC information applies to SCC signals.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sccInfo")]
        public virtual SCCInfo SccInfo { get; set; }

        /// <summary>
        /// Short backup retention information applies to signals with type SIGNAL_TYPE_SHORT_BACKUP_RETENTION.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortBackupRetentionInfo")]
        public virtual RetentionSettingsInfo ShortBackupRetentionInfo { get; set; }

        private string _signalEventTimeRaw;

        private object _signalEventTime;

        /// <summary>Event time when signal was recorded by source service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalEventTime")]
        public virtual string SignalEventTimeRaw
        {
            get => _signalEventTimeRaw;
            set
            {
                _signalEventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _signalEventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SignalEventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SignalEventTimeDateTimeOffset instead.")]
        public virtual object SignalEventTime
        {
            get => _signalEventTime;
            set
            {
                _signalEventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _signalEventTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SignalEventTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SignalEventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SignalEventTimeRaw);
            set => SignalEventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Where the signal is coming from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalSource")]
        public virtual string SignalSource { get; set; }

        /// <summary>Type of the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Affiliation information of a resource</summary>
    public class Affiliation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Full resource name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Optional. Multiple lineages can be created from a resource. For example, a resource can be replicated to
        /// multiple target resources. In this case, there will be multiple lineages for the resource, one for each
        /// target resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineages")]
        public virtual System.Collections.Generic.IList<Lineage> Lineages { get; set; }

        /// <summary>Optional. resource id of affiliated resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message to aggregate a fleet by some group by fields.</summary>
    public class AggregateFleetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Count of all resource groups in the fleet. This includes counts from all pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupsTotalCount")]
        public virtual System.Nullable<int> ResourceGroupsTotalCount { get; set; }

        /// <summary>Count of all resources in the fleet. This includes counts from all pages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTotalCount")]
        public virtual System.Nullable<int> ResourceTotalCount { get; set; }

        /// <summary>Represents a row grouped by the fields in the input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<AggregateFleetRow> Rows { get; set; }

        /// <summary>Output only. The total number of rows in the entire list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<long> TotalSize { get; set; }

        /// <summary>Unordered list. List of unreachable regions from where data could not be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Individual row grouped by a particular dimension.</summary>
    public class AggregateFleetRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Delta counts and details of resources which were added to/deleted from fleet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaDetails")]
        public virtual DeltaDetails DeltaDetails { get; set; }

        /// <summary>Group by dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual System.Collections.Generic.IList<Dimension> Dimension { get; set; }

        /// <summary>Number of resource groups that have a particular dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupsCount")]
        public virtual System.Nullable<int> ResourceGroupsCount { get; set; }

        /// <summary>Number of resources that have a particular dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesCount")]
        public virtual System.Nullable<int> ResourcesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AggregateIssueStatsRequest represents the input to the AggregateIssueStats method.</summary>
    public class AggregateIssueStatsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The baseline date w.r.t. which the delta counts are calculated. If not set, delta counts are not
        /// included in the response and the response indicates the current state of the fleet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineDate")]
        public virtual Date BaselineDate { get; set; }

        /// <summary>
        /// Optional. The expression to filter resources. Supported fields are: `full_resource_name`, `resource_type`,
        /// `container`, `product.type`, `product.engine`, `product.version`, `location`, `labels`, `issues`, fields of
        /// availability_info, data_protection_info,'resource_name', etc. The expression is a list of zero or more
        /// restrictions combined via logical operators `AND` and `OR`. When `AND` and `OR` are both used in the
        /// expression, parentheses must be appropriately used to group the combinations. Example: `location="us-east1"`
        /// Example: `container="projects/123" OR container="projects/456"` Example: `(container="projects/123" OR
        /// container="projects/456") AND location="us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
        /// within the `scope`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
        /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g., "folders/1234567") *
        /// organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Optional. Lists of signal types that are issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalTypeGroups")]
        public virtual System.Collections.Generic.IList<SignalTypeGroup> SignalTypeGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response message containing one of more group of relevant health issues for database resources.
    /// </summary>
    public class AggregateIssueStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of issue group stats where each group contains stats for resources having a particular combination of
        /// relevant issues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueGroupStats")]
        public virtual System.Collections.Generic.IList<IssueGroupStats> IssueGroupStats { get; set; }

        /// <summary>Total count of the resource filtered in based on the user given filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResourceGroupsCount")]
        public virtual System.Nullable<int> TotalResourceGroupsCount { get; set; }

        /// <summary>Total count of the resources filtered in based on the user given filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResourcesCount")]
        public virtual System.Nullable<int> TotalResourcesCount { get; set; }

        /// <summary>Unordered list. List of unreachable regions from where data could not be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>AggregateQueryStatsRequest represents the input to the AggregateQueryStats method.</summary>
    public class AggregateQueryStatsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The expression to filter resources. Supported fields are: `full_resource_name`, `resource_type`,
        /// `container`, `product.type`, `product.engine`, `product.version`, `location`, `labels`, `issues`, fields of
        /// availability_info, data_protection_info,'resource_name', etc. The expression is a list of zero or more
        /// restrictions combined via logical operators `AND` and `OR`. When `AND` and `OR` are both used in the
        /// expression, parentheses must be appropriately used to group the combinations. Example: `location="us-east1"`
        /// Example: `container="projects/123" OR container="projects/456"` Example: `(container="projects/123" OR
        /// container="projects/456") AND location="us-east1"` Additional specific fields for query stats are:
        /// `metric_window`, `query_hash`, `normalized_query`. Example: `metric_window="LAST_ONE_DAY"` (Possible values
        /// for `metric_window` are: `LAST_ONE_DAY`, `LAST_ONE_WEEK`, `LAST_TWO_WEEKS`) Example: `query_hash="12345678"`
        /// Example: `normalized_query="SELECT * FROM table"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. The expression to order the results by. Example: `order_by="execution_count"` Example:
        /// `order_by="execution_count desc"` Supported order by fields are `execution_count`, `rows_processed`,
        /// `total_cpu_time`, `avg_cpu_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Optional. If unspecified, at most 100 query stats will be returned. The maximum value is 1000; values above
        /// 1000 will be coerced to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token, received from a previous `AggregateQueryStatsRequest` call. Provide this to retrieve
        /// the subsequent page. All parameters except page_token should match the parameters in the call that provided
        /// the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message containing relevant query stats for database resources.</summary>
    public class AggregateQueryStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// List of query stats where each group contains stats for resources having a particular combination of
        /// relevant query stats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryStats")]
        public virtual System.Collections.Generic.IList<QueryStatsInfo> QueryStats { get; set; }

        /// <summary>Unordered list. List of unreachable regions from where data could not be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Automated backup policy signal info</summary>
    public class AutomatedBackupPolicyInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Is automated policy enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnabled")]
        public virtual System.Nullable<bool> IsEnabled { get; set; }

        /// <summary>Optional. Sub resource details associated with the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subResource")]
        public virtual SubResource SubResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>BackupDRConfig to capture the backup and disaster recovery details of database resource.</summary>
    public class BackupDRConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates if the resource is managed by BackupDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupdrManaged")]
        public virtual System.Nullable<bool> BackupdrManaged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about latest backup run state for a database resource.</summary>
    public class BackupRunInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the backup operation completed.</summary>
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

        /// <summary>Additional information about the error encountered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// Optional. OperationErrorType to expose specific error when backup operation of database resource failed,
        /// that is state is FAILED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationErrorType")]
        public virtual string OperationErrorType { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The time the backup operation started.</summary>
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

        /// <summary>Output only. The state of this run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Sub resource details associated with the backup run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subResource")]
        public virtual SubResource SubResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DatabaseResource represents every individually configured database unit representing compute and/or storage.
    /// </summary>
    public class DatabaseResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Affiliation details of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affiliations")]
        public virtual System.Collections.Generic.IList<Affiliation> Affiliations { get; set; }

        /// <summary>Optional. Backup and disaster recovery details for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupdrConfig")]
        public virtual BackupDRConfig BackupdrConfig { get; set; }

        /// <summary>List of children associated with a database group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childResources")]
        public virtual System.Collections.Generic.IList<DatabaseResource> ChildResources { get; set; }

        /// <summary>
        /// Specifies where the resource is created. For Google Cloud resources, it is the full name of the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>The edition of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>
        /// The full resource name, based on CAIS resource name format
        /// https://cloud.google.com/asset-inventory/docs/resource-name-format Example:
        /// `//cloudsql.googleapis.com/projects/project-number/instances/mysql-1`
        /// `//cloudsql.googleapis.com/projects/project-number/instances/postgres-1`
        /// `//spanner.googleapis.com/projects/project-number/instances/spanner-instance-1`
        /// `//alloydb.googleapis.com/projects/project-number/locations/us-central1/clusters/c1`
        /// `//alloydb.googleapis.com/projects/project-number/locations/us-central1/clusters/c1/instances/i1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Labels applied on the resource. The requirements for labels assigned to Google Cloud resources may be found
        /// at https://cloud.google.com/resource-manager/docs/labels-overview#requirements
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>
        /// The location of the resources. It supports returning only regional locations in Google Cloud. These are of
        /// the form: "us-central1", "us-east1", etc. See https://cloud.google.com/about/locations for a list of such
        /// regions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Machine configuration like CPU, memory, etc for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineConfig")]
        public virtual MachineConfig MachineConfig { get; set; }

        /// <summary>Optional. The maintenance information of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceInfo")]
        public virtual MaintenanceInfo MaintenanceInfo { get; set; }

        /// <summary>Observable metrics for the resource e.g. CPU utilization, memory utilization, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual Metrics Metrics { get; set; }

        /// <summary>The product this resource represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        /// <summary>The category of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCategory")]
        public virtual string ResourceCategory { get; set; }

        /// <summary>
        /// The name of the resource(The last part of the full resource name). Example: For full resource name -
        /// `//cloudsql.googleapis.com/projects/project-number/instances/mysql-1`, resource name - `mysql-1` For full
        /// resource name - `//cloudsql.googleapis.com/projects/project-number/instances/postgres-1` , resource name -
        /// `postgres-1` Note: In some cases, there might be more than one resource with the same resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// The type of resource defined according to the pattern: {Service Name}/{Type}. Ex:
        /// sqladmin.googleapis.com/Instance alloydb.googleapis.com/Cluster alloydb.googleapis.com/Instance
        /// spanner.googleapis.com/Instance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>
        /// The list of signal groups and count of issues related to the resource. Only those signals which have been
        /// requested would be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalGroups")]
        public virtual System.Collections.Generic.IList<SignalGroup> SignalGroups { get; set; }

        /// <summary>Subtype of the resource specified at creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subResourceType")]
        public virtual string SubResourceType { get; set; }

        /// <summary>
        /// Tags applied on the resource. The requirements for tags assigned to Google Cloud resources may be found at
        /// https://cloud.google.com/resource-manager/docs/tags/tags-overview
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DatabaseResourceGroup represents all resources that serve a common data set. It is considered notionally as a
    /// single entity, powered by any number of units of compute and storage.
    /// </summary>
    public class DatabaseResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A database resource that serves as a root of the group of database resources. It is repeated just in case we
        /// have the concept of multiple roots in the future, however, it will only be populated with a single value for
        /// now.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootResources")]
        public virtual System.Collections.Generic.IList<DatabaseResource> RootResources { get; set; }

        /// <summary>
        /// The filtered signal groups and the count of issues associated with the resources that have been filtered in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalGroups")]
        public virtual System.Collections.Generic.IList<IssueCount> SignalGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>DatabaseResource and Issue associated with it.</summary>
    public class DatabaseResourceIssue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual DatabaseResource Resource { get; set; }

        /// <summary>Signal associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signal")]
        public virtual Signal Signal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletion protection signal info for a database resource.</summary>
    public class DeletionProtectionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Is deletion protection enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionProtectionEnabled")]
        public virtual System.Nullable<bool> DeletionProtectionEnabled { get; set; }

        /// <summary>Optional. Sub resource details associated with the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subResource")]
        public virtual SubResource SubResource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Captures the details of items that have increased or decreased in some bucket when compared to some point in
    /// history. It is currently used to capture the delta of resources that have been added or removed in the fleet as
    /// well as to capture the resources that have a change in Issue/Signal status.
    /// </summary>
    public class DeltaDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details of resources that have decreased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decreasedResources")]
        public virtual System.Collections.Generic.IList<ResourceDetails> DecreasedResources { get; set; }

        /// <summary>Details of resources that have increased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("increasedResources")]
        public virtual System.Collections.Generic.IList<ResourceDetails> IncreasedResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Dimension used to aggregate the fleet.</summary>
    public class Dimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies where the resource is created. For Google Cloud resources, it is the full name of the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>The edition of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edition")]
        public virtual string Edition { get; set; }

        /// <summary>Whether the resource has deny maintenance schedules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasDenyMaintenanceSchedules")]
        public virtual System.Nullable<bool> HasDenyMaintenanceSchedules { get; set; }

        /// <summary>Whether the resource has a maintenance schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasMaintenanceSchedule")]
        public virtual System.Nullable<bool> HasMaintenanceSchedule { get; set; }

        /// <summary>Label key of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelKey")]
        public virtual string LabelKey { get; set; }

        /// <summary>Label source of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelSource")]
        public virtual string LabelSource { get; set; }

        /// <summary>Label value of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelValue")]
        public virtual string LabelValue { get; set; }

        /// <summary>
        /// The location of the resources. It supports returning only regional locations in Google Cloud.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The management type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementType")]
        public virtual string ManagementType { get; set; }

        /// <summary>Engine refers to underlying database binary running in an instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productEngine")]
        public virtual string ProductEngine { get; set; }

        /// <summary>Type to identify a product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productType")]
        public virtual string ProductType { get; set; }

        /// <summary>Version of the underlying database engine</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productVersion")]
        public virtual string ProductVersion { get; set; }

        /// <summary>The category of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCategory")]
        public virtual string ResourceCategory { get; set; }

        /// <summary>
        /// The type of resource defined according to the pattern: {Service Name}/{Type}. Ex:
        /// sqladmin.googleapis.com/Instance alloydb.googleapis.com/Cluster alloydb.googleapis.com/Instance
        /// spanner.googleapis.com/Instance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Subtype of the resource specified at creation time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subResourceType")]
        public virtual string SubResourceType { get; set; }

        /// <summary>Tag inheritance value of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagInherited")]
        public virtual System.Nullable<bool> TagInherited { get; set; }

        /// <summary>Tag key of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagKey")]
        public virtual string TagKey { get; set; }

        /// <summary>Tag source of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagSource")]
        public virtual string TagSource { get; set; }

        /// <summary>Tag value of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValue")]
        public virtual string TagValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about inefficient query signal info for a database resource.</summary>
    public class InefficientQueryInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the database where index is required. For example, "db1", which is the name of the database present
        /// in the instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual string Database { get; set; }

        /// <summary>Count of queries to be impacted if index is applied</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impactedQueriesCount")]
        public virtual System.Nullable<long> ImpactedQueriesCount { get; set; }

        /// <summary>
        /// SQL statement of the index. Based on the ddl type, this will be either CREATE INDEX or DROP INDEX.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sqlIndexStatement")]
        public virtual string SqlIndexStatement { get; set; }

        /// <summary>Cost of additional disk usage in bytes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageCostBytes")]
        public virtual System.Nullable<long> StorageCostBytes { get; set; }

        /// <summary>Name of the table where index is required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Count of issues for a group of signals.</summary>
    public class IssueCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Title of a signal group corresponding to the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The count of the number of issues associated with those resources that are explicitly filtered in by the
        /// filters present in the request. A signal is an issue when its SignalStatus field is set to
        /// SIGNAL_STATUS_ISSUE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueCount")]
        public virtual System.Nullable<int> IssueCountValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// IssueGroupStats refers to stats for a particulare combination of relevant health issues of database resources.
    /// </summary>
    public class IssueGroupStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Database resource level health card name. This will corresponds to one of the requested input group names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The number of resource groups from the total groups as defined above that are healthy with respect to all of
        /// the specified issues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthyResourceGroupsCount")]
        public virtual System.Nullable<int> HealthyResourceGroupsCount { get; set; }

        /// <summary>
        /// The number of resources from the total defined above in field total_resources_count that are healthy with
        /// respect to all of the specified issues.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthyResourcesCount")]
        public virtual System.Nullable<int> HealthyResourcesCount { get; set; }

        /// <summary>List of issues stats containing count of resources having particular issue category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueStats")]
        public virtual System.Collections.Generic.IList<IssueStats> IssueStats { get; set; }

        /// <summary>
        /// Total count of the groups of resources returned by the filter that also have one or more resources for which
        /// any of the specified issues are applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroupsCount")]
        public virtual System.Nullable<int> ResourceGroupsCount { get; set; }

        /// <summary>
        /// Total count of resources returned by the filter for which any of the specified issues are applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcesCount")]
        public virtual System.Nullable<int> ResourcesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IssueStats holds stats for a particular signal category.</summary>
    public class IssueStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Delta counts and details of resources for which issue was raised or fixed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaDetails")]
        public virtual DeltaDetails DeltaDetails { get; set; }

        /// <summary>Severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueSeverity")]
        public virtual string IssueSeverity { get; set; }

        /// <summary>Number of resources having issues of a given type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCount")]
        public virtual System.Nullable<int> ResourceCount { get; set; }

        /// <summary>Type of signal which is an issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Label is a key value pair applied to a resource.</summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key part of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The source of the Label. Source is empty if the label is directly attached to the resource and not
        /// inherited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The value part of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// lineage information of the affiliated resources This captures source, target and process which created the
    /// lineage.
    /// </summary>
    public class Lineage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. FQN of process which created the lineage i.e. dataplex, datastream etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processFqn")]
        public virtual string ProcessFqn { get; set; }

        /// <summary>Optional. Type of process which created the lineage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processType")]
        public virtual string ProcessType { get; set; }

        /// <summary>Optional. FQN of source table / column</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceFqn")]
        public virtual string SourceFqn { get; set; }

        /// <summary>Optional. FQN of target table / column</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetFqn")]
        public virtual string TargetFqn { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MachineConfig describes the configuration of a machine specific to a Database Resource.</summary>
    public class MachineConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Baseline slots for BigQuery Reservations. Baseline slots are in increments of 50.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineSlotCount")]
        public virtual System.Nullable<long> BaselineSlotCount { get; set; }

        /// <summary>Optional. Max slots for BigQuery Reservations. Max slots are in increments of 50.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxReservationSlotCount")]
        public virtual System.Nullable<long> MaxReservationSlotCount { get; set; }

        /// <summary>Memory size in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeBytes")]
        public virtual System.Nullable<long> MemorySizeBytes { get; set; }

        /// <summary>Optional. The number of Shards (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardCount")]
        public virtual System.Nullable<int> ShardCount { get; set; }

        /// <summary>Optional. The number of vCPUs (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vcpuCount")]
        public virtual System.Nullable<double> VcpuCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MaintenanceInfo to capture the maintenance details of database resource.</summary>
    public class MaintenanceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The date when the maintenance version was released.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentVersionReleaseDate")]
        public virtual Date CurrentVersionReleaseDate { get; set; }

        /// <summary>Optional. List of Deny maintenance period for the database resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denyMaintenanceSchedules")]
        public virtual System.Collections.Generic.IList<ResourceMaintenanceDenySchedule> DenyMaintenanceSchedules { get; set; }

        /// <summary>Optional. Maintenance window for the database resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSchedule")]
        public virtual ResourceMaintenanceSchedule MaintenanceSchedule { get; set; }

        /// <summary>
        /// Output only. Current Maintenance version of the database resource. Example: "MYSQL_8_0_41.R20250531.01_15"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceVersion")]
        public virtual string MaintenanceVersion { get; set; }

        /// <summary>
        /// Output only. List of possible reasons why the maintenance is not completed. This is an optional field and is
        /// only populated if there are any reasons for failures recorded for the maintenance by DB Center. FAILURE
        /// maintenance status may not always have a failure reason.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("possibleFailureReasons")]
        public virtual System.Collections.Generic.IList<string> PossibleFailureReasons { get; set; }

        /// <summary>
        /// Output only. Previous maintenance version of the database resource. Example: "MYSQL_8_0_41.R20250531.01_15".
        /// This is available once a minor version maintenance is complete on a database resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousMaintenanceVersion")]
        public virtual string PreviousMaintenanceVersion { get; set; }

        /// <summary>
        /// Output only. Resource maintenance state. This is to capture the current state of the maintenance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Upcoming maintenance window for the database resource. This is only populated for an engine, if
        /// upcoming maintenance is scheduled for the resource. This schedule is generated per engine and engine
        /// version, and there is only one upcoming maintenance window at any given time. In case of upcoming
        /// maintenance, the maintenance_state will be set to SCHEDULED first, and then IN_PROGRESS when the maintenance
        /// window starts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upcomingMaintenance")]
        public virtual UpcomingMaintenance UpcomingMaintenance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Info associated with maintenance recommendation.</summary>
    public class MaintenanceRecommendationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of recommended maintenance schedules for the database resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceMaintenanceSchedules")]
        public virtual System.Collections.Generic.IList<ResourceMaintenanceSchedule> ResourceMaintenanceSchedules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>MetricData represents the metric data for a database resource.</summary>
    public class MetricData : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _observationTimeRaw;

        private object _observationTime;

        /// <summary>The time the metric was observed in the metric source service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observationTime")]
        public virtual string ObservationTimeRaw
        {
            get => _observationTimeRaw;
            set
            {
                _observationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _observationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ObservationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ObservationTimeDateTimeOffset instead.")]
        public virtual object ObservationTime
        {
            get => _observationTime;
            set
            {
                _observationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _observationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ObservationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ObservationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ObservationTimeRaw);
            set => ObservationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The value associated with the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual TypedValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics represents the metrics for a database resource.</summary>
    public class Metrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current memory used by the resource in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentMemoryUsedBytes")]
        public virtual MetricData CurrentMemoryUsedBytes { get; set; }

        /// <summary>Current storage used by the resource in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentStorageUsedBytes")]
        public virtual MetricData CurrentStorageUsedBytes { get; set; }

        /// <summary>Number of nodes in instance for spanner or bigtable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeCount")]
        public virtual MetricData NodeCount { get; set; }

        /// <summary>
        /// P95 CPU utilization observed for the resource. The value is a fraction between 0.0 and 1.0 (may momentarily
        /// exceed 1.0 in some cases).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p95CpuUtilization")]
        public virtual MetricData P95CpuUtilization { get; set; }

        /// <summary>
        /// P99 CPU utilization observed for the resource. The value is a fraction between 0.0 and 1.0 (may momentarily
        /// exceed 1.0 in some cases).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p99CpuUtilization")]
        public virtual MetricData P99CpuUtilization { get; set; }

        /// <summary>
        /// Peak memory utilization observed for the resource. The value is a fraction between 0.0 and 1.0 (may
        /// momentarily exceed 1.0 in some cases).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peakMemoryUtilization")]
        public virtual MetricData PeakMemoryUtilization { get; set; }

        /// <summary>Peak number of connections observed for the resource. The value is a positive integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peakNumberConnections")]
        public virtual MetricData PeakNumberConnections { get; set; }

        /// <summary>
        /// Peak storage utilization observed for the resource. The value is a fraction between 0.0 and 1.0 (may
        /// momentarily exceed 1.0 in some cases).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peakStorageUtilization")]
        public virtual MetricData PeakStorageUtilization { get; set; }

        /// <summary>Number of processing units in spanner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processingUnitCount")]
        public virtual MetricData ProcessingUnitCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Info associated with outdated minor version.</summary>
    public class OutdatedMinorVersionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Recommended minor version of the underlying database engine. Example values: For MySQL, it could be
        /// "8.0.35", "5.7.25" etc. For PostgreSQL, it could be "14.4", "15.5" etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedMinorVersion")]
        public virtual string RecommendedMinorVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product specification for databasecenter resources.</summary>
    public class Product : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The specific engine that the underlying database is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("engine")]
        public virtual string Engine { get; set; }

        /// <summary>
        /// Optional. Minor version of the underlying database engine. Example values: For MySQL, it could be "8.0.35",
        /// "5.7.25" etc. For PostgreSQL, it could be "14.4", "15.5" etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minorVersion")]
        public virtual string MinorVersion { get; set; }

        /// <summary>Optional. Type of specific database product. It could be CloudSQL, AlloyDB etc..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Optional. Version of the underlying database engine. Example values: For MySQL, it could be "8.0", "5.7"
        /// etc. For Postgres, it could be "14", "15" etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryDatabaseResourceGroupsRequest is the request to get a list of database groups.</summary>
    public class QueryDatabaseResourceGroupsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The expression to filter resources. The following fields are filterable: * full_resource_name *
        /// resource_type * container * product.type * product.engine * product.version * location * labels *
        /// resource_category * machine_config.cpu_count * machine_config.memory_size_bytes * machine_config.shard_count
        /// * resource_name * tags * backupdr_config.backupdr_managed * edition The expression is a list of zero or more
        /// restrictions combined via logical operators `AND` and `OR`. When `AND` and `OR` are both used in the
        /// expression, parentheses must be appropriately used to group the combinations. Example: `location="us-east1"`
        /// Example: `container="projects/123" OR container="projects/456"` Example: `(container="projects/123" OR
        /// container="projects/456") AND location="us-east1"` Example: `full_resource_name=~"test"` Example:
        /// `full_resource_name=~"test.*master"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. A field that specifies the sort order of the results. The following fields are sortable: *
        /// full_resource_name * product.type * product.engine * product.version * container * issue_count *
        /// machine_config.vcpu_count * machine_config.memory_size_bytes * machine_config.shard_count * resource_name *
        /// issue_severity * signal_type * location * resource_type * instance_type * edition *
        /// metrics.p99_cpu_utilization * metrics.p95_cpu_utilization * metrics.current_storage_used_bytes *
        /// metrics.node_count * metrics.processing_unit_count * metrics.current_memory_used_bytes *
        /// metrics.peak_storage_utilization * metrics.peak_number_connections * metrics.peak_memory_utilization The
        /// default order is ascending. Add "DESC" after the field name to indicate descending order. Add "ASC" after
        /// the field name to indicate ascending order. It only supports a single field at a time. For example:
        /// `order_by = "full_resource_name"` sorts response in ascending order `order_by = "full_resource_name DESC"`
        /// sorts response in descending order `order_by = "issue_count DESC"` sorts response in descending order of
        /// count of all issues associated with a resource. More explicitly, `order_by = "full_resource_name, product"`
        /// is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Optional. If unspecified, at most 50 resource groups will be returned. The maximum value is 1000; values
        /// above 1000 will be coerced to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token, received from a previous `QueryDatabaseResourceGroupsRequest` call. Provide this to
        /// retrieve the subsequent page. All parameters except page_token should match the parameters in the call that
        /// provided the page page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. Parent can be a project, a folder, or an organization. The search is limited to the resources
        /// within the `scope`. The allowed values are: * projects/{PROJECT_ID} (e.g., "projects/foo-bar") *
        /// projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER} (e.g., "folders/1234567") *
        /// organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Optional. Filters based on signals. The list will be ORed together and then ANDed with the `filters` field
        /// above.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalFilters")]
        public virtual System.Collections.Generic.IList<SignalFilter> SignalFilters { get; set; }

        /// <summary>Optional. Groups of signal types that are requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalTypeGroups")]
        public virtual System.Collections.Generic.IList<SignalTypeGroup> SignalTypeGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// QueryDatabaseResourceGroupsResponse represents the response message containing a list of resource groups.
    /// </summary>
    public class QueryDatabaseResourceGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of database resource groups that pass the filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroups")]
        public virtual System.Collections.Generic.IList<DatabaseResourceGroup> ResourceGroups { get; set; }

        /// <summary>Output only. The total number of resource groups in the entire list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<long> TotalSize { get; set; }

        /// <summary>Unordered list. List of unreachable regions from where data could not be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryIssuesRequest is the request to get a list of issues.</summary>
    public class QueryIssuesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Supported fields are: 'product', `location`, `issue_severity`, 'tags', 'labels',
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Optional. Following fields are sortable: SignalType Product Location IssueSeverity The default order is
        /// ascending. Add "DESC" after the field name to indicate descending order. Add "ASC" after the field name to
        /// indicate ascending order. It only supports a single field at a time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderBy")]
        public virtual string OrderBy { get; set; }

        /// <summary>
        /// Optional. If unspecified, at most 50 issues will be returned. The maximum value is 1000; values above 1000
        /// will be coerced to 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token, received from a previous `QueryIssues` call. Provide this to retrieve the subsequent
        /// page. All parameters except page size should match the parameters used in the call that provided the page
        /// token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. Parent can be a project, a folder, or an organization. The list is limited to the one attached to
        /// resources within the `scope` that a user has access to. The allowed values are: * projects/{PROJECT_ID}
        /// (e.g., "projects/foo-bar") * projects/{PROJECT_NUMBER} (e.g., "projects/12345678") * folders/{FOLDER_NUMBER}
        /// (e.g., "folders/1234567") * organizations/{ORGANIZATION_NUMBER} (e.g., "organizations/123456")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Optional. Filters based on signal and product. The filter list will be ORed across pairs and ANDed within a
        /// signal and products pair.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalProductsFilters")]
        public virtual System.Collections.Generic.IList<SignalProductsFilters> SignalProductsFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryIssuesResponse is the response containing a list of issues.</summary>
    public class QueryIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of issues and resource details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceIssues")]
        public virtual System.Collections.Generic.IList<DatabaseResourceIssue> ResourceIssues { get; set; }

        /// <summary>Unordered list. List of unreachable regions from where data could not be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryMetrics contains the metrics related to the query execution.</summary>
    public class QueryMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The average execution period of the query across all runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgCpuTime")]
        public virtual object AvgCpuTime { get; set; }

        /// <summary>The number of times the query was executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executionCount")]
        public virtual System.Nullable<long> ExecutionCount { get; set; }

        /// <summary>The window over which the metrics are aggregated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricsWindow")]
        public virtual string MetricsWindow { get; set; }

        /// <summary>The average number of rows processed by the query across all runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowsProcessed")]
        public virtual System.Nullable<long> RowsProcessed { get; set; }

        /// <summary>The total CPU time consumed by the query across all runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCpuTime")]
        public virtual object TotalCpuTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>QueryProductsResponse represents the response containing a list of products.</summary>
    public class QueryProductsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of database products returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<Product> Products { get; set; }

        /// <summary>Unordered list. List of unreachable regions from where data could not be retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// QueryStats contains the stats for a particular combination of query_hash, query_string and resource_type.
    /// </summary>
    public class QueryStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about inefficient query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inefficientQueryInfo")]
        public virtual InefficientQueryInfo InefficientQueryInfo { get; set; }

        /// <summary>The query string is normalized query without any PII data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("normalizedQuery")]
        public virtual string NormalizedQuery { get; set; }

        /// <summary>The query hash of the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryHash")]
        public virtual string QueryHash { get; set; }

        /// <summary>Metrics related to the query performance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryMetrics")]
        public virtual QueryMetrics QueryMetrics { get; set; }

        /// <summary>The resource ids for which the query stats are collected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceIds")]
        public virtual System.Collections.Generic.IList<ResourceId> ResourceIds { get; set; }

        /// <summary>
        /// The type of the resource. sqladmin.googleapis.com/Instance alloydb.googleapis.com/Cluster
        /// alloydb.googleapis.com/Instance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// QueryStatsInfo contains the aggregated and detailed query stats for a particular combination of relevant query
    /// stats for queries having same normalized query.
    /// </summary>
    public class QueryStatsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregated query stats for the resources for same normalized query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatedQueryStats")]
        public virtual QueryStats AggregatedQueryStats { get; set; }

        /// <summary>
        /// List of query stats for the resources in the group. This stats is stats at resource level for the resources
        /// having same normalized query.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryStats")]
        public virtual System.Collections.Generic.IList<QueryStats> QueryStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Info associated with recommendation.</summary>
    public class RecommendationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of recommendation. Examples:
        /// organizations/1234/locations/us-central1/recommenders/google.cloudsql.instance.PerformanceRecommender/recommendations/9876
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommender")]
        public virtual string Recommender { get; set; }

        /// <summary>ID of recommender. Examples: "google.cloudsql.instance.PerformanceRecommender"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommenderId")]
        public virtual string RecommenderId { get; set; }

        /// <summary>
        /// Contains an identifier for a subtype of recommendations produced for the same recommender. Subtype is a
        /// function of content and impact, meaning a new subtype might be added when significant changes to `content`
        /// or `primary_impact.category` are introduced. See the Recommenders section to see a list of subtypes for a
        /// given Recommender. Examples: For recommender = "google.cloudsql.instance.PerformanceRecommender",
        /// recommender_subtype can be
        /// "MYSQL_HIGH_NUMBER_OF_OPEN_TABLES_BEST_PRACTICE"/"POSTGRES_HIGH_TRANSACTION_ID_UTILIZATION_BEST_PRACTICE"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommenderSubtype")]
        public virtual string RecommenderSubtype { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compliances associated with signals.</summary>
    public class RegulatoryStandard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of industry compliance standards, such as such as CIS, PCI, and OWASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>Version of the standard or benchmark, for example, 1.1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Capture the resource details for resources that are included in the delta counts.</summary>
    public class ResourceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies where the resource is created. For Google Cloud resources, it is the full name of the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>Full resource name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>Location of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Product type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ResourceId contains the identifier for a database resource, including the full resource name, resource type, and
    /// product.
    /// </summary>
    public class ResourceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full resource name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>The product of the resource, including the type, engine, and version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        /// <summary>
        /// The type of the resource. sqladmin.googleapis.com/Instance alloydb.googleapis.com/Cluster
        /// alloydb.googleapis.com/Instance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deny maintenance period for the database resource. It specifies the time range during which the maintenance
    /// cannot start. This is configured by the customer.
    /// </summary>
    public class ResourceMaintenanceDenySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Deny period end date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>Optional. The start date of the deny maintenance period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>Optional. Time in UTC when the deny period starts on start_date and ends on end_date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual TimeOfDay Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Maintenance window for the database resource. It specifies preferred time and day of the week and phase in some
    /// cases, when the maintenance can start.
    /// </summary>
    public class ResourceMaintenanceSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Preferred day of the week for maintenance, e.g. MONDAY, TUESDAY, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual string Day { get; set; }

        /// <summary>
        /// Optional. Phase of the maintenance window. This is to capture order of maintenance. For example, for Cloud
        /// SQL resources, this can be used to capture if the maintenance window is in Week1, Week2, Week5, etc. Non
        /// production resources are usually part of early phase. For more details, refer to Cloud SQL resources -
        /// https://cloud.google.com/sql/docs/mysql/maintenance
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>Optional. Preferred time to start the maintenance operation on the specified day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource suspension info for a database resource.</summary>
    public class ResourceSuspensionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Is resource suspended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSuspended")]
        public virtual System.Nullable<bool> ResourceSuspended { get; set; }

        /// <summary>Suspension reason for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReason")]
        public virtual string SuspensionReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about backup retention settings for a database resource.</summary>
    public class RetentionSettingsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Duration based retention period i.e. 172800 seconds (2 days)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationBasedRetention")]
        public virtual object DurationBasedRetention { get; set; }

        /// <summary>Number of backups that will be retained.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantityBasedRetention")]
        public virtual System.Nullable<int> QuantityBasedRetention { get; set; }

        /// <summary>Optional. Sub resource details associated with the backup configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subResource")]
        public virtual SubResource SubResource { get; set; }

        private string _timestampBasedRetentionTimeRaw;

        private object _timestampBasedRetentionTime;

        /// <summary>Timestamp based retention period i.e. till 2024-05-01T00:00:00Z</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampBasedRetentionTime")]
        public virtual string TimestampBasedRetentionTimeRaw
        {
            get => _timestampBasedRetentionTimeRaw;
            set
            {
                _timestampBasedRetentionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampBasedRetentionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampBasedRetentionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampBasedRetentionTimeDateTimeOffset instead.")]
        public virtual object TimestampBasedRetentionTime
        {
            get => _timestampBasedRetentionTime;
            set
            {
                _timestampBasedRetentionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestampBasedRetentionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampBasedRetentionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampBasedRetentionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampBasedRetentionTimeRaw);
            set => TimestampBasedRetentionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Info associated with SCC signals.</summary>
    public class SCCInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name by which SCC calls this signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>External URI which points to a SCC page associated with the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>Compliances that are associated with the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regulatoryStandards")]
        public virtual System.Collections.Generic.IList<RegulatoryStandard> RegulatoryStandards { get; set; }

        /// <summary>Name of the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signal")]
        public virtual string Signal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a signal.</summary>
    public class Signal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional information related to the signal. In the case of composite signals, this field encapsulates
        /// details associated with granular signals, having a signal status of "ISSUE"; signals with a status of "OK"
        /// are not included. For granular signals, it encompasses information relevant to the signal, regardless of the
        /// signal status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalDetails")]
        public virtual System.Collections.Generic.IList<AdditionalDetail> AdditionalDetails { get; set; }

        private string _issueCreateTimeRaw;

        private object _issueCreateTime;

        /// <summary>Timestamp when the issue was created (when signal status is ISSUE).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueCreateTime")]
        public virtual string IssueCreateTimeRaw
        {
            get => _issueCreateTimeRaw;
            set
            {
                _issueCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _issueCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="IssueCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IssueCreateTimeDateTimeOffset instead.")]
        public virtual object IssueCreateTime
        {
            get => _issueCreateTime;
            set
            {
                _issueCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _issueCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="IssueCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? IssueCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IssueCreateTimeRaw);
            set => IssueCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueSeverity")]
        public virtual string IssueSeverity { get; set; }

        /// <summary>Status of the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalStatus")]
        public virtual string SignalStatus { get; set; }

        /// <summary>Type of the signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter for Signals. If signal_type is left unset, all signals should be returned. For example, the following
    /// filter returns all issues. signal_filter: { signal_status: SIGNAL_STATUS_ISSUE; } Another example, the following
    /// filter returns issues of the given type: signal_filter: { type: SIGNAL_TYPE_NO_PROMOTABLE_REPLICA signal_status:
    /// ISSUE } If signal_status is left unset or set to SIGNAL_STATE_UNSPECIFIED, an error should be returned.
    /// </summary>
    public class SignalFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Represents the status of the Signal for which the filter is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalStatus")]
        public virtual string SignalStatus { get; set; }

        /// <summary>Optional. Represents the type of the Signal for which the filter is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group of signals and their counts.</summary>
    public class SignalGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Title of a signal group corresponding to the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// When applied to a DatabaseResource represents count of issues associated with the resource. A signal is an
        /// issue when its SignalStatus field is set to SIGNAL_STATUS_ISSUE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueCount")]
        public virtual System.Nullable<int> IssueCount { get; set; }

        /// <summary>
        /// List of signals present in the group and associated with the resource. Only applies to a DatabaseResource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signals")]
        public virtual System.Collections.Generic.IList<Signal> Signals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SignalProductsFilters represents a signal and list of supported products.</summary>
    public class SignalProductsFilters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Product type of the resource. The version of the product will be ignored in filtering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<Product> Products { get; set; }

        /// <summary>Optional. The type of signal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalType")]
        public virtual string SignalType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group of signal types that specifies what the user is interested in. Used by QueryDatabaseResourceGroups API.
    /// Example: signal_type_group { name = "AVAILABILITY" types = [SIGNAL_TYPE_NO_PROMOTABLE_REPLICA] }
    /// </summary>
    public class SignalTypeGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display name of a signal group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. List of signal types present in the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalTypes")]
        public virtual System.Collections.Generic.IList<string> SignalTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sub resource details For Spanner/Bigtable instance certain data protection settings are at sub resource level
    /// like database/table. This message is used to capture such sub resource details.
    /// </summary>
    public class SubResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies where the resource is created. For Google Cloud resources, it is the full name of the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>
        /// Optional. Resource name associated with the sub resource where backup settings are configured.
        /// E.g."//spanner.googleapis.com/projects/project1/instances/inst1/databases/db1" for Spanner where backup
        /// retention is configured on database within an instance OPTIONAL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; }

        /// <summary>
        /// Optional. Product information associated with the sub resource where backup retention settings are
        /// configured. e.g.
        /// ```
        /// product: { type : PRODUCT_TYPE_SPANNER engine :
        /// ENGINE_CLOUD_SPANNER_WITH_POSTGRES_DIALECT }
        /// ```
        /// for Spanner where backup is configured on database within
        /// an instance OPTIONAL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual Product Product { get; set; }

        /// <summary>
        /// Optional. Resource type associated with the sub resource where backup settings are configured. E.g.
        /// "spanner.googleapis.com/Database" for Spanner where backup retention is configured on database within an
        /// instance OPTIONAL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tag is a key value pair attached to a resource.</summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates the inheritance status of a tag value attached to the given resource. If the tag value is
        /// inherited from one of the resource's ancestors, inherited will be true. If false, then the tag value is
        /// directly attached to the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inherited")]
        public virtual System.Nullable<bool> Inherited { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// The source of the tag. According to
        /// https://cloud.google.com/resource-manager/docs/tags/tags-overview#tags_and_labels, tags can be created only
        /// at the project or organization level. Tags can be inherited from different project as well not just the
        /// current project where the database resource is present. Format: "projects/{PROJECT_ID}",
        /// "projects/{PROJECT_NUMBER}", "organizations/{ORGANIZATION_ID}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The value part of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TypedValue represents the value of the metric based on data type.</summary>
    public class TypedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of the metric as double.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>The value of the metric as int.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Upcoming maintenance window for the database resource.</summary>
    public class UpcomingMaintenance : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Output only. End time of the upcoming maintenance. This is only populated for an engine, if end time is
        /// public for the engine.
        /// </summary>
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
        /// Output only. Start time of the upcoming maintenance. Start time is always populated when an upcoming
        /// maintenance is scheduled.
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
}
