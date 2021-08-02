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

namespace Google.Apis.Baremetalsolution.v1alpha1
{
    /// <summary>The Baremetalsolution Service.</summary>
    public class BaremetalsolutionService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BaremetalsolutionService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BaremetalsolutionService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "baremetalsolution";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://baremetalsolution.googleapis.com/";
        #else
            "https://baremetalsolution.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://baremetalsolution.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Bare Metal Solution API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Bare Metal Solution API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Baremetalsolution requests.</summary>
    public abstract class BaremetalsolutionBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BaremetalsolutionBaseServiceRequest instance.</summary>
        protected BaremetalsolutionBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Baremetalsolution parameter list.</summary>
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
            ProvisioningQuotas = new ProvisioningQuotasResource(service);
            SnapshotSchedulePolicies = new SnapshotSchedulePoliciesResource(service);
            SshKeys = new SshKeysResource(service);
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
                Instances = new InstancesResource(service);
                Luns = new LunsResource(service);
                Volumes = new VolumesResource(service);
            }

            /// <summary>Gets the Instances resource.</summary>
            public virtual InstancesResource Instances { get; }

            /// <summary>The "instances" collection of methods.</summary>
            public class InstancesResource
            {
                private const string Resource = "instances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Disable the interactive serial console feature on a specific machine.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="instance">
                /// Required. Name of the instance to disable the interactive serial console feature on.
                /// </param>
                public virtual DisableInteractiveSerialConsoleRequest DisableInteractiveSerialConsole(Google.Apis.Baremetalsolution.v1alpha1.Data.DisableInteractiveSerialConsoleRequest body, string instance)
                {
                    return new DisableInteractiveSerialConsoleRequest(service, body, instance);
                }

                /// <summary>Disable the interactive serial console feature on a specific machine.</summary>
                public class DisableInteractiveSerialConsoleRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.DisableInteractiveSerialConsoleResponse>
                {
                    /// <summary>Constructs a new DisableInteractiveSerialConsole request.</summary>
                    public DisableInteractiveSerialConsoleRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.DisableInteractiveSerialConsoleRequest body, string instance) : base(service)
                    {
                        Instance = instance;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the instance to disable the interactive serial console feature on.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Instance { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v1alpha1.Data.DisableInteractiveSerialConsoleRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "disableInteractiveSerialConsole";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+instance}:disableInteractiveSerialConsole";

                    /// <summary>Initializes DisableInteractiveSerialConsole parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Enable the interactive serial console feature on a specific machine.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="instance">
                /// Required. Name of the instance to enable the interactive serial console feature on.
                /// </param>
                public virtual EnableInteractiveSerialConsoleRequest EnableInteractiveSerialConsole(Google.Apis.Baremetalsolution.v1alpha1.Data.EnableInteractiveSerialConsoleRequest body, string instance)
                {
                    return new EnableInteractiveSerialConsoleRequest(service, body, instance);
                }

                /// <summary>Enable the interactive serial console feature on a specific machine.</summary>
                public class EnableInteractiveSerialConsoleRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.EnableInteractiveSerialConsoleResponse>
                {
                    /// <summary>Constructs a new EnableInteractiveSerialConsole request.</summary>
                    public EnableInteractiveSerialConsoleRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.EnableInteractiveSerialConsoleRequest body, string instance) : base(service)
                    {
                        Instance = instance;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the instance to enable the interactive serial console feature on.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Instance { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v1alpha1.Data.EnableInteractiveSerialConsoleRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "enableInteractiveSerialConsole";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+instance}:enableInteractiveSerialConsole";

                    /// <summary>Initializes EnableInteractiveSerialConsole parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>Get details for a specific named Instance.</summary>
                /// <param name="name">Required. The name of the Instance to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details for a specific named Instance.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the Instance to retrieve.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }

                /// <summary>List Instances (physical servers).</summary>
                /// <param name="parent">Required. The location to list Instances in.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List Instances (physical servers).</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The location to list Instances in.</summary>
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
                    public override string RestPath => "v1alpha1/{+parent}/instances";

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

                /// <summary>Read the most recent serial port output from a machine.</summary>
                /// <param name="instance">Required. Name of the instance to get serial port output of.</param>
                public virtual ReadSerialPortOutputRequest ReadSerialPortOutput(string instance)
                {
                    return new ReadSerialPortOutputRequest(service, instance);
                }

                /// <summary>Read the most recent serial port output from a machine.</summary>
                public class ReadSerialPortOutputRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.SerialPortOutput>
                {
                    /// <summary>Constructs a new ReadSerialPortOutput request.</summary>
                    public ReadSerialPortOutputRequest(Google.Apis.Services.IClientService service, string instance) : base(service)
                    {
                        Instance = instance;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the instance to get serial port output of.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Instance { get; private set; }

                    /// <summary>Optional. The start byte of the serial port output to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("startByte", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<long> StartByte { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "readSerialPortOutput";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+instance}:readSerialPortOutput";

                    /// <summary>Initializes ReadSerialPortOutput parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                        RequestParameters.Add("startByte", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startByte",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Perform an ungraceful, hard reset on a machine (equivalent to physically turning power off and then
                /// back on).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="instance">Required. Name of the instance to reset.</param>
                public virtual ResetInstanceRequest ResetInstance(Google.Apis.Baremetalsolution.v1alpha1.Data.ResetInstanceRequest body, string instance)
                {
                    return new ResetInstanceRequest(service, body, instance);
                }

                /// <summary>
                /// Perform an ungraceful, hard reset on a machine (equivalent to physically turning power off and then
                /// back on).
                /// </summary>
                public class ResetInstanceRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ResetInstanceResponse>
                {
                    /// <summary>Constructs a new ResetInstance request.</summary>
                    public ResetInstanceRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.ResetInstanceRequest body, string instance) : base(service)
                    {
                        Instance = instance;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the instance to reset.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instance", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Instance { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v1alpha1.Data.ResetInstanceRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resetInstance";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+instance}:resetInstance";

                    /// <summary>Initializes ResetInstance parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("instance", new Google.Apis.Discovery.Parameter
                        {
                            Name = "instance",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Luns resource.</summary>
            public virtual LunsResource Luns { get; }

            /// <summary>The "luns" collection of methods.</summary>
            public class LunsResource
            {
                private const string Resource = "luns";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public LunsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get details for a specific named Lun.</summary>
                /// <param name="name">Required. The name of the Lun to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details for a specific named Lun.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Lun>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the Lun to retrieve.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/luns/[^/]+$",
                        });
                    }
                }

                /// <summary>List Luns.</summary>
                /// <param name="parent">Required. The location to list Luns in.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List Luns.</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListLunsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The location to list Luns in.</summary>
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
                    public override string RestPath => "v1alpha1/{+parent}/luns";

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

            /// <summary>Gets the Volumes resource.</summary>
            public virtual VolumesResource Volumes { get; }

            /// <summary>The "volumes" collection of methods.</summary>
            public class VolumesResource
            {
                private const string Resource = "volumes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VolumesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Snapshots = new SnapshotsResource(service);
                }

                /// <summary>Gets the Snapshots resource.</summary>
                public virtual SnapshotsResource Snapshots { get; }

                /// <summary>The "snapshots" collection of methods.</summary>
                public class SnapshotsResource
                {
                    private const string Resource = "snapshots";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SnapshotsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create snapshot of the specified Volume</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The Volume containing the VolumeSnapshots.</param>
                    public virtual CreateRequest Create(Google.Apis.Baremetalsolution.v1alpha1.Data.VolumeSnapshot body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Create snapshot of the specified Volume</summary>
                    public class CreateRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.VolumeSnapshot>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.VolumeSnapshot body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The Volume containing the VolumeSnapshots.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Baremetalsolution.v1alpha1.Data.VolumeSnapshot Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha1/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Delete specific named snapshot.</summary>
                    /// <param name="name">Required. The name of the snapshot to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Delete specific named snapshot.</summary>
                    public class DeleteRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the snapshot to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Get details for a specific named snapshot.</summary>
                    /// <param name="name">Required. The name of the snapshot to retrieve.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Get details for a specific named snapshot.</summary>
                    public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.VolumeSnapshot>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the snapshot to retrieve.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List the Snapshots for the specified Volume</summary>
                    /// <param name="parent">Required. The Volume containing the VolumeSnapshots.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List the Snapshots for the specified Volume</summary>
                    public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListVolumeSnapshotsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. The Volume containing the VolumeSnapshots.</summary>
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
                        public override string RestPath => "v1alpha1/{+parent}/snapshots";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                    /// <summary>Restore a VolumeSnapshot.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. Name of the VolumeSnapshot to restore.</param>
                    public virtual RestoreRequest Restore(Google.Apis.Baremetalsolution.v1alpha1.Data.RestoreVolumeSnapshotRequest body, string name)
                    {
                        return new RestoreRequest(service, body, name);
                    }

                    /// <summary>Restore a VolumeSnapshot.</summary>
                    public class RestoreRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Empty>
                    {
                        /// <summary>Constructs a new Restore request.</summary>
                        public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.RestoreVolumeSnapshotRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the VolumeSnapshot to restore.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Baremetalsolution.v1alpha1.Data.RestoreVolumeSnapshotRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "restore";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha1/{+name}:restore";

                        /// <summary>Initializes Restore parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+/snapshots/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Get details for a specific named Volume.</summary>
                /// <param name="name">Required. The name of the Volume to retrieve.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get details for a specific named Volume.</summary>
                public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Volume>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the Volume to retrieve.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                        });
                    }
                }

                /// <summary>List the volumes for the specified project</summary>
                /// <param name="parent">Required. The location to list Volumes in.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List the volumes for the specified project</summary>
                public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListVolumesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The location to list Volumes in.</summary>
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
                    public override string RestPath => "v1alpha1/{+parent}/volumes";

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

                /// <summary>Update certain parameters on a Volume.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Output only. The name of this Volume.</param>
                public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v1alpha1.Data.Volume body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Update certain parameters on a Volume.</summary>
                public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Volume>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.Volume body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Output only. The name of this Volume.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The list of fields to update. The only currently supported field is
                    /// `snapshot_reserved_space_percent`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v1alpha1.Data.Volume Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
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

                /// <summary>Sets the specified snapshot schedule policy on the specified volume.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="volume">Required. Name of the volume to set snapshot schedule policy on.</param>
                public virtual SetVolumeSnapshotSchedulePolicyRequest SetVolumeSnapshotSchedulePolicy(Google.Apis.Baremetalsolution.v1alpha1.Data.SetVolumeSnapshotSchedulePolicyRequest body, string volume)
                {
                    return new SetVolumeSnapshotSchedulePolicyRequest(service, body, volume);
                }

                /// <summary>Sets the specified snapshot schedule policy on the specified volume.</summary>
                public class SetVolumeSnapshotSchedulePolicyRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.SetVolumeSnapshotSchedulePolicyResponse>
                {
                    /// <summary>Constructs a new SetVolumeSnapshotSchedulePolicy request.</summary>
                    public SetVolumeSnapshotSchedulePolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.SetVolumeSnapshotSchedulePolicyRequest body, string volume) : base(service)
                    {
                        Volume = volume;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the volume to set snapshot schedule policy on.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("volume", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Volume { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Baremetalsolution.v1alpha1.Data.SetVolumeSnapshotSchedulePolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setVolumeSnapshotSchedulePolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+volume}:setVolumeSnapshotSchedulePolicy";

                    /// <summary>Initializes SetVolumeSnapshotSchedulePolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("volume", new Google.Apis.Discovery.Parameter
                        {
                            Name = "volume",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/volumes/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Submit a provisiong configuration for a given project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">Required. The target project of the provisioning request.</param>
            /// <param name="location">Required. The target location of the provisioning request.</param>
            public virtual SubmitProvisioningConfigRequest SubmitProvisioningConfig(Google.Apis.Baremetalsolution.v1alpha1.Data.SubmitProvisioningConfigRequest body, string project, string location)
            {
                return new SubmitProvisioningConfigRequest(service, body, project, location);
            }

            /// <summary>Submit a provisiong configuration for a given project.</summary>
            public class SubmitProvisioningConfigRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ProvisioningConfig>
            {
                /// <summary>Constructs a new SubmitProvisioningConfig request.</summary>
                public SubmitProvisioningConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.SubmitProvisioningConfigRequest body, string project, string location) : base(service)
                {
                    Project = project;
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The target project of the provisioning request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Required. The target location of the provisioning request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Baremetalsolution.v1alpha1.Data.SubmitProvisioningConfigRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "submitProvisioningConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+project}/{+location}:submitProvisioningConfig";

                /// <summary>Initializes SubmitProvisioningConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                    {
                        Name = "project",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^locations/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the ProvisioningQuotas resource.</summary>
        public virtual ProvisioningQuotasResource ProvisioningQuotas { get; }

        /// <summary>The "provisioningQuotas" collection of methods.</summary>
        public class ProvisioningQuotasResource
        {
            private const string Resource = "provisioningQuotas";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProvisioningQuotasResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>List the budget details to provision resources on a given project.</summary>
            /// <param name="parent">Required. The parent project containing the provisioning quotas.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List the budget details to provision resources on a given project.</summary>
            public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListProvisioningQuotasResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent project containing the provisioning quotas.</summary>
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
                public override string RestPath => "v1alpha1/{+parent}/provisioningQuotas";

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

        /// <summary>Gets the SnapshotSchedulePolicies resource.</summary>
        public virtual SnapshotSchedulePoliciesResource SnapshotSchedulePolicies { get; }

        /// <summary>The "snapshotSchedulePolicies" collection of methods.</summary>
        public class SnapshotSchedulePoliciesResource
        {
            private const string Resource = "snapshotSchedulePolicies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SnapshotSchedulePoliciesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create a SnapshotSchedulePolicy.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The parent project containing the SnapshotSchedulePolicy.</param>
            public virtual CreateRequest Create(Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create a SnapshotSchedulePolicy.</summary>
            public class CreateRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent project containing the SnapshotSchedulePolicy.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/snapshotSchedulePolicies";

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
                }
            }

            /// <summary>Delete removes named snapshot schedule policy</summary>
            /// <param name="name">Required. The name of the snapshot to delete.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Delete removes named snapshot schedule policy</summary>
            public class DeleteRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the snapshot to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^projects/[^/]+/snapshotSchedulePolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Get details for a specific snapshot schedule policy</summary>
            /// <param name="name">Required. The name of the policy to retrieve.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get details for a specific snapshot schedule policy</summary>
            public class GetRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the policy to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^projects/[^/]+/snapshotSchedulePolicies/[^/]+$",
                    });
                }
            }

            /// <summary>List the snapshot schedule policies for the specified project</summary>
            /// <param name="parent">Required. The parent project containing the Snapshot Schedule Policies.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List the snapshot schedule policies for the specified project</summary>
            public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListSnapshotSchedulePoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent project containing the Snapshot Schedule Policies.</summary>
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
                public override string RestPath => "v1alpha1/{+parent}/snapshotSchedulePolicies";

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

            /// <summary>Update a SnapshotSchedulePolicy.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Output only. The name of this SnapshotSchedulePolicy.</param>
            public virtual PatchRequest Patch(Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Update a SnapshotSchedulePolicy.</summary>
            public class PatchRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Output only. The name of this SnapshotSchedulePolicy.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Baremetalsolution.v1alpha1.Data.SnapshotSchedulePolicy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^projects/[^/]+/snapshotSchedulePolicies/[^/]+$",
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

        /// <summary>Gets the SshKeys resource.</summary>
        public virtual SshKeysResource SshKeys { get; }

        /// <summary>The "sshKeys" collection of methods.</summary>
        public class SshKeysResource
        {
            private const string Resource = "sshKeys";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SshKeysResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create a new SSH key registration in the specified project.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The parent project containing the SSH keys.</param>
            public virtual CreateRequest Create(Google.Apis.Baremetalsolution.v1alpha1.Data.SSHKey body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create a new SSH key registration in the specified project.</summary>
            public class CreateRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.SSHKey>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Baremetalsolution.v1alpha1.Data.SSHKey body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent project containing the SSH keys.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. The ID to use for the key, which will become the final component of the key's resource
                /// name. This value should be match the regex: [a-zA-Z0-9@.\-_]{1,64}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sshKeyId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SshKeyId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Baremetalsolution.v1alpha1.Data.SSHKey Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+parent}/sshKeys";

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
                    RequestParameters.Add("sshKeyId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sshKeyId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete an SSH key registration in the specified project.</summary>
            /// <param name="name">Required. The name of the SSH key to delete.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Delete an SSH key registration in the specified project.</summary>
            public class DeleteRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the SSH key to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^projects/[^/]+/sshKeys/[^/]+$",
                    });
                }
            }

            /// <summary>List the public SSH keys registered for the specified project.</summary>
            /// <param name="parent">Required. The parent project containing the SSH keys.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List the public SSH keys registered for the specified project.</summary>
            public class ListRequest : BaremetalsolutionBaseServiceRequest<Google.Apis.Baremetalsolution.v1alpha1.Data.ListSSHKeysResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The parent project containing the SSH keys.</summary>
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
                public override string RestPath => "v1alpha1/{+parent}/sshKeys";

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
namespace Google.Apis.Baremetalsolution.v1alpha1.Data
{
    /// <summary>Request for DisableInteractiveSerialConsole.</summary>
    public class DisableInteractiveSerialConsoleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for DisableInteractiveSerialConsole.</summary>
    public class DisableInteractiveSerialConsoleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Request for EnableInteractiveSerialConsole.</summary>
    public class EnableInteractiveSerialConsoleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for EnableInteractiveSerialConsole.</summary>
    public class EnableInteractiveSerialConsoleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Instance.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Is hyperthreading enabled for this instance?</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreadingEnabled")]
        public virtual System.Nullable<bool> HyperthreadingEnabled { get; set; }

        /// <summary>The Luns attached to this instance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("luns")]
        public virtual System.Collections.Generic.IList<Lun> Luns { get; set; }

        /// <summary>Output only. The name of this Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The scheduled power reset time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledPowerResetTime")]
        public virtual object ScheduledPowerResetTime { get; set; }

        /// <summary>Is SSH enabled for this instance?</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshEnabled")]
        public virtual System.Nullable<bool> SshEnabled { get; set; }

        /// <summary>The state of this Instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new instance.</summary>
    public class InstanceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Client network address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientNetwork")]
        public virtual NetworkAddress ClientNetwork { get; set; }

        /// <summary>Whether the instance should be provisioned with Hyperthreading enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperthreading")]
        public virtual System.Nullable<bool> Hyperthreading { get; set; }

        /// <summary>
        /// A transient unique identifier to idenfity an instance within an ProvisioningConfig request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>Location where to deploy the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>OS image to initialize the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osImage")]
        public virtual string OsImage { get; set; }

        /// <summary>Private network address, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateNetwork")]
        public virtual NetworkAddress PrivateNetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource budget.</summary>
    public class InstanceQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of machines than can be created for the given location and instance_type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableMachineCount")]
        public virtual System.Nullable<int> AvailableMachineCount { get; set; }

        /// <summary>Instance type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceType")]
        public virtual string InstanceType { get; set; }

        /// <summary>Location where the quota applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListInstances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Instances in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListLuns.</summary>
    public class ListLunsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Luns in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("luns")]
        public virtual System.Collections.Generic.IList<Lun> Luns { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListProvisioningQuotas.</summary>
    public class ListProvisioningQuotasResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The provisioning quotas registered in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningQuotas")]
        public virtual System.Collections.Generic.IList<ProvisioningQuota> ProvisioningQuotas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListSSHKeys.</summary>
    public class ListSSHKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The SSH keys registered in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshKeys")]
        public virtual System.Collections.Generic.IList<SSHKey> SshKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListSnapshotSchedulePolicies.</summary>
    public class ListSnapshotSchedulePoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The snapshot schedule policies registered in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotSchedulePolicies")]
        public virtual System.Collections.Generic.IList<SnapshotSchedulePolicy> SnapshotSchedulePolicies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListVolumeSnapshots.</summary>
    public class ListVolumeSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The VolumeSnapshots for the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeSnapshots")]
        public virtual System.Collections.Generic.IList<VolumeSnapshot> VolumeSnapshots { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListVolumes.</summary>
    public class ListVolumesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The volumes registered in this project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A storage Lun.</summary>
    public class Lun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this Lun is a boot Lun.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isBoot")]
        public virtual System.Nullable<bool> IsBoot { get; set; }

        /// <summary>The multiprotocol type of this Lun.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiprotocolType")]
        public virtual string MultiprotocolType { get; set; }

        /// <summary>Output only. The name of this Lun.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The storage volume that this Lun is attached to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteVolume")]
        public virtual Volume RemoteVolume { get; set; }

        /// <summary>Whether this Lun is allowed to be shared between multiple physical servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareable")]
        public virtual System.Nullable<bool> Shareable { get; set; }

        /// <summary>The size of this Lun, in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<long> SizeGb { get; set; }

        /// <summary>The state of this Lun.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A LUN range.</summary>
    public class LunRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of LUNs to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>The requested size of each LUN, in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A network.</summary>
    public class NetworkAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IP address to be assigned to the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Id of the network to use, within the same ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new network.</summary>
    public class NetworkConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Interconnect bandwidth. Set only when type is CLIENT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandwidth")]
        public virtual string Bandwidth { get; set; }

        /// <summary>CIDR range of the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        /// <summary>A transient unique identifier to identify a volume within an ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Location where to deploy the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>Service CIDR, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceCidr")]
        public virtual string ServiceCidr { get; set; }

        /// <summary>The type of this network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// List of VLAN attachments. As of now there are always 2 attachments, but it is going to change in the future
        /// (multi vlan).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vlanAttachments")]
        public virtual System.Collections.Generic.IList<VlanAttachment> VlanAttachments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A NFS export entry.</summary>
    public class NfsExport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allow dev.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowDev")]
        public virtual System.Nullable<bool> AllowDev { get; set; }

        /// <summary>Allow the setuid flag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowSuid")]
        public virtual System.Nullable<bool> AllowSuid { get; set; }

        /// <summary>A CIDR range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cidr")]
        public virtual string Cidr { get; set; }

        /// <summary>A single machine, identified by an ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineId")]
        public virtual string MachineId { get; set; }

        /// <summary>Network to use to publish the export.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkId")]
        public virtual string NetworkId { get; set; }

        /// <summary>Disable root squashing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noRootSquash")]
        public virtual System.Nullable<bool> NoRootSquash { get; set; }

        /// <summary>Export permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual string Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An provisioning configuration.</summary>
    public class ProvisioningConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Instances to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<InstanceConfig> Instances { get; set; }

        /// <summary>Networks to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networks")]
        public virtual System.Collections.Generic.IList<NetworkConfig> Networks { get; set; }

        /// <summary>A reference to track the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketId")]
        public virtual string TicketId { get; set; }

        /// <summary>Volumes to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<VolumeConfig> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A provisioning quota for a given project.</summary>
    public class ProvisioningQuota : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Instance quota.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceQuota")]
        public virtual InstanceQuota InstanceQuota { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for ResetInstance.</summary>
    public class ResetInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ResetInstance.</summary>
    public class ResetInstanceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for RestoreVolumeSnapshot.</summary>
    public class RestoreVolumeSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A public SSH key registered in the project. Used primarily for the interactive serial console feature.
    /// </summary>
    public class SSHKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The name of this SSH key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The public SSH key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual string PublicKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A snapshot schedule.</summary>
    public class Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The crontab-like specification that this Schedule will use to take snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crontabSpec")]
        public virtual string CrontabSpec { get; set; }

        /// <summary>A string to prefix names of snapshots created under this Schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>The maximum number of snapshots to retain under this Schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionCount")]
        public virtual System.Nullable<int> RetentionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ReadSerialPortOutput.</summary>
    public class SerialPortOutput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The serial port output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>The byte index to use in a subsequent call to ReadSerialPortOutput to get more output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextStartByte")]
        public virtual System.Nullable<long> NextStartByte { get; set; }

        /// <summary>The start byte index of the included contents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<long> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for SetVolumeSnapshotSchedulePolicy.</summary>
    public class SetVolumeSnapshotSchedulePolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the policy to set on the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotSchedulePolicy")]
        public virtual string SnapshotSchedulePolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for SetVolumeSnapshotSchedulePolicy.</summary>
    public class SetVolumeSnapshotSchedulePolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A snapshot schedule policy.</summary>
    public class SnapshotSchedulePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of this SnapshotSchedulePolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The name of this SnapshotSchedulePolicy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The snapshot Schedules contained in this Policy. At most 5 Schedules may be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedules")]
        public virtual System.Collections.Generic.IList<Schedule> Schedules { get; set; }

        /// <summary>The names of the Volumes this policy is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<string> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for SubmitProvisioningConfig.</summary>
    public class SubmitProvisioningConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ProvisioningConfig to submit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisioningConfig")]
        public virtual ProvisioningConfig ProvisioningConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A GCP vlan attachment.</summary>
    public class VlanAttachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the VLAN attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Attachment pairing key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pairingKey")]
        public virtual string PairingKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Volume registered in the project.</summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The size, in GB, that this Volume has expanded as a result of an auto grow policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoGrownSizeGb")]
        public virtual System.Nullable<long> AutoGrownSizeGb { get; set; }

        /// <summary>
        /// The current size of this Volume, in GB, including space reserved for snapshots. This size may be different
        /// than the requested size if the Volume has been configured with auto grow or auto shrink.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentSizeGb")]
        public virtual System.Nullable<long> CurrentSizeGb { get; set; }

        /// <summary>Output only. The name of this Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The space remaining in the Volume for new LUNs, in GB, excluding space reserved for snapshots.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingSpaceGb")]
        public virtual System.Nullable<long> RemainingSpaceGb { get; set; }

        /// <summary>The requested size of this Volume, in GB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedSizeGb")]
        public virtual System.Nullable<long> RequestedSizeGb { get; set; }

        /// <summary>The percent of space on this Volume reserved for snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotReservedSpacePercent")]
        public virtual System.Nullable<int> SnapshotReservedSpacePercent { get; set; }

        /// <summary>The amount, in GB, of space available in this Volume's reserved snapshot space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotReservedSpaceRemainingGb")]
        public virtual System.Nullable<long> SnapshotReservedSpaceRemainingGb { get; set; }

        /// <summary>
        /// The percent of reserved snapshot space on this Volume that is actually used by snapshot copies. This may be
        /// higher than 100% if snapshot copies are occupying more space than has been reserved on the Volume.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotReservedSpaceUsedPercent")]
        public virtual System.Nullable<int> SnapshotReservedSpaceUsedPercent { get; set; }

        /// <summary>The state of this Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The type of this Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration parameters for a new volume.</summary>
    public class VolumeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A transient unique identifier to identify a volume within an ProvisioningConfig request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Location where to deploy the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>LUN ranges to be configured. Set only when protocol is PROTOCOL_FC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lunRanges")]
        public virtual System.Collections.Generic.IList<LunRange> LunRanges { get; set; }

        /// <summary>Machine ids connected to this volume. Set only when protocol is PROTOCOL_FC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineIds")]
        public virtual System.Collections.Generic.IList<string> MachineIds { get; set; }

        /// <summary>NFS exports. Set only when protocol is PROTOCOL_NFS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsExports")]
        public virtual System.Collections.Generic.IList<NfsExport> NfsExports { get; set; }

        /// <summary>Volume protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The requested size of this volume, in GB. This will be updated in a later iteration with a generic size
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>Whether snapshots should be enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotsEnabled")]
        public virtual System.Nullable<bool> SnapshotsEnabled { get; set; }

        /// <summary>The type of this Volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VolumeSnapshot registered for given Volume</summary>
    public class VolumeSnapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of this Snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The name of this Snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The real size of this Snapshot, in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The state of this Snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
