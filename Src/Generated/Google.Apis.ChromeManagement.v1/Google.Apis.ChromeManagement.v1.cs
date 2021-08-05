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

namespace Google.Apis.ChromeManagement.v1
{
    /// <summary>The ChromeManagement Service.</summary>
    public class ChromeManagementService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ChromeManagementService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ChromeManagementService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Customers = new CustomersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "chromemanagement";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://chromemanagement.googleapis.com/";
        #else
            "https://chromemanagement.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://chromemanagement.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Chrome Management API.</summary>
        public class Scope
        {
            /// <summary>
            /// See detailed information about apps installed on Chrome browsers and devices managed by your
            /// organization
            /// </summary>
            public static string ChromeManagementAppdetailsReadonly = "https://www.googleapis.com/auth/chrome.management.appdetails.readonly";

            /// <summary>See reports about devices and Chrome browsers managed within your organization</summary>
            public static string ChromeManagementReportsReadonly = "https://www.googleapis.com/auth/chrome.management.reports.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Chrome Management API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See detailed information about apps installed on Chrome browsers and devices managed by your
            /// organization
            /// </summary>
            public const string ChromeManagementAppdetailsReadonly = "https://www.googleapis.com/auth/chrome.management.appdetails.readonly";

            /// <summary>See reports about devices and Chrome browsers managed within your organization</summary>
            public const string ChromeManagementReportsReadonly = "https://www.googleapis.com/auth/chrome.management.reports.readonly";
        }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }
    }

    /// <summary>A base abstract class for ChromeManagement requests.</summary>
    public abstract class ChromeManagementBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ChromeManagementBaseServiceRequest instance.</summary>
        protected ChromeManagementBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ChromeManagement parameter list.</summary>
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

    /// <summary>The "customers" collection of methods.</summary>
    public class CustomersResource
    {
        private const string Resource = "customers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Apps = new AppsResource(service);
            Reports = new ReportsResource(service);
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

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
                Android = new AndroidResource(service);
                Chrome = new ChromeResource(service);
                Web = new WebResource(service);
            }

            /// <summary>Gets the Android resource.</summary>
            public virtual AndroidResource Android { get; }

            /// <summary>The "android" collection of methods.</summary>
            public class AndroidResource
            {
                private const string Resource = "android";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AndroidResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get a specific app for a customer by its resource name.</summary>
                /// <param name="name">
                /// Required. The app for which details are being queried. Examples:
                /// "customers/my_customer/apps/chrome/gmbmikajjgmnabiglmofipeabaddhgne@2.1.2" for the Save to Google
                /// Drive Chrome extension version 2.1.2,
                /// "customers/my_customer/apps/android/com.google.android.apps.docs" for the Google Drive Android app's
                /// latest version.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get a specific app for a customer by its resource name.</summary>
                public class GetRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1AppDetails>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The app for which details are being queried. Examples:
                    /// "customers/my_customer/apps/chrome/gmbmikajjgmnabiglmofipeabaddhgne@2.1.2" for the Save to
                    /// Google Drive Chrome extension version 2.1.2,
                    /// "customers/my_customer/apps/android/com.google.android.apps.docs" for the Google Drive Android
                    /// app's latest version.
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
                            Pattern = @"^customers/[^/]+/apps/android/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Chrome resource.</summary>
            public virtual ChromeResource Chrome { get; }

            /// <summary>The "chrome" collection of methods.</summary>
            public class ChromeResource
            {
                private const string Resource = "chrome";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ChromeResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get a specific app for a customer by its resource name.</summary>
                /// <param name="name">
                /// Required. The app for which details are being queried. Examples:
                /// "customers/my_customer/apps/chrome/gmbmikajjgmnabiglmofipeabaddhgne@2.1.2" for the Save to Google
                /// Drive Chrome extension version 2.1.2,
                /// "customers/my_customer/apps/android/com.google.android.apps.docs" for the Google Drive Android app's
                /// latest version.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get a specific app for a customer by its resource name.</summary>
                public class GetRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1AppDetails>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The app for which details are being queried. Examples:
                    /// "customers/my_customer/apps/chrome/gmbmikajjgmnabiglmofipeabaddhgne@2.1.2" for the Save to
                    /// Google Drive Chrome extension version 2.1.2,
                    /// "customers/my_customer/apps/android/com.google.android.apps.docs" for the Google Drive Android
                    /// app's latest version.
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
                            Pattern = @"^customers/[^/]+/apps/chrome/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Web resource.</summary>
            public virtual WebResource Web { get; }

            /// <summary>The "web" collection of methods.</summary>
            public class WebResource
            {
                private const string Resource = "web";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WebResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get a specific app for a customer by its resource name.</summary>
                /// <param name="name">
                /// Required. The app for which details are being queried. Examples:
                /// "customers/my_customer/apps/chrome/gmbmikajjgmnabiglmofipeabaddhgne@2.1.2" for the Save to Google
                /// Drive Chrome extension version 2.1.2,
                /// "customers/my_customer/apps/android/com.google.android.apps.docs" for the Google Drive Android app's
                /// latest version.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get a specific app for a customer by its resource name.</summary>
                public class GetRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1AppDetails>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The app for which details are being queried. Examples:
                    /// "customers/my_customer/apps/chrome/gmbmikajjgmnabiglmofipeabaddhgne@2.1.2" for the Save to
                    /// Google Drive Chrome extension version 2.1.2,
                    /// "customers/my_customer/apps/android/com.google.android.apps.docs" for the Google Drive Android
                    /// app's latest version.
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
                            Pattern = @"^customers/[^/]+/apps/web/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>The "reports" collection of methods.</summary>
        public class ReportsResource
        {
            private const string Resource = "reports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Generate report of installed Chrome versions.</summary>
            /// <param name="customer">
            /// Required. Customer id or "my_customer" to use the customer associated to the account making the request.
            /// </param>
            public virtual CountChromeVersionsRequest CountChromeVersions(string customer)
            {
                return new CountChromeVersionsRequest(service, customer);
            }

            /// <summary>Generate report of installed Chrome versions.</summary>
            public class CountChromeVersionsRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1CountChromeVersionsResponse>
            {
                /// <summary>Constructs a new CountChromeVersions request.</summary>
                public CountChromeVersionsRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// Required. Customer id or "my_customer" to use the customer associated to the account making the
                /// request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>
                /// Query string to filter results, AND-separated fields in EBNF syntax. Note: OR operations are not
                /// supported in this filter. Supported filter fields: * last_active_date
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>The ID of the organizational unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orgUnitId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrgUnitId { get; set; }

                /// <summary>Maximum number of results to return. Maximum and default are 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to specify the page of the request to be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "countChromeVersions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}/reports:countChromeVersions";

                /// <summary>Initializes CountChromeVersions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orgUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitId",
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

            /// <summary>Generate report of app installations.</summary>
            /// <param name="customer">
            /// Required. Customer id or "my_customer" to use the customer associated to the account making the request.
            /// </param>
            public virtual CountInstalledAppsRequest CountInstalledApps(string customer)
            {
                return new CountInstalledAppsRequest(service, customer);
            }

            /// <summary>Generate report of app installations.</summary>
            public class CountInstalledAppsRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1CountInstalledAppsResponse>
            {
                /// <summary>Constructs a new CountInstalledApps request.</summary>
                public CountInstalledAppsRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// Required. Customer id or "my_customer" to use the customer associated to the account making the
                /// request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>
                /// Query string to filter results, AND-separated fields in EBNF syntax. Note: OR operations are not
                /// supported in this filter. Supported filter fields: * app_name * app_type * install_type *
                /// number_of_permissions * total_install_count * latest_profile_active_date * permission_name
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Field used to order results. Supported order by fields: * app_name * app_type * install_type *
                /// number_of_permissions * total_install_count
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>The ID of the organizational unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orgUnitId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrgUnitId { get; set; }

                /// <summary>Maximum number of results to return. Maximum and default are 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to specify the page of the request to be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "countInstalledApps";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}/reports:countInstalledApps";

                /// <summary>Initializes CountInstalledApps parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+$",
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
                    RequestParameters.Add("orgUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitId",
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

            /// <summary>Generate report of devices that have a specified app installed.</summary>
            /// <param name="customer">
            /// Required. Customer id or "my_customer" to use the customer associated to the account making the request.
            /// </param>
            public virtual FindInstalledAppDevicesRequest FindInstalledAppDevices(string customer)
            {
                return new FindInstalledAppDevicesRequest(service, customer);
            }

            /// <summary>Generate report of devices that have a specified app installed.</summary>
            public class FindInstalledAppDevicesRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1FindInstalledAppDevicesResponse>
            {
                /// <summary>Constructs a new FindInstalledAppDevices request.</summary>
                public FindInstalledAppDevicesRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>
                /// Required. Customer id or "my_customer" to use the customer associated to the account making the
                /// request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>
                /// Unique identifier of the app. For Chrome apps and extensions, the 32-character id (e.g.
                /// ehoadneljpdggcbbknedodolkkjodefl). For Android apps, the package name (e.g. com.evernote).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("appId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AppId { get; set; }

                /// <summary>Type of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AppTypeEnum> AppType { get; set; }

                /// <summary>Type of the app.</summary>
                public enum AppTypeEnum
                {
                    /// <summary>App type not specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("APP_TYPE_UNSPECIFIED")]
                    APPTYPEUNSPECIFIED = 0,

                    /// <summary>Chrome extension.</summary>
                    [Google.Apis.Util.StringValueAttribute("EXTENSION")]
                    EXTENSION = 1,

                    /// <summary>Chrome app.</summary>
                    [Google.Apis.Util.StringValueAttribute("APP")]
                    APP = 2,

                    /// <summary>Chrome theme.</summary>
                    [Google.Apis.Util.StringValueAttribute("THEME")]
                    THEME = 3,

                    /// <summary>Chrome hosted app.</summary>
                    [Google.Apis.Util.StringValueAttribute("HOSTED_APP")]
                    HOSTEDAPP = 4,

                    /// <summary>ARC++ app.</summary>
                    [Google.Apis.Util.StringValueAttribute("ANDROID_APP")]
                    ANDROIDAPP = 5,
                }

                /// <summary>
                /// Query string to filter results, AND-separated fields in EBNF syntax. Note: OR operations are not
                /// supported in this filter. Supported filter fields: * last_active_date
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Field used to order results. Supported order by fields: * machine * device_id</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>The ID of the organizational unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orgUnitId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrgUnitId { get; set; }

                /// <summary>Maximum number of results to return. Maximum and default are 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to specify the page of the request to be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "findInstalledAppDevices";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}/reports:findInstalledAppDevices";

                /// <summary>Initializes FindInstalledAppDevices parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^customers/[^/]+$",
                    });
                    RequestParameters.Add("appId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("appType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "appType",
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
                    RequestParameters.Add("orgUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitId",
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
namespace Google.Apis.ChromeManagement.v1.Data
{
    /// <summary>Android app information.</summary>
    public class GoogleChromeManagementV1AndroidAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Permissions requested by an Android app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1AndroidAppPermission> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Permission requested by an Android app.</summary>
    public class GoogleChromeManagementV1AndroidAppPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The type of the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource representing app details.</summary>
    public class GoogleChromeManagementV1AppDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Android app information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidAppInfo")]
        public virtual GoogleChromeManagementV1AndroidAppInfo AndroidAppInfo { get; set; }

        /// <summary>
        /// Output only. Unique store identifier for the item. Examples: "gmbmikajjgmnabiglmofipeabaddhgne" for the Save
        /// to Google Drive Chrome extension, "com.google.android.apps.docs" for the Google Drive Android app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Output only. Chrome Web Store app information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chromeAppInfo")]
        public virtual GoogleChromeManagementV1ChromeAppInfo ChromeAppInfo { get; set; }

        /// <summary>Output only. App's description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The uri for the detail page of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailUri")]
        public virtual string DetailUri { get; set; }

        /// <summary>Output only. App's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. First published time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPublishTime")]
        public virtual object FirstPublishTime { get; set; }

        /// <summary>Output only. Home page or Website uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual string HomepageUri { get; set; }

        /// <summary>Output only. A link to an image that can be used as an icon for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUri")]
        public virtual string IconUri { get; set; }

        /// <summary>Output only. Indicates if the app has to be paid for OR has paid content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPaidApp")]
        public virtual System.Nullable<bool> IsPaidApp { get; set; }

        /// <summary>Output only. Latest published time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestPublishTime")]
        public virtual object LatestPublishTime { get; set; }

        /// <summary>
        /// Output only. Format: name=customers/{customer_id}/apps/{chrome|android|web}/{app_id}@{version}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The URI pointing to the privacy policy of the app, if it was provided by the developer.
        /// Version-specific field that will only be set when the requested app version is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicyUri")]
        public virtual string PrivacyPolicyUri { get; set; }

        /// <summary>Output only. The publisher of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisher")]
        public virtual string Publisher { get; set; }

        /// <summary>
        /// Output only. Number of reviews received. Chrome Web Store review information will always be for the latest
        /// version of an app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewNumber")]
        public virtual System.Nullable<long> ReviewNumber { get; set; }

        /// <summary>
        /// Output only. The rating of the app (on 5 stars). Chrome Web Store review information will always be for the
        /// latest version of an app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewRating")]
        public virtual System.Nullable<float> ReviewRating { get; set; }

        /// <summary>
        /// Output only. App version. A new revision is committed whenever a new version of the app is published.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Output only. Information about a partial service error if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceError")]
        public virtual GoogleRpcStatus ServiceError { get; set; }

        /// <summary>Output only. App type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a browser version and its install count.</summary>
    public class GoogleChromeManagementV1BrowserVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The release channel of the installed browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channel")]
        public virtual string Channel { get; set; }

        /// <summary>Output only. Count grouped by device_system and major version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Output only. Version of the system-specified operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceOsVersion")]
        public virtual string DeviceOsVersion { get; set; }

        /// <summary>Output only. The device operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("system")]
        public virtual string System { get; set; }

        /// <summary>Output only. The full version of the installed browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Chrome Web Store app information.</summary>
    public class GoogleChromeManagementV1ChromeAppInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the app or extension is built and maintained by Google. Version-specific field that
        /// will only be set when the requested app version is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleOwned")]
        public virtual System.Nullable<bool> GoogleOwned { get; set; }

        /// <summary>
        /// Output only. Whether the app or extension is in a published state in the Chrome Web Store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isCwsHosted")]
        public virtual System.Nullable<bool> IsCwsHosted { get; set; }

        /// <summary>Output only. Whether the app or extension is a theme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTheme")]
        public virtual System.Nullable<bool> IsTheme { get; set; }

        /// <summary>Output only. The minimum number of users using this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minUserCount")]
        public virtual System.Nullable<int> MinUserCount { get; set; }

        /// <summary>
        /// Output only. Every custom permission requested by the app. Version-specific field that will only be set when
        /// the requested app version is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1ChromeAppPermission> Permissions { get; set; }

        /// <summary>
        /// Output only. Every permission giving access to domains or broad host patterns. ( e.g. www.google.com). This
        /// includes the matches from content scripts as well as hosts in the permissions node of the manifest.
        /// Version-specific field that will only be set when the requested app version is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteAccess")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1ChromeAppSiteAccess> SiteAccess { get; set; }

        /// <summary>
        /// Output only. The app developer has enabled support for their app. Version-specific field that will only be
        /// set when the requested app version is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportEnabled")]
        public virtual System.Nullable<bool> SupportEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Permission requested by a Chrome app or extension.</summary>
    public class GoogleChromeManagementV1ChromeAppPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If available, whether this permissions grants the app/extension access to user data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessUserData")]
        public virtual System.Nullable<bool> AccessUserData { get; set; }

        /// <summary>
        /// Output only. If available, a URI to a page that has documentation for the current permission.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentationUri")]
        public virtual string DocumentationUri { get; set; }

        /// <summary>Output only. The type of the permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represent one host permission.</summary>
    public class GoogleChromeManagementV1ChromeAppSiteAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. This can contain very specific hosts, or patterns like "*.com" for instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostMatch")]
        public virtual string HostMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing requested browser versions details and counts.</summary>
    public class GoogleChromeManagementV1CountChromeVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all browser versions and their install counts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browserVersions")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1BrowserVersion> BrowserVersions { get; set; }

        /// <summary>Token to specify the next page of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Total number browser versions matching request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing details of queried installed apps.</summary>
    public class GoogleChromeManagementV1CountInstalledAppsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of installed apps matching request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedApps")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1InstalledApp> InstalledApps { get; set; }

        /// <summary>Token to specify the next page of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Total number of installed apps matching request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a device reporting Chrome browser information.</summary>
    public class GoogleChromeManagementV1Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of the device that reported this Chrome browser information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>Output only. The name of the machine within its local network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machine")]
        public virtual string Machine { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing a list of devices with queried app installed.</summary>
    public class GoogleChromeManagementV1FindInstalledAppDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of devices which have the app installed. Sorted in ascending alphabetical order on the Device.machine
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1Device> Devices { get; set; }

        /// <summary>Token to specify the next page of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Total number of devices matching request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an installed app.</summary>
    public class GoogleChromeManagementV1InstalledApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Unique identifier of the app. For Chrome apps and extensions, the 32-character id (e.g.
        /// ehoadneljpdggcbbknedodolkkjodefl). For Android apps, the package name (e.g. com.evernote).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Output only. How the app was installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInstallType")]
        public virtual string AppInstallType { get; set; }

        /// <summary>Output only. Source of the installed app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appSource")]
        public virtual string AppSource { get; set; }

        /// <summary>Output only. Type of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appType")]
        public virtual string AppType { get; set; }

        /// <summary>Output only. Count of browser devices with this app installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browserDeviceCount")]
        public virtual System.Nullable<long> BrowserDeviceCount { get; set; }

        /// <summary>Output only. Description of the installed app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. Whether the app is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>Output only. Name of the installed app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. Homepage uri of the installed app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homepageUri")]
        public virtual string HomepageUri { get; set; }

        /// <summary>Output only. Count of ChromeOS users with this app installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osUserCount")]
        public virtual System.Nullable<long> OsUserCount { get; set; }

        /// <summary>Output only. Permissions of the installed app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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
