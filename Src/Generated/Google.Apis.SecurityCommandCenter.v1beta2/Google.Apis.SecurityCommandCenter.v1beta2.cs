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

namespace Google.Apis.SecurityCommandCenter.v1beta2
{
    /// <summary>The SecurityCommandCenter Service.</summary>
    public class SecurityCommandCenterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta2";

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
            ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
            EventThreatDetectionSettings = new EventThreatDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            WebSecurityScannerSettings = new WebSecurityScannerSettingsResource(service);
        }

        /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
        public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

        /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
        public class ContainerThreatDetectionSettingsResource
        {
            private const string Resource = "containerThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/containerThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the EventThreatDetectionSettings resource.</summary>
        public virtual EventThreatDetectionSettingsResource EventThreatDetectionSettings { get; }

        /// <summary>The "eventThreatDetectionSettings" collection of methods.</summary>
        public class EventThreatDetectionSettingsResource
        {
            private const string Resource = "eventThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EventThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/eventThreatDetectionSettings *
                /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/eventThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
                /// organizations/{organization}/securityHealthAnalyticsSettings *
                /// folders/{folder}/securityHealthAnalyticsSettings *
                /// projects/{project}/securityHealthAnalyticsSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the WebSecurityScannerSettings resource.</summary>
        public virtual WebSecurityScannerSettingsResource WebSecurityScannerSettings { get; }

        /// <summary>The "webSecurityScannerSettings" collection of methods.</summary>
        public class WebSecurityScannerSettingsResource
        {
            private const string Resource = "webSecurityScannerSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebSecurityScannerSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
                /// organizations/{organization}/webSecurityScannerSettings *
                /// folders/{folder}/webSecurityScannerSettings * projects/{project}/webSecurityScannerSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/webSecurityScannerSettings$",
                    });
                }
            }
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/containerThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/eventThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
                });
            }
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(service, name);
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/webSecurityScannerSettings$",
                });
            }
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the ContainerThreatDetectionSettings. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/containerThreatDetectionSettings$",
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

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the EventThreatDetectionSettings. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/eventThreatDetectionSettings$",
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

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(service, body, name);
        }

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
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

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(service, body, name);
        }

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the WebSecurityScannerSettings. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/webSecurityScannerSettings$",
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
            ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
            EventThreatDetectionSettings = new EventThreatDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            WebSecurityScannerSettings = new WebSecurityScannerSettingsResource(service);
        }

        /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
        public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

        /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
        public class ContainerThreatDetectionSettingsResource
        {
            private const string Resource = "containerThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/containerThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the EventThreatDetectionSettings resource.</summary>
        public virtual EventThreatDetectionSettingsResource EventThreatDetectionSettings { get; }

        /// <summary>The "eventThreatDetectionSettings" collection of methods.</summary>
        public class EventThreatDetectionSettingsResource
        {
            private const string Resource = "eventThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EventThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/eventThreatDetectionSettings *
                /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/eventThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
                /// organizations/{organization}/securityHealthAnalyticsSettings *
                /// folders/{folder}/securityHealthAnalyticsSettings *
                /// projects/{project}/securityHealthAnalyticsSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the WebSecurityScannerSettings resource.</summary>
        public virtual WebSecurityScannerSettingsResource WebSecurityScannerSettings { get; }

        /// <summary>The "webSecurityScannerSettings" collection of methods.</summary>
        public class WebSecurityScannerSettingsResource
        {
            private const string Resource = "webSecurityScannerSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebSecurityScannerSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
                /// organizations/{organization}/webSecurityScannerSettings *
                /// folders/{folder}/webSecurityScannerSettings * projects/{project}/webSecurityScannerSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/webSecurityScannerSettings$",
                    });
                }
            }
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/containerThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/eventThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityCenterSettings to retrieve. Format:
        /// organizations/{organization}/securityCenterSettings
        /// </param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        public class GetSecurityCenterSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityCenterSettings>
        {
            /// <summary>Constructs a new GetSecurityCenterSettings request.</summary>
            public GetSecurityCenterSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityCenterSettings to retrieve. Format:
            /// organizations/{organization}/securityCenterSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityCenterSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityCenterSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/securityCenterSettings$",
                });
            }
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
                });
            }
        }

        /// <summary>Get the Subscription resource.</summary>
        /// <param name="name">
        /// Required. The name of the subscription to retrieve. Format: organizations/{organization}/subscription
        /// </param>
        public virtual GetSubscriptionRequest GetSubscription(string name)
        {
            return new GetSubscriptionRequest(service, name);
        }

        /// <summary>Get the Subscription resource.</summary>
        public class GetSubscriptionRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.Subscription>
        {
            /// <summary>Constructs a new GetSubscription request.</summary>
            public GetSubscriptionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the subscription to retrieve. Format: organizations/{organization}/subscription
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSubscription";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSubscription parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/subscription$",
                });
            }
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(service, name);
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/webSecurityScannerSettings$",
                });
            }
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the ContainerThreatDetectionSettings. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/containerThreatDetectionSettings$",
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

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the EventThreatDetectionSettings. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/eventThreatDetectionSettings$",
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

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(service, body, name);
        }

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
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

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(service, body, name);
        }

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the WebSecurityScannerSettings. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/webSecurityScannerSettings$",
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
            ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
            EventThreatDetectionSettings = new EventThreatDetectionSettingsResource(service);
            Locations = new LocationsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            WebSecurityScannerSettings = new WebSecurityScannerSettingsResource(service);
        }

        /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
        public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

        /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
        public class ContainerThreatDetectionSettingsResource
        {
            private const string Resource = "containerThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/containerThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the EventThreatDetectionSettings resource.</summary>
        public virtual EventThreatDetectionSettingsResource EventThreatDetectionSettings { get; }

        /// <summary>The "eventThreatDetectionSettings" collection of methods.</summary>
        public class EventThreatDetectionSettingsResource
        {
            private const string Resource = "eventThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EventThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/eventThreatDetectionSettings *
                /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/eventThreatDetectionSettings$",
                    });
                }
            }
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
                Clusters = new ClustersResource(service);
            }

            /// <summary>Gets the Clusters resource.</summary>
            public virtual ClustersResource Clusters { get; }

            /// <summary>The "clusters" collection of methods.</summary>
            public class ClustersResource
            {
                private const string Resource = "clusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
                }

                /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
                public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

                /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
                public class ContainerThreatDetectionSettingsResource
                {
                    private const string Resource = "containerThreatDetectionSettings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource
                    /// hierarchy and its settings.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                    /// organizations/{organization}/containerThreatDetectionSettings *
                    /// folders/{folder}/containerThreatDetectionSettings *
                    /// projects/{project}/containerThreatDetectionSettings *
                    /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                    /// </param>
                    public virtual CalculateRequest Calculate(string name)
                    {
                        return new CalculateRequest(service, name);
                    }

                    /// <summary>
                    /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource
                    /// hierarchy and its settings.
                    /// </summary>
                    public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                    {
                        /// <summary>Constructs a new Calculate request.</summary>
                        public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                        /// organizations/{organization}/containerThreatDetectionSettings *
                        /// folders/{folder}/containerThreatDetectionSettings *
                        /// projects/{project}/containerThreatDetectionSettings *
                        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "calculate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta2/{+name}:calculate";

                        /// <summary>Initializes Calculate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/containerThreatDetectionSettings$",
                            });
                        }
                    }
                }

                /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
                /// <param name="name">
                /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </param>
                public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
                {
                    return new GetContainerThreatDetectionSettingsRequest(service, name);
                }

                /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
                public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                {
                    /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
                    public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
                    /// organizations/{organization}/containerThreatDetectionSettings *
                    /// folders/{folder}/containerThreatDetectionSettings *
                    /// projects/{project}/containerThreatDetectionSettings *
                    /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getContainerThreatDetectionSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

                    /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/containerThreatDetectionSettings$",
                        });
                    }
                }

                /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the ContainerThreatDetectionSettings. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </param>
                public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
                {
                    return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
                }

                /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
                public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                {
                    /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
                    public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the ContainerThreatDetectionSettings. Formats: *
                    /// organizations/{organization}/containerThreatDetectionSettings *
                    /// folders/{folder}/containerThreatDetectionSettings *
                    /// projects/{project}/containerThreatDetectionSettings *
                    /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateContainerThreatDetectionSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

                    /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/containerThreatDetectionSettings$",
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

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
                /// organizations/{organization}/securityHealthAnalyticsSettings *
                /// folders/{folder}/securityHealthAnalyticsSettings *
                /// projects/{project}/securityHealthAnalyticsSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the WebSecurityScannerSettings resource.</summary>
        public virtual WebSecurityScannerSettingsResource WebSecurityScannerSettings { get; }

        /// <summary>The "webSecurityScannerSettings" collection of methods.</summary>
        public class WebSecurityScannerSettingsResource
        {
            private const string Resource = "webSecurityScannerSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebSecurityScannerSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
                /// organizations/{organization}/webSecurityScannerSettings *
                /// folders/{folder}/webSecurityScannerSettings * projects/{project}/webSecurityScannerSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/webSecurityScannerSettings$",
                    });
                }
            }
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/containerThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/eventThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
                });
            }
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(service, name);
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/webSecurityScannerSettings$",
                });
            }
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the ContainerThreatDetectionSettings. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/containerThreatDetectionSettings$",
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

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the EventThreatDetectionSettings. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/eventThreatDetectionSettings$",
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

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(service, body, name);
        }

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
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

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(service, body, name);
        }

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the WebSecurityScannerSettings. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/webSecurityScannerSettings$",
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
namespace Google.Apis.SecurityCommandCenter.v1beta2.Data
{
    /// <summary>Configuration of a module.</summary>
    public class Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of enablement for the module at its level of the resource hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleEnablementState")]
        public virtual string ModuleEnablementState { get; set; }

