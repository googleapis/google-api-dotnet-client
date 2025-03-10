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

namespace Google.Apis.CloudDomains.v1beta1
{
    /// <summary>The CloudDomains Service.</summary>
    public class CloudDomainsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://domains.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://domains.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "domains";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

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
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
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
                    public override string RestPath => "v1beta1/{+name}";

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
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1beta1/{+name}/operations";

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
                /// registrant contact . Caution: Please consider carefully any changes to contact privacy settings when
                /// changing from `REDACTED_CONTACT_DATA` to `PUBLIC_CONTACT_DATA.` There may be a delay in reflecting
                /// updates you make to registrant contact information such that any changes you make to contact privacy
                /// (including from `REDACTED_CONTACT_DATA` to `PUBLIC_CONTACT_DATA`) will be applied without delay but
                /// changes to registrant contact information may take a limited time to be publicized. This means that
                /// changes to contact privacy from `REDACTED_CONTACT_DATA` to `PUBLIC_CONTACT_DATA` may make the
                /// previous registrant contact data public until the modified registrant contact details are published.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose contact settings are being updated, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ConfigureContactSettingsRequest ConfigureContactSettings(Google.Apis.CloudDomains.v1beta1.Data.ConfigureContactSettingsRequest body, string registration)
                {
                    return new ConfigureContactSettingsRequest(this.service, body, registration);
                }

