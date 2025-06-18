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

namespace Google.Apis.Appengine.v1beta
{
    /// <summary>The Appengine Service.</summary>
    public class AppengineService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AppengineService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AppengineService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Apps = new AppsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://appengine.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://appengine.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "appengine";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the App Engine Admin API.</summary>
        public class Scope
        {
            /// <summary>View and manage your applications deployed on Google App Engine</summary>
            public static string AppengineAdmin = "https://www.googleapis.com/auth/appengine.admin";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the App Engine Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your applications deployed on Google App Engine</summary>
            public const string AppengineAdmin = "https://www.googleapis.com/auth/appengine.admin";

            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>
            /// View your data across Google Cloud services and see the email address of your Google Account
            /// </summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Appengine requests.</summary>
    public abstract class AppengineBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AppengineBaseServiceRequest instance.</summary>
        protected AppengineBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Appengine parameter list.</summary>
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

    /// <summary>The "apps" collection of methods.</summary>
    public class AppsResource
    {
        private const string Resource = "apps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AppsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AuthorizedCertificates = new AuthorizedCertificatesResource(service);
            AuthorizedDomains = new AuthorizedDomainsResource(service);
            DomainMappings = new DomainMappingsResource(service);
            Firewall = new FirewallResource(service);
            Locations = new LocationsResource(service);
            Operations = new OperationsResource(service);
            Services = new ServicesResource(service);
        }

        /// <summary>Gets the AuthorizedCertificates resource.</summary>
        public virtual AuthorizedCertificatesResource AuthorizedCertificates { get; }

        /// <summary>The "authorizedCertificates" collection of methods.</summary>
        public class AuthorizedCertificatesResource
        {
            private const string Resource = "authorizedCertificates";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AuthorizedCertificatesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Uploads the specified SSL certificate.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="appsId">
            /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string appsId)
            {
                return new CreateRequest(this.service, body, appsId);
            }

