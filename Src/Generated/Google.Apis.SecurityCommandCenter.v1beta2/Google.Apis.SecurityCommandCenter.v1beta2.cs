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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetSecurityCenterSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityCenterSettings>
        {
            /// <summary>Constructs a new GetSecurityCenterSettings request.</summary>
            public GetSecurityCenterSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetSecurityCenterSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityCenterSettings>
        {
            /// <summary>Constructs a new GetSecurityCenterSettings request.</summary>
            public GetSecurityCenterSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetSubscriptionRequest GetSubscription(string name)
        {
            return new GetSubscriptionRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetSubscriptionRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.Subscription>
        {
            /// <summary>Constructs a new GetSubscription request.</summary>
            public GetSubscriptionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

                    /// <summary></summary>
                    /// <param name="name"><c>null</c></param>
                    public virtual CalculateRequest Calculate(string name)
                    {
                        return new CalculateRequest(this.service, name);
                    }

                    /// <summary></summary>
                    public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                    {
                        /// <summary>Constructs a new Calculate request.</summary>
                        public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

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

                /// <summary></summary>
                /// <param name="name"><c>null</c></param>
                public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
                {
                    return new GetContainerThreatDetectionSettingsRequest(this.service, name);
                }

                /// <summary></summary>
                public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                {
                    /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
                    public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

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

                /// <summary></summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name"><c>null</c></param>
                public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
                {
                    return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
                }

                /// <summary></summary>
                public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                {
                    /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
                    public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

            /// <summary></summary>
            /// <param name="name"><c>null</c></param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(this.service, name);
            }

            /// <summary></summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetSecurityCenterSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityCenterSettings>
        {
            /// <summary>Constructs a new GetSecurityCenterSettings request.</summary>
            public GetSecurityCenterSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="name"><c>null</c></param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(this.service, name);
        }

        /// <summary></summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name"><c>null</c></param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(this.service, body, name);
        }

        /// <summary></summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

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
    public class Access : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("callerIp")]
        public virtual string CallerIp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("callerIpGeo")]
        public virtual Geolocation CallerIpGeo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountDelegationInfo")]
        public virtual System.Collections.Generic.IList<ServiceAccountDelegationInfo> ServiceAccountDelegationInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyName")]
        public virtual string ServiceAccountKeyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userAgentFamily")]
        public virtual string UserAgentFamily { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AccessReview : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subresource")]
        public virtual string Subresource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdaptiveProtection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<double> Confidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdcApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual GoogleCloudSecuritycenterV1ResourceApplicationAttributes Attributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdcApplicationTemplateRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdcSharedTemplateRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AffectedResources : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AgentDataAccessEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AiModel : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentPlatform")]
        public virtual string DeploymentPlatform { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("library")]
        public virtual string Library { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual string Publisher { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("usageCategory")]
        public virtual string UsageCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Allowed : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("baseUri")]
        public virtual string BaseUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fullUri")]
        public virtual string FullUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ArtifactGuardPolicies : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("failingPolicies")]
        public virtual System.Collections.Generic.IList<ArtifactGuardPolicy> FailingPolicies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ArtifactGuardPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyId")]
        public virtual string PolicyId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Attack : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("classification")]
        public virtual string Classification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumeBps")]
        public virtual System.Nullable<int> VolumeBps { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumeBpsLong")]
        public virtual System.Nullable<long> VolumeBpsLong { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumePps")]
        public virtual System.Nullable<int> VolumePps { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumePpsLong")]
        public virtual System.Nullable<long> VolumePpsLong { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AttackExposure : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureResult")]
        public virtual string AttackExposureResult { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedHighValueResourcesCount")]
        public virtual System.Nullable<int> ExposedHighValueResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedLowValueResourcesCount")]
        public virtual System.Nullable<int> ExposedLowValueResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedMediumValueResourcesCount")]
        public virtual System.Nullable<int> ExposedMediumValueResourcesCount { get; set; }

        private string _latestCalculationTimeRaw;

        private object _latestCalculationTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<double> Score { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AwsAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AwsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual AwsAccount Account { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual AwsOrganization Organization { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("organizationalUnits")]
        public virtual System.Collections.Generic.IList<AwsOrganizationalUnit> OrganizationalUnits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AwsOrganization : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AwsOrganizationalUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AzureManagementGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AzureMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("managementGroups")]
        public virtual System.Collections.Generic.IList<AzureManagementGroup> ManagementGroups { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual AzureResourceGroup ResourceGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual AzureSubscription Subscription { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual AzureTenant Tenant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AzureResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AzureSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AzureTenant : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BackupDisasterRecovery : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("appliance")]
        public virtual string Appliance { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<string> Applications { get; set; }

        private string _backupCreateTimeRaw;

        private object _backupCreateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("backupTemplate")]
        public virtual string BackupTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<string> Policies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyOptions")]
        public virtual System.Collections.Generic.IList<string> PolicyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual string Profile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("storagePool")]
        public virtual string StoragePool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Chokepoint : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudArmor : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveProtection")]
        public virtual AdaptiveProtection AdaptiveProtection { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("attack")]
        public virtual Attack Attack { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual Requests Requests { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityPolicy")]
        public virtual SecurityPolicy SecurityPolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("threatVector")]
        public virtual string ThreatVector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudControl : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudControlName")]
        public virtual string CloudControlName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyType")]
        public virtual string PolicyType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudDlpDataProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataProfile")]
        public virtual string DataProfile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<InfoType> InfoTypes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentType")]
        public virtual string ParentType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudDlpInspection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("fullScan")]
        public virtual System.Nullable<bool> FullScan { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual string InfoType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeCount")]
        public virtual System.Nullable<long> InfoTypeCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("inspectJob")]
        public virtual string InspectJob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CloudLoggingEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
        public virtual string InsertId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("logId")]
        public virtual string LogId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        private string _timestampRaw;

        private object _timestamp;

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

    public class Compliance : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ComplianceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudControl")]
        public virtual CloudControl CloudControl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudControlDeploymentNames")]
        public virtual System.Collections.Generic.IList<string> CloudControlDeploymentNames { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("frameworks")]
        public virtual System.Collections.Generic.IList<Framework> Frameworks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Config : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("moduleEnablementState")]
        public virtual string ModuleEnablementState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ContactDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<Contact> Contacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("imageId")]
        public virtual string ImageId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ContainerThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class Control : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("controlName")]
        public virtual string ControlName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Cve : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cvssv3")]
        public virtual Cvssv3 Cvssv3 { get; set; }

        private string _exploitReleaseDateRaw;

        private object _exploitReleaseDate;

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

        [Newtonsoft.Json.JsonPropertyAttribute("exploitationActivity")]
        public virtual string ExploitationActivity { get; set; }

        private string _firstExploitationDateRaw;

        private object _firstExploitationDate;

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

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impact")]
        public virtual string Impact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("observedInTheWild")]
        public virtual System.Nullable<bool> ObservedInTheWild { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<Reference> References { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("upstreamFixAvailable")]
        public virtual System.Nullable<bool> UpstreamFixAvailable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("zeroDay")]
        public virtual System.Nullable<bool> ZeroDay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Cvssv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<double> BaseScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Cwe : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<Reference> References { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DataAccessEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DataFlowEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("violatedLocation")]
        public virtual string ViolatedLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DataRetentionDeletionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataObjectCount")]
        public virtual System.Nullable<long> DataObjectCount { get; set; }

        private string _eventDetectionTimeRaw;

        private object _eventDetectionTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maxRetentionAllowed")]
        public virtual object MaxRetentionAllowed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("minRetentionAllowed")]
        public virtual object MinRetentionAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("grantees")]
        public virtual System.Collections.Generic.IList<string> Grantees { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Denied : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Details : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Detection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual string Binary { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("percentPagesMatched")]
        public virtual System.Nullable<double> PercentPagesMatched { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DiscoveredWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual string Confidence { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detectedRelevantHardware")]
        public virtual System.Nullable<bool> DetectedRelevantHardware { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detectedRelevantKeywords")]
        public virtual System.Nullable<bool> DetectedRelevantKeywords { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detectedRelevantPackages")]
        public virtual System.Nullable<bool> DetectedRelevantPackages { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("workloadType")]
        public virtual string WorkloadType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DiskPath : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("partitionUuid")]
        public virtual string PartitionUuid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("relativePath")]
        public virtual string RelativePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DynamicMuteRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _matchTimeRaw;

        private object _matchTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("muteConfig")]
        public virtual string MuteConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("val")]
        public virtual string Val { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EventThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class ExfilResource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Exfiltration : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<ExfilResource> Sources { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<ExfilResource> Targets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("totalExfiltratedBytes")]
        public virtual System.Nullable<long> TotalExfiltratedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ExportFindingsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryDestination")]
        public virtual BigQueryDestination BigQueryDestination { get; set; }

        private string _exportStartTimeRaw;

        private object _exportStartTime;

        [Newtonsoft.Json.JsonPropertyAttribute("exportStartTime")]
        public virtual string ExportStartTimeRaw
        {
            get => _exportStartTimeRaw;
            set
            {
                _exportStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _exportStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExportStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExportStartTimeDateTimeOffset instead.")]
        public virtual object ExportStartTime
        {
            get => _exportStartTime;
            set
            {
                _exportStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _exportStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExportStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExportStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExportStartTimeRaw);
            set => ExportStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ExportFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ExternalExposure : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("backendBucket")]
        public virtual string BackendBucket { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("backendService")]
        public virtual string BackendService { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedApplication")]
        public virtual string ExposedApplication { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedEndpoint")]
        public virtual string ExposedEndpoint { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedService")]
        public virtual string ExposedService { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRule")]
        public virtual string ForwardingRule { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hostnameUri")]
        public virtual string HostnameUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("httpResponse")]
        public virtual System.Collections.Generic.IList<HttpResponse> HttpResponse { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("instanceGroup")]
        public virtual string InstanceGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("internalBackendService")]
        public virtual string InternalBackendService { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerFirewallPolicy")]
        public virtual string LoadBalancerFirewallPolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("networkEndpointGroup")]
        public virtual string NetworkEndpointGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("networkIngressFirewallPolicy")]
        public virtual string NetworkIngressFirewallPolicy { get; set; }

        private string _networkPathInsightsGenerationTimeRaw;

        private object _networkPathInsightsGenerationTime;

        [Newtonsoft.Json.JsonPropertyAttribute("networkPathInsightsGenerationTime")]
        public virtual string NetworkPathInsightsGenerationTimeRaw
        {
            get => _networkPathInsightsGenerationTimeRaw;
            set
            {
                _networkPathInsightsGenerationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _networkPathInsightsGenerationTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="NetworkPathInsightsGenerationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NetworkPathInsightsGenerationTimeDateTimeOffset instead.")]
        public virtual object NetworkPathInsightsGenerationTime
        {
            get => _networkPathInsightsGenerationTime;
            set
            {
                _networkPathInsightsGenerationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _networkPathInsightsGenerationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NetworkPathInsightsGenerationTimeRaw"/>
        /// .
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NetworkPathInsightsGenerationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NetworkPathInsightsGenerationTimeRaw);
            set => NetworkPathInsightsGenerationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("privateIpAddress")]
        public virtual string PrivateIpAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privatePort")]
        public virtual string PrivatePort { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pscNetworkAttachment")]
        public virtual string PscNetworkAttachment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pscServiceAttachment")]
        public virtual string PscServiceAttachment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publicIpAddress")]
        public virtual string PublicIpAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publicPort")]
        public virtual string PublicPort { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceFirewallPolicy")]
        public virtual string ServiceFirewallPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("diskPath")]
        public virtual DiskPath DiskPath { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fileLoadState")]
        public virtual string FileLoadState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hashedSize")]
        public virtual System.Nullable<long> HashedSize { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<FileOperation> Operations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partiallyHashed")]
        public virtual System.Nullable<bool> PartiallyHashed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class FileOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual Access Access { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("affectedResources")]
        public virtual AffectedResources AffectedResources { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("agentDataAccessEvents")]
        public virtual System.Collections.Generic.IList<AgentDataAccessEvent> AgentDataAccessEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("aiModel")]
        public virtual AiModel AiModel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual Application Application { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("artifactGuardPolicies")]
        public virtual ArtifactGuardPolicies ArtifactGuardPolicies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("attackExposure")]
        public virtual AttackExposure AttackExposure { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("backupDisasterRecovery")]
        public virtual BackupDisasterRecovery BackupDisasterRecovery { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("chokepoint")]
        public virtual Chokepoint Chokepoint { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudArmor")]
        public virtual CloudArmor CloudArmor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpDataProfile")]
        public virtual CloudDlpDataProfile CloudDlpDataProfile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpInspection")]
        public virtual CloudDlpInspection CloudDlpInspection { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("complianceDetails")]
        public virtual ComplianceDetails ComplianceDetails { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("compliances")]
        public virtual System.Collections.Generic.IList<Compliance> Compliances { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Connection> Connections { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IDictionary<string, ContactDetails> Contacts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("dataAccessEvents")]
        public virtual System.Collections.Generic.IList<DataAccessEvent> DataAccessEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataFlowEvents")]
        public virtual System.Collections.Generic.IList<DataFlowEvent> DataFlowEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionDeletionEvents")]
        public virtual System.Collections.Generic.IList<DataRetentionDeletionEvent> DataRetentionDeletionEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual Database Database { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("discoveredWorkload")]
        public virtual DiscoveredWorkload DiscoveredWorkload { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual Disk Disk { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("exfiltration")]
        public virtual Exfiltration Exfiltration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalExposure")]
        public virtual ExternalExposure ExternalExposure { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalSystems")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV1ExternalSystem> ExternalSystems { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<File> Files { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("findingClass")]
        public virtual string FindingClass { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupMemberships")]
        public virtual System.Collections.Generic.IList<GroupMembership> GroupMemberships { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iamBindings")]
        public virtual System.Collections.Generic.IList<IamBinding> IamBindings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("indicator")]
        public virtual Indicator Indicator { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual IpRules IpRules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual Job Job { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kernelRootkit")]
        public virtual KernelRootkit KernelRootkit { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kubernetes")]
        public virtual Kubernetes Kubernetes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancers")]
        public virtual System.Collections.Generic.IList<LoadBalancer> LoadBalancers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("logEntries")]
        public virtual System.Collections.Generic.IList<LogEntry> LogEntries { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mitreAttack")]
        public virtual MitreAttack MitreAttack { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual string Mute { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("muteInfo")]
        public virtual MuteInfo MuteInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        private string _muteUpdateTimeRaw;

        private object _muteUpdateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<Network> Networks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextSteps")]
        public virtual string NextSteps { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notebook")]
        public virtual Notebook Notebook { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicies")]
        public virtual System.Collections.Generic.IList<OrgPolicy> OrgPolicies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyViolationSummary")]
        public virtual PolicyViolationSummary PolicyViolationSummary { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<Process> Processes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual Secret Secret { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual SecurityMarks SecurityMarks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityPosture")]
        public virtual SecurityPosture SecurityPosture { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("toxicCombination")]
        public virtual ToxicCombination ToxicCombination { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("vertexAi")]
        public virtual VertexAi VertexAi { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual Vulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Framework : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual System.Collections.Generic.IList<string> Category { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("controls")]
        public virtual System.Collections.Generic.IList<Control> Controls { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GcpMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Folder> Folders { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Geolocation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1BigQueryExport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual Role Role { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subjects")]
        public virtual System.Collections.Generic.IList<Subject> Subjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1BulkMuteFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1CustomConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("customOutput")]
        public virtual GoogleCloudSecuritycenterV1CustomOutputSpec CustomOutput { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("predicate")]
        public virtual Expr Predicate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("recommendation")]
        public virtual string Recommendation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceSelector")]
        public virtual GoogleCloudSecuritycenterV1ResourceSelector ResourceSelector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1CustomOutputSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1Property> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1EffectiveSecurityHealthAnalyticsCustomModule : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customConfig")]
        public virtual GoogleCloudSecuritycenterV1CustomConfig CustomConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ExternalSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("assignees")]
        public virtual System.Collections.Generic.IList<string> Assignees { get; set; }

        private string _caseCloseTimeRaw;

        private object _caseCloseTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("casePriority")]
        public virtual string CasePriority { get; set; }

        private string _caseSlaRaw;

        private object _caseSla;

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

        [Newtonsoft.Json.JsonPropertyAttribute("caseUri")]
        public virtual string CaseUri { get; set; }

        private string _externalSystemUpdateTimeRaw;

        private object _externalSystemUpdateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("externalUid")]
        public virtual string ExternalUid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ticketInfo")]
        public virtual TicketInfo TicketInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1MuteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _expiryTimeRaw;

        private object _expiryTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual Finding Finding { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("valueExpression")]
        public virtual Expr ValueExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adcApplication")]
        public virtual AdcApplication AdcApplication { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adcApplicationTemplate")]
        public virtual AdcApplicationTemplateRevision AdcApplicationTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adcSharedTemplate")]
        public virtual AdcSharedTemplateRevision AdcSharedTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual GoogleCloudSecuritycenterV1ResourceApplication Application { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("awsMetadata")]
        public virtual AwsMetadata AwsMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("azureMetadata")]
        public virtual AzureMetadata AzureMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourcePath")]
        public virtual ResourcePath ResourcePath { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourcePathString")]
        public virtual string ResourcePathString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ResourceApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual GoogleCloudSecuritycenterV1ResourceApplicationAttributes Attributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ResourceApplicationAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("businessOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1ResourceApplicationAttributesContactInfo> BusinessOwners { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("criticality")]
        public virtual GoogleCloudSecuritycenterV1ResourceApplicationAttributesCriticality Criticality { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("developerOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1ResourceApplicationAttributesContactInfo> DeveloperOwners { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual GoogleCloudSecuritycenterV1ResourceApplicationAttributesEnvironment Environment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operatorOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1ResourceApplicationAttributesContactInfo> OperatorOwners { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ResourceApplicationAttributesContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ResourceApplicationAttributesCriticality : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ResourceApplicationAttributesEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1ResourceValueConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceLabelsSelector")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceLabelsSelector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceValue")]
        public virtual string ResourceValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveDataProtectionMapping")]
        public virtual GoogleCloudSecuritycenterV1SensitiveDataProtectionMapping SensitiveDataProtectionMapping { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tagValues")]
        public virtual System.Collections.Generic.IList<string> TagValues { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ancestorModule")]
        public virtual string AncestorModule { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("customConfig")]
        public virtual GoogleCloudSecuritycenterV1CustomConfig CustomConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("lastEditor")]
        public virtual string LastEditor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV1SensitiveDataProtectionMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("highSensitivityMapping")]
        public virtual string HighSensitivityMapping { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediumSensitivityMapping")]
        public virtual string MediumSensitivityMapping { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1p1beta1Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual GoogleCloudSecuritycenterV1p1beta1SecurityMarks SecurityMarks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1p1beta1Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1p1beta1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Finding Finding { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1p1beta1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1p1beta1Folder> Folders { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1p1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV1p1beta1SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Access : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("callerIp")]
        public virtual string CallerIp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("callerIpGeo")]
        public virtual GoogleCloudSecuritycenterV2Geolocation CallerIpGeo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountDelegationInfo")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ServiceAccountDelegationInfo> ServiceAccountDelegationInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyName")]
        public virtual string ServiceAccountKeyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userAgentFamily")]
        public virtual string UserAgentFamily { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AccessReview : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subresource")]
        public virtual string Subresource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AdaptiveProtection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<double> Confidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AdcApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual GoogleCloudSecuritycenterV2ResourceApplicationAttributes Attributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AdcApplicationTemplateRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AdcSharedTemplateRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AffectedResources : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AgentDataAccessEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AiModel : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("deploymentPlatform")]
        public virtual string DeploymentPlatform { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("library")]
        public virtual string Library { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual string Publisher { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("usageCategory")]
        public virtual string UsageCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Allowed : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Application : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("baseUri")]
        public virtual string BaseUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fullUri")]
        public virtual string FullUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ArtifactGuardPolicies : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("failingPolicies")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ArtifactGuardPolicy> FailingPolicies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ArtifactGuardPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyId")]
        public virtual string PolicyId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Attack : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("classification")]
        public virtual string Classification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumeBps")]
        public virtual System.Nullable<int> VolumeBps { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumeBpsLong")]
        public virtual System.Nullable<long> VolumeBpsLong { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumePps")]
        public virtual System.Nullable<int> VolumePps { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("volumePpsLong")]
        public virtual System.Nullable<long> VolumePpsLong { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AttackExposure : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureResult")]
        public virtual string AttackExposureResult { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedHighValueResourcesCount")]
        public virtual System.Nullable<int> ExposedHighValueResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedLowValueResourcesCount")]
        public virtual System.Nullable<int> ExposedLowValueResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedMediumValueResourcesCount")]
        public virtual System.Nullable<int> ExposedMediumValueResourcesCount { get; set; }

        private string _latestCalculationTimeRaw;

        private object _latestCalculationTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<double> Score { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AwsAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AwsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleCloudSecuritycenterV2AwsAccount Account { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual GoogleCloudSecuritycenterV2AwsOrganization Organization { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("organizationalUnits")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2AwsOrganizationalUnit> OrganizationalUnits { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AwsOrganization : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AwsOrganizationalUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AzureManagementGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AzureMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("managementGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2AzureManagementGroup> ManagementGroups { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceGroup")]
        public virtual GoogleCloudSecuritycenterV2AzureResourceGroup ResourceGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudSecuritycenterV2AzureSubscription Subscription { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tenant")]
        public virtual GoogleCloudSecuritycenterV2AzureTenant Tenant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AzureResourceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AzureSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2AzureTenant : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2BackupDisasterRecovery : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("appliance")]
        public virtual string Appliance { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<string> Applications { get; set; }

        private string _backupCreateTimeRaw;

        private object _backupCreateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("backupTemplate")]
        public virtual string BackupTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("backupType")]
        public virtual string BackupType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<string> Policies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyOptions")]
        public virtual System.Collections.Generic.IList<string> PolicyOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual string Profile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("storagePool")]
        public virtual string StoragePool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2BigQueryExport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyName")]
        public virtual string CryptoKeyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV2Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual GoogleCloudSecuritycenterV2Role Role { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("subjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Subject> Subjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2BulkMuteFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Chokepoint : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2CloudArmor : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adaptiveProtection")]
        public virtual GoogleCloudSecuritycenterV2AdaptiveProtection AdaptiveProtection { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("attack")]
        public virtual GoogleCloudSecuritycenterV2Attack Attack { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual GoogleCloudSecuritycenterV2Requests Requests { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityPolicy")]
        public virtual GoogleCloudSecuritycenterV2SecurityPolicy SecurityPolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("threatVector")]
        public virtual string ThreatVector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2CloudControl : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudControlName")]
        public virtual string CloudControlName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyType")]
        public virtual string PolicyType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2CloudDlpDataProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataProfile")]
        public virtual string DataProfile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2InfoType> InfoTypes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentType")]
        public virtual string ParentType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2CloudDlpInspection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("fullScan")]
        public virtual System.Nullable<bool> FullScan { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual string InfoType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeCount")]
        public virtual System.Nullable<long> InfoTypeCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("inspectJob")]
        public virtual string InspectJob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2CloudLoggingEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
        public virtual string InsertId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("logId")]
        public virtual string LogId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        private string _timestampRaw;

        private object _timestamp;

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

    public class GoogleCloudSecuritycenterV2Compliance : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ComplianceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudControl")]
        public virtual GoogleCloudSecuritycenterV2CloudControl CloudControl { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudControlDeploymentNames")]
        public virtual System.Collections.Generic.IList<string> CloudControlDeploymentNames { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("frameworks")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Framework> Frameworks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ContactDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Contact> Contacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Container : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("imageId")]
        public virtual string ImageId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Label> Labels { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Control : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("controlName")]
        public virtual string ControlName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Cve : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cvssv3")]
        public virtual GoogleCloudSecuritycenterV2Cvssv3 Cvssv3 { get; set; }

        private string _exploitReleaseDateRaw;

        private object _exploitReleaseDate;

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

        [Newtonsoft.Json.JsonPropertyAttribute("exploitationActivity")]
        public virtual string ExploitationActivity { get; set; }

        private string _firstExploitationDateRaw;

        private object _firstExploitationDate;

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

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("impact")]
        public virtual string Impact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("observedInTheWild")]
        public virtual System.Nullable<bool> ObservedInTheWild { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Reference> References { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("upstreamFixAvailable")]
        public virtual System.Nullable<bool> UpstreamFixAvailable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("zeroDay")]
        public virtual System.Nullable<bool> ZeroDay { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Cvssv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<double> BaseScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Cwe : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Reference> References { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2DataAccessEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2DataFlowEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("violatedLocation")]
        public virtual string ViolatedLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2DataRetentionDeletionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dataObjectCount")]
        public virtual System.Nullable<long> DataObjectCount { get; set; }

        private string _eventDetectionTimeRaw;

        private object _eventDetectionTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maxRetentionAllowed")]
        public virtual object MaxRetentionAllowed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("minRetentionAllowed")]
        public virtual object MinRetentionAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Database : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("grantees")]
        public virtual System.Collections.Generic.IList<string> Grantees { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Denied : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IpRule> IpRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Detection : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual string Binary { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("percentPagesMatched")]
        public virtual System.Nullable<double> PercentPagesMatched { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2DiscoveredWorkload : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual string Confidence { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detectedRelevantHardware")]
        public virtual System.Nullable<bool> DetectedRelevantHardware { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detectedRelevantKeywords")]
        public virtual System.Nullable<bool> DetectedRelevantKeywords { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detectedRelevantPackages")]
        public virtual System.Nullable<bool> DetectedRelevantPackages { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("workloadType")]
        public virtual string WorkloadType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2DiskPath : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("partitionUuid")]
        public virtual string PartitionUuid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("relativePath")]
        public virtual string RelativePath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2DynamicMuteRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _matchTimeRaw;

        private object _matchTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("muteConfig")]
        public virtual string MuteConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2EnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("val")]
        public virtual string Val { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ExfilResource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Exfiltration : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ExfilResource> Sources { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ExfilResource> Targets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("totalExfiltratedBytes")]
        public virtual System.Nullable<long> TotalExfiltratedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ExternalExposure : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("backendBucket")]
        public virtual string BackendBucket { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("backendService")]
        public virtual string BackendService { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedApplication")]
        public virtual string ExposedApplication { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedEndpoint")]
        public virtual string ExposedEndpoint { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedService")]
        public virtual string ExposedService { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("forwardingRule")]
        public virtual string ForwardingRule { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hostnameUri")]
        public virtual string HostnameUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("httpResponse")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2HttpResponse> HttpResponse { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("instanceGroup")]
        public virtual string InstanceGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("internalBackendService")]
        public virtual string InternalBackendService { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerFirewallPolicy")]
        public virtual string LoadBalancerFirewallPolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("networkEndpointGroup")]
        public virtual string NetworkEndpointGroup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("networkIngressFirewallPolicy")]
        public virtual string NetworkIngressFirewallPolicy { get; set; }

        private string _networkPathInsightsGenerationTimeRaw;

        private object _networkPathInsightsGenerationTime;

        [Newtonsoft.Json.JsonPropertyAttribute("networkPathInsightsGenerationTime")]
        public virtual string NetworkPathInsightsGenerationTimeRaw
        {
            get => _networkPathInsightsGenerationTimeRaw;
            set
            {
                _networkPathInsightsGenerationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _networkPathInsightsGenerationTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="NetworkPathInsightsGenerationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NetworkPathInsightsGenerationTimeDateTimeOffset instead.")]
        public virtual object NetworkPathInsightsGenerationTime
        {
            get => _networkPathInsightsGenerationTime;
            set
            {
                _networkPathInsightsGenerationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _networkPathInsightsGenerationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NetworkPathInsightsGenerationTimeRaw"/>
        /// .
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NetworkPathInsightsGenerationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NetworkPathInsightsGenerationTimeRaw);
            set => NetworkPathInsightsGenerationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("privateIpAddress")]
        public virtual string PrivateIpAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("privatePort")]
        public virtual string PrivatePort { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pscNetworkAttachment")]
        public virtual string PscNetworkAttachment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pscServiceAttachment")]
        public virtual string PscServiceAttachment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publicIpAddress")]
        public virtual string PublicIpAddress { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("publicPort")]
        public virtual string PublicPort { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceFirewallPolicy")]
        public virtual string ServiceFirewallPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ExternalSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("assignees")]
        public virtual System.Collections.Generic.IList<string> Assignees { get; set; }

        private string _caseCloseTimeRaw;

        private object _caseCloseTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("casePriority")]
        public virtual string CasePriority { get; set; }

        private string _caseSlaRaw;

        private object _caseSla;

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

        [Newtonsoft.Json.JsonPropertyAttribute("caseUri")]
        public virtual string CaseUri { get; set; }

        private string _externalSystemUpdateTimeRaw;

        private object _externalSystemUpdateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("externalUid")]
        public virtual string ExternalUid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ticketInfo")]
        public virtual GoogleCloudSecuritycenterV2TicketInfo TicketInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2File : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("diskPath")]
        public virtual GoogleCloudSecuritycenterV2DiskPath DiskPath { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fileLoadState")]
        public virtual string FileLoadState { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("hashedSize")]
        public virtual System.Nullable<long> HashedSize { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2FileOperation> Operations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("partiallyHashed")]
        public virtual System.Nullable<bool> PartiallyHashed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2FileOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual GoogleCloudSecuritycenterV2Access Access { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("affectedResources")]
        public virtual GoogleCloudSecuritycenterV2AffectedResources AffectedResources { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("agentDataAccessEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2AgentDataAccessEvent> AgentDataAccessEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("aiModel")]
        public virtual GoogleCloudSecuritycenterV2AiModel AiModel { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual GoogleCloudSecuritycenterV2Application Application { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("artifactGuardPolicies")]
        public virtual GoogleCloudSecuritycenterV2ArtifactGuardPolicies ArtifactGuardPolicies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("attackExposure")]
        public virtual GoogleCloudSecuritycenterV2AttackExposure AttackExposure { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("backupDisasterRecovery")]
        public virtual GoogleCloudSecuritycenterV2BackupDisasterRecovery BackupDisasterRecovery { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("chokepoint")]
        public virtual GoogleCloudSecuritycenterV2Chokepoint Chokepoint { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudArmor")]
        public virtual GoogleCloudSecuritycenterV2CloudArmor CloudArmor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpDataProfile")]
        public virtual GoogleCloudSecuritycenterV2CloudDlpDataProfile CloudDlpDataProfile { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpInspection")]
        public virtual GoogleCloudSecuritycenterV2CloudDlpInspection CloudDlpInspection { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("complianceDetails")]
        public virtual GoogleCloudSecuritycenterV2ComplianceDetails ComplianceDetails { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("compliances")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Compliance> Compliances { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Connection> Connections { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV2ContactDetails> Contacts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Container> Containers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyName")]
        public virtual string CryptoKeyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataAccessEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DataAccessEvent> DataAccessEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataFlowEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DataFlowEvent> DataFlowEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataRetentionDeletionEvents")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DataRetentionDeletionEvent> DataRetentionDeletionEvents { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual GoogleCloudSecuritycenterV2Database Database { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("discoveredWorkload")]
        public virtual GoogleCloudSecuritycenterV2DiscoveredWorkload DiscoveredWorkload { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual GoogleCloudSecuritycenterV2Disk Disk { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("exfiltration")]
        public virtual GoogleCloudSecuritycenterV2Exfiltration Exfiltration { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalExposure")]
        public virtual GoogleCloudSecuritycenterV2ExternalExposure ExternalExposure { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalSystems")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV2ExternalSystem> ExternalSystems { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2File> Files { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("findingClass")]
        public virtual string FindingClass { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupMemberships")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2GroupMembership> GroupMemberships { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iamBindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IamBinding> IamBindings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("indicator")]
        public virtual GoogleCloudSecuritycenterV2Indicator Indicator { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ipRules")]
        public virtual GoogleCloudSecuritycenterV2IpRules IpRules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("job")]
        public virtual GoogleCloudSecuritycenterV2Job Job { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kernelRootkit")]
        public virtual GoogleCloudSecuritycenterV2KernelRootkit KernelRootkit { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kubernetes")]
        public virtual GoogleCloudSecuritycenterV2Kubernetes Kubernetes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2LoadBalancer> LoadBalancers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("logEntries")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2LogEntry> LogEntries { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mitreAttack")]
        public virtual GoogleCloudSecuritycenterV2MitreAttack MitreAttack { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual string Mute { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("muteInfo")]
        public virtual GoogleCloudSecuritycenterV2MuteInfo MuteInfo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        private string _muteUpdateTimeRaw;

        private object _muteUpdateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Network> Networks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextSteps")]
        public virtual string NextSteps { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notebook")]
        public virtual GoogleCloudSecuritycenterV2Notebook Notebook { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicies")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2OrgPolicy> OrgPolicies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyViolationSummary")]
        public virtual GoogleCloudSecuritycenterV2PolicyViolationSummary PolicyViolationSummary { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Process> Processes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual GoogleCloudSecuritycenterV2Secret Secret { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual GoogleCloudSecuritycenterV2SecurityMarks SecurityMarks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityPosture")]
        public virtual GoogleCloudSecuritycenterV2SecurityPosture SecurityPosture { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("toxicCombination")]
        public virtual GoogleCloudSecuritycenterV2ToxicCombination ToxicCombination { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("vertexAi")]
        public virtual GoogleCloudSecuritycenterV2VertexAi VertexAi { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual GoogleCloudSecuritycenterV2Vulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Framework : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual System.Collections.Generic.IList<string> Category { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("controls")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Control> Controls { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Geolocation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2GroupMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2HttpResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("statusCode")]
        public virtual string StatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IamBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Indicator : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ProcessSignature> Signatures { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2InfoType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sensitivityScore")]
        public virtual GoogleCloudSecuritycenterV2SensitivityScore SensitivityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IpRule : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("portRanges")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2PortRange> PortRanges { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IpRules : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("allowed")]
        public virtual GoogleCloudSecuritycenterV2Allowed Allowed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("denied")]
        public virtual GoogleCloudSecuritycenterV2Denied Denied { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinationIpRanges")]
        public virtual System.Collections.Generic.IList<string> DestinationIpRanges { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedServices")]
        public virtual System.Collections.Generic.IList<string> ExposedServices { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourceIpRanges")]
        public virtual System.Collections.Generic.IList<string> SourceIpRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detection")]
        public virtual string Detection { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueDomain> Domains { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposureScore")]
        public virtual System.Nullable<double> ExposureScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("issueType")]
        public virtual string IssueType { get; set; }

        private string _lastObservationTimeRaw;

        private object _lastObservationTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual GoogleCloudSecuritycenterV2IssueMute Mute { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryResource")]
        public virtual GoogleCloudSecuritycenterV2IssueResource PrimaryResource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueFinding> RelatedFindings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("remediations")]
        public virtual System.Collections.Generic.IList<string> Remediations { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("secondaryResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueResource> SecondaryResources { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueSecurityContext> SecurityContexts { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV2IssueDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("domainCategory")]
        public virtual string DomainCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual GoogleCloudSecuritycenterV2IssueFindingCve Cve { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityBulletin")]
        public virtual GoogleCloudSecuritycenterV2IssueFindingSecurityBulletin SecurityBulletin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueFindingCve : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueFindingSecurityBulletin : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueMute : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("muteReason")]
        public virtual string MuteReason { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("muteState")]
        public virtual string MuteState { get; set; }

        private string _muteUpdateTimeRaw;

        private object _muteUpdateTime;

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

    public class GoogleCloudSecuritycenterV2IssueResource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adcApplication")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAdcApplication AdcApplication { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adcApplicationTemplate")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAdcApplicationTemplateRevision AdcApplicationTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adcSharedTemplate")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAdcSharedTemplateRevision AdcSharedTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceApplication Application { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("awsMetadata")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAwsMetadata AwsMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("azureMetadata")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAzureMetadata AzureMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("googleCloudMetadata")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceGoogleCloudMetadata GoogleCloudMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceAdcApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceApplicationAttributes Attributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceAdcApplicationTemplateRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceAdcSharedTemplateRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceApplicationAttributes Attributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceApplicationAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("businessOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesContactInfo> BusinessOwners { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("criticality")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesCriticality Criticality { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("developerOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesContactInfo> DeveloperOwners { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesEnvironment Environment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operatorOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesContactInfo> OperatorOwners { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesCriticality : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceApplicationAttributesEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceAwsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAwsMetadataAwsAccount Account { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceAwsMetadataAwsAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceAzureMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual GoogleCloudSecuritycenterV2IssueResourceAzureMetadataAzureSubscription Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceAzureMetadataAzureSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueResourceGoogleCloudMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueSecurityContext : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("aggregatedCount")]
        public virtual GoogleCloudSecuritycenterV2IssueSecurityContextAggregatedCount AggregatedCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GoogleCloudSecuritycenterV2IssueSecurityContextContext Context { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueSecurityContextAggregatedCount : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<int> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2IssueSecurityContextContext : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Job : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual System.Nullable<int> ErrorCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2KernelRootkit : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedCodeModification")]
        public virtual System.Nullable<bool> UnexpectedCodeModification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedFtraceHandler")]
        public virtual System.Nullable<bool> UnexpectedFtraceHandler { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedInterruptHandler")]
        public virtual System.Nullable<bool> UnexpectedInterruptHandler { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKernelCodePages")]
        public virtual System.Nullable<bool> UnexpectedKernelCodePages { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKprobeHandler")]
        public virtual System.Nullable<bool> UnexpectedKprobeHandler { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedProcessesInRunqueue")]
        public virtual System.Nullable<bool> UnexpectedProcessesInRunqueue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedReadOnlyDataModification")]
        public virtual System.Nullable<bool> UnexpectedReadOnlyDataModification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedSystemCallHandler")]
        public virtual System.Nullable<bool> UnexpectedSystemCallHandler { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Kubernetes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accessReviews")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2AccessReview> AccessReviews { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Binding> Bindings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2NodePool> NodePools { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Node> Nodes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Object> Objects { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pods")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Pod> Pods { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Label : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2LoadBalancer : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudLoggingEntry")]
        public virtual GoogleCloudSecuritycenterV2CloudLoggingEntry CloudLoggingEntry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2MemoryHashSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("binaryFamily")]
        public virtual string BinaryFamily { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Detection> Detections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2MitreAttack : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTactics")]
        public virtual System.Collections.Generic.IList<string> AdditionalTactics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("additionalTechniques")]
        public virtual System.Collections.Generic.IList<string> AdditionalTechniques { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryTactic")]
        public virtual string PrimaryTactic { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryTechniques")]
        public virtual System.Collections.Generic.IList<string> PrimaryTechniques { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2MuteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyName")]
        public virtual string CryptoKeyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _expiryTimeRaw;

        private object _expiryTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV2MuteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicMuteRecords")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2DynamicMuteRecord> DynamicMuteRecords { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("staticMute")]
        public virtual GoogleCloudSecuritycenterV2StaticMute StaticMute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Network : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Node : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2NodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Node> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Notebook : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("lastAuthor")]
        public virtual string LastAuthor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _notebookUpdateTimeRaw;

        private object _notebookUpdateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual GoogleCloudSecuritycenterV2Finding Finding { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV2Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Object : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Container> Containers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2OrgPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Package : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("packageVersion")]
        public virtual string PackageVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Pipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Pod : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Container> Containers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Label> Labels { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2PolicyDriftDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("detectedValue")]
        public virtual string DetectedValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("expectedValue")]
        public virtual string ExpectedValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2PolicyViolationSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("conformantResourcesCount")]
        public virtual System.Nullable<long> ConformantResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("evaluationErrorsCount")]
        public virtual System.Nullable<long> EvaluationErrorsCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("outOfScopeResourcesCount")]
        public virtual System.Nullable<long> OutOfScopeResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyViolationsCount")]
        public virtual System.Nullable<long> PolicyViolationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2PortRange : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<long> Max { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<long> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Process : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("argumentsTruncated")]
        public virtual System.Nullable<bool> ArgumentsTruncated { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual GoogleCloudSecuritycenterV2File Binary { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2EnvironmentVariable> EnvVariables { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("envVariablesTruncated")]
        public virtual System.Nullable<bool> EnvVariablesTruncated { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("libraries")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2File> Libraries { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentPid")]
        public virtual System.Nullable<long> ParentPid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual GoogleCloudSecuritycenterV2File Script { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual System.Nullable<long> UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ProcessSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("memoryHashSignature")]
        public virtual GoogleCloudSecuritycenterV2MemoryHashSignature MemoryHashSignature { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signatureType")]
        public virtual string SignatureType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("yaraRuleSignature")]
        public virtual GoogleCloudSecuritycenterV2YaraRuleSignature YaraRuleSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Reference : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Requests : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("longTermAllowed")]
        public virtual System.Nullable<int> LongTermAllowed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("longTermDenied")]
        public virtual System.Nullable<int> LongTermDenied { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ratio")]
        public virtual System.Nullable<double> Ratio { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("shortTermAllowed")]
        public virtual System.Nullable<int> ShortTermAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("adcApplication")]
        public virtual GoogleCloudSecuritycenterV2AdcApplication AdcApplication { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adcApplicationTemplate")]
        public virtual GoogleCloudSecuritycenterV2AdcApplicationTemplateRevision AdcApplicationTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("adcSharedTemplate")]
        public virtual GoogleCloudSecuritycenterV2AdcSharedTemplateRevision AdcSharedTemplate { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual GoogleCloudSecuritycenterV2ResourceApplication Application { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("awsMetadata")]
        public virtual GoogleCloudSecuritycenterV2AwsMetadata AwsMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("azureMetadata")]
        public virtual GoogleCloudSecuritycenterV2AzureMetadata AzureMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("gcpMetadata")]
        public virtual GcpMetadata GcpMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourcePath")]
        public virtual GoogleCloudSecuritycenterV2ResourcePath ResourcePath { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourcePathString")]
        public virtual string ResourcePathString { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourceApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual GoogleCloudSecuritycenterV2ResourceApplicationAttributes Attributes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourceApplicationAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("businessOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ResourceApplicationAttributesContactInfo> BusinessOwners { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("criticality")]
        public virtual GoogleCloudSecuritycenterV2ResourceApplicationAttributesCriticality Criticality { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("developerOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ResourceApplicationAttributesContactInfo> DeveloperOwners { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual GoogleCloudSecuritycenterV2ResourceApplicationAttributesEnvironment Environment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("operatorOwners")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ResourceApplicationAttributesContactInfo> OperatorOwners { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourceApplicationAttributesContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourceApplicationAttributesCriticality : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourceApplicationAttributesEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourcePath : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2ResourcePathNode> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourcePathNode : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodeType")]
        public virtual string NodeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ResourceValueConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        private string _createTimeRaw;

        private object _createTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceLabelsSelector")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceLabelsSelector { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("resourceValue")]
        public virtual string ResourceValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveDataProtectionMapping")]
        public virtual GoogleCloudSecuritycenterV2SensitiveDataProtectionMapping SensitiveDataProtectionMapping { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tagValues")]
        public virtual System.Collections.Generic.IList<string> TagValues { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class GoogleCloudSecuritycenterV2Role : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariable")]
        public virtual GoogleCloudSecuritycenterV2SecretEnvironmentVariable EnvironmentVariable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual GoogleCloudSecuritycenterV2SecretFilePath FilePath { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleCloudSecuritycenterV2SecretStatus Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SecretEnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SecretFilePath : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SecretStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastUpdatedTimeRaw;

        private object _lastUpdatedTime;

        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTime")]
        public virtual string LastUpdatedTimeRaw
        {
            get => _lastUpdatedTimeRaw;
            set
            {
                _lastUpdatedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdatedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdatedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdatedTimeDateTimeOffset instead.")]
        public virtual object LastUpdatedTime
        {
            get => _lastUpdatedTime;
            set
            {
                _lastUpdatedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdatedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdatedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdatedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdatedTimeRaw);
            set => LastUpdatedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("validity")]
        public virtual string Validity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SecurityBulletin : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("bulletinId")]
        public virtual string BulletinId { get; set; }

        private string _submissionTimeRaw;

        private object _submissionTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("suggestedUpgradeVersion")]
        public virtual string SuggestedUpgradeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SecurityPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("preview")]
        public virtual System.Nullable<bool> Preview { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SecurityPosture : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("changedPolicy")]
        public virtual string ChangedPolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyDriftDetails")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2PolicyDriftDetails> PolicyDriftDetails { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policySet")]
        public virtual string PolicySet { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("postureDeployment")]
        public virtual string PostureDeployment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("postureDeploymentResource")]
        public virtual string PostureDeploymentResource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SensitiveDataProtectionMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("highSensitivityMapping")]
        public virtual string HighSensitivityMapping { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("mediumSensitivityMapping")]
        public virtual string MediumSensitivityMapping { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2SensitivityScore : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual string Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ServiceAccountDelegationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2StaticMute : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _applyTimeRaw;

        private object _applyTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2TicketInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual string Assignee { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2ToxicCombination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureScore")]
        public virtual System.Nullable<double> AttackExposureScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2VertexAi : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("datasets")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Dataset> Datasets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pipelines")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Pipeline> Pipelines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual GoogleCloudSecuritycenterV2Cve Cve { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cwes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV2Cwe> Cwes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fixedPackage")]
        public virtual GoogleCloudSecuritycenterV2Package FixedPackage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("offendingPackage")]
        public virtual GoogleCloudSecuritycenterV2Package OffendingPackage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("providerRiskScore")]
        public virtual System.Nullable<long> ProviderRiskScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("reachable")]
        public virtual System.Nullable<bool> Reachable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityBulletin")]
        public virtual GoogleCloudSecuritycenterV2SecurityBulletin SecurityBulletin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudSecuritycenterV2YaraRuleSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRule")]
        public virtual string YaraRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GroupMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("groupId")]
        public virtual string GroupId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class HttpResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("statusCode")]
        public virtual string StatusCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IamBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Indicator : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<ProcessSignature> Signatures { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InfoType : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sensitivityScore")]
        public virtual SensitivityScore SensitivityScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IpRule : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("portRanges")]
        public virtual System.Collections.Generic.IList<PortRange> PortRanges { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class IpRules : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("allowed")]
        public virtual Allowed Allowed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("denied")]
        public virtual Denied Denied { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("destinationIpRanges")]
        public virtual System.Collections.Generic.IList<string> DestinationIpRanges { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("direction")]
        public virtual string Direction { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exposedServices")]
        public virtual System.Collections.Generic.IList<string> ExposedServices { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sourceIpRanges")]
        public virtual System.Collections.Generic.IList<string> SourceIpRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual System.Nullable<int> ErrorCode { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class KernelRootkit : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedCodeModification")]
        public virtual System.Nullable<bool> UnexpectedCodeModification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedFtraceHandler")]
        public virtual System.Nullable<bool> UnexpectedFtraceHandler { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedInterruptHandler")]
        public virtual System.Nullable<bool> UnexpectedInterruptHandler { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKernelCodePages")]
        public virtual System.Nullable<bool> UnexpectedKernelCodePages { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKprobeHandler")]
        public virtual System.Nullable<bool> UnexpectedKprobeHandler { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedProcessesInRunqueue")]
        public virtual System.Nullable<bool> UnexpectedProcessesInRunqueue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedReadOnlyDataModification")]
        public virtual System.Nullable<bool> UnexpectedReadOnlyDataModification { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedSystemCallHandler")]
        public virtual System.Nullable<bool> UnexpectedSystemCallHandler { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Kubernetes : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("accessReviews")]
        public virtual System.Collections.Generic.IList<AccessReview> AccessReviews { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1Binding> Bindings { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<NodePool> NodePools { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("objects")]
        public virtual System.Collections.Generic.IList<Object> Objects { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pods")]
        public virtual System.Collections.Generic.IList<Pod> Pods { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LoadBalancer : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudLoggingEntry")]
        public virtual CloudLoggingEntry CloudLoggingEntry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MemoryHashSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("binaryFamily")]
        public virtual string BinaryFamily { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<Detection> Detections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MitreAttack : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTactics")]
        public virtual System.Collections.Generic.IList<string> AdditionalTactics { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("additionalTechniques")]
        public virtual System.Collections.Generic.IList<string> AdditionalTechniques { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryTactic")]
        public virtual string PrimaryTactic { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryTechniques")]
        public virtual System.Collections.Generic.IList<string> PrimaryTechniques { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class MuteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicMuteRecords")]
        public virtual System.Collections.Generic.IList<DynamicMuteRecord> DynamicMuteRecords { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("staticMute")]
        public virtual StaticMute StaticMute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Network : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Node : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class NodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Notebook : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("lastAuthor")]
        public virtual string LastAuthor { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _notebookUpdateTimeRaw;

        private object _notebookUpdateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Object : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class OrgPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Package : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cpeUri")]
        public virtual string CpeUri { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("packageType")]
        public virtual string PackageType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("packageVersion")]
        public virtual string PackageVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Pipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Pod : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyDriftDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("detectedValue")]
        public virtual string DetectedValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("expectedValue")]
        public virtual string ExpectedValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual string Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyViolationSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("conformantResourcesCount")]
        public virtual System.Nullable<long> ConformantResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("evaluationErrorsCount")]
        public virtual System.Nullable<long> EvaluationErrorsCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("outOfScopeResourcesCount")]
        public virtual System.Nullable<long> OutOfScopeResourcesCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyViolationsCount")]
        public virtual System.Nullable<long> PolicyViolationsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PortRange : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual System.Nullable<long> Max { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<long> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Process : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("argumentsTruncated")]
        public virtual System.Nullable<bool> ArgumentsTruncated { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual File Binary { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IList<EnvironmentVariable> EnvVariables { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("envVariablesTruncated")]
        public virtual System.Nullable<bool> EnvVariablesTruncated { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("libraries")]
        public virtual System.Collections.Generic.IList<File> Libraries { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("parentPid")]
        public virtual System.Nullable<long> ParentPid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual File Script { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual System.Nullable<long> UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ProcessSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("memoryHashSignature")]
        public virtual MemoryHashSignature MemoryHashSignature { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("signatureType")]
        public virtual string SignatureType { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("yaraRuleSignature")]
        public virtual YaraRuleSignature YaraRuleSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class RapidVulnerabilityDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class Reference : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Requests : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("longTermAllowed")]
        public virtual System.Nullable<int> LongTermAllowed { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("longTermDenied")]
        public virtual System.Nullable<int> LongTermDenied { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ratio")]
        public virtual System.Nullable<double> Ratio { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("shortTermAllowed")]
        public virtual System.Nullable<int> ShortTermAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResourcePath : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<ResourcePathNode> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ResourcePathNode : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nodeType")]
        public virtual string NodeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("environmentVariable")]
        public virtual SecretEnvironmentVariable EnvironmentVariable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("filePath")]
        public virtual SecretFilePath FilePath { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual SecretStatus Status { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecretEnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecretFilePath : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecretStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastUpdatedTimeRaw;

        private object _lastUpdatedTime;

        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedTime")]
        public virtual string LastUpdatedTimeRaw
        {
            get => _lastUpdatedTimeRaw;
            set
            {
                _lastUpdatedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdatedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdatedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdatedTimeDateTimeOffset instead.")]
        public virtual object LastUpdatedTime
        {
            get => _lastUpdatedTime;
            set
            {
                _lastUpdatedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdatedTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdatedTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdatedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdatedTimeRaw);
            set => LastUpdatedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        [Newtonsoft.Json.JsonPropertyAttribute("validity")]
        public virtual string Validity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecurityBulletin : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("bulletinId")]
        public virtual string BulletinId { get; set; }

        private string _submissionTimeRaw;

        private object _submissionTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("suggestedUpgradeVersion")]
        public virtual string SuggestedUpgradeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecurityCenterSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyName")]
        public virtual string CryptoKeyName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("logSinkProject")]
        public virtual string LogSinkProject { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _onboardingTimeRaw;

        private object _onboardingTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("orgServiceAccount")]
        public virtual string OrgServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecurityHealthAnalyticsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecurityPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("preview")]
        public virtual System.Nullable<bool> Preview { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SecurityPosture : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("changedPolicy")]
        public virtual string ChangedPolicy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual string Policy { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policyDriftDetails")]
        public virtual System.Collections.Generic.IList<PolicyDriftDetails> PolicyDriftDetails { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("policySet")]
        public virtual string PolicySet { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("postureDeployment")]
        public virtual string PostureDeployment { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("postureDeploymentResource")]
        public virtual string PostureDeploymentResource { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SensitivityScore : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual string Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ServiceAccountDelegationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class StaticMute : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _applyTimeRaw;

        private object _applyTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual Details Details { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TicketInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual string Assignee { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ToxicCombination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("attackExposureScore")]
        public virtual System.Nullable<double> AttackExposureScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("relatedFindings")]
        public virtual System.Collections.Generic.IList<string> RelatedFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VertexAi : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("datasets")]
        public virtual System.Collections.Generic.IList<Dataset> Datasets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pipelines")]
        public virtual System.Collections.Generic.IList<Pipeline> Pipelines { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VirtualMachineThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual Cve Cve { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("cwes")]
        public virtual System.Collections.Generic.IList<Cwe> Cwes { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("fixedPackage")]
        public virtual Package FixedPackage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("offendingPackage")]
        public virtual Package OffendingPackage { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("providerRiskScore")]
        public virtual System.Nullable<long> ProviderRiskScore { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("reachable")]
        public virtual System.Nullable<bool> Reachable { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("securityBulletin")]
        public virtual SecurityBulletin SecurityBulletin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VulnerabilityCountBySeverity : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("severityToFindingCount")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> SeverityToFindingCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class VulnerabilitySnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProvider")]
        public virtual string CloudProvider { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("findingCount")]
        public virtual VulnerabilityCountBySeverity FindingCount { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _snapshotTimeRaw;

        private object _snapshotTime;

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

    public class WebSecurityScannerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

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

    public class YaraRuleSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRule")]
        public virtual string YaraRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