                /// <summary>
                /// Updates a `Registration`'s contact settings. Some changes require confirmation by the domain's
                /// registrant contact . Caution: Please consider carefully any changes to contact privacy settings when
                /// changing from `REDACTED_CONTACT_DATA` to `PUBLIC_CONTACT_DATA.` There may be a delay in reflecting
                /// updates you make to registrant contact information such that any changes you make to contact privacy
                /// (including from `REDACTED_CONTACT_DATA` to `PUBLIC_CONTACT_DATA`) will be applied without delay but
                /// changes to registrant contact information may take a limited time to be publicized. This means that
                /// changes to contact privacy from `REDACTED_CONTACT_DATA` to `PUBLIC_CONTACT_DATA` may make the
                /// previous registrant contact data public until the modified registrant contact details are published.
                /// </summary>
                public class ConfigureContactSettingsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new ConfigureContactSettings request.</summary>
                    public ConfigureContactSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.ConfigureContactSettingsRequest body, string registration) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.ConfigureContactSettingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "configureContactSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:configureContactSettings";

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
                public virtual ConfigureDnsSettingsRequest ConfigureDnsSettings(Google.Apis.CloudDomains.v1beta1.Data.ConfigureDnsSettingsRequest body, string registration)
                {
                    return new ConfigureDnsSettingsRequest(this.service, body, registration);
                }

                /// <summary>Updates a `Registration`'s DNS settings.</summary>
                public class ConfigureDnsSettingsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new ConfigureDnsSettings request.</summary>
                    public ConfigureDnsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.ConfigureDnsSettingsRequest body, string registration) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.ConfigureDnsSettingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "configureDnsSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:configureDnsSettings";

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
                public virtual ConfigureManagementSettingsRequest ConfigureManagementSettings(Google.Apis.CloudDomains.v1beta1.Data.ConfigureManagementSettingsRequest body, string registration)
                {
                    return new ConfigureManagementSettingsRequest(this.service, body, registration);
                }

                /// <summary>Updates a `Registration`'s management settings.</summary>
                public class ConfigureManagementSettingsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new ConfigureManagementSettings request.</summary>
                    public ConfigureManagementSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.ConfigureManagementSettingsRequest body, string registration) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.ConfigureManagementSettingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "configureManagementSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:configureManagementSettings";

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
                /// was created at least 1 day in the past. When an active registration is successfully deleted, you can
                /// continue to use the domain in [Google Domains](https://domains.google/) until it expires. The
                /// calling user becomes the domain's sole owner in Google Domains, and permissions for the domain are
                /// subsequently managed there. The domain does not renew automatically unless the new owner sets up
                /// billing in Google Domains. After January 2024 you will only be able to delete `Registration`
                /// resources when `state` is one of: `EXPORTED`, `EXPIRED`,`REGISTRATION_FAILED` or `TRANSFER_FAILED`.
                /// See [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) for more
                /// details.
                /// </summary>
                /// <param name="name">
                /// Required. The name of the `Registration` to delete, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a `Registration` resource. This method works on any `Registration` resource using
                /// [Subscription or Commitment billing](/domains/pricing#billing-models), provided that the resource
                /// was created at least 1 day in the past. When an active registration is successfully deleted, you can
                /// continue to use the domain in [Google Domains](https://domains.google/) until it expires. The
                /// calling user becomes the domain's sole owner in Google Domains, and permissions for the domain are
                /// subsequently managed there. The domain does not renew automatically unless the new owner sets up
                /// billing in Google Domains. After January 2024 you will only be able to delete `Registration`
                /// resources when `state` is one of: `EXPORTED`, `EXPIRED`,`REGISTRATION_FAILED` or `TRANSFER_FAILED`.
                /// See [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) for more
                /// details.
                /// </summary>
                public class DeleteRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
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
                    public override string RestPath => "v1beta1/{+name}";

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
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Exports a
                /// `Registration` resource, such that it is no longer managed by Cloud Domains. When an active domain
                /// is successfully exported, you can continue to use the domain in [Google
                /// Domains](https://domains.google/) until it expires. The calling user becomes the domain's sole owner
                /// in Google Domains, and permissions for the domain are subsequently managed there. The domain does
                /// not renew automatically unless the new owner sets up billing in Google Domains.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The name of the `Registration` to export, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ExportRequest Export(Google.Apis.CloudDomains.v1beta1.Data.ExportRegistrationRequest body, string name)
                {
                    return new ExportRequest(this.service, body, name);
                }

                /// <summary>
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Exports a
                /// `Registration` resource, such that it is no longer managed by Cloud Domains. When an active domain
                /// is successfully exported, you can continue to use the domain in [Google
                /// Domains](https://domains.google/) until it expires. The calling user becomes the domain's sole owner
                /// in Google Domains, and permissions for the domain are subsequently managed there. The domain does
                /// not renew automatically unless the new owner sets up billing in Google Domains.
                /// </summary>
                public class ExportRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.ExportRegistrationRequest body, string name) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.ExportRegistrationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}:export";

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
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets the details of a `Registration` resource.</summary>
                public class GetRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Registration>
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
                    public override string RestPath => "v1beta1/{+name}";

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
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Policy>
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
                    public override string RestPath => "v1beta1/{+resource}:getIamPolicy";

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
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Imports a
                /// domain name from [Google Domains](https://domains.google/) for use in Cloud Domains. To transfer a
                /// domain from another registrar, use the `TransferDomain` method instead. Since individual users can
                /// own domains in Google Domains, the calling user must have ownership permission on the domain.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the Registration. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual ImportRequest Import(Google.Apis.CloudDomains.v1beta1.Data.ImportDomainRequest body, string parent)
                {
                    return new ImportRequest(this.service, body, parent);
                }

                /// <summary>
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Imports a
                /// domain name from [Google Domains](https://domains.google/) for use in Cloud Domains. To transfer a
                /// domain from another registrar, use the `TransferDomain` method instead. Since individual users can
                /// own domains in Google Domains, the calling user must have ownership permission on the domain.
                /// </summary>
                public class ImportRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Import request.</summary>
                    public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.ImportDomainRequest body, string parent) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.ImportDomainRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "import";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/registrations:import";

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

                /// <summary>
                /// Initiates the `Push Transfer` process to transfer the domain to another registrar. The process might
                /// complete instantly or might require confirmation or additional work. Check the emails sent to the
                /// email address of the registrant. The process is aborted after a timeout if it's not completed. This
                /// method is only supported for domains that have the `REQUIRE_PUSH_TRANSFER` property in the list of
                /// `domain_properties`. The domain must also be unlocked before it can be transferred to a different
                /// registrar. For more information, see [Transfer a registered domain to another
                /// registrar](https://cloud.google.com/domains/docs/transfer-domain-to-another-registrar).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` for which the push transfer is initiated, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual InitiatePushTransferRequest InitiatePushTransfer(Google.Apis.CloudDomains.v1beta1.Data.InitiatePushTransferRequest body, string registration)
                {
                    return new InitiatePushTransferRequest(this.service, body, registration);
                }

                /// <summary>
                /// Initiates the `Push Transfer` process to transfer the domain to another registrar. The process might
                /// complete instantly or might require confirmation or additional work. Check the emails sent to the
                /// email address of the registrant. The process is aborted after a timeout if it's not completed. This
                /// method is only supported for domains that have the `REQUIRE_PUSH_TRANSFER` property in the list of
                /// `domain_properties`. The domain must also be unlocked before it can be transferred to a different
                /// registrar. For more information, see [Transfer a registered domain to another
                /// registrar](https://cloud.google.com/domains/docs/transfer-domain-to-another-registrar).
                /// </summary>
                public class InitiatePushTransferRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new InitiatePushTransfer request.</summary>
                    public InitiatePushTransferRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.InitiatePushTransferRequest body, string registration) : base(service)
                    {
                        Registration = registration;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` for which the push transfer is initiated, in the format
                    /// `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1beta1.Data.InitiatePushTransferRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "initiatePushTransfer";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:initiatePushTransfer";

                    /// <summary>Initializes InitiatePushTransfer parameter list.</summary>
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

                /// <summary>Lists the `Registration` resources in a project.</summary>
                /// <param name="parent">
                /// Required. The project and location from which to list `Registration`s, specified in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists the `Registration` resources in a project.</summary>
                public class ListRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.ListRegistrationsResponse>
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
                    public override string RestPath => "v1beta1/{+parent}/registrations";

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
                public virtual PatchRequest Patch(Google.Apis.CloudDomains.v1beta1.Data.Registration body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates select fields of a `Registration` resource, notably `labels`. To update other fields, use
                /// the appropriate custom update method: * To update management settings, see
                /// `ConfigureManagementSettings` * To update DNS configuration, see `ConfigureDnsSettings` * To update
                /// contact information, see `ConfigureContactSettings`
                /// </summary>
                public class PatchRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.Registration body, string name) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.Registration Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

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
                public virtual RegisterRequest Register(Google.Apis.CloudDomains.v1beta1.Data.RegisterDomainRequest body, string parent)
                {
                    return new RegisterRequest(this.service, body, parent);
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
                public class RegisterRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Register request.</summary>
                    public RegisterRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.RegisterDomainRequest body, string parent) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.RegisterDomainRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "register";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/registrations:register";

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
                /// Renews a recently expired domain. This method can only be called on domains that expired in the
                /// previous 30 days. After the renewal, the new expiration time of the domain is one year after the old
                /// expiration time and you are charged a `yearly_price` for the renewal.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` whish is being renewed, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual RenewDomainRequest RenewDomain(Google.Apis.CloudDomains.v1beta1.Data.RenewDomainRequest body, string registration)
                {
                    return new RenewDomainRequest(this.service, body, registration);
                }

                /// <summary>
                /// Renews a recently expired domain. This method can only be called on domains that expired in the
                /// previous 30 days. After the renewal, the new expiration time of the domain is one year after the old
                /// expiration time and you are charged a `yearly_price` for the renewal.
                /// </summary>
                public class RenewDomainRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new RenewDomain request.</summary>
                    public RenewDomainRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.RenewDomainRequest body, string registration) : base(service)
                    {
                        Registration = registration;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whish is being renewed, in the format
                    /// `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudDomains.v1beta1.Data.RenewDomainRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "renewDomain";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:renewDomain";

                    /// <summary>Initializes RenewDomain parameter list.</summary>
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
                /// Resets the authorization code of the `Registration` to a new random string. You can call this method
                /// only after 60 days have elapsed since the initial domain registration. Domains that have the
                /// `REQUIRE_PUSH_TRANSFER` property in the list of `domain_properties` don't support authorization
                /// codes and must use the `InitiatePushTransfer` method to initiate the process to transfer the domain
                /// to a different registrar.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose authorization code is being reset, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual ResetAuthorizationCodeRequest ResetAuthorizationCode(Google.Apis.CloudDomains.v1beta1.Data.ResetAuthorizationCodeRequest body, string registration)
                {
                    return new ResetAuthorizationCodeRequest(this.service, body, registration);
                }

                /// <summary>
                /// Resets the authorization code of the `Registration` to a new random string. You can call this method
                /// only after 60 days have elapsed since the initial domain registration. Domains that have the
                /// `REQUIRE_PUSH_TRANSFER` property in the list of `domain_properties` don't support authorization
                /// codes and must use the `InitiatePushTransfer` method to initiate the process to transfer the domain
                /// to a different registrar.
                /// </summary>
                public class ResetAuthorizationCodeRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.AuthorizationCode>
                {
                    /// <summary>Constructs a new ResetAuthorizationCode request.</summary>
                    public ResetAuthorizationCodeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.ResetAuthorizationCodeRequest body, string registration) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.ResetAuthorizationCodeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "resetAuthorizationCode";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:resetAuthorizationCode";

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
                /// registration. Domains that have the `REQUIRE_PUSH_TRANSFER` property in the list of
                /// `domain_properties` don't support authorization codes and must use the `InitiatePushTransfer` method
                /// to initiate the process to transfer the domain to a different registrar.
                /// </summary>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose authorization code is being retrieved, in the format
                /// `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual RetrieveAuthorizationCodeRequest RetrieveAuthorizationCode(string registration)
                {
                    return new RetrieveAuthorizationCodeRequest(this.service, registration);
                }

                /// <summary>
                /// Gets the authorization code of the `Registration` for the purpose of transferring the domain to
                /// another registrar. You can call this method only after 60 days have elapsed since the initial domain
                /// registration. Domains that have the `REQUIRE_PUSH_TRANSFER` property in the list of
                /// `domain_properties` don't support authorization codes and must use the `InitiatePushTransfer` method
                /// to initiate the process to transfer the domain to a different registrar.
                /// </summary>
                public class RetrieveAuthorizationCodeRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.AuthorizationCode>
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
                    public override string RestPath => "v1beta1/{+registration}:retrieveAuthorizationCode";

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
                /// Lists the DNS records from the Google Domains DNS zone for domains that use the deprecated
                /// `google_domains_dns` in the `Registration`'s `dns_settings`.
                /// </summary>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose Google Domains DNS records details you are
                /// retrieving, in the format `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual RetrieveGoogleDomainsDnsRecordsRequest RetrieveGoogleDomainsDnsRecords(string registration)
                {
                    return new RetrieveGoogleDomainsDnsRecordsRequest(this.service, registration);
                }

                /// <summary>
                /// Lists the DNS records from the Google Domains DNS zone for domains that use the deprecated
                /// `google_domains_dns` in the `Registration`'s `dns_settings`.
                /// </summary>
                public class RetrieveGoogleDomainsDnsRecordsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.RetrieveGoogleDomainsDnsRecordsResponse>
                {
                    /// <summary>Constructs a new RetrieveGoogleDomainsDnsRecords request.</summary>
                    public RetrieveGoogleDomainsDnsRecordsRequest(Google.Apis.Services.IClientService service, string registration) : base(service)
                    {
                        Registration = registration;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whose Google Domains DNS records details you are
                    /// retrieving, in the format `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Optional. Maximum number of results to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. When set to the `next_page_token` from a prior response, provides the next page of
                    /// results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieveGoogleDomainsDnsRecords";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:retrieveGoogleDomainsDnsRecords";

                    /// <summary>Initializes RetrieveGoogleDomainsDnsRecords parameter list.</summary>
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
                /// Lists the deprecated domain and email forwarding configurations you set up in the deprecated Google
                /// Domains UI. The configuration is present only for domains with the
                /// `google_domains_redirects_data_available` set to `true` in the `Registration`'s `dns_settings`. A
                /// forwarding configuration might not work correctly if required DNS records are not present in the
                /// domain's authoritative DNS Zone.
                /// </summary>
                /// <param name="registration">
                /// Required. The name of the `Registration` whose Google Domains forwarding configuration details are
                /// being retrieved, in the format `projects/*/locations/*/registrations/*`.
                /// </param>
                public virtual RetrieveGoogleDomainsForwardingConfigRequest RetrieveGoogleDomainsForwardingConfig(string registration)
                {
                    return new RetrieveGoogleDomainsForwardingConfigRequest(this.service, registration);
                }

                /// <summary>
                /// Lists the deprecated domain and email forwarding configurations you set up in the deprecated Google
                /// Domains UI. The configuration is present only for domains with the
                /// `google_domains_redirects_data_available` set to `true` in the `Registration`'s `dns_settings`. A
                /// forwarding configuration might not work correctly if required DNS records are not present in the
                /// domain's authoritative DNS Zone.
                /// </summary>
                public class RetrieveGoogleDomainsForwardingConfigRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.RetrieveGoogleDomainsForwardingConfigResponse>
                {
                    /// <summary>Constructs a new RetrieveGoogleDomainsForwardingConfig request.</summary>
                    public RetrieveGoogleDomainsForwardingConfigRequest(Google.Apis.Services.IClientService service, string registration) : base(service)
                    {
                        Registration = registration;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the `Registration` whose Google Domains forwarding configuration details
                    /// are being retrieved, in the format `projects/*/locations/*/registrations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("registration", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Registration { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "retrieveGoogleDomainsForwardingConfig";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+registration}:retrieveGoogleDomainsForwardingConfig";

                    /// <summary>Initializes RetrieveGoogleDomainsForwardingConfig parameter list.</summary>
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
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Lists domain
                /// names from [Google Domains](https://domains.google/) that can be imported to Cloud Domains using the
                /// `ImportDomain` method. Since individual users can own domains in Google Domains, the list of domains
                /// returned depends on the individual user making the call. Domains already managed by Cloud Domains
                /// are not returned.
                /// </summary>
                /// <param name="location">
                /// Required. The location. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual RetrieveImportableDomainsRequest RetrieveImportableDomains(string location)
                {
                    return new RetrieveImportableDomainsRequest(this.service, location);
                }

                /// <summary>
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Lists domain
                /// names from [Google Domains](https://domains.google/) that can be imported to Cloud Domains using the
                /// `ImportDomain` method. Since individual users can own domains in Google Domains, the list of domains
                /// returned depends on the individual user making the call. Domains already managed by Cloud Domains
                /// are not returned.
                /// </summary>
                public class RetrieveImportableDomainsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.RetrieveImportableDomainsResponse>
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
                    public override string RestPath => "v1beta1/{+location}/registrations:retrieveImportableDomains";

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
                    return new RetrieveRegisterParametersRequest(this.service, location);
                }

                /// <summary>
                /// Gets parameters needed to register a new domain name, including price and up-to-date availability.
                /// Use the returned values to call `RegisterDomain`.
                /// </summary>
                public class RetrieveRegisterParametersRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.RetrieveRegisterParametersResponse>
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
                    public override string RestPath => "v1beta1/{+location}/registrations:retrieveRegisterParameters";

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
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Gets
                /// parameters needed to transfer a domain name from another registrar to Cloud Domains. For domains
                /// already managed by [Google Domains](https://domains.google/), use `ImportDomain` instead. Use the
                /// returned values to call `TransferDomain`.
                /// </summary>
                /// <param name="location">
                /// Required. The location. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual RetrieveTransferParametersRequest RetrieveTransferParameters(string location)
                {
                    return new RetrieveTransferParametersRequest(this.service, location);
                }

                /// <summary>
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Gets
                /// parameters needed to transfer a domain name from another registrar to Cloud Domains. For domains
                /// already managed by [Google Domains](https://domains.google/), use `ImportDomain` instead. Use the
                /// returned values to call `TransferDomain`.
                /// </summary>
                public class RetrieveTransferParametersRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.RetrieveTransferParametersResponse>
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
                    public override string RestPath => "v1beta1/{+location}/registrations:retrieveTransferParameters";

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
                    return new SearchDomainsRequest(this.service, location);
                }

                /// <summary>
                /// Searches for available domain names similar to the provided query. Availability results from this
                /// method are approximate; call `RetrieveRegisterParameters` on a domain before registering to confirm
                /// availability.
                /// </summary>
                public class SearchDomainsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.SearchDomainsResponse>
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
                    public override string RestPath => "v1beta1/{+location}/registrations:searchDomains";

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
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudDomains.v1beta1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:setIamPolicy";

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
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudDomains.v1beta1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+resource}:testIamPermissions";

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
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Transfers a
                /// domain name from another registrar to Cloud Domains. For domains already managed by [Google
                /// Domains](https://domains.google/), use `ImportDomain` instead. Before calling this method, go to the
                /// domain's current registrar to unlock the domain for transfer and retrieve the domain's transfer
                /// authorization code. Then call `RetrieveTransferParameters` to confirm that the domain is unlocked
                /// and to get values needed to build a call to this method. A successful call creates a `Registration`
                /// resource in state `TRANSFER_PENDING`. It can take several days to complete the transfer process. The
                /// registrant can often speed up this process by approving the transfer through the current registrar,
                /// either by clicking a link in an email from the registrar or by visiting the registrar's website. A
                /// few minutes after transfer approval, the resource transitions to state `ACTIVE`, indicating that the
                /// transfer was successful. If the transfer is rejected or the request expires without being approved,
                /// the resource can end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete the
                /// resource and retry the transfer.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource of the `Registration`. Must be in the format `projects/*/locations/*`.
                /// </param>
                public virtual TransferRequest Transfer(Google.Apis.CloudDomains.v1beta1.Data.TransferDomainRequest body, string parent)
                {
                    return new TransferRequest(this.service, body, parent);
                }

                /// <summary>
                /// Deprecated: For more information, see [Cloud Domains feature
                /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations) Transfers a
                /// domain name from another registrar to Cloud Domains. For domains already managed by [Google
                /// Domains](https://domains.google/), use `ImportDomain` instead. Before calling this method, go to the
                /// domain's current registrar to unlock the domain for transfer and retrieve the domain's transfer
                /// authorization code. Then call `RetrieveTransferParameters` to confirm that the domain is unlocked
                /// and to get values needed to build a call to this method. A successful call creates a `Registration`
                /// resource in state `TRANSFER_PENDING`. It can take several days to complete the transfer process. The
                /// registrant can often speed up this process by approving the transfer through the current registrar,
                /// either by clicking a link in an email from the registrar or by visiting the registrar's website. A
                /// few minutes after transfer approval, the resource transitions to state `ACTIVE`, indicating that the
                /// transfer was successful. If the transfer is rejected or the request expires without being approved,
                /// the resource can end up in state `TRANSFER_FAILED`. If transfer fails, you can safely delete the
                /// resource and retry the transfer.
                /// </summary>
                public class TransferRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Operation>
                {
                    /// <summary>Constructs a new Transfer request.</summary>
                    public TransferRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudDomains.v1beta1.Data.TransferDomainRequest body, string parent) : base(service)
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
                    Google.Apis.CloudDomains.v1beta1.Data.TransferDomainRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "transfer";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/registrations:transfer";

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
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.Location>
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
                public override string RestPath => "v1beta1/{+name}";

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
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CloudDomainsBaseServiceRequest<Google.Apis.CloudDomains.v1beta1.Data.ListLocationsResponse>
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
                public override string RestPath => "v1beta1/{+name}/locations";

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
namespace Google.Apis.CloudDomains.v1beta1.Data
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
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workforce identity pool. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/group/{group_id}`: All
        /// workforce identities in a group. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All workforce identities with a specific attribute value. *
        /// `principalSet://iam.googleapis.com/locations/global/workforcePools/{pool_id}/*`: All identities in a
        /// workforce identity pool. *
        /// `principal://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/subject/{subject_attribute_value}`:
        /// A single identity in a workload identity pool. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/group/{group_id}`:
        /// A workload identity pool group. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/attribute.{attribute_name}/{attribute_value}`:
        /// All identities in a workload identity pool with a certain attribute. *
        /// `principalSet://iam.googleapis.com/projects/{project_number}/locations/global/workloadIdentityPools/{pool_id}/*`:
        /// All identities in a workload identity pool. * `deleted:user:{emailid}?uid={uniqueid}`: An email address
        /// (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. *
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/{pool_id}/subject/{subject_attribute_value}`:
        /// Deleted single identity in a workforce identity pool. For example,
        /// `deleted:principal://iam.googleapis.com/locations/global/workforcePools/my-pool-id/subject/my-subject-attribute-value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`. For an overview of the IAM roles and permissions, see the [IAM
        /// documentation](https://cloud.google.com/iam/docs/roles-overview). For a list of the available pre-defined
        /// roles, see [here](https://cloud.google.com/iam/docs/understanding-roles).
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

        /// <summary>
        /// Deprecated: For more information, see [Cloud Domains feature
        /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). The free DNS zone
        /// provided by [Google Domains](https://domains.google/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleDomainsDns")]
        public virtual GoogleDomainsDns GoogleDomainsDns { get; set; }

        /// <summary>
        /// Output only. Indicates if this `Registration` has configured one of the following deprecated Google Domains
        /// DNS features: * Domain forwarding (HTTP `301` and `302` response status codes), * Email forwarding. See
        /// https://cloud.google.com/domains/docs/deprecations/feature-deprecations for more details. If any of these
        /// features is enabled call the `RetrieveGoogleDomainsForwardingConfig` method to get details about the
        /// feature's configuration. A forwarding configuration might not work correctly if required DNS records are not
        /// present in the domain's authoritative DNS Zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleDomainsRedirectsDataAvailable")]
        public virtual System.Nullable<bool> GoogleDomainsRedirectsDataAvailable { get; set; }

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

    /// <summary>Domain forwarding configuration.</summary>
    public class DomainForwarding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, forwards the path after the domain name to the same path at the new address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathForwarding")]
        public virtual System.Nullable<bool> PathForwarding { get; set; }

        /// <summary>The PEM-encoded certificate chain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCertificate")]
        public virtual string PemCertificate { get; set; }

        /// <summary>The redirect type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectType")]
        public virtual string RedirectType { get; set; }

        /// <summary>If true, the forwarding works also over HTTPS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslEnabled")]
        public virtual System.Nullable<bool> SslEnabled { get; set; }

        /// <summary>
        /// The subdomain of the registered domain that is being forwarded. E.g. `www.example.com`, `example.com` (i.e.
        /// the registered domain itself) or `*.example.com` (i.e. all subdomains).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subdomain")]
        public virtual string Subdomain { get; set; }

        /// <summary>The target of the domain forwarding, i.e. the path to redirect the `subdomain` to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetUri")]
        public virtual string TargetUri { get; set; }

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

    /// <summary>Email forwarding configuration.</summary>
    public class EmailForwarding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An alias recipient email that forwards emails to the `target_email_address`. For example,
        /// `admin@example.com` or `*@example.com` (wildcard alias forwards all the emails under the registered domain).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>Target email that receives emails sent to the `alias`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetEmailAddress")]
        public virtual string TargetEmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). Request for the
    /// `ExportRegistration` method.
    /// </summary>
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

    /// <summary>Configures a `RRSetRoutingPolicy` that routes based on the geo location of the querying user.</summary>
    public class GeoPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Without fencing, if health check fails for all configured items in the current geo bucket, we failover to
        /// the next nearest geo bucket. With fencing, if health checking is enabled, as long as some targets in the
        /// current geo bucket are healthy, we return only the healthy targets. However, if all targets are unhealthy,
        /// we don't failover to the next nearest bucket; instead, we return all the items in the current bucket even
        /// when all targets are unhealthy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFencing")]
        public virtual System.Nullable<bool> EnableFencing { get; set; }

        /// <summary>
        /// The primary geo routing configuration. If there are multiple items with the same location, an error is
        /// returned instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual System.Collections.Generic.IList<GeoPolicyItem> Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRecordSet data for one geo location.</summary>
    public class GeoPolicyItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For A and AAAA types only. Endpoints to return in the query result only if they are healthy. These can be
        /// specified along with `rrdata` within this item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckedTargets")]
        public virtual HealthCheckTargets HealthCheckedTargets { get; set; }

        /// <summary>
        /// The geo-location granularity is a GCP region. This location string should correspond to a GCP region. e.g.
        /// "us-east1", "southamerica-east1", "asia-east1", etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("rrdata")]
        public virtual System.Collections.Generic.IList<string> Rrdata { get; set; }

        /// <summary>
        /// DNSSEC generated signatures for all the `rrdata` within this item. When using health-checked targets for
        /// DNSSEC-enabled zones, you can only use at most one health-checked IP address per item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureRrdata")]
        public virtual System.Collections.Generic.IList<string> SignatureRrdata { get; set; }

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
    /// Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). Configuration for using
    /// the free DNS zone provided by Google Domains as a `Registration`'s `dns_provider`. You cannot configure the DNS
    /// zone itself using the API. To configure the DNS zone, go to [Google Domains](https://domains.google/).
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

    /// <summary>
    /// HealthCheckTargets describes endpoints to health-check when responding to Routing Policy queries. Only the
    /// healthy endpoints will be included in the response. Set either `internal_load_balancer` or `external_endpoints`.
    /// Do not set both.
    /// </summary>
    public class HealthCheckTargets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Internet IP addresses to be health checked. The format matches the format of ResourceRecordSet.rrdata as
        /// defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalEndpoints")]
        public virtual System.Collections.Generic.IList<string> ExternalEndpoints { get; set; }

        /// <summary>Configuration for internal load balancers to be health checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalLoadBalancer")]
        public virtual System.Collections.Generic.IList<LoadBalancerTarget> InternalLoadBalancer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). Request for the
    /// `ImportDomain` method.
    /// </summary>
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

    /// <summary>Request for the `InitiatePushTransfer` method.</summary>
    public class InitiatePushTransferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Tag of the new registrar. Can be found at [List of
        /// registrars](https://nominet.uk/registrar-list/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

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

    /// <summary>The configuration for an individual load balancer to health check.</summary>
    public class LoadBalancerTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The frontend IP address of the load balancer to health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>The protocol of the load balancer to health check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipProtocol")]
        public virtual string IpProtocol { get; set; }

        /// <summary>
        /// The type of load balancer specified by this target. This value must match the configuration of the load
        /// balancer located at the LoadBalancerTarget's IP address, port, and region. Use the following: -
        /// *regionalL4ilb*: for a regional internal passthrough Network Load Balancer. - *regionalL7ilb*: for a
        /// regional internal Application Load Balancer. - *globalL7ilb*: for a global internal Application Load
        /// Balancer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadBalancerType")]
        public virtual string LoadBalancerType { get; set; }

        /// <summary>
        /// The fully qualified URL of the network that the load balancer is attached to. This should be formatted like
        /// `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUrl")]
        public virtual string NetworkUrl { get; set; }

        /// <summary>The configured port of the load balancer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual string Port { get; set; }

        /// <summary>The project ID in which the load balancer is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The region in which the load balancer is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents a Google Cloud location.</summary>
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
        /// <summary>Output only. The actual transfer lock state for this `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveTransferLockState")]
        public virtual string EffectiveTransferLockState { get; set; }

        /// <summary>
        /// Optional. The desired renewal method for this `Registration`. The actual `renewal_method` is automatically
        /// updated to reflect this choice. If unset or equal to `RENEWAL_METHOD_UNSPECIFIED`, the actual
        /// `renewalMethod` is treated as if it were set to `AUTOMATIC_RENEWAL`. You cannot use `RENEWAL_DISABLED`
        /// during resource creation, and you can update the renewal status only when the `Registration` resource has
        /// state `ACTIVE` or `SUSPENDED`. When `preferred_renewal_method` is set to `AUTOMATIC_RENEWAL`, the actual
        /// `renewal_method` can be set to `RENEWAL_DISABLED` in case of problems with the billing account or reported
        /// domain abuse. In such cases, check the `issues` field on the `Registration`. After the problem is resolved,
        /// the `renewal_method` is automatically updated to `preferred_renewal_method` in a few hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredRenewalMethod")]
        public virtual string PreferredRenewalMethod { get; set; }

        /// <summary>
        /// Output only. The actual renewal method for this `Registration`. When `preferred_renewal_method` is set to
        /// `AUTOMATIC_RENEWAL`, the actual `renewal_method` can be equal to `RENEWAL_DISABLED`—for example, when there
        /// are problems with the billing account or reported domain abuse. In such cases, check the `issues` field on
        /// the `Registration`. After the problem is resolved, the `renewal_method` is automatically updated to
        /// `preferred_renewal_method` in a few hours.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalMethod")]
        public virtual string RenewalMethod { get; set; }

        /// <summary>
        /// This is the desired transfer lock state for this `Registration`. A transfer lock controls whether the domain
        /// can be transferred to another registrar. The transfer lock state of the domain is returned in the
        /// `effective_transfer_lock_state` property. The transfer lock state values might be different for the
        /// following reasons: * `transfer_lock_state` was updated only a short time ago. * Domains with the
        /// `TRANSFER_LOCK_UNSUPPORTED_BY_REGISTRY` state are in the list of `domain_properties`. These domains are
        /// always in the `UNLOCKED` state.
        /// </summary>
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
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time the operation was created.</summary>
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

        /// <summary>The time the operation finished running.</summary>
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
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:**
    /// ```
    /// {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 }
    /// ```
    /// **YAML
    /// example:**
    /// ```
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3
    /// ```
    /// For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
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
    /// Represents a postal address. For example for postal delivery or payments addresses. Given a postal address, a
    /// postal service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical
    /// locations (roads, towns, mountains). In typical usage an address would be created by user input or from
    /// importing existing data, depending on the type of process. Advice on address input / editing: - Use an
    /// internationalization-ready address widget such as https://github.com/google/libaddressinput) - Users should not
    /// be presented with UI elements for input or editing of fields outside countries where that field is used. For
    /// more guidance on how to use this schema, see: https://support.google.com/business/answer/6397478
    /// </summary>
    public class PostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unstructured address lines describing the lower levels of an address. Because values in address_lines do not
        /// have type information and may sometimes contain multiple values in a single field (For example "Austin,
        /// TX"), it is important that the line order is clear. The order of address lines should be "envelope order"
        /// for the country/region of the address. In places where this can vary (For example Japan), address_language
        /// is used to make it explicit (For example "ja" for large-to-small ordering and "ja-Latn" or "en" for
        /// small-to-large). This way, the most specific line of an address can be selected based on the language. The
        /// minimum permitted structural representation of an address consists of a region_code with all remaining
        /// information placed in the address_lines. It would be possible to format such an address very approximately
        /// without geocoding, but no semantic reasoning could be made about any of the address components until it was
        /// at least partially resolved. Creating an address only containing a region_code and address_lines, and then
        /// geocoding is the recommended way to handle completely unstructured addresses (as opposed to guessing which
        /// parts of the address should be localities or administrative areas).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For
        /// example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the
        /// province and not the autonomous community (For example "Barcelona" and not "Catalonia"). Many countries
        /// don't use an administrative area in postal addresses. For example in Switzerland this should be left
        /// unpopulated.
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
        /// they are used, they may trigger additional validation with other parts of the address (For example state/zip
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
        /// the value is either a string like "CEDEX", optionally followed by a number (For example "CEDEX 7"), or just
        /// a number alone, representing the "sector code" (Jamaica), "delivery area indicator" (Malawi) or "post office
        /// indicator" (For example Côte d'Ivoire).
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

    /// <summary>
    /// Configures a RRSetRoutingPolicy such that all queries are responded with the primary_targets if they are
    /// healthy. And if all of them are unhealthy, then we fallback to a geo localized policy.
    /// </summary>
    public class PrimaryBackupPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Backup targets provide a regional failover policy for the otherwise global primary targets. If serving state
        /// is set to `BACKUP`, this policy essentially becomes a geo routing policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backupGeoTargets")]
        public virtual GeoPolicy BackupGeoTargets { get; set; }

        /// <summary>
        /// Endpoints that are health checked before making the routing decision. Unhealthy endpoints are omitted from
        /// the results. If all endpoints are unhealthy, we serve a response based on the `backup_geo_targets`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTargets")]
        public virtual HealthCheckTargets PrimaryTargets { get; set; }

        /// <summary>
        /// When serving state is `PRIMARY`, this field provides the option of sending a small percentage of the traffic
        /// to the backup targets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trickleTraffic")]
        public virtual System.Nullable<double> TrickleTraffic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A RRSetRoutingPolicy represents ResourceRecordSet data that is returned dynamically with the response varying
    /// based on configured properties such as geolocation or by weighted random selection.
    /// </summary>
    public class RRSetRoutingPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("geo")]
        public virtual GeoPolicy Geo { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("geoPolicy")]
        public virtual GeoPolicy GeoPolicy { get; set; }

        /// <summary>
        /// The fully qualified URL of the HealthCheck to use for this RRSetRoutingPolicy. Format this URL like
        /// `https://www.googleapis.com/compute/v1/projects/{project}/global/healthChecks/{healthCheck}`.
        /// https://cloud.google.com/compute/docs/reference/rest/v1/healthChecks
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheck")]
        public virtual string HealthCheck { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("primaryBackup")]
        public virtual PrimaryBackupPolicy PrimaryBackup { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("wrr")]
        public virtual WrrPolicy Wrr { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("wrrPolicy")]
        public virtual WrrPolicy WrrPolicy { get; set; }

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
    /// existing domain from another registrar (Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations)). First, go to the current
    /// registrar to unlock the domain for transfer and retrieve the domain's transfer authorization code. Then call
    /// `RetrieveTransferParameters` to confirm that the domain is unlocked and to get values needed to build a call to
    /// `TransferDomain`. Finally, you can create a new `Registration` by importing an existing domain managed with
    /// [Google Domains](https://domains.google/) (Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations)). First, call
    /// `RetrieveImportableDomains` to list domains to which the calling user has sufficient access. Then call
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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The creation timestamp of the `Registration` resource.</summary>
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

        /// <summary>Output only. Special properties of the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainProperties")]
        public virtual System.Collections.Generic.IList<string> DomainProperties { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Output only. The expiration timestamp of the `Registration`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
        /// Output only. Deprecated: For more information, see [Cloud Domains feature
        /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). The reason the domain
        /// transfer failed. Only set for domains in TRANSFER_FAILED state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferFailureReason")]
        public virtual string TransferFailureReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `RenewDomain` method.</summary>
    public class RenewDomainRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When true, only validation is performed, without actually renewing the domain. For more
        /// information, see [Request
        /// validation](https://cloud.google.com/apis/design/design_patterns#request_validation)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>
        /// Required. Acknowledgement of the price to renew the domain for one year. To get the price, see [Cloud
        /// Domains pricing](https://cloud.google.com/domains/pricing). If not provided, the expected price is returned
        /// in the error message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yearlyPrice")]
        public virtual Money YearlyPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `ResetAuthorizationCode` method.</summary>
    public class ResetAuthorizationCodeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A unit of data that is returned by the DNS servers.</summary>
    public class ResourceRecordSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For example, www.example.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Configures dynamic query responses based on either the geo location of the querying user or a weighted round
        /// robin based routing policy. A valid `ResourceRecordSet` contains only `rrdata` (for static resolution) or a
        /// `routing_policy` (for dynamic resolution).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routingPolicy")]
        public virtual RRSetRoutingPolicy RoutingPolicy { get; set; }

        /// <summary>As defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1) -- see examples.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrdata")]
        public virtual System.Collections.Generic.IList<string> Rrdata { get; set; }

        /// <summary>As defined in RFC 4034 (section 3.2).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureRrdata")]
        public virtual System.Collections.Generic.IList<string> SignatureRrdata { get; set; }

        /// <summary>Number of seconds that this `ResourceRecordSet` can be cached by resolvers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual System.Nullable<int> Ttl { get; set; }

        /// <summary>The identifier of a supported record type. See the list of Supported DNS record types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `RetrieveGoogleDomainsDnsRecords` method.</summary>
    public class RetrieveGoogleDomainsDnsRecordsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When present, there are more results to retrieve. Set `page_token` to this value on a subsequent call to get
        /// the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resource record set resources (DNS Zone records).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrset")]
        public virtual System.Collections.Generic.IList<ResourceRecordSet> Rrset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `RetrieveGoogleDomainsForwardingConfig` method.</summary>
    public class RetrieveGoogleDomainsForwardingConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of domain forwarding configurations. A forwarding configuration might not work correctly if the
        /// required DNS records are not present in the domain's authoritative DNS zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainForwardings")]
        public virtual System.Collections.Generic.IList<DomainForwarding> DomainForwardings { get; set; }

        /// <summary>
        /// The list of email forwarding configurations. A forwarding configuration might not work correctly if the
        /// required DNS records are not present in the domain's authoritative DNS zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailForwardings")]
        public virtual System.Collections.Generic.IList<EmailForwarding> EmailForwardings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). Response for the
    /// `RetrieveImportableDomains` method.
    /// </summary>
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

    /// <summary>
    /// Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). Response for the
    /// `RetrieveTransferParameters` method.
    /// </summary>
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

    /// <summary>
    /// Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). Request for the
    /// `TransferDomain` method.
    /// </summary>
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

    /// <summary>
    /// Deprecated: For more information, see [Cloud Domains feature
    /// deprecation](https://cloud.google.com/domains/docs/deprecations/feature-deprecations). Parameters required to
    /// transfer a domain from another registrar.
    /// </summary>
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

    /// <summary>Configures a RRSetRoutingPolicy that routes in a weighted round robin fashion.</summary>
    public class WrrPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual System.Collections.Generic.IList<WrrPolicyItem> Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A routing block which contains the routing information for one WRR item.</summary>
    public class WrrPolicyItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Endpoints that are health checked before making the routing decision. The unhealthy endpoints are omitted
        /// from the result. If all endpoints within a bucket are unhealthy, we choose a different bucket (sampled with
        /// respect to its weight) for responding. If DNSSEC is enabled for this zone, only one of `rrdata` or
        /// `health_checked_targets` can be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheckedTargets")]
        public virtual HealthCheckTargets HealthCheckedTargets { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("rrdata")]
        public virtual System.Collections.Generic.IList<string> Rrdata { get; set; }

        /// <summary>
        /// DNSSEC generated signatures for all the `rrdata` within this item. When using health-checked targets for
        /// DNSSEC-enabled zones, you can only use at most one health-checked IP address per item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureRrdata")]
        public virtual System.Collections.Generic.IList<string> SignatureRrdata { get; set; }

        /// <summary>
        /// The weight corresponding to this `WrrPolicyItem` object. When multiple `WrrPolicyItem` objects are
        /// configured, the probability of returning an `WrrPolicyItem` object's data is proportional to its weight
        /// relative to the sum of weights configured for all items. This weight must be non-negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<double> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
