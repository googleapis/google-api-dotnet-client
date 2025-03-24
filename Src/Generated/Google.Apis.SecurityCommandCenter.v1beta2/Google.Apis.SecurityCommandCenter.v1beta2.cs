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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://securitycenter.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://securitycenter.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "securitycenter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Security Command Center API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Security Command Center API.</summary>
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
            RapidVulnerabilityDetectionSettings = new RapidVulnerabilityDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            VirtualMachineThreatDetectionSettings = new VirtualMachineThreatDetectionSettingsResource(service);
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
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            /// its settings. Settings provided closer to the target resource take precedence over those further away
            /// (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings. Settings provided closer to the target resource take precedence over those further away
            /// (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the RapidVulnerabilityDetectionSettings resource.</summary>
        public virtual RapidVulnerabilityDetectionSettingsResource RapidVulnerabilityDetectionSettings { get; }

        /// <summary>The "rapidVulnerabilityDetectionSettings" collection of methods.</summary>
        public class RapidVulnerabilityDetectionSettingsResource
        {
            private const string Resource = "rapidVulnerabilityDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RapidVulnerabilityDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
                /// folders/{folder}/rapidVulnerabilityDetectionSettings *
                /// projects/{project}/rapidVulnerabilityDetectionSettings
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
                        Pattern = @"^folders/[^/]+/rapidVulnerabilityDetectionSettings$",
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
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the VirtualMachineThreatDetectionSettings resource.</summary>
        public virtual VirtualMachineThreatDetectionSettingsResource VirtualMachineThreatDetectionSettings { get; }

        /// <summary>The "virtualMachineThreatDetectionSettings" collection of methods.</summary>
        public class VirtualMachineThreatDetectionSettingsResource
        {
            private const string Resource = "virtualMachineThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VirtualMachineThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/virtualMachineThreatDetectionSettings *
                /// folders/{folder}/virtualMachineThreatDetectionSettings *
                /// projects/{project}/virtualMachineThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                        Pattern = @"^folders/[^/]+/virtualMachineThreatDetectionSettings$",
                    });
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            /// settings. Settings provided closer to the target resource take precedence over those further away (e.g.
            /// folder will override organization level settings). The default SCC setting for the detector service
            /// defaults can be overridden at organization, folder and project levels. No assumptions should be made
            /// about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings. Settings provided closer to the target resource take precedence over those further away (e.g.
            /// folder will override organization level settings). The default SCC setting for the detector service
            /// defaults can be overridden at organization, folder and project levels. No assumptions should be made
            /// about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetContainerThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateContainerThreatDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetContainerThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateContainerThreatDetectionSettings for this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the EventThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetEventThreatDetectionSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateEventThreatDetectionSettings for
        /// this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the EventThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetEventThreatDetectionSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateEventThreatDetectionSettings for
        /// this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the RapidVulnerabilityDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetRapidVulnerabilityDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateRapidVulnerabilityDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the RapidVulnerabilityDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetRapidVulnerabilityDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateRapidVulnerabilityDetectionSettings for this purpose.
        /// </summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/rapidVulnerabilityDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityCenterSettings to retrieve. Format:
        /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings Format:
        /// projects/{project}/securityCenterSettings
        /// </param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(this.service, name);
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
            /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings
            /// Format: projects/{project}/securityCenterSettings
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
                    Pattern = @"^folders/[^/]+/securityCenterSettings$",
                });
            }
        }

        /// <summary>
        /// Get the SecurityHealthAnalyticsSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetSecurityHealthAnalyticsSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateSecurityHealthAnalyticsSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the SecurityHealthAnalyticsSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetSecurityHealthAnalyticsSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateSecurityHealthAnalyticsSettings for this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the VirtualMachineThreatDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetVirtualMachineThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateVirtualMachineThreatDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the VirtualMachineThreatDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetVirtualMachineThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateVirtualMachineThreatDetectionSettings for this purpose.
        /// </summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/virtualMachineThreatDetectionSettings$",
                });
            }
        }

        /// <summary>
        /// Get the WebSecurityScannerSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetWebSecurityScannerSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateWebSecurityScannerSettings for
        /// this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the WebSecurityScannerSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetWebSecurityScannerSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateWebSecurityScannerSettings for
        /// this purpose.
        /// </summary>
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
        /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
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
        /// Identifier. The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the EventThreatDetectionSettings. Formats: *
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

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/rapidVulnerabilityDetectionSettings$",
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
        /// Identifier. The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the SecurityHealthAnalyticsSettings. Formats: *
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

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/virtualMachineThreatDetectionSettings$",
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
        /// Identifier. The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the WebSecurityScannerSettings. Formats: *
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
            RapidVulnerabilityDetectionSettings = new RapidVulnerabilityDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            VirtualMachineThreatDetectionSettings = new VirtualMachineThreatDetectionSettingsResource(service);
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
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            /// its settings. Settings provided closer to the target resource take precedence over those further away
            /// (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings. Settings provided closer to the target resource take precedence over those further away
            /// (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the RapidVulnerabilityDetectionSettings resource.</summary>
        public virtual RapidVulnerabilityDetectionSettingsResource RapidVulnerabilityDetectionSettings { get; }

        /// <summary>The "rapidVulnerabilityDetectionSettings" collection of methods.</summary>
        public class RapidVulnerabilityDetectionSettingsResource
        {
            private const string Resource = "rapidVulnerabilityDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RapidVulnerabilityDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
                /// folders/{folder}/rapidVulnerabilityDetectionSettings *
                /// projects/{project}/rapidVulnerabilityDetectionSettings
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
                        Pattern = @"^organizations/[^/]+/rapidVulnerabilityDetectionSettings$",
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
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the VirtualMachineThreatDetectionSettings resource.</summary>
        public virtual VirtualMachineThreatDetectionSettingsResource VirtualMachineThreatDetectionSettings { get; }

        /// <summary>The "virtualMachineThreatDetectionSettings" collection of methods.</summary>
        public class VirtualMachineThreatDetectionSettingsResource
        {
            private const string Resource = "virtualMachineThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VirtualMachineThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/virtualMachineThreatDetectionSettings *
                /// folders/{folder}/virtualMachineThreatDetectionSettings *
                /// projects/{project}/virtualMachineThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                        Pattern = @"^organizations/[^/]+/virtualMachineThreatDetectionSettings$",
                    });
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            /// settings. Settings provided closer to the target resource take precedence over those further away (e.g.
            /// folder will override organization level settings). The default SCC setting for the detector service
            /// defaults can be overridden at organization, folder and project levels. No assumptions should be made
            /// about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings. Settings provided closer to the target resource take precedence over those further away (e.g.
            /// folder will override organization level settings). The default SCC setting for the detector service
            /// defaults can be overridden at organization, folder and project levels. No assumptions should be made
            /// about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetContainerThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateContainerThreatDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetContainerThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateContainerThreatDetectionSettings for this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the EventThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetEventThreatDetectionSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateEventThreatDetectionSettings for
        /// this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the EventThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetEventThreatDetectionSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateEventThreatDetectionSettings for
        /// this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the RapidVulnerabilityDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetRapidVulnerabilityDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateRapidVulnerabilityDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the RapidVulnerabilityDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetRapidVulnerabilityDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateRapidVulnerabilityDetectionSettings for this purpose.
        /// </summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/rapidVulnerabilityDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityCenterSettings to retrieve. Format:
        /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings Format:
        /// projects/{project}/securityCenterSettings
        /// </param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(this.service, name);
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
            /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings
            /// Format: projects/{project}/securityCenterSettings
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

        /// <summary>
        /// Get the SecurityHealthAnalyticsSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetSecurityHealthAnalyticsSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateSecurityHealthAnalyticsSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the SecurityHealthAnalyticsSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetSecurityHealthAnalyticsSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateSecurityHealthAnalyticsSettings for this purpose.
        /// </summary>
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
            return new GetSubscriptionRequest(this.service, name);
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

        /// <summary>
        /// Get the VirtualMachineThreatDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetVirtualMachineThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateVirtualMachineThreatDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the VirtualMachineThreatDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetVirtualMachineThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateVirtualMachineThreatDetectionSettings for this purpose.
        /// </summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/virtualMachineThreatDetectionSettings$",
                });
            }
        }

        /// <summary>
        /// Get the WebSecurityScannerSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetWebSecurityScannerSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateWebSecurityScannerSettings for
        /// this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the WebSecurityScannerSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetWebSecurityScannerSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateWebSecurityScannerSettings for
        /// this purpose.
        /// </summary>
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
        /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
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
        /// Identifier. The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the EventThreatDetectionSettings. Formats: *
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

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/rapidVulnerabilityDetectionSettings$",
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
        /// Identifier. The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the SecurityHealthAnalyticsSettings. Formats: *
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

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/virtualMachineThreatDetectionSettings$",
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
        /// Identifier. The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the WebSecurityScannerSettings. Formats: *
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
            RapidVulnerabilityDetectionSettings = new RapidVulnerabilityDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            VirtualMachineThreatDetectionSettings = new VirtualMachineThreatDetectionSettingsResource(service);
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
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            /// its settings. Settings provided closer to the target resource take precedence over those further away
            /// (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings. Settings provided closer to the target resource take precedence over those further away
            /// (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
                    /// hierarchy and its settings. Settings provided closer to the target resource take precedence over
                    /// those further away (e.g. folder will override organization level settings). The default SCC
                    /// setting for the detector service defaults can be overridden at organization, folder and project
                    /// levels. No assumptions should be made about the SCC defaults as it is considered an internal
                    /// implementation detail.
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
                        return new CalculateRequest(this.service, name);
                    }

                    /// <summary>
                    /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource
                    /// hierarchy and its settings. Settings provided closer to the target resource take precedence over
                    /// those further away (e.g. folder will override organization level settings). The default SCC
                    /// setting for the detector service defaults can be overridden at organization, folder and project
                    /// levels. No assumptions should be made about the SCC defaults as it is considered an internal
                    /// implementation detail.
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

                        /// <summary>
                        /// Optional. When set, will only retrieve the modules that are in scope. By default, all
                        /// modules will be shown.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                            RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "showEligibleModulesOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing
                /// field only indicates that it was not explicitly set, so no assumption should be made about these
                /// fields. In other words, GetContainerThreatDetectionSettings does not calculate the effective service
                /// settings for the resource, which accounts for inherited settings and defaults. Instead, use
                /// CalculateContainerThreatDetectionSettings for this purpose.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </param>
                public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
                {
                    return new GetContainerThreatDetectionSettingsRequest(this.service, name);
                }

                /// <summary>
                /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing
                /// field only indicates that it was not explicitly set, so no assumption should be made about these
                /// fields. In other words, GetContainerThreatDetectionSettings does not calculate the effective service
                /// settings for the resource, which accounts for inherited settings and defaults. Instead, use
                /// CalculateContainerThreatDetectionSettings for this purpose.
                /// </summary>
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
                /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </param>
                public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
                {
                    return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
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
                    /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
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

        /// <summary>Gets the RapidVulnerabilityDetectionSettings resource.</summary>
        public virtual RapidVulnerabilityDetectionSettingsResource RapidVulnerabilityDetectionSettings { get; }

        /// <summary>The "rapidVulnerabilityDetectionSettings" collection of methods.</summary>
        public class RapidVulnerabilityDetectionSettingsResource
        {
            private const string Resource = "rapidVulnerabilityDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RapidVulnerabilityDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
                /// folders/{folder}/rapidVulnerabilityDetectionSettings *
                /// projects/{project}/rapidVulnerabilityDetectionSettings
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
                        Pattern = @"^projects/[^/]+/rapidVulnerabilityDetectionSettings$",
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
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings. Settings provided closer to the target resource take precedence over those further
            /// away (e.g. folder will override organization level settings). The default SCC setting for the detector
            /// service defaults can be overridden at organization, folder and project levels. No assumptions should be
            /// made about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the VirtualMachineThreatDetectionSettings resource.</summary>
        public virtual VirtualMachineThreatDetectionSettingsResource VirtualMachineThreatDetectionSettings { get; }

        /// <summary>The "virtualMachineThreatDetectionSettings" collection of methods.</summary>
        public class VirtualMachineThreatDetectionSettingsResource
        {
            private const string Resource = "virtualMachineThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VirtualMachineThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings. Settings provided closer to the target resource take precedence over those
            /// further away (e.g. folder will override organization level settings). The default SCC setting for the
            /// detector service defaults can be overridden at organization, folder and project levels. No assumptions
            /// should be made about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/virtualMachineThreatDetectionSettings *
                /// folders/{folder}/virtualMachineThreatDetectionSettings *
                /// projects/{project}/virtualMachineThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                        Pattern = @"^projects/[^/]+/virtualMachineThreatDetectionSettings$",
                    });
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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
            /// settings. Settings provided closer to the target resource take precedence over those further away (e.g.
            /// folder will override organization level settings). The default SCC setting for the detector service
            /// defaults can be overridden at organization, folder and project levels. No assumptions should be made
            /// about the SCC defaults as it is considered an internal implementation detail.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings. Settings provided closer to the target resource take precedence over those further away (e.g.
            /// folder will override organization level settings). The default SCC setting for the detector service
            /// defaults can be overridden at organization, folder and project levels. No assumptions should be made
            /// about the SCC defaults as it is considered an internal implementation detail.
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

                /// <summary>
                /// Optional. When set, will only retrieve the modules that are in scope. By default, all modules will
                /// be shown.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("showEligibleModulesOnly", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowEligibleModulesOnly { get; set; }

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
                    RequestParameters.Add("showEligibleModulesOnly", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showEligibleModulesOnly",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetContainerThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateContainerThreatDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the ContainerThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetContainerThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateContainerThreatDetectionSettings for this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the EventThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetEventThreatDetectionSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateEventThreatDetectionSettings for
        /// this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the EventThreatDetectionSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetEventThreatDetectionSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateEventThreatDetectionSettings for
        /// this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the RapidVulnerabilityDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetRapidVulnerabilityDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateRapidVulnerabilityDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the RapidVulnerabilityDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetRapidVulnerabilityDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateRapidVulnerabilityDetectionSettings for this purpose.
        /// </summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/rapidVulnerabilityDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityCenterSettings to retrieve. Format:
        /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings Format:
        /// projects/{project}/securityCenterSettings
        /// </param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(this.service, name);
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
            /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings
            /// Format: projects/{project}/securityCenterSettings
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
                    Pattern = @"^projects/[^/]+/securityCenterSettings$",
                });
            }
        }

        /// <summary>
        /// Get the SecurityHealthAnalyticsSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetSecurityHealthAnalyticsSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateSecurityHealthAnalyticsSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the SecurityHealthAnalyticsSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetSecurityHealthAnalyticsSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateSecurityHealthAnalyticsSettings for this purpose.
        /// </summary>
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

        /// <summary>
        /// Get the VirtualMachineThreatDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetVirtualMachineThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateVirtualMachineThreatDetectionSettings for this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the VirtualMachineThreatDetectionSettings resource. In the returned settings response, a missing field
        /// only indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetVirtualMachineThreatDetectionSettings does not calculate the effective service settings for the
        /// resource, which accounts for inherited settings and defaults. Instead, use
        /// CalculateVirtualMachineThreatDetectionSettings for this purpose.
        /// </summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/virtualMachineThreatDetectionSettings$",
                });
            }
        }

        /// <summary>
        /// Get the WebSecurityScannerSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetWebSecurityScannerSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateWebSecurityScannerSettings for
        /// this purpose.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(this.service, name);
        }

        /// <summary>
        /// Get the WebSecurityScannerSettings resource. In the returned settings response, a missing field only
        /// indicates that it was not explicitly set, so no assumption should be made about these fields. In other
        /// words, GetWebSecurityScannerSettings does not calculate the effective service settings for the resource,
        /// which accounts for inherited settings and defaults. Instead, use CalculateWebSecurityScannerSettings for
        /// this purpose.
        /// </summary>
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
        /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
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
        /// Identifier. The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the EventThreatDetectionSettings. Formats: *
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

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/rapidVulnerabilityDetectionSettings$",
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
        /// Identifier. The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the SecurityHealthAnalyticsSettings. Formats: *
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

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/virtualMachineThreatDetectionSettings$",
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
        /// Identifier. The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(this.service, body, name);
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
            /// Identifier. The resource name of the WebSecurityScannerSettings. Formats: *
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
    /// <summary>Represents an access event.</summary>
    public class Access : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Caller's IP address, such as "1.1.1.1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIp")]
        public virtual string CallerIp { get; set; }

        /// <summary>The caller IP's geolocation, which identifies where the call came from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIpGeo")]
        public virtual Geolocation CallerIpGeo { get; set; }

        /// <summary>The method that the service account called, e.g. "SetIamPolicy".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        /// <summary>
        /// Associated email, such as "foo@google.com". The email address of the authenticated user or a service account
        /// acting on behalf of a third party principal making the request. For third party identity callers, the
        /// `principal_subject` field is populated instead of this field. For privacy reasons, the principal email
        /// address is sometimes redacted. For more information, see [Caller identities in audit
        /// logs](https://cloud.google.com/logging/docs/audit#user-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string that represents the principal_subject that is associated with the identity. Unlike
        /// `principal_email`, `principal_subject` supports principals that aren't associated with email addresses, such
        /// as third party principals. For most identities, the format is `principal://iam.googleapis.com/{identity pool
        /// name}/subject/{subject}`. Some GKE identities, such as GKE_WORKLOAD, FREEFORM, and GKE_HUB_WORKLOAD, still
        /// use the legacy format `serviceAccount:{identity pool name}[{subject}]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>
        /// The identity delegation history of an authenticated service account that made the request. The
        /// `serviceAccountDelegationInfo[]` object contains information about the real authorities that try to access
        /// Google Cloud resources by delegating on a service account. When multiple authorities are present, they are
        /// guaranteed to be sorted based on the original ordering of the identity delegation events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountDelegationInfo")]
        public virtual System.Collections.Generic.IList<ServiceAccountDelegationInfo> ServiceAccountDelegationInfo { get; set; }

        /// <summary>
        /// The name of the service account key that was used to create or exchange credentials when authenticating the
        /// service account that made the request. This is a scheme-less URI full resource name. For example:
        /// "//iam.googleapis.com/projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyName")]
        public virtual string ServiceAccountKeyName { get; set; }

        /// <summary>
        /// This is the API service that the service account made a call to, e.g. "iam.googleapis.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The caller's user agent string associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Type of user agent associated with the finding. For example, an operating system shell or an embedded or
        /// standalone application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgentFamily")]
        public virtual string UserAgentFamily { get; set; }

        /// <summary>
        /// A string that represents a username. The username provided depends on the type of the finding and is likely
        /// not an IAM principal. For example, this can be a system username if the finding is related to a virtual
        /// machine, or it can be an application login username.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Conveys information about a Kubernetes access review (such as one returned by a [`kubectl auth
    /// can-i`](https://kubernetes.io/docs/reference/access-authn-authz/authorization/#checking-api-access) command)
    /// that was involved in a finding.
    /// </summary>
    public class AccessReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API group of the resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The name of the resource being requested. Empty means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Namespace of the action being requested. Currently, there is no distinction between no namespace and all
        /// namespaces. Both are represented by "" (empty).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The optional resource type requested. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The optional subresource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subresource")]
        public virtual string Subresource { get; set; }

        /// <summary>
        /// A Kubernetes resource API verb, like get, list, watch, create, update, delete, proxy. "*" means all.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The API version of the resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about [Google Cloud Armor Adaptive
    /// Protection](https://cloud.google.com/armor/docs/cloud-armor-overview#google-cloud-armor-adaptive-protection).
    /// </summary>
    public class AdaptiveProtection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A score of 0 means that there is low confidence that the detected event is an actual attack. A score of 1
        /// means that there is high confidence that the detected event is an attack. See the [Adaptive Protection
        /// documentation](https://cloud.google.com/armor/docs/adaptive-protection-overview#configure-alert-tuning) for
        /// further explanation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<double> Confidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Allowed IP rule.</summary>
    public class Allowed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Optional list of allowed IP rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an application associated with a finding.</summary>
    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The base URI that identifies the network location of the application in which the vulnerability was
        /// detected. For example, `http://example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUri")]
        public virtual string BaseUri { get; set; }

        /// <summary>
        /// The full URI with payload that can be used to reproduce the vulnerability. For example,
        /// `http://example.com?p=aMmYgI6H`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullUri")]
        public virtual string FullUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about DDoS attack volume and classification.</summary>
    public class Attack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of attack, for example, 'SYN-flood', 'NTP-udp', or 'CHARGEN-udp'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classification")]
        public virtual string Classification { get; set; }

        /// <summary>
        /// Total BPS (bytes per second) volume of attack. Deprecated - refer to volume_bps_long instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeBps")]
        public virtual System.Nullable<int> VolumeBps { get; set; }

        /// <summary>Total BPS (bytes per second) volume of attack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeBpsLong")]
        public virtual System.Nullable<long> VolumeBpsLong { get; set; }

        /// <summary>
        /// Total PPS (packets per second) volume of attack. Deprecated - refer to volume_pps_long instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumePps")]
        public virtual System.Nullable<int> VolumePps { get; set; }

        /// <summary>Total PPS (packets per second) volume of attack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumePpsLong")]
        public virtual System.Nullable<long> VolumePpsLong { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An attack exposure contains the results of an attack path simulation run.</summary>
    public class AttackExposure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the attack path simulation result that contains the details regarding this attack
        /// exposure score. Example: `organizations/123/simulations/456/attackExposureResults/789`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureResult")]
        public virtual string AttackExposureResult { get; set; }

        /// <summary>The number of high value resources that are exposed as a result of this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedHighValueResourcesCount")]
        public virtual System.Nullable<int> ExposedHighValueResourcesCount { get; set; }

        /// <summary>The number of high value resources that are exposed as a result of this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedLowValueResourcesCount")]
        public virtual System.Nullable<int> ExposedLowValueResourcesCount { get; set; }

        /// <summary>The number of medium value resources that are exposed as a result of this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedMediumValueResourcesCount")]
        public virtual System.Nullable<int> ExposedMediumValueResourcesCount { get; set; }

        private string _latestCalculationTimeRaw;

        private object _latestCalculationTime;

        /// <summary>The most recent time the attack exposure was updated on this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCalculationTime")]
        public virtual string LatestCalculationTimeRaw
        {
            get => _latestCalculationTimeRaw;
            set
            {
                _latestCalculationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestCalculationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestCalculationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestCalculationTimeDateTimeOffset instead.")]
        public virtual object LatestCalculationTime
        {
            get => _latestCalculationTime;
            set
            {
                _latestCalculationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestCalculationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestCalculationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestCalculationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestCalculationTimeRaw);
            set => LatestCalculationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A number between 0 (inclusive) and infinity that represents how important this finding is to remediate. The
        /// higher the score, the more important it is to remediate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<double> Score { get; set; }

        /// <summary>
        /// What state this AttackExposure is in. This captures whether or not an attack exposure has been calculated or
        /// not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An AWS account that is a member of an organization.</summary>
    public class AwsAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier (ID) of the account, containing exactly 12 digits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The friendly name of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AWS metadata associated with the resource, only applicable if the finding's cloud provider is Amazon Web
    /// Services.
    /// </summary>
    public class AwsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AWS account associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual AwsAccount Account { get; set; }

        /// <summary>The AWS organization associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual AwsOrganization Organization { get; set; }

        /// <summary>
        /// A list of AWS organizational units associated with the resource, ordered from lowest level (closest to the
        /// account) to highest level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationalUnits")]
        public virtual System.Collections.Generic.IList<AwsOrganizationalUnit> OrganizationalUnits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An organization is a collection of accounts that are centrally managed together using consolidated billing,
    /// organized hierarchically with organizational units (OUs), and controlled with policies.
    /// </summary>
    public class AwsOrganization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier (ID) for the organization. The regex pattern for an organization ID string requires
        /// "o-" followed by from 10 to 32 lowercase letters or digits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Organizational Unit (OU) is a container of AWS accounts within a root of an organization. Policies that are
    /// attached to an OU apply to all accounts contained in that OU and in any child OUs.
    /// </summary>
    public class AwsOrganizationalUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier (ID) associated with this OU. The regex pattern for an organizational unit ID string
        /// requires "ou-" followed by from 4 to 32 lowercase letters or digits (the ID of the root that contains the
        /// OU). This string is followed by a second "-" dash and from 8 to 32 additional lowercase letters or digits.
        /// For example, "ou-ab12-cd34ef56".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The friendly name of the OU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Azure management group.</summary>
    public class AzureManagementGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the Azure management group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The UUID of the Azure management group, for example, `20000000-0001-0000-0000-000000000000`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Azure metadata associated with the resource, only applicable if the finding's cloud provider is Microsoft Azure.
    /// </summary>
    public class AzureMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of Azure management groups associated with the resource, ordered from lowest level (closest to the
        /// subscription) to highest level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementGroups")]
        public virtual System.Collections.Generic.IList<AzureManagementGroup> ManagementGroups { get; set; }

        /// <summary>The Azure resource group associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual AzureResourceGroup ResourceGroup { get; set; }

        /// <summary>The Azure subscription associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual AzureSubscription Subscription { get; set; }

        /// <summary>The Azure Entra tenant associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual AzureTenant Tenant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Azure resource group.</summary>
    public class AzureResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the Azure resource group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the Azure resource group. This is not a UUID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Azure subscription.</summary>
    public class AzureSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the Azure subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The UUID of the Azure subscription, for example, `291bba3f-e0a5-47bc-a099-3bdcb2a50a05`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Microsoft Entra tenant.</summary>
    public class AzureTenant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the Azure tenant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ID of the Microsoft Entra tenant, for example, "a11aaa11-aa11-1aa1-11aa-1aaa11a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to Google Cloud Backup and DR Service findings.</summary>
    public class BackupDisasterRecovery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the Backup and DR appliance that captures, moves, and manages the lifecycle of backup data. For
        /// example, `backup-server-57137`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliance")]
        public virtual string Appliance { get; set; }

        /// <summary>
        /// The names of Backup and DR applications. An application is a VM, database, or file system on a managed host
        /// monitored by a backup and recovery appliance. For example, `centos7-01-vol00`, `centos7-01-vol01`,
        /// `centos7-01-vol02`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<string> Applications { get; set; }

        private string _backupCreateTimeRaw;

        private object _backupCreateTime;

        /// <summary>The timestamp at which the Backup and DR backup was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupCreateTime")]
        public virtual string BackupCreateTimeRaw
        {
            get => _backupCreateTimeRaw;
            set
            {
                _backupCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _backupCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BackupCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BackupCreateTimeDateTimeOffset instead.")]
        public virtual object BackupCreateTime
        {
            get => _backupCreateTime;
            set
            {
                _backupCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _backupCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BackupCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BackupCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BackupCreateTimeRaw);
            set => BackupCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The name of a Backup and DR template which comprises one or more backup policies. See the [Backup and DR
        /// documentation](https://cloud.google.com/backup-disaster-recovery/docs/concepts/backup-plan#temp) for more
        /// information. For example, `snap-ov`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupTemplate")]
        public virtual string BackupTemplate { get; set; }

        /// <summary>
        /// The backup type of the Backup and DR image. For example, `Snapshot`, `Remote Snapshot`, `OnVault`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        /// <summary>
        /// The name of a Backup and DR host, which is managed by the backup and recovery appliance and known to the
        /// management console. The host can be of type Generic (for example, Compute Engine, SQL Server, Oracle DB, SMB
        /// file system, etc.), vCenter, or an ESX server. See the [Backup and DR documentation on
        /// hosts](https://cloud.google.com/backup-disaster-recovery/docs/configuration/manage-hosts-and-their-applications)
        /// for more information. For example, `centos7-01`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// The names of Backup and DR policies that are associated with a template and that define when to run a
        /// backup, how frequently to run a backup, and how long to retain the backup image. For example, `onvaults`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<string> Policies { get; set; }

        /// <summary>
        /// The names of Backup and DR advanced policy options of a policy applying to an application. See the [Backup
        /// and DR documentation on policy
        /// options](https://cloud.google.com/backup-disaster-recovery/docs/create-plan/policy-settings). For example,
        /// `skipofflineappsincongrp, nounmap`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyOptions")]
        public virtual System.Collections.Generic.IList<string> PolicyOptions { get; set; }

        /// <summary>
        /// The name of the Backup and DR resource profile that specifies the storage media for backups of application
        /// and VM data. See the [Backup and DR documentation on
        /// profiles](https://cloud.google.com/backup-disaster-recovery/docs/concepts/backup-plan#profile). For example,
        /// `GCP`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual string Profile { get; set; }

        /// <summary>
        /// The name of the Backup and DR storage pool that the backup and recovery appliance is storing data in. The
        /// storage pool could be of type Cloud, Primary, Snapshot, or OnVault. See the [Backup and DR documentation on
        /// storage pools](https://cloud.google.com/backup-disaster-recovery/docs/concepts/storage-pools). For example,
        /// `DiskPoolOne`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePool")]
        public virtual string StoragePool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains details about a chokepoint, which is a resource or resource group where high-risk attack paths
    /// converge, based on [attack path simulations]
    /// (https://cloud.google.com/security-command-center/docs/attack-exposure-learn#attack_path_simulations).
    /// </summary>
    public class Chokepoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of resource names of findings associated with this chokepoint. For example,
        /// organizations/123/sources/456/findings/789. This list will have at most 100 findings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fields related to Google Cloud Armor findings.</summary>
    public class CloudArmor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about potential Layer 7 DDoS attacks identified by [Google Cloud Armor Adaptive
        /// Protection](https://cloud.google.com/armor/docs/adaptive-protection-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveProtection")]
        public virtual AdaptiveProtection AdaptiveProtection { get; set; }

        /// <summary>Information about DDoS attack volume and classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attack")]
        public virtual Attack Attack { get; set; }

        /// <summary>Duration of attack from the start until the current moment (updated every 5 minutes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Information about incoming requests evaluated by [Google Cloud Armor security
        /// policies](https://cloud.google.com/armor/docs/security-policy-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual Requests Requests { get; set; }

        /// <summary>
        /// Information about the [Google Cloud Armor security
        /// policy](https://cloud.google.com/armor/docs/security-policy-overview) relevant to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPolicy")]
        public virtual SecurityPolicy SecurityPolicy { get; set; }

        /// <summary>
        /// Distinguish between volumetric &amp;amp; protocol DDoS attack and application layer attacks. For example,
        /// "L3_4" for Layer 3 and Layer 4 DDoS attacks, or "L_7" for Layer 7 DDoS attacks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatVector")]
        public virtual string ThreatVector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The [data profile](https://cloud.google.com/dlp/docs/data-profiles) associated with the finding.
    /// </summary>
    public class CloudDlpDataProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the data profile, for example, `projects/123/locations/europe/tableProfiles/8383929`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProfile")]
        public virtual string DataProfile { get; set; }

        /// <summary>The resource hierarchy level at which the data profile was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentType")]
        public virtual string ParentType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about the Cloud Data Loss Prevention (Cloud DLP) [inspection
    /// job](https://cloud.google.com/dlp/docs/concepts-job-triggers) that produced the finding.
    /// </summary>
    public class CloudDlpInspection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Cloud DLP scanned the complete resource or a sampled subset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullScan")]
        public virtual System.Nullable<bool> FullScan { get; set; }

        /// <summary>
        /// The type of information (or *[infoType](https://cloud.google.com/dlp/docs/infotypes-reference)*) found, for
        /// example, `EMAIL_ADDRESS` or `STREET_ADDRESS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual string InfoType { get; set; }

        /// <summary>The number of times Cloud DLP found this infoType within this job and resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeCount")]
        public virtual System.Nullable<long> InfoTypeCount { get; set; }

        /// <summary>
        /// Name of the inspection job, for example, `projects/123/locations/europe/dlpJobs/i-8383929`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectJob")]
        public virtual string InspectJob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata taken from a [Cloud Logging
    /// LogEntry](https://cloud.google.com/logging/docs/reference/v2/rest/v2/LogEntry)
    /// </summary>
    public class CloudLoggingEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique identifier for the log entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
        public virtual string InsertId { get; set; }

        /// <summary>
        /// The type of the log (part of `log_name`. `log_name` is the resource name of the log to which this log entry
        /// belongs). For example: `cloudresourcemanager.googleapis.com/activity`. Note that this field is not
        /// URL-encoded, unlike the `LOG_ID` field in `LogEntry`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logId")]
        public virtual string LogId { get; set; }

        /// <summary>
        /// The organization, folder, or project of the monitored resource that produced this log entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        private string _timestampRaw;

        private object _timestamp;

        /// <summary>The time the event described by the log entry occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string TimestampRaw
        {
            get => _timestampRaw;
            set
            {
                _timestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampDateTimeOffset instead.")]
        public virtual object Timestamp
        {
            get => _timestamp;
            set
            {
                _timestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampRaw);
            set => TimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains compliance information about a security standard indicating unmet recommendations.</summary>
    public class Compliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policies within the standard or benchmark, for example, A.12.4.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>Industry-wide compliance standards or benchmarks, such as CIS, PCI, and OWASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>Version of the standard or benchmark, for example, 1.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the properties and count of a ComplianceSnapshot request.</summary>
    public class ComplianceSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category of Findings matching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The cloud provider for the compliance snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        /// <summary>The compliance standard (ie CIS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceStandard")]
        public virtual string ComplianceStandard { get; set; }

        /// <summary>The compliance version (ie 1.3) in CIS 1.3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceVersion")]
        public virtual string ComplianceVersion { get; set; }

        /// <summary>Total count of findings for the given properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The leaf container resource name that is closest to the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leafContainerResource")]
        public virtual string LeafContainerResource { get; set; }

        /// <summary>The compliance snapshot name. Format: //sources//complianceSnapshots/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

        /// <summary>The snapshot time of the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotTime")]
        public virtual string SnapshotTimeRaw
        {
            get => _snapshotTimeRaw;
            set
            {
                _snapshotTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _snapshotTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SnapshotTimeDateTimeOffset instead.")]
        public virtual object SnapshotTime
        {
            get => _snapshotTime;
            set
            {
                _snapshotTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _snapshotTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SnapshotTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SnapshotTimeRaw);
            set => SnapshotTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>Contains information about the IP connection associated with the finding.</summary>
    public class Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination IP address. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        /// <summary>Destination port. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        /// <summary>IANA Internet Protocol Number such as TCP(6) and UDP(17).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Source IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>Source port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The email address of a contact.</summary>
    public class Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An email address. For example, "`person123@company.com`".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about specific contacts</summary>
    public class ContactDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of contacts</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<Contact> Contacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container associated with the finding.</summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time that the container was created.</summary>
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

        /// <summary>
        /// Optional container image ID, if provided by the container runtime. Uniquely identifies the container image
        /// launched using a container image digest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageId")]
        public virtual string ImageId { get; set; }

        /// <summary>Container labels, as provided by the container runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>Name of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Container image URI provided when configuring a pod or container. This string can identify a container image
        /// version using mutable tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Container Threat Detection service.</summary>
    public class ContainerThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// Identifier. The resource name of the ContainerThreatDetectionSettings. Formats: *
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the settings were last updated.</summary>
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
    /// CVE stands for Common Vulnerabilities and Exposures. Information from the [CVE
    /// record](https://www.cve.org/ResourcesSupport/Glossary) that describes this vulnerability.
    /// </summary>
    public class Cve : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describe Common Vulnerability Scoring System specified at
        /// https://www.first.org/cvss/v3.1/specification-document
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssv3")]
        public virtual Cvssv3 Cvssv3 { get; set; }

        private string _exploitReleaseDateRaw;

        private object _exploitReleaseDate;

        /// <summary>Date the first publicly available exploit or PoC was released.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitReleaseDate")]
        public virtual string ExploitReleaseDateRaw
        {
            get => _exploitReleaseDateRaw;
            set
            {
                _exploitReleaseDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _exploitReleaseDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExploitReleaseDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExploitReleaseDateDateTimeOffset instead.")]
        public virtual object ExploitReleaseDate
        {
            get => _exploitReleaseDate;
            set
            {
                _exploitReleaseDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _exploitReleaseDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExploitReleaseDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExploitReleaseDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExploitReleaseDateRaw);
            set => ExploitReleaseDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The exploitation activity of the vulnerability in the wild.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitationActivity")]
        public virtual string ExploitationActivity { get; set; }

        private string _firstExploitationDateRaw;

        private object _firstExploitationDate;

        /// <summary>Date of the earliest known exploitation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstExploitationDate")]
        public virtual string FirstExploitationDateRaw
        {
            get => _firstExploitationDateRaw;
            set
            {
                _firstExploitationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _firstExploitationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FirstExploitationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FirstExploitationDateDateTimeOffset instead.")]
        public virtual object FirstExploitationDate
        {
            get => _firstExploitationDate;
            set
            {
                _firstExploitationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _firstExploitationDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="FirstExploitationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FirstExploitationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FirstExploitationDateRaw);
            set => FirstExploitationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The unique identifier for the vulnerability. e.g. CVE-2021-34527</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The potential impact of the vulnerability if it was to be exploited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impact")]
        public virtual string Impact { get; set; }

        /// <summary>Whether or not the vulnerability has been observed in the wild.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedInTheWild")]
        public virtual System.Nullable<bool> ObservedInTheWild { get; set; }

        /// <summary>
        /// Additional information about the CVE. e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<Reference> References { get; set; }

        /// <summary>Whether upstream fix is available for the CVE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upstreamFixAvailable")]
        public virtual System.Nullable<bool> UpstreamFixAvailable { get; set; }

        /// <summary>Whether or not the vulnerability was zero day when the finding was published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zeroDay")]
        public virtual System.Nullable<bool> ZeroDay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common Vulnerability Scoring System version 3.</summary>
    public class Cvssv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This metric describes the conditions beyond the attacker's control that must exist in order to exploit the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>
        /// Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and
        /// across user environments. This metric reflects the context by which vulnerability exploitation is possible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        /// <summary>
        /// This metric measures the impact to the availability of the impacted component resulting from a successfully
        /// exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<double> BaseScore { get; set; }

        /// <summary>
        /// This metric measures the impact to the confidentiality of the information resources managed by a software
        /// component due to a successfully exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        /// <summary>This metric measures the impact to integrity of a successfully exploited vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        /// <summary>
        /// This metric describes the level of privileges an attacker must possess before successfully exploiting the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        /// <summary>
        /// The Scope metric captures whether a vulnerability in one vulnerable component impacts resources in
        /// components beyond its security scope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// This metric captures the requirement for a human user, other than the attacker, to participate in the
        /// successful compromise of the vulnerable component.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CWE stands for Common Weakness Enumeration. Information about this weakness, as described by
    /// [CWE](https://cwe.mitre.org/).
    /// </summary>
    public class Cwe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CWE identifier, e.g. CWE-94</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Any reference to the details on the CWE, for example, https://cwe.mitre.org/data/definitions/94.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<Reference> References { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about a data access attempt made by a principal not authorized under applicable data security policy.
    /// </summary>
    public class DataAccessEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier for data access event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Timestamp of data access event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The operation performed by the principal to access the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>
        /// The email address of the principal that accessed the data. The principal could be a user account, service
        /// account, Google group, or other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about a data flow event, in which either the data is moved to or is accessed from a non-compliant
    /// geo-location, as defined in the applicable data security policy.
    /// </summary>
    public class DataFlowEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier for data flow event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Timestamp of data flow event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The operation performed by the principal for the data flow event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>
        /// The email address of the principal that initiated the data flow event. The principal could be a user
        /// account, service account, Google group, or other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>Non-compliant location of the principal or the data destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatedLocation")]
        public virtual string ViolatedLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about data retention deletion violations, in which the data is non-compliant based on their retention or
    /// deletion time, as defined in the applicable data security policy. The Data Retention Deletion (DRD) control is a
    /// control of the DSPM (Data Security Posture Management) suite that enables organizations to manage data retention
    /// and deletion policies in compliance with regulations, such as GDPR and CRPA. DRD supports two primary policy
    /// types: maximum storage length (max TTL) and minimum storage length (min TTL). Both are aimed at helping
    /// organizations meet regulatory and data management commitments.
    /// </summary>
    public class DataRetentionDeletionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of objects that violated the policy for this resource. If the number is less than 1,000, then the
        /// value of this field is the exact number. If the number of objects that violated the policy is greater than
        /// or equal to 1,000, then the value of this field is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataObjectCount")]
        public virtual System.Nullable<long> DataObjectCount { get; set; }

        private string _eventDetectionTimeRaw;

        private object _eventDetectionTime;

        /// <summary>Timestamp indicating when the event was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDetectionTime")]
        public virtual string EventDetectionTimeRaw
        {
            get => _eventDetectionTimeRaw;
            set
            {
                _eventDetectionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventDetectionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventDetectionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventDetectionTimeDateTimeOffset instead.")]
        public virtual object EventDetectionTime
        {
            get => _eventDetectionTime;
            set
            {
                _eventDetectionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventDetectionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EventDetectionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventDetectionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventDetectionTimeRaw);
            set => EventDetectionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Type of the DRD event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// Maximum duration of retention allowed from the DRD control. This comes from the DRD control where users set
        /// a max TTL for their data. For example, suppose that a user sets the max TTL for a Cloud Storage bucket to 90
        /// days. However, an object in that bucket is 100 days old. In this case, a DataRetentionDeletionEvent will be
        /// generated for that Cloud Storage bucket, and the max_retention_allowed is 90 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetentionAllowed")]
        public virtual object MaxRetentionAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents database access information, such as queries. A database may be a sub-resource of an instance (as in
    /// the case of Cloud SQL instances or Cloud Spanner instances), or the database instance itself. Some database
    /// resources might not have the [full resource name](https://google.aip.dev/122#full-resource-names) populated
    /// because these resource types, such as Cloud SQL databases, are not yet supported by Cloud Asset Inventory. In
    /// these cases only the display name is provided.
    /// </summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the database that the user connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The target usernames, roles, or groups of an SQL privilege grant, which is not an IAM policy change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantees")]
        public virtual System.Collections.Generic.IList<string> Grantees { get; set; }

        /// <summary>
        /// Some database resources may not have the [full resource
        /// name](https://google.aip.dev/122#full-resource-names) populated because these resource types are not yet
        /// supported by Cloud Asset Inventory (e.g. Cloud SQL databases). In these cases only the display name will be
        /// provided. The [full resource name](https://google.aip.dev/122#full-resource-names) of the database that the
        /// user connected to, if it is supported by Cloud Asset Inventory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The SQL statement that is associated with the database access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The username used to connect to the database. The username might not be an IAM principal and does not have a
        /// set format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>
        /// The version of the database, for example, POSTGRES_14. See [the complete
        /// list](https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/SqlDatabaseVersion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Denied IP rule.</summary>
    public class Denied : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Optional list of denied IP rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a subscription.</summary>
    public class Details : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The time the subscription has or will end.</summary>
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

        /// <summary>The time the subscription has or will start.</summary>
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

        /// <summary>The type of subscription</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Memory hash detection contributing to the binary family match.</summary>
    public class Detection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the binary associated with the memory hash signature detection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual string Binary { get; set; }

        /// <summary>The percentage of memory page hashes in the signature that were matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentPagesMatched")]
        public virtual System.Nullable<double> PercentPagesMatched { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the disk associated with the finding.</summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the disk, for example,
        /// "https://www.googleapis.com/compute/v1/projects/{project-id}/zones/{zone-id}/disks/{disk-id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Path of the file in terms of underlying disk/partition identifiers.</summary>
    public class DiskPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// UUID of the partition (format https://wiki.archlinux.org/title/persistent_block_device_naming#by-uuid)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionUuid")]
        public virtual string PartitionUuid { get; set; }

        /// <summary>
        /// Relative path of the file in the partition as a JSON encoded string. Example: /home/user1/executable_file.sh
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativePath")]
        public virtual string RelativePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The record of a dynamic mute rule that matches the finding.</summary>
    public class DynamicMuteRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _matchTimeRaw;

        private object _matchTime;

        /// <summary>When the dynamic mute rule first matched the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchTime")]
        public virtual string MatchTimeRaw
        {
            get => _matchTimeRaw;
            set
            {
                _matchTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _matchTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MatchTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MatchTimeDateTimeOffset instead.")]
        public virtual object MatchTime
        {
            get => _matchTime;
            set
            {
                _matchTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _matchTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="MatchTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MatchTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MatchTimeRaw);
            set => MatchTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The relative resource name of the mute rule, represented by a mute config, that created this record, for
        /// example `organizations/123/muteConfigs/mymuteconfig` or
        /// `organizations/123/locations/global/muteConfigs/mymuteconfig`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteConfig")]
        public virtual string MuteConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A name-value pair representing an environment variable used in an operating system process.</summary>
    public class EnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environment variable name as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Environment variable value as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("val")]
        public virtual string Val { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Event Threat Detection service.</summary>
    public class EventThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// Identifier. The resource name of the EventThreatDetectionSettings. Formats: *
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the settings were last updated.</summary>
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

    /// <summary>Resource where data was exfiltrated from or exfiltrated to.</summary>
    public class ExfilResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Subcomponents of the asset that was exfiltrated, like URIs used during exfiltration, table names, databases,
        /// and filenames. For example, multiple tables might have been exfiltrated from the same Cloud SQL instance, or
        /// multiple files might have been exfiltrated from the same Cloud Storage bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        /// <summary>
        /// The resource's [full resource name](https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exfiltration represents a data exfiltration attempt from one or more sources to one or more targets. The
    /// `sources` attribute lists the sources of the exfiltrated data. The `targets` attribute lists the destinations
    /// the data was copied to.
    /// </summary>
    public class Exfiltration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are multiple sources, then the data is considered "joined" between them. For instance, BigQuery can
        /// join multiple tables, and each table would be considered a source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<ExfilResource> Sources { get; set; }

        /// <summary>
        /// If there are multiple targets, each target would get a complete copy of the "joined" source data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<ExfilResource> Targets { get; set; }

        /// <summary>Total exfiltrated bytes processed for the entire job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalExfiltratedBytes")]
        public virtual System.Nullable<long> TotalExfiltratedBytes { get; set; }

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
    /// File information about the related binary/library used by an executable, or the script used by a script
    /// interpreter
    /// </summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Prefix of the file contents as a JSON-encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>Path of the file in terms of underlying disk/partition identifiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskPath")]
        public virtual DiskPath DiskPath { get; set; }

        /// <summary>
        /// The length in bytes of the file prefix that was hashed. If hashed_size == size, any hashes reported
        /// represent the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedSize")]
        public virtual System.Nullable<long> HashedSize { get; set; }

        /// <summary>True when the hash covers only a prefix of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partiallyHashed")]
        public virtual System.Nullable<bool> PartiallyHashed { get; set; }

        /// <summary>Absolute path of the file as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// SHA256 hash of the first hashed_size bytes of the file encoded as a hex string. If hashed_size == size,
        /// sha256 represents the SHA256 hash of the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>Size of the file in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

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
        /// Access details associated with the finding, such as more information on the caller, which method was
        /// accessed, and from where.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual Access Access { get; set; }

        /// <summary>Represents an application associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual Application Application { get; set; }

        /// <summary>The results of an attack path simulation relevant to this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposure")]
        public virtual AttackExposure AttackExposure { get; set; }

        /// <summary>Fields related to Backup and DR findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDisasterRecovery")]
        public virtual BackupDisasterRecovery BackupDisasterRecovery { get; set; }

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

        /// <summary>
        /// Contains details about a chokepoint, which is a resource or resource group where high-risk attack paths
        /// converge, based on [attack path simulations]
        /// (https://cloud.google.com/security-command-center/docs/attack-exposure-learn#attack_path_simulations). This
        /// field cannot be updated. Its value is ignored in all update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chokepoint")]
        public virtual Chokepoint Chokepoint { get; set; }

        /// <summary>Fields related to Cloud Armor findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudArmor")]
        public virtual CloudArmor CloudArmor { get; set; }

        /// <summary>Cloud DLP data profile that is associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpDataProfile")]
        public virtual CloudDlpDataProfile CloudDlpDataProfile { get; set; }

        /// <summary>
        /// Cloud Data Loss Prevention (Cloud DLP) inspection results that are associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpInspection")]
        public virtual CloudDlpInspection CloudDlpInspection { get; set; }

        /// <summary>Contains compliance information for security standards associated to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliances")]
        public virtual System.Collections.Generic.IList<Compliance> Compliances { get; set; }

        /// <summary>Contains information about the IP connection associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Connection> Connections { get; set; }

        /// <summary>
        /// Output only. Map containing the points of contact for the given finding. The key represents the type of
        /// contact, while the value contains a list of all the contacts that pertain. Please refer to:
        /// https://cloud.google.com/resource-manager/docs/managing-notification-contacts#notification-categories {
        /// "security": { "contacts": [ { "email": "person1@company.com" }, { "email": "person2@company.com" } ] } }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IDictionary<string, ContactDetails> Contacts { get; set; }

        /// <summary>
        /// Containers associated with the finding. This field provides information for both Kubernetes and
        /// non-Kubernetes containers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
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

        /// <summary>Data access events associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAccessEvents")]
        public virtual System.Collections.Generic.IList<DataAccessEvent> DataAccessEvents { get; set; }

        /// <summary>Data flow events associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFlowEvents")]
        public virtual System.Collections.Generic.IList<DataFlowEvent> DataFlowEvents { get; set; }

        /// <summary>Data retention deletion events associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionDeletionEvents")]
        public virtual System.Collections.Generic.IList<DataRetentionDeletionEvent> DataRetentionDeletionEvents { get; set; }

        /// <summary>Database associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual Database Database { get; set; }

        /// <summary>Contains more details about the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Disk associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual Disk Disk { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time the finding was first detected. If an existing finding is updated, then this is the time the update
        /// occurred. For example, if the finding represents an open firewall, this property captures the time the
        /// detector believes the firewall became open. The accuracy is determined by the detector. If the finding is
        /// later resolved, then this time reflects when the finding was resolved. This must not be set to a value
        /// greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Represents exfiltrations associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exfiltration")]
        public virtual Exfiltration Exfiltration { get; set; }

        /// <summary>
        /// Output only. Third party SIEM/SOAR fields within SCC, contains external system information and external
        /// system finding fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystems")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV1ExternalSystem> ExternalSystems { get; set; }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>File associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<File> Files { get; set; }

        /// <summary>The class of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingClass")]
        public virtual string FindingClass { get; set; }

        /// <summary>
        /// Contains details about groups of which this finding is a member. A group is a collection of findings that
        /// are related in some way. This field cannot be updated. Its value is ignored in all update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupMemberships")]
        public virtual System.Collections.Generic.IList<GroupMembership> GroupMemberships { get; set; }

        /// <summary>Represents IAM bindings associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamBindings")]
        public virtual System.Collections.Generic.IList<IamBinding> IamBindings { get; set; }

        /// <summary>
        /// Represents what's commonly known as an *indicator of compromise* (IoC) in computer forensics. This is an
        /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
        /// intrusion. For more information, see [Indicator of
        /// compromise](https://en.wikipedia.org/wiki/Indicator_of_compromise).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indicator")]
        public virtual Indicator Indicator { get; set; }

        /// <summary>IP rules associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual IpRules IpRules { get; set; }

        /// <summary>Job associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        /// <summary>Signature of the kernel rootkit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelRootkit")]
        public virtual KernelRootkit KernelRootkit { get; set; }

        /// <summary>Kubernetes resources associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetes")]
        public virtual Kubernetes Kubernetes { get; set; }

        /// <summary>The load balancers associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancers")]
        public virtual System.Collections.Generic.IList<LoadBalancer> LoadBalancers { get; set; }

        /// <summary>Log entries that are relevant to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logEntries")]
        public virtual System.Collections.Generic.IList<LogEntry> LogEntries { get; set; }

        /// <summary>
        /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mitreAttack")]
        public virtual MitreAttack MitreAttack { get; set; }

        /// <summary>
        /// Unique identifier of the module which generated the finding. Example:
        /// folders/598186756061/securityHealthAnalyticsSettings/customModules/56799441161885
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        /// <summary>
        /// Indicates the mute state of a finding (either muted, unmuted or undefined). Unlike other attributes of a
        /// finding, a finding provider shouldn't set the value of mute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual string Mute { get; set; }

        /// <summary>Output only. The mute information regarding this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteInfo")]
        public virtual MuteInfo MuteInfo { get; set; }

        /// <summary>
        /// Records additional information about the mute operation, for example, the [mute
        /// configuration](/security-command-center/docs/how-to-mute-findings) that muted the finding and the user who
        /// muted the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        private string _muteUpdateTimeRaw;

        private object _muteUpdateTime;

        /// <summary>Output only. The most recent time this finding was muted or unmuted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteUpdateTime")]
        public virtual string MuteUpdateTimeRaw
        {
            get => _muteUpdateTimeRaw;
            set
            {
                _muteUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _muteUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MuteUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MuteUpdateTimeDateTimeOffset instead.")]
        public virtual object MuteUpdateTime
        {
            get => _muteUpdateTime;
            set
            {
                _muteUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _muteUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MuteUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MuteUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MuteUpdateTimeRaw);
            set => MuteUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The [relative resource name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of
        /// the finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
        /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Represents the VPC networks that the resource is attached to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<Network> Networks { get; set; }

        /// <summary>Steps to address the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSteps")]
        public virtual string NextSteps { get; set; }

        /// <summary>Notebook associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebook")]
        public virtual Notebook Notebook { get; set; }

        /// <summary>Contains information about the org policies associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicies")]
        public virtual System.Collections.Generic.IList<OrgPolicy> OrgPolicies { get; set; }

        /// <summary>
        /// The relative resource name of the source the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. For example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Output only. The human readable display name of the finding source such as "Event Threat Detection" or
        /// "Security Health Analytics".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>Represents operating system processes associated with the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<Process> Processes { get; set; }

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

        /// <summary>The security posture associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPosture")]
        public virtual SecurityPosture SecurityPosture { get; set; }

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

        /// <summary>
        /// Contains details about a group of security issues that, when the issues occur together, represent a greater
        /// risk than when the issues occur independently. A group of such issues is referred to as a toxic combination.
        /// This field cannot be updated. Its value is ignored in all update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toxicCombination")]
        public virtual ToxicCombination ToxicCombination { get; set; }

        /// <summary>
        /// Represents vulnerability-specific fields like CVE and CVSS scores. CVE stands for Common Vulnerabilities and
        /// Exposures (https://cve.mitre.org/about/)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual Vulnerability Vulnerability { get; set; }

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

    /// <summary>
    /// GCP metadata associated with the resource, only applicable if the finding's cloud provider is Google Cloud
    /// Platform.
    /// </summary>
    public class GcpMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Folder> Folders { get; set; }

        /// <summary>The name of the organization that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The project ID that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a geographical location for a given access.</summary>
    public class Geolocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A CLDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures how to deliver Findings to BigQuery Instance.</summary>
    public class GoogleCloudSecuritycenterV1BigQueryExport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which the BigQuery export was created. This field is set by the server and will be
        /// ignored if provided on export on creation.
        /// </summary>
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

        /// <summary>
        /// The dataset to write findings' updates to. Its format is
        /// "projects/[project_id]/datasets/[bigquery_dataset_id]". BigQuery Dataset unique ID must contain only letters
        /// (a-z, A-Z), numbers (0-9), or underscores (_).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>The description of the export (max of 1024 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across create/update events of findings. The expression is a
        /// list of zero or more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported,
        /// and `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in
        /// front of them to indicate negation. The fields map to those defined in the corresponding resource. The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the BigQuery export. This field is set by the server
        /// and will be ignored if provided on export creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// The relative resource name of this export. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
        /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
        /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
        /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is ignored when
        /// provided in create requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The service account that needs permission to create table and upload data to the BigQuery
        /// dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The most recent time at which the BigQuery export was updated. This field is set by the server
        /// and will be ignored if provided on export creation or update.
        /// </summary>
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

    /// <summary>Represents a Kubernetes RoleBinding or ClusterRoleBinding.</summary>
    public class GoogleCloudSecuritycenterV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name for the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The Role or ClusterRole referenced by the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual Role Role { get; set; }

        /// <summary>
        /// Represents one or more subjects that are bound to the role. Not always available for PATCH requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjects")]
        public virtual System.Collections.Generic.IList<Subject> Subjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a BulkMute request. Contains the LRO information.</summary>
    public class GoogleCloudSecuritycenterV1BulkMuteFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the properties in a custom module configuration for Security Health Analytics. Use the custom module
    /// configuration to create custom detectors that generate custom findings for resources that you specify.
    /// </summary>
    public class GoogleCloudSecuritycenterV1CustomConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom output properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customOutput")]
        public virtual GoogleCloudSecuritycenterV1CustomOutputSpec CustomOutput { get; set; }

        /// <summary>
        /// Text that describes the vulnerability or misconfiguration that the custom module detects. This explanation
        /// is returned with each finding instance to help investigators understand the detected issue. The text must be
        /// enclosed in quotation marks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The CEL expression to evaluate to produce findings. When the expression evaluates to true against a
        /// resource, a finding is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predicate")]
        public virtual Expr Predicate { get; set; }

        /// <summary>
        /// An explanation of the recommended steps that security teams can take to resolve the detected issue. This
        /// explanation is returned with each finding generated by this module in the `nextSteps` property of the
        /// finding JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendation")]
        public virtual string Recommendation { get; set; }

        /// <summary>
        /// The resource types that the custom module operates on. Each custom module can specify up to 5 resource
        /// types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSelector")]
        public virtual GoogleCloudSecuritycenterV1ResourceSelector ResourceSelector { get; set; }

        /// <summary>The severity to assign to findings generated by the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of optional name-value pairs that define custom source properties to return with each finding that is
    /// generated by the custom module. The custom source properties that are defined here are included in the finding
    /// JSON under `sourceProperties`.
    /// </summary>
    public class GoogleCloudSecuritycenterV1CustomOutputSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of custom output properties to add to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1Property> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An EffectiveSecurityHealthAnalyticsCustomModule is the representation of a Security Health Analytics custom
    /// module at a specified level of the resource hierarchy: organization, folder, or project. If a custom module is
    /// inherited from a parent organization or folder, the value of the `enablementState` property in
    /// EffectiveSecurityHealthAnalyticsCustomModule is set to the value that is effective in the parent, instead of
    /// `INHERITED`. For example, if the module is enabled in a parent organization or folder, the effective
    /// enablement_state for the module in all child folders or projects is also `enabled`.
    /// EffectiveSecurityHealthAnalyticsCustomModule is read-only.
    /// </summary>
    public class GoogleCloudSecuritycenterV1EffectiveSecurityHealthAnalyticsCustomModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cloud provider of the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        /// <summary>Output only. The user-specified configuration for the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConfig")]
        public virtual GoogleCloudSecuritycenterV1CustomConfig CustomConfig { get; set; }

        /// <summary>
        /// Output only. The display name for the custom module. The name must be between 1 and 128 characters, start
        /// with a lowercase letter, and contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The effective state of enablement for the module at the given level of the hierarchy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        /// <summary>
        /// Output only. The resource name of the custom module. Its format is
        /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
        /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
        /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of third party SIEM/SOAR fields within SCC.</summary>
    public class GoogleCloudSecuritycenterV1ExternalSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>References primary/secondary etc assignees in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignees")]
        public virtual System.Collections.Generic.IList<string> Assignees { get; set; }

        private string _caseCloseTimeRaw;

        private object _caseCloseTime;

        /// <summary>The time when the case was closed, as reported by the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseCloseTime")]
        public virtual string CaseCloseTimeRaw
        {
            get => _caseCloseTimeRaw;
            set
            {
                _caseCloseTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _caseCloseTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaseCloseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaseCloseTimeDateTimeOffset instead.")]
        public virtual object CaseCloseTime
        {
            get => _caseCloseTime;
            set
            {
                _caseCloseTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _caseCloseTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CaseCloseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaseCloseTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaseCloseTimeRaw);
            set => CaseCloseTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _caseCreateTimeRaw;

        private object _caseCreateTime;

        /// <summary>The time when the case was created, as reported by the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseCreateTime")]
        public virtual string CaseCreateTimeRaw
        {
            get => _caseCreateTimeRaw;
            set
            {
                _caseCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _caseCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaseCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaseCreateTimeDateTimeOffset instead.")]
        public virtual object CaseCreateTime
        {
            get => _caseCreateTime;
            set
            {
                _caseCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _caseCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CaseCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaseCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaseCreateTimeRaw);
            set => CaseCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The priority of the finding's corresponding case in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("casePriority")]
        public virtual string CasePriority { get; set; }

        private string _caseSlaRaw;

        private object _caseSla;

        /// <summary>The SLA of the finding's corresponding case in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSla")]
        public virtual string CaseSlaRaw
        {
            get => _caseSlaRaw;
            set
            {
                _caseSla = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _caseSlaRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaseSlaRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaseSlaDateTimeOffset instead.")]
        public virtual object CaseSla
        {
            get => _caseSla;
            set
            {
                _caseSlaRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _caseSla = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CaseSlaRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaseSlaDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaseSlaRaw);
            set => CaseSlaRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The link to the finding's corresponding case in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseUri")]
        public virtual string CaseUri { get; set; }

        private string _externalSystemUpdateTimeRaw;

        private object _externalSystemUpdateTime;

        /// <summary>The time when the case was last updated, as reported by the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystemUpdateTime")]
        public virtual string ExternalSystemUpdateTimeRaw
        {
            get => _externalSystemUpdateTimeRaw;
            set
            {
                _externalSystemUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _externalSystemUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExternalSystemUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExternalSystemUpdateTimeDateTimeOffset instead.")]
        public virtual object ExternalSystemUpdateTime
        {
            get => _externalSystemUpdateTime;
            set
            {
                _externalSystemUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _externalSystemUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExternalSystemUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExternalSystemUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExternalSystemUpdateTimeRaw);
            set => ExternalSystemUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The identifier that's used to track the finding's corresponding case in the external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUid")]
        public virtual string ExternalUid { get; set; }

        /// <summary>
        /// Full resource name of the external system, for example:
        /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
        /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
        /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The most recent status of the finding's corresponding case, as reported by the external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Information about the ticket, if any, that is being used to track the resolution of the issue that is
        /// identified by this finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketInfo")]
        public virtual TicketInfo TicketInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mute config is a Cloud SCC resource that contains the configuration to mute create/update events of findings.
    /// </summary>
    public class GoogleCloudSecuritycenterV1MuteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which the mute config was created. This field is set by the server and will be
        /// ignored if provided on config creation.
        /// </summary>
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

        /// <summary>A description of the mute config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable name to be displayed for the mute config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expiryTimeRaw;

        private object _expiryTime;

        /// <summary>
        /// Optional. The expiry of the mute config. Only applicable for dynamic configs. If the expiry is set, when the
        /// config expires, it is removed from all findings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTime")]
        public virtual string ExpiryTimeRaw
        {
            get => _expiryTimeRaw;
            set
            {
                _expiryTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expiryTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpiryTimeDateTimeOffset instead.")]
        public virtual object ExpiryTime
        {
            get => _expiryTime;
            set
            {
                _expiryTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expiryTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpiryTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpiryTimeRaw);
            set => ExpiryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. An expression that defines the filter to apply across create/update events of findings. While
        /// creating a filter string, be mindful of the scope in which the mute configuration is being created. E.g., If
        /// a filter contains project = X but is created under the project = Y scope, it might not match any findings.
        /// The following field and operator combinations are supported: * severity: `=`, `:` * category: `=`, `:` *
        /// resource.name: `=`, `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` *
        /// resource.folders.resource_folder: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name:
        /// `=`, `:` * resource.type: `=`, `:` * finding_class: `=`, `:` * indicator.ip_addresses: `=`, `:` *
        /// indicator.domains: `=`, `:`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the mute config. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// This field will be ignored if provided on config creation. Format
        /// `organizations/{organization}/muteConfigs/{mute_config}` `folders/{folder}/muteConfigs/{mute_config}`
        /// `projects/{project}/muteConfigs/{mute_config}`
        /// `organizations/{organization}/locations/global/muteConfigs/{mute_config}`
        /// `folders/{folder}/locations/global/muteConfigs/{mute_config}`
        /// `projects/{project}/locations/global/muteConfigs/{mute_config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The type of the mute config, which determines what type of mute state the config affects. The
        /// static mute state takes precedence over the dynamic mute state. Immutable after creation. STATIC by default
        /// if not set during creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The most recent time at which the mute config was updated. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
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

    /// <summary>An individual name-value pair that defines a custom source property.</summary>
    public class GoogleCloudSecuritycenterV1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the property for the custom output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The CEL expression for the custom output. A resource property can be specified to return the value of the
        /// property or a text string enclosed in quotation marks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueExpression")]
        public virtual Expr ValueExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AWS metadata associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsMetadata")]
        public virtual AwsMetadata AwsMetadata { get; set; }

        /// <summary>The Azure metadata associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureMetadata")]
        public virtual AzureMetadata AzureMetadata { get; set; }

        /// <summary>Indicates which cloud provider the resource resides in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        /// <summary>The human readable name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>The region or location of the service (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Indicates which organization or tenant in the cloud provider the finding applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The project ID that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>Provides the path to the resource within the resource hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePath")]
        public virtual ResourcePath ResourcePath { get; set; }

        /// <summary>
        /// A string representation of the resource path. For Google Cloud, it has the format of
        /// `organizations/{organization_id}/folders/{folder_id}/folders/{folder_id}/projects/{project_id}` where there
        /// can be any number of folders. For AWS, it has the format of
        /// `org/{organization_id}/ou/{organizational_unit_id}/ou/{organizational_unit_id}/account/{account_id}` where
        /// there can be any number of organizational units. For Azure, it has the format of
        /// `mg/{management_group_id}/mg/{management_group_id}/subscription/{subscription_id}/rg/{resource_group_name}`
        /// where there can be any number of management groups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePathString")]
        public virtual string ResourcePathString { get; set; }

        /// <summary>
        /// The parent service or product from which the resource is provided, for example, GKE or SNS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The full resource type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource for selecting resource type.</summary>
    public class GoogleCloudSecuritycenterV1ResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource types to run the detector on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource value configuration (RVC) is a mapping configuration of user's resources to resource values. Used in
    /// Attack path simulations.
    /// </summary>
    public class GoogleCloudSecuritycenterV1ResourceValueConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud provider this configuration applies to</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp this resource value configuration was created.</summary>
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

        /// <summary>Description of the resource value configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Name for the resource value configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of resource labels to search for, evaluated with `AND`. For example, `"resource_labels_selector":
        /// {"key": "value", "env": "prod"}` will match resources with labels "key": "value" `AND` "env": "prod"
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLabelsSelector")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceLabelsSelector { get; set; }

        /// <summary>
        /// Apply resource_value only to resources that match resource_type. resource_type will be checked with `AND` of
        /// other resources. For example, "storage.googleapis.com/Bucket" with resource_value "HIGH" will apply "HIGH"
        /// value only to "storage.googleapis.com/Bucket" resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Required. Resource value level this expression represents</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceValue")]
        public virtual string ResourceValue { get; set; }

        /// <summary>
        /// Project or folder to scope this configuration to. For example, "project/456" would apply this configuration
        /// only to resources in "project/456" scope will be checked with `AND` of other resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// A mapping of the sensitivity on Sensitive Data Protection finding to resource values. This mapping can only
        /// be used in combination with a resource_type that is related to BigQuery, e.g.
        /// "bigquery.googleapis.com/Dataset".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveDataProtectionMapping")]
        public virtual GoogleCloudSecuritycenterV1SensitiveDataProtectionMapping SensitiveDataProtectionMapping { get; set; }

        /// <summary>
        /// Required. Tag values combined with `AND` to check against. For Google Cloud resources, they are tag value
        /// IDs in the form of "tagValues/123". Example: `[ "tagValues/123", "tagValues/456", "tagValues/789" ]`
        /// https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValues")]
        public virtual System.Collections.Generic.IList<string> TagValues { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp this resource value configuration was last updated.</summary>
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

    /// <summary>
    /// Represents an instance of a Security Health Analytics custom module, including its full module name, display
    /// name, enablement state, and last updated time. You can create a custom module at the organization, folder, or
    /// project level. Custom modules that you create at the organization or folder level are inherited by the child
    /// folders and projects.
    /// </summary>
    public class GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If empty, indicates that the custom module was created in the organization, folder, or project
        /// in which you are viewing the custom module. Otherwise, `ancestor_module` specifies the organization or
        /// folder from which the custom module is inherited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestorModule")]
        public virtual string AncestorModule { get; set; }

        /// <summary>The cloud provider of the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        /// <summary>The user specified custom configuration for the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConfig")]
        public virtual GoogleCloudSecuritycenterV1CustomConfig CustomConfig { get; set; }

        /// <summary>
        /// The display name of the Security Health Analytics custom module. This display name becomes the finding
        /// category for all findings that are returned by this custom module. The display name must be between 1 and
        /// 128 characters, start with a lowercase letter, and contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The enablement state of the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        /// <summary>Output only. The editor that last updated the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEditor")]
        public virtual string LastEditor { get; set; }

        /// <summary>
        /// Immutable. The resource name of the custom module. Its format is
        /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
        /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
        /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id {customModule} is
        /// server-generated and is not user settable. It will be a numeric id containing 1-20 digits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the custom module was last updated.</summary>
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
    /// Resource value mapping for Sensitive Data Protection findings. If any of these mappings have a resource value
    /// that is not unspecified, the resource_value field will be ignored when reading this configuration.
    /// </summary>
    public class GoogleCloudSecuritycenterV1SensitiveDataProtectionMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource value mapping for high-sensitivity Sensitive Data Protection findings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highSensitivityMapping")]
        public virtual string HighSensitivityMapping { get; set; }

        /// <summary>Resource value mapping for medium-sensitivity Sensitive Data Protection findings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediumSensitivityMapping")]
        public virtual string MediumSensitivityMapping { get; set; }

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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
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

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time at which the event took place, or when an update to the finding occurred. For example, if the
        /// finding represents an open firewall it would capture the time the detector believes the firewall became
        /// open. The accuracy is determined by the detector. If the finding were to be resolved afterward, this time
        /// would reflect when the finding was resolved. Must not be set to a value greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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

        /// <summary>The project id that the resource belongs to.</summary>
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

    /// <summary>Represents an access event.</summary>
    public class GoogleCloudSecuritycenterV2Access : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Caller's IP address, such as "1.1.1.1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIp")]
        public virtual string CallerIp { get; set; }

        /// <summary>The caller IP's geolocation, which identifies where the call came from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIpGeo")]
        public virtual GoogleCloudSecuritycenterV2Geolocation CallerIpGeo { get; set; }

        /// <summary>The method that the service account called, e.g. "SetIamPolicy".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        /// <summary>
        /// Associated email, such as "foo@google.com". The email address of the authenticated user or a service account
        /// acting on behalf of a third party principal making the request. For third party identity callers, the
        /// `principal_subject` field is populated instead of this field. For privacy reasons, the principal email
        /// address is sometimes redacted. For more information, see [Caller identities in audit
        /// logs](https://cloud.google.com/logging/docs/audit#user-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string that represents the principal_subject that is associated with the identity. Unlike
        /// `principal_email`, `principal_subject` supports principals that aren't associated with email addresses, such
        /// as third party principals. For most identities, the format is `principal://iam.googleapis.com/{identity pool
        /// name}/subject/{subject}`. Some GKE identities, such as GKE_WORKLOAD, FREEFORM, and GKE_HUB_WORKLOAD, still
        /// use the legacy format `serviceAccount:{identity pool name}[{subject}]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>
        /// The identity delegation history of an authenticated service account that made the request. The
        /// `serviceAccountDelegationInfo[]` object contains information about the real authorities that try to access
        /// Google Cloud resources by delegating on a service account. When multiple authorities are present, they are
        /// guaranteed to be sorted based on the original ordering of the identity delegation events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountDelegationInfo")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ServiceAccountDelegationInfo> ServiceAccountDelegationInfo { get; set; }

        /// <summary>
        /// The name of the service account key that was used to create or exchange credentials when authenticating the
        /// service account that made the request. This is a scheme-less URI full resource name. For example:
        /// "//iam.googleapis.com/projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyName")]
        public virtual string ServiceAccountKeyName { get; set; }

        /// <summary>
        /// This is the API service that the service account made a call to, e.g. "iam.googleapis.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The caller's user agent string associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Type of user agent associated with the finding. For example, an operating system shell or an embedded or
        /// standalone application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgentFamily")]
        public virtual string UserAgentFamily { get; set; }

        /// <summary>
        /// A string that represents a username. The username provided depends on the type of the finding and is likely
        /// not an IAM principal. For example, this can be a system username if the finding is related to a virtual
        /// machine, or it can be an application login username.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Conveys information about a Kubernetes access review (such as one returned by a [`kubectl auth
    /// can-i`](https://kubernetes.io/docs/reference/access-authn-authz/authorization/#checking-api-access) command)
    /// that was involved in a finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV2AccessReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API group of the resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The name of the resource being requested. Empty means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Namespace of the action being requested. Currently, there is no distinction between no namespace and all
        /// namespaces. Both are represented by "" (empty).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The optional resource type requested. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The optional subresource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subresource")]
        public virtual string Subresource { get; set; }

        /// <summary>
        /// A Kubernetes resource API verb, like get, list, watch, create, update, delete, proxy. "*" means all.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The API version of the resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about [Google Cloud Armor Adaptive
    /// Protection](https://cloud.google.com/armor/docs/cloud-armor-overview#google-cloud-armor-adaptive-protection).
    /// </summary>
    public class GoogleCloudSecuritycenterV2AdaptiveProtection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A score of 0 means that there is low confidence that the detected event is an actual attack. A score of 1
        /// means that there is high confidence that the detected event is an attack. See the [Adaptive Protection
        /// documentation](https://cloud.google.com/armor/docs/adaptive-protection-overview#configure-alert-tuning) for
        /// further explanation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<double> Confidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Allowed IP rule.</summary>
    public class GoogleCloudSecuritycenterV2Allowed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Optional list of allowed IP rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an application associated with a finding.</summary>
    public class GoogleCloudSecuritycenterV2Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The base URI that identifies the network location of the application in which the vulnerability was
        /// detected. For example, `http://example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseUri")]
        public virtual string BaseUri { get; set; }

        /// <summary>
        /// The full URI with payload that could be used to reproduce the vulnerability. For example,
        /// `http://example.com?p=aMmYgI6H`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullUri")]
        public virtual string FullUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about DDoS attack volume and classification.</summary>
    public class GoogleCloudSecuritycenterV2Attack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of attack, for example, 'SYN-flood', 'NTP-udp', or 'CHARGEN-udp'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classification")]
        public virtual string Classification { get; set; }

        /// <summary>
        /// Total BPS (bytes per second) volume of attack. Deprecated - refer to volume_bps_long instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeBps")]
        public virtual System.Nullable<int> VolumeBps { get; set; }

        /// <summary>Total BPS (bytes per second) volume of attack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeBpsLong")]
        public virtual System.Nullable<long> VolumeBpsLong { get; set; }

        /// <summary>
        /// Total PPS (packets per second) volume of attack. Deprecated - refer to volume_pps_long instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumePps")]
        public virtual System.Nullable<int> VolumePps { get; set; }

        /// <summary>Total PPS (packets per second) volume of attack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumePpsLong")]
        public virtual System.Nullable<long> VolumePpsLong { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An attack exposure contains the results of an attack path simulation run.</summary>
    public class GoogleCloudSecuritycenterV2AttackExposure : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the attack path simulation result that contains the details regarding this attack
        /// exposure score. Example: `organizations/123/simulations/456/attackExposureResults/789`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureResult")]
        public virtual string AttackExposureResult { get; set; }

        /// <summary>The number of high value resources that are exposed as a result of this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedHighValueResourcesCount")]
        public virtual System.Nullable<int> ExposedHighValueResourcesCount { get; set; }

        /// <summary>The number of high value resources that are exposed as a result of this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedLowValueResourcesCount")]
        public virtual System.Nullable<int> ExposedLowValueResourcesCount { get; set; }

        /// <summary>The number of medium value resources that are exposed as a result of this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedMediumValueResourcesCount")]
        public virtual System.Nullable<int> ExposedMediumValueResourcesCount { get; set; }

        private string _latestCalculationTimeRaw;

        private object _latestCalculationTime;

        /// <summary>The most recent time the attack exposure was updated on this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestCalculationTime")]
        public virtual string LatestCalculationTimeRaw
        {
            get => _latestCalculationTimeRaw;
            set
            {
                _latestCalculationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestCalculationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestCalculationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestCalculationTimeDateTimeOffset instead.")]
        public virtual object LatestCalculationTime
        {
            get => _latestCalculationTime;
            set
            {
                _latestCalculationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestCalculationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestCalculationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestCalculationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestCalculationTimeRaw);
            set => LatestCalculationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// A number between 0 (inclusive) and infinity that represents how important this finding is to remediate. The
        /// higher the score, the more important it is to remediate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<double> Score { get; set; }

        /// <summary>
        /// Output only. What state this AttackExposure is in. This captures whether or not an attack exposure has been
        /// calculated or not.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An AWS account that is a member of an organization.</summary>
    public class GoogleCloudSecuritycenterV2AwsAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier (ID) of the account, containing exactly 12 digits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The friendly name of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// AWS metadata associated with the resource, only applicable if the finding's cloud provider is Amazon Web
    /// Services.
    /// </summary>
    public class GoogleCloudSecuritycenterV2AwsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AWS account associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleCloudSecuritycenterV2AwsAccount Account { get; set; }

        /// <summary>The AWS organization associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual GoogleCloudSecuritycenterV2AwsOrganization Organization { get; set; }

        /// <summary>
        /// A list of AWS organizational units associated with the resource, ordered from lowest level (closest to the
        /// account) to highest level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationalUnits")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2AwsOrganizationalUnit> OrganizationalUnits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An organization is a collection of accounts that are centrally managed together using consolidated billing,
    /// organized hierarchically with organizational units (OUs), and controlled with policies.
    /// </summary>
    public class GoogleCloudSecuritycenterV2AwsOrganization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier (ID) for the organization. The regex pattern for an organization ID string requires
        /// "o-" followed by from 10 to 32 lowercase letters or digits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Organizational Unit (OU) is a container of AWS accounts within a root of an organization. Policies that are
    /// attached to an OU apply to all accounts contained in that OU and in any child OUs.
    /// </summary>
    public class GoogleCloudSecuritycenterV2AwsOrganizationalUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique identifier (ID) associated with this OU. The regex pattern for an organizational unit ID string
        /// requires "ou-" followed by from 4 to 32 lowercase letters or digits (the ID of the root that contains the
        /// OU). This string is followed by a second "-" dash and from 8 to 32 additional lowercase letters or digits.
        /// For example, "ou-ab12-cd34ef56".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The friendly name of the OU.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Azure management group.</summary>
    public class GoogleCloudSecuritycenterV2AzureManagementGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the Azure management group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The UUID of the Azure management group, for example, `20000000-0001-0000-0000-000000000000`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Azure metadata associated with the resource, only applicable if the finding's cloud provider is Microsoft Azure.
    /// </summary>
    public class GoogleCloudSecuritycenterV2AzureMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of Azure management groups associated with the resource, ordered from lowest level (closest to the
        /// subscription) to highest level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2AzureManagementGroup> ManagementGroups { get; set; }

        /// <summary>The Azure resource group associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual GoogleCloudSecuritycenterV2AzureResourceGroup ResourceGroup { get; set; }

        /// <summary>The Azure subscription associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudSecuritycenterV2AzureSubscription Subscription { get; set; }

        /// <summary>The Azure Entra tenant associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual GoogleCloudSecuritycenterV2AzureTenant Tenant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Azure resource group.</summary>
    public class GoogleCloudSecuritycenterV2AzureResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the Azure resource group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the Azure resource group. This is not a UUID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an Azure subscription.</summary>
    public class GoogleCloudSecuritycenterV2AzureSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the Azure subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The UUID of the Azure subscription, for example, `291bba3f-e0a5-47bc-a099-3bdcb2a50a05`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Microsoft Entra tenant.</summary>
    public class GoogleCloudSecuritycenterV2AzureTenant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the Azure tenant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ID of the Microsoft Entra tenant, for example, "a11aaa11-aa11-1aa1-11aa-1aaa11a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to Google Cloud Backup and DR Service findings.</summary>
    public class GoogleCloudSecuritycenterV2BackupDisasterRecovery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the Backup and DR appliance that captures, moves, and manages the lifecycle of backup data. For
        /// example, `backup-server-57137`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appliance")]
        public virtual string Appliance { get; set; }

        /// <summary>
        /// The names of Backup and DR applications. An application is a VM, database, or file system on a managed host
        /// monitored by a backup and recovery appliance. For example, `centos7-01-vol00`, `centos7-01-vol01`,
        /// `centos7-01-vol02`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<string> Applications { get; set; }

        private string _backupCreateTimeRaw;

        private object _backupCreateTime;

        /// <summary>The timestamp at which the Backup and DR backup was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupCreateTime")]
        public virtual string BackupCreateTimeRaw
        {
            get => _backupCreateTimeRaw;
            set
            {
                _backupCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _backupCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="BackupCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use BackupCreateTimeDateTimeOffset instead.")]
        public virtual object BackupCreateTime
        {
            get => _backupCreateTime;
            set
            {
                _backupCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _backupCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="BackupCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? BackupCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(BackupCreateTimeRaw);
            set => BackupCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The name of a Backup and DR template which comprises one or more backup policies. See the [Backup and DR
        /// documentation](https://cloud.google.com/backup-disaster-recovery/docs/concepts/backup-plan#temp) for more
        /// information. For example, `snap-ov`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupTemplate")]
        public virtual string BackupTemplate { get; set; }

        /// <summary>
        /// The backup type of the Backup and DR image. For example, `Snapshot`, `Remote Snapshot`, `OnVault`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        /// <summary>
        /// The name of a Backup and DR host, which is managed by the backup and recovery appliance and known to the
        /// management console. The host can be of type Generic (for example, Compute Engine, SQL Server, Oracle DB, SMB
        /// file system, etc.), vCenter, or an ESX server. See the [Backup and DR documentation on
        /// hosts](https://cloud.google.com/backup-disaster-recovery/docs/configuration/manage-hosts-and-their-applications)
        /// for more information. For example, `centos7-01`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// The names of Backup and DR policies that are associated with a template and that define when to run a
        /// backup, how frequently to run a backup, and how long to retain the backup image. For example, `onvaults`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<string> Policies { get; set; }

        /// <summary>
        /// The names of Backup and DR advanced policy options of a policy applying to an application. See the [Backup
        /// and DR documentation on policy
        /// options](https://cloud.google.com/backup-disaster-recovery/docs/create-plan/policy-settings). For example,
        /// `skipofflineappsincongrp, nounmap`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyOptions")]
        public virtual System.Collections.Generic.IList<string> PolicyOptions { get; set; }

        /// <summary>
        /// The name of the Backup and DR resource profile that specifies the storage media for backups of application
        /// and VM data. See the [Backup and DR documentation on
        /// profiles](https://cloud.google.com/backup-disaster-recovery/docs/concepts/backup-plan#profile). For example,
        /// `GCP`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual string Profile { get; set; }

        /// <summary>
        /// The name of the Backup and DR storage pool that the backup and recovery appliance is storing data in. The
        /// storage pool could be of type Cloud, Primary, Snapshot, or OnVault. See the [Backup and DR documentation on
        /// storage pools](https://cloud.google.com/backup-disaster-recovery/docs/concepts/storage-pools). For example,
        /// `DiskPoolOne`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storagePool")]
        public virtual string StoragePool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures how to deliver Findings to BigQuery Instance.</summary>
    public class GoogleCloudSecuritycenterV2BigQueryExport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which the BigQuery export was created. This field is set by the server and will be
        /// ignored if provided on export on creation.
        /// </summary>
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

        /// <summary>
        /// The dataset to write findings' updates to. Its format is
        /// "projects/[project_id]/datasets/[bigquery_dataset_id]". BigQuery dataset unique ID must contain only letters
        /// (a-z, A-Z), numbers (0-9), or underscores (_).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>The description of the export (max of 1024 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across create/update events of findings. The expression is a
        /// list of zero or more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported,
        /// and `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in
        /// front of them to indicate negation. The fields map to those defined in the corresponding resource. The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the BigQuery export. This field is set by the server
        /// and will be ignored if provided on export creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// Identifier. The relative resource name of this export. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. The following list shows some
        /// examples: + `organizations/{organization_id}/locations/{location_id}/bigQueryExports/{export_id}` +
        /// `folders/{folder_id}/locations/{location_id}/bigQueryExports/{export_id}` +
        /// `projects/{project_id}/locations/{location_id}/bigQueryExports/{export_id}` This field is provided in
        /// responses, and is ignored when provided in create requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The service account that needs permission to create table and upload data to the BigQuery
        /// dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The most recent time at which the BigQuery export was updated. This field is set by the server
        /// and will be ignored if provided on export creation or update.
        /// </summary>
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

    /// <summary>Represents a Kubernetes RoleBinding or ClusterRoleBinding.</summary>
    public class GoogleCloudSecuritycenterV2Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name for the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The Role or ClusterRole referenced by the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual GoogleCloudSecuritycenterV2Role Role { get; set; }

        /// <summary>
        /// Represents one or more subjects that are bound to the role. Not always available for PATCH requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Subject> Subjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a BulkMute request. Contains the LRO information.</summary>
    public class GoogleCloudSecuritycenterV2BulkMuteFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains details about a chokepoint, which is a resource or resource group where high-risk attack paths
    /// converge, based on [attack path simulations]
    /// (https://cloud.google.com/security-command-center/docs/attack-exposure-learn#attack_path_simulations).
    /// </summary>
    public class GoogleCloudSecuritycenterV2Chokepoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of resource names of findings associated with this chokepoint. For example,
        /// organizations/123/sources/456/findings/789. This list will have at most 100 findings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fields related to Google Cloud Armor findings.</summary>
    public class GoogleCloudSecuritycenterV2CloudArmor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about potential Layer 7 DDoS attacks identified by [Google Cloud Armor Adaptive
        /// Protection](https://cloud.google.com/armor/docs/adaptive-protection-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveProtection")]
        public virtual GoogleCloudSecuritycenterV2AdaptiveProtection AdaptiveProtection { get; set; }

        /// <summary>Information about DDoS attack volume and classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attack")]
        public virtual GoogleCloudSecuritycenterV2Attack Attack { get; set; }

        /// <summary>Duration of attack from the start until the current moment (updated every 5 minutes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Information about incoming requests evaluated by [Google Cloud Armor security
        /// policies](https://cloud.google.com/armor/docs/security-policy-overview).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual GoogleCloudSecuritycenterV2Requests Requests { get; set; }

        /// <summary>
        /// Information about the [Google Cloud Armor security
        /// policy](https://cloud.google.com/armor/docs/security-policy-overview) relevant to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPolicy")]
        public virtual GoogleCloudSecuritycenterV2SecurityPolicy SecurityPolicy { get; set; }

        /// <summary>
        /// Distinguish between volumetric &amp;amp; protocol DDoS attack and application layer attacks. For example,
        /// "L3_4" for Layer 3 and Layer 4 DDoS attacks, or "L_7" for Layer 7 DDoS attacks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatVector")]
        public virtual string ThreatVector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The [data profile](https://cloud.google.com/dlp/docs/data-profiles) associated with the finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV2CloudDlpDataProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the data profile, for example, `projects/123/locations/europe/tableProfiles/8383929`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProfile")]
        public virtual string DataProfile { get; set; }

        /// <summary>The resource hierarchy level at which the data profile was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentType")]
        public virtual string ParentType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about the Cloud Data Loss Prevention (Cloud DLP) [inspection
    /// job](https://cloud.google.com/dlp/docs/concepts-job-triggers) that produced the finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV2CloudDlpInspection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Cloud DLP scanned the complete resource or a sampled subset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullScan")]
        public virtual System.Nullable<bool> FullScan { get; set; }

        /// <summary>
        /// The type of information (or *[infoType](https://cloud.google.com/dlp/docs/infotypes-reference)*) found, for
        /// example, `EMAIL_ADDRESS` or `STREET_ADDRESS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual string InfoType { get; set; }

        /// <summary>The number of times Cloud DLP found this infoType within this job and resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeCount")]
        public virtual System.Nullable<long> InfoTypeCount { get; set; }

        /// <summary>
        /// Name of the inspection job, for example, `projects/123/locations/europe/dlpJobs/i-8383929`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectJob")]
        public virtual string InspectJob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata taken from a [Cloud Logging
    /// LogEntry](https://cloud.google.com/logging/docs/reference/v2/rest/v2/LogEntry)
    /// </summary>
    public class GoogleCloudSecuritycenterV2CloudLoggingEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique identifier for the log entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
        public virtual string InsertId { get; set; }

        /// <summary>
        /// The type of the log (part of `log_name`. `log_name` is the resource name of the log to which this log entry
        /// belongs). For example: `cloudresourcemanager.googleapis.com/activity` Note that this field is not
        /// URL-encoded, unlike in `LogEntry`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logId")]
        public virtual string LogId { get; set; }

        /// <summary>
        /// The organization, folder, or project of the monitored resource that produced this log entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        private string _timestampRaw;

        private object _timestamp;

        /// <summary>The time the event described by the log entry occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string TimestampRaw
        {
            get => _timestampRaw;
            set
            {
                _timestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampDateTimeOffset instead.")]
        public virtual object Timestamp
        {
            get => _timestamp;
            set
            {
                _timestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampRaw);
            set => TimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains compliance information about a security standard indicating unmet recommendations.</summary>
    public class GoogleCloudSecuritycenterV2Compliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policies within the standard or benchmark, for example, A.12.4.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>Industry-wide compliance standards or benchmarks, such as CIS, PCI, and OWASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>Version of the standard or benchmark, for example, 1.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the IP connection associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination IP address. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        /// <summary>Destination port. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        /// <summary>IANA Internet Protocol Number such as TCP(6) and UDP(17).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Source IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>Source port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The email address of a contact.</summary>
    public class GoogleCloudSecuritycenterV2Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An email address. For example, "`person123@company.com`".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about specific contacts</summary>
    public class GoogleCloudSecuritycenterV2ContactDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of contacts</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Contact> Contacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2Container : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time that the container was created.</summary>
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

        /// <summary>
        /// Optional container image ID, if provided by the container runtime. Uniquely identifies the container image
        /// launched using a container image digest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageId")]
        public virtual string ImageId { get; set; }

        /// <summary>Container labels, as provided by the container runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Label> Labels { get; set; }

        /// <summary>Name of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Container image URI provided when configuring a pod or container. This string can identify a container image
        /// version using mutable tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CVE stands for Common Vulnerabilities and Exposures. Information from the [CVE
    /// record](https://www.cve.org/ResourcesSupport/Glossary) that describes this vulnerability.
    /// </summary>
    public class GoogleCloudSecuritycenterV2Cve : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describe Common Vulnerability Scoring System specified at
        /// https://www.first.org/cvss/v3.1/specification-document
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssv3")]
        public virtual GoogleCloudSecuritycenterV2Cvssv3 Cvssv3 { get; set; }

        private string _exploitReleaseDateRaw;

        private object _exploitReleaseDate;

        /// <summary>Date the first publicly available exploit or PoC was released.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitReleaseDate")]
        public virtual string ExploitReleaseDateRaw
        {
            get => _exploitReleaseDateRaw;
            set
            {
                _exploitReleaseDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _exploitReleaseDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExploitReleaseDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExploitReleaseDateDateTimeOffset instead.")]
        public virtual object ExploitReleaseDate
        {
            get => _exploitReleaseDate;
            set
            {
                _exploitReleaseDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _exploitReleaseDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExploitReleaseDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExploitReleaseDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExploitReleaseDateRaw);
            set => ExploitReleaseDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The exploitation activity of the vulnerability in the wild.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitationActivity")]
        public virtual string ExploitationActivity { get; set; }

        private string _firstExploitationDateRaw;

        private object _firstExploitationDate;

        /// <summary>Date of the earliest known exploitation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstExploitationDate")]
        public virtual string FirstExploitationDateRaw
        {
            get => _firstExploitationDateRaw;
            set
            {
                _firstExploitationDate = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _firstExploitationDateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FirstExploitationDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FirstExploitationDateDateTimeOffset instead.")]
        public virtual object FirstExploitationDate
        {
            get => _firstExploitationDate;
            set
            {
                _firstExploitationDateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _firstExploitationDate = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="FirstExploitationDateRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FirstExploitationDateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FirstExploitationDateRaw);
            set => FirstExploitationDateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The unique identifier for the vulnerability. e.g. CVE-2021-34527</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The potential impact of the vulnerability if it was to be exploited.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impact")]
        public virtual string Impact { get; set; }

        /// <summary>Whether or not the vulnerability has been observed in the wild.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedInTheWild")]
        public virtual System.Nullable<bool> ObservedInTheWild { get; set; }

        /// <summary>
        /// Additional information about the CVE. e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Reference> References { get; set; }

        /// <summary>Whether upstream fix is available for the CVE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upstreamFixAvailable")]
        public virtual System.Nullable<bool> UpstreamFixAvailable { get; set; }

        /// <summary>Whether or not the vulnerability was zero day when the finding was published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zeroDay")]
        public virtual System.Nullable<bool> ZeroDay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common Vulnerability Scoring System version 3.</summary>
    public class GoogleCloudSecuritycenterV2Cvssv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This metric describes the conditions beyond the attacker's control that must exist in order to exploit the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>
        /// Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and
        /// across user environments. This metric reflects the context by which vulnerability exploitation is possible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        /// <summary>
        /// This metric measures the impact to the availability of the impacted component resulting from a successfully
        /// exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<double> BaseScore { get; set; }

        /// <summary>
        /// This metric measures the impact to the confidentiality of the information resources managed by a software
        /// component due to a successfully exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        /// <summary>This metric measures the impact to integrity of a successfully exploited vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        /// <summary>
        /// This metric describes the level of privileges an attacker must possess before successfully exploiting the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        /// <summary>
        /// The Scope metric captures whether a vulnerability in one vulnerable component impacts resources in
        /// components beyond its security scope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// This metric captures the requirement for a human user, other than the attacker, to participate in the
        /// successful compromise of the vulnerable component.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CWE stands for Common Weakness Enumeration. Information about this weakness, as described by
    /// [CWE](https://cwe.mitre.org/).
    /// </summary>
    public class GoogleCloudSecuritycenterV2Cwe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CWE identifier, e.g. CWE-94</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Any reference to the details on the CWE, for example, https://cwe.mitre.org/data/definitions/94.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Reference> References { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about a data access attempt made by a principal not authorized under applicable data security policy.
    /// </summary>
    public class GoogleCloudSecuritycenterV2DataAccessEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier for data access event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Timestamp of data access event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The operation performed by the principal to access the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>
        /// The email address of the principal that accessed the data. The principal could be a user account, service
        /// account, Google group, or other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about a data flow event, in which either the data is moved to or is accessed from a non-compliant
    /// geo-location, as defined in the applicable data security policy.
    /// </summary>
    public class GoogleCloudSecuritycenterV2DataFlowEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier for data flow event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Timestamp of data flow event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The operation performed by the principal for the data flow event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>
        /// The email address of the principal that initiated the data flow event. The principal could be a user
        /// account, service account, Google group, or other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>Non-compliant location of the principal or the data destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violatedLocation")]
        public virtual string ViolatedLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about data retention deletion violations, in which the data is non-compliant based on their retention or
    /// deletion time, as defined in the applicable data security policy. The Data Retention Deletion (DRD) control is a
    /// control of the DSPM (Data Security Posture Management) suite that enables organizations to manage data retention
    /// and deletion policies in compliance with regulations, such as GDPR and CRPA. DRD supports two primary policy
    /// types: maximum storage length (max TTL) and minimum storage length (min TTL). Both are aimed at helping
    /// organizations meet regulatory and data management commitments.
    /// </summary>
    public class GoogleCloudSecuritycenterV2DataRetentionDeletionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of objects that violated the policy for this resource. If the number is less than 1,000, then the
        /// value of this field is the exact number. If the number of objects that violated the policy is greater than
        /// or equal to 1,000, then the value of this field is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataObjectCount")]
        public virtual System.Nullable<long> DataObjectCount { get; set; }

        private string _eventDetectionTimeRaw;

        private object _eventDetectionTime;

        /// <summary>Timestamp indicating when the event was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDetectionTime")]
        public virtual string EventDetectionTimeRaw
        {
            get => _eventDetectionTimeRaw;
            set
            {
                _eventDetectionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventDetectionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventDetectionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventDetectionTimeDateTimeOffset instead.")]
        public virtual object EventDetectionTime
        {
            get => _eventDetectionTime;
            set
            {
                _eventDetectionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventDetectionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EventDetectionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventDetectionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventDetectionTimeRaw);
            set => EventDetectionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Type of the DRD event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// Maximum duration of retention allowed from the DRD control. This comes from the DRD control where users set
        /// a max TTL for their data. For example, suppose that a user sets the max TTL for a Cloud Storage bucket to 90
        /// days. However, an object in that bucket is 100 days old. In this case, a DataRetentionDeletionEvent will be
        /// generated for that Cloud Storage bucket, and the max_retention_allowed is 90 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxRetentionAllowed")]
        public virtual object MaxRetentionAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents database access information, such as queries. A database may be a sub-resource of an instance (as in
    /// the case of Cloud SQL instances or Cloud Spanner instances), or the database instance itself. Some database
    /// resources might not have the [full resource name](https://google.aip.dev/122#full-resource-names) populated
    /// because these resource types, such as Cloud SQL databases, are not yet supported by Cloud Asset Inventory. In
    /// these cases only the display name is provided.
    /// </summary>
    public class GoogleCloudSecuritycenterV2Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the database that the user connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The target usernames, roles, or groups of an SQL privilege grant, which is not an IAM policy change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantees")]
        public virtual System.Collections.Generic.IList<string> Grantees { get; set; }

        /// <summary>
        /// Some database resources may not have the [full resource
        /// name](https://google.aip.dev/122#full-resource-names) populated because these resource types are not yet
        /// supported by Cloud Asset Inventory (e.g. Cloud SQL databases). In these cases only the display name will be
        /// provided. The [full resource name](https://google.aip.dev/122#full-resource-names) of the database that the
        /// user connected to, if it is supported by Cloud Asset Inventory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The SQL statement that is associated with the database access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The username used to connect to the database. The username might not be an IAM principal and does not have a
        /// set format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>
        /// The version of the database, for example, POSTGRES_14. See [the complete
        /// list](https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/SqlDatabaseVersion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Denied IP rule.</summary>
    public class GoogleCloudSecuritycenterV2Denied : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Optional list of denied IP rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Memory hash detection contributing to the binary family match.</summary>
    public class GoogleCloudSecuritycenterV2Detection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the binary associated with the memory hash signature detection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual string Binary { get; set; }

        /// <summary>The percentage of memory page hashes in the signature that were matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentPagesMatched")]
        public virtual System.Nullable<double> PercentPagesMatched { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the disk associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the disk, for example,
        /// "https://www.googleapis.com/compute/v1/projects/{project-id}/zones/{zone-id}/disks/{disk-id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Path of the file in terms of underlying disk/partition identifiers.</summary>
    public class GoogleCloudSecuritycenterV2DiskPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// UUID of the partition (format https://wiki.archlinux.org/title/persistent_block_device_naming#by-uuid)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionUuid")]
        public virtual string PartitionUuid { get; set; }

        /// <summary>
        /// Relative path of the file in the partition as a JSON encoded string. Example: /home/user1/executable_file.sh
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativePath")]
        public virtual string RelativePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The record of a dynamic mute rule that matches the finding.</summary>
    public class GoogleCloudSecuritycenterV2DynamicMuteRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _matchTimeRaw;

        private object _matchTime;

        /// <summary>When the dynamic mute rule first matched the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchTime")]
        public virtual string MatchTimeRaw
        {
            get => _matchTimeRaw;
            set
            {
                _matchTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _matchTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MatchTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MatchTimeDateTimeOffset instead.")]
        public virtual object MatchTime
        {
            get => _matchTime;
            set
            {
                _matchTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _matchTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="MatchTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MatchTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MatchTimeRaw);
            set => MatchTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The relative resource name of the mute rule, represented by a mute config, that created this record, for
        /// example `organizations/123/muteConfigs/mymuteconfig` or
        /// `organizations/123/locations/global/muteConfigs/mymuteconfig`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteConfig")]
        public virtual string MuteConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A name-value pair representing an environment variable used in an operating system process.</summary>
    public class GoogleCloudSecuritycenterV2EnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environment variable name as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Environment variable value as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("val")]
        public virtual string Val { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource where data was exfiltrated from or exfiltrated to.</summary>
    public class GoogleCloudSecuritycenterV2ExfilResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Subcomponents of the asset that was exfiltrated, like URIs used during exfiltration, table names, databases,
        /// and filenames. For example, multiple tables might have been exfiltrated from the same Cloud SQL instance, or
        /// multiple files might have been exfiltrated from the same Cloud Storage bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        /// <summary>
        /// The resource's [full resource name](https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exfiltration represents a data exfiltration attempt from one or more sources to one or more targets. The
    /// `sources` attribute lists the sources of the exfiltrated data. The `targets` attribute lists the destinations
    /// the data was copied to.
    /// </summary>
    public class GoogleCloudSecuritycenterV2Exfiltration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are multiple sources, then the data is considered "joined" between them. For instance, BigQuery can
        /// join multiple tables, and each table would be considered a source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ExfilResource> Sources { get; set; }

        /// <summary>
        /// If there are multiple targets, each target would get a complete copy of the "joined" source data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ExfilResource> Targets { get; set; }

        /// <summary>Total exfiltrated bytes processed for the entire job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalExfiltratedBytes")]
        public virtual System.Nullable<long> TotalExfiltratedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of third party SIEM/SOAR fields within SCC.</summary>
    public class GoogleCloudSecuritycenterV2ExternalSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>References primary/secondary etc assignees in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignees")]
        public virtual System.Collections.Generic.IList<string> Assignees { get; set; }

        private string _caseCloseTimeRaw;

        private object _caseCloseTime;

        /// <summary>The time when the case was closed, as reported by the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseCloseTime")]
        public virtual string CaseCloseTimeRaw
        {
            get => _caseCloseTimeRaw;
            set
            {
                _caseCloseTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _caseCloseTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaseCloseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaseCloseTimeDateTimeOffset instead.")]
        public virtual object CaseCloseTime
        {
            get => _caseCloseTime;
            set
            {
                _caseCloseTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _caseCloseTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CaseCloseTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaseCloseTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaseCloseTimeRaw);
            set => CaseCloseTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _caseCreateTimeRaw;

        private object _caseCreateTime;

        /// <summary>The time when the case was created, as reported by the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseCreateTime")]
        public virtual string CaseCreateTimeRaw
        {
            get => _caseCreateTimeRaw;
            set
            {
                _caseCreateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _caseCreateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaseCreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaseCreateTimeDateTimeOffset instead.")]
        public virtual object CaseCreateTime
        {
            get => _caseCreateTime;
            set
            {
                _caseCreateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _caseCreateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CaseCreateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaseCreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaseCreateTimeRaw);
            set => CaseCreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The priority of the finding's corresponding case in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("casePriority")]
        public virtual string CasePriority { get; set; }

        private string _caseSlaRaw;

        private object _caseSla;

        /// <summary>The SLA of the finding's corresponding case in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseSla")]
        public virtual string CaseSlaRaw
        {
            get => _caseSlaRaw;
            set
            {
                _caseSla = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _caseSlaRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CaseSlaRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CaseSlaDateTimeOffset instead.")]
        public virtual object CaseSla
        {
            get => _caseSla;
            set
            {
                _caseSlaRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _caseSla = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CaseSlaRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CaseSlaDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CaseSlaRaw);
            set => CaseSlaRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The link to the finding's corresponding case in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseUri")]
        public virtual string CaseUri { get; set; }

        private string _externalSystemUpdateTimeRaw;

        private object _externalSystemUpdateTime;

        /// <summary>The time when the case was last updated, as reported by the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystemUpdateTime")]
        public virtual string ExternalSystemUpdateTimeRaw
        {
            get => _externalSystemUpdateTimeRaw;
            set
            {
                _externalSystemUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _externalSystemUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExternalSystemUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExternalSystemUpdateTimeDateTimeOffset instead.")]
        public virtual object ExternalSystemUpdateTime
        {
            get => _externalSystemUpdateTime;
            set
            {
                _externalSystemUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _externalSystemUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExternalSystemUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExternalSystemUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExternalSystemUpdateTimeRaw);
            set => ExternalSystemUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The identifier that's used to track the finding's corresponding case in the external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUid")]
        public virtual string ExternalUid { get; set; }

        /// <summary>
        /// Full resource name of the external system. The following list shows some examples: +
        /// `organizations/1234/sources/5678/findings/123456/externalSystems/jira` +
        /// `organizations/1234/sources/5678/locations/us/findings/123456/externalSystems/jira` +
        /// `folders/1234/sources/5678/findings/123456/externalSystems/jira` +
        /// `folders/1234/sources/5678/locations/us/findings/123456/externalSystems/jira` +
        /// `projects/1234/sources/5678/findings/123456/externalSystems/jira` +
        /// `projects/1234/sources/5678/locations/us/findings/123456/externalSystems/jira`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The most recent status of the finding's corresponding case, as reported by the external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Information about the ticket, if any, that is being used to track the resolution of the issue that is
        /// identified by this finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketInfo")]
        public virtual GoogleCloudSecuritycenterV2TicketInfo TicketInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// File information about the related binary/library used by an executable, or the script used by a script
    /// interpreter
    /// </summary>
    public class GoogleCloudSecuritycenterV2File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Prefix of the file contents as a JSON-encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>Path of the file in terms of underlying disk/partition identifiers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskPath")]
        public virtual GoogleCloudSecuritycenterV2DiskPath DiskPath { get; set; }

        /// <summary>
        /// The length in bytes of the file prefix that was hashed. If hashed_size == size, any hashes reported
        /// represent the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedSize")]
        public virtual System.Nullable<long> HashedSize { get; set; }

        /// <summary>True when the hash covers only a prefix of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partiallyHashed")]
        public virtual System.Nullable<bool> PartiallyHashed { get; set; }

        /// <summary>Absolute path of the file as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// SHA256 hash of the first hashed_size bytes of the file encoded as a hex string. If hashed_size == size,
        /// sha256 represents the SHA256 hash of the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>Size of the file in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center finding. A finding is a record of assessment data like security, risk, health, or
    /// privacy, that is ingested into Security Command Center for presentation, notification, analysis, policy testing,
    /// and enforcement. For example, a cross-site scripting (XSS) vulnerability in an App Engine application is a
    /// finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV2Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Access details associated with the finding, such as more information on the caller, which method was
        /// accessed, and from where.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual GoogleCloudSecuritycenterV2Access Access { get; set; }

        /// <summary>Represents an application associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual GoogleCloudSecuritycenterV2Application Application { get; set; }

        /// <summary>The results of an attack path simulation relevant to this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposure")]
        public virtual GoogleCloudSecuritycenterV2AttackExposure AttackExposure { get; set; }

        /// <summary>Fields related to Backup and DR findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupDisasterRecovery")]
        public virtual GoogleCloudSecuritycenterV2BackupDisasterRecovery BackupDisasterRecovery { get; set; }

        /// <summary>
        /// Output only. The canonical name of the finding. The following list shows some examples: +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}` +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}` +
        /// `folders/{folder_id}/sources/{source_id}/findings/{finding_id}` +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}` +
        /// `projects/{project_id}/sources/{source_id}/findings/{finding_id}` +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}` The prefix is the
        /// closest CRM ancestor of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// Immutable. The additional taxonomy group within findings from a given source. Example: "XSS_FLASH_INJECTION"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Contains details about a chokepoint, which is a resource or resource group where high-risk attack paths
        /// converge, based on [attack path simulations]
        /// (https://cloud.google.com/security-command-center/docs/attack-exposure-learn#attack_path_simulations). This
        /// field cannot be updated. Its value is ignored in all update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chokepoint")]
        public virtual GoogleCloudSecuritycenterV2Chokepoint Chokepoint { get; set; }

        /// <summary>Fields related to Cloud Armor findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudArmor")]
        public virtual GoogleCloudSecuritycenterV2CloudArmor CloudArmor { get; set; }

        /// <summary>Cloud DLP data profile that is associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpDataProfile")]
        public virtual GoogleCloudSecuritycenterV2CloudDlpDataProfile CloudDlpDataProfile { get; set; }

        /// <summary>
        /// Cloud Data Loss Prevention (Cloud DLP) inspection results that are associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpInspection")]
        public virtual GoogleCloudSecuritycenterV2CloudDlpInspection CloudDlpInspection { get; set; }

        /// <summary>Contains compliance information for security standards associated to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliances")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Compliance> Compliances { get; set; }

        /// <summary>Contains information about the IP connection associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Connection> Connections { get; set; }

        /// <summary>
        /// Output only. Map containing the points of contact for the given finding. The key represents the type of
        /// contact, while the value contains a list of all the contacts that pertain. Please refer to:
        /// https://cloud.google.com/resource-manager/docs/managing-notification-contacts#notification-categories {
        /// "security": { "contacts": [ { "email": "person1@company.com" }, { "email": "person2@company.com" } ] } }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV2ContactDetails> Contacts { get; set; }

        /// <summary>
        /// Containers associated with the finding. This field provides information for both Kubernetes and
        /// non-Kubernetes containers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Container> Containers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the finding was created in Security Command Center.</summary>
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

        /// <summary>Data access events associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataAccessEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DataAccessEvent> DataAccessEvents { get; set; }

        /// <summary>Data flow events associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFlowEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DataFlowEvent> DataFlowEvents { get; set; }

        /// <summary>Data retention deletion events associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionDeletionEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DataRetentionDeletionEvent> DataRetentionDeletionEvents { get; set; }

        /// <summary>Database associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual GoogleCloudSecuritycenterV2Database Database { get; set; }

        /// <summary>Contains more details about the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Disk associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual GoogleCloudSecuritycenterV2Disk Disk { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time the finding was first detected. If an existing finding is updated, then this is the time the update
        /// occurred. For example, if the finding represents an open firewall, this property captures the time the
        /// detector believes the firewall became open. The accuracy is determined by the detector. If the finding is
        /// later resolved, then this time reflects when the finding was resolved. This must not be set to a value
        /// greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Represents exfiltrations associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exfiltration")]
        public virtual GoogleCloudSecuritycenterV2Exfiltration Exfiltration { get; set; }

        /// <summary>
        /// Output only. Third party SIEM/SOAR fields within SCC, contains external system information and external
        /// system finding fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystems")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV2ExternalSystem> ExternalSystems { get; set; }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>File associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2File> Files { get; set; }

        /// <summary>The class of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingClass")]
        public virtual string FindingClass { get; set; }

        /// <summary>
        /// Contains details about groups of which this finding is a member. A group is a collection of findings that
        /// are related in some way. This field cannot be updated. Its value is ignored in all update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupMemberships")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2GroupMembership> GroupMemberships { get; set; }

        /// <summary>Represents IAM bindings associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamBindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IamBinding> IamBindings { get; set; }

        /// <summary>
        /// Represents what's commonly known as an *indicator of compromise* (IoC) in computer forensics. This is an
        /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
        /// intrusion. For more information, see [Indicator of
        /// compromise](https://en.wikipedia.org/wiki/Indicator_of_compromise).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indicator")]
        public virtual GoogleCloudSecuritycenterV2Indicator Indicator { get; set; }

        /// <summary>IP rules associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual GoogleCloudSecuritycenterV2IpRules IpRules { get; set; }

        /// <summary>Job associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual GoogleCloudSecuritycenterV2Job Job { get; set; }

        /// <summary>Signature of the kernel rootkit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelRootkit")]
        public virtual GoogleCloudSecuritycenterV2KernelRootkit KernelRootkit { get; set; }

        /// <summary>Kubernetes resources associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetes")]
        public virtual GoogleCloudSecuritycenterV2Kubernetes Kubernetes { get; set; }

        /// <summary>The load balancers associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2LoadBalancer> LoadBalancers { get; set; }

        /// <summary>Log entries that are relevant to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logEntries")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2LogEntry> LogEntries { get; set; }

        /// <summary>
        /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mitreAttack")]
        public virtual GoogleCloudSecuritycenterV2MitreAttack MitreAttack { get; set; }

        /// <summary>
        /// Unique identifier of the module which generated the finding. Example:
        /// folders/598186756061/securityHealthAnalyticsSettings/customModules/56799441161885
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        /// <summary>
        /// Indicates the mute state of a finding (either muted, unmuted or undefined). Unlike other attributes of a
        /// finding, a finding provider shouldn't set the value of mute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual string Mute { get; set; }

        /// <summary>Output only. The mute information regarding this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteInfo")]
        public virtual GoogleCloudSecuritycenterV2MuteInfo MuteInfo { get; set; }

        /// <summary>
        /// Records additional information about the mute operation, for example, the [mute
        /// configuration](https://cloud.google.com/security-command-center/docs/how-to-mute-findings) that muted the
        /// finding and the user who muted the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        private string _muteUpdateTimeRaw;

        private object _muteUpdateTime;

        /// <summary>Output only. The most recent time this finding was muted or unmuted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteUpdateTime")]
        public virtual string MuteUpdateTimeRaw
        {
            get => _muteUpdateTimeRaw;
            set
            {
                _muteUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _muteUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MuteUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MuteUpdateTimeDateTimeOffset instead.")]
        public virtual object MuteUpdateTime
        {
            get => _muteUpdateTime;
            set
            {
                _muteUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _muteUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MuteUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MuteUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MuteUpdateTimeRaw);
            set => MuteUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The [relative resource name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of
        /// the finding. The following list shows some examples: +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}` +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}` +
        /// `folders/{folder_id}/sources/{source_id}/findings/{finding_id}` +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}` +
        /// `projects/{project_id}/sources/{source_id}/findings/{finding_id}` +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Represents the VPC networks that the resource is attached to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Network> Networks { get; set; }

        /// <summary>Steps to address the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSteps")]
        public virtual string NextSteps { get; set; }

        /// <summary>Notebook associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebook")]
        public virtual GoogleCloudSecuritycenterV2Notebook Notebook { get; set; }

        /// <summary>Contains information about the org policies associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicies")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2OrgPolicy> OrgPolicies { get; set; }

        /// <summary>
        /// The relative resource name of the source and location the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. The following list shows some examples: +
        /// `organizations/{organization_id}/sources/{source_id}` + `folders/{folders_id}/sources/{source_id}` +
        /// `projects/{projects_id}/sources/{source_id}` +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}` +
        /// `folders/{folders_id}/sources/{source_id}/locations/{location_id}` +
        /// `projects/{projects_id}/sources/{source_id}/locations/{location_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Output only. The human readable display name of the finding source such as "Event Threat Detection" or
        /// "Security Health Analytics".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>Represents operating system processes associated with the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Process> Processes { get; set; }

        /// <summary>
        /// Immutable. For findings on Google Cloud resources, the full resource name of the Google Cloud resource this
        /// finding is for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding
        /// is for a non-Google Cloud resource, the resourceName can be a customer or partner defined string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. User specified security marks. These marks are entirely managed by the user and come from the
        /// SecurityMarks resource that belongs to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual GoogleCloudSecuritycenterV2SecurityMarks SecurityMarks { get; set; }

        /// <summary>The security posture associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPosture")]
        public virtual GoogleCloudSecuritycenterV2SecurityPosture SecurityPosture { get; set; }

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

        /// <summary>Output only. The state of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Contains details about a group of security issues that, when the issues occur together, represent a greater
        /// risk than when the issues occur independently. A group of such issues is referred to as a toxic combination.
        /// This field cannot be updated. Its value is ignored in all update requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("toxicCombination")]
        public virtual GoogleCloudSecuritycenterV2ToxicCombination ToxicCombination { get; set; }

        /// <summary>
        /// Represents vulnerability-specific fields like CVE and CVSS scores. CVE stands for Common Vulnerabilities and
        /// Exposures (https://cve.mitre.org/about/)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual GoogleCloudSecuritycenterV2Vulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message that contains the resource name and display name of a folder resource.</summary>
    public class GoogleCloudSecuritycenterV2Folder : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>Represents a geographical location for a given access.</summary>
    public class GoogleCloudSecuritycenterV2Geolocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A CLDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains details about groups of which this finding is a member. A group is a collection of findings that are
    /// related in some way.
    /// </summary>
    public class GoogleCloudSecuritycenterV2GroupMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>Type of group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a particular IAM binding, which captures a member's role addition, removal, or state.
    /// </summary>
    public class GoogleCloudSecuritycenterV2IamBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action that was performed on a Binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// A single identity requesting access for a Cloud Platform resource, for example, "foo@google.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        /// <summary>
        /// Role that is assigned to "members". For example, "roles/viewer", "roles/editor", or "roles/owner".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents what's commonly known as an _indicator of compromise_ (IoC) in computer forensics. This is an
    /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
    /// intrusion. For more information, see [Indicator of
    /// compromise](https://en.wikipedia.org/wiki/Indicator_of_compromise).
    /// </summary>
    public class GoogleCloudSecuritycenterV2Indicator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domains associated to the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>The list of IP addresses that are associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>
        /// The list of matched signatures indicating that the given process is present in the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ProcessSignature> Signatures { get; set; }

        /// <summary>The list of URIs associated to the Findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IP rule information.</summary>
    public class GoogleCloudSecuritycenterV2IpRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional list of ports to which this rule applies. This field is only applicable for the UDP or
        /// (S)TCP protocols. Each entry must be either an integer or a range including a min and max port number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portRanges")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2PortRange> PortRanges { get; set; }

        /// <summary>
        /// The IP protocol this rule applies to. This value can either be one of the following well known protocol
        /// strings (TCP, UDP, ICMP, ESP, AH, IPIP, SCTP) or a string representation of the integer value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IP rules associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2IpRules : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tuple with allowed rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowed")]
        public virtual GoogleCloudSecuritycenterV2Allowed Allowed { get; set; }

        /// <summary>Tuple with denied rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denied")]
        public virtual GoogleCloudSecuritycenterV2Denied Denied { get; set; }

        /// <summary>
        /// If destination IP ranges are specified, the firewall rule applies only to traffic that has a destination IP
        /// address in these ranges. These ranges must be expressed in CIDR format. Only supports IPv4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIpRanges")]
        public virtual System.Collections.Generic.IList<string> DestinationIpRanges { get; set; }

        /// <summary>The direction that the rule is applicable to, one of ingress or egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>
        /// Name of the network protocol service, such as FTP, that is exposed by the open port. Follows the naming
        /// convention available at:
        /// https://www.iana.org/assignments/service-names-port-numbers/service-names-port-numbers.xhtml.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedServices")]
        public virtual System.Collections.Generic.IList<string> ExposedServices { get; set; }

        /// <summary>
        /// If source IP ranges are specified, the firewall rule applies only to traffic that has a source IP address in
        /// these ranges. These ranges must be expressed in CIDR format. Only supports IPv4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIpRanges")]
        public virtual System.Collections.Generic.IList<string> SourceIpRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security Command Center Issue.</summary>
    public class GoogleCloudSecuritycenterV2Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the issue was created.</summary>
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

        /// <summary>The description of the issue in Markdown format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The finding category or rule name that generated the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detection")]
        public virtual string Detection { get; set; }

        /// <summary>The domains of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueDomain> Domains { get; set; }

        /// <summary>The exposure score of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposureScore")]
        public virtual System.Nullable<double> ExposureScore { get; set; }

        /// <summary>The type of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueType")]
        public virtual string IssueType { get; set; }

        private string _lastObservationTimeRaw;

        private object _lastObservationTime;

        /// <summary>The time the issue was last observed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastObservationTime")]
        public virtual string LastObservationTimeRaw
        {
            get => _lastObservationTimeRaw;
            set
            {
                _lastObservationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastObservationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastObservationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastObservationTimeDateTimeOffset instead.")]
        public virtual object LastObservationTime
        {
            get => _lastObservationTime;
            set
            {
                _lastObservationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastObservationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastObservationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastObservationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastObservationTimeRaw);
            set => LastObservationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The mute information of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual GoogleCloudSecuritycenterV2IssueMute Mute { get; set; }

        /// <summary>
        /// Identifier. The name of the issue. Format: organizations/{organization}/locations/{location}/issues/{issue}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The primary resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryResource")]
        public virtual GoogleCloudSecuritycenterV2IssueResource PrimaryResource { get; set; }

        /// <summary>The findings related to the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueFinding> RelatedFindings { get; set; }

        /// <summary>Approaches to remediate the issue in Markdown format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediations")]
        public virtual System.Collections.Generic.IList<string> Remediations { get; set; }

        /// <summary>Additional resources associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondaryResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueResource> SecondaryResources { get; set; }

        /// <summary>The security context of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueSecurityContext> SecurityContexts { get; set; }

        /// <summary>The severity of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. The state of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the issue was last updated.</summary>
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

    /// <summary>The domains of an issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain category of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainCategory")]
        public virtual string DomainCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Finding related to an issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CVE of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual GoogleCloudSecuritycenterV2IssueFindingCve Cve { get; set; }

        /// <summary>The name of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The security bulletin of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityBulletin")]
        public virtual GoogleCloudSecuritycenterV2IssueFindingSecurityBulletin SecurityBulletin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The CVE of the finding.</summary>
    public class GoogleCloudSecuritycenterV2IssueFindingCve : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CVE name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The security bulletin of the finding.</summary>
    public class GoogleCloudSecuritycenterV2IssueFindingSecurityBulletin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The security bulletin name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The mute information of the issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueMute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the user who last changed the mute state of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        /// <summary>The user-provided reason for muting the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteReason")]
        public virtual string MuteReason { get; set; }

        /// <summary>Output only. The mute state of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteState")]
        public virtual string MuteState { get; set; }

        private string _muteUpdateTimeRaw;

        private object _muteUpdateTime;

        /// <summary>The time the issue was muted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteUpdateTime")]
        public virtual string MuteUpdateTimeRaw
        {
            get => _muteUpdateTimeRaw;
            set
            {
                _muteUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _muteUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MuteUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MuteUpdateTimeDateTimeOffset instead.")]
        public virtual object MuteUpdateTime
        {
            get => _muteUpdateTime;
            set
            {
                _muteUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _muteUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MuteUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MuteUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(MuteUpdateTimeRaw);
            set => MuteUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource associated with the an issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The AWS metadata of the resource associated with the issue. Only populated for AWS resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsMetadata")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAwsMetadata AwsMetadata { get; set; }

        /// <summary>
        /// The Azure metadata of the resource associated with the issue. Only populated for Azure resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureMetadata")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAzureMetadata AzureMetadata { get; set; }

        /// <summary>The cloud provider of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        /// <summary>The resource-type specific display name of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The Google Cloud metadata of the resource associated with the issue. Only populated for Google Cloud
        /// resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudMetadata")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceGoogleCloudMetadata GoogleCloudMetadata { get; set; }

        /// <summary>The full resource name of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The type of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The AWS metadata of a resource associated with an issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueResourceAwsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AWS account of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAwsMetadataAwsAccount Account { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The AWS account of the resource associated with the issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueResourceAwsMetadataAwsAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AWS account ID of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The AWS account name of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Azure metadata of a resource associated with an issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueResourceAzureMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Azure subscription of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAzureMetadataAzureSubscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Azure subscription of the resource associated with the issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueResourceAzureMetadataAzureSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Azure subscription display name of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The Azure subscription ID of the resource associated with the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud metadata of a resource associated with an issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueResourceGoogleCloudMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The project ID that the resource associated with the issue belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security context associated with an issue.</summary>
    public class GoogleCloudSecuritycenterV2IssueSecurityContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The aggregated count of the security context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatedCount")]
        public virtual GoogleCloudSecuritycenterV2IssueSecurityContextAggregatedCount AggregatedCount { get; set; }

        /// <summary>The context of the security context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudSecuritycenterV2IssueSecurityContextContext Context { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Aggregated count of a security context.</summary>
    public class GoogleCloudSecuritycenterV2IssueSecurityContextAggregatedCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Aggregation key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Aggregation value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<int> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Context of a security context.</summary>
    public class GoogleCloudSecuritycenterV2IssueSecurityContextContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Context type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Context values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a job</summary>
    public class GoogleCloudSecuritycenterV2Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If the job did not complete successfully, this field describes why.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual System.Nullable<int> ErrorCode { get; set; }

        /// <summary>Optional. Gives the location where the job ran, such as `US` or `europe-west1`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The fully-qualified name for a job. e.g. `projects//jobs/`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the job, such as `RUNNING` or `PENDING`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kernel mode rootkit signatures.</summary>
    public class GoogleCloudSecuritycenterV2KernelRootkit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rootkit name, when available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>True if unexpected modifications of kernel code memory are present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedCodeModification")]
        public virtual System.Nullable<bool> UnexpectedCodeModification { get; set; }

        /// <summary>
        /// True if `ftrace` points are present with callbacks pointing to regions that are not in the expected kernel
        /// or module code range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedFtraceHandler")]
        public virtual System.Nullable<bool> UnexpectedFtraceHandler { get; set; }

        /// <summary>
        /// True if interrupt handlers that are are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedInterruptHandler")]
        public virtual System.Nullable<bool> UnexpectedInterruptHandler { get; set; }

        /// <summary>
        /// True if kernel code pages that are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKernelCodePages")]
        public virtual System.Nullable<bool> UnexpectedKernelCodePages { get; set; }

        /// <summary>
        /// True if `kprobe` points are present with callbacks pointing to regions that are not in the expected kernel
        /// or module code range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKprobeHandler")]
        public virtual System.Nullable<bool> UnexpectedKprobeHandler { get; set; }

        /// <summary>
        /// True if unexpected processes in the scheduler run queue are present. Such processes are in the run queue,
        /// but not in the process task list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedProcessesInRunqueue")]
        public virtual System.Nullable<bool> UnexpectedProcessesInRunqueue { get; set; }

        /// <summary>True if unexpected modifications of kernel read-only data memory are present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedReadOnlyDataModification")]
        public virtual System.Nullable<bool> UnexpectedReadOnlyDataModification { get; set; }

        /// <summary>
        /// True if system call handlers that are are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedSystemCallHandler")]
        public virtual System.Nullable<bool> UnexpectedSystemCallHandler { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes-related attributes.</summary>
    public class GoogleCloudSecuritycenterV2Kubernetes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Provides information on any Kubernetes access reviews (privilege checks) relevant to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessReviews")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2AccessReview> AccessReviews { get; set; }

        /// <summary>
        /// Provides Kubernetes role binding information for findings that involve [RoleBindings or
        /// ClusterRoleBindings](https://cloud.google.com/kubernetes-engine/docs/how-to/role-based-access-control).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Binding> Bindings { get; set; }

        /// <summary>
        /// GKE [node pools](https://cloud.google.com/kubernetes-engine/docs/concepts/node-pools) associated with the
        /// finding. This field contains node pool information for each node, when it is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2NodePool> NodePools { get; set; }

        /// <summary>
        /// Provides Kubernetes
        /// [node](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture#nodes) information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Node> Nodes { get; set; }

        /// <summary>Kubernetes objects related to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Object> Objects { get; set; }

        /// <summary>
        /// Kubernetes [Pods](https://cloud.google.com/kubernetes-engine/docs/concepts/pod) associated with the finding.
        /// This field contains Pod records for each container that is owned by a Pod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pods")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Pod> Pods { get; set; }

        /// <summary>
        /// Provides Kubernetes role information for findings that involve [Roles or
        /// ClusterRoles](https://cloud.google.com/kubernetes-engine/docs/how-to/role-based-access-control).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a generic name-value label. A label has separate name and value fields to support filtering with the
    /// `contains()` function. For more information, see [Filtering on array-type
    /// fields](https://cloud.google.com/security-command-center/docs/how-to-api-list-findings#array-contains-filtering).
    /// </summary>
    public class GoogleCloudSecuritycenterV2Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value that corresponds to the label's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information related to the load balancer associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2LoadBalancer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the load balancer associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual entry in a log.</summary>
    public class GoogleCloudSecuritycenterV2LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An individual entry in a log stored in Cloud Logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudLoggingEntry")]
        public virtual GoogleCloudSecuritycenterV2CloudLoggingEntry CloudLoggingEntry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature corresponding to memory page hashes.</summary>
    public class GoogleCloudSecuritycenterV2MemoryHashSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The binary family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryFamily")]
        public virtual string BinaryFamily { get; set; }

        /// <summary>The list of memory hash detections contributing to the binary family match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Detection> Detections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
    /// </summary>
    public class GoogleCloudSecuritycenterV2MitreAttack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional MITRE ATT&amp;CK tactics related to this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTactics")]
        public virtual System.Collections.Generic.IList<string> AdditionalTactics { get; set; }

        /// <summary>
        /// Additional MITRE ATT&amp;amp;CK techniques related to this finding, if any, along with any of their
        /// respective parent techniques.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTechniques")]
        public virtual System.Collections.Generic.IList<string> AdditionalTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK tactic most closely represented by this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTactic")]
        public virtual string PrimaryTactic { get; set; }

        /// <summary>
        /// The MITRE ATT&amp;amp;CK technique most closely represented by this finding, if any. primary_techniques is a
        /// repeated field because there are multiple levels of MITRE ATT&amp;amp;CK techniques. If the technique most
        /// closely represented by this finding is a sub-technique (e.g. `SCANNING_IP_BLOCKS`), both the sub-technique
        /// and its parent technique(s) will be listed (e.g. `SCANNING_IP_BLOCKS`, `ACTIVE_SCANNING`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTechniques")]
        public virtual System.Collections.Generic.IList<string> PrimaryTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK version referenced by the above fields. E.g. "8".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mute config is a Cloud SCC resource that contains the configuration to mute create/update events of findings.
    /// </summary>
    public class GoogleCloudSecuritycenterV2MuteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which the mute config was created. This field is set by the server and will be
        /// ignored if provided on config creation.
        /// </summary>
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

        /// <summary>A description of the mute config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _expiryTimeRaw;

        private object _expiryTime;

        /// <summary>
        /// Optional. The expiry of the mute config. Only applicable for dynamic configs. If the expiry is set, when the
        /// config expires, it is removed from all findings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTime")]
        public virtual string ExpiryTimeRaw
        {
            get => _expiryTimeRaw;
            set
            {
                _expiryTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expiryTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpiryTimeDateTimeOffset instead.")]
        public virtual object ExpiryTime
        {
            get => _expiryTime;
            set
            {
                _expiryTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expiryTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpiryTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpiryTimeRaw);
            set => ExpiryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. An expression that defines the filter to apply across create/update events of findings. While
        /// creating a filter string, be mindful of the scope in which the mute configuration is being created. E.g., If
        /// a filter contains project = X but is created under the project = Y scope, it might not match any findings.
        /// The following field and operator combinations are supported: * severity: `=`, `:` * category: `=`, `:` *
        /// resource.name: `=`, `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` *
        /// resource.folders.resource_folder: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name:
        /// `=`, `:` * resource.type: `=`, `:` * finding_class: `=`, `:` * indicator.ip_addresses: `=`, `:` *
        /// indicator.domains: `=`, `:`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the mute config. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// Identifier. This field will be ignored if provided on config creation. The following list shows some
        /// examples of the format: + `organizations/{organization}/muteConfigs/{mute_config}` +
        /// `organizations/{organization}locations/{location}//muteConfigs/{mute_config}` +
        /// `folders/{folder}/muteConfigs/{mute_config}` +
        /// `folders/{folder}/locations/{location}/muteConfigs/{mute_config}` +
        /// `projects/{project}/muteConfigs/{mute_config}` +
        /// `projects/{project}/locations/{location}/muteConfigs/{mute_config}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The type of the mute config, which determines what type of mute state the config affects.
        /// Immutable after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The most recent time at which the mute config was updated. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
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
    /// Mute information about the finding, including whether the finding has a static mute or any matching dynamic mute
    /// rules.
    /// </summary>
    public class GoogleCloudSecuritycenterV2MuteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of dynamic mute rules that currently match the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicMuteRecords")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DynamicMuteRecord> DynamicMuteRecords { get; set; }

        /// <summary>
        /// If set, the static mute applied to this finding. Static mutes override dynamic mutes. If unset, there is no
        /// static mute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticMute")]
        public virtual GoogleCloudSecuritycenterV2StaticMute StaticMute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about a VPC network associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2Network : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the VPC network resource, for example,
        /// `//compute.googleapis.com/projects/my-project/global/networks/my-network`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes nodes associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2Node : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Full resource name](https://google.aip.dev/122#full-resource-names) of the Compute Engine VM running the
        /// cluster node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides GKE node pool information.</summary>
    public class GoogleCloudSecuritycenterV2NodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Kubernetes node pool name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nodes associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Node> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Jupyter notebook IPYNB file, such as a [Colab Enterprise
    /// notebook](https://cloud.google.com/colab/docs/introduction) file, that is associated with a finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV2Notebook : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user ID of the latest author to modify the notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAuthor")]
        public virtual string LastAuthor { get; set; }

        /// <summary>The name of the notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _notebookUpdateTimeRaw;

        private object _notebookUpdateTime;

        /// <summary>The most recent time the notebook was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebookUpdateTime")]
        public virtual string NotebookUpdateTimeRaw
        {
            get => _notebookUpdateTimeRaw;
            set
            {
                _notebookUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notebookUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotebookUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotebookUpdateTimeDateTimeOffset instead.")]
        public virtual object NotebookUpdateTime
        {
            get => _notebookUpdateTime;
            set
            {
                _notebookUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notebookUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NotebookUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotebookUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotebookUpdateTimeRaw);
            set => NotebookUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The source notebook service, for example, "Colab Enterprise".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud SCC's Notification</summary>
    public class GoogleCloudSecuritycenterV2NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If it's a Finding based notification config, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual GoogleCloudSecuritycenterV2Finding Finding { get; set; }

        /// <summary>Name of the notification config that generated current notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        /// <summary>The Cloud resource tied to this notification's Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV2Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Kubernetes object related to the finding, uniquely identified by GKNN. Used if the object Kind is not one of
    /// Pod, Node, NodePool, Binding, or AccessReview.
    /// </summary>
    public class GoogleCloudSecuritycenterV2Object : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pod containers associated with this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Container> Containers { get; set; }

        /// <summary>Kubernetes object group, such as "policy.k8s.io/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Kubernetes object kind, such as "Namespace".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Kubernetes object name. For details see
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Kubernetes object namespace. Must be a valid DNS label. Named "ns" to avoid collision with C++ namespace
        /// keyword. For details see https://kubernetes.io/docs/tasks/administer-cluster/namespaces/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the org policies associated with the finding.</summary>
    public class GoogleCloudSecuritycenterV2OrgPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The resource name of the org policy. Example:
        /// "organizations/{organization_id}/policies/{constraint_name}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Package is a generic definition of a package.</summary>
    public class GoogleCloudSecuritycenterV2Package : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CPE URI where the vulnerability was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The name of the package where the vulnerability was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Type of package, for example, os, maven, or go.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageVersion")]
        public virtual string PackageVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kubernetes Pod.</summary>
    public class GoogleCloudSecuritycenterV2Pod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pod containers associated with this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Container> Containers { get; set; }

        /// <summary>Pod labels. For Kubernetes containers, these are applied to the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Label> Labels { get; set; }

        /// <summary>Kubernetes Pod name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Kubernetes Pod namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The policy field that violates the deployed posture and its expected and detected values.</summary>
    public class GoogleCloudSecuritycenterV2PolicyDriftDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The detected value that violates the deployed posture, for example, `false` or
        /// `allowed_values={"projects/22831892"}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedValue")]
        public virtual string DetectedValue { get; set; }

        /// <summary>
        /// The value of this field that was configured in a posture, for example, `true` or
        /// `allowed_values={"projects/29831892"}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedValue")]
        public virtual string ExpectedValue { get; set; }

        /// <summary>
        /// The name of the updated field, for example constraint.implementation.policy_rules[0].enforce
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A port range which is inclusive of the min and max values. Values are between 0 and 2^16-1. The max can be equal
    /// / must be not smaller than the min value. If min and max are equal this indicates that it is a single port.
    /// </summary>
    public class GoogleCloudSecuritycenterV2PortRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum port value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<long> Max { get; set; }

        /// <summary>Minimum port value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<long> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an operating system process.</summary>
    public class GoogleCloudSecuritycenterV2Process : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Process arguments as JSON encoded strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>True if `args` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentsTruncated")]
        public virtual System.Nullable<bool> ArgumentsTruncated { get; set; }

        /// <summary>File information for the process executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual GoogleCloudSecuritycenterV2File Binary { get; set; }

        /// <summary>Process environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2EnvironmentVariable> EnvVariables { get; set; }

        /// <summary>True if `env_variables` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariablesTruncated")]
        public virtual System.Nullable<bool> EnvVariablesTruncated { get; set; }

        /// <summary>File information for libraries loaded by the process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("libraries")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2File> Libraries { get; set; }

        /// <summary>
        /// The process name, as displayed in utilities like `top` and `ps`. This name can be accessed through
        /// `/proc/[pid]/comm` and changed with `prctl(PR_SET_NAME)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The parent process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentPid")]
        public virtual System.Nullable<long> ParentPid { get; set; }

        /// <summary>The process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        /// <summary>
        /// When the process represents the invocation of a script, `binary` provides information about the interpreter,
        /// while `script` provides information about the script file provided to the interpreter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual GoogleCloudSecuritycenterV2File Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates what signature matched this process.</summary>
    public class GoogleCloudSecuritycenterV2ProcessSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Signature indicating that a binary family was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryHashSignature")]
        public virtual GoogleCloudSecuritycenterV2MemoryHashSignature MemoryHashSignature { get; set; }

        /// <summary>Describes the type of resource associated with the signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureType")]
        public virtual string SignatureType { get; set; }

        /// <summary>Signature indicating that a YARA rule was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRuleSignature")]
        public virtual GoogleCloudSecuritycenterV2YaraRuleSignature YaraRuleSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional Links</summary>
    public class GoogleCloudSecuritycenterV2Reference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source of the reference e.g. NVD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Uri for the mentioned source e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the requests relevant to the finding.</summary>
    public class GoogleCloudSecuritycenterV2Requests : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allowed RPS (requests per second) over the long term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longTermAllowed")]
        public virtual System.Nullable<int> LongTermAllowed { get; set; }

        /// <summary>Denied RPS (requests per second) over the long term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longTermDenied")]
        public virtual System.Nullable<int> LongTermDenied { get; set; }

        /// <summary>
        /// For 'Increasing deny ratio', the ratio is the denied traffic divided by the allowed traffic. For 'Allowed
        /// traffic spike', the ratio is the allowed traffic in the short term divided by allowed traffic in the long
        /// term.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratio")]
        public virtual System.Nullable<double> Ratio { get; set; }

        /// <summary>Allowed RPS (requests per second) in the short term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortTermAllowed")]
        public virtual System.Nullable<int> ShortTermAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV2Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The AWS metadata associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("awsMetadata")]
        public virtual GoogleCloudSecuritycenterV2AwsMetadata AwsMetadata { get; set; }

        /// <summary>The Azure metadata associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("azureMetadata")]
        public virtual GoogleCloudSecuritycenterV2AzureMetadata AzureMetadata { get; set; }

        /// <summary>Indicates which cloud provider the finding is from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        /// <summary>The human readable name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The GCP metadata associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpMetadata")]
        public virtual GcpMetadata GcpMetadata { get; set; }

        /// <summary>The region or location of the service (if applicable).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Provides the path to the resource within the resource hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePath")]
        public virtual GoogleCloudSecuritycenterV2ResourcePath ResourcePath { get; set; }

        /// <summary>
        /// A string representation of the resource path. For Google Cloud, it has the format of
        /// `organizations/{organization_id}/folders/{folder_id}/folders/{folder_id}/projects/{project_id}` where there
        /// can be any number of folders. For AWS, it has the format of
        /// `org/{organization_id}/ou/{organizational_unit_id}/ou/{organizational_unit_id}/account/{account_id}` where
        /// there can be any number of organizational units. For Azure, it has the format of
        /// `mg/{management_group_id}/mg/{management_group_id}/subscription/{subscription_id}/rg/{resource_group_name}`
        /// where there can be any number of management groups.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePathString")]
        public virtual string ResourcePathString { get; set; }

        /// <summary>The service or resource provider associated with the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The full resource type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the path of resources leading up to the resource this finding is about.</summary>
    public class GoogleCloudSecuritycenterV2ResourcePath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of nodes that make the up resource path, ordered from lowest level to highest level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ResourcePathNode> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A node within the resource path. Each node represents a resource within the resource hierarchy.
    /// </summary>
    public class GoogleCloudSecuritycenterV2ResourcePathNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the resource this node represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ID of the resource this node represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of resource this node represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeType")]
        public virtual string NodeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource value configuration (RVC) is a mapping configuration of user's resources to resource values. Used in
    /// Attack path simulations.
    /// </summary>
    public class GoogleCloudSecuritycenterV2ResourceValueConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cloud provider this configuration applies to</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Timestamp this resource value configuration was created.</summary>
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

        /// <summary>Description of the resource value configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Identifier. Name for the resource value configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// List of resource labels to search for, evaluated with `AND`. For example, "resource_labels_selector":
        /// {"key": "value", "env": "prod"} will match resources with labels "key": "value" `AND` "env": "prod"
        /// https://cloud.google.com/resource-manager/docs/creating-managing-labels
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLabelsSelector")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceLabelsSelector { get; set; }

        /// <summary>
        /// Apply resource_value only to resources that match resource_type. resource_type will be checked with `AND` of
        /// other resources. For example, "storage.googleapis.com/Bucket" with resource_value "HIGH" will apply "HIGH"
        /// value only to "storage.googleapis.com/Bucket" resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>
        /// Resource value level this expression represents Only required when there is no Sensitive Data Protection
        /// mapping in the request
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceValue")]
        public virtual string ResourceValue { get; set; }

        /// <summary>
        /// Project or folder to scope this configuration to. For example, "project/456" would apply this configuration
        /// only to resources in "project/456" scope and will be checked with `AND` of other resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// A mapping of the sensitivity on Sensitive Data Protection finding to resource values. This mapping can only
        /// be used in combination with a resource_type that is related to BigQuery, e.g.
        /// "bigquery.googleapis.com/Dataset".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveDataProtectionMapping")]
        public virtual GoogleCloudSecuritycenterV2SensitiveDataProtectionMapping SensitiveDataProtectionMapping { get; set; }

        /// <summary>
        /// Tag values combined with `AND` to check against. For Google Cloud resources, they are tag value IDs in the
        /// form of "tagValues/123". Example: `[ "tagValues/123", "tagValues/456", "tagValues/789" ]`
        /// https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValues")]
        public virtual System.Collections.Generic.IList<string> TagValues { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp this resource value configuration was last updated.</summary>
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

    /// <summary>Kubernetes Role or ClusterRole.</summary>
    public class GoogleCloudSecuritycenterV2Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Role type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Role name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Role namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SecurityBulletin are notifications of vulnerabilities of Google products.</summary>
    public class GoogleCloudSecuritycenterV2SecurityBulletin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the bulletin corresponding to the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletinId")]
        public virtual string BulletinId { get; set; }

        private string _submissionTimeRaw;

        private object _submissionTime;

        /// <summary>Submission time of this Security Bulletin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submissionTime")]
        public virtual string SubmissionTimeRaw
        {
            get => _submissionTimeRaw;
            set
            {
                _submissionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _submissionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SubmissionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SubmissionTimeDateTimeOffset instead.")]
        public virtual object SubmissionTime
        {
            get => _submissionTime;
            set
            {
                _submissionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _submissionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SubmissionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SubmissionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SubmissionTimeRaw);
            set => SubmissionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// This represents a version that the cluster receiving this notification should be upgraded to, based on its
        /// current version. For example, 1.15.0
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedUpgradeVersion")]
        public virtual string SuggestedUpgradeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User specified security marks that are attached to the parent Security Command Center resource. Security marks
    /// are scoped within a Security Command Center organization -- they can be modified and viewed by all users who
    /// have proper permissions on the organization.
    /// </summary>
    public class GoogleCloudSecuritycenterV2SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the marks. The following list shows some examples: +
        /// `organizations/{organization_id}/assets/{asset_id}/securityMarks` +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks` +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location}/findings/{finding_id}/securityMarks`
        /// + `folders/{folder_id}/assets/{asset_id}/securityMarks` +
        /// `folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks` +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location}/findings/{finding_id}/securityMarks` +
        /// `projects/{project_number}/assets/{asset_id}/securityMarks` +
        /// `projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks` +
        /// `projects/{project_number}/sources/{source_id}/locations/{location}/findings/{finding_id}/securityMarks`
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
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name The following list shows some
        /// examples: + `organizations/{organization_id}/assets/{asset_id}/securityMarks` +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks` +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location}/findings/{finding_id}/securityMarks`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the [Google Cloud Armor security
    /// policy](https://cloud.google.com/armor/docs/security-policy-overview) relevant to the finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV2SecurityPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Google Cloud Armor security policy, for example, "my-security-policy".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether or not the associated rule or policy is in preview mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preview")]
        public virtual System.Nullable<bool> Preview { get; set; }

        /// <summary>
        /// The type of Google Cloud Armor security policy for example, 'backend security policy', 'edge security
        /// policy', 'network edge security policy', or 'always-on DDoS protection'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a posture that is deployed on Google Cloud by the Security Command Center Posture Management service.
    /// A posture contains one or more policy sets. A policy set is a group of policies that enforce a set of security
    /// rules on Google Cloud.
    /// </summary>
    public class GoogleCloudSecuritycenterV2SecurityPosture : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the updated policy, for example, `projects/{project_id}/policies/{constraint_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changedPolicy")]
        public virtual string ChangedPolicy { get; set; }

        /// <summary>Name of the posture, for example, `CIS-Posture`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID of the updated policy, for example, `compute-policy-1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>The details about a change in an updated policy that violates the deployed posture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDriftDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2PolicyDriftDetails> PolicyDriftDetails { get; set; }

        /// <summary>The name of the updated policy set, for example, `cis-policyset`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySet")]
        public virtual string PolicySet { get; set; }

        /// <summary>
        /// The name of the posture deployment, for example,
        /// `organizations/{org_id}/posturedeployments/{posture_deployment_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDeployment")]
        public virtual string PostureDeployment { get; set; }

        /// <summary>
        /// The project, folder, or organization on which the posture is deployed, for example,
        /// `projects/{project_number}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDeploymentResource")]
        public virtual string PostureDeploymentResource { get; set; }

        /// <summary>The version of the posture, for example, `c7cfa2a8`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource value mapping for Sensitive Data Protection findings If any of these mappings have a resource value
    /// that is not unspecified, the resource_value field will be ignored when reading this configuration.
    /// </summary>
    public class GoogleCloudSecuritycenterV2SensitiveDataProtectionMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource value mapping for high-sensitivity Sensitive Data Protection findings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highSensitivityMapping")]
        public virtual string HighSensitivityMapping { get; set; }

        /// <summary>Resource value mapping for medium-sensitivity Sensitive Data Protection findings</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediumSensitivityMapping")]
        public virtual string MediumSensitivityMapping { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identity delegation history of an authenticated service account.</summary>
    public class GoogleCloudSecuritycenterV2ServiceAccountDelegationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of a Google account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string representing the principal_subject associated with the identity. As compared to `principal_email`,
        /// supports principals that aren't associated with email addresses, such as third party principals. For most
        /// identities, the format will be `principal://iam.googleapis.com/{identity pool name}/subjects/{subject}`
        /// except for some GKE identities (GKE_WORKLOAD, FREEFORM, GKE_HUB_WORKLOAD) that are still in the legacy
        /// format `serviceAccount:{identity pool name}[{subject}]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the static mute state. A static mute state overrides any dynamic mute rules that apply to this
    /// finding. The static mute state can be set by a static mute rule or by muting the finding directly.
    /// </summary>
    public class GoogleCloudSecuritycenterV2StaticMute : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _applyTimeRaw;

        private object _applyTime;

        /// <summary>When the static mute was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyTime")]
        public virtual string ApplyTimeRaw
        {
            get => _applyTimeRaw;
            set
            {
                _applyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _applyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ApplyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ApplyTimeDateTimeOffset instead.")]
        public virtual object ApplyTime
        {
            get => _applyTime;
            set
            {
                _applyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _applyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ApplyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ApplyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ApplyTimeRaw);
            set => ApplyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The static mute state. If the value is `MUTED` or `UNMUTED`, then the finding's overall mute state will have
        /// the same value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Kubernetes subject.</summary>
    public class GoogleCloudSecuritycenterV2Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Authentication type for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the ticket, if any, that is being used to track the resolution of the issue that is identified
    /// by this finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV2TicketInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assignee of the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual string Assignee { get; set; }

        /// <summary>The description of the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The identifier of the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The latest status of the ticket, as reported by the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time when the ticket was last updated, as reported by the ticket system.</summary>
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

        /// <summary>The link to the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains details about a group of security issues that, when the issues occur together, represent a greater risk
    /// than when the issues occur independently. A group of such issues is referred to as a toxic combination.
    /// </summary>
    public class GoogleCloudSecuritycenterV2ToxicCombination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [Attack exposure
        /// score](https://cloud.google.com/security-command-center/docs/attack-exposure-learn#attack_exposure_scores)
        /// of this toxic combination. The score is a measure of how much this toxic combination exposes one or more
        /// high-value resources to potential attack.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureScore")]
        public virtual System.Nullable<double> AttackExposureScore { get; set; }

        /// <summary>
        /// List of resource names of findings associated with this toxic combination. For example,
        /// `organizations/123/sources/456/findings/789`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Refers to common vulnerability fields e.g. cve, cvss, cwe etc.</summary>
    public class GoogleCloudSecuritycenterV2Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CVE stands for Common Vulnerabilities and Exposures (https://cve.mitre.org/about/)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual GoogleCloudSecuritycenterV2Cve Cve { get; set; }

        /// <summary>
        /// Represents one or more Common Weakness Enumeration (CWE) information on this vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cwes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Cwe> Cwes { get; set; }

        /// <summary>The fixed package is relevant to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPackage")]
        public virtual GoogleCloudSecuritycenterV2Package FixedPackage { get; set; }

        /// <summary>The offending package is relevant to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offendingPackage")]
        public virtual GoogleCloudSecuritycenterV2Package OffendingPackage { get; set; }

        /// <summary>
        /// Provider provided risk_score based on multiple factors. The higher the risk score, the more risky the
        /// vulnerability is.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerRiskScore")]
        public virtual System.Nullable<long> ProviderRiskScore { get; set; }

        /// <summary>Represents whether the vulnerability is reachable (detected via static analysis)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reachable")]
        public virtual System.Nullable<bool> Reachable { get; set; }

        /// <summary>The security bulletin is relevant to this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityBulletin")]
        public virtual GoogleCloudSecuritycenterV2SecurityBulletin SecurityBulletin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature corresponding to a YARA rule.</summary>
    public class GoogleCloudSecuritycenterV2YaraRuleSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the YARA rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRule")]
        public virtual string YaraRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains details about groups of which this finding is a member. A group is a collection of findings that are
    /// related in some way.
    /// </summary>
    public class GroupMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        /// <summary>Type of group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a particular IAM binding, which captures a member's role addition, removal, or state.
    /// </summary>
    public class IamBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action that was performed on a Binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// A single identity requesting access for a Cloud Platform resource, for example, "foo@google.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        /// <summary>
        /// Role that is assigned to "members". For example, "roles/viewer", "roles/editor", or "roles/owner".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents what's commonly known as an _indicator of compromise_ (IoC) in computer forensics. This is an
    /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
    /// intrusion. For more information, see [Indicator of
    /// compromise](https://en.wikipedia.org/wiki/Indicator_of_compromise).
    /// </summary>
    public class Indicator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domains associated to the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>The list of IP addresses that are associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>
        /// The list of matched signatures indicating that the given process is present in the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<ProcessSignature> Signatures { get; set; }

        /// <summary>The list of URIs associated to the Findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IP rule information.</summary>
    public class IpRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. An optional list of ports to which this rule applies. This field is only applicable for the UDP or
        /// (S)TCP protocols. Each entry must be either an integer or a range including a min and max port number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portRanges")]
        public virtual System.Collections.Generic.IList<PortRange> PortRanges { get; set; }

        /// <summary>
        /// The IP protocol this rule applies to. This value can either be one of the following well known protocol
        /// strings (TCP, UDP, ICMP, ESP, AH, IPIP, SCTP) or a string representation of the integer value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IP rules associated with the finding.</summary>
    public class IpRules : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tuple with allowed rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowed")]
        public virtual Allowed Allowed { get; set; }

        /// <summary>Tuple with denied rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("denied")]
        public virtual Denied Denied { get; set; }

        /// <summary>
        /// If destination IP ranges are specified, the firewall rule applies only to traffic that has a destination IP
        /// address in these ranges. These ranges must be expressed in CIDR format. Only supports IPv4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIpRanges")]
        public virtual System.Collections.Generic.IList<string> DestinationIpRanges { get; set; }

        /// <summary>The direction that the rule is applicable to, one of ingress or egress.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        /// <summary>
        /// Name of the network protocol service, such as FTP, that is exposed by the open port. Follows the naming
        /// convention available at:
        /// https://www.iana.org/assignments/service-names-port-numbers/service-names-port-numbers.xhtml.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedServices")]
        public virtual System.Collections.Generic.IList<string> ExposedServices { get; set; }

        /// <summary>
        /// If source IP ranges are specified, the firewall rule applies only to traffic that has a source IP address in
        /// these ranges. These ranges must be expressed in CIDR format. Only supports IPv4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIpRanges")]
        public virtual System.Collections.Generic.IList<string> SourceIpRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a job</summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If the job did not complete successfully, this field describes why.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual System.Nullable<int> ErrorCode { get; set; }

        /// <summary>Optional. Gives the location where the job ran, such as `US` or `europe-west1`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The fully-qualified name for a job. e.g. `projects//jobs/`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. State of the job, such as `RUNNING` or `PENDING`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kernel mode rootkit signatures.</summary>
    public class KernelRootkit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rootkit name, when available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>True if unexpected modifications of kernel code memory are present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedCodeModification")]
        public virtual System.Nullable<bool> UnexpectedCodeModification { get; set; }

        /// <summary>
        /// True if `ftrace` points are present with callbacks pointing to regions that are not in the expected kernel
        /// or module code range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedFtraceHandler")]
        public virtual System.Nullable<bool> UnexpectedFtraceHandler { get; set; }

        /// <summary>
        /// True if interrupt handlers that are are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedInterruptHandler")]
        public virtual System.Nullable<bool> UnexpectedInterruptHandler { get; set; }

        /// <summary>
        /// True if kernel code pages that are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKernelCodePages")]
        public virtual System.Nullable<bool> UnexpectedKernelCodePages { get; set; }

        /// <summary>
        /// True if `kprobe` points are present with callbacks pointing to regions that are not in the expected kernel
        /// or module code range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKprobeHandler")]
        public virtual System.Nullable<bool> UnexpectedKprobeHandler { get; set; }

        /// <summary>
        /// True if unexpected processes in the scheduler run queue are present. Such processes are in the run queue,
        /// but not in the process task list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedProcessesInRunqueue")]
        public virtual System.Nullable<bool> UnexpectedProcessesInRunqueue { get; set; }

        /// <summary>True if unexpected modifications of kernel read-only data memory are present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedReadOnlyDataModification")]
        public virtual System.Nullable<bool> UnexpectedReadOnlyDataModification { get; set; }

        /// <summary>
        /// True if system call handlers that are are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedSystemCallHandler")]
        public virtual System.Nullable<bool> UnexpectedSystemCallHandler { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes-related attributes.</summary>
    public class Kubernetes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Provides information on any Kubernetes access reviews (privilege checks) relevant to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessReviews")]
        public virtual System.Collections.Generic.IList<AccessReview> AccessReviews { get; set; }

        /// <summary>
        /// Provides Kubernetes role binding information for findings that involve [RoleBindings or
        /// ClusterRoleBindings](https://cloud.google.com/kubernetes-engine/docs/how-to/role-based-access-control).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1Binding> Bindings { get; set; }

        /// <summary>
        /// GKE [node pools](https://cloud.google.com/kubernetes-engine/docs/concepts/node-pools) associated with the
        /// finding. This field contains node pool information for each node, when it is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<NodePool> NodePools { get; set; }

        /// <summary>
        /// Provides Kubernetes
        /// [node](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture#nodes) information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>Kubernetes objects related to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual System.Collections.Generic.IList<Object> Objects { get; set; }

        /// <summary>
        /// Kubernetes [Pods](https://cloud.google.com/kubernetes-engine/docs/concepts/pod) associated with the finding.
        /// This field contains Pod records for each container that is owned by a Pod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pods")]
        public virtual System.Collections.Generic.IList<Pod> Pods { get; set; }

        /// <summary>
        /// Provides Kubernetes role information for findings that involve [Roles or
        /// ClusterRoles](https://cloud.google.com/kubernetes-engine/docs/how-to/role-based-access-control).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a generic name-value label. A label has separate name and value fields to support filtering with the
    /// `contains()` function. For more information, see [Filtering on array-type
    /// fields](https://cloud.google.com/security-command-center/docs/how-to-api-list-findings#array-contains-filtering).
    /// </summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value that corresponds to the label's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information related to the load balancer associated with the finding.</summary>
    public class LoadBalancer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the load balancer associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual entry in a log.</summary>
    public class LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An individual entry in a log stored in Cloud Logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudLoggingEntry")]
        public virtual CloudLoggingEntry CloudLoggingEntry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature corresponding to memory page hashes.</summary>
    public class MemoryHashSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The binary family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryFamily")]
        public virtual string BinaryFamily { get; set; }

        /// <summary>The list of memory hash detections contributing to the binary family match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<Detection> Detections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
    /// </summary>
    public class MitreAttack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional MITRE ATT&amp;CK tactics related to this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTactics")]
        public virtual System.Collections.Generic.IList<string> AdditionalTactics { get; set; }

        /// <summary>
        /// Additional MITRE ATT&amp;amp;CK techniques related to this finding, if any, along with any of their
        /// respective parent techniques.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTechniques")]
        public virtual System.Collections.Generic.IList<string> AdditionalTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK tactic most closely represented by this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTactic")]
        public virtual string PrimaryTactic { get; set; }

        /// <summary>
        /// The MITRE ATT&amp;amp;CK technique most closely represented by this finding, if any. primary_techniques is a
        /// repeated field because there are multiple levels of MITRE ATT&amp;amp;CK techniques. If the technique most
        /// closely represented by this finding is a sub-technique (e.g. `SCANNING_IP_BLOCKS`), both the sub-technique
        /// and its parent technique(s) will be listed (e.g. `SCANNING_IP_BLOCKS`, `ACTIVE_SCANNING`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTechniques")]
        public virtual System.Collections.Generic.IList<string> PrimaryTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK version referenced by the above fields. E.g. "8".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Mute information about the finding, including whether the finding has a static mute or any matching dynamic mute
    /// rules.
    /// </summary>
    public class MuteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of dynamic mute rules that currently match the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicMuteRecords")]
        public virtual System.Collections.Generic.IList<DynamicMuteRecord> DynamicMuteRecords { get; set; }

        /// <summary>
        /// If set, the static mute applied to this finding. Static mutes override dynamic mutes. If unset, there is no
        /// static mute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticMute")]
        public virtual StaticMute StaticMute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about a VPC network associated with the finding.</summary>
    public class Network : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the VPC network resource, for example,
        /// `//compute.googleapis.com/projects/my-project/global/networks/my-network`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes nodes associated with the finding.</summary>
    public class Node : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Full resource name](https://google.aip.dev/122#full-resource-names) of the Compute Engine VM running the
        /// cluster node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides GKE node pool information.</summary>
    public class NodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Kubernetes node pool name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nodes associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Jupyter notebook IPYNB file, such as a [Colab Enterprise
    /// notebook](https://cloud.google.com/colab/docs/introduction) file, that is associated with a finding.
    /// </summary>
    public class Notebook : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user ID of the latest author to modify the notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAuthor")]
        public virtual string LastAuthor { get; set; }

        /// <summary>The name of the notebook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _notebookUpdateTimeRaw;

        private object _notebookUpdateTime;

        /// <summary>The most recent time the notebook was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notebookUpdateTime")]
        public virtual string NotebookUpdateTimeRaw
        {
            get => _notebookUpdateTimeRaw;
            set
            {
                _notebookUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notebookUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotebookUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotebookUpdateTimeDateTimeOffset instead.")]
        public virtual object NotebookUpdateTime
        {
            get => _notebookUpdateTime;
            set
            {
                _notebookUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notebookUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NotebookUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotebookUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotebookUpdateTimeRaw);
            set => NotebookUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The source notebook service, for example, "Colab Enterprise".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Kubernetes object related to the finding, uniquely identified by GKNN. Used if the object Kind is not one of
    /// Pod, Node, NodePool, Binding, or AccessReview.
    /// </summary>
    public class Object : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pod containers associated with this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>Kubernetes object group, such as "policy.k8s.io/v1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Kubernetes object kind, such as "Namespace".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Kubernetes object name. For details see
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Kubernetes object namespace. Must be a valid DNS label. Named "ns" to avoid collision with C++ namespace
        /// keyword. For details see https://kubernetes.io/docs/tasks/administer-cluster/namespaces/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the org policies associated with the finding.</summary>
    public class OrgPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the org policy. Example: "organizations/{organization_id}/policies/{constraint_name}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Package is a generic definition of a package.</summary>
    public class Package : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The CPE URI where the vulnerability was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        /// <summary>The name of the package where the vulnerability was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Type of package, for example, os, maven, or go.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        /// <summary>The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageVersion")]
        public virtual string PackageVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kubernetes Pod.</summary>
    public class Pod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pod containers associated with this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>Pod labels. For Kubernetes containers, these are applied to the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>Kubernetes Pod name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Kubernetes Pod namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The policy field that violates the deployed posture and its expected and detected values.</summary>
    public class PolicyDriftDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The detected value that violates the deployed posture, for example, `false` or
        /// `allowed_values={"projects/22831892"}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedValue")]
        public virtual string DetectedValue { get; set; }

        /// <summary>
        /// The value of this field that was configured in a posture, for example, `true` or
        /// `allowed_values={"projects/29831892"}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedValue")]
        public virtual string ExpectedValue { get; set; }

        /// <summary>
        /// The name of the updated field, for example constraint.implementation.policy_rules[0].enforce
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A port range which is inclusive of the min and max values. Values are between 0 and 2^16-1. The max can be equal
    /// / must be not smaller than the min value. If min and max are equal this indicates that it is a single port.
    /// </summary>
    public class PortRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum port value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<long> Max { get; set; }

        /// <summary>Minimum port value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<long> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an operating system process.</summary>
    public class Process : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Process arguments as JSON encoded strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>True if `args` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentsTruncated")]
        public virtual System.Nullable<bool> ArgumentsTruncated { get; set; }

        /// <summary>File information for the process executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual File Binary { get; set; }

        /// <summary>Process environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IList<EnvironmentVariable> EnvVariables { get; set; }

        /// <summary>True if `env_variables` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariablesTruncated")]
        public virtual System.Nullable<bool> EnvVariablesTruncated { get; set; }

        /// <summary>File information for libraries loaded by the process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("libraries")]
        public virtual System.Collections.Generic.IList<File> Libraries { get; set; }

        /// <summary>
        /// The process name, as displayed in utilities like `top` and `ps`. This name can be accessed through
        /// `/proc/[pid]/comm` and changed with `prctl(PR_SET_NAME)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The parent process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentPid")]
        public virtual System.Nullable<long> ParentPid { get; set; }

        /// <summary>The process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        /// <summary>
        /// When the process represents the invocation of a script, `binary` provides information about the interpreter,
        /// while `script` provides information about the script file provided to the interpreter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual File Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates what signature matched this process.</summary>
    public class ProcessSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Signature indicating that a binary family was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryHashSignature")]
        public virtual MemoryHashSignature MemoryHashSignature { get; set; }

        /// <summary>Describes the type of resource associated with the signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureType")]
        public virtual string SignatureType { get; set; }

        /// <summary>Signature indicating that a YARA rule was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRuleSignature")]
        public virtual YaraRuleSignature YaraRuleSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Rapid Vulnerability Detection service.</summary>
    public class RapidVulnerabilityDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the settings were last updated.</summary>
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

    /// <summary>Additional Links</summary>
    public class Reference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source of the reference e.g. NVD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Uri for the mentioned source e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the requests relevant to the finding.</summary>
    public class Requests : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allowed RPS (requests per second) over the long term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longTermAllowed")]
        public virtual System.Nullable<int> LongTermAllowed { get; set; }

        /// <summary>Denied RPS (requests per second) over the long term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longTermDenied")]
        public virtual System.Nullable<int> LongTermDenied { get; set; }

        /// <summary>
        /// For 'Increasing deny ratio', the ratio is the denied traffic divided by the allowed traffic. For 'Allowed
        /// traffic spike', the ratio is the allowed traffic in the short term divided by allowed traffic in the long
        /// term.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ratio")]
        public virtual System.Nullable<double> Ratio { get; set; }

        /// <summary>Allowed RPS (requests per second) in the short term.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortTermAllowed")]
        public virtual System.Nullable<int> ShortTermAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the path of resources leading up to the resource this finding is about.</summary>
    public class ResourcePath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of nodes that make the up resource path, ordered from lowest level to highest level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<ResourcePathNode> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A node within the resource path. Each node represents a resource within the resource hierarchy.
    /// </summary>
    public class ResourcePathNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the resource this node represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ID of the resource this node represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of resource this node represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeType")]
        public virtual string NodeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes Role or ClusterRole.</summary>
    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Role type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Role name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Role namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SecurityBulletin are notifications of vulnerabilities of Google products.</summary>
    public class SecurityBulletin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the bulletin corresponding to the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulletinId")]
        public virtual string BulletinId { get; set; }

        private string _submissionTimeRaw;

        private object _submissionTime;

        /// <summary>Submission time of this Security Bulletin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submissionTime")]
        public virtual string SubmissionTimeRaw
        {
            get => _submissionTimeRaw;
            set
            {
                _submissionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _submissionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SubmissionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SubmissionTimeDateTimeOffset instead.")]
        public virtual object SubmissionTime
        {
            get => _submissionTime;
            set
            {
                _submissionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _submissionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SubmissionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SubmissionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SubmissionTimeRaw);
            set => SubmissionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// This represents a version that the cluster receiving this notification should be upgraded to, based on its
        /// current version. For example, 1.15.0
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestedUpgradeVersion")]
        public virtual string SuggestedUpgradeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for Security Center. Next ID: 12</summary>
    public class SecurityCenterSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the project to send logs to. This project must be part of the organization this
        /// resource resides in. The format is `projects/{project_id}`. An empty value disables logging. This value is
        /// only referenced by services that support log sink. Please refer to the documentation for an updated list of
        /// compatible services. This may only be specified for organization level onboarding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logSinkProject")]
        public virtual string LogSinkProject { get; set; }

        /// <summary>
        /// The resource name of the SecurityCenterSettings. Format: organizations/{organization}/securityCenterSettings
        /// Format: folders/{folder}/securityCenterSettings Format: projects/{project}/securityCenterSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _onboardingTimeRaw;

        private object _onboardingTime;

        /// <summary>Output only. Timestamp of when the customer organization was onboarded to SCC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onboardingTime")]
        public virtual string OnboardingTimeRaw
        {
            get => _onboardingTimeRaw;
            set
            {
                _onboardingTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _onboardingTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="OnboardingTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OnboardingTimeDateTimeOffset instead.")]
        public virtual object OnboardingTime
        {
            get => _onboardingTime;
            set
            {
                _onboardingTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _onboardingTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OnboardingTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OnboardingTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OnboardingTimeRaw);
            set => OnboardingTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The organization level service account to be used for security center components.
        /// </summary>
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
        /// module in the map implies its configuration is inherited from its parent's configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// Identifier. The resource name of the SecurityHealthAnalyticsSettings. Formats: *
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the settings were last updated.</summary>
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

    /// <summary>
    /// Information about the [Google Cloud Armor security
    /// policy](https://cloud.google.com/armor/docs/security-policy-overview) relevant to the finding.
    /// </summary>
    public class SecurityPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the Google Cloud Armor security policy, for example, "my-security-policy".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether or not the associated rule or policy is in preview mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preview")]
        public virtual System.Nullable<bool> Preview { get; set; }

        /// <summary>
        /// The type of Google Cloud Armor security policy for example, 'backend security policy', 'edge security
        /// policy', 'network edge security policy', or 'always-on DDoS protection'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a posture that is deployed on Google Cloud by the Security Command Center Posture Management service.
    /// A posture contains one or more policy sets. A policy set is a group of policies that enforce a set of security
    /// rules on Google Cloud.
    /// </summary>
    public class SecurityPosture : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the updated policy, for example, `projects/{project_id}/policies/{constraint_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changedPolicy")]
        public virtual string ChangedPolicy { get; set; }

        /// <summary>Name of the posture, for example, `CIS-Posture`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID of the updated policy, for example, `compute-policy-1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        /// <summary>The details about a change in an updated policy that violates the deployed posture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyDriftDetails")]
        public virtual System.Collections.Generic.IList<PolicyDriftDetails> PolicyDriftDetails { get; set; }

        /// <summary>The name of the updated policyset, for example, `cis-policyset`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policySet")]
        public virtual string PolicySet { get; set; }

        /// <summary>
        /// The name of the posture deployment, for example,
        /// `organizations/{org_id}/posturedeployments/{posture_deployment_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDeployment")]
        public virtual string PostureDeployment { get; set; }

        /// <summary>
        /// The project, folder, or organization on which the posture is deployed, for example,
        /// `projects/{project_number}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postureDeploymentResource")]
        public virtual string PostureDeploymentResource { get; set; }

        /// <summary>The version of the posture, for example, `c7cfa2a8`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identity delegation history of an authenticated service account.</summary>
    public class ServiceAccountDelegationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of a Google account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string representing the principal_subject associated with the identity. As compared to `principal_email`,
        /// supports principals that aren't associated with email addresses, such as third party principals. For most
        /// identities, the format will be `principal://iam.googleapis.com/{identity pool name}/subjects/{subject}`
        /// except for some GKE identities (GKE_WORKLOAD, FREEFORM, GKE_HUB_WORKLOAD) that are still in the legacy
        /// format `serviceAccount:{identity pool name}[{subject}]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the static mute state. A static mute state overrides any dynamic mute rules that apply to this
    /// finding. The static mute state can be set by a static mute rule or by muting the finding directly.
    /// </summary>
    public class StaticMute : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _applyTimeRaw;

        private object _applyTime;

        /// <summary>When the static mute was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyTime")]
        public virtual string ApplyTimeRaw
        {
            get => _applyTimeRaw;
            set
            {
                _applyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _applyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ApplyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ApplyTimeDateTimeOffset instead.")]
        public virtual object ApplyTime
        {
            get => _applyTime;
            set
            {
                _applyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _applyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ApplyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ApplyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ApplyTimeRaw);
            set => ApplyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The static mute state. If the value is `MUTED` or `UNMUTED`, then the finding's overall mute state will have
        /// the same value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Kubernetes subject.</summary>
    public class Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Authentication type for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

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

    /// <summary>
    /// Information about the ticket, if any, that is being used to track the resolution of the issue that is identified
    /// by this finding.
    /// </summary>
    public class TicketInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The assignee of the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual string Assignee { get; set; }

        /// <summary>The description of the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The identifier of the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The latest status of the ticket, as reported by the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time when the ticket was last updated, as reported by the ticket system.</summary>
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

        /// <summary>The link to the ticket in the ticket system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains details about a group of security issues that, when the issues occur together, represent a greater risk
    /// than when the issues occur independently. A group of such issues is referred to as a toxic combination.
    /// </summary>
    public class ToxicCombination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [Attack exposure
        /// score](https://cloud.google.com/security-command-center/docs/attack-exposure-learn#attack_exposure_scores)
        /// of this toxic combination. The score is a measure of how much this toxic combination exposes one or more
        /// high-value resources to potential attack.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureScore")]
        public virtual System.Nullable<double> AttackExposureScore { get; set; }

        /// <summary>
        /// List of resource names of findings associated with this toxic combination. For example,
        /// `organizations/123/sources/456/findings/789`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Virtual Machine Threat Detection service.</summary>
    public class VirtualMachineThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// Identifier. The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The service account used by Virtual Machine Threat Detection detectors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the settings were last updated.</summary>
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

    /// <summary>Refers to common vulnerability fields e.g. cve, cvss, cwe etc.</summary>
    public class Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CVE stands for Common Vulnerabilities and Exposures (https://cve.mitre.org/about/)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual Cve Cve { get; set; }

        /// <summary>
        /// Represents one or more Common Weakness Enumeration (CWE) information on this vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cwes")]
        public virtual System.Collections.Generic.IList<Cwe> Cwes { get; set; }

        /// <summary>The fixed package is relevant to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedPackage")]
        public virtual Package FixedPackage { get; set; }

        /// <summary>The offending package is relevant to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offendingPackage")]
        public virtual Package OffendingPackage { get; set; }

        /// <summary>
        /// Provider provided risk_score based on multiple factors. The higher the risk score, the more risky the
        /// vulnerability is.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerRiskScore")]
        public virtual System.Nullable<long> ProviderRiskScore { get; set; }

        /// <summary>Represents whether the vulnerability is reachable (detected via static analysis)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reachable")]
        public virtual System.Nullable<bool> Reachable { get; set; }

        /// <summary>The security bulletin is relevant to this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityBulletin")]
        public virtual SecurityBulletin SecurityBulletin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Vulnerability count by severity.</summary>
    public class VulnerabilityCountBySeverity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key is the Severity enum.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityToFindingCount")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> SeverityToFindingCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the properties and count of a VulnerabilitySnapshot request.</summary>
    public class VulnerabilitySnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cloud provider for the vulnerability snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        /// <summary>The vulnerability count by severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingCount")]
        public virtual VulnerabilityCountBySeverity FindingCount { get; set; }

        /// <summary>Identifier. The vulnerability snapshot name. Format: //locations//vulnerabilitySnapshots/</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

        /// <summary>The time that the snapshot was taken.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotTime")]
        public virtual string SnapshotTimeRaw
        {
            get => _snapshotTimeRaw;
            set
            {
                _snapshotTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _snapshotTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SnapshotTimeDateTimeOffset instead.")]
        public virtual object SnapshotTime
        {
            get => _snapshotTime;
            set
            {
                _snapshotTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _snapshotTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SnapshotTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SnapshotTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SnapshotTimeRaw);
            set => SnapshotTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Web Security Scanner service.</summary>
    public class WebSecurityScannerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// Identifier. The resource name of the WebSecurityScannerSettings. Formats: *
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time the settings were last updated.</summary>
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

    /// <summary>A signature corresponding to a YARA rule.</summary>
    public class YaraRuleSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the YARA rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRule")]
        public virtual string YaraRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
