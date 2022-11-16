// Copyright 2022 Google LLC
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

namespace Google.Apis.CloudDomains.v1
{
    /// <summary>The CloudDomains Service.</summary>
    public class CloudDomainsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudDomainsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudDomainsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "domains";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://domains.googleapis.com/";
        #else
            "https://domains.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://domains.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Domains API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Domains API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudDomains requests.</summary>
    public abstract class CloudDomainsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudDomainsBaseServiceRequest instance.</summary>
        protected CloudDomainsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudDomains parameter list.</summary>
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
                Operations = new OperationsResource(service);
                Registrations = new RegistrationsResource(service);
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
                public class GetRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
                /// binding to use different resource name schemes, such as `users/*/operations`. To override the
                /// binding, API services can add a binding such as `"/v1/{name=users/*}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.
                /// </summary>
                public class ListRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1/{+name}/operations";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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

            /// <summary>Gets the Registrations resource.</summary>
            public virtual RegistrationsResource Registrations { get; }

            /// <summary>The "registrations" collection of methods.</summary>
            public class RegistrationsResource
            {
                private const string Resource = "registrations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RegistrationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Updates a `Registration`'s contact settings. Some changes require confirmation by the domain's
                /// registrant contact .
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose contact settings are being updated, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ConfigureContactSettingsRequest ConfigureContactSettings(Google.Apis.CloudDomains.v1.Data.ConfigureContactSettingsRequest body, string registration)
                {
                    return new ConfigureContactSettingsRequest(service, body, registration);
                }

