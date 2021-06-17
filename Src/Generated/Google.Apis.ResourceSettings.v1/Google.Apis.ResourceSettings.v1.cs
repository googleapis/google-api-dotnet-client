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

namespace Google.Apis.ResourceSettings.v1
{
    /// <summary>The ResourceSettings Service.</summary>
    public class ResourceSettingsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ResourceSettingsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ResourceSettingsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "resourcesettings";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://resourcesettings.googleapis.com/";
        #else
            "https://resourcesettings.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://resourcesettings.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Resource Settings API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Resource Settings API.</summary>
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

    /// <summary>A base abstract class for ResourceSettings requests.</summary>
    public abstract class ResourceSettingsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ResourceSettingsBaseServiceRequest instance.</summary>
        protected ResourceSettingsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ResourceSettings parameter list.</summary>
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
            Settings = new SettingsResource(service);
        }

        /// <summary>Gets the Settings resource.</summary>
        public virtual SettingsResource Settings { get; }

        /// <summary>The "settings" collection of methods.</summary>
        public class SettingsResource
        {
            private const string Resource = "settings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the setting to get. See Setting for naming requirements.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist.
            /// </summary>
            public class GetRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the setting to get. See Setting for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The SettingView for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The SettingView for this request.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The default / unset value. The API will default to the SETTING_VIEW_BASIC view.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_UNSPECIFIED")]
                    SETTINGVIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Include Setting.metadata, but nothing else. This is the default value (for both ListSettings and
                    /// GetSetting).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_BASIC")]
                    SETTINGVIEWBASIC = 1,

                    /// <summary>Include Setting.effective_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_EFFECTIVE_VALUE")]
                    SETTINGVIEWEFFECTIVEVALUE = 2,

                    /// <summary>Include Setting.local_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_LOCAL_VALUE")]
                    SETTINGVIEWLOCALVALUE = 3,
                }

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
                        Pattern = @"^folders/[^/]+/settings/[^/]+$",
                    });
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all the settings that are available on the Cloud resource `parent`.</summary>
            /// <param name="parent">
            /// Required. The project, folder, or organization that is the parent resource for this setting. Must be in
            /// one of the following forms: * `projects/{project_number}` * `projects/{project_id}` *
            /// `folders/{folder_id}` * `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the settings that are available on the Cloud resource `parent`.</summary>
            public class ListRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1ListSettingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project, folder, or organization that is the parent resource for this setting. Must be
                /// in one of the following forms: * `projects/{project_number}` * `projects/{project_id}` *
                /// `folders/{folder_id}` * `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Unused. The size of the page to be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Unused. A page token used to retrieve the next page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The SettingView for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The SettingView for this request.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The default / unset value. The API will default to the SETTING_VIEW_BASIC view.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_UNSPECIFIED")]
                    SETTINGVIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Include Setting.metadata, but nothing else. This is the default value (for both ListSettings and
                    /// GetSetting).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_BASIC")]
                    SETTINGVIEWBASIC = 1,

                    /// <summary>Include Setting.effective_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_EFFECTIVE_VALUE")]
                    SETTINGVIEWEFFECTIVEVALUE = 2,

                    /// <summary>Include Setting.local_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_LOCAL_VALUE")]
                    SETTINGVIEWLOCALVALUE = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/settings";

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
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if the
            /// setting is flagged as read only. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the
            /// etag supplied in the request does not match the persisted etag of the setting value. On success, the
            /// response will contain only `name`, `local_value` and `etag`. The `metadata` and `effective_value` cannot
            /// be updated through this API. Note: the supplied setting will perform a full overwrite of the
            /// `local_value` field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the setting. Must be in one of the following forms: *
            /// `projects/{project_number}/settings/{setting_name}` * `folders/{folder_id}/settings/{setting_name}` *
            /// `organizations/{organization_id}/settings/{setting_name}` For example,
            /// "/projects/123/settings/gcp-enableMyFeature"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if the
            /// setting is flagged as read only. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the
            /// etag supplied in the request does not match the persisted etag of the setting value. On success, the
            /// response will contain only `name`, `local_value` and `etag`. The `metadata` and `effective_value` cannot
            /// be updated through this API. Note: the supplied setting will perform a full overwrite of the
            /// `local_value` field.
            /// </summary>
            public class PatchRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the setting. Must be in one of the following forms: *
                /// `projects/{project_number}/settings/{setting_name}` * `folders/{folder_id}/settings/{setting_name}`
                /// * `organizations/{organization_id}/settings/{setting_name}` For example,
                /// "/projects/123/settings/gcp-enableMyFeature"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting Body { get; set; }

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
                        Pattern = @"^folders/[^/]+/settings/[^/]+$",
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
            Settings = new SettingsResource(service);
        }

        /// <summary>Gets the Settings resource.</summary>
        public virtual SettingsResource Settings { get; }

        /// <summary>The "settings" collection of methods.</summary>
        public class SettingsResource
        {
            private const string Resource = "settings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the setting to get. See Setting for naming requirements.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist.
            /// </summary>
            public class GetRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the setting to get. See Setting for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The SettingView for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The SettingView for this request.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The default / unset value. The API will default to the SETTING_VIEW_BASIC view.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_UNSPECIFIED")]
                    SETTINGVIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Include Setting.metadata, but nothing else. This is the default value (for both ListSettings and
                    /// GetSetting).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_BASIC")]
                    SETTINGVIEWBASIC = 1,

                    /// <summary>Include Setting.effective_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_EFFECTIVE_VALUE")]
                    SETTINGVIEWEFFECTIVEVALUE = 2,

                    /// <summary>Include Setting.local_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_LOCAL_VALUE")]
                    SETTINGVIEWLOCALVALUE = 3,
                }

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
                        Pattern = @"^organizations/[^/]+/settings/[^/]+$",
                    });
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all the settings that are available on the Cloud resource `parent`.</summary>
            /// <param name="parent">
            /// Required. The project, folder, or organization that is the parent resource for this setting. Must be in
            /// one of the following forms: * `projects/{project_number}` * `projects/{project_id}` *
            /// `folders/{folder_id}` * `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the settings that are available on the Cloud resource `parent`.</summary>
            public class ListRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1ListSettingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project, folder, or organization that is the parent resource for this setting. Must be
                /// in one of the following forms: * `projects/{project_number}` * `projects/{project_id}` *
                /// `folders/{folder_id}` * `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Unused. The size of the page to be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Unused. A page token used to retrieve the next page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The SettingView for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The SettingView for this request.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The default / unset value. The API will default to the SETTING_VIEW_BASIC view.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_UNSPECIFIED")]
                    SETTINGVIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Include Setting.metadata, but nothing else. This is the default value (for both ListSettings and
                    /// GetSetting).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_BASIC")]
                    SETTINGVIEWBASIC = 1,

                    /// <summary>Include Setting.effective_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_EFFECTIVE_VALUE")]
                    SETTINGVIEWEFFECTIVEVALUE = 2,

                    /// <summary>Include Setting.local_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_LOCAL_VALUE")]
                    SETTINGVIEWLOCALVALUE = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/settings";

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
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if the
            /// setting is flagged as read only. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the
            /// etag supplied in the request does not match the persisted etag of the setting value. On success, the
            /// response will contain only `name`, `local_value` and `etag`. The `metadata` and `effective_value` cannot
            /// be updated through this API. Note: the supplied setting will perform a full overwrite of the
            /// `local_value` field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the setting. Must be in one of the following forms: *
            /// `projects/{project_number}/settings/{setting_name}` * `folders/{folder_id}/settings/{setting_name}` *
            /// `organizations/{organization_id}/settings/{setting_name}` For example,
            /// "/projects/123/settings/gcp-enableMyFeature"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if the
            /// setting is flagged as read only. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the
            /// etag supplied in the request does not match the persisted etag of the setting value. On success, the
            /// response will contain only `name`, `local_value` and `etag`. The `metadata` and `effective_value` cannot
            /// be updated through this API. Note: the supplied setting will perform a full overwrite of the
            /// `local_value` field.
            /// </summary>
            public class PatchRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the setting. Must be in one of the following forms: *
                /// `projects/{project_number}/settings/{setting_name}` * `folders/{folder_id}/settings/{setting_name}`
                /// * `organizations/{organization_id}/settings/{setting_name}` For example,
                /// "/projects/123/settings/gcp-enableMyFeature"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/settings/[^/]+$",
                    });
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
            Settings = new SettingsResource(service);
        }

        /// <summary>Gets the Settings resource.</summary>
        public virtual SettingsResource Settings { get; }

        /// <summary>The "settings" collection of methods.</summary>
        public class SettingsResource
        {
            private const string Resource = "settings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the setting to get. See Setting for naming requirements.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Returns a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist.
            /// </summary>
            public class GetRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the setting to get. See Setting for naming requirements.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The SettingView for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The SettingView for this request.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The default / unset value. The API will default to the SETTING_VIEW_BASIC view.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_UNSPECIFIED")]
                    SETTINGVIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Include Setting.metadata, but nothing else. This is the default value (for both ListSettings and
                    /// GetSetting).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_BASIC")]
                    SETTINGVIEWBASIC = 1,

                    /// <summary>Include Setting.effective_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_EFFECTIVE_VALUE")]
                    SETTINGVIEWEFFECTIVEVALUE = 2,

                    /// <summary>Include Setting.local_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_LOCAL_VALUE")]
                    SETTINGVIEWLOCALVALUE = 3,
                }

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
                        Pattern = @"^projects/[^/]+/settings/[^/]+$",
                    });
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all the settings that are available on the Cloud resource `parent`.</summary>
            /// <param name="parent">
            /// Required. The project, folder, or organization that is the parent resource for this setting. Must be in
            /// one of the following forms: * `projects/{project_number}` * `projects/{project_id}` *
            /// `folders/{folder_id}` * `organizations/{organization_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all the settings that are available on the Cloud resource `parent`.</summary>
            public class ListRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1ListSettingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The project, folder, or organization that is the parent resource for this setting. Must be
                /// in one of the following forms: * `projects/{project_number}` * `projects/{project_id}` *
                /// `folders/{folder_id}` * `organizations/{organization_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Unused. The size of the page to be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Unused. A page token used to retrieve the next page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The SettingView for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>The SettingView for this request.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// The default / unset value. The API will default to the SETTING_VIEW_BASIC view.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_UNSPECIFIED")]
                    SETTINGVIEWUNSPECIFIED = 0,

                    /// <summary>
                    /// Include Setting.metadata, but nothing else. This is the default value (for both ListSettings and
                    /// GetSetting).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_BASIC")]
                    SETTINGVIEWBASIC = 1,

                    /// <summary>Include Setting.effective_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_EFFECTIVE_VALUE")]
                    SETTINGVIEWEFFECTIVEVALUE = 2,

                    /// <summary>Include Setting.local_value, but nothing else.</summary>
                    [Google.Apis.Util.StringValueAttribute("SETTING_VIEW_LOCAL_VALUE")]
                    SETTINGVIEWLOCALVALUE = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/settings";

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
                    RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if the
            /// setting is flagged as read only. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the
            /// etag supplied in the request does not match the persisted etag of the setting value. On success, the
            /// response will contain only `name`, `local_value` and `etag`. The `metadata` and `effective_value` cannot
            /// be updated through this API. Note: the supplied setting will perform a full overwrite of the
            /// `local_value` field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The resource name of the setting. Must be in one of the following forms: *
            /// `projects/{project_number}/settings/{setting_name}` * `folders/{folder_id}/settings/{setting_name}` *
            /// `organizations/{organization_id}/settings/{setting_name}` For example,
            /// "/projects/123/settings/gcp-enableMyFeature"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a specified setting. Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
            /// setting does not exist. Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if the
            /// setting is flagged as read only. Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the
            /// etag supplied in the request does not match the persisted etag of the setting value. On success, the
            /// response will contain only `name`, `local_value` and `etag`. The `metadata` and `effective_value` cannot
            /// be updated through this API. Note: the supplied setting will perform a full overwrite of the
            /// `local_value` field.
            /// </summary>
            public class PatchRequest : ResourceSettingsBaseServiceRequest<Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the setting. Must be in one of the following forms: *
                /// `projects/{project_number}/settings/{setting_name}` * `folders/{folder_id}/settings/{setting_name}`
                /// * `organizations/{organization_id}/settings/{setting_name}` For example,
                /// "/projects/123/settings/gcp-enableMyFeature"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ResourceSettings.v1.Data.GoogleCloudResourcesettingsV1Setting Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/settings/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.ResourceSettings.v1.Data
{
    /// <summary>The response from ListSettings.</summary>
    public class GoogleCloudResourcesettingsV1ListSettingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unused. A page token used to retrieve the next page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of settings that are available at the specified Cloud resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual System.Collections.Generic.IList<GoogleCloudResourcesettingsV1Setting> Settings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The schema for settings.</summary>
    public class GoogleCloudResourcesettingsV1Setting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The effective value of the setting at the given parent resource, evaluated based on the
        /// resource hierarchy The effective value evaluates to one of the following options, in this order. If an
        /// option is not valid or doesn't exist, then the next option is used: 1. The local setting value on the given
        /// resource: Setting.local_value 2. If one of the given resource's ancestors in the resource hierarchy have a
        /// local setting value, the local value at the nearest such ancestor. 3. The setting's default value:
        /// SettingMetadata.default_value 4. An empty value, defined as a `Value` with all fields unset. The data type
        /// of Value must always be consistent with the data type defined in Setting.metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveValue")]
        public virtual GoogleCloudResourcesettingsV1Value EffectiveValue { get; set; }

        /// <summary>A fingerprint used for optimistic concurrency. See UpdateSetting for more details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The configured value of the setting at the given parent resource, ignoring the resource hierarchy. The data
        /// type of Value must always be consistent with the data type defined in Setting.metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localValue")]
        public virtual GoogleCloudResourcesettingsV1Value LocalValue { get; set; }

        /// <summary>Output only. Metadata about a setting which is not editable by the end user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual GoogleCloudResourcesettingsV1SettingMetadata Metadata { get; set; }

        /// <summary>
        /// The resource name of the setting. Must be in one of the following forms: *
        /// `projects/{project_number}/settings/{setting_name}` * `folders/{folder_id}/settings/{setting_name}` *
        /// `organizations/{organization_id}/settings/{setting_name}` For example,
        /// "/projects/123/settings/gcp-enableMyFeature"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }
    }

    /// <summary>Metadata about a setting which is not editable by the end user.</summary>
    public class GoogleCloudResourcesettingsV1SettingMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data type for this setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>
        /// The value provided by Setting.effective_value if no setting value is explicitly set. Note: not all settings
        /// have a default value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual GoogleCloudResourcesettingsV1Value DefaultValue { get; set; }

        /// <summary>A detailed description of what this setting does.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable name for this setting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// A flag indicating that values of this setting cannot be modified. See documentation for the specific setting
        /// for updates and reasons.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data in a setting value.</summary>
    public class GoogleCloudResourcesettingsV1Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines this value as being a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>Defines this value as being a Duration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationValue")]
        public virtual object DurationValue { get; set; }

        /// <summary>Defines this value as being a Enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enumValue")]
        public virtual GoogleCloudResourcesettingsV1ValueEnumValue EnumValue { get; set; }

        /// <summary>Defines this value as being a StringMap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringMapValue")]
        public virtual GoogleCloudResourcesettingsV1ValueStringMap StringMapValue { get; set; }

        /// <summary>Defines this value as being a StringSet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringSetValue")]
        public virtual GoogleCloudResourcesettingsV1ValueStringSet StringSetValue { get; set; }

        /// <summary>Defines this value as being a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A enum value that can hold any enum type setting values. Each enum type is represented by a number, this
    /// representation is stored in the definitions.
    /// </summary>
    public class GoogleCloudResourcesettingsV1ValueEnumValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of this enum</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A string-&amp;gt;string map value that can hold a map of string keys to string values. The maximum length of
    /// each string is 200 characters and there can be a maximum of 50 key-value pairs in the map.
    /// </summary>
    public class GoogleCloudResourcesettingsV1ValueStringMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key-value pairs in the map</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mappings")]
        public virtual System.Collections.Generic.IDictionary<string, string> Mappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A string set value that can hold a set of strings. The maximum length of each string is 200 characters and there
    /// can be a maximum of 50 strings in the string set.
    /// </summary>
    public class GoogleCloudResourcesettingsV1ValueStringSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The strings in the set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
