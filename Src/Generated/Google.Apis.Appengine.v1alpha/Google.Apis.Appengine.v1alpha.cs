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

namespace Google.Apis.Appengine.v1alpha
{
    /// <summary>The Appengine Service.</summary>
    public class AppengineService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

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
            Locations = new LocationsResource(service);
            Operations = new OperationsResource(service);
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
            public virtual CreateRequest Create(Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string appsId)
            {
                return new CreateRequest(this.service, body, appsId);
            }

            /// <summary>Uploads the specified SSL certificate.</summary>
            public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string appsId) : base(service)
                {
                    AppsId = appsId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{appsId}/authorizedCertificates";

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
            public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Empty>
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
                public override string RestPath => "v1alpha/apps/{appsId}/authorizedCertificates/{authorizedCertificatesId}";

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
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate>
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
                public override string RestPath => "v1alpha/apps/{appsId}/authorizedCertificates/{authorizedCertificatesId}";

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
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListAuthorizedCertificatesResponse>
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
                public override string RestPath => "v1alpha/apps/{appsId}/authorizedCertificates";

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
            public virtual PatchRequest Patch(Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string appsId, string authorizedCertificatesId)
            {
                return new PatchRequest(this.service, body, appsId, authorizedCertificatesId);
            }

            /// <summary>
            /// Updates the specified SSL certificate. To renew a certificate and maintain its existing domain mappings,
            /// update certificate_data with a new certificate. The new certificate must be applicable to the same
            /// domains as the original certificate. The certificate display_name may also be updated.
            /// </summary>
            public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string appsId, string authorizedCertificatesId) : base(service)
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
                Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{appsId}/authorizedCertificates/{authorizedCertificatesId}";

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
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListAuthorizedDomainsResponse>
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
                public override string RestPath => "v1alpha/apps/{appsId}/authorizedDomains";

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
            public virtual CreateRequest Create(Google.Apis.Appengine.v1alpha.Data.DomainMapping body, string appsId)
            {
                return new CreateRequest(this.service, body, appsId);
            }

            /// <summary>
            /// Maps a domain to an application. A user must be authorized to administer a domain in order to map it to
            /// an application. For a list of available authorized domains, see AuthorizedDomains.ListAuthorizedDomains.
            /// </summary>
            public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1alpha.Data.DomainMapping body, string appsId) : base(service)
                {
                    AppsId = appsId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Part of `parent`. Name of the parent Application resource. Example: apps/myapp.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appsId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AppsId { get; private set; }

                /// <summary>
                /// Whether a managed certificate should be provided by App Engine. If true, a certificate ID must be
                /// manaually set in the DomainMapping resource to configure SSL for this domain. If false, a managed
                /// certificate will be provisioned and a certificate ID will be automatically populated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("noManagedCertificate", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> NoManagedCertificate { get; set; }

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
                Google.Apis.Appengine.v1alpha.Data.DomainMapping Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{appsId}/domainMappings";

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
                    RequestParameters.Add("noManagedCertificate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "noManagedCertificate",
                        IsRequired = false,
                        ParameterType = "query",
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
            public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Operation>
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
                public override string RestPath => "v1alpha/apps/{appsId}/domainMappings/{domainMappingsId}";

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
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.DomainMapping>
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
                public override string RestPath => "v1alpha/apps/{appsId}/domainMappings/{domainMappingsId}";

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
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListDomainMappingsResponse>
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
                public override string RestPath => "v1alpha/apps/{appsId}/domainMappings";

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
            public virtual PatchRequest Patch(Google.Apis.Appengine.v1alpha.Data.DomainMapping body, string appsId, string domainMappingsId)
            {
                return new PatchRequest(this.service, body, appsId, domainMappingsId);
            }

            /// <summary>
            /// Updates the specified domain mapping. To map an SSL certificate to a domain mapping, update
            /// certificate_id to point to an AuthorizedCertificate resource. A user must be authorized to administer
            /// the associated domain in order to update a DomainMapping resource.
            /// </summary>
            public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1alpha.Data.DomainMapping body, string appsId, string domainMappingsId) : base(service)
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

                /// <summary>
                /// Whether a managed certificate should be provided by App Engine. If true, a certificate ID must be
                /// manually set in the DomainMapping resource to configure SSL for this domain. If false, a managed
                /// certificate will be provisioned and a certificate ID will be automatically populated. Only
                /// applicable if ssl_settings.certificate_id is specified in the update mask.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("noManagedCertificate", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> NoManagedCertificate { get; set; }

                /// <summary>Required. Standard field mask for the set of fields to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Appengine.v1alpha.Data.DomainMapping Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/apps/{appsId}/domainMappings/{domainMappingsId}";

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
                    RequestParameters.Add("noManagedCertificate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "noManagedCertificate",
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
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Location>
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
                public override string RestPath => "v1alpha/apps/{appsId}/locations/{locationsId}";

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
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListLocationsResponse>
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
                public override string RestPath => "v1alpha/apps/{appsId}/locations";

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
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Operation>
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
                public override string RestPath => "v1alpha/apps/{appsId}/operations/{operationsId}";

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
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListOperationsResponse>
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
                public override string RestPath => "v1alpha/apps/{appsId}/operations";

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
                    public virtual CreateRequest Create(Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId)
                    {
                        return new CreateRequest(this.service, body, projectsId, locationsId, applicationsId);
                    }

                    /// <summary>Uploads the specified SSL certificate.</summary>
                    public class CreateRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId) : base(service)
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
                        Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates";

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
                    public class DeleteRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Empty>
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
                        public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates/{authorizedCertificatesId}";

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
                    public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate>
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
                        public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates/{authorizedCertificatesId}";

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
                    public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListAuthorizedCertificatesResponse>
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
                        public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates";

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
                    public virtual PatchRequest Patch(Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId)
                    {
                        return new PatchRequest(this.service, body, projectsId, locationsId, applicationsId, authorizedCertificatesId);
                    }

                    /// <summary>
                    /// Updates the specified SSL certificate. To renew a certificate and maintain its existing domain
                    /// mappings, update certificate_data with a new certificate. The new certificate must be applicable
                    /// to the same domains as the original certificate. The certificate display_name may also be
                    /// updated.
                    /// </summary>
                    public class PatchRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate body, string projectsId, string locationsId, string applicationsId, string authorizedCertificatesId) : base(service)
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
                        Google.Apis.Appengine.v1alpha.Data.AuthorizedCertificate Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedCertificates/{authorizedCertificatesId}";

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
                    public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListAuthorizedDomainsResponse>
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
                        public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/authorizedDomains";

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
                    public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.DomainMapping>
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
                        public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/applications/{applicationsId}/domainMappings/{domainMappingsId}";

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
                public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Operation>
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
                    public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/operations/{operationsId}";

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
                public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}/operations";

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
            public class GetRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.Location>
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
                public override string RestPath => "v1alpha/projects/{projectsId}/locations/{locationsId}";

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
            public class ListRequest : AppengineBaseServiceRequest<Google.Apis.Appengine.v1alpha.Data.ListLocationsResponse>
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
                public override string RestPath => "v1alpha/projects/{projectsId}/locations";

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
namespace Google.Apis.Appengine.v1alpha.Data
{
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

    /// <summary>SSL configuration for a DomainMapping resource.</summary>
    public class SslSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
        /// remove SSL support.By default, a managed certificate is automatically created for every domain mapping. To
        /// omit SSL support or to configure SSL manually, specify no_managed_certificate on a CREATE or UPDATE request.
        /// You must be authorized to administer the AuthorizedCertificate resource to manually map it to a
        /// DomainMapping resource. Example: 12345.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateId")]
        public virtual string CertificateId { get; set; }

        /// <summary>
        /// Whether the mapped certificate is an App Engine managed certificate. Managed certificates are created by
        /// default with a domain mapping. To opt out, specify no_managed_certificate on a CREATE or UPDATE
        /// request.@OutputOnly
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isManagedCertificate")]
        public virtual System.Nullable<bool> IsManagedCertificate { get; set; }

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
}
