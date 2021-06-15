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

namespace Google.Apis.SecurityCommandCenter.v1
{
    /// <summary>The SecurityCommandCenter Service.</summary>
    public class SecurityCommandCenterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SecurityCommandCenterService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SecurityCommandCenterService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "securitycenter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://securitycenter.googleapis.com/";
        #else
            "https://securitycenter.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://securitycenter.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Security Command Center API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Security Command Center API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for SecurityCommandCenter requests.</summary>
    public abstract class SecurityCommandCenterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SecurityCommandCenterBaseServiceRequest instance.</summary>
        protected SecurityCommandCenterBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SecurityCommandCenter parameter list.</summary>
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
            Assets = new AssetsResource(service);
            Sources = new SourcesResource(service);
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Name of the organization to groupBy. Its format is "organizations/[organization_id],
            /// folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent)
            {
                return new GroupRequest(service, body, parent);
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsResponse>
            {
                /// <summary>Constructs a new Group request.</summary>
                public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization to groupBy. Its format is "organizations/[organization_id],
                /// folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "group";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:group";

                /// <summary>Initializes Group parameter list.</summary>
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

            /// <summary>Lists an organization's assets.</summary>
            /// <param name="parent">
            /// Required. Name of the organization assets should belong to. Its format is
            /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists an organization's assets.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization assets should belong to. Its format is
                /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// When compare_duration is set, the ListAssetsResult's "state_change" attribute is updated to indicate
                /// whether the asset was added, removed, or remained present during the compare_duration period of time
                /// that precedes the read_time. This is the time between (read_time - compare_duration) and read_time.
                /// The state_change value is derived based on the presence of the asset at the two points in time.
                /// Intermediate state changes between the two times don't affect the result. For example, the results
                /// aren't affected if the asset is removed and re-created again. Possible "state_change" values when
                /// compare_duration is specified: * "ADDED": indicates that the asset was not present at the start of
                /// compare_duration, but present at read_time. * "REMOVED": indicates that the asset was present at the
                /// start of compare_duration, but not present at read_time. * "ACTIVE": indicates that the asset was
                /// present at both the start and the end of the time period defined by compare_duration and read_time.
                /// If compare_duration is not specified, then the only possible state_change is "UNUSED", which will be
                /// the state_change set for all assets present at read_time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object CompareDuration { get; set; }

                /// <summary>
                /// A field mask to specify the ListAssetsResult fields to be listed in the response. An empty field
                /// mask will list all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object FieldMask { get; set; }

                /// <summary>
                /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
                /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has
                /// higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front
                /// of them to indicate negation. The fields map to those defined in the Asset resource. Examples
                /// include: * name * security_center_properties.resource_name * resource_properties.a_property *
                /// security_marks.marks.marka The supported operators are: * `=` for all value types. * `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for
                /// strings. The supported value types are: * string literals in quotes. * integer literals without
                /// quotes. * boolean literals `true` and `false` without quotes. The following are the allowed field
                /// and operator combinations: * name: `=` * update_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
                /// `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string. Examples:
                /// `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
                /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or
                /// an RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time =
                /// 1560208038000` * iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` * security_marks.marks: `=`, `:` *
                /// security_center_properties.resource_name: `=`, `:` *
                /// security_center_properties.resource_display_name: `=`, `:` *
                /// security_center_properties.resource_type: `=`, `:` * security_center_properties.resource_parent:
                /// `=`, `:` * security_center_properties.resource_parent_display_name: `=`, `:` *
                /// security_center_properties.resource_project: `=`, `:` *
                /// security_center_properties.resource_project_display_name: `=`, `:` *
                /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100`
                /// is a valid filter string. Use a partial match on the empty string to filter based on a property
                /// existing: `resource_properties.my_property : ""` Use a negated partial match on the empty string to
                /// filter based on a property not existing: `-resource_properties.my_property : ""`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Expression that defines what fields and order to use for sorting. The string value should follow SQL
                /// syntax: comma separated list of fields. For example: "name,resource_properties.a_property". The
                /// default sorting order is ascending. To specify descending order for a field, a suffix " desc" should
                /// be appended to the field name. For example: "name desc,resource_properties.a_property". Redundant
                /// space characters in the syntax are insignificant. "name desc,resource_properties.a_property" and "
                /// name desc , resource_properties.a_property " are equivalent. The following fields are supported:
                /// name update_time resource_properties security_marks.marks security_center_properties.resource_name
                /// security_center_properties.resource_display_name security_center_properties.resource_parent
                /// security_center_properties.resource_parent_display_name security_center_properties.resource_project
                /// security_center_properties.resource_project_display_name security_center_properties.resource_type
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAssetsResponse`; indicates that this is a continuation of a
                /// prior `ListAssets` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Time used as a reference point when filtering assets. The filter is limited to assets existing at
                /// the supplied time and their values are those at that specific time. Absence of this field will
                /// default to the API's version of NOW.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets";

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
                    RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                    {
                        Name = "compareDuration",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldMask",
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
                    RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates security marks.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of the SecurityMarks. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
            /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
            /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
            /// </param>
            public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
            {
                return new UpdateSecurityMarksRequest(service, body, name);
            }

            /// <summary>Updates security marks.</summary>
            public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
            {
                /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>
                /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can be
                /// updated using "marks.".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSecurityMarks";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/assets/[^/]+/securityMarks$",
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
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

        /// <summary>Gets the Sources resource.</summary>
        public virtual SourcesResource Sources { get; }

        /// <summary>The "sources" collection of methods.</summary>
        public class SourcesResource
        {
            private const string Resource = "sources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Findings = new FindingsResource(service);
            }

            /// <summary>Gets the Findings resource.</summary>
            public virtual FindingsResource Findings { get; }

            /// <summary>The "findings" collection of methods.</summary>
            public class FindingsResource
            {
                private const string Resource = "findings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the source to groupBy. Its format is
                /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-, or
                /// projects/{project_id}/sources/-
                /// </param>
                public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent)
                {
                    return new GroupRequest(service, body, parent);
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsResponse>
                {
                    /// <summary>Constructs a new Group request.</summary>
                    public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source to groupBy. Its format is
                    /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id
                    /// of `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-,
                    /// or projects/{project_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "group";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings:group";

                    /// <summary>Initializes Group parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                /// <param name="parent">
                /// Required. Name of the source the findings belong to. Its format is
                /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                /// projects/{projects_id}/sources/-
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListFindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source the findings belong to. Its format is
                    /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of
                    /// `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                    /// projects/{projects_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// When compare_duration is set, the ListFindingsResult's "state_change" attribute is updated to
                    /// indicate whether the finding had its state changed, the finding's state remained unchanged, or
                    /// if the finding was added in any state during the compare_duration period of time that precedes
                    /// the read_time. This is the time between (read_time - compare_duration) and read_time. The
                    /// state_change value is derived based on the presence and state of the finding at the two points
                    /// in time. Intermediate state changes between the two times don't affect the result. For example,
                    /// the results aren't affected if the finding is made inactive and then active again. Possible
                    /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the
                    /// finding was present and matched the given filter at the start of compare_duration, but changed
                    /// its state at read_time. * "UNCHANGED": indicates that the finding was present and matched the
                    /// given filter at the start of compare_duration and did not change state at read_time. * "ADDED":
                    /// indicates that the finding did not match the given filter or was not present at the start of
                    /// compare_duration, but was present at read_time. * "REMOVED": indicates that the finding was
                    /// present and matched the filter at the start of compare_duration, but did not match the filter at
                    /// read_time. If compare_duration is not specified, then the only possible state_change is
                    /// "UNUSED", which will be the state_change set for all findings present at read_time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CompareDuration { get; set; }

                    /// <summary>
                    /// A field mask to specify the Finding fields to be listed in the response. An empty field mask
                    /// will list all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object FieldMask { get; set; }

                    /// <summary>
                    /// Expression that defines the filter to apply across findings. The expression is a list of one or
                    /// more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and
                    /// `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-`
                    /// character in front of them to indicate negation. Examples include: * name *
                    /// source_properties.a_property * security_marks.marks.marka The supported operators are: * `=` for
                    /// all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`,
                    /// meaning substring matching, for strings. The supported value types are: * string literals in
                    /// quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
                    /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` *
                    /// resource_name: `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` *
                    /// event_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be
                    /// milliseconds since epoch or an RFC3339 string. Examples: `event_time =
                    /// "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` * workflow_state:
                    /// `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`,
                    /// `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
                    /// Use a partial match on the empty string to filter based on a property existing:
                    /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter
                    /// based on a property not existing: `-source_properties.my_property : ""` * resource: *
                    /// resource.name: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`,
                    /// `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.type:
                    /// `=`, `:` * resource.folders.resource_folder: `=`, `:`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Expression that defines what fields and order to use for sorting. The string value should follow
                    /// SQL syntax: comma separated list of fields. For example: "name,resource_properties.a_property".
                    /// The default sorting order is ascending. To specify descending order for a field, a suffix "
                    /// desc" should be appended to the field name. For example: "name
                    /// desc,source_properties.a_property". Redundant space characters in the syntax are insignificant.
                    /// "name desc,source_properties.a_property" and " name desc , source_properties.a_property " are
                    /// equivalent. The following fields are supported: name parent state category resource_name
                    /// event_time source_properties security_marks.marks
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListFindingsResponse`; indicates that this is a continuation of
                    /// a prior `ListFindings` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Time used as a reference point when filtering findings. The filter is limited to findings
                    /// existing at the supplied time and their values are those at that specific time. Absence of this
                    /// field will default to the API's version of NOW.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^folders/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "compareDuration",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldMask",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of this finding. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of this finding. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The FieldMask to use when updating the finding resource. This field should not be specified when
                    /// creating a finding. When updating a finding, an empty mask is treated as updating all mutable
                    /// fields and replacing source_properties. Individual source_properties can be added/updated by
                    /// using "source_properties." in the field mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

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
                            Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+$",
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

                /// <summary>Updates the state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the finding. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}/finding/{finding_id}".
                /// </param>
                public virtual SetStateRequest SetState(Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name)
                {
                    return new SetStateRequest(service, body, name);
                }

                /// <summary>Updates the state of a finding.</summary>
                public class SetStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetState request.</summary>
                    public SetStateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the finding. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                    /// "organizations/{organization_id}/sources/{source_id}/finding/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setState";

                    /// <summary>Initializes SetState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates security marks.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </param>
                public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
                {
                    return new UpdateSecurityMarksRequest(service, body, name);
                }

                /// <summary>Updates security marks.</summary>
                public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
                {
                    /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                    public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of the SecurityMarks. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                    /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>
                    /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                    /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can
                    /// be updated using "marks.".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateSecurityMarks";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+/securityMarks$",
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
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

            /// <summary>Lists all sources belonging to an organization.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent of sources to list. Its format should be
            /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent of sources to list. Its format should be
                /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSourcesResponse`; indicates that this is a continuation of a
                /// prior `ListSources` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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
            Assets = new AssetsResource(service);
            NotificationConfigs = new NotificationConfigsResource(service);
            Operations = new OperationsResource(service);
            Sources = new SourcesResource(service);
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Name of the organization to groupBy. Its format is "organizations/[organization_id],
            /// folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent)
            {
                return new GroupRequest(service, body, parent);
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsResponse>
            {
                /// <summary>Constructs a new Group request.</summary>
                public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization to groupBy. Its format is "organizations/[organization_id],
                /// folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "group";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:group";

                /// <summary>Initializes Group parameter list.</summary>
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

            /// <summary>Lists an organization's assets.</summary>
            /// <param name="parent">
            /// Required. Name of the organization assets should belong to. Its format is
            /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists an organization's assets.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization assets should belong to. Its format is
                /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// When compare_duration is set, the ListAssetsResult's "state_change" attribute is updated to indicate
                /// whether the asset was added, removed, or remained present during the compare_duration period of time
                /// that precedes the read_time. This is the time between (read_time - compare_duration) and read_time.
                /// The state_change value is derived based on the presence of the asset at the two points in time.
                /// Intermediate state changes between the two times don't affect the result. For example, the results
                /// aren't affected if the asset is removed and re-created again. Possible "state_change" values when
                /// compare_duration is specified: * "ADDED": indicates that the asset was not present at the start of
                /// compare_duration, but present at read_time. * "REMOVED": indicates that the asset was present at the
                /// start of compare_duration, but not present at read_time. * "ACTIVE": indicates that the asset was
                /// present at both the start and the end of the time period defined by compare_duration and read_time.
                /// If compare_duration is not specified, then the only possible state_change is "UNUSED", which will be
                /// the state_change set for all assets present at read_time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object CompareDuration { get; set; }

                /// <summary>
                /// A field mask to specify the ListAssetsResult fields to be listed in the response. An empty field
                /// mask will list all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object FieldMask { get; set; }

                /// <summary>
                /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
                /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has
                /// higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front
                /// of them to indicate negation. The fields map to those defined in the Asset resource. Examples
                /// include: * name * security_center_properties.resource_name * resource_properties.a_property *
                /// security_marks.marks.marka The supported operators are: * `=` for all value types. * `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for
                /// strings. The supported value types are: * string literals in quotes. * integer literals without
                /// quotes. * boolean literals `true` and `false` without quotes. The following are the allowed field
                /// and operator combinations: * name: `=` * update_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
                /// `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string. Examples:
                /// `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
                /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or
                /// an RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time =
                /// 1560208038000` * iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` * security_marks.marks: `=`, `:` *
                /// security_center_properties.resource_name: `=`, `:` *
                /// security_center_properties.resource_display_name: `=`, `:` *
                /// security_center_properties.resource_type: `=`, `:` * security_center_properties.resource_parent:
                /// `=`, `:` * security_center_properties.resource_parent_display_name: `=`, `:` *
                /// security_center_properties.resource_project: `=`, `:` *
                /// security_center_properties.resource_project_display_name: `=`, `:` *
                /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100`
                /// is a valid filter string. Use a partial match on the empty string to filter based on a property
                /// existing: `resource_properties.my_property : ""` Use a negated partial match on the empty string to
                /// filter based on a property not existing: `-resource_properties.my_property : ""`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Expression that defines what fields and order to use for sorting. The string value should follow SQL
                /// syntax: comma separated list of fields. For example: "name,resource_properties.a_property". The
                /// default sorting order is ascending. To specify descending order for a field, a suffix " desc" should
                /// be appended to the field name. For example: "name desc,resource_properties.a_property". Redundant
                /// space characters in the syntax are insignificant. "name desc,resource_properties.a_property" and "
                /// name desc , resource_properties.a_property " are equivalent. The following fields are supported:
                /// name update_time resource_properties security_marks.marks security_center_properties.resource_name
                /// security_center_properties.resource_display_name security_center_properties.resource_parent
                /// security_center_properties.resource_parent_display_name security_center_properties.resource_project
                /// security_center_properties.resource_project_display_name security_center_properties.resource_type
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAssetsResponse`; indicates that this is a continuation of a
                /// prior `ListAssets` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Time used as a reference point when filtering assets. The filter is limited to assets existing at
                /// the supplied time and their values are those at that specific time. Absence of this field will
                /// default to the API's version of NOW.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets";

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
                    RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                    {
                        Name = "compareDuration",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldMask",
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
                    RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Runs asset discovery. The discovery is tracked with a long-running operation. This API can only be
            /// called with limited frequency for an organization. If it is called too frequently the caller will
            /// receive a TOO_MANY_REQUESTS error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Name of the organization to run asset discovery for. Its format is
            /// "organizations/[organization_id]".
            /// </param>
            public virtual RunDiscoveryRequest RunDiscovery(Google.Apis.SecurityCommandCenter.v1.Data.RunAssetDiscoveryRequest body, string parent)
            {
                return new RunDiscoveryRequest(service, body, parent);
            }

            /// <summary>
            /// Runs asset discovery. The discovery is tracked with a long-running operation. This API can only be
            /// called with limited frequency for an organization. If it is called too frequently the caller will
            /// receive a TOO_MANY_REQUESTS error.
            /// </summary>
            public class RunDiscoveryRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Operation>
            {
                /// <summary>Constructs a new RunDiscovery request.</summary>
                public RunDiscoveryRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.RunAssetDiscoveryRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization to run asset discovery for. Its format is
                /// "organizations/[organization_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.RunAssetDiscoveryRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "runDiscovery";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:runDiscovery";

                /// <summary>Initializes RunDiscovery parameter list.</summary>
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

            /// <summary>Updates security marks.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of the SecurityMarks. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
            /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
            /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
            /// </param>
            public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
            {
                return new UpdateSecurityMarksRequest(service, body, name);
            }

            /// <summary>Updates security marks.</summary>
            public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
            {
                /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>
                /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can be
                /// updated using "marks.".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSecurityMarks";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/assets/[^/]+/securityMarks$",
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
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

        /// <summary>Gets the NotificationConfigs resource.</summary>
        public virtual NotificationConfigsResource NotificationConfigs { get; }

        /// <summary>The "notificationConfigs" collection of methods.</summary>
        public class NotificationConfigsResource
        {
            private const string Resource = "notificationConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NotificationConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a notification config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new notification config's parent. Its format is
            /// "organizations/[organization_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a notification config.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new notification config's parent. Its format is
                /// "organizations/[organization_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and
                /// 128 characters, and contains alphanumeric characters, underscores or hyphens only.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ConfigId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
                    RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "configId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to delete. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a notification config.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to delete. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^organizations/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to get. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a notification config.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to get. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^organizations/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists notification configs.</summary>
            /// <param name="parent">
            /// Required. Name of the organization to list notification configs. Its format is
            /// "organizations/[organization_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists notification configs.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListNotificationConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization to list notification configs. Its format is
                /// "organizations/[organization_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListNotificationConfigsResponse`; indicates that this is a
                /// continuation of a prior `ListNotificationConfigs` call, and that the system should return the next
                /// page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this notification config. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this notification config. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The FieldMask to use when updating the notification config. If empty all mutable fields will be
                /// updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/notificationConfigs/[^/]+$",
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
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            /// <param name="name">The name of the operation resource to be cancelled.</param>
            public virtual CancelRequest Cancel(string name)
            {
                return new CancelRequest(service, name);
            }

            /// <summary>
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            public class CancelRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
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
                        Pattern = @"^organizations/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            /// <param name="name">The name of the operation resource to be deleted.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
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
                        Pattern = @"^organizations/[^/]+/operations/[^/]+$",
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
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Operation>
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
                        Pattern = @"^organizations/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListOperationsResponse>
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
                        Pattern = @"^organizations/[^/]+/operations$",
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

        /// <summary>Gets the Sources resource.</summary>
        public virtual SourcesResource Sources { get; }

        /// <summary>The "sources" collection of methods.</summary>
        public class SourcesResource
        {
            private const string Resource = "sources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Findings = new FindingsResource(service);
            }

            /// <summary>Gets the Findings resource.</summary>
            public virtual FindingsResource Findings { get; }

            /// <summary>The "findings" collection of methods.</summary>
            public class FindingsResource
            {
                private const string Resource = "findings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a finding. The corresponding source must exist for finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the new finding's parent. Its format should be
                /// "organizations/[organization_id]/sources/[source_id]".
                /// </param>
                public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a finding. The corresponding source must exist for finding creation to succeed.
                /// </summary>
                public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the new finding's parent. Its format should be
                    /// "organizations/[organization_id]/sources/[source_id]".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Unique identifier provided by the client within the parent scope. It must be
                    /// alphanumeric and less than or equal to 32 characters and greater than 0 characters in length.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("findingId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FindingId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("findingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "findingId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the source to groupBy. Its format is
                /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-, or
                /// projects/{project_id}/sources/-
                /// </param>
                public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent)
                {
                    return new GroupRequest(service, body, parent);
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsResponse>
                {
                    /// <summary>Constructs a new Group request.</summary>
                    public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source to groupBy. Its format is
                    /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id
                    /// of `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-,
                    /// or projects/{project_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "group";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings:group";

                    /// <summary>Initializes Group parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                /// <param name="parent">
                /// Required. Name of the source the findings belong to. Its format is
                /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                /// projects/{projects_id}/sources/-
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListFindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source the findings belong to. Its format is
                    /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of
                    /// `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                    /// projects/{projects_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// When compare_duration is set, the ListFindingsResult's "state_change" attribute is updated to
                    /// indicate whether the finding had its state changed, the finding's state remained unchanged, or
                    /// if the finding was added in any state during the compare_duration period of time that precedes
                    /// the read_time. This is the time between (read_time - compare_duration) and read_time. The
                    /// state_change value is derived based on the presence and state of the finding at the two points
                    /// in time. Intermediate state changes between the two times don't affect the result. For example,
                    /// the results aren't affected if the finding is made inactive and then active again. Possible
                    /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the
                    /// finding was present and matched the given filter at the start of compare_duration, but changed
                    /// its state at read_time. * "UNCHANGED": indicates that the finding was present and matched the
                    /// given filter at the start of compare_duration and did not change state at read_time. * "ADDED":
                    /// indicates that the finding did not match the given filter or was not present at the start of
                    /// compare_duration, but was present at read_time. * "REMOVED": indicates that the finding was
                    /// present and matched the filter at the start of compare_duration, but did not match the filter at
                    /// read_time. If compare_duration is not specified, then the only possible state_change is
                    /// "UNUSED", which will be the state_change set for all findings present at read_time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CompareDuration { get; set; }

                    /// <summary>
                    /// A field mask to specify the Finding fields to be listed in the response. An empty field mask
                    /// will list all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object FieldMask { get; set; }

                    /// <summary>
                    /// Expression that defines the filter to apply across findings. The expression is a list of one or
                    /// more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and
                    /// `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-`
                    /// character in front of them to indicate negation. Examples include: * name *
                    /// source_properties.a_property * security_marks.marks.marka The supported operators are: * `=` for
                    /// all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`,
                    /// meaning substring matching, for strings. The supported value types are: * string literals in
                    /// quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
                    /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` *
                    /// resource_name: `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` *
                    /// event_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be
                    /// milliseconds since epoch or an RFC3339 string. Examples: `event_time =
                    /// "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` * workflow_state:
                    /// `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`,
                    /// `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
                    /// Use a partial match on the empty string to filter based on a property existing:
                    /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter
                    /// based on a property not existing: `-source_properties.my_property : ""` * resource: *
                    /// resource.name: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`,
                    /// `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.type:
                    /// `=`, `:` * resource.folders.resource_folder: `=`, `:`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Expression that defines what fields and order to use for sorting. The string value should follow
                    /// SQL syntax: comma separated list of fields. For example: "name,resource_properties.a_property".
                    /// The default sorting order is ascending. To specify descending order for a field, a suffix "
                    /// desc" should be appended to the field name. For example: "name
                    /// desc,source_properties.a_property". Redundant space characters in the syntax are insignificant.
                    /// "name desc,source_properties.a_property" and " name desc , source_properties.a_property " are
                    /// equivalent. The following fields are supported: name parent state category resource_name
                    /// event_time source_properties security_marks.marks
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListFindingsResponse`; indicates that this is a continuation of
                    /// a prior `ListFindings` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Time used as a reference point when filtering findings. The filter is limited to findings
                    /// existing at the supplied time and their values are those at that specific time. Absence of this
                    /// field will default to the API's version of NOW.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "compareDuration",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldMask",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of this finding. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of this finding. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The FieldMask to use when updating the finding resource. This field should not be specified when
                    /// creating a finding. When updating a finding, an empty mask is treated as updating all mutable
                    /// fields and replacing source_properties. Individual source_properties can be added/updated by
                    /// using "source_properties." in the field mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+$",
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

                /// <summary>Updates the state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the finding. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}/finding/{finding_id}".
                /// </param>
                public virtual SetStateRequest SetState(Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name)
                {
                    return new SetStateRequest(service, body, name);
                }

                /// <summary>Updates the state of a finding.</summary>
                public class SetStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetState request.</summary>
                    public SetStateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the finding. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                    /// "organizations/{organization_id}/sources/{source_id}/finding/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setState";

                    /// <summary>Initializes SetState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates security marks.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </param>
                public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
                {
                    return new UpdateSecurityMarksRequest(service, body, name);
                }

                /// <summary>Updates security marks.</summary>
                public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
                {
                    /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                    public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of the SecurityMarks. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                    /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>
                    /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                    /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can
                    /// be updated using "marks.".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateSecurityMarks";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+/securityMarks$",
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
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

            /// <summary>Creates a source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new source's parent. Its format should be
            /// "organizations/[organization_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.Source body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a source.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Source>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Source body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new source's parent. Its format should be
                /// "organizations/[organization_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.Source Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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

            /// <summary>Gets a source.</summary>
            /// <param name="name">
            /// Required. Relative resource name of the source. Its format is
            /// "organizations/[organization_id]/source/[source_id]".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a source.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Source>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Relative resource name of the source. Its format is
                /// "organizations/[organization_id]/source/[source_id]".
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
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the access control policy on the specified Source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.SecurityCommandCenter.v1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Gets the access control policy on the specified Source.</summary>
            public class GetIamPolicyRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent of sources to list. Its format should be
            /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent of sources to list. Its format should be
                /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSourcesResponse`; indicates that this is a continuation of a
                /// prior `ListSources` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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

            /// <summary>Updates a source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this source. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/sources/{source_id}"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Source body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a source.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Source>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Source body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this source. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The FieldMask to use when updating the source resource. If empty all mutable fields will be updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.Source Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
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

            /// <summary>Sets the access control policy on the specified Source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for the
            /// appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.SecurityCommandCenter.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Sets the access control policy on the specified Source.</summary>
            public class SetIamPolicyRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }

            /// <summary>Returns the permissions that a caller has on the specified source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See the operation documentation
            /// for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>Returns the permissions that a caller has on the specified source.</summary>
            public class TestIamPermissionsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the settings for an organization.</summary>
        /// <param name="name">
        /// Required. Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        public virtual GetOrganizationSettingsRequest GetOrganizationSettings(string name)
        {
            return new GetOrganizationSettingsRequest(service, name);
        }

        /// <summary>Gets the settings for an organization.</summary>
        public class GetOrganizationSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings>
        {
            /// <summary>Constructs a new GetOrganizationSettings request.</summary>
            public GetOrganizationSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the organization to get organization settings for. Its format is
            /// "organizations/[organization_id]/organizationSettings".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOrganizationSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetOrganizationSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/organizationSettings$",
                });
            }
        }

        /// <summary>Updates an organization's settings.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The relative resource name of the settings. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/organizationSettings".
        /// </param>
        public virtual UpdateOrganizationSettingsRequest UpdateOrganizationSettings(Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings body, string name)
        {
            return new UpdateOrganizationSettingsRequest(service, body, name);
        }

        /// <summary>Updates an organization's settings.</summary>
        public class UpdateOrganizationSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings>
        {
            /// <summary>Constructs a new UpdateOrganizationSettings request.</summary>
            public UpdateOrganizationSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The relative resource name of the settings. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/organizationSettings".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The FieldMask to use when updating the settings resource. If empty all mutable fields will be updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateOrganizationSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateOrganizationSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/organizationSettings$",
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
            Assets = new AssetsResource(service);
            Sources = new SourcesResource(service);
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Name of the organization to groupBy. Its format is "organizations/[organization_id],
            /// folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent)
            {
                return new GroupRequest(service, body, parent);
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsResponse>
            {
                /// <summary>Constructs a new Group request.</summary>
                public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization to groupBy. Its format is "organizations/[organization_id],
                /// folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "group";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:group";

                /// <summary>Initializes Group parameter list.</summary>
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

            /// <summary>Lists an organization's assets.</summary>
            /// <param name="parent">
            /// Required. Name of the organization assets should belong to. Its format is
            /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists an organization's assets.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization assets should belong to. Its format is
                /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// When compare_duration is set, the ListAssetsResult's "state_change" attribute is updated to indicate
                /// whether the asset was added, removed, or remained present during the compare_duration period of time
                /// that precedes the read_time. This is the time between (read_time - compare_duration) and read_time.
                /// The state_change value is derived based on the presence of the asset at the two points in time.
                /// Intermediate state changes between the two times don't affect the result. For example, the results
                /// aren't affected if the asset is removed and re-created again. Possible "state_change" values when
                /// compare_duration is specified: * "ADDED": indicates that the asset was not present at the start of
                /// compare_duration, but present at read_time. * "REMOVED": indicates that the asset was present at the
                /// start of compare_duration, but not present at read_time. * "ACTIVE": indicates that the asset was
                /// present at both the start and the end of the time period defined by compare_duration and read_time.
                /// If compare_duration is not specified, then the only possible state_change is "UNUSED", which will be
                /// the state_change set for all assets present at read_time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object CompareDuration { get; set; }

                /// <summary>
                /// A field mask to specify the ListAssetsResult fields to be listed in the response. An empty field
                /// mask will list all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object FieldMask { get; set; }

                /// <summary>
                /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
                /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has
                /// higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front
                /// of them to indicate negation. The fields map to those defined in the Asset resource. Examples
                /// include: * name * security_center_properties.resource_name * resource_properties.a_property *
                /// security_marks.marks.marka The supported operators are: * `=` for all value types. * `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for
                /// strings. The supported value types are: * string literals in quotes. * integer literals without
                /// quotes. * boolean literals `true` and `false` without quotes. The following are the allowed field
                /// and operator combinations: * name: `=` * update_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
                /// `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string. Examples:
                /// `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
                /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or
                /// an RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time =
                /// 1560208038000` * iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` * security_marks.marks: `=`, `:` *
                /// security_center_properties.resource_name: `=`, `:` *
                /// security_center_properties.resource_display_name: `=`, `:` *
                /// security_center_properties.resource_type: `=`, `:` * security_center_properties.resource_parent:
                /// `=`, `:` * security_center_properties.resource_parent_display_name: `=`, `:` *
                /// security_center_properties.resource_project: `=`, `:` *
                /// security_center_properties.resource_project_display_name: `=`, `:` *
                /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100`
                /// is a valid filter string. Use a partial match on the empty string to filter based on a property
                /// existing: `resource_properties.my_property : ""` Use a negated partial match on the empty string to
                /// filter based on a property not existing: `-resource_properties.my_property : ""`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Expression that defines what fields and order to use for sorting. The string value should follow SQL
                /// syntax: comma separated list of fields. For example: "name,resource_properties.a_property". The
                /// default sorting order is ascending. To specify descending order for a field, a suffix " desc" should
                /// be appended to the field name. For example: "name desc,resource_properties.a_property". Redundant
                /// space characters in the syntax are insignificant. "name desc,resource_properties.a_property" and "
                /// name desc , resource_properties.a_property " are equivalent. The following fields are supported:
                /// name update_time resource_properties security_marks.marks security_center_properties.resource_name
                /// security_center_properties.resource_display_name security_center_properties.resource_parent
                /// security_center_properties.resource_parent_display_name security_center_properties.resource_project
                /// security_center_properties.resource_project_display_name security_center_properties.resource_type
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAssetsResponse`; indicates that this is a continuation of a
                /// prior `ListAssets` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Time used as a reference point when filtering assets. The filter is limited to assets existing at
                /// the supplied time and their values are those at that specific time. Absence of this field will
                /// default to the API's version of NOW.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets";

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
                    RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                    {
                        Name = "compareDuration",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldMask",
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
                    RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates security marks.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of the SecurityMarks. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
            /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
            /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
            /// </param>
            public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
            {
                return new UpdateSecurityMarksRequest(service, body, name);
            }

            /// <summary>Updates security marks.</summary>
            public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
            {
                /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>
                /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can be
                /// updated using "marks.".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSecurityMarks";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/assets/[^/]+/securityMarks$",
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
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

        /// <summary>Gets the Sources resource.</summary>
        public virtual SourcesResource Sources { get; }

        /// <summary>The "sources" collection of methods.</summary>
        public class SourcesResource
        {
            private const string Resource = "sources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Findings = new FindingsResource(service);
            }

            /// <summary>Gets the Findings resource.</summary>
            public virtual FindingsResource Findings { get; }

            /// <summary>The "findings" collection of methods.</summary>
            public class FindingsResource
            {
                private const string Resource = "findings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the source to groupBy. Its format is
                /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-, or
                /// projects/{project_id}/sources/-
                /// </param>
                public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent)
                {
                    return new GroupRequest(service, body, parent);
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsResponse>
                {
                    /// <summary>Constructs a new Group request.</summary>
                    public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source to groupBy. Its format is
                    /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id
                    /// of `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-,
                    /// or projects/{project_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "group";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings:group";

                    /// <summary>Initializes Group parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                /// <param name="parent">
                /// Required. Name of the source the findings belong to. Its format is
                /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                /// projects/{projects_id}/sources/-
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListFindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source the findings belong to. Its format is
                    /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of
                    /// `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                    /// projects/{projects_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// When compare_duration is set, the ListFindingsResult's "state_change" attribute is updated to
                    /// indicate whether the finding had its state changed, the finding's state remained unchanged, or
                    /// if the finding was added in any state during the compare_duration period of time that precedes
                    /// the read_time. This is the time between (read_time - compare_duration) and read_time. The
                    /// state_change value is derived based on the presence and state of the finding at the two points
                    /// in time. Intermediate state changes between the two times don't affect the result. For example,
                    /// the results aren't affected if the finding is made inactive and then active again. Possible
                    /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the
                    /// finding was present and matched the given filter at the start of compare_duration, but changed
                    /// its state at read_time. * "UNCHANGED": indicates that the finding was present and matched the
                    /// given filter at the start of compare_duration and did not change state at read_time. * "ADDED":
                    /// indicates that the finding did not match the given filter or was not present at the start of
                    /// compare_duration, but was present at read_time. * "REMOVED": indicates that the finding was
                    /// present and matched the filter at the start of compare_duration, but did not match the filter at
                    /// read_time. If compare_duration is not specified, then the only possible state_change is
                    /// "UNUSED", which will be the state_change set for all findings present at read_time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CompareDuration { get; set; }

                    /// <summary>
                    /// A field mask to specify the Finding fields to be listed in the response. An empty field mask
                    /// will list all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object FieldMask { get; set; }

                    /// <summary>
                    /// Expression that defines the filter to apply across findings. The expression is a list of one or
                    /// more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and
                    /// `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-`
                    /// character in front of them to indicate negation. Examples include: * name *
                    /// source_properties.a_property * security_marks.marks.marka The supported operators are: * `=` for
                    /// all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`,
                    /// meaning substring matching, for strings. The supported value types are: * string literals in
                    /// quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
                    /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` *
                    /// resource_name: `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` *
                    /// event_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be
                    /// milliseconds since epoch or an RFC3339 string. Examples: `event_time =
                    /// "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` * workflow_state:
                    /// `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`,
                    /// `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
                    /// Use a partial match on the empty string to filter based on a property existing:
                    /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter
                    /// based on a property not existing: `-source_properties.my_property : ""` * resource: *
                    /// resource.name: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`,
                    /// `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.type:
                    /// `=`, `:` * resource.folders.resource_folder: `=`, `:`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Expression that defines what fields and order to use for sorting. The string value should follow
                    /// SQL syntax: comma separated list of fields. For example: "name,resource_properties.a_property".
                    /// The default sorting order is ascending. To specify descending order for a field, a suffix "
                    /// desc" should be appended to the field name. For example: "name
                    /// desc,source_properties.a_property". Redundant space characters in the syntax are insignificant.
                    /// "name desc,source_properties.a_property" and " name desc , source_properties.a_property " are
                    /// equivalent. The following fields are supported: name parent state category resource_name
                    /// event_time source_properties security_marks.marks
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListFindingsResponse`; indicates that this is a continuation of
                    /// a prior `ListFindings` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Time used as a reference point when filtering findings. The filter is limited to findings
                    /// existing at the supplied time and their values are those at that specific time. Absence of this
                    /// field will default to the API's version of NOW.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^projects/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "compareDuration",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldMask",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of this finding. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of this finding. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The FieldMask to use when updating the finding resource. This field should not be specified when
                    /// creating a finding. When updating a finding, an empty mask is treated as updating all mutable
                    /// fields and replacing source_properties. Individual source_properties can be added/updated by
                    /// using "source_properties." in the field mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+$",
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

                /// <summary>Updates the state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the finding. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}/finding/{finding_id}".
                /// </param>
                public virtual SetStateRequest SetState(Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name)
                {
                    return new SetStateRequest(service, body, name);
                }

                /// <summary>Updates the state of a finding.</summary>
                public class SetStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetState request.</summary>
                    public SetStateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the finding. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                    /// "organizations/{organization_id}/sources/{source_id}/finding/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setState";

                    /// <summary>Initializes SetState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates security marks.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </param>
                public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
                {
                    return new UpdateSecurityMarksRequest(service, body, name);
                }

                /// <summary>Updates security marks.</summary>
                public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
                {
                    /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                    public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of the SecurityMarks. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                    /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>
                    /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                    /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can
                    /// be updated using "marks.".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateSecurityMarks";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+/securityMarks$",
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
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

            /// <summary>Lists all sources belonging to an organization.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent of sources to list. Its format should be
            /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent of sources to list. Its format should be
                /// "organizations/[organization_id], folders/[folder_id], or projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSourcesResponse`; indicates that this is a continuation of a
                /// prior `ListSources` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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
        }
    }
}
namespace Google.Apis.SecurityCommandCenter.v1.Data
{
    /// <summary>
    /// Security Command Center representation of a Google Cloud resource. The Asset is a Security Command Center
    /// resource that captures information about a single Google Cloud resource. All modifications to an Asset are only
    /// within the context of Security Command Center and don't affect the referenced Google Cloud resource.
    /// </summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the resource. It's either "organizations/{organization_id}/assets/{asset_id}",
        /// "folders/{folder_id}/assets/{asset_id}" or "projects/{project_number}/assets/{asset_id}", depending on the
        /// closest CRM ancestor of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>The time at which the asset was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Cloud IAM Policy information associated with the Google Cloud resource described by the Security Command
        /// Center asset. This information is managed and defined by the Google Cloud resource and cannot be modified by
        /// the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicy")]
        public virtual IamPolicy IamPolicy { get; set; }

        /// <summary>
        /// The relative resource name of this asset. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/assets/{asset_id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Resource managed properties. These properties are managed and defined by the Google Cloud resource and
        /// cannot be modified by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> ResourceProperties { get; set; }

        /// <summary>
        /// Security Command Center managed properties. These properties are managed by Security Command Center and
        /// cannot be modified by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityCenterProperties")]
        public virtual SecurityCenterProperties SecurityCenterProperties { get; set; }

        /// <summary>
        /// User specified security marks. These marks are entirely managed by the user and come from the SecurityMarks
        /// resource that belongs to the asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual SecurityMarks SecurityMarks { get; set; }

        /// <summary>The time at which the asset was last updated or added in Cloud SCC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration used for Asset Discovery runs.</summary>
    public class AssetDiscoveryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The folder ids to use for filtering asset discovery. It consists of only digits, e.g., 756619654966.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderIds")]
        public virtual System.Collections.Generic.IList<string> FolderIds { get; set; }

        /// <summary>The mode to use for filtering asset discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusionMode")]
        public virtual string InclusionMode { get; set; }

        /// <summary>The project ids to use for filtering asset discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectIds")]
        public virtual System.Collections.Generic.IList<string> ProjectIds { get; set; }

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
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
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

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

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

    /// <summary>
    /// Security Command Center finding. A finding is a record of assessment data like security, risk, health, or
    /// privacy, that is ingested into Security Command Center for presentation, notification, analysis, policy testing,
    /// and enforcement. For example, a cross-site scripting (XSS) vulnerability in an App Engine application is a
    /// finding.
    /// </summary>
    public class Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the finding. It's either
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}" or
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}", depending on the closest CRM ancestor
        /// of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The additional taxonomy group within findings from a given source. This field is immutable after creation
        /// time. Example: "XSS_FLASH_INJECTION"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The time at which the event took place, or when an update to the finding occurred. For example, if the
        /// finding represents an open firewall it would capture the time the detector believes the firewall became
        /// open. The accuracy is determined by the detector. If the finding were to be resolved afterward, this time
        /// would reflect when the finding was resolved. Must not be set to a value greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>
        /// The relative resource name of this finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The relative resource name of the source the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. For example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is
        /// for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a
        /// non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is
        /// immutable after creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. User specified security marks. These marks are entirely managed by the user and come from the
        /// SecurityMarks resource that belongs to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual SecurityMarks SecurityMarks { get; set; }

        /// <summary>The severity of the finding. This field is managed by the source that writes the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Source specific properties. These properties are managed by the source that writes the finding. The key
        /// names in the source_properties map must be between 1 and 255 characters, and must start with a letter and
        /// contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        /// <summary>The state of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message that contains the resource name and display name of a folder resource.</summary>
    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full resource name of this folder. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        /// <summary>The user defined display name for this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

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
        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests specifying an
        /// invalid value will be rejected. Requests for policies with any conditional bindings must specify version 3.
        /// Policies without any conditional bindings may specify any valid value or leave the field unset. To learn
        /// which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud SCC's Notification</summary>
    public class GoogleCloudSecuritycenterV1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If it's a Finding based notification config, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual Finding Finding { get; set; }

        /// <summary>Name of the notification config that generated current notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        /// <summary>The Cloud resource tied to this notification's Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The human readable name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center finding. A finding is a record of assessment data (security, risk, health or privacy)
    /// ingested into Security Command Center for presentation, notification, analysis, policy testing, and enforcement.
    /// For example, an XSS vulnerability in an App Engine application is a finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV1p1beta1Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the finding. It's either
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}" or
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}", depending on the closest CRM ancestor
        /// of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The additional taxonomy group within findings from a given source. This field is immutable after creation
        /// time. Example: "XSS_FLASH_INJECTION"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The time at which the event took place, or when an update to the finding occurred. For example, if the
        /// finding represents an open firewall it would capture the time the detector believes the firewall became
        /// open. The accuracy is determined by the detector. If the finding were to be resolved afterward, this time
        /// would reflect when the finding was resolved. Must not be set to a value greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>
        /// The relative resource name of this finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The relative resource name of the source the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. For example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is
        /// for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a
        /// non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is
        /// immutable after creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. User specified security marks. These marks are entirely managed by the user and come from the
        /// SecurityMarks resource that belongs to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual GoogleCloudSecuritycenterV1p1beta1SecurityMarks SecurityMarks { get; set; }

        /// <summary>The severity of the finding. This field is managed by the source that writes the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Source specific properties. These properties are managed by the source that writes the finding. The key
        /// names in the source_properties map must be between 1 and 255 characters, and must start with a letter and
        /// contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        /// <summary>The state of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message that contains the resource name and display name of a folder resource.</summary>
    public class GoogleCloudSecuritycenterV1p1beta1Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full resource name of this folder. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        /// <summary>The user defined display name for this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security Command Center's Notification</summary>
    public class GoogleCloudSecuritycenterV1p1beta1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If it's a Finding based notification config, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Finding Finding { get; set; }

        /// <summary>Name of the notification config that generated current notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        /// <summary>The Cloud resource tied to the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV1p1beta1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1p1beta1Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The human readable name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1p1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User specified security marks that are attached to the parent Security Command Center resource. Security marks
    /// are scoped within a Security Command Center organization -- they can be modified and viewed by all users who
    /// have proper permissions on the organization.
    /// </summary>
    public class GoogleCloudSecuritycenterV1p1beta1SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the marks. Examples: "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "folders/{folder_id}/assets/{asset_id}/securityMarks"
        /// "projects/{project_number}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// Mutable user specified security marks belonging to the parent resource. Constraints are as follows: * Keys
        /// and values are treated as case insensitive * Keys must be between 1 - 256 characters (inclusive) * Keys must
        /// be letters, numbers, underscores, or dashes * Values have leading and trailing whitespace trimmed, remaining
        /// characters must be between 1 - 4096 characters (inclusive)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        /// <summary>
        /// The relative resource name of the SecurityMarks. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
        /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for grouping by assets.</summary>
    public class GroupAssetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When compare_duration is set, the GroupResult's "state_change" property is updated to indicate whether the
        /// asset was added, removed, or remained present during the compare_duration period of time that precedes the
        /// read_time. This is the time between (read_time - compare_duration) and read_time. The state change value is
        /// derived based on the presence of the asset at the two points in time. Intermediate state changes between the
        /// two times don't affect the result. For example, the results aren't affected if the asset is removed and
        /// re-created again. Possible "state_change" values when compare_duration is specified: * "ADDED": indicates
        /// that the asset was not present at the start of compare_duration, but present at reference_time. * "REMOVED":
        /// indicates that the asset was present at the start of compare_duration, but not present at reference_time. *
        /// "ACTIVE": indicates that the asset was present at both the start and the end of the time period defined by
        /// compare_duration and reference_time. If compare_duration is not specified, then the only possible
        /// state_change is "UNUSED", which will be the state_change set for all assets present at read_time. If this
        /// field is set then `state_change` must be a specified field in `group_by`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compareDuration")]
        public virtual object CompareDuration { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
        /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has higher
        /// precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front of them to
        /// indicate negation. The fields map to those defined in the Asset resource. Examples include: * name *
        /// security_center_properties.resource_name * resource_properties.a_property * security_marks.marks.marka The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// The following field and operator combinations are supported: * name: `=` * update_time: `=`, `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string.
        /// Examples: `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
        /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or an
        /// RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time = 1560208038000` *
        /// iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
        /// `&amp;lt;=` * security_marks.marks: `=`, `:` * security_center_properties.resource_name: `=`, `:` *
        /// security_center_properties.resource_display_name: `=`, `:` * security_center_properties.resource_type: `=`,
        /// `:` * security_center_properties.resource_parent: `=`, `:` *
        /// security_center_properties.resource_parent_display_name: `=`, `:` *
        /// security_center_properties.resource_project: `=`, `:` *
        /// security_center_properties.resource_project_display_name: `=`, `:` *
        /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100` is a
        /// valid filter string. Use a partial match on the empty string to filter based on a property existing:
        /// `resource_properties.my_property : ""` Use a negated partial match on the empty string to filter based on a
        /// property not existing: `-resource_properties.my_property : ""`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. Expression that defines what assets fields to use for grouping. The string value should follow SQL
        /// syntax: comma separated list of fields. For example:
        /// "security_center_properties.resource_project,security_center_properties.project". The following fields are
        /// supported when compare_duration is not set: * security_center_properties.resource_project *
        /// security_center_properties.resource_project_display_name * security_center_properties.resource_type *
        /// security_center_properties.resource_parent * security_center_properties.resource_parent_display_name The
        /// following fields are supported when compare_duration is set: * security_center_properties.resource_type *
        /// security_center_properties.resource_project_display_name *
        /// security_center_properties.resource_parent_display_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupBy")]
        public virtual string GroupBy { get; set; }

        /// <summary>
        /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The value returned by the last `GroupAssetsResponse`; indicates that this is a continuation of a prior
        /// `GroupAssets` call, and that the system should return the next page of data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Time used as a reference point when filtering assets. The filter is limited to assets existing at the
        /// supplied time and their values are those at that specific time. Absence of this field will default to the
        /// API's version of NOW.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for grouping by assets.</summary>
    public class GroupAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Group results. There exists an element for each existing unique combination of property/values. The element
        /// contains a count for the number of times those specific property/values appear.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupByResults")]
        public virtual System.Collections.Generic.IList<GroupResult> GroupByResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Time used for executing the groupBy request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The total number of results matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for grouping by findings.</summary>
    public class GroupFindingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When compare_duration is set, the GroupResult's "state_change" attribute is updated to indicate whether the
        /// finding had its state changed, the finding's state remained unchanged, or if the finding was added during
        /// the compare_duration period of time that precedes the read_time. This is the time between (read_time -
        /// compare_duration) and read_time. The state_change value is derived based on the presence and state of the
        /// finding at the two points in time. Intermediate state changes between the two times don't affect the result.
        /// For example, the results aren't affected if the finding is made inactive and then active again. Possible
        /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the finding was
        /// present and matched the given filter at the start of compare_duration, but changed its state at read_time. *
        /// "UNCHANGED": indicates that the finding was present and matched the given filter at the start of
        /// compare_duration and did not change state at read_time. * "ADDED": indicates that the finding did not match
        /// the given filter or was not present at the start of compare_duration, but was present at read_time. *
        /// "REMOVED": indicates that the finding was present and matched the filter at the start of compare_duration,
        /// but did not match the filter at read_time. If compare_duration is not specified, then the only possible
        /// state_change is "UNUSED", which will be the state_change set for all findings present at read_time. If this
        /// field is set then `state_change` must be a specified field in `group_by`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compareDuration")]
        public virtual object CompareDuration { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across findings. The expression is a list of one or more
        /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has higher
        /// precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front of them to
        /// indicate negation. Examples include: * name * source_properties.a_property * security_marks.marks.marka The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` * resource_name:
        /// `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` * event_time: `=`, `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string.
        /// Examples: `event_time = "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` *
        /// workflow_state: `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
        /// Use a partial match on the empty string to filter based on a property existing:
        /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter based on a
        /// property not existing: `-source_properties.my_property : ""` * resource: * resource.name: `=`, `:` *
        /// resource.parent_name: `=`, `:` * resource.parent_display_name: `=`, `:` * resource.project_name: `=`, `:` *
        /// resource.project_display_name: `=`, `:` * resource.type: `=`, `:`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. Expression that defines what assets fields to use for grouping (including `state_change`). The
        /// string value should follow SQL syntax: comma separated list of fields. For example: "parent,resource_name".
        /// The following fields are supported: * resource_name * category * state * parent * severity The following
        /// fields are supported when compare_duration is set: * state_change
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupBy")]
        public virtual string GroupBy { get; set; }

        /// <summary>
        /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The value returned by the last `GroupFindingsResponse`; indicates that this is a continuation of a prior
        /// `GroupFindings` call, and that the system should return the next page of data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Time used as a reference point when filtering findings. The filter is limited to findings existing at the
        /// supplied time and their values are those at that specific time. Absence of this field will default to the
        /// API's version of NOW.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for group by findings.</summary>
    public class GroupFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Group results. There exists an element for each existing unique combination of property/values. The element
        /// contains a count for the number of times those specific property/values appear.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupByResults")]
        public virtual System.Collections.Generic.IList<GroupResult> GroupByResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Time used for executing the groupBy request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The total number of results matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the properties and count of a groupBy request.</summary>
    public class GroupResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total count of resources for the given properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Properties matching the groupBy fields in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, object> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Cloud IAM Policy information associated with the Google Cloud resource described by the Security Command Center
    /// asset. This information is managed and defined by the Google Cloud resource and cannot be modified by the user.
    /// </summary>
    public class IamPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The JSON representation of the Policy associated with the asset. See
        /// https://cloud.google.com/iam/reference/rest/v1/Policy for format details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyBlob")]
        public virtual string PolicyBlob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing assets.</summary>
    public class ListAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Assets matching the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listAssetsResults")]
        public virtual System.Collections.Generic.IList<ListAssetsResult> ListAssetsResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Time used for executing the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The total number of assets matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the Asset and its State.</summary>
    public class ListAssetsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Asset matching the search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; }

        /// <summary>State change of the asset between the points in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateChange")]
        public virtual string StateChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing findings.</summary>
    public class ListFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Findings matching the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listFindingsResults")]
        public virtual System.Collections.Generic.IList<ListFindingsResult> ListFindingsResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Time used for executing the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual object ReadTime { get; set; }

        /// <summary>The total number of findings matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the Finding and its StateChange.</summary>
    public class ListFindingsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Finding matching the search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual Finding Finding { get; set; }

        /// <summary>Output only. Resource that is associated with this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>State change of the finding between the points in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateChange")]
        public virtual string StateChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing notification configs.</summary>
    public class ListNotificationConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Notification configs belonging to the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigs")]
        public virtual System.Collections.Generic.IList<NotificationConfig> NotificationConfigs { get; set; }

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

    /// <summary>Response message for listing sources.</summary>
    public class ListSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Sources belonging to the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<Source> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Cloud Security Command Center (Cloud SCC) notification configs. A notification config is a Cloud SCC resource
    /// that contains the configuration to send notifications for create/update events of findings, assets and etc.
    /// </summary>
    public class NotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the notification config (max of 1024 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The relative resource name of this notification config. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The Pub/Sub topic to send notifications to. Its format is "projects/[project_id]/topics/[topic]".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>
        /// Output only. The service account that needs "pubsub.topics.publish" permission to publish to the Pub/Sub
        /// topic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The config for triggering streaming-based notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingConfig")]
        public virtual StreamingConfig StreamingConfig { get; set; }

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

    /// <summary>User specified settings that are attached to the Security Command Center organization.</summary>
    public class OrganizationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration used for Asset Discovery runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetDiscoveryConfig")]
        public virtual AssetDiscoveryConfig AssetDiscoveryConfig { get; set; }

        /// <summary>
        /// A flag that indicates if Asset Discovery should be enabled. If the flag is set to `true`, then discovery of
        /// assets will occur. If it is set to `false, all historical assets will remain, but discovery of future assets
        /// will not occur.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAssetDiscovery")]
        public virtual System.Nullable<bool> EnableAssetDiscovery { get; set; }

        /// <summary>
        /// The relative resource name of the settings. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/organizationSettings".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
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

    /// <summary>Information related to the Google Cloud resource that is associated with this finding.</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains a Folder message for each folder in the assets ancestry. The first folder is the deepest nested
        /// folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentName")]
        public virtual string ParentName { get; set; }

        /// <summary>The human readable name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectName")]
        public virtual string ProjectName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for running asset discovery for an organization.</summary>
    public class RunAssetDiscoveryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center managed properties. These properties are managed by Security Command Center and cannot
    /// be modified by the user.
    /// </summary>
    public class SecurityCenterProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains a Folder message for each folder in the assets ancestry. The first folder is the deepest nested
        /// folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>The user defined display name for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceDisplayName")]
        public virtual string ResourceDisplayName { get; set; }

        /// <summary>
        /// The full resource name of the Google Cloud resource this asset represents. This field is immutable after
        /// create time. See: https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Owners of the Google Cloud resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceOwners")]
        public virtual System.Collections.Generic.IList<string> ResourceOwners { get; set; }

        /// <summary>
        /// The full resource name of the immediate parent of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceParent")]
        public virtual string ResourceParent { get; set; }

        /// <summary>The user defined display name for the parent of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceParentDisplayName")]
        public virtual string ResourceParentDisplayName { get; set; }

        /// <summary>
        /// The full resource name of the project the resource belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceProject")]
        public virtual string ResourceProject { get; set; }

        /// <summary>The user defined display name for the project of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceProjectDisplayName")]
        public virtual string ResourceProjectDisplayName { get; set; }

        /// <summary>
        /// The type of the Google Cloud resource. Examples include: APPLICATION, PROJECT, and ORGANIZATION. This is a
        /// case insensitive field defined by Security Command Center and/or the producer of the resource and is
        /// immutable after create time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User specified security marks that are attached to the parent Security Command Center resource. Security marks
    /// are scoped within a Security Command Center organization -- they can be modified and viewed by all users who
    /// have proper permissions on the organization.
    /// </summary>
    public class SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the marks. Examples: "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "folders/{folder_id}/assets/{asset_id}/securityMarks"
        /// "projects/{project_number}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// Mutable user specified security marks belonging to the parent resource. Constraints are as follows: * Keys
        /// and values are treated as case insensitive * Keys must be between 1 - 256 characters (inclusive) * Keys must
        /// be letters, numbers, underscores, or dashes * Values have leading and trailing whitespace trimmed, remaining
        /// characters must be between 1 - 4096 characters (inclusive)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        /// <summary>
        /// The relative resource name of the SecurityMarks. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
        /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for updating a finding's state.</summary>
    public class SetFindingStateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The time at which the updated state takes effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Required. The desired State of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
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
    /// Security Command Center finding source. A finding source is an entity or a mechanism that can produce a finding.
    /// A source is like a container of findings that come from the same scanner, logger, monitor, and other tools.
    /// </summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the finding. It's either "organizations/{organization_id}/sources/{source_id}",
        /// "folders/{folder_id}/sources/{source_id}" or "projects/{project_number}/sources/{source_id}", depending on
        /// the closest CRM ancestor of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The description of the source (max of 1024 characters). Example: "Web Security Scanner is a web security
        /// scanner for common vulnerabilities in App Engine applications. It can automatically scan and detect four
        /// common vulnerabilities, including cross-site-scripting (XSS), Flash injection, mixed content (HTTP in
        /// HTTPS), and outdated or insecure libraries."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The source's display name. A source's display name must be unique amongst its siblings, for example, two
        /// sources with the same parent can't share the same display name. The display name must have a length between
        /// 1 and 64 characters (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The relative resource name of this source. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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
    /// The config for streaming-based notifications, which send each event as soon as it is detected.
    /// </summary>
    public class StreamingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Expression that defines the filter to apply across create/update events of assets or findings as specified
        /// by the event type. The expression is a list of zero or more restrictions combined via logical operators
        /// `AND` and `OR`. Parentheses are supported, and `OR` has higher precedence than `AND`. Restrictions have the
        /// form ` ` and may have a `-` character in front of them to indicate negation. The fields map to those defined
        /// in the corresponding resource. The supported operators are: * `=` for all value types. * `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for strings. The
        /// supported value types are: * string literals in quotes. * integer literals without quotes. * boolean
        /// literals `true` and `false` without quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
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