        /// <summary>
        /// The configuration value for the module. The absence of this field implies its inheritance from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Container Threat Detection service.</summary>
    public class ContainerThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The service account used by Container Threat Detection for scanning. Service accounts are
        /// scoped at the project level meaning this field will be empty at any level above a project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a subscription.</summary>
    public class Details : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time the subscription has or will end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The time the subscription has or will start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The type of subscription</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Event Threat Detection service.</summary>
    public class EventThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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

        /// <summary>The class of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingClass")]
        public virtual string FindingClass { get; set; }

        /// <summary>
        /// Represents what's commonly known as an Indicator of compromise (IoC) in computer forensics. This is an
        /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
        /// intrusion. Reference: https://en.wikipedia.org/wiki/Indicator_of_compromise
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indicator")]
        public virtual Indicator Indicator { get; set; }

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

    /// <summary>
    /// Represents what's commonly known as an Indicator of compromise (IoC) in computer forensics. This is an artifact
    /// observed on a network or in an operating system that, with high confidence, indicates a computer intrusion.
    /// Reference: https://en.wikipedia.org/wiki/Indicator_of_compromise
    /// </summary>
    public class Indicator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domains associated to the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>List of ip addresses associated to the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for Security Center.</summary>
    public class SecurityCenterSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the project to send logs to. This project must be part of the organization this
        /// resource resides in. The format is `projects/{project_id}`. An empty value disables logging. This value is
        /// only referenced by services that support log sink. Please refer to the documentation for an updated list of
        /// compatible services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logSinkProject")]
        public virtual string LogSinkProject { get; set; }

        /// <summary>
        /// The resource name of the SecurityCenterSettings. Format: organizations/{organization}/securityCenterSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The organization level service account to be used for security center components.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgServiceAccount")]
        public virtual string OrgServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Security Health Analytics service.</summary>
    public class SecurityHealthAnalyticsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The service account used by Security Health Analytics detectors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

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

    /// <summary>Resource capturing the state of an organization's subscription.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The details of the most recent active subscription. If there has never been a subscription this will be
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual Details Details { get; set; }

        /// <summary>The resource name of the subscription. Format: organizations/{organization}/subscription</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The tier of SCC features this organization currently has access to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Web Security Scanner service.</summary>
    public class WebSecurityScannerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