            /// <summary>Uploads the specified SSL certificate.</summary>
            public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string appsId) : base(service)
                {
                    AppsId = appsId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/authorizedCertificates";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes the specified SSL certificate.</summary>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource to delete. Example: apps/myapp/authorizedCertificates/12345.
            /// </param>
            /// <param name="authorizedCertificatesId">Part of `name`. See documentation of `appsId`.</param>
            public virtual DeleteRequest Delete(string appsId, string authorizedCertificatesId)
            {
                return new DeleteRequest(this.service, appsId, authorizedCertificatesId);
            }

            /// <summary>Deletes the specified SSL certificate.</summary>
            public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string appsId, string authorizedCertificatesId) : base(service)
                {
                    AppsId = appsId;
                    AuthorizedCertificatesId = authorizedCertificatesId;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource to delete. Example: apps/myapp/authorizedCertificates/12345.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("authorizedCertificatesId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AuthorizedCertificatesId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/authorizedCertificates/{authorizedCertificatesId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("authorizedCertificatesId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "authorizedCertificatesId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the specified SSL certificate.</summary>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource requested. Example: apps/myapp/authorizedCertificates/12345.
            /// </param>
            /// <param name="authorizedCertificatesId">Part of `name`. See documentation of `appsId`.</param>
            public virtual GetRequest Get(string appsId, string authorizedCertificatesId)
            {
                return new GetRequest(this.service, appsId, authorizedCertificatesId);
            }

            /// <summary>Gets the specified SSL certificate.</summary>
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string appsId, string authorizedCertificatesId) : base(service)
                {
                    AppsId = appsId;
                    AuthorizedCertificatesId = authorizedCertificatesId;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource requested. Example: apps/myapp/authorizedCertificates/12345.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("authorizedCertificatesId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AuthorizedCertificatesId { get; private set; }

                /// <summary>Controls the set of fields returned in the GET response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Controls the set of fields returned in the GET response.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// Basic certificate information, including applicable domains and expiration date.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC_CERTIFICATE")]
                    BASICCERTIFICATE = 0,

                    /// <summary>
                    /// The information from BASIC_CERTIFICATE, plus detailed information on the domain mappings that
                    /// have this certificate mapped.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL_CERTIFICATE")]
                    FULLCERTIFICATE = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/authorizedCertificates/{authorizedCertificatesId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("authorizedCertificatesId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "authorizedCertificatesId",
                        IsRequired = true,
                        ParameterType = "path",
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

            /// <summary>Lists all SSL certificates the user is authorized to administer.</summary>
            /// <param name="appsId">
            /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
            /// </param>
            public virtual ListRequest List(string appsId)
            {
                return new ListRequest(this.service, appsId);
            }

            /// <summary>Lists all SSL certificates the user is authorized to administer.</summary>
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListAuthorizedCertificatesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
                {
                    AppsId = appsId;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Maximum results to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Controls the set of fields returned in the LIST response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Controls the set of fields returned in the LIST response.</summary>
                public enum ViewEnum
                {
                    /// <summary>
                    /// Basic certificate information, including applicable domains and expiration date.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC_CERTIFICATE")]
                    BASICCERTIFICATE = 0,

                    /// <summary>
                    /// The information from BASIC_CERTIFICATE, plus detailed information on the domain mappings that
                    /// have this certificate mapped.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FULL_CERTIFICATE")]
                    FULLCERTIFICATE = 1,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/authorizedCertificates";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
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
            /// Updates the specified SSL certificate. To renew a certificate and maintain its existing domain mappings,
            /// update certificate_data with a new certificate. The new certificate must be applicable to the same
            /// domains as the original certificate. The certificate display_name may also be updated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource to update. Example: apps/myapp/authorizedCertificates/12345.
            /// </param>
            /// <param name="authorizedCertificatesId">Part of `name`. See documentation of `appsId`.</param>
            public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string appsId, string authorizedCertificatesId)
            {
                return new PatchRequest(this.service, body, appsId, authorizedCertificatesId);
            }

            /// <summary>
            /// Updates the specified SSL certificate. To renew a certificate and maintain its existing domain mappings,
            /// update certificate_data with a new certificate. The new certificate must be applicable to the same
            /// domains as the original certificate. The certificate display_name may also be updated.
            /// </summary>
            public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string appsId, string authorizedCertificatesId) : base(service)
                {
                    AppsId = appsId;
                    AuthorizedCertificatesId = authorizedCertificatesId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource to update. Example: apps/myapp/authorizedCertificates/12345.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("authorizedCertificatesId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AuthorizedCertificatesId { get; private set; }

                /// <summary>
                /// Standard field mask for the set of fields to be updated. Updates are only supported on the
                /// certificate_raw_data and display_name fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/authorizedCertificates/{authorizedCertificatesId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("authorizedCertificatesId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "authorizedCertificatesId",
                        IsRequired = true,
                        ParameterType = "path",
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

        /// <summary>Gets the AuthorizedDomains resource.</summary>
        public virtual AuthorizedDomainsResource AuthorizedDomains { get; }

        /// <summary>The "authorizedDomains" collection of methods.</summary>
        public class AuthorizedDomainsResource
        {
            private const string Resource = "authorizedDomains";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AuthorizedDomainsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists all domains the user is authorized to administer.</summary>
            /// <param name="appsId">
            /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
            /// </param>
            public virtual ListRequest List(string appsId)
            {
                return new ListRequest(this.service, appsId);
            }

            /// <summary>Lists all domains the user is authorized to administer.</summary>
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListAuthorizedDomainsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
                {
                    AppsId = appsId;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Maximum results to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/authorizedDomains";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
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

        /// <summary>Gets the DomainMappings resource.</summary>
        public virtual DomainMappingsResource DomainMappings { get; }

        /// <summary>The "domainMappings" collection of methods.</summary>
        public class DomainMappingsResource
        {
            private const string Resource = "domainMappings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DomainMappingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Maps a domain to an application. A user must be authorized to administer a domain in order to map it to
            /// an application. For a list of available authorized domains, see AuthorizedDomains.ListAuthorizedDomains.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="appsId">
            /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Appengine.v1beta.Data.DomainMapping body, string appsId)
            {
                return new CreateRequest(this.service, body, appsId);
            }

            /// <summary>
            /// Maps a domain to an application. A user must be authorized to administer a domain in order to map it to
            /// an application. For a list of available authorized domains, see AuthorizedDomains.ListAuthorizedDomains.
            /// </summary>
            public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.DomainMapping body, string appsId) : base(service)
                {
                    AppsId = appsId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>
                /// Whether the domain creation should override any existing mappings for this domain. By default,
                /// overrides are rejected.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("overrideStrategy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<OverrideStrategyEnum> OverrideStrategy { get; set; }

                /// <summary>
                /// Whether the domain creation should override any existing mappings for this domain. By default,
                /// overrides are rejected.
                /// </summary>
                public enum OverrideStrategyEnum
                {
                    /// <summary>Strategy unspecified. Defaults to STRICT.</summary>
                    [Google.Apis.Util.StringValueAttribute("UNSPECIFIED_DOMAIN_OVERRIDE_STRATEGY")]
                    UNSPECIFIEDDOMAINOVERRIDESTRATEGY = 0,

                    /// <summary>
                    /// Overrides not allowed. If a mapping already exists for the specified domain, the request will
                    /// return an ALREADY_EXISTS (409).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("STRICT")]
                    STRICT = 1,

                    /// <summary>
                    /// Overrides allowed. If a mapping already exists for the specified domain, the request will
                    /// overwrite it. Note that this might stop another Google product from serving. For example, if the
                    /// domain is mapped to another App Engine application, that app will no longer serve from that
                    /// domain.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("OVERRIDE")]
                    OVERRIDE__ = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Appengine.v1beta.Data.DomainMapping Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/domainMappings";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("overrideStrategy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "overrideStrategy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes the specified domain mapping. A user must be authorized to administer the associated domain in
            /// order to delete a DomainMapping resource.
            /// </summary>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource to delete. Example: apps/myapp/domainMappings/example.com.
            /// </param>
            /// <param name="domainMappingsId">Part of `name`. See documentation of `appsId`.</param>
            public virtual DeleteRequest Delete(string appsId, string domainMappingsId)
            {
                return new DeleteRequest(this.service, appsId, domainMappingsId);
            }

            /// <summary>
            /// Deletes the specified domain mapping. A user must be authorized to administer the associated domain in
            /// order to delete a DomainMapping resource.
            /// </summary>
            public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string appsId, string domainMappingsId) : base(service)
                {
                    AppsId = appsId;
                    DomainMappingsId = domainMappingsId;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource to delete. Example: apps/myapp/domainMappings/example.com.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("domainMappingsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DomainMappingsId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/domainMappings/{domainMappingsId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("domainMappingsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domainMappingsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the specified domain mapping.</summary>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource requested. Example: apps/myapp/domainMappings/example.com.
            /// </param>
            /// <param name="domainMappingsId">Part of `name`. See documentation of `appsId`.</param>
            public virtual GetRequest Get(string appsId, string domainMappingsId)
            {
                return new GetRequest(this.service, appsId, domainMappingsId);
            }

            /// <summary>Gets the specified domain mapping.</summary>
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.DomainMapping>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string appsId, string domainMappingsId) : base(service)
                {
                    AppsId = appsId;
                    DomainMappingsId = domainMappingsId;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource requested. Example: apps/myapp/domainMappings/example.com.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("domainMappingsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DomainMappingsId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/domainMappings/{domainMappingsId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("domainMappingsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domainMappingsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists the domain mappings on an application.</summary>
            /// <param name="appsId">
            /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
            /// </param>
            public virtual ListRequest List(string appsId)
            {
                return new ListRequest(this.service, appsId);
            }

            /// <summary>Lists the domain mappings on an application.</summary>
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListDomainMappingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
                {
                    AppsId = appsId;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Maximum results to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/domainMappings";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
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
            /// Updates the specified domain mapping. To map an SSL certificate to a domain mapping, update
            /// certificate_id to point to an AuthorizedCertificate resource. A user must be authorized to administer
            /// the associated domain in order to update a DomainMapping resource.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource to update. Example: apps/myapp/domainMappings/example.com.
            /// </param>
            /// <param name="domainMappingsId">Part of `name`. See documentation of `appsId`.</param>
            public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.DomainMapping body, string appsId, string domainMappingsId)
            {
                return new PatchRequest(this.service, body, appsId, domainMappingsId);
            }

            /// <summary>
            /// Updates the specified domain mapping. To map an SSL certificate to a domain mapping, update
            /// certificate_id to point to an AuthorizedCertificate resource. A user must be authorized to administer
            /// the associated domain in order to update a DomainMapping resource.
            /// </summary>
            public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.DomainMapping body, string appsId, string domainMappingsId) : base(service)
                {
                    AppsId = appsId;
                    DomainMappingsId = domainMappingsId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource to update. Example: apps/myapp/domainMappings/example.com.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("domainMappingsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DomainMappingsId { get; private set; }

                /// <summary>Required. Standard field mask for the set of fields to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Appengine.v1beta.Data.DomainMapping Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/domainMappings/{domainMappingsId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("domainMappingsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domainMappingsId",
                        IsRequired = true,
                        ParameterType = "path",
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

        /// <summary>Gets the Firewall resource.</summary>
        public virtual FirewallResource Firewall { get; }

        /// <summary>The "firewall" collection of methods.</summary>
        public class FirewallResource
        {
            private const string Resource = "firewall";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FirewallResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                IngressRules = new IngressRulesResource(service);
            }

            /// <summary>Gets the IngressRules resource.</summary>
            public virtual IngressRulesResource IngressRules { get; }

            /// <summary>The "ingressRules" collection of methods.</summary>
            public class IngressRulesResource
            {
                private const string Resource = "ingressRules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IngressRulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Replaces the entire firewall ruleset in one bulk operation. This overrides and replaces the rules of
                /// an existing firewall with the new rules.If the final rule does not match traffic with the '*'
                /// wildcard IP range, then an "allow all" rule is explicitly added to the end of the list.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="appsId">
                /// Part of `name`. Name of the Firewall collection to set. Example: apps/myapp/firewall/ingressRules.
                /// </param>
                public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Appengine.v1beta.Data.BatchUpdateIngressRulesRequest body, string appsId)
                {
                    return new BatchUpdateRequest(this.service, body, appsId);
                }

                /// <summary>
                /// Replaces the entire firewall ruleset in one bulk operation. This overrides and replaces the rules of
                /// an existing firewall with the new rules.If the final rule does not match traffic with the '*'
                /// wildcard IP range, then an "allow all" rule is explicitly added to the end of the list.
                /// </summary>
                public class BatchUpdateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.BatchUpdateIngressRulesResponse>
                {
                    /// <summary>Constructs a new BatchUpdate request.</summary>
                    public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.BatchUpdateIngressRulesRequest body, string appsId) : base(service)
                    {
                        AppsId = appsId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the Firewall collection to set. Example:
                    /// apps/myapp/firewall/ingressRules.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Appengine.v1beta.Data.BatchUpdateIngressRulesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchUpdate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/firewall/ingressRules:batchUpdate";

                    /// <summary>Initializes BatchUpdate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Creates a firewall rule for the application.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="appsId">
                /// Part of `parent`. Name of the parent Firewall collection in which to create a new rule. Example:
                /// apps/myapp/firewall/ingressRules.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Appengine.v1beta.Data.FirewallRule body, string appsId)
                {
                    return new CreateRequest(this.service, body, appsId);
                }

                /// <summary>Creates a firewall rule for the application.</summary>
                public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.FirewallRule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.FirewallRule body, string appsId) : base(service)
                    {
                        AppsId = appsId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `parent`. Name of the parent Firewall collection in which to create a new rule. Example:
                    /// apps/myapp/firewall/ingressRules.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Appengine.v1beta.Data.FirewallRule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/firewall/ingressRules";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes the specified firewall rule.</summary>
                /// <param name="appsId">
                /// Part of `name`. Name of the Firewall resource to delete. Example:
                /// apps/myapp/firewall/ingressRules/100.
                /// </param>
                /// <param name="ingressRulesId">Part of `name`. See documentation of `appsId`.</param>
                public virtual DeleteRequest Delete(string appsId, string ingressRulesId)
                {
                    return new DeleteRequest(this.service, appsId, ingressRulesId);
                }

                /// <summary>Deletes the specified firewall rule.</summary>
                public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string appsId, string ingressRulesId) : base(service)
                    {
                        AppsId = appsId;
                        IngressRulesId = ingressRulesId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the Firewall resource to delete. Example:
                    /// apps/myapp/firewall/ingressRules/100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("ingressRulesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string IngressRulesId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/firewall/ingressRules/{ingressRulesId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ingressRulesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ingressRulesId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the specified firewall rule.</summary>
                /// <param name="appsId">
                /// Part of `name`. Name of the Firewall resource to retrieve. Example:
                /// apps/myapp/firewall/ingressRules/100.
                /// </param>
                /// <param name="ingressRulesId">Part of `name`. See documentation of `appsId`.</param>
                public virtual GetRequest Get(string appsId, string ingressRulesId)
                {
                    return new GetRequest(this.service, appsId, ingressRulesId);
                }

                /// <summary>Gets the specified firewall rule.</summary>
                public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.FirewallRule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string appsId, string ingressRulesId) : base(service)
                    {
                        AppsId = appsId;
                        IngressRulesId = ingressRulesId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the Firewall resource to retrieve. Example:
                    /// apps/myapp/firewall/ingressRules/100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("ingressRulesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string IngressRulesId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/firewall/ingressRules/{ingressRulesId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ingressRulesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ingressRulesId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists the firewall rules of an application.</summary>
                /// <param name="appsId">
                /// Part of `parent`. Name of the Firewall collection to retrieve. Example:
                /// apps/myapp/firewall/ingressRules.
                /// </param>
                public virtual ListRequest List(string appsId)
                {
                    return new ListRequest(this.service, appsId);
                }

                /// <summary>Lists the firewall rules of an application.</summary>
                public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListIngressRulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
                    {
                        AppsId = appsId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `parent`. Name of the Firewall collection to retrieve. Example:
                    /// apps/myapp/firewall/ingressRules.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>
                    /// A valid IP Address. If set, only rules matching this address will be returned. The first
                    /// returned rule will be the rule that fires on requests from this IP.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("matchingAddress", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string MatchingAddress { get; set; }

                    /// <summary>Maximum results to return per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Continuation token for fetching the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/firewall/ingressRules";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("matchingAddress", new Google.Apis.Discovery.Parameter
                        {
                            Name = "matchingAddress",
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

                /// <summary>Updates the specified firewall rule.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="appsId">
                /// Part of `name`. Name of the Firewall resource to update. Example:
                /// apps/myapp/firewall/ingressRules/100.
                /// </param>
                /// <param name="ingressRulesId">Part of `name`. See documentation of `appsId`.</param>
                public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.FirewallRule body, string appsId, string ingressRulesId)
                {
                    return new PatchRequest(this.service, body, appsId, ingressRulesId);
                }

                /// <summary>Updates the specified firewall rule.</summary>
                public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.FirewallRule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.FirewallRule body, string appsId, string ingressRulesId) : base(service)
                    {
                        AppsId = appsId;
                        IngressRulesId = ingressRulesId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the Firewall resource to update. Example:
                    /// apps/myapp/firewall/ingressRules/100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("ingressRulesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string IngressRulesId { get; private set; }

                    /// <summary>Standard field mask for the set of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Appengine.v1beta.Data.FirewallRule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/firewall/ingressRules/{ingressRulesId}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("ingressRulesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ingressRulesId",
                            IsRequired = true,
                            ParameterType = "path",
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
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="appsId">Part of `name`. Resource name for the location.</param>
            /// <param name="locationsId">Part of `name`. See documentation of `appsId`.</param>
            public virtual GetRequest Get(string appsId, string locationsId)
            {
                return new GetRequest(this.service, appsId, locationsId);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string appsId, string locationsId) : base(service)
                {
                    AppsId = appsId;
                    LocationsId = locationsId;
                    InitParameters();
                }

                /// <summary>Part of `name`. Resource name for the location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LocationsId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/locations/{locationsId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="appsId">
            /// Part of `name`. The resource that owns the locations collection, if applicable.
            /// </param>
            public virtual ListRequest List(string appsId)
            {
                return new ListRequest(this.service, appsId);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
                {
                    AppsId = appsId;
                    InitParameters();
                }

                /// <summary>Part of `name`. The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the next_page_token field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/locations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("extraLocationTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "extraLocationTypes",
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
            /// <param name="appsId">Part of `name`. The name of the operation resource.</param>
            /// <param name="operationsId">Part of `name`. See documentation of `appsId`.</param>
            public virtual GetRequest Get(string appsId, string operationsId)
            {
                return new GetRequest(this.service, appsId, operationsId);
            }

            /// <summary>
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string appsId, string operationsId) : base(service)
                {
                    AppsId = appsId;
                    OperationsId = operationsId;
                    InitParameters();
                }

                /// <summary>Part of `name`. The name of the operation resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("operationsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string OperationsId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/operations/{operationsId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("operationsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "operationsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns UNIMPLEMENTED.
            /// </summary>
            /// <param name="appsId">Part of `name`. The name of the operation's parent resource.</param>
            public virtual ListRequest List(string appsId)
            {
                return new ListRequest(this.service, appsId);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns UNIMPLEMENTED.
            /// </summary>
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListOperationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
                {
                    AppsId = appsId;
                    InitParameters();
                }

                /// <summary>Part of `name`. The name of the operation's parent resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

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
                public override string RestPath => "v1beta/apps/{appsId}/operations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
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

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }

        /// <summary>The "services" collection of methods.</summary>
        public class ServicesResource
        {
            private const string Resource = "services";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServicesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Versions = new VersionsResource(service);
            }

            /// <summary>Gets the Versions resource.</summary>
            public virtual VersionsResource Versions { get; }

            /// <summary>The "versions" collection of methods.</summary>
            public class VersionsResource
            {
                private const string Resource = "versions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VersionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Instances = new InstancesResource(service);
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

                    /// <summary>
                    /// Enables debugging on a VM instance. This allows you to use the SSH command to connect to the
                    /// virtual machine where the instance lives. While in "debug mode", the instance continues to serve
                    /// live traffic. You should delete the instance when you are done debugging and then allow the
                    /// system to take over and determine if another instance should be started.Only applicable for
                    /// instances in App Engine flexible environment.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="appsId">
                    /// Part of `name`. Name of the resource requested. Example:
                    /// apps/myapp/services/default/versions/v1/instances/instance-1.
                    /// </param>
                    /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
                    /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
                    /// <param name="instancesId">Part of `name`. See documentation of `appsId`.</param>
                    public virtual DebugRequest Debug(Google.Apis.Appengine.v1beta.Data.DebugInstanceRequest body, string appsId, string servicesId, string versionsId, string instancesId)
                    {
                        return new DebugRequest(this.service, body, appsId, servicesId, versionsId, instancesId);
                    }

                    /// <summary>
                    /// Enables debugging on a VM instance. This allows you to use the SSH command to connect to the
                    /// virtual machine where the instance lives. While in "debug mode", the instance continues to serve
                    /// live traffic. You should delete the instance when you are done debugging and then allow the
                    /// system to take over and determine if another instance should be started.Only applicable for
                    /// instances in App Engine flexible environment.
                    /// </summary>
                    public class DebugRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Debug request.</summary>
                        public DebugRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.DebugInstanceRequest body, string appsId, string servicesId, string versionsId, string instancesId) : base(service)
                        {
                            AppsId = appsId;
                            ServicesId = servicesId;
                            VersionsId = versionsId;
                            InstancesId = instancesId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource requested. Example:
                        /// apps/myapp/services/default/versions/v1/instances/instance-1.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AppsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServicesId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string VersionsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("instancesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string InstancesId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Appengine.v1beta.Data.DebugInstanceRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "debug";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions/{versionsId}/instances/{instancesId}:debug";

                        /// <summary>Initializes Debug parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "appsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servicesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "versionsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("instancesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "instancesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Stops a running instance.The instance might be automatically recreated based on the scaling
                    /// settings of the version. For more information, see "How Instances are Managed" (standard
                    /// environment (https://cloud.google.com/appengine/docs/standard/python/how-instances-are-managed)
                    /// | flexible environment
                    /// (https://cloud.google.com/appengine/docs/flexible/python/how-instances-are-managed)).To ensure
                    /// that instances are not re-created and avoid getting billed, you can stop all instances within
                    /// the target version by changing the serving status of the version to STOPPED with the
                    /// apps.services.versions.patch
                    /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions/patch)
                    /// method.
                    /// </summary>
                    /// <param name="appsId">
                    /// Part of `name`. Name of the resource requested. Example:
                    /// apps/myapp/services/default/versions/v1/instances/instance-1.
                    /// </param>
                    /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
                    /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
                    /// <param name="instancesId">Part of `name`. See documentation of `appsId`.</param>
                    public virtual DeleteRequest Delete(string appsId, string servicesId, string versionsId, string instancesId)
                    {
                        return new DeleteRequest(this.service, appsId, servicesId, versionsId, instancesId);
                    }

                    /// <summary>
                    /// Stops a running instance.The instance might be automatically recreated based on the scaling
                    /// settings of the version. For more information, see "How Instances are Managed" (standard
                    /// environment (https://cloud.google.com/appengine/docs/standard/python/how-instances-are-managed)
                    /// | flexible environment
                    /// (https://cloud.google.com/appengine/docs/flexible/python/how-instances-are-managed)).To ensure
                    /// that instances are not re-created and avoid getting billed, you can stop all instances within
                    /// the target version by changing the serving status of the version to STOPPED with the
                    /// apps.services.versions.patch
                    /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions/patch)
                    /// method.
                    /// </summary>
                    public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId, string versionsId, string instancesId) : base(service)
                        {
                            AppsId = appsId;
                            ServicesId = servicesId;
                            VersionsId = versionsId;
                            InstancesId = instancesId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource requested. Example:
                        /// apps/myapp/services/default/versions/v1/instances/instance-1.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AppsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServicesId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string VersionsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("instancesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string InstancesId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions/{versionsId}/instances/{instancesId}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "appsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servicesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "versionsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("instancesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "instancesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets instance information.</summary>
                    /// <param name="appsId">
                    /// Part of `name`. Name of the resource requested. Example:
                    /// apps/myapp/services/default/versions/v1/instances/instance-1.
                    /// </param>
                    /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
                    /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
                    /// <param name="instancesId">Part of `name`. See documentation of `appsId`.</param>
                    public virtual GetRequest Get(string appsId, string servicesId, string versionsId, string instancesId)
                    {
                        return new GetRequest(this.service, appsId, servicesId, versionsId, instancesId);
                    }

                    /// <summary>Gets instance information.</summary>
                    public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Instance>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId, string versionsId, string instancesId) : base(service)
                        {
                            AppsId = appsId;
                            ServicesId = servicesId;
                            VersionsId = versionsId;
                            InstancesId = instancesId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource requested. Example:
                        /// apps/myapp/services/default/versions/v1/instances/instance-1.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AppsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServicesId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string VersionsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("instancesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string InstancesId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions/{versionsId}/instances/{instancesId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "appsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servicesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "versionsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("instancesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "instancesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Lists the instances of a version.Tip: To aggregate details about instances over time, see the
                    /// Stackdriver Monitoring API
                    /// (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list).
                    /// </summary>
                    /// <param name="appsId">
                    /// Part of `parent`. Name of the parent Version resource. Example:
                    /// apps/myapp/services/default/versions/v1.
                    /// </param>
                    /// <param name="servicesId">Part of `parent`. See documentation of `appsId`.</param>
                    /// <param name="versionsId">Part of `parent`. See documentation of `appsId`.</param>
                    public virtual ListRequest List(string appsId, string servicesId, string versionsId)
                    {
                        return new ListRequest(this.service, appsId, servicesId, versionsId);
                    }

                    /// <summary>
                    /// Lists the instances of a version.Tip: To aggregate details about instances over time, see the
                    /// Stackdriver Monitoring API
                    /// (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.timeSeries/list).
                    /// </summary>
                    public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListInstancesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId, string versionsId) : base(service)
                        {
                            AppsId = appsId;
                            ServicesId = servicesId;
                            VersionsId = versionsId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `parent`. Name of the parent Version resource. Example:
                        /// apps/myapp/services/default/versions/v1.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AppsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServicesId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `appsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string VersionsId { get; private set; }

                        /// <summary>Maximum results to return per page.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions/{versionsId}/instances";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "appsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servicesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "versionsId",
                                IsRequired = true,
                                ParameterType = "path",
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

                /// <summary>Deploys code and resource files to a new version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="appsId">
                /// Part of `parent`. Name of the parent resource to create this version under. Example:
                /// apps/myapp/services/default.
                /// </param>
                /// <param name="servicesId">Part of `parent`. See documentation of `appsId`.</param>
                public virtual CreateRequest Create(Google.Apis.Appengine.v1beta.Data.Version body, string appsId, string servicesId)
                {
                    return new CreateRequest(this.service, body, appsId, servicesId);
                }

                /// <summary>Deploys code and resource files to a new version.</summary>
                public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Version body, string appsId, string servicesId) : base(service)
                    {
                        AppsId = appsId;
                        ServicesId = servicesId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `parent`. Name of the parent resource to create this version under. Example:
                    /// apps/myapp/services/default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `parent`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ServicesId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Appengine.v1beta.Data.Version Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "servicesId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes an existing Version resource.</summary>
                /// <param name="appsId">
                /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default/versions/v1.
                /// </param>
                /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
                /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
                public virtual DeleteRequest Delete(string appsId, string servicesId, string versionsId)
                {
                    return new DeleteRequest(this.service, appsId, servicesId, versionsId);
                }

                /// <summary>Deletes an existing Version resource.</summary>
                public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId, string versionsId) : base(service)
                    {
                        AppsId = appsId;
                        ServicesId = servicesId;
                        VersionsId = versionsId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the resource requested. Example:
                    /// apps/myapp/services/default/versions/v1.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ServicesId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string VersionsId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions/{versionsId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "servicesId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the specified Version resource. By default, only a BASIC_VIEW will be returned. Specify the
                /// FULL_VIEW parameter to get the full resource.
                /// </summary>
                /// <param name="appsId">
                /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default/versions/v1.
                /// </param>
                /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
                /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
                public virtual GetRequest Get(string appsId, string servicesId, string versionsId)
                {
                    return new GetRequest(this.service, appsId, servicesId, versionsId);
                }

                /// <summary>
                /// Gets the specified Version resource. By default, only a BASIC_VIEW will be returned. Specify the
                /// FULL_VIEW parameter to get the full resource.
                /// </summary>
                public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Version>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId, string versionsId) : base(service)
                    {
                        AppsId = appsId;
                        ServicesId = servicesId;
                        VersionsId = versionsId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the resource requested. Example:
                    /// apps/myapp/services/default/versions/v1.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ServicesId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string VersionsId { get; private set; }

                    /// <summary>Optional. Options to include extra data</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeExtraData", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<IncludeExtraDataEnum> IncludeExtraData { get; set; }

                    /// <summary>Optional. Options to include extra data</summary>
                    public enum IncludeExtraDataEnum
                    {
                        /// <summary>Unspecified: No extra data will be returned</summary>
                        [Google.Apis.Util.StringValueAttribute("INCLUDE_EXTRA_DATA_UNSPECIFIED")]
                        INCLUDEEXTRADATAUNSPECIFIED = 0,

                        /// <summary>Do not return any extra data</summary>
                        [Google.Apis.Util.StringValueAttribute("INCLUDE_EXTRA_DATA_NONE")]
                        INCLUDEEXTRADATANONE = 1,

                        /// <summary>Return GGCM associated with the resources</summary>
                        [Google.Apis.Util.StringValueAttribute("INCLUDE_GOOGLE_GENERATED_METADATA")]
                        INCLUDEGOOGLEGENERATEDMETADATA = 2,
                    }

                    /// <summary>Controls the set of fields returned in the Get response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>Controls the set of fields returned in the Get response.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// Basic version information including scaling and inbound services, but not detailed
                        /// deployment information.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 0,

                        /// <summary>
                        /// The information from BASIC, plus detailed information about the deployment. This format is
                        /// required when creating resources, but is not returned in Get or List by default.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 1,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions/{versionsId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "servicesId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeExtraData", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeExtraData",
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

                /// <summary>Lists the versions of a service.</summary>
                /// <param name="appsId">
                /// Part of `parent`. Name of the parent Service resource. Example: apps/myapp/services/default.
                /// </param>
                /// <param name="servicesId">Part of `parent`. See documentation of `appsId`.</param>
                public virtual ListRequest List(string appsId, string servicesId)
                {
                    return new ListRequest(this.service, appsId, servicesId);
                }

                /// <summary>Lists the versions of a service.</summary>
                public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId) : base(service)
                    {
                        AppsId = appsId;
                        ServicesId = servicesId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `parent`. Name of the parent Service resource. Example: apps/myapp/services/default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `parent`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ServicesId { get; private set; }

                    /// <summary>Maximum results to return per page.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Continuation token for fetching the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Controls the set of fields returned in the List response.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<ViewEnum> View { get; set; }

                    /// <summary>Controls the set of fields returned in the List response.</summary>
                    public enum ViewEnum
                    {
                        /// <summary>
                        /// Basic version information including scaling and inbound services, but not detailed
                        /// deployment information.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("BASIC")]
                        BASIC = 0,

                        /// <summary>
                        /// The information from BASIC, plus detailed information about the deployment. This format is
                        /// required when creating resources, but is not returned in Get or List by default.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("FULL")]
                        FULL = 1,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "servicesId",
                            IsRequired = true,
                            ParameterType = "path",
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
                /// Updates the specified Version resource. You can specify the following fields depending on the App
                /// Engine environment and type of scaling that the version resource uses:Standard environment
                /// instance_class
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.instance_class)automatic
                /// scaling in the standard environment: automatic_scaling.min_idle_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.max_idle_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automaticScaling.standard_scheduler_settings.max_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                /// automaticScaling.standard_scheduler_settings.min_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                /// automaticScaling.standard_scheduler_settings.target_cpu_utilization
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                /// automaticScaling.standard_scheduler_settings.target_throughput_utilization
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)basic
                /// scaling or manual scaling in the standard environment: serving_status
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)
                /// manual_scaling.instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)Flexible
                /// environment serving_status
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)automatic
                /// scaling in the flexible environment: automatic_scaling.min_total_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.max_total_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.cool_down_period_sec
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.cpu_utilization.target_utilization
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)manual
                /// scaling in the flexible environment: manual_scaling.instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="appsId">
                /// Part of `name`. Name of the resource to update. Example: apps/myapp/services/default/versions/1.
                /// </param>
                /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
                /// <param name="versionsId">Part of `name`. See documentation of `appsId`.</param>
                public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.Version body, string appsId, string servicesId, string versionsId)
                {
                    return new PatchRequest(this.service, body, appsId, servicesId, versionsId);
                }

                /// <summary>
                /// Updates the specified Version resource. You can specify the following fields depending on the App
                /// Engine environment and type of scaling that the version resource uses:Standard environment
                /// instance_class
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.instance_class)automatic
                /// scaling in the standard environment: automatic_scaling.min_idle_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.max_idle_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automaticScaling.standard_scheduler_settings.max_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                /// automaticScaling.standard_scheduler_settings.min_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                /// automaticScaling.standard_scheduler_settings.target_cpu_utilization
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                /// automaticScaling.standard_scheduler_settings.target_throughput_utilization
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)basic
                /// scaling or manual scaling in the standard environment: serving_status
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)
                /// manual_scaling.instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)Flexible
                /// environment serving_status
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)automatic
                /// scaling in the flexible environment: automatic_scaling.min_total_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.max_total_instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.cool_down_period_sec
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                /// automatic_scaling.cpu_utilization.target_utilization
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)manual
                /// scaling in the flexible environment: manual_scaling.instances
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)
                /// </summary>
                public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Version body, string appsId, string servicesId, string versionsId) : base(service)
                    {
                        AppsId = appsId;
                        ServicesId = servicesId;
                        VersionsId = versionsId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the resource to update. Example: apps/myapp/services/default/versions/1.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AppsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ServicesId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string VersionsId { get; private set; }

                    /// <summary>Standard field mask for the set of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Appengine.v1beta.Data.Version Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}/versions/{versionsId}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "appsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "servicesId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "versionsId",
                            IsRequired = true,
                            ParameterType = "path",
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

            /// <summary>Deletes the specified service and all enclosed versions.</summary>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default.
            /// </param>
            /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
            public virtual DeleteRequest Delete(string appsId, string servicesId)
            {
                return new DeleteRequest(this.service, appsId, servicesId);
            }

            /// <summary>Deletes the specified service and all enclosed versions.</summary>
            public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId) : base(service)
                {
                    AppsId = appsId;
                    ServicesId = servicesId;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServicesId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "servicesId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets the current configuration of the specified service.</summary>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default.
            /// </param>
            /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
            public virtual GetRequest Get(string appsId, string servicesId)
            {
                return new GetRequest(this.service, appsId, servicesId);
            }

            /// <summary>Gets the current configuration of the specified service.</summary>
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Service>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string appsId, string servicesId) : base(service)
                {
                    AppsId = appsId;
                    ServicesId = servicesId;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServicesId { get; private set; }

                /// <summary>Optional. Options to include extra data</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeExtraData", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<IncludeExtraDataEnum> IncludeExtraData { get; set; }

                /// <summary>Optional. Options to include extra data</summary>
                public enum IncludeExtraDataEnum
                {
                    /// <summary>Unspecified: No extra data will be returned</summary>
                    [Google.Apis.Util.StringValueAttribute("INCLUDE_EXTRA_DATA_UNSPECIFIED")]
                    INCLUDEEXTRADATAUNSPECIFIED = 0,

                    /// <summary>Do not return any extra data</summary>
                    [Google.Apis.Util.StringValueAttribute("INCLUDE_EXTRA_DATA_NONE")]
                    INCLUDEEXTRADATANONE = 1,

                    /// <summary>Return GGCM associated with the resources</summary>
                    [Google.Apis.Util.StringValueAttribute("INCLUDE_GOOGLE_GENERATED_METADATA")]
                    INCLUDEGOOGLEGENERATEDMETADATA = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "servicesId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeExtraData", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeExtraData",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all the services in the application.</summary>
            /// <param name="appsId">
            /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
            /// </param>
            public virtual ListRequest List(string appsId)
            {
                return new ListRequest(this.service, appsId);
            }

            /// <summary>Lists all the services in the application.</summary>
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListServicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
                {
                    AppsId = appsId;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Maximum results to return per page.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/services";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
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

            /// <summary>Updates the configuration of the specified service.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="appsId">
            /// Part of `name`. Name of the resource to update. Example: apps/myapp/services/default.
            /// </param>
            /// <param name="servicesId">Part of `name`. See documentation of `appsId`.</param>
            public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.Service body, string appsId, string servicesId)
            {
                return new PatchRequest(this.service, body, appsId, servicesId);
            }

            /// <summary>Updates the configuration of the specified service.</summary>
            public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Service body, string appsId, string servicesId) : base(service)
                {
                    AppsId = appsId;
                    ServicesId = servicesId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Part of `name`. Name of the resource to update. Example: apps/myapp/services/default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `appsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ServicesId { get; private set; }

                /// <summary>
                /// Set to true to gradually shift traffic to one or more versions that you specify. By default, traffic
                /// is shifted immediately. For gradual traffic migration, the target versions must be located within
                /// instances that are configured for both warmup requests
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#InboundServiceType)
                /// and automatic scaling
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#AutomaticScaling).
                /// You must specify the shardBy
                /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services#ShardBy)
                /// field in the Service resource. Gradual traffic migration is not supported in the App Engine flexible
                /// environment. For examples, see Migrating and Splitting Traffic
                /// (https://cloud.google.com/appengine/docs/admin-api/migrating-splitting-traffic).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("migrateTraffic", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> MigrateTraffic { get; set; }

                /// <summary>Required. Standard field mask for the set of fields to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Appengine.v1beta.Data.Service Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/apps/{appsId}/services/{servicesId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "servicesId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("migrateTraffic", new Google.Apis.Discovery.Parameter
                    {
                        Name = "migrateTraffic",
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

        /// <summary>
        /// Creates an App Engine application for a Google Cloud Platform project. Required fields: id - The ID of the
        /// target Cloud Platform project. location - The region (https://cloud.google.com/appengine/docs/locations)
        /// where you want the App Engine application located.For more information about App Engine applications, see
        /// Managing Projects, Applications, and Billing
        /// (https://cloud.google.com/appengine/docs/standard/python/console/).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Appengine.v1beta.Data.Application body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates an App Engine application for a Google Cloud Platform project. Required fields: id - The ID of the
        /// target Cloud Platform project. location - The region (https://cloud.google.com/appengine/docs/locations)
        /// where you want the App Engine application located.For more information about App Engine applications, see
        /// Managing Projects, Applications, and Billing
        /// (https://cloud.google.com/appengine/docs/standard/python/console/).
        /// </summary>
        public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Application body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Appengine.v1beta.Data.Application Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/apps";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Gets information about an application.</summary>
        /// <param name="appsId">Part of `name`. Name of the Application resource to get. Example: apps/myapp.</param>
        public virtual GetRequest Get(string appsId)
        {
            return new GetRequest(this.service, appsId);
        }

        /// <summary>Gets information about an application.</summary>
        public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Application>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
            {
                AppsId = appsId;
                InitParameters();
            }

            /// <summary>Part of `name`. Name of the Application resource to get. Example: apps/myapp.</summary>
            [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AppsId { get; private set; }

            /// <summary>Optional. Options to include extra data</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeExtraData", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<IncludeExtraDataEnum> IncludeExtraData { get; set; }

            /// <summary>Optional. Options to include extra data</summary>
            public enum IncludeExtraDataEnum
            {
                /// <summary>Unspecified: No extra data will be returned</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_EXTRA_DATA_UNSPECIFIED")]
                INCLUDEEXTRADATAUNSPECIFIED = 0,

                /// <summary>Do not return any extra data</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_EXTRA_DATA_NONE")]
                INCLUDEEXTRADATANONE = 1,

                /// <summary>Return GGCM associated with the resources</summary>
                [Google.Apis.Util.StringValueAttribute("INCLUDE_GOOGLE_GENERATED_METADATA")]
                INCLUDEGOOGLEGENERATEDMETADATA = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/apps/{appsId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appsId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeExtraData", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeExtraData",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all the available runtimes for the application.</summary>
        /// <param name="appsId">
        /// Part of `parent`. Required. Name of the parent Application resource. Example: apps/myapp.
        /// </param>
        public virtual ListRuntimesRequest ListRuntimes(string appsId)
        {
            return new ListRuntimesRequest(this.service, appsId);
        }

        /// <summary>Lists all the available runtimes for the application.</summary>
        public class ListRuntimesRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListRuntimesResponse>
        {
            /// <summary>Constructs a new ListRuntimes request.</summary>
            public ListRuntimesRequest(Google.Apis.Services.IClientService service, string appsId) : base(service)
            {
                AppsId = appsId;
                InitParameters();
            }

            /// <summary>
            /// Part of `parent`. Required. Name of the parent Application resource. Example: apps/myapp.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AppsId { get; private set; }

            /// <summary>Optional. The environment of the Application.</summary>
            [Google.Apis.Util.RequestParameterAttribute("environment", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<EnvironmentEnum> Environment { get; set; }

            /// <summary>Optional. The environment of the Application.</summary>
            public enum EnvironmentEnum
            {
                /// <summary>Default value.</summary>
                [Google.Apis.Util.StringValueAttribute("ENVIRONMENT_UNSPECIFIED")]
                ENVIRONMENTUNSPECIFIED = 0,

                /// <summary>App Engine Standard.</summary>
                [Google.Apis.Util.StringValueAttribute("STANDARD")]
                STANDARD = 1,

                /// <summary>App Engine Flexible</summary>
                [Google.Apis.Util.StringValueAttribute("FLEXIBLE")]
                FLEXIBLE = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listRuntimes";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/apps/{appsId}:listRuntimes";

            /// <summary>Initializes ListRuntimes parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appsId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("environment", new Google.Apis.Discovery.Parameter
                {
                    Name = "environment",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates the specified Application resource. You can update the following fields: auth_domain - Google
        /// authentication domain for controlling user access to the application. default_cookie_expiration - Cookie
        /// expiration policy for the application. iap - Identity-Aware Proxy properties for the application.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="appsId">
        /// Part of `name`. Name of the Application resource to update. Example: apps/myapp.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.Application body, string appsId)
        {
            return new PatchRequest(this.service, body, appsId);
        }

        /// <summary>
        /// Updates the specified Application resource. You can update the following fields: auth_domain - Google
        /// authentication domain for controlling user access to the application. default_cookie_expiration - Cookie
        /// expiration policy for the application. iap - Identity-Aware Proxy properties for the application.
        /// </summary>
        public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Application body, string appsId) : base(service)
            {
                AppsId = appsId;
                Body = body;
                InitParameters();
            }

            /// <summary>Part of `name`. Name of the Application resource to update. Example: apps/myapp.</summary>
            [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AppsId { get; private set; }

            /// <summary>Required. Standard field mask for the set of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Appengine.v1beta.Data.Application Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/apps/{appsId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appsId",
                    IsRequired = true,
                    ParameterType = "path",
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

        /// <summary>
        /// Recreates the required App Engine features for the specified App Engine application, for example a Cloud
        /// Storage bucket or App Engine service account. Use this method if you receive an error message about a
        /// missing feature, for example, Error retrieving the App Engine service account. If you have deleted your App
        /// Engine service account, this will not be able to recreate it. Instead, you should attempt to use the IAM
        /// undelete API if possible at
        /// https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts/undelete?apix_params=%7B"name"%3A"projects%2F-%2FserviceAccounts%2Funique_id"%2C"resource"%3A%7B%7D%7D
        /// . If the deletion was recent, the numeric ID can be found in the Cloud Console Activity Log.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="appsId">Part of `name`. Name of the application to repair. Example: apps/myapp</param>
        public virtual RepairRequest Repair(Google.Apis.Appengine.v1beta.Data.RepairApplicationRequest body, string appsId)
        {
            return new RepairRequest(this.service, body, appsId);
        }

        /// <summary>
        /// Recreates the required App Engine features for the specified App Engine application, for example a Cloud
        /// Storage bucket or App Engine service account. Use this method if you receive an error message about a
        /// missing feature, for example, Error retrieving the App Engine service account. If you have deleted your App
        /// Engine service account, this will not be able to recreate it. Instead, you should attempt to use the IAM
        /// undelete API if possible at
        /// https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts/undelete?apix_params=%7B"name"%3A"projects%2F-%2FserviceAccounts%2Funique_id"%2C"resource"%3A%7B%7D%7D
        /// . If the deletion was recent, the numeric ID can be found in the Cloud Console Activity Log.
        /// </summary>
        public class RepairRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
        {
            /// <summary>Constructs a new Repair request.</summary>
            public RepairRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.RepairApplicationRequest body, string appsId) : base(service)
            {
                AppsId = appsId;
                Body = body;
                InitParameters();
            }

            /// <summary>Part of `name`. Name of the application to repair. Example: apps/myapp</summary>
            [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AppsId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Appengine.v1beta.Data.RepairApplicationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "repair";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/apps/{appsId}:repair";

            /// <summary>Initializes Repair parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("appsId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appsId",
                    IsRequired = true,
                    ParameterType = "path",
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
                Applications = new ApplicationsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Applications resource.</summary>
            public virtual ApplicationsResource Applications { get; }

            /// <summary>The "applications" collection of methods.</summary>
            public class ApplicationsResource
            {
                private const string Resource = "applications";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ApplicationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    AuthorizedCertificates = new AuthorizedCertificatesResource(service);
                    AuthorizedDomains = new AuthorizedDomainsResource(service);
                    DomainMappings = new DomainMappingsResource(service);
                    Services = new ServicesResource(service);
                }

                /// <summary>Gets the AuthorizedCertificates resource.</summary>
                public virtual AuthorizedCertificatesResource AuthorizedCertificates { get; }

                /// <summary>The "authorizedCertificates" collection of methods.</summary>
                public class AuthorizedCertificatesResource
                {
                    private const string Resource = "authorizedCertificates";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AuthorizedCertificatesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Uploads the specified SSL certificate.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectsId">
                    /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                    /// </param>
                    /// <param name="locationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    public virtual CreateRequest Create(Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId)
                    {
                        return new CreateRequest(this.service, body, projectsId, locationsId, applicationsId);
                    }

                    /// <summary>Uploads the specified SSL certificate.</summary>
                    public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified SSL certificate.</summary>
                    /// <param name="projectsId">
                    /// Part of `name`. Name of the resource to delete. Example:
                    /// apps/myapp/authorizedCertificates/12345.
                    /// </param>
                    /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="authorizedCertificatesId">
                    /// Part of `name`. See documentation of `projectsId`.
                    /// </param>
                    public virtual DeleteRequest Delete(string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId)
                    {
                        return new DeleteRequest(this.service, projectsId, locationsId, applicationsId, authorizedCertificatesId);
                    }

                    /// <summary>Deletes the specified SSL certificate.</summary>
                    public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            AuthorizedCertificatesId = authorizedCertificatesId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource to delete. Example:
                        /// apps/myapp/authorizedCertificates/12345.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("authorizedCertificatesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AuthorizedCertificatesId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates/{authorizedCertificatesId}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("authorizedCertificatesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "authorizedCertificatesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets the specified SSL certificate.</summary>
                    /// <param name="projectsId">
                    /// Part of `name`. Name of the resource requested. Example:
                    /// apps/myapp/authorizedCertificates/12345.
                    /// </param>
                    /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="authorizedCertificatesId">
                    /// Part of `name`. See documentation of `projectsId`.
                    /// </param>
                    public virtual GetRequest Get(string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId)
                    {
                        return new GetRequest(this.service, projectsId, locationsId, applicationsId, authorizedCertificatesId);
                    }

                    /// <summary>Gets the specified SSL certificate.</summary>
                    public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            AuthorizedCertificatesId = authorizedCertificatesId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource requested. Example:
                        /// apps/myapp/authorizedCertificates/12345.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("authorizedCertificatesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AuthorizedCertificatesId { get; private set; }

                        /// <summary>Controls the set of fields returned in the GET response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Controls the set of fields returned in the GET response.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>
                            /// Basic certificate information, including applicable domains and expiration date.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC_CERTIFICATE")]
                            BASICCERTIFICATE = 0,

                            /// <summary>
                            /// The information from BASIC_CERTIFICATE, plus detailed information on the domain mappings
                            /// that have this certificate mapped.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL_CERTIFICATE")]
                            FULLCERTIFICATE = 1,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates/{authorizedCertificatesId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("authorizedCertificatesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "authorizedCertificatesId",
                                IsRequired = true,
                                ParameterType = "path",
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

                    /// <summary>Lists all SSL certificates the user is authorized to administer.</summary>
                    /// <param name="projectsId">
                    /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                    /// </param>
                    /// <param name="locationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    public virtual ListRequest List(string projectsId, string locationsId, string applicationsId)
                    {
                        return new ListRequest(this.service, projectsId, locationsId, applicationsId);
                    }

                    /// <summary>Lists all SSL certificates the user is authorized to administer.</summary>
                    public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListAuthorizedCertificatesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string applicationsId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Maximum results to return per page.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Controls the set of fields returned in the LIST response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<ViewEnum> View { get; set; }

                        /// <summary>Controls the set of fields returned in the LIST response.</summary>
                        public enum ViewEnum
                        {
                            /// <summary>
                            /// Basic certificate information, including applicable domains and expiration date.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("BASIC_CERTIFICATE")]
                            BASICCERTIFICATE = 0,

                            /// <summary>
                            /// The information from BASIC_CERTIFICATE, plus detailed information on the domain mappings
                            /// that have this certificate mapped.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL_CERTIFICATE")]
                            FULLCERTIFICATE = 1,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
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
                    /// Updates the specified SSL certificate. To renew a certificate and maintain its existing domain
                    /// mappings, update certificate_data with a new certificate. The new certificate must be applicable
                    /// to the same domains as the original certificate. The certificate display_name may also be
                    /// updated.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectsId">
                    /// Part of `name`. Name of the resource to update. Example:
                    /// apps/myapp/authorizedCertificates/12345.
                    /// </param>
                    /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="authorizedCertificatesId">
                    /// Part of `name`. See documentation of `projectsId`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId)
                    {
                        return new PatchRequest(this.service, body, projectsId, locationsId, applicationsId, authorizedCertificatesId);
                    }

                    /// <summary>
                    /// Updates the specified SSL certificate. To renew a certificate and maintain its existing domain
                    /// mappings, update certificate_data with a new certificate. The new certificate must be applicable
                    /// to the same domains as the original certificate. The certificate display_name may also be
                    /// updated.
                    /// </summary>
                    public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            AuthorizedCertificatesId = authorizedCertificatesId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource to update. Example:
                        /// apps/myapp/authorizedCertificates/12345.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("authorizedCertificatesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AuthorizedCertificatesId { get; private set; }

                        /// <summary>
                        /// Standard field mask for the set of fields to be updated. Updates are only supported on the
                        /// certificate_raw_data and display_name fields.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Appengine.v1beta.Data.AuthorizedCertificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates/{authorizedCertificatesId}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("authorizedCertificatesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "authorizedCertificatesId",
                                IsRequired = true,
                                ParameterType = "path",
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

                /// <summary>Gets the AuthorizedDomains resource.</summary>
                public virtual AuthorizedDomainsResource AuthorizedDomains { get; }

                /// <summary>The "authorizedDomains" collection of methods.</summary>
                public class AuthorizedDomainsResource
                {
                    private const string Resource = "authorizedDomains";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public AuthorizedDomainsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Lists all domains the user is authorized to administer.</summary>
                    /// <param name="projectsId">
                    /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                    /// </param>
                    /// <param name="locationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    public virtual ListRequest List(string projectsId, string locationsId, string applicationsId)
                    {
                        return new ListRequest(this.service, projectsId, locationsId, applicationsId);
                    }

                    /// <summary>Lists all domains the user is authorized to administer.</summary>
                    public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListAuthorizedDomainsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string applicationsId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Maximum results to return per page.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedDomains";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
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

                /// <summary>Gets the DomainMappings resource.</summary>
                public virtual DomainMappingsResource DomainMappings { get; }

                /// <summary>The "domainMappings" collection of methods.</summary>
                public class DomainMappingsResource
                {
                    private const string Resource = "domainMappings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DomainMappingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Maps a domain to an application. A user must be authorized to administer a domain in order to
                    /// map it to an application. For a list of available authorized domains, see
                    /// AuthorizedDomains.ListAuthorizedDomains.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectsId">
                    /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                    /// </param>
                    /// <param name="locationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `parent`. See documentation of `projectsId`.</param>
                    public virtual CreateRequest Create(Google.Apis.Appengine.v1beta.Data.DomainMapping body, string projectsId, string locationsId, string applicationsId)
                    {
                        return new CreateRequest(this.service, body, projectsId, locationsId, applicationsId);
                    }

                    /// <summary>
                    /// Maps a domain to an application. A user must be authorized to administer a domain in order to
                    /// map it to an application. For a list of available authorized domains, see
                    /// AuthorizedDomains.ListAuthorizedDomains.
                    /// </summary>
                    public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.DomainMapping body, string projectsId, string locationsId, string applicationsId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `parent`. Name of the parent Application resource. Example: apps/myapp.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `parent`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>
                        /// Whether the domain creation should override any existing mappings for this domain. By
                        /// default, overrides are rejected.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("overrideStrategy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<OverrideStrategyEnum> OverrideStrategy { get; set; }

                        /// <summary>
                        /// Whether the domain creation should override any existing mappings for this domain. By
                        /// default, overrides are rejected.
                        /// </summary>
                        public enum OverrideStrategyEnum
                        {
                            /// <summary>Strategy unspecified. Defaults to STRICT.</summary>
                            [Google.Apis.Util.StringValueAttribute("UNSPECIFIED_DOMAIN_OVERRIDE_STRATEGY")]
                            UNSPECIFIEDDOMAINOVERRIDESTRATEGY = 0,

                            /// <summary>
                            /// Overrides not allowed. If a mapping already exists for the specified domain, the request
                            /// will return an ALREADY_EXISTS (409).
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("STRICT")]
                            STRICT = 1,

                            /// <summary>
                            /// Overrides allowed. If a mapping already exists for the specified domain, the request
                            /// will overwrite it. Note that this might stop another Google product from serving. For
                            /// example, if the domain is mapped to another App Engine application, that app will no
                            /// longer serve from that domain.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("OVERRIDE")]
                            OVERRIDE__ = 2,
                        }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Appengine.v1beta.Data.DomainMapping Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/domainMappings";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("overrideStrategy", new Google.Apis.Discovery.Parameter
                            {
                                Name = "overrideStrategy",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Gets the specified domain mapping.</summary>
                    /// <param name="projectsId">
                    /// Part of `name`. Name of the resource requested. Example: apps/myapp/domainMappings/example.com.
                    /// </param>
                    /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="domainMappingsId">Part of `name`. See documentation of `projectsId`.</param>
                    public virtual GetRequest Get(string projectsId, string locationsId, string applicationsId, string domainMappingsId)
                    {
                        return new GetRequest(this.service, projectsId, locationsId, applicationsId, domainMappingsId);
                    }

                    /// <summary>Gets the specified domain mapping.</summary>
                    public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.DomainMapping>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string applicationsId, string domainMappingsId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            DomainMappingsId = domainMappingsId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource requested. Example:
                        /// apps/myapp/domainMappings/example.com.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("domainMappingsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DomainMappingsId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/domainMappings/{domainMappingsId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("domainMappingsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "domainMappingsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Gets the Services resource.</summary>
                public virtual ServicesResource Services { get; }

                /// <summary>The "services" collection of methods.</summary>
                public class ServicesResource
                {
                    private const string Resource = "services";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ServicesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Versions = new VersionsResource(service);
                    }

                    /// <summary>Gets the Versions resource.</summary>
                    public virtual VersionsResource Versions { get; }

                    /// <summary>The "versions" collection of methods.</summary>
                    public class VersionsResource
                    {
                        private const string Resource = "versions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public VersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Deletes an existing Version resource.</summary>
                        /// <param name="projectsId">
                        /// Part of `name`. Name of the resource requested. Example:
                        /// apps/myapp/services/default/versions/v1.
                        /// </param>
                        /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                        /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                        /// <param name="servicesId">Part of `name`. See documentation of `projectsId`.</param>
                        /// <param name="versionsId">Part of `name`. See documentation of `projectsId`.</param>
                        public virtual DeleteRequest Delete(string projectsId, string locationsId, string applicationsId, string servicesId, string versionsId)
                        {
                            return new DeleteRequest(this.service, projectsId, locationsId, applicationsId, servicesId, versionsId);
                        }

                        /// <summary>Deletes an existing Version resource.</summary>
                        public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string applicationsId, string servicesId, string versionsId) : base(service)
                            {
                                ProjectsId = projectsId;
                                LocationsId = locationsId;
                                ApplicationsId = applicationsId;
                                ServicesId = servicesId;
                                VersionsId = versionsId;
                                InitParameters();
                            }

                            /// <summary>
                            /// Part of `name`. Name of the resource requested. Example:
                            /// apps/myapp/services/default/versions/v1.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectsId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string LocationsId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ApplicationsId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ServicesId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string VersionsId { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/services/{servicesId}/versions/{versionsId}";

                            /// <summary>Initializes Delete parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectsId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "locationsId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "applicationsId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "servicesId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "versionsId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Updates the specified Version resource. You can specify the following fields depending on
                        /// the App Engine environment and type of scaling that the version resource uses:Standard
                        /// environment instance_class
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.instance_class)automatic
                        /// scaling in the standard environment: automatic_scaling.min_idle_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.max_idle_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automaticScaling.standard_scheduler_settings.max_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                        /// automaticScaling.standard_scheduler_settings.min_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                        /// automaticScaling.standard_scheduler_settings.target_cpu_utilization
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                        /// automaticScaling.standard_scheduler_settings.target_throughput_utilization
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)basic
                        /// scaling or manual scaling in the standard environment: serving_status
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)
                        /// manual_scaling.instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)Flexible
                        /// environment serving_status
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)automatic
                        /// scaling in the flexible environment: automatic_scaling.min_total_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.max_total_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.cool_down_period_sec
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.cpu_utilization.target_utilization
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)manual
                        /// scaling in the flexible environment: manual_scaling.instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="projectsId">
                        /// Part of `name`. Name of the resource to update. Example:
                        /// apps/myapp/services/default/versions/1.
                        /// </param>
                        /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                        /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                        /// <param name="servicesId">Part of `name`. See documentation of `projectsId`.</param>
                        /// <param name="versionsId">Part of `name`. See documentation of `projectsId`.</param>
                        public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.Version body, string projectsId, string locationsId, string applicationsId, string servicesId, string versionsId)
                        {
                            return new PatchRequest(this.service, body, projectsId, locationsId, applicationsId, servicesId, versionsId);
                        }

                        /// <summary>
                        /// Updates the specified Version resource. You can specify the following fields depending on
                        /// the App Engine environment and type of scaling that the version resource uses:Standard
                        /// environment instance_class
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.instance_class)automatic
                        /// scaling in the standard environment: automatic_scaling.min_idle_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.max_idle_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automaticScaling.standard_scheduler_settings.max_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                        /// automaticScaling.standard_scheduler_settings.min_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                        /// automaticScaling.standard_scheduler_settings.target_cpu_utilization
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)
                        /// automaticScaling.standard_scheduler_settings.target_throughput_utilization
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StandardSchedulerSettings)basic
                        /// scaling or manual scaling in the standard environment: serving_status
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)
                        /// manual_scaling.instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)Flexible
                        /// environment serving_status
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.serving_status)automatic
                        /// scaling in the flexible environment: automatic_scaling.min_total_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.max_total_instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.cool_down_period_sec
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)
                        /// automatic_scaling.cpu_utilization.target_utilization
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#Version.FIELDS.automatic_scaling)manual
                        /// scaling in the flexible environment: manual_scaling.instances
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#manualscaling)
                        /// </summary>
                        public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Version body, string projectsId, string locationsId, string applicationsId, string servicesId, string versionsId) : base(service)
                            {
                                ProjectsId = projectsId;
                                LocationsId = locationsId;
                                ApplicationsId = applicationsId;
                                ServicesId = servicesId;
                                VersionsId = versionsId;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Part of `name`. Name of the resource to update. Example:
                            /// apps/myapp/services/default/versions/1.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ProjectsId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string LocationsId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ApplicationsId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ServicesId { get; private set; }

                            /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("versionsId", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string VersionsId { get; private set; }

                            /// <summary>Standard field mask for the set of fields to be updated.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Appengine.v1beta.Data.Version Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/services/{servicesId}/versions/{versionsId}";

                            /// <summary>Initializes Patch parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "projectsId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "locationsId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "applicationsId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "servicesId",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("versionsId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "versionsId",
                                    IsRequired = true,
                                    ParameterType = "path",
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

                    /// <summary>Deletes the specified service and all enclosed versions.</summary>
                    /// <param name="projectsId">
                    /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default.
                    /// </param>
                    /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="servicesId">Part of `name`. See documentation of `projectsId`.</param>
                    public virtual DeleteRequest Delete(string projectsId, string locationsId, string applicationsId, string servicesId)
                    {
                        return new DeleteRequest(this.service, projectsId, locationsId, applicationsId, servicesId);
                    }

                    /// <summary>Deletes the specified service and all enclosed versions.</summary>
                    public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string applicationsId, string servicesId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            ServicesId = servicesId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource requested. Example: apps/myapp/services/default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServicesId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/services/{servicesId}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servicesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Updates the configuration of the specified service.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="projectsId">
                    /// Part of `name`. Name of the resource to update. Example: apps/myapp/services/default.
                    /// </param>
                    /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                    /// <param name="servicesId">Part of `name`. See documentation of `projectsId`.</param>
                    public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.Service body, string projectsId, string locationsId, string applicationsId, string servicesId)
                    {
                        return new PatchRequest(this.service, body, projectsId, locationsId, applicationsId, servicesId);
                    }

                    /// <summary>Updates the configuration of the specified service.</summary>
                    public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Service body, string projectsId, string locationsId, string applicationsId, string servicesId) : base(service)
                        {
                            ProjectsId = projectsId;
                            LocationsId = locationsId;
                            ApplicationsId = applicationsId;
                            ServicesId = servicesId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Part of `name`. Name of the resource to update. Example: apps/myapp/services/default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProjectsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string LocationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ApplicationsId { get; private set; }

                        /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("servicesId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ServicesId { get; private set; }

                        /// <summary>
                        /// Set to true to gradually shift traffic to one or more versions that you specify. By default,
                        /// traffic is shifted immediately. For gradual traffic migration, the target versions must be
                        /// located within instances that are configured for both warmup requests
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#InboundServiceType)
                        /// and automatic scaling
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#AutomaticScaling).
                        /// You must specify the shardBy
                        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services#ShardBy)
                        /// field in the Service resource. Gradual traffic migration is not supported in the App Engine
                        /// flexible environment. For examples, see Migrating and Splitting Traffic
                        /// (https://cloud.google.com/appengine/docs/admin-api/migrating-splitting-traffic).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("migrateTraffic", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> MigrateTraffic { get; set; }

                        /// <summary>Required. Standard field mask for the set of fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Appengine.v1beta.Data.Service Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/services/{servicesId}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "projectsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "locationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "applicationsId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("servicesId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "servicesId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("migrateTraffic", new Google.Apis.Discovery.Parameter
                            {
                                Name = "migrateTraffic",
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

                /// <summary>
                /// Updates the specified Application resource. You can update the following fields: auth_domain -
                /// Google authentication domain for controlling user access to the application.
                /// default_cookie_expiration - Cookie expiration policy for the application. iap - Identity-Aware Proxy
                /// properties for the application.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="projectsId">
                /// Part of `name`. Name of the Application resource to update. Example: apps/myapp.
                /// </param>
                /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                /// <param name="applicationsId">Part of `name`. See documentation of `projectsId`.</param>
                public virtual PatchRequest Patch(Google.Apis.Appengine.v1beta.Data.Application body, string projectsId, string locationsId, string applicationsId)
                {
                    return new PatchRequest(this.service, body, projectsId, locationsId, applicationsId);
                }

                /// <summary>
                /// Updates the specified Application resource. You can update the following fields: auth_domain -
                /// Google authentication domain for controlling user access to the application.
                /// default_cookie_expiration - Cookie expiration policy for the application. iap - Identity-Aware Proxy
                /// properties for the application.
                /// </summary>
                public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1beta.Data.Application body, string projectsId, string locationsId, string applicationsId) : base(service)
                    {
                        ProjectsId = projectsId;
                        LocationsId = locationsId;
                        ApplicationsId = applicationsId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Part of `name`. Name of the Application resource to update. Example: apps/myapp.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string LocationsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("applicationsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ApplicationsId { get; private set; }

                    /// <summary>Required. Standard field mask for the set of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Appengine.v1beta.Data.Application Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("applicationsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "applicationsId",
                            IsRequired = true,
                            ParameterType = "path",
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
                /// <param name="projectsId">Part of `name`. The name of the operation resource.</param>
                /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                /// <param name="operationsId">Part of `name`. See documentation of `projectsId`.</param>
                public virtual GetRequest Get(string projectsId, string locationsId, string operationsId)
                {
                    return new GetRequest(this.service, projectsId, locationsId, operationsId);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId, string operationsId) : base(service)
                    {
                        ProjectsId = projectsId;
                        LocationsId = locationsId;
                        OperationsId = operationsId;
                        InitParameters();
                    }

                    /// <summary>Part of `name`. The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string LocationsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("operationsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string OperationsId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/operations/{operationsId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("operationsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "operationsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.
                /// </summary>
                /// <param name="projectsId">Part of `name`. The name of the operation's parent resource.</param>
                /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
                public virtual ListRequest List(string projectsId, string locationsId)
                {
                    return new ListRequest(this.service, projectsId, locationsId);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns UNIMPLEMENTED.
                /// </summary>
                public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId) : base(service)
                    {
                        ProjectsId = projectsId;
                        LocationsId = locationsId;
                        InitParameters();
                    }

                    /// <summary>Part of `name`. The name of the operation's parent resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProjectsId { get; private set; }

                    /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string LocationsId { get; private set; }

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
                    public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}/operations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectsId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationsId",
                            IsRequired = true,
                            ParameterType = "path",
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="projectsId">Part of `name`. Resource name for the location.</param>
            /// <param name="locationsId">Part of `name`. See documentation of `projectsId`.</param>
            public virtual GetRequest Get(string projectsId, string locationsId)
            {
                return new GetRequest(this.service, projectsId, locationsId);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectsId, string locationsId) : base(service)
                {
                    ProjectsId = projectsId;
                    LocationsId = locationsId;
                    InitParameters();
                }

                /// <summary>Part of `name`. Resource name for the location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectsId { get; private set; }

                /// <summary>Part of `name`. See documentation of `projectsId`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string LocationsId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/projects/{projectsId}/locations/{locationsId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locationsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="projectsId">
            /// Part of `name`. The resource that owns the locations collection, if applicable.
            /// </param>
            public virtual ListRequest List(string projectsId)
            {
                return new ListRequest(this.service, projectsId);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1beta.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectsId) : base(service)
                {
                    ProjectsId = projectsId;
                    InitParameters();
                }

                /// <summary>Part of `name`. The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectsId { get; private set; }

                /// <summary>
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in AIP-160 (https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the next_page_token field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/projects/{projectsId}/locations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectsId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectsId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("extraLocationTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "extraLocationTypes",
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
namespace Google.Apis.Appengine.v1beta.Data
{
    /// <summary>Google Cloud Endpoints (https://cloud.google.com/endpoints) configuration for API handlers.</summary>
    public class ApiConfigHandler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Action to take when users access resources that require authentication. Defaults to redirect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authFailAction")]
        public virtual string AuthFailAction { get; set; }

        /// <summary>Level of login required to access this resource. Defaults to optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("login")]
        public virtual string Login { get; set; }

        /// <summary>Path to the script from the application root directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual string Script { get; set; }

        /// <summary>Security (HTTPS) enforcement for this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityLevel")]
        public virtual string SecurityLevel { get; set; }

        /// <summary>URL to serve the endpoint at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Uses Google Cloud Endpoints to handle requests.</summary>
    public class ApiEndpointHandler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path to the script from the application root directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptPath")]
        public virtual string ScriptPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Application resource contains the top-level configuration of an App Engine application.</summary>
    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Apps authentication domain that controls which users can access this application.Defaults to open
        /// access for any Google Account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authDomain")]
        public virtual string AuthDomain { get; set; }

        /// <summary>
        /// Output only. Google Cloud Storage bucket that can be used for storing files associated with this
        /// application. This bucket is associated with the application and can be used by the gcloud deployment
        /// commands.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeBucket")]
        public virtual string CodeBucket { get; set; }

        /// <summary>
        /// The type of the Cloud Firestore or Cloud Datastore database associated with this application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("databaseType")]
        public virtual string DatabaseType { get; set; }

        /// <summary>
        /// Output only. Google Cloud Storage bucket that can be used by this application to store content.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultBucket")]
        public virtual string DefaultBucket { get; set; }

        /// <summary>Cookie expiration policy for this application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultCookieExpiration")]
        public virtual object DefaultCookieExpiration { get; set; }

        /// <summary>
        /// Output only. Hostname used to reach this application, as resolved by App Engine.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultHostname")]
        public virtual string DefaultHostname { get; set; }

        /// <summary>
        /// HTTP path dispatch rules for requests to the application that do not explicitly target a service or version.
        /// Rules are order-dependent. Up to 20 dispatch rules can be supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dispatchRules")]
        public virtual System.Collections.Generic.IList<UrlDispatchRule> DispatchRules { get; set; }

        /// <summary>The feature specific settings to be used in the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureSettings")]
        public virtual FeatureSettings FeatureSettings { get; set; }

        /// <summary>
        /// Output only. The Google Container Registry domain used for storing managed build docker images for this
        /// application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcrDomain")]
        public virtual string GcrDomain { get; set; }

        /// <summary>
        /// Additional Google Generated Customer Metadata, this field won't be provided by default and can be requested
        /// by setting the IncludeExtraData field in GetApplicationRequest
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedCustomerMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> GeneratedCustomerMetadata { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("iap")]
        public virtual IdentityAwareProxy Iap { get; set; }

        /// <summary>
        /// Identifier of the Application resource. This identifier is equivalent to the project ID of the Google Cloud
        /// Platform project where you want to deploy your application. Example: myapp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Location from which this application runs. Application instances run out of the data centers in the
        /// specified location, which is also where all of the application's end user content is stored.Defaults to
        /// us-central.View the list of supported locations (https://cloud.google.com/appengine/docs/locations).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Output only. Full path to the Application resource in the API. Example: apps/myapp.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The service account associated with the application. This is the app-level default identity. If no identity
        /// provided during create version, Admin API will fallback to this one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>Serving status of this application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingStatus")]
        public virtual string ServingStatus { get; set; }

        /// <summary>
        /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS
        /// &amp;lt; 1.2 and allow only Modern Ciphers suite
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslPolicy")]
        public virtual string SslPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An SSL certificate that a user has been authorized to administer. A user is authorized to administer any
    /// certificate that applies to one of their authorized domains.
    /// </summary>
    public class AuthorizedCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The SSL certificate serving the AuthorizedCertificate resource. This must be obtained independently from a
        /// certificate authority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateRawData")]
        public virtual CertificateRawData CertificateRawData { get; set; }

        /// <summary>
        /// The user-specified display name of the certificate. This is not guaranteed to be unique. Example: My
        /// Certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Aggregate count of the domain mappings with this certificate mapped. This count includes domain mappings on
        /// applications for which the user does not have VIEWER permissions.Only returned by GET or LIST requests when
        /// specifically requested by the view=FULL_CERTIFICATE option.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainMappingsCount")]
        public virtual System.Nullable<int> DomainMappingsCount { get; set; }

        /// <summary>
        /// Topmost applicable domains of this certificate. This certificate applies to these domains and their
        /// subdomains. Example: example.com.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainNames")]
        public virtual System.Collections.Generic.IList<string> DomainNames { get; set; }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// The time when this certificate expires. To update the renewal time on this certificate, upload an SSL
        /// certificate with a different expiration time using
        /// AuthorizedCertificates.UpdateAuthorizedCertificate.@OutputOnly
        /// </summary>
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

        /// <summary>
        /// Relative name of the certificate. This is a unique value autogenerated on AuthorizedCertificate resource
        /// creation. Example: 12345.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Only applicable if this certificate is managed by App Engine. Managed certificates are tied to the lifecycle
        /// of a DomainMapping and cannot be updated or deleted via the AuthorizedCertificates API. If this certificate
        /// is manually administered by the user, this field will be empty.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedCertificate")]
        public virtual ManagedCertificate ManagedCertificate { get; set; }

        /// <summary>
        /// Full path to the AuthorizedCertificate resource in the API. Example:
        /// apps/myapp/authorizedCertificates/12345.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The full paths to user visible Domain Mapping resources that have this certificate mapped. Example:
        /// apps/myapp/domainMappings/example.com.This may not represent the full list of mapped domain mappings if the
        /// user does not have VIEWER permissions on all of the applications that have this certificate mapped. See
        /// domain_mappings_count for a complete count.Only returned by GET or LIST requests when specifically requested
        /// by the view=FULL_CERTIFICATE option.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleDomainMappings")]
        public virtual System.Collections.Generic.IList<string> VisibleDomainMappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A domain that a user has been authorized to administer. To authorize use of a domain, verify ownership via
    /// Search Console (https://search.google.com/search-console/welcome).
    /// </summary>
    public class AuthorizedDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Fully qualified domain name of the domain authorized for use. Example: example.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Full path to the AuthorizedDomain resource in the API. Example:
        /// apps/myapp/authorizedDomains/example.com.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Automatic scaling is based on request rate, response latencies, and other application metrics.
    /// </summary>
    public class AutomaticScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The time period that the Autoscaler (https://cloud.google.com/compute/docs/autoscaler/) should wait before
        /// it starts collecting information from a new instance. This prevents the autoscaler from collecting
        /// information when the instance is initializing, during which the collected usage would not be reliable. Only
        /// applicable in the App Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coolDownPeriod")]
        public virtual object CoolDownPeriod { get; set; }

        /// <summary>Target scaling by CPU usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuUtilization")]
        public virtual CpuUtilization CpuUtilization { get; set; }

        /// <summary>
        /// Target scaling by user-provided metrics. Only applicable in the App Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetrics")]
        public virtual System.Collections.Generic.IList<CustomMetric> CustomMetrics { get; set; }

        /// <summary>Target scaling by disk usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskUtilization")]
        public virtual DiskUtilization DiskUtilization { get; set; }

        /// <summary>
        /// Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new
        /// instance.Defaults to a runtime-specific value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxConcurrentRequests")]
        public virtual System.Nullable<int> MaxConcurrentRequests { get; set; }

        /// <summary>Maximum number of idle instances that should be maintained for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIdleInstances")]
        public virtual System.Nullable<int> MaxIdleInstances { get; set; }

        /// <summary>
        /// Maximum amount of time that a request should wait in the pending queue before starting a new instance to
        /// handle it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPendingLatency")]
        public virtual object MaxPendingLatency { get; set; }

        /// <summary>Maximum number of instances that should be started to handle requests for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTotalInstances")]
        public virtual System.Nullable<int> MaxTotalInstances { get; set; }

        /// <summary>
        /// Minimum number of idle instances that should be maintained for this version. Only applicable for the default
        /// version of a service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minIdleInstances")]
        public virtual System.Nullable<int> MinIdleInstances { get; set; }

        /// <summary>
        /// Minimum amount of time a request should wait in the pending queue before starting a new instance to handle
        /// it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minPendingLatency")]
        public virtual object MinPendingLatency { get; set; }

        /// <summary>Minimum number of running instances that should be maintained for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minTotalInstances")]
        public virtual System.Nullable<int> MinTotalInstances { get; set; }

        /// <summary>Target scaling by network usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkUtilization")]
        public virtual NetworkUtilization NetworkUtilization { get; set; }

        /// <summary>Target scaling by request utilization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestUtilization")]
        public virtual RequestUtilization RequestUtilization { get; set; }

        /// <summary>Scheduler settings for standard environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardSchedulerSettings")]
        public virtual StandardSchedulerSettings StandardSchedulerSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A service with basic scaling will create an instance when the application receives a request. The instance will
    /// be turned down when the app becomes idle. Basic scaling is ideal for work that is intermittent or driven by user
    /// activity.
    /// </summary>
    public class BasicScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Duration of time after the last request that an instance must wait before the instance is shut down.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idleTimeout")]
        public virtual object IdleTimeout { get; set; }

        /// <summary>Maximum number of instances to create for this version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstances")]
        public virtual System.Nullable<int> MaxInstances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for Firewall.BatchUpdateIngressRules.</summary>
    public class BatchUpdateIngressRulesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of FirewallRules to replace the existing set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressRules")]
        public virtual System.Collections.Generic.IList<FirewallRule> IngressRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Firewall.UpdateAllIngressRules.</summary>
    public class BatchUpdateIngressRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full list of ingress FirewallRules for this application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressRules")]
        public virtual System.Collections.Generic.IList<FirewallRule> IngressRules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Cloud Build information.</summary>
    public class BuildInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Google Cloud Build id. Example: "f966068f-08b2-42c8-bdfe-74137dff2bf9"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBuildId")]
        public virtual string CloudBuildId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An SSL certificate obtained from a certificate authority.</summary>
    public class CertificateRawData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unencrypted PEM encoded RSA private key. This field is set once on certificate creation and then encrypted.
        /// The key size must be 2048 bits or fewer. Must include the header and footer. Example: -----BEGIN RSA PRIVATE
        /// KEY----- -----END RSA PRIVATE KEY----- @InputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKey")]
        public virtual string PrivateKey { get; set; }

        /// <summary>
        /// PEM encoded x.509 public key certificate. This field is set once on certificate creation. Must include the
        /// header and footer. Example: -----BEGIN CERTIFICATE----- -----END CERTIFICATE-----
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicCertificate")]
        public virtual string PublicCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Options for the build operations performed as a part of the version deployment. Only applicable for App Engine
    /// flexible environment when creating a version using source code directly.
    /// </summary>
    public class CloudBuildOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Path to the yaml file used in deployment, used to determine runtime configuration details.Required for
        /// flexible environment builds.See https://cloud.google.com/appengine/docs/standard/python/config/appref for
        /// more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appYamlPath")]
        public virtual string AppYamlPath { get; set; }

        /// <summary>
        /// The Cloud Build timeout used as part of any dependent builds performed by version creation. Defaults to 10
        /// minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBuildTimeout")]
        public virtual object CloudBuildTimeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Docker image that is used to create a container and start a VM instance for the version that you deploy. Only
    /// applicable for instances running in the App Engine flexible environment.
    /// </summary>
    public class ContainerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URI to the hosted container image in Google Container Registry. The URI must be fully qualified and include
        /// a tag or digest. Examples: "gcr.io/my-project/image:tag" or "gcr.io/my-project/image@digest"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ContainerState contains the externally-visible container state that is used to communicate the state and
    /// reasoning for that state to the CLH. This data is not persisted by CCFE, but is instead derived from CCFE's
    /// internal representation of the container state.
    /// </summary>
    public class ContainerState : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("currentReasons")]
        public virtual Reasons CurrentReasons { get; set; }

        /// <summary>
        /// The previous and current reasons for a container state will be sent for a container event. CLHs that need to
        /// know the signal that caused the container event to trigger (edges) as opposed to just knowing the state can
        /// act upon differences in the previous and current reasons.Reasons will be provided for every system: service
        /// management, data governance, abuse, and billing.If this is a CCFE-triggered event used for reconciliation
        /// then the current reasons will be set to their *_CONTROL_PLANE_SYNC state. The previous reasons will contain
        /// the last known set of non-unknown non-control_plane_sync reasons for the state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousReasons")]
        public virtual Reasons PreviousReasons { get; set; }

        /// <summary>
        /// The current state of the container. This state is the culmination of all of the opinions from external
        /// systems that CCFE knows about of the container.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Target scaling by CPU usage.</summary>
    public class CpuUtilization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Period of time over which CPU utilization is calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationWindowLength")]
        public virtual object AggregationWindowLength { get; set; }

        /// <summary>Target CPU utilization ratio to maintain when scaling. Must be between 0 and 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetUtilization")]
        public virtual System.Nullable<double> TargetUtilization { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for the given google.longrunning.Operation during a google.appengine.v1.CreateVersionRequest.
    /// </summary>
    public class CreateVersionMetadataV1 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Build ID if one was created as part of the version create. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBuildId")]
        public virtual string CloudBuildId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for the given google.longrunning.Operation during a google.appengine.v1alpha.CreateVersionRequest.
    /// </summary>
    public class CreateVersionMetadataV1Alpha : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Build ID if one was created as part of the version create. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBuildId")]
        public virtual string CloudBuildId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for the given google.longrunning.Operation during a google.appengine.v1beta.CreateVersionRequest.
    /// </summary>
    public class CreateVersionMetadataV1Beta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Build ID if one was created as part of the version create. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBuildId")]
        public virtual string CloudBuildId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Allows autoscaling based on Stackdriver metrics.</summary>
    public class CustomMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allows filtering on the metric's fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The name of the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>
        /// May be used instead of target_utilization when an instance can handle a specific amount of work/resources
        /// and the metric value is equal to the current amount of work remaining. The autoscaler will try to keep the
        /// number of instances equal to the metric value divided by single_instance_assignment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleInstanceAssignment")]
        public virtual System.Nullable<double> SingleInstanceAssignment { get; set; }

        /// <summary>
        /// The type of the metric. Must be a string representing a Stackdriver metric type e.g. GAGUE,
        /// DELTA_PER_SECOND, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetType")]
        public virtual string TargetType { get; set; }

        /// <summary>The target value for the metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetUtilization")]
        public virtual System.Nullable<double> TargetUtilization { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: A full date, with non-zero year, month, and day values. A month and day, with a zero year (for
    /// example, an anniversary). A year on its own, with a zero month and a zero day. A year and month, with a zero day
    /// (for example, a credit card expiration date).Related types: google.type.TimeOfDay google.type.DateTime
    /// google.protobuf.Timestamp
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

    /// <summary>Request message for Instances.DebugInstance.</summary>
    public class DebugInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Public SSH key to add to the instance. Examples: [USERNAME]:ssh-rsa [KEY_VALUE] [USERNAME]
        /// [USERNAME]:ssh-rsa [KEY_VALUE] google-ssh {"userName":"[USERNAME]","expireOn":"[EXPIRE_TIME]"}For more
        /// information, see Adding and Removing SSH Keys
        /// (https://cloud.google.com/compute/docs/instances/adding-removing-ssh-keys).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshKey")]
        public virtual string SshKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Code and application artifacts used to deploy a version to App Engine.</summary>
    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Google Cloud Build build information. Only applicable for instances running in the App Engine flexible
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("build")]
        public virtual BuildInfo Build { get; set; }

        /// <summary>
        /// Options for any Google Cloud Build builds created as a part of this deployment.These options will only be
        /// used if a new build is created, such as when deploying to the App Engine flexible environment using files or
        /// zip.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudBuildOptions")]
        public virtual CloudBuildOptions CloudBuildOptions { get; set; }

        /// <summary>
        /// The Docker image for the container that runs the version. Only applicable for instances running in the App
        /// Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual ContainerInfo Container { get; set; }

        /// <summary>
        /// Manifest of the files stored in Google Cloud Storage that are included as part of this version. All files
        /// must be readable using the credentials supplied with this call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IDictionary<string, FileInfo> Files { get; set; }

        /// <summary>The zip file for this deployment, if this is a zip deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zip")]
        public virtual ZipInfo Zip { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Target scaling by disk usage. Only applicable in the App Engine flexible environment.</summary>
    public class DiskUtilization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target bytes read per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetReadBytesPerSecond")]
        public virtual System.Nullable<int> TargetReadBytesPerSecond { get; set; }

        /// <summary>Target ops read per seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetReadOpsPerSecond")]
        public virtual System.Nullable<int> TargetReadOpsPerSecond { get; set; }

        /// <summary>Target bytes written per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetWriteBytesPerSecond")]
        public virtual System.Nullable<int> TargetWriteBytesPerSecond { get; set; }

        /// <summary>Target ops written per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetWriteOpsPerSecond")]
        public virtual System.Nullable<int> TargetWriteOpsPerSecond { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A domain serving an App Engine application.</summary>
    public class DomainMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Relative name of the domain serving the application. Example: example.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Full path to the DomainMapping resource in the API. Example:
        /// apps/myapp/domainMapping/example.com.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The resource records required to configure this domain mapping. These records must be added to the domain's
        /// DNS configuration in order to serve the application via this domain mapping.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceRecords")]
        public virtual System.Collections.Generic.IList<ResourceRecord> ResourceRecords { get; set; }

        /// <summary>SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslSettings")]
        public virtual SslSettings SslSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Google Cloud Endpoints (https://cloud.google.com/endpoints) configuration. The Endpoints API Service provides
    /// tooling for serving Open API and gRPC endpoints via an NGINX proxy. Only valid for App Engine Flexible
    /// environment deployments.The fields here refer to the name and configuration ID of a "service" resource in the
    /// Service Management API (https://cloud.google.com/service-management/overview).
    /// </summary>
    public class EndpointsApiService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Endpoints service configuration ID as specified by the Service Management API. For example "2016-09-19r1".By
        /// default, the rollout strategy for Endpoints is RolloutStrategy.FIXED. This means that Endpoints starts up
        /// with a particular configuration ID. When a new configuration is rolled out, Endpoints must be given the new
        /// configuration ID. The config_id field is used to give the configuration ID and is required in this
        /// case.Endpoints also has a rollout strategy called RolloutStrategy.MANAGED. When using this, Endpoints
        /// fetches the latest configuration and does not need the configuration ID. In this case, config_id must be
        /// omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configId")]
        public virtual string ConfigId { get; set; }

        /// <summary>Enable or disable trace sampling. By default, this is set to false for enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableTraceSampling")]
        public virtual System.Nullable<bool> DisableTraceSampling { get; set; }

        /// <summary>
        /// Endpoints service name which is the name of the "service" resource in the Service Management API. For
        /// example "myapi.endpoints.myproject.cloud.goog"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Endpoints rollout strategy. If FIXED, config_id must be specified. If MANAGED, config_id must be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutStrategy")]
        public virtual string RolloutStrategy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The entrypoint for the application.</summary>
    public class Entrypoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The format should be a shell command that can be fed to bash -c.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shell")]
        public virtual string Shell { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom static error page to be served when an error occurs.</summary>
    public class ErrorHandler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error condition this handler applies to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>MIME type of file. Defaults to text/html.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Static file content to be served for this error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticFile")]
        public virtual string StaticFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The feature specific settings to be used in the application. These define behaviors that are user configurable.
    /// </summary>
    public class FeatureSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Boolean value indicating if split health checks should be used instead of the legacy health checks. At an
        /// app.yaml level, this means defaulting to 'readiness_check' and 'liveness_check' values instead of
        /// 'health_check' ones. Once the legacy 'health_check' behavior is deprecated, and this value is always true,
        /// this setting can be removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitHealthChecks")]
        public virtual System.Nullable<bool> SplitHealthChecks { get; set; }

        /// <summary>
        /// If true, use Container-Optimized OS (https://cloud.google.com/container-optimized-os/) base image for VMs,
        /// rather than a base Debian image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useContainerOptimizedOs")]
        public virtual System.Nullable<bool> UseContainerOptimizedOs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Single source file that is part of the version to be deployed. Each source file that is deployed must be
    /// specified separately.
    /// </summary>
    public class FileInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The MIME type of the file.Defaults to the value from Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The SHA1 hash of the file, in hex.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Sum")]
        public virtual string Sha1Sum { get; set; }

        /// <summary>
        /// URL source to use to fetch this file. Must be a URL to a resource in Google Cloud Storage in the form
        /// 'http(s)://storage.googleapis.com//'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUrl")]
        public virtual string SourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single firewall rule that is evaluated against incoming traffic and provides an action to take on matched
    /// requests.
    /// </summary>
    public class FirewallRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action to take on matched requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// An optional string description of this rule. This field has a maximum length of 400 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A positive integer between 1, Int32.MaxValue-1 that defines the order of rule evaluation. Rules with the
        /// lowest priority are evaluated first.A default rule at priority Int32.MaxValue matches all IPv4 and IPv6
        /// traffic when no previous rule matches. Only the action of this rule can be modified by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>
        /// IP address or range, defined using CIDR notation, of requests that this rule applies to. You can use the
        /// wildcard character "*" to match all IPs equivalent to "0/0" and "::/0" together. Examples: 192.168.1.1 or
        /// 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334. Truncation will be silently
        /// performed on addresses which are not properly truncated. For example, 1.2.3.4/24 is accepted as the same
        /// address as 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 is accepted as the same address as 2001:db8::/32.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRange")]
        public virtual string SourceRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime settings for the App Engine flexible environment.</summary>
    public class FlexibleRuntimeSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operating system of the application runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual string OperatingSystem { get; set; }

        /// <summary>The runtime version of an App Engine flexible application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeVersion")]
        public virtual string RuntimeVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>For use only by GCE. GceTag is a wrapper around the GCE administrative tag with parent info.</summary>
    public class GceTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The parents(s) of the tag. Eg. projects/123, folders/456 It usually contains only one parent. But, in some
        /// corner cases, it can contain multiple parents. Currently, organizations are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual System.Collections.Generic.IList<string> Parent { get; set; }

        /// <summary>The administrative_tag name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the given google.cloud.location.Location.</summary>
    public class GoogleAppengineV1betaLocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App Engine flexible environment is available in the given location.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flexibleEnvironmentAvailable")]
        public virtual System.Nullable<bool> FlexibleEnvironmentAvailable { get; set; }

        /// <summary>
        /// Output only. Search API (https://cloud.google.com/appengine/docs/standard/python/search) is available in the
        /// given location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchApiAvailable")]
        public virtual System.Nullable<bool> SearchApiAvailable { get; set; }

        /// <summary>App Engine standard environment is available in the given location.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardEnvironmentAvailable")]
        public virtual System.Nullable<bool> StandardEnvironmentAvailable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Health checking configuration for VM instances. Unhealthy instances are killed and replaced with new instances.
    /// Only applicable for instances in App Engine flexible environment.
    /// </summary>
    public class HealthCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Interval between health checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkInterval")]
        public virtual object CheckInterval { get; set; }

        /// <summary>Whether to explicitly disable health checks for this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableHealthCheck")]
        public virtual System.Nullable<bool> DisableHealthCheck { get; set; }

        /// <summary>Number of consecutive successful health checks required before receiving traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthyThreshold")]
        public virtual System.Nullable<long> HealthyThreshold { get; set; }

        /// <summary>Host header to send when performing an HTTP health check. Example: "myapp.appspot.com"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>Number of consecutive failed health checks required before an instance is restarted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restartThreshold")]
        public virtual System.Nullable<long> RestartThreshold { get; set; }

        /// <summary>Time before the health check is considered failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>Number of consecutive failed health checks required before removing traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unhealthyThreshold")]
        public virtual System.Nullable<long> UnhealthyThreshold { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identity-Aware Proxy</summary>
    public class IdentityAwareProxy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the serving infrastructure will authenticate and authorize all incoming requests.If true, the
        /// oauth2_client_id and oauth2_client_secret fields must be non-empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>OAuth2 client ID to use for the authentication flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientId")]
        public virtual string Oauth2ClientId { get; set; }

        /// <summary>
        /// OAuth2 client secret to use for the authentication flow.For security reasons, this value cannot be retrieved
        /// via the API. Instead, the SHA-256 hash of the value is returned in the oauth2_client_secret_sha256
        /// field.@InputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientSecret")]
        public virtual string Oauth2ClientSecret { get; set; }

        /// <summary>Output only. Hex-encoded SHA-256 hash of the client secret.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauth2ClientSecretSha256")]
        public virtual string Oauth2ClientSecretSha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Instance resource is the computing unit that App Engine uses to automatically scale an application.
    /// </summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. App Engine release this instance is running on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineRelease")]
        public virtual string AppEngineRelease { get; set; }

        /// <summary>Output only. Availability of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        /// <summary>Output only. Average latency (ms) over the last minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageLatency")]
        public virtual System.Nullable<int> AverageLatency { get; set; }

        /// <summary>Output only. Number of errors since this instance was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Nullable<int> Errors { get; set; }

        /// <summary>Output only. Relative name of the instance within the version. Example: instance-1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. Total memory in use (bytes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryUsage")]
        public virtual System.Nullable<long> MemoryUsage { get; set; }

        /// <summary>
        /// Output only. Full path to the Instance resource in the API. Example:
        /// apps/myapp/services/default/versions/v1/instances/instance-1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Average queries per second (QPS) over the last minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qps")]
        public virtual System.Nullable<float> Qps { get; set; }

        /// <summary>Output only. Number of requests since this instance was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Nullable<int> Requests { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Time that this instance was started.@OutputOnly</summary>
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

        /// <summary>
        /// Output only. Whether this instance is in debug mode. Only applicable for instances in App Engine flexible
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmDebugEnabled")]
        public virtual System.Nullable<bool> VmDebugEnabled { get; set; }

        /// <summary>
        /// Output only. Virtual machine ID of this instance. Only applicable for instances in App Engine flexible
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmId")]
        public virtual string VmId { get; set; }

        /// <summary>
        /// Output only. The IP address of this instance. Only applicable for instances in App Engine flexible
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmIp")]
        public virtual string VmIp { get; set; }

        /// <summary>
        /// Output only. The liveness health check of this instance. Only applicable for instances in App Engine
        /// flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmLiveness")]
        public virtual string VmLiveness { get; set; }

        /// <summary>
        /// Output only. Name of the virtual machine where this instance lives. Only applicable for instances in App
        /// Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmName")]
        public virtual string VmName { get; set; }

        /// <summary>
        /// Output only. Status of the virtual machine where this instance lives. Only applicable for instances in App
        /// Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmStatus")]
        public virtual string VmStatus { get; set; }

        /// <summary>
        /// Output only. Zone where the virtual machine is located. Only applicable for instances in App Engine flexible
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmZoneName")]
        public virtual string VmZoneName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Third-party Python runtime library that is required by the application.</summary>
    public class Library : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the library. Example: "django".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Version of the library to select, or "latest".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AuthorizedCertificates.ListAuthorizedCertificates.</summary>
    public class ListAuthorizedCertificatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SSL certificates the user is authorized to administer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificates")]
        public virtual System.Collections.Generic.IList<AuthorizedCertificate> Certificates { get; set; }

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AuthorizedDomains.ListAuthorizedDomains.</summary>
    public class ListAuthorizedDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The authorized domains belonging to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<AuthorizedDomain> Domains { get; set; }

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DomainMappings.ListDomainMappings.</summary>
    public class ListDomainMappingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain mappings for the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainMappings")]
        public virtual System.Collections.Generic.IList<DomainMapping> DomainMappings { get; set; }

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Firewall.ListIngressRules.</summary>
    public class ListIngressRulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ingress FirewallRules for this application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressRules")]
        public virtual System.Collections.Generic.IList<FirewallRule> IngressRules { get; set; }

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Instances.ListInstances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The instances belonging to the requested version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; }

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>Response message for Applications.ListRuntimes.</summary>
    public class ListRuntimesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The runtimes available to the requested application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimes")]
        public virtual System.Collections.Generic.IList<Runtime> Runtimes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Services.ListServices.</summary>
    public class ListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The services belonging to the requested application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<Service> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Versions.ListVersions.</summary>
    public class ListVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The versions belonging to the requested service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<Version> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Health checking configuration for VM instances. Unhealthy instances are killed and replaced with new instances.
    /// </summary>
    public class LivenessCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Interval between health checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkInterval")]
        public virtual object CheckInterval { get; set; }

        /// <summary>Number of consecutive failed checks required before considering the VM unhealthy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureThreshold")]
        public virtual System.Nullable<long> FailureThreshold { get; set; }

        /// <summary>Host header to send when performing a HTTP Liveness check. Example: "myapp.appspot.com"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>The initial delay before starting to execute the checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDelay")]
        public virtual object InitialDelay { get; set; }

        /// <summary>The request path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Number of consecutive successful checks required before considering the VM healthy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successThreshold")]
        public virtual System.Nullable<long> SuccessThreshold { get; set; }

        /// <summary>Time before the check is considered failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

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

        /// <summary>The canonical id for this location. For example: "us-east1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// "projects/example-project/locations/us-east1"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the given google.cloud.location.Location.</summary>
    public class LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App Engine flexible environment is available in the given location.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flexibleEnvironmentAvailable")]
        public virtual System.Nullable<bool> FlexibleEnvironmentAvailable { get; set; }

        /// <summary>
        /// Output only. Search API (https://cloud.google.com/appengine/docs/standard/python/search) is available in the
        /// given location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchApiAvailable")]
        public virtual System.Nullable<bool> SearchApiAvailable { get; set; }

        /// <summary>App Engine standard environment is available in the given location.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardEnvironmentAvailable")]
        public virtual System.Nullable<bool> StandardEnvironmentAvailable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A certificate managed by App Engine.</summary>
    public class ManagedCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastRenewalTimeRaw;

        private object _lastRenewalTime;

        /// <summary>
        /// Time at which the certificate was last renewed. The renewal process is fully managed. Certificate renewal
        /// will automatically occur before the certificate expires. Renewal errors can be tracked via
        /// ManagementStatus.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRenewalTime")]
        public virtual string LastRenewalTimeRaw
        {
            get => _lastRenewalTimeRaw;
            set
            {
                _lastRenewalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastRenewalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastRenewalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastRenewalTimeDateTimeOffset instead.")]
        public virtual object LastRenewalTime
        {
            get => _lastRenewalTime;
            set
            {
                _lastRenewalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastRenewalTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastRenewalTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastRenewalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastRenewalTimeRaw);
            set => LastRenewalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Status of certificate management. Refers to the most recent certificate acquisition or renewal
        /// attempt.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on the
    /// state of its memory over time.
    /// </summary>
    public class ManualScaling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Number of instances to assign to the service at the start. This number can later be altered by using the
        /// Modules API (https://cloud.google.com/appengine/docs/python/modules/functions) set_num_instances() function.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Nullable<int> Instances { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Extra network settings. Only applicable in the App Engine flexible environment.</summary>
    public class Network : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of ports, or port pairs, to forward from the virtual machine to the application container. Only
        /// applicable in the App Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forwardedPorts")]
        public virtual System.Collections.Generic.IList<string> ForwardedPorts { get; set; }

        /// <summary>The IP mode for instances. Only applicable in the App Engine flexible environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceIpMode")]
        public virtual string InstanceIpMode { get; set; }

        /// <summary>
        /// Tag to apply to the instance during creation. Only applicable in the App Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceTag")]
        public virtual string InstanceTag { get; set; }

        /// <summary>
        /// Google Compute Engine network where the virtual machines are created. Specify the short name, not the
        /// resource path.Defaults to default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Enable session affinity. Only applicable in the App Engine flexible environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionAffinity")]
        public virtual System.Nullable<bool> SessionAffinity { get; set; }

        /// <summary>
        /// Google Cloud Platform sub-network where the virtual machines are created. Specify the short name, not the
        /// resource path.If a subnetwork name is specified, a network name will also be required unless it is for the
        /// default network. If the network that the instance is being created in is a Legacy network, then the IP
        /// address is allocated from the IPv4Range. If the network that the instance is being created in is an auto
        /// Subnet Mode Network, then only network name should be specified (not the subnetwork_name) and the IP address
        /// is created from the IPCidrRange of the subnetwork that exists in that zone for that network. If the network
        /// that the instance is being created in is a custom Subnet Mode Network, then the subnetwork_name must be
        /// specified and the IP address is created from the IPCidrRange of the subnetwork.If specified, the subnetwork
        /// must exist in the same region as the App Engine flexible environment application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetworkName")]
        public virtual string SubnetworkName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A NetworkSettings resource is a container for ingress settings for a version or service.</summary>
    public class NetworkSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ingress settings for version or service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressTrafficAllowed")]
        public virtual string IngressTrafficAllowed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Target scaling by network usage. Only applicable in the App Engine flexible environment.</summary>
    public class NetworkUtilization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target bytes received per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetReceivedBytesPerSecond")]
        public virtual System.Nullable<int> TargetReceivedBytesPerSecond { get; set; }

        /// <summary>Target packets received per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetReceivedPacketsPerSecond")]
        public virtual System.Nullable<int> TargetReceivedPacketsPerSecond { get; set; }

        /// <summary>Target bytes sent per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSentBytesPerSecond")]
        public virtual System.Nullable<int> TargetSentBytesPerSecond { get; set; }

        /// <summary>Target packets sent per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetSentPacketsPerSecond")]
        public virtual System.Nullable<int> TargetSentPacketsPerSecond { get; set; }

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
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// Delete, the response is google.protobuf.Empty. If the original method is standard Get/Create/Update, the
        /// response should be the resource. For other methods, the response should have the type XxxResponse, where Xxx
        /// is the original method name. For example, if the original method name is TakeSnapshot(), the inferred
        /// response type is TakeSnapshotResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the given google.longrunning.Operation.</summary>
    public class OperationMetadataV1 : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("createVersionMetadata")]
        public virtual CreateVersionMetadataV1 CreateVersionMetadata { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Time that this operation completed.@OutputOnly</summary>
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

        /// <summary>Ephemeral message that may change every time the operation is polled. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralMessage")]
        public virtual string EphemeralMessage { get; set; }

        private string _insertTimeRaw;

        private object _insertTime;

        /// <summary>Time that this operation was created.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTimeRaw
        {
            get => _insertTimeRaw;
            set
            {
                _insertTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _insertTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InsertTimeDateTimeOffset instead.")]
        public virtual object InsertTime
        {
            get => _insertTime;
            set
            {
                _insertTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _insertTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InsertTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InsertTimeRaw);
            set => InsertTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// API method that initiated this operation. Example: google.appengine.v1.Versions.CreateVersion.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Name of the resource that this operation is acting on. Example: apps/myapp/services/default.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>User who requested this operation.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>Durable messages that persist on every operation poll. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual System.Collections.Generic.IList<string> Warning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the given google.longrunning.Operation.</summary>
    public class OperationMetadataV1Alpha : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("createVersionMetadata")]
        public virtual CreateVersionMetadataV1Alpha CreateVersionMetadata { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Time that this operation completed.@OutputOnly</summary>
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

        /// <summary>Ephemeral message that may change every time the operation is polled. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralMessage")]
        public virtual string EphemeralMessage { get; set; }

        private string _insertTimeRaw;

        private object _insertTime;

        /// <summary>Time that this operation was created.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTimeRaw
        {
            get => _insertTimeRaw;
            set
            {
                _insertTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _insertTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InsertTimeDateTimeOffset instead.")]
        public virtual object InsertTime
        {
            get => _insertTime;
            set
            {
                _insertTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _insertTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InsertTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InsertTimeRaw);
            set => InsertTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// API method that initiated this operation. Example:
        /// google.appengine.v1alpha.Versions.CreateVersion.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Name of the resource that this operation is acting on. Example: apps/myapp/services/default.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>User who requested this operation.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>Durable messages that persist on every operation poll. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual System.Collections.Generic.IList<string> Warning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the given google.longrunning.Operation.</summary>
    public class OperationMetadataV1Beta : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("createVersionMetadata")]
        public virtual CreateVersionMetadataV1Beta CreateVersionMetadata { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Time that this operation completed.@OutputOnly</summary>
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

        /// <summary>Ephemeral message that may change every time the operation is polled. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ephemeralMessage")]
        public virtual string EphemeralMessage { get; set; }

        private string _insertTimeRaw;

        private object _insertTime;

        /// <summary>Time that this operation was created.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertTime")]
        public virtual string InsertTimeRaw
        {
            get => _insertTimeRaw;
            set
            {
                _insertTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _insertTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use InsertTimeDateTimeOffset instead.")]
        public virtual object InsertTime
        {
            get => _insertTime;
            set
            {
                _insertTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _insertTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="InsertTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? InsertTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(InsertTimeRaw);
            set => InsertTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// API method that initiated this operation. Example:
        /// google.appengine.v1beta.Versions.CreateVersion.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Name of the resource that this operation is acting on. Example: apps/myapp/services/default.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>User who requested this operation.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>Durable messages that persist on every operation poll. @OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual System.Collections.Generic.IList<string> Warning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request sent to CLHs during project events.</summary>
    public class ProjectEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique ID for this project event. CLHs can use this value to dedup repeated calls. required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>
        /// Phase indicates when in the container event propagation this event is being communicated. Events are sent
        /// before and after the per-resource events are propagated. required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phase")]
        public virtual string Phase { get; set; }

        /// <summary>The projects metadata for this project. required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectMetadata")]
        public virtual ProjectsMetadata ProjectMetadata { get; set; }

        /// <summary>The state of the organization that led to this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual ContainerState State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ProjectsMetadata is the metadata CCFE stores about the all the relevant projects (tenant, consumer, producer).
    /// </summary>
    public class ProjectsMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The consumer project id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerProjectId")]
        public virtual string ConsumerProjectId { get; set; }

        /// <summary>The consumer project number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerProjectNumber")]
        public virtual System.Nullable<long> ConsumerProjectNumber { get; set; }

        /// <summary>
        /// The CCFE state of the consumer project. It is the same state that is communicated to the CLH during project
        /// events. Notice that this field is not set in the DB, it is only set in this proto when communicated to CLH
        /// in the side channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerProjectState")]
        public virtual string ConsumerProjectState { get; set; }

        /// <summary>
        /// The GCE tags associated with the consumer project and those inherited due to their ancestry, if any. Not
        /// supported by CCFE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gceTag")]
        public virtual System.Collections.Generic.IList<GceTag> GceTag { get; set; }

        /// <summary>
        /// The service account authorized to operate on the consumer project. Note: CCFE only propagates P4SA with
        /// default tag to CLH.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("p4ServiceAccount")]
        public virtual string P4ServiceAccount { get; set; }

        /// <summary>The producer project id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerProjectId")]
        public virtual string ProducerProjectId { get; set; }

        /// <summary>The producer project number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerProjectNumber")]
        public virtual System.Nullable<long> ProducerProjectNumber { get; set; }

        /// <summary>The tenant project id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectId")]
        public virtual string TenantProjectId { get; set; }

        /// <summary>The tenant project number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectNumber")]
        public virtual System.Nullable<long> TenantProjectNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Readiness checking configuration for VM instances. Unhealthy instances are removed from traffic rotation.
    /// </summary>
    public class ReadinessCheck : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A maximum time limit on application initialization, measured from moment the application successfully
        /// replies to a healthcheck until it is ready to serve traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appStartTimeout")]
        public virtual object AppStartTimeout { get; set; }

        /// <summary>Interval between health checks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkInterval")]
        public virtual object CheckInterval { get; set; }

        /// <summary>Number of consecutive failed checks required before removing traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureThreshold")]
        public virtual System.Nullable<long> FailureThreshold { get; set; }

        /// <summary>Host header to send when performing a HTTP Readiness check. Example: "myapp.appspot.com"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>The request path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Number of consecutive successful checks required before receiving traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successThreshold")]
        public virtual System.Nullable<long> SuccessThreshold { get; set; }

        /// <summary>Time before the check is considered failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Containers transition between and within states based on reasons sent from various systems. CCFE will provide
    /// the CLH with reasons for the current state per system.The current systems that CCFE supports are: Service
    /// Management (Inception) Data Governance (Wipeout) Abuse (Ares) Billing (Internal Cloud Billing API) Service
    /// Activation (Service Controller)
    /// </summary>
    public class Reasons : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("abuse")]
        public virtual string Abuse { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("billing")]
        public virtual string Billing { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dataGovernance")]
        public virtual string DataGovernance { get; set; }

        /// <summary>
        /// Consumer Container denotes if the service is active within a project or not. This information could be used
        /// to clean up resources in case service in DISABLED_FULL i.e. Service is inactive &amp;gt; 30 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceActivation")]
        public virtual string ServiceActivation { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("serviceManagement")]
        public virtual string ServiceManagement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for 'Applications.RepairApplication'.</summary>
    public class RepairApplicationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Target scaling by request utilization. Only applicable in the App Engine flexible environment.
    /// </summary>
    public class RequestUtilization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target number of concurrent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetConcurrentRequests")]
        public virtual System.Nullable<int> TargetConcurrentRequests { get; set; }

        /// <summary>Target requests per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRequestCountPerSecond")]
        public virtual System.Nullable<int> TargetRequestCountPerSecond { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request that is passed to CLH during per-resource events. The request will be sent with update semantics in
    /// all cases except for data governance purge events. These events will be sent with delete semantics and the CLH
    /// is expected to delete the resource receiving this event.
    /// </summary>
    public class ResourceEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique ID for this per-resource event. CLHs can use this value to dedup repeated calls. required
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        /// <summary>The name of the resource for which this event is. required</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The state of the project that led to this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual ContainerState State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A DNS resource record.</summary>
    public class ResourceRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Relative name of the object affected by this record. Only applicable for CNAME records. Example: 'www'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Data for this record. Values vary by record type, as defined in RFC 1035 (section 5) and RFC 1034 (section
        /// 3.6.1).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rrdata")]
        public virtual string Rrdata { get; set; }

        /// <summary>Resource record type. Example: AAAA.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Machine resources for a version.</summary>
    public class Resources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of CPU cores needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpu")]
        public virtual System.Nullable<double> Cpu { get; set; }

        /// <summary>Disk size (GB) needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskGb")]
        public virtual System.Nullable<double> DiskGb { get; set; }

        /// <summary>
        /// The name of the encryption key that is stored in Google Cloud KMS. Only should be used by Cloud Composer to
        /// encrypt the vm disk
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyReference")]
        public virtual string KmsKeyReference { get; set; }

        /// <summary>Memory (GB) needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryGb")]
        public virtual System.Nullable<double> MemoryGb { get; set; }

        /// <summary>User specified volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Runtime versions for App Engine.</summary>
    public class Runtime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Date when Runtime is decommissioned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("decommissionedDate")]
        public virtual Date DecommissionedDate { get; set; }

        /// <summary>Date when Runtime is deprecated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deprecationDate")]
        public virtual Date DeprecationDate { get; set; }

        /// <summary>User-friendly display name, e.g. 'Node.js 12', etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Date when Runtime is end of support.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOfSupportDate")]
        public virtual Date EndOfSupportDate { get; set; }

        /// <summary>The environment of the runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual string Environment { get; set; }

        /// <summary>The name of the runtime, e.g., 'go113', 'nodejs12', etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The stage of life this runtime is in, e.g., BETA, GA, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>Supported operating systems for the runtime, e.g., 'ubuntu22', etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedOperatingSystems")]
        public virtual System.Collections.Generic.IList<string> SupportedOperatingSystems { get; set; }

        /// <summary>Warning messages, e.g., a deprecation warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Executes a script to handle the request that matches the URL pattern.</summary>
    public class ScriptHandler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path to the script from the application root directory.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scriptPath")]
        public virtual string ScriptPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Service resource is a logical component of an application that can share state and communicate in a secure
    /// fashion with other services. For example, an application that handles customer requests might include separate
    /// services to handle tasks such as backend data analysis or API requests from mobile devices. Each service has a
    /// collection of versions that define a specific set of code used to implement the functionality of that service.
    /// </summary>
    public class Service : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional Google Generated Customer Metadata, this field won't be provided by default and can be requested
        /// by setting the IncludeExtraData field in GetServiceRequest
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedCustomerMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> GeneratedCustomerMetadata { get; set; }

        /// <summary>
        /// Output only. Relative name of the service within the application. Example: default.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A set of labels to apply to this service. Labels are key/value pairs that describe the service and all
        /// resources that belong to it (e.g., versions). The labels can be used to search and group resources, and are
        /// propagated to the usage and billing reports, enabling fine-grain analysis of costs. An example of using
        /// labels is to tag resources belonging to different environments (e.g., "env=prod", "env=qa"). Label keys and
        /// values can be no longer than 63 characters and can only contain lowercase letters, numeric characters,
        /// underscores, dashes, and international characters. Label keys must start with a lowercase letter or an
        /// international character. Each service can have at most 32 labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Full path to the Service resource in the API. Example: apps/myapp/services/default.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Ingress settings for this service. Will apply to all versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkSettings")]
        public virtual NetworkSettings NetworkSettings { get; set; }

        /// <summary>
        /// Mapping that defines fractional HTTP traffic diversion to different versions within the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("split")]
        public virtual TrafficSplit Split { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SSL configuration for a DomainMapping resource.</summary>
    public class SslSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
        /// remove SSL support.By default, a managed certificate is automatically created for every domain mapping. To
        /// omit SSL support or to configure SSL manually, specify SslManagementType.MANUAL on a CREATE or UPDATE
        /// request. You must be authorized to administer the AuthorizedCertificate resource to manually map it to a
        /// DomainMapping resource. Example: 12345.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateId")]
        public virtual string CertificateId { get; set; }

        /// <summary>
        /// ID of the managed AuthorizedCertificate resource currently being provisioned, if applicable. Until the new
        /// managed certificate has been successfully provisioned, the previous SSL state will be preserved. Once the
        /// provisioning process completes, the certificate_id field will reflect the new managed certificate and this
        /// field will be left empty. To remove SSL support while there is still a pending managed certificate, clear
        /// the certificate_id field with an UpdateDomainMappingRequest.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingManagedCertificateId")]
        public virtual string PendingManagedCertificateId { get; set; }

        /// <summary>
        /// SSL management type for this domain. If AUTOMATIC, a managed certificate is automatically provisioned. If
        /// MANUAL, certificate_id must be manually specified in order to configure SSL for this domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslManagementType")]
        public virtual string SslManagementType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Scheduler settings for standard environment.</summary>
    public class StandardSchedulerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of instances to run for this version. Set to 2147483647 to disable max_instances
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInstances")]
        public virtual System.Nullable<int> MaxInstances { get; set; }

        /// <summary>
        /// Minimum number of instances to run for this version. Set to zero to disable min_instances configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minInstances")]
        public virtual System.Nullable<int> MinInstances { get; set; }

        /// <summary>Target CPU utilization ratio to maintain when scaling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCpuUtilization")]
        public virtual System.Nullable<double> TargetCpuUtilization { get; set; }

        /// <summary>Target throughput utilization ratio to maintain when scaling</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetThroughputUtilization")]
        public virtual System.Nullable<double> TargetThroughputUtilization { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Files served directly to the user for a given URL, such as images, CSS stylesheets, or JavaScript source files.
    /// Static file handlers describe which files in the application directory are static files, and which URLs serve
    /// them.
    /// </summary>
    public class StaticFilesHandler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether files should also be uploaded as code data. By default, files declared in static file handlers are
        /// uploaded as static data and are only served to end users; they cannot be read by the application. If
        /// enabled, uploads are charged against both your code and static data storage resource quotas.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationReadable")]
        public virtual System.Nullable<bool> ApplicationReadable { get; set; }

        /// <summary>Time a static file served by this handler should be cached by web proxies and browsers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual object Expiration { get; set; }

        /// <summary>HTTP headers to use for all responses from these URLs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpHeaders")]
        public virtual System.Collections.Generic.IDictionary<string, string> HttpHeaders { get; set; }

        /// <summary>
        /// MIME type used to serve all files served by this handler.Defaults to file-specific MIME types, which are
        /// derived from each file's filename extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// Path to the static files matched by the URL pattern, from the application root directory. The path can refer
        /// to text matched in groupings in the URL pattern.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Whether this handler should match the request if the file referenced by the handler does not exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireMatchingFile")]
        public virtual System.Nullable<bool> RequireMatchingFile { get; set; }

        /// <summary>
        /// Regular expression that matches the file paths for all files that should be referenced by this handler.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadPathRegex")]
        public virtual string UploadPathRegex { get; set; }

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

    /// <summary>
    /// Traffic routing configuration for versions within a single service. Traffic splits define how traffic directed
    /// to the service is assigned to versions.
    /// </summary>
    public class TrafficSplit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mapping from version IDs within the service to fractional (0.000, 1] allocations of traffic for that
        /// version. Each version can be specified only once, but some versions in the service may not have any traffic
        /// allocation. Services that have traffic allocated cannot be deleted until either the service is deleted or
        /// their traffic allocation is removed. Allocations must sum to 1. Up to two decimal place precision is
        /// supported for IP-based splits and up to three decimal places is supported for cookie-based splits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocations")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<double>> Allocations { get; set; }

        /// <summary>
        /// Mechanism used to determine which version a request is sent to. The traffic selection algorithm will be
        /// stable for either type until allocations are changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shardBy")]
        public virtual string ShardBy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rules to match an HTTP request and dispatch that request to a service.</summary>
    public class UrlDispatchRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Domain name to match against. The wildcard "*" is supported if specified before a period: "*.".Defaults to
        /// matching all domains: "*".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Pathname within the host. Must start with a "/". A single "*" can be included at the end of the path.The sum
        /// of the lengths of the domain and path may not exceed 100 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// Resource ID of a service in this application that should serve the matched request. The service must already
        /// exist. Example: default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// URL pattern and description of how the URL should be handled. App Engine can handle URLs by executing
    /// application code or by serving static files uploaded with the version, such as images, CSS, or JavaScript.
    /// </summary>
    public class UrlMap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uses API Endpoints to handle requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiEndpoint")]
        public virtual ApiEndpointHandler ApiEndpoint { get; set; }

        /// <summary>
        /// Action to take when users access resources that require authentication. Defaults to redirect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authFailAction")]
        public virtual string AuthFailAction { get; set; }

        /// <summary>
        /// Level of login required to access this resource. Not supported for Node.js in the App Engine standard
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("login")]
        public virtual string Login { get; set; }

        /// <summary>30x code to use when performing redirects for the secure field. Defaults to 302.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectHttpResponseCode")]
        public virtual string RedirectHttpResponseCode { get; set; }

        /// <summary>
        /// Executes a script to handle the requests that match this URL pattern. Only the auto value is supported for
        /// Node.js in the App Engine standard environment, for example "script": "auto".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual ScriptHandler Script { get; set; }

        /// <summary>Security (HTTPS) enforcement for this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityLevel")]
        public virtual string SecurityLevel { get; set; }

        /// <summary>Returns the contents of a file, such as an image, as the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticFiles")]
        public virtual StaticFilesHandler StaticFiles { get; set; }

        /// <summary>
        /// URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but
        /// should not contain groupings. All URLs that begin with this prefix are handled by this handler, using the
        /// portion of the URL after the prefix as part of the file path.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlRegex")]
        public virtual string UrlRegex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Version resource is a specific set of source code and configuration files that are deployed into a service.
    /// </summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Serving configuration for Google Cloud Endpoints (https://cloud.google.com/endpoints).Only returned in GET
        /// requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiConfig")]
        public virtual ApiConfigHandler ApiConfig { get; set; }

        /// <summary>Allows App Engine second generation runtimes to access the legacy bundled services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appEngineApis")]
        public virtual System.Nullable<bool> AppEngineApis { get; set; }

        /// <summary>
        /// Automatic scaling is based on request rate, response latencies, and other application metrics. Instances are
        /// dynamically created and destroyed as needed in order to handle traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("automaticScaling")]
        public virtual AutomaticScaling AutomaticScaling { get; set; }

        /// <summary>
        /// A service with basic scaling will create an instance when the application receives a request. The instance
        /// will be turned down when the app becomes idle. Basic scaling is ideal for work that is intermittent or
        /// driven by user activity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicScaling")]
        public virtual BasicScaling BasicScaling { get; set; }

        /// <summary>Metadata settings that are supplied to this version to enable beta runtime features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("betaSettings")]
        public virtual System.Collections.Generic.IDictionary<string, string> BetaSettings { get; set; }

        /// <summary>
        /// Environment variables available to the build environment.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildEnvVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> BuildEnvVariables { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Time that this version was created.@OutputOnly</summary>
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

        /// <summary>Output only. Email address of the user who created this version.@OutputOnly</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdBy")]
        public virtual string CreatedBy { get; set; }

        /// <summary>
        /// Duration that static files should be cached by web proxies and browsers. Only applicable if the
        /// corresponding StaticFilesHandler
        /// (https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1beta/apps.services.versions#StaticFilesHandler)
        /// does not specify its own expiration time.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultExpiration")]
        public virtual object DefaultExpiration { get; set; }

        /// <summary>
        /// Code and application artifacts that make up this version.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual Deployment Deployment { get; set; }

        /// <summary>
        /// Output only. Total size in bytes of all the files that are included in this version and currently hosted on
        /// the App Engine disk.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskUsageBytes")]
        public virtual System.Nullable<long> DiskUsageBytes { get; set; }

        /// <summary>
        /// Cloud Endpoints configuration.If endpoints_api_service is set, the Cloud Endpoints Extensible Service Proxy
        /// will be provided to serve the API implemented by the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointsApiService")]
        public virtual EndpointsApiService EndpointsApiService { get; set; }

        /// <summary>The entrypoint for the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual Entrypoint Entrypoint { get; set; }

        /// <summary>App Engine execution environment for this version.Defaults to standard.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual string Env { get; set; }

        /// <summary>
        /// Environment variables available to the application.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvVariables { get; set; }

        /// <summary>
        /// Custom static error pages. Limited to 10KB per page.Only returned in GET requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorHandlers")]
        public virtual System.Collections.Generic.IList<ErrorHandler> ErrorHandlers { get; set; }

        /// <summary>Settings for App Engine flexible runtimes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flexibleRuntimeSettings")]
        public virtual FlexibleRuntimeSettings FlexibleRuntimeSettings { get; set; }

        /// <summary>
        /// Additional Google Generated Customer Metadata, this field won't be provided by default and can be requested
        /// by setting the IncludeExtraData field in GetVersionRequest
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedCustomerMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> GeneratedCustomerMetadata { get; set; }

        /// <summary>
        /// An ordered list of URL-matching patterns that should be applied to incoming requests. The first matching URL
        /// handles the request and other request handlers are not attempted.Only returned in GET requests if view=FULL
        /// is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("handlers")]
        public virtual System.Collections.Generic.IList<UrlMap> Handlers { get; set; }

        /// <summary>
        /// Configures health checking for instances. Unhealthy instances are stopped and replaced with new instances.
        /// Only applicable in the App Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthCheck")]
        public virtual HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Relative name of the version within the service. Example: v1. Version names can contain only lowercase
        /// letters, numbers, or hyphens. Reserved names: "default", "latest", and any name with the prefix "ah-".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Before an application can receive email or XMPP messages, the application must be configured to enable the
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inboundServices")]
        public virtual System.Collections.Generic.IList<string> InboundServices { get; set; }

        /// <summary>
        /// Instance class that is used to run this version. Valid values are: AutomaticScaling: F1, F2, F4, F4_1G
        /// ManualScaling or BasicScaling: B1, B2, B4, B8, B4_1GDefaults to F1 for AutomaticScaling and B1 for
        /// ManualScaling or BasicScaling.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceClass")]
        public virtual string InstanceClass { get; set; }

        /// <summary>
        /// Configuration for third-party Python runtime libraries that are required by the application.Only returned in
        /// GET requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("libraries")]
        public virtual System.Collections.Generic.IList<Library> Libraries { get; set; }

        /// <summary>
        /// Configures liveness health checking for instances. Unhealthy instances are stopped and replaced with new
        /// instances
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livenessCheck")]
        public virtual LivenessCheck LivenessCheck { get; set; }

        /// <summary>
        /// A service with manual scaling runs continuously, allowing you to perform complex initialization and rely on
        /// the state of its memory over time. Manually scaled versions are sometimes referred to as "backends".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualScaling")]
        public virtual ManualScaling ManualScaling { get; set; }

        /// <summary>
        /// Output only. Full path to the Version resource in the API. Example:
        /// apps/myapp/services/default/versions/v1.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Extra network settings. Only applicable in the App Engine flexible environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual Network Network { get; set; }

        /// <summary>
        /// Files that match this pattern will not be built into this version. Only applicable for Go runtimes.Only
        /// returned in GET requests if view=FULL is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nobuildFilesRegex")]
        public virtual string NobuildFilesRegex { get; set; }

        /// <summary>
        /// Configures readiness health checking for instances. Unhealthy instances are not put into the backend traffic
        /// rotation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readinessCheck")]
        public virtual ReadinessCheck ReadinessCheck { get; set; }

        /// <summary>
        /// Machine resources for this version. Only applicable in the App Engine flexible environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual Resources Resources { get; set; }

        /// <summary>Desired runtime. Example: python27.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtime")]
        public virtual string Runtime { get; set; }

        /// <summary>
        /// The version of the API in the given runtime environment. Please see the app.yaml reference for valid values
        /// at https://cloud.google.com/appengine/docs/standard//config/appref
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeApiVersion")]
        public virtual string RuntimeApiVersion { get; set; }

        /// <summary>
        /// The channel of the runtime to use. Only available for some runtimes. Defaults to the default channel.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeChannel")]
        public virtual string RuntimeChannel { get; set; }

        /// <summary>The path or name of the app's main executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeMainExecutablePath")]
        public virtual string RuntimeMainExecutablePath { get; set; }

        /// <summary>
        /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service
        /// account as default if this field is neither provided in app.yaml file nor through CLI flag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// Current serving status of this version. Only the versions with a SERVING status create instances and can be
        /// billed.SERVING_STATUS_UNSPECIFIED is an invalid value. Defaults to SERVING.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servingStatus")]
        public virtual string ServingStatus { get; set; }

        /// <summary>Whether multiple requests can be dispatched to this version at once.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadsafe")]
        public virtual System.Nullable<bool> Threadsafe { get; set; }

        /// <summary>
        /// Output only. Serving URL for this version. Example:
        /// "https://myversion-dot-myservice-dot-myapp.appspot.com"@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionUrl")]
        public virtual string VersionUrl { get; set; }

        /// <summary>Whether to deploy this version in a container on a virtual machine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vm")]
        public virtual System.Nullable<bool> Vm { get; set; }

        /// <summary>Enables VPC connectivity for standard apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccessConnector")]
        public virtual VpcAccessConnector VpcAccessConnector { get; set; }

        /// <summary>
        /// The Google Compute Engine zones that are supported by this version in the App Engine flexible environment.
        /// Deprecated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<string> Zones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Volumes mounted within the app container. Only applicable in the App Engine flexible environment.
    /// </summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique name for the volume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Volume size in gigabytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<double> SizeGb { get; set; }

        /// <summary>Underlying volume type, e.g. 'tmpfs'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeType")]
        public virtual string VolumeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VPC access connector specification.</summary>
    public class VpcAccessConnector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The egress setting for the connector, controlling what traffic is diverted through it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressSetting")]
        public virtual string EgressSetting { get; set; }

        /// <summary>
        /// Full Serverless VPC Access Connector name e.g. projects/my-project/locations/us-central1/connectors/c1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The zip file information for a zip deployment.</summary>
    public class ZipInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An estimate of the number of files in a zip for a zip deployment. If set, must be greater than or equal to
        /// the actual number of files. Used for optimizing performance; if not provided, deployment may be slow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesCount")]
        public virtual System.Nullable<int> FilesCount { get; set; }

        /// <summary>
        /// URL of the zip file to deploy from. Must be a URL to a resource in Google Cloud Storage in the form
        /// 'http(s)://storage.googleapis.com//'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUrl")]
        public virtual string SourceUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