                /// <summary>
                /// Updates a `Registration`'s contact settings. Some changes require confirmation by the domain's
                /// registrant contact .
                /// </summary>
                public class ConfigureContactSettingsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ConfigureContactSettings request.</summary>
                    public ConfigureContactSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.ConfigureContactSettingsRequest body, string registration) : base(service)
                    {
                        Registration = registration;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whose contact settings are being updated, in the format
                    /// `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.ConfigureContactSettingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "configureContactSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+registration}:configureContactSettings";

                    /// <summary>Initializes ConfigureContactSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("registration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "registration",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates a `Registration`'s DNS settings.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose DNS settings are being updated, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ConfigureDnsSettingsRequest ConfigureDnsSettings(Google.Apis.CloudDomains.v1.Data.ConfigureDnsSettingsRequest body, string registration)
                {
                    return new ConfigureDnsSettingsRequest(service, body, registration);
                }

                /// <summary>Updates a `Registration`'s DNS settings.</summary>
                public class ConfigureDnsSettingsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ConfigureDnsSettings request.</summary>
                    public ConfigureDnsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.ConfigureDnsSettingsRequest body, string registration) : base(service)
                    {
                        Registration = registration;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whose DNS settings are being updated, in the format
                    /// `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.ConfigureDnsSettingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "configureDnsSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+registration}:configureDnsSettings";

                    /// <summary>Initializes ConfigureDnsSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("registration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "registration",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates a `Registration`'s management settings.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose management settings are being updated, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ConfigureManagementSettingsRequest ConfigureManagementSettings(Google.Apis.CloudDomains.v1.Data.ConfigureManagementSettingsRequest body, string registration)
                {
                    return new ConfigureManagementSettingsRequest(service, body, registration);
                }

                /// <summary>Updates a `Registration`'s management settings.</summary>
                public class ConfigureManagementSettingsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new ConfigureManagementSettings request.</summary>
                    public ConfigureManagementSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.ConfigureManagementSettingsRequest body, string registration) : base(service)
                    {
                        Registration = registration;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whose management settings are being updated, in the
                    /// format `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.ConfigureManagementSettingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "configureManagementSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+registration}:configureManagementSettings";

                    /// <summary>Initializes ConfigureManagementSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("registration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "registration",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a `Registration` resource. This method works on any `Registration` resource using
                /// [Subscription or Commitment billing](/domains/pricing#billing-models), provided that the resource
                /// was created at least 1 day in the past. For `Registration` resources using [Monthly
                /// billing](/domains/pricing#billing-models), this method works if: * `state` is `EXPORTED` with
                /// `expire_time` in the past * `state` is `REGISTRATION_FAILED` * `state` is `TRANSFER_FAILED` When an
                /// active registration is successfully deleted, you can continue to use the domain in [Google
                /// Domains](https://domains.google/) until it expires. The calling user becomes the domain's sole owner
                /// in Google Domains, and permissions for the domain are subsequently managed there. The domain does
                /// not renew automatically unless the new owner sets up billing in Google Domains.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the `Registration` to delete, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a `Registration` resource. This method works on any `Registration` resource using
                /// [Subscription or Commitment billing](/domains/pricing#billing-models), provided that the resource
                /// was created at least 1 day in the past. For `Registration` resources using [Monthly
                /// billing](/domains/pricing#billing-models), this method works if: * `state` is `EXPORTED` with
                /// `expire_time` in the past * `state` is `REGISTRATION_FAILED` * `state` is `TRANSFER_FAILED` When an
                /// active registration is successfully deleted, you can continue to use the domain in [Google
                /// Domains](https://domains.google/) until it expires. The calling user becomes the domain's sole owner
                /// in Google Domains, and permissions for the domain are subsequently managed there. The domain does
                /// not renew automatically unless the new owner sets up billing in Google Domains.
                /// </summary>
                public class DeleteRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` to delete, in the format
                    /// `projects/*/locations/*/registrations/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Exports a `Registration` resource, such that it is no longer managed by Cloud Domains. When an
                /// active domain is successfully exported, you can continue to use the domain in [Google
                /// Domains](https://domains.google/) until it expires. The calling user becomes the domain's sole owner
                /// in Google Domains, and permissions for the domain are subsequently managed there. The domain does
                /// not renew automatically unless the new owner sets up billing in Google Domains.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the `Registration` to export, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ExportRequest Export(Google.Apis.CloudDomains.v1.Data.ExportRegistrationRequest body, string name)
                {
                    return new ExportRequest(service, body, name);
                }

                /// <summary>
                /// Exports a `Registration` resource, such that it is no longer managed by Cloud Domains. When an
                /// active domain is successfully exported, you can continue to use the domain in [Google
                /// Domains](https://domains.google/) until it expires. The calling user becomes the domain's sole owner
                /// in Google Domains, and permissions for the domain are subsequently managed there. The domain does
                /// not renew automatically unless the new owner sets up billing in Google Domains.
                /// </summary>
                public class ExportRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.ExportRegistrationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` to export, in the format
                    /// `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.ExportRegistrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:export";

                    /// <summary>Initializes Export parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets the details of a `Registration` resource.</summary>
                /// <param name="name">
                /// Required. The name of the `Registration` to get, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the details of a `Registration` resource.</summary>
                public class GetRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Registration>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` to get, in the format
                    /// `projects/*/locations/*/registrations/*`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Policy>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
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
                /// Imports a domain name from [Google Domains](https://domains.google/) for use in Cloud Domains. To
                /// transfer a domain from another registrar, use the `TransferDomain` method instead. Since individual
                /// users can own domains in Google Domains, the calling user must have ownership permission on the
                /// domain.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the Registration. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual ImportRequest Import(Google.Apis.CloudDomains.v1.Data.ImportDomainRequest body, string parent)
                {
                    return new ImportRequest(service, body, parent);
                }

                /// <summary>
                /// Imports a domain name from [Google Domains](https://domains.google/) for use in Cloud Domains. To
                /// transfer a domain from another registrar, use the `TransferDomain` method instead. Since individual
                /// users can own domains in Google Domains, the calling user must have ownership permission on the
                /// domain.
                /// </summary>
                public class ImportRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Import request.</summary>
                    public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.ImportDomainRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the Registration. Must be in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.ImportDomainRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "import";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/registrations:import";

                    /// <summary>Initializes Import parameter list.</summary>
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

                /// <summary>Lists the `Registration` resources in a project.</summary>
                /// <param name="parent">
                /// Required. The project and location from which to list `Registration`s, specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists the `Registration` resources in a project.</summary>
                public class ListRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.ListRegistrationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and location from which to list `Registration`s, specified in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Filter expression to restrict the `Registration`s returned. The expression must specify the
                    /// field name, a comparison operator, and the value that you want to use for filtering. The value
                    /// must be a string, a number, a boolean, or an enum value. The comparison operator should be one
                    /// of =, !=, &amp;gt;, &amp;lt;, &amp;gt;=, &amp;lt;=, or : for prefix or wildcard matches. For
                    /// example, to filter to a specific domain name, use an expression like `domainName="example.com"`.
                    /// You can also check for the existence of a field; for example, to find domains using custom DNS
                    /// settings, use an expression like `dnsSettings.customDns:*`. You can also create compound filters
                    /// by combining expressions with the `AND` and `OR` operators. For example, to find domains that
                    /// are suspended or have specific issues flagged, use an expression like `(state=SUSPENDED) OR
                    /// (issue:*)`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Maximum number of results to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// When set to the `next_page_token` from a prior response, provides the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/registrations";

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

                /// <summary>
                /// Updates select fields of a `Registration` resource, notably `labels`. To update other fields, use
                /// the appropriate custom update method: * To update management settings, see
                /// `ConfigureManagementSettings` * To update DNS configuration, see `ConfigureDnsSettings` * To update
                /// contact information, see `ConfigureContactSettings`
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. Name of the `Registration` resource, in the format
                /// `projects/*/locations/*/registrations/`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudDomains.v1.Data.Registration body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates select fields of a `Registration` resource, notably `labels`. To update other fields, use
                /// the appropriate custom update method: * To update management settings, see
                /// `ConfigureManagementSettings` * To update DNS configuration, see `ConfigureDnsSettings` * To update
                /// contact information, see `ConfigureContactSettings`
                /// </summary>
                public class PatchRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.Registration body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. Name of the `Registration` resource, in the format
                    /// `projects/*/locations/*/registrations/`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. The field mask describing which fields to update as a comma-separated list. For
                    /// example, if only the labels are being updated, the `update_mask` is `"labels"`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.Registration Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
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
                /// Registers a new domain name and creates a corresponding `Registration` resource. Call
                /// `RetrieveRegisterParameters` first to check availability of the domain name and determine parameters
                /// like price that are needed to build a call to this method. A successful call creates a
                /// `Registration` resource in state `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
                /// minutes, indicating that the domain was successfully registered. If the resource ends up in state
                /// `REGISTRATION_FAILED`, it indicates that the domain was not registered successfully, and you can
                /// safely delete the resource and retry registration.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the `Registration`. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual RegisterRequest Register(Google.Apis.CloudDomains.v1.Data.RegisterDomainRequest body, string parent)
                {
                    return new RegisterRequest(service, body, parent);
                }

                /// <summary>
                /// Registers a new domain name and creates a corresponding `Registration` resource. Call
                /// `RetrieveRegisterParameters` first to check availability of the domain name and determine parameters
                /// like price that are needed to build a call to this method. A successful call creates a
                /// `Registration` resource in state `REGISTRATION_PENDING`, which resolves to `ACTIVE` within 1-2
                /// minutes, indicating that the domain was successfully registered. If the resource ends up in state
                /// `REGISTRATION_FAILED`, it indicates that the domain was not registered successfully, and you can
                /// safely delete the resource and retry registration.
                /// </summary>
                public class RegisterRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Register request.</summary>
                    public RegisterRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.RegisterDomainRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the `Registration`. Must be in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.RegisterDomainRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "register";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/registrations:register";

                    /// <summary>Initializes Register parameter list.</summary>
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
                /// Resets the authorization code of the `Registration` to a new random string. You can call this method
                /// only after 60 days have elapsed since the initial domain registration.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose authorization code is being reset, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ResetAuthorizationCodeRequest ResetAuthorizationCode(Google.Apis.CloudDomains.v1.Data.ResetAuthorizationCodeRequest body, string registration)
                {
                    return new ResetAuthorizationCodeRequest(service, body, registration);
                }

                /// <summary>
                /// Resets the authorization code of the `Registration` to a new random string. You can call this method
                /// only after 60 days have elapsed since the initial domain registration.
                /// </summary>
                public class ResetAuthorizationCodeRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.AuthorizationCode>
                {
                    /// <summary>Constructs a new ResetAuthorizationCode request.</summary>
                    public ResetAuthorizationCodeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.ResetAuthorizationCodeRequest body, string registration) : base(service)
                    {
                        Registration = registration;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whose authorization code is being reset, in the format
                    /// `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.ResetAuthorizationCodeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resetAuthorizationCode";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+registration}:resetAuthorizationCode";

                    /// <summary>Initializes ResetAuthorizationCode parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("registration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "registration",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the authorization code of the `Registration` for the purpose of transferring the domain to
                /// another registrar. You can call this method only after 60 days have elapsed since the initial domain
                /// registration.
                /// </summary>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose authorization code is being retrieved, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual RetrieveAuthorizationCodeRequest RetrieveAuthorizationCode(string registration)
                {
                    return new RetrieveAuthorizationCodeRequest(service, registration);
                }

                /// <summary>
                /// Gets the authorization code of the `Registration` for the purpose of transferring the domain to
                /// another registrar. You can call this method only after 60 days have elapsed since the initial domain
                /// registration.
                /// </summary>
                public class RetrieveAuthorizationCodeRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.AuthorizationCode>
                {
                    /// <summary>Constructs a new RetrieveAuthorizationCode request.</summary>
                    public RetrieveAuthorizationCodeRequest(Google.Apis.Services.IClientService service, string registration) : base(service)
                    {
                        Registration = registration;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whose authorization code is being retrieved, in the
                    /// format `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieveAuthorizationCode";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+registration}:retrieveAuthorizationCode";

                    /// <summary>Initializes RetrieveAuthorizationCode parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("registration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "registration",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists domain names from [Google Domains](https://domains.google/) that can be imported to Cloud
                /// Domains using the `ImportDomain` method. Since individual users can own domains in Google Domains,
                /// the list of domains returned depends on the individual user making the call. Domains already managed
                /// by Cloud Domains are not returned.
                /// </summary>
                /// <param name="location">
                /// Required. The location. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual RetrieveImportableDomainsRequest RetrieveImportableDomains(string location)
                {
                    return new RetrieveImportableDomainsRequest(service, location);
                }

                /// <summary>
                /// Lists domain names from [Google Domains](https://domains.google/) that can be imported to Cloud
                /// Domains using the `ImportDomain` method. Since individual users can own domains in Google Domains,
                /// the list of domains returned depends on the individual user making the call. Domains already managed
                /// by Cloud Domains are not returned.
                /// </summary>
                public class RetrieveImportableDomainsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.RetrieveImportableDomainsResponse>
                {
                    /// <summary>Constructs a new RetrieveImportableDomains request.</summary>
                    public RetrieveImportableDomainsRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                    {
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. The location. Must be in the format `projects/*/locations/*`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>Maximum number of results to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// When set to the `next_page_token` from a prior response, provides the next page of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieveImportableDomains";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+location}/registrations:retrieveImportableDomains";

                    /// <summary>Initializes RetrieveImportableDomains parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
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
                /// Gets parameters needed to register a new domain name, including price and up-to-date availability.
                /// Use the returned values to call `RegisterDomain`.
                /// </summary>
                /// <param name="location">
                /// Required. The location. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual RetrieveRegisterParametersRequest RetrieveRegisterParameters(string location)
                {
                    return new RetrieveRegisterParametersRequest(service, location);
                }

                /// <summary>
                /// Gets parameters needed to register a new domain name, including price and up-to-date availability.
                /// Use the returned values to call `RegisterDomain`.
                /// </summary>
                public class RetrieveRegisterParametersRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.RetrieveRegisterParametersResponse>
                {
                    /// <summary>Constructs a new RetrieveRegisterParameters request.</summary>
                    public RetrieveRegisterParametersRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                    {
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. The location. Must be in the format `projects/*/locations/*`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>
                    /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DomainName { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieveRegisterParameters";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+location}/registrations:retrieveRegisterParameters";

                    /// <summary>Initializes RetrieveRegisterParameters parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("domainName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "domainName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets parameters needed to transfer a domain name from another registrar to Cloud Domains. For
                /// domains already managed by [Google Domains](https://domains.google/), use `ImportDomain` instead.
                /// Use the returned values to call `TransferDomain`.
                /// </summary>
                /// <param name="location">
                /// Required. The location. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual RetrieveTransferParametersRequest RetrieveTransferParameters(string location)
                {
                    return new RetrieveTransferParametersRequest(service, location);
                }

                /// <summary>
                /// Gets parameters needed to transfer a domain name from another registrar to Cloud Domains. For
                /// domains already managed by [Google Domains](https://domains.google/), use `ImportDomain` instead.
                /// Use the returned values to call `TransferDomain`.
                /// </summary>
                public class RetrieveTransferParametersRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.RetrieveTransferParametersResponse>
                {
                    /// <summary>Constructs a new RetrieveTransferParameters request.</summary>
                    public RetrieveTransferParametersRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                    {
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. The location. Must be in the format `projects/*/locations/*`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>
                    /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DomainName { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieveTransferParameters";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+location}/registrations:retrieveTransferParameters";

                    /// <summary>Initializes RetrieveTransferParameters parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("domainName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "domainName",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Searches for available domain names similar to the provided query. Availability results from this
                /// method are approximate; call `RetrieveRegisterParameters` on a domain before registering to confirm
                /// availability.
                /// </summary>
                /// <param name="location">
                /// Required. The location. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual SearchDomainsRequest SearchDomains(string location)
                {
                    return new SearchDomainsRequest(service, location);
                }

                /// <summary>
                /// Searches for available domain names similar to the provided query. Availability results from this
                /// method are approximate; call `RetrieveRegisterParameters` on a domain before registering to confirm
                /// availability.
                /// </summary>
                public class SearchDomainsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.SearchDomainsResponse>
                {
                    /// <summary>Constructs a new SearchDomains request.</summary>
                    public SearchDomainsRequest(Google.Apis.Services.IClientService service, string location) : base(service)
                    {
                        Location = location;
                        InitParameters();
                    }

                    /// <summary>Required. The location. Must be in the format `projects/*/locations/*`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Location { get; private set; }

                    /// <summary>Required. String used to search for available domain names.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Query { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "searchDomains";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+location}/registrations:searchDomains";

                    /// <summary>Initializes SearchDomains parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                        {
                            Name = "location",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDomains.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDomains.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDomains.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDomains.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registrations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Transfers a domain name from another registrar to Cloud Domains. For domains already managed by
                /// [Google Domains](https://domains.google/), use `ImportDomain` instead. Before calling this method,
                /// go to the domain's current registrar to unlock the domain for transfer and retrieve the domain's
                /// transfer authorization code. Then call `RetrieveTransferParameters` to confirm that the domain is
                /// unlocked and to get values needed to build a call to this method. A successful call creates a
                /// `Registration` resource in state `TRANSFER_PENDING`. It can take several days to complete the
                /// transfer process. The registrant can often speed up this process by approving the transfer through
                /// the current registrar, either by clicking a link in an email from the registrar or by visiting the
                /// registrar's website. A few minutes after transfer approval, the resource transitions to state
                /// `ACTIVE`, indicating that the transfer was successful. If the transfer is rejected or the request
                /// expires without being approved, the resource can end up in state `TRANSFER_FAILED`. If transfer
                /// fails, you can safely delete the resource and retry the transfer.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the `Registration`. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual TransferRequest Transfer(Google.Apis.CloudDomains.v1.Data.TransferDomainRequest body, string parent)
                {
                    return new TransferRequest(service, body, parent);
                }

                /// <summary>
                /// Transfers a domain name from another registrar to Cloud Domains. For domains already managed by
                /// [Google Domains](https://domains.google/), use `ImportDomain` instead. Before calling this method,
                /// go to the domain's current registrar to unlock the domain for transfer and retrieve the domain's
                /// transfer authorization code. Then call `RetrieveTransferParameters` to confirm that the domain is
                /// unlocked and to get values needed to build a call to this method. A successful call creates a
                /// `Registration` resource in state `TRANSFER_PENDING`. It can take several days to complete the
                /// transfer process. The registrant can often speed up this process by approving the transfer through
                /// the current registrar, either by clicking a link in an email from the registrar or by visiting the
                /// registrar's website. A few minutes after transfer approval, the resource transitions to state
                /// `ACTIVE`, indicating that the transfer was successful. If the transfer is rejected or the request
                /// expires without being approved, the resource can end up in state `TRANSFER_FAILED`. If transfer
                /// fails, you can safely delete the resource and retry the transfer.
                /// </summary>
                public class TransferRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Transfer request.</summary>
                    public TransferRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1.Data.TransferDomainRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource of the `Registration`. Must be in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1.Data.TransferDomainRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "transfer";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/registrations:transfer";

                    /// <summary>Initializes Transfer parameter list.</summary>
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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// `"displayName=tokyo"`, and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/locations";

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
                        Pattern = @"^projects/[^/]+$",
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
    }
}
namespace Google.Apis.CloudDomains.v1.Data
{
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

    /// <summary>Defines an authorization code.</summary>
    public class AuthorizationCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Authorization Code in ASCII. It can be used to transfer the domain to or from another registrar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

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
        /// represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
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
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ConfigureContactSettings` method.</summary>
    public class ConfigureContactSettingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of contact notices that the caller acknowledges. The notices needed here depend on the values
        /// specified in `contact_settings`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactNotices")]
        public virtual System.Collections.Generic.IList<string> ContactNotices { get; set; }

        /// <summary>Fields of the `ContactSettings` to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactSettings")]
        public virtual ContactSettings ContactSettings { get; set; }

        /// <summary>
        /// Required. The field mask describing which fields to update as a comma-separated list. For example, if only
        /// the registrant contact is being updated, the `update_mask` is `"registrant_contact"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>Validate the request without actually updating the contact settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ConfigureDnsSettings` method.</summary>
    public class ConfigureDnsSettingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fields of the `DnsSettings` to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsSettings")]
        public virtual DnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Required. The field mask describing which fields to update as a comma-separated list. For example, if only
        /// the name servers are being updated for an existing Custom DNS configuration, the `update_mask` is
        /// `"custom_dns.name_servers"`. When changing the DNS provider from one type to another, pass the new
        /// provider's field name as part of the field mask. For example, when changing from a Google Domains DNS
        /// configuration to a Custom DNS configuration, the `update_mask` is `"custom_dns"`. //
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>Validate the request without actually updating the DNS settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ConfigureManagementSettings` method.</summary>
    public class ConfigureManagementSettingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fields of the `ManagementSettings` to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementSettings")]
        public virtual ManagementSettings ManagementSettings { get; set; }

        /// <summary>
        /// Required. The field mask describing which fields to update as a comma-separated list. For example, if only
        /// the transfer lock is being updated, the `update_mask` is `"transfer_lock_state"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details required for a contact associated with a `Registration`.</summary>
    public class Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Email address of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Fax number of the contact in international format. For example, `"+1-800-555-0123"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faxNumber")]
        public virtual string FaxNumber { get; set; }

        /// <summary>
        /// Required. Phone number of the contact in international format. For example, `"+1-800-555-0123"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>Required. Postal address of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual PostalAddress PostalAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the contact information associated with a `Registration`. [ICANN](https://icann.org/) requires all
    /// domain names to have associated contact information. The `registrant_contact` is considered the domain's legal
    /// owner, and often the other contacts are identical.
    /// </summary>
    public class ContactSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The administrative contact for the `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminContact")]
        public virtual Contact AdminContact { get; set; }

        /// <summary>Required. Privacy setting for the contacts associated with the `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacy")]
        public virtual string Privacy { get; set; }

        /// <summary>
        /// Required. The registrant contact for the `Registration`. *Caution: Anyone with access to this email address,
        /// phone number, and/or postal address can take control of the domain.* *Warning: For new `Registration`s, the
        /// registrant receives an email confirmation that they must complete within 15 days to avoid domain
        /// suspension.*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registrantContact")]
        public virtual Contact RegistrantContact { get; set; }

        /// <summary>Required. The technical contact for the `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technicalContact")]
        public virtual Contact TechnicalContact { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an arbitrary DNS provider.</summary>
    public class CustomDns : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of DS records for this domain, which are used to enable DNSSEC. The domain's DNS provider can
        /// provide the values to set here. If this field is empty, DNSSEC is disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dsRecords")]
        public virtual System.Collections.Generic.IList<DsRecord> DsRecords { get; set; }

        /// <summary>
        /// Required. A list of name servers that store the DNS zone for this domain. Each name server is a domain name,
        /// with Unicode domain names expressed in Punycode format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameServers")]
        public virtual System.Collections.Generic.IList<string> NameServers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the DNS configuration of a `Registration`, including name servers, DNSSEC, and glue records.
    /// </summary>
    public class DnsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An arbitrary DNS provider identified by its name servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDns")]
        public virtual CustomDns CustomDns { get; set; }

        /// <summary>The list of glue records for this `Registration`. Commonly empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glueRecords")]
        public virtual System.Collections.Generic.IList<GlueRecord> GlueRecords { get; set; }

        /// <summary>The free DNS zone provided by [Google Domains](https://domains.google/).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleDomainsDns")]
        public virtual GoogleDomainsDns GoogleDomainsDns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A domain that the calling user manages in Google Domains.</summary>
    public class Domain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain name. Unicode domain names are expressed in Punycode format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>The state of this domain as a `Registration` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceState")]
        public virtual string ResourceState { get; set; }

        /// <summary>Price to renew the domain for one year. Only set when `resource_state` is `IMPORTABLE`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyPrice")]
        public virtual Money YearlyPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines a Delegation Signer (DS) record, which is needed to enable DNSSEC for a domain. It contains a digest
    /// (hash) of a DNSKEY record that must be present in the domain's DNS zone.
    /// </summary>
    public class DsRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The algorithm used to generate the referenced DNSKEY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>The digest generated from the referenced DNSKEY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual string Digest { get; set; }

        /// <summary>The hash function used to generate the digest of the referenced DNSKEY.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digestType")]
        public virtual string DigestType { get; set; }

        /// <summary>The key tag of the record. Must be set in range 0 -- 65535.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyTag")]
        public virtual System.Nullable<int> KeyTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ExportRegistration` method.</summary>
    public class ExportRegistrationRequest : Google.Apis.Requests.IDirectResponseSchema
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
    /// Defines a host on your domain that is a DNS name server for your domain and/or other domains. Glue records are a
    /// way of making the IP address of a name server known, even when it serves DNS queries for its parent domain. For
    /// example, when `ns.example.com` is a name server for `example.com`, the host `ns.example.com` must have a glue
    /// record to break the circular DNS reference.
    /// </summary>
    public class GlueRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Domain name of the host in Punycode format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostName")]
        public virtual string HostName { get; set; }

        /// <summary>
        /// List of IPv4 addresses corresponding to this host in the standard decimal format (e.g. `198.51.100.1`). At
        /// least one of `ipv4_address` and `ipv6_address` must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv4Addresses")]
        public virtual System.Collections.Generic.IList<string> Ipv4Addresses { get; set; }

        /// <summary>
        /// List of IPv6 addresses corresponding to this host in the standard hexadecimal format (e.g. `2001:db8::`). At
        /// least one of `ipv4_address` and `ipv6_address` must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv6Addresses")]
        public virtual System.Collections.Generic.IList<string> Ipv6Addresses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for using the free DNS zone provided by Google Domains as a `Registration`'s `dns_provider`. You
    /// cannot configure the DNS zone itself using the API. To configure the DNS zone, go to [Google
    /// Domains](https://domains.google/).
    /// </summary>
    public class GoogleDomainsDns : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The list of DS records published for this domain. The list is automatically populated when
        /// `ds_state` is `DS_RECORDS_PUBLISHED`, otherwise it remains empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dsRecords")]
        public virtual System.Collections.Generic.IList<DsRecord> DsRecords { get; set; }

        /// <summary>
        /// Required. The state of DS records for this domain. Used to enable or disable automatic DNSSEC.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dsState")]
        public virtual string DsState { get; set; }

        /// <summary>
        /// Output only. A list of name servers that store the DNS zone for this domain. Each name server is a domain
        /// name, with Unicode domain names expressed in Punycode format. This field is automatically populated with the
        /// name servers assigned to the Google Domains DNS zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameServers")]
        public virtual System.Collections.Generic.IList<string> NameServers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ImportDomain` method.</summary>
    public class ImportDomainRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The domain name. Unicode domain names must be expressed in Punycode format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>Set of labels associated with the `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Response for the `ListRegistrations` method.</summary>
    public class ListRegistrationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When present, there are more results to retrieve. Set `page_token` to this value on a subsequent call to get
        /// the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of `Registration`s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registrations")]
        public virtual System.Collections.Generic.IList<Registration> Registrations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines renewal, billing, and transfer settings for a `Registration`.</summary>
    public class ManagementSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The renewal method for this `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalMethod")]
        public virtual string RenewalMethod { get; set; }

        /// <summary>Controls whether the domain can be transferred to another registrar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferLockState")]
        public virtual string TransferLockState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation. Output only.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; }

        /// <summary>Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

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
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
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

    /// <summary>
    /// Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a postal
    /// service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical locations
    /// (roads, towns, mountains). In typical usage an address would be created via user input or from importing
    /// existing data, depending on the type of process. Advice on address input / editing: - Use an
    /// internationalization-ready address widget such as https://github.com/google/libaddressinput) - Users should not
    /// be presented with UI elements for input or editing of fields outside countries where that field is used. For
    /// more guidance on how to use this schema, please see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (e.g. "Austin, TX"), it is
        /// important that the line order is clear. The order of address lines should be "envelope order" for the
        /// country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make
        /// it explicit (e.g. "ja" for large-to-small ordering and "ja-Latn" or "en" for small-to-large). This way, the
        /// most specific line of an address can be selected based on the language. The minimum permitted structural
        /// representation of an address consists of a region_code with all remaining information placed in the
        /// address_lines. It would be possible to format such an address very approximately without geocoding, but no
        /// semantic reasoning could be made about any of the address components until it was at least partially
        /// resolved. Creating an address only containing a region_code and address_lines, and then geocoding is the
        /// recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the
        /// address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (e.g. "Barcelona" and not "Catalonia"). Many countries don't use
        /// an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of
        /// the input form or is expected to match one of the languages used in the address' country/region, or their
        /// transliterated equivalents. This can affect formatting in certain countries, but is not critical to the
        /// correctness of the data and will never affect any validation or other non-formatting related operations. If
        /// this value is not known, it should be omitted (rather than specifying a possibly incorrect default).
        /// Examples: "zh-Hant", "ja", "ja-Latn", "en".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post
        /// town. In regions of the world where localities are not well defined or do not fit into this structure well,
        /// leave locality empty and use address_lines.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The name of the organization at the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organization")]
        public virtual string Organization { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where
        /// they are used, they may trigger additional validation with other parts of the address (e.g. state/zip
        /// validation in the U.S.A.).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline
        /// information. For example, it might contain "care of" information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the
        /// user to ensure the value is correct. See https://cldr.unicode.org/ and
        /// https://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: "CH"
        /// for Switzerland.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The schema revision of the `PostalAddress`. This must be set to 0, which is the latest revision. All new
        /// revisions **must** be backward compatible with old revisions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revision")]
        public virtual System.Nullable<int> Revision { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used,
        /// the value is either a string like "CEDEX", optionally followed by a number (e.g. "CEDEX 7"), or just a
        /// number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (e.g. Côte d'Ivoire).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortingCode")]
        public virtual string SortingCode { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `RegisterDomain` method.</summary>
    public class RegisterDomainRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of contact notices that the caller acknowledges. The notices needed here depend on the values
        /// specified in `registration.contact_settings`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactNotices")]
        public virtual System.Collections.Generic.IList<string> ContactNotices { get; set; }

        /// <summary>
        /// The list of domain notices that you acknowledge. Call `RetrieveRegisterParameters` to see the notices that
        /// need acknowledgement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainNotices")]
        public virtual System.Collections.Generic.IList<string> DomainNotices { get; set; }

        /// <summary>Required. The complete `Registration` resource to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registration")]
        public virtual Registration Registration { get; set; }

        /// <summary>
        /// When true, only validation is performed, without actually registering the domain. Follows:
        /// https://cloud.google.com/apis/design/design_patterns#request_validation
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>
        /// Required. Yearly price to register or renew the domain. The value that should be put here can be obtained
        /// from RetrieveRegisterParameters or SearchDomains calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyPrice")]
        public virtual Money YearlyPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters required to register a new domain.</summary>
    public class RegisterParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether the domain is available for registration. This value is accurate when obtained by calling
        /// `RetrieveRegisterParameters`, but is approximate when obtained by calling `SearchDomains`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>The domain name. Unicode domain names are expressed in Punycode format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>Notices about special properties of the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainNotices")]
        public virtual System.Collections.Generic.IList<string> DomainNotices { get; set; }

        /// <summary>Contact privacy options that the domain supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedPrivacy")]
        public virtual System.Collections.Generic.IList<string> SupportedPrivacy { get; set; }

        /// <summary>Price to register or renew the domain for one year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyPrice")]
        public virtual Money YearlyPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Registration` resource facilitates managing and configuring domain name registrations. There are several
    /// ways to create a new `Registration` resource: To create a new `Registration` resource, find a suitable domain
    /// name by calling the `SearchDomains` method with a query to see available domain name options. After choosing a
    /// name, call `RetrieveRegisterParameters` to ensure availability and obtain information like pricing, which is
    /// needed to build a call to `RegisterDomain`. Another way to create a new `Registration` is to transfer an
    /// existing domain from another registrar. First, go to the current registrar to unlock the domain for transfer and
    /// retrieve the domain's transfer authorization code. Then call `RetrieveTransferParameters` to confirm that the
    /// domain is unlocked and to get values needed to build a call to `TransferDomain`. Finally, you can create a new
    /// `Registration` by importing an existing domain managed with [Google Domains](https://domains.google/). First,
    /// call `RetrieveImportableDomains` to list domains to which the calling user has sufficient access. Then call
    /// `ImportDomain` on any domain names you want to use with Cloud Domains.
    /// </summary>
    public class Registration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Settings for contact information linked to the `Registration`. You cannot update these with the
        /// `UpdateRegistration` method. To update these settings, use the `ConfigureContactSettings` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactSettings")]
        public virtual ContactSettings ContactSettings { get; set; }

        /// <summary>Output only. The creation timestamp of the `Registration` resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Settings controlling the DNS configuration of the `Registration`. You cannot update these with the
        /// `UpdateRegistration` method. To update these settings, use the `ConfigureDnsSettings` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsSettings")]
        public virtual DnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Required. Immutable. The domain name. Unicode domain names must be expressed in Punycode format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>Output only. The expiration timestamp of the `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>Output only. The set of issues with the `Registration` that require attention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<string> Issues { get; set; }

        /// <summary>Set of labels associated with the `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Settings for management of the `Registration`, including renewal, billing, and transfer. You cannot update
        /// these with the `UpdateRegistration` method. To update these settings, use the `ConfigureManagementSettings`
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementSettings")]
        public virtual ManagementSettings ManagementSettings { get; set; }

        /// <summary>
        /// Output only. Name of the `Registration` resource, in the format `projects/*/locations/*/registrations/`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Pending contact settings for the `Registration`. Updates to the `contact_settings` field that
        /// change its `registrant_contact` or `privacy` fields require email confirmation by the `registrant_contact`
        /// before taking effect. This field is set only if there are pending updates to the `contact_settings` that
        /// have not been confirmed. To confirm the changes, the `registrant_contact` must follow the instructions in
        /// the email they receive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingContactSettings")]
        public virtual ContactSettings PendingContactSettings { get; set; }

        /// <summary>
        /// Output only. The reason the domain registration failed. Only set for domains in REGISTRATION_FAILED state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registerFailureReason")]
        public virtual string RegisterFailureReason { get; set; }

        /// <summary>Output only. The state of the `Registration`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Output only. Set of options for the `contact_settings.privacy` field that this `Registration` supports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedPrivacy")]
        public virtual System.Collections.Generic.IList<string> SupportedPrivacy { get; set; }

        /// <summary>
        /// Output only. The reason the domain transfer failed. Only set for domains in TRANSFER_FAILED state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferFailureReason")]
        public virtual string TransferFailureReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ResetAuthorizationCode` method.</summary>
    public class ResetAuthorizationCodeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `RetrieveImportableDomains` method.</summary>
    public class RetrieveImportableDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of domains that the calling user manages in Google Domains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<Domain> Domains { get; set; }

        /// <summary>
        /// When present, there are more results to retrieve. Set `page_token` to this value on a subsequent call to get
        /// the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `RetrieveRegisterParameters` method.</summary>
    public class RetrieveRegisterParametersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Parameters to use when calling the `RegisterDomain` method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registerParameters")]
        public virtual RegisterParameters RegisterParameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `RetrieveTransferParameters` method.</summary>
    public class RetrieveTransferParametersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Parameters to use when calling the `TransferDomain` method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferParameters")]
        public virtual TransferParameters TransferParameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `SearchDomains` method.</summary>
    public class SearchDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Results of the domain name search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registerParameters")]
        public virtual System.Collections.Generic.IList<RegisterParameters> RegisterParameters { get; set; }

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

    /// <summary>Request for the `TransferDomain` method.</summary>
    public class TransferDomainRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The domain's transfer authorization code. You can obtain this from the domain's current registrar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationCode")]
        public virtual AuthorizationCode AuthorizationCode { get; set; }

        /// <summary>
        /// The list of contact notices that you acknowledge. The notices needed here depend on the values specified in
        /// `registration.contact_settings`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactNotices")]
        public virtual System.Collections.Generic.IList<string> ContactNotices { get; set; }

        /// <summary>
        /// Required. The complete `Registration` resource to be created. You can leave `registration.dns_settings`
        /// unset to import the domain's current DNS configuration from its current registrar. Use this option only if
        /// you are sure that the domain's current DNS service does not cease upon transfer, as is often the case for
        /// DNS services provided for free by the registrar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registration")]
        public virtual Registration Registration { get; set; }

        /// <summary>Validate the request without actually transferring the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>
        /// Required. Acknowledgement of the price to transfer or renew the domain for one year. Call
        /// `RetrieveTransferParameters` to obtain the price, which you must acknowledge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyPrice")]
        public virtual Money YearlyPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Parameters required to transfer a domain from another registrar.</summary>
    public class TransferParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The registrar that currently manages the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentRegistrar")]
        public virtual string CurrentRegistrar { get; set; }

        /// <summary>The URL of the registrar that currently manages the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentRegistrarUri")]
        public virtual string CurrentRegistrarUri { get; set; }

        /// <summary>The domain name. Unicode domain names are expressed in Punycode format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; }

        /// <summary>The name servers that currently store the configuration of the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nameServers")]
        public virtual System.Collections.Generic.IList<string> NameServers { get; set; }

        /// <summary>Contact privacy options that the domain supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedPrivacy")]
        public virtual System.Collections.Generic.IList<string> SupportedPrivacy { get; set; }

        /// <summary>
        /// Indicates whether the domain is protected by a transfer lock. For a transfer to succeed, this must show
        /// `UNLOCKED`. To unlock a domain, go to its current registrar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferLockState")]
        public virtual string TransferLockState { get; set; }

        /// <summary>Price to transfer or renew the domain for one year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyPrice")]
        public virtual Money YearlyPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
