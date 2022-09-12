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

            /// <summary>
            /// See basic device and telemetry information collected from Chrome OS devices or users managed within your
            /// organization
            /// </summary>
            public static string ChromeManagementTelemetryReadonly = "https://www.googleapis.com/auth/chrome.management.telemetry.readonly";
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

            /// <summary>
            /// See basic device and telemetry information collected from Chrome OS devices or users managed within your
            /// organization
            /// </summary>
            public const string ChromeManagementTelemetryReadonly = "https://www.googleapis.com/auth/chrome.management.telemetry.readonly";
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
            Telemetry = new TelemetryResource(service);
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

            /// <summary>Generate summary of app installation requests.</summary>
            /// <param name="customer">
            /// Required. Customer id or "my_customer" to use the customer associated to the account making the request.
            /// </param>
            public virtual CountChromeAppRequestsRequest CountChromeAppRequests(string customer)
            {
                return new CountChromeAppRequestsRequest(service, customer);
            }

            /// <summary>Generate summary of app installation requests.</summary>
            public class CountChromeAppRequestsRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1CountChromeAppRequestsResponse>
            {
                /// <summary>Constructs a new CountChromeAppRequests request.</summary>
                public CountChromeAppRequestsRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
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
                /// Field used to order results. Supported fields: * request_count * latest_request_time
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>The ID of the organizational unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orgUnitId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrgUnitId { get; set; }

                /// <summary>
                /// Maximum number of results to return. Maximum and default are 50, anything above will be coerced to
                /// 50.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Token to specify the page of the request to be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "countChromeAppRequests";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}/apps:countChromeAppRequests";

                /// <summary>Initializes CountChromeAppRequests parameter list.</summary>
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

            /// <summary>
            /// Generate report of the number of devices expiring in each month of the selected time frame. Devices are
            /// grouped by auto update expiration date and model. Further information can be found
            /// [here](https://support.google.com/chrome/a/answer/10564947).
            /// </summary>
            /// <param name="customer">Required. The customer ID or "my_customer" prefixed with "customers/".</param>
            public virtual CountChromeDevicesReachingAutoExpirationDateRequest CountChromeDevicesReachingAutoExpirationDate(string customer)
            {
                return new CountChromeDevicesReachingAutoExpirationDateRequest(service, customer);
            }

            /// <summary>
            /// Generate report of the number of devices expiring in each month of the selected time frame. Devices are
            /// grouped by auto update expiration date and model. Further information can be found
            /// [here](https://support.google.com/chrome/a/answer/10564947).
            /// </summary>
            public class CountChromeDevicesReachingAutoExpirationDateRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1CountChromeDevicesReachingAutoExpirationDateResponse>
            {
                /// <summary>Constructs a new CountChromeDevicesReachingAutoExpirationDate request.</summary>
                public CountChromeDevicesReachingAutoExpirationDateRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>Required. The customer ID or "my_customer" prefixed with "customers/".</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>
                /// Optional. Maximum expiration date in format yyyy-mm-dd in UTC timezone. If included returns all
                /// devices that have already expired and devices with auto expiration date equal to or earlier than the
                /// maximum date.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxAueDate", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MaxAueDate { get; set; }

                /// <summary>
                /// Optional. Maximum expiration date in format yyyy-mm-dd in UTC timezone. If included returns all
                /// devices that have already expired and devices with auto expiration date equal to or later than the
                /// minimum date.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("minAueDate", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MinAueDate { get; set; }

                /// <summary>
                /// Optional. The organizational unit ID, if omitted, will return data for all organizational units.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orgUnitId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrgUnitId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "countChromeDevicesReachingAutoExpirationDate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}/reports:countChromeDevicesReachingAutoExpirationDate";

                /// <summary>Initializes CountChromeDevicesReachingAutoExpirationDate parameter list.</summary>
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
                    RequestParameters.Add("maxAueDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxAueDate",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("minAueDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "minAueDate",
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
                }
            }

            /// <summary>
            /// Counts of ChromeOS devices that have not synced policies or have lacked user activity in the past 28
            /// days, are out of date, or are not complaint. Further information can be found here
            /// https://support.google.com/chrome/a/answer/10564947
            /// </summary>
            /// <param name="customer">Required. The customer ID or "my_customer" prefixed with "customers/".</param>
            public virtual CountChromeDevicesThatNeedAttentionRequest CountChromeDevicesThatNeedAttention(string customer)
            {
                return new CountChromeDevicesThatNeedAttentionRequest(service, customer);
            }

            /// <summary>
            /// Counts of ChromeOS devices that have not synced policies or have lacked user activity in the past 28
            /// days, are out of date, or are not complaint. Further information can be found here
            /// https://support.google.com/chrome/a/answer/10564947
            /// </summary>
            public class CountChromeDevicesThatNeedAttentionRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1CountChromeDevicesThatNeedAttentionResponse>
            {
                /// <summary>Constructs a new CountChromeDevicesThatNeedAttention request.</summary>
                public CountChromeDevicesThatNeedAttentionRequest(Google.Apis.Services.IClientService service, string customer) : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }

                /// <summary>Required. The customer ID or "my_customer" prefixed with "customers/".</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>
                /// Optional. The ID of the organizational unit. If omitted, all data will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orgUnitId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrgUnitId { get; set; }

                /// <summary>Required. Mask of the fields that should be populated in the returned report.</summary>
                [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadMask { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "countChromeDevicesThatNeedAttention";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+customer}/reports:countChromeDevicesThatNeedAttention";

                /// <summary>Initializes CountChromeDevicesThatNeedAttention parameter list.</summary>
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
                    RequestParameters.Add("orgUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
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

        /// <summary>Gets the Telemetry resource.</summary>
        public virtual TelemetryResource Telemetry { get; }

        /// <summary>The "telemetry" collection of methods.</summary>
        public class TelemetryResource
        {
            private const string Resource = "telemetry";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TelemetryResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Devices = new DevicesResource(service);
            }

            /// <summary>Gets the Devices resource.</summary>
            public virtual DevicesResource Devices { get; }

            /// <summary>The "devices" collection of methods.</summary>
            public class DevicesResource
            {
                private const string Resource = "devices";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DevicesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get telemetry device.</summary>
                /// <param name="name">Required. Name of the `TelemetryDevice` to return.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Get telemetry device.</summary>
                public class GetRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1TelemetryDevice>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the `TelemetryDevice` to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. Read mask to specify which fields to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

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
                            Pattern = @"^customers/[^/]+/telemetry/devices/[^/]+$",
                        });
                        RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>List all telemetry devices.</summary>
                /// <param name="parent">
                /// Required. Customer id or "my_customer" to use the customer associated to the account making the
                /// request.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>List all telemetry devices.</summary>
                public class ListRequest : ChromeManagementBaseServiceRequest<Google.Apis.ChromeManagement.v1.Data.GoogleChromeManagementV1ListTelemetryDevicesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Customer id or "my_customer" to use the customer associated to the account making the
                    /// request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Only include resources that match the filter. Supported filter fields: - org_unit_id -
                    /// serial_number - device_id
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Maximum number of results to return. Default value is 100. Maximum value is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Token to specify next page in the list.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Required. Read mask to specify which fields to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/telemetry/devices";

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
                        RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readMask",
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

    /// <summary>
    /// Status data for storage. * This field is telemetry information and this will change over time as the device is
    /// utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceAudioStatus](https://chromeenterprise.google/policies/#ReportDeviceAudioStatus) * Data Collection
    /// Frequency: 10 minutes * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1AudioStatusReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Active input device's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputDevice")]
        public virtual string InputDevice { get; set; }

        /// <summary>Output only. Active input device's gain in [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputGain")]
        public virtual System.Nullable<int> InputGain { get; set; }

        /// <summary>Output only. Is active input device mute or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputMute")]
        public virtual System.Nullable<bool> InputMute { get; set; }

        /// <summary>Output only. Active output device's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputDevice")]
        public virtual string OutputDevice { get; set; }

        /// <summary>Output only. Is active output device mute or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputMute")]
        public virtual System.Nullable<bool> OutputMute { get; set; }

        /// <summary>Output only. Active output device's volume in [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputVolume")]
        public virtual System.Nullable<int> OutputVolume { get; set; }

        /// <summary>Output only. Timestamp of when the sample was collected on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the battery. * This field provides device information, which is static and will not change
    /// over time. * Data for this field is controlled via policy:
    /// [ReportDevicePowerStatus](https://chromeenterprise.google/policies/#ReportDevicePowerStatus) * Data Collection
    /// Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1BatteryInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Design capacity (mAmpere-hours).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("designCapacity")]
        public virtual System.Nullable<long> DesignCapacity { get; set; }

        /// <summary>Output only. Designed minimum output voltage (mV)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("designMinVoltage")]
        public virtual System.Nullable<int> DesignMinVoltage { get; set; }

        /// <summary>Output only. The date the battery was manufactured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufactureDate")]
        public virtual GoogleTypeDate ManufactureDate { get; set; }

        /// <summary>Output only. Battery manufacturer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Output only. Battery serial number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>Output only. Technology of the battery. Example: Li-ion</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technology")]
        public virtual string Technology { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sampling data for battery. * This field is telemetry information and this will change over time as the device is
    /// utilized. * Data for this field is controlled via policy:
    /// [ReportDevicePowerStatus](https://chromeenterprise.google/policies/#ReportDevicePowerStatus) * Data Collection
    /// Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1BatterySampleReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Battery charge percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chargeRate")]
        public virtual System.Nullable<int> ChargeRate { get; set; }

        /// <summary>Output only. Battery current (mA).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("current")]
        public virtual System.Nullable<long> Current { get; set; }

        /// <summary>
        /// Output only. The battery discharge rate measured in mW. Positive if the battery is being discharged,
        /// negative if it's being charged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dischargeRate")]
        public virtual System.Nullable<int> DischargeRate { get; set; }

        /// <summary>Output only. Battery remaining capacity (mAmpere-hours).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingCapacity")]
        public virtual System.Nullable<long> RemainingCapacity { get; set; }

        /// <summary>Output only. Timestamp of when the sample was collected on device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>Output only. Battery status read from sysfs. Example: Discharging</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>Output only. Temperature in Celsius degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temperature")]
        public virtual System.Nullable<int> Temperature { get; set; }

        /// <summary>Output only. Battery voltage (millivolt).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voltage")]
        public virtual System.Nullable<long> Voltage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Status data for battery. * This field is telemetry information and this will change over time as the device is
    /// utilized. * Data for this field is controlled via policy:
    /// [ReportDevicePowerStatus](https://chromeenterprise.google/policies/#ReportDevicePowerStatus) * Data Collection
    /// Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1BatteryStatusReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Battery health.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batteryHealth")]
        public virtual string BatteryHealth { get; set; }

        /// <summary>Output only. Cycle count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cycleCount")]
        public virtual System.Nullable<int> CycleCount { get; set; }

        /// <summary>Output only. Full charge capacity (mAmpere-hours).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullChargeCapacity")]
        public virtual System.Nullable<long> FullChargeCapacity { get; set; }

        /// <summary>Output only. Timestamp of when the sample was collected on device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>Output only. Sampling data for the battery sorted in a decreasing order of report_time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sample")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1BatterySampleReport> Sample { get; set; }

        /// <summary>Output only. Battery serial number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

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

        /// <summary>Output only. Whether the app is only for Kiosk mode on ChromeOS devices</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isKioskOnly")]
        public virtual System.Nullable<bool> IsKioskOnly { get; set; }

        /// <summary>Output only. Whether the app or extension is a theme.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTheme")]
        public virtual System.Nullable<bool> IsTheme { get; set; }

        /// <summary>Output only. Whether this app is enabled for Kiosk mode on ChromeOS devices</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kioskEnabled")]
        public virtual System.Nullable<bool> KioskEnabled { get; set; }

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

    /// <summary>Details of an app installation request.</summary>
    public class GoogleChromeManagementV1ChromeAppRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Format: app_details=customers/{customer_id}/apps/chrome/{app_id}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appDetails")]
        public virtual string AppDetails { get; set; }

        /// <summary>
        /// Output only. Unique store identifier for the app. Example: "gmbmikajjgmnabiglmofipeabaddhgne" for the Save
        /// to Google Drive Chrome extension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual string AppId { get; set; }

        /// <summary>Output only. The uri for the detail page of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailUri")]
        public virtual string DetailUri { get; set; }

        /// <summary>Output only. App's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Output only. A link to an image that can be used as an icon for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconUri")]
        public virtual string IconUri { get; set; }

        /// <summary>Output only. The timestamp of the most recently made request for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestRequestTime")]
        public virtual object LatestRequestTime { get; set; }

        /// <summary>Output only. Total count of requests for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestCount")]
        public virtual System.Nullable<long> RequestCount { get; set; }

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

    /// <summary>Response containing summary of requested app installations.</summary>
    public class GoogleChromeManagementV1CountChromeAppRequestsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to specify the next page in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Count of requested apps matching request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedApps")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1ChromeAppRequest> RequestedApps { get; set; }

        /// <summary>Total number of matching app requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response containing a list of devices expiring in each month of a selected time frame. Counts are grouped by
    /// model and Auto Update Expiration date.
    /// </summary>
    public class GoogleChromeManagementV1CountChromeDevicesReachingAutoExpirationDateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of reports sorted by auto update expiration date in ascending order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceAueCountReports")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1DeviceAueCountReport> DeviceAueCountReports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing counts for devices that need attention.</summary>
    public class GoogleChromeManagementV1CountChromeDevicesThatNeedAttentionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of ChromeOS devices have not synced policies in the past 28 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noRecentPolicySyncCount")]
        public virtual System.Nullable<long> NoRecentPolicySyncCount { get; set; }

        /// <summary>Number of ChromeOS devices that have not seen any user activity in the past 28 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noRecentUserActivityCount")]
        public virtual System.Nullable<long> NoRecentUserActivityCount { get; set; }

        /// <summary>Number of devices whose OS version is not compliant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersionNotCompliantCount")]
        public virtual System.Nullable<long> OsVersionNotCompliantCount { get; set; }

        /// <summary>Number of devices that are pending an OS update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingUpdate")]
        public virtual System.Nullable<long> PendingUpdate { get; set; }

        /// <summary>Number of devices that are unable to apply a policy due to an OS version mismatch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsupportedPolicyCount")]
        public virtual System.Nullable<long> UnsupportedPolicyCount { get; set; }

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

    /// <summary>
    /// CPU specifications for the device * This field provides device information, which is static and will not change
    /// over time. * Data for this field is controlled via policy:
    /// [ReportDeviceCpuInfo](https://chromeenterprise.google/policies/#ReportDeviceCpuInfo) * Data Collection
    /// Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1CpuInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Architecture type for the CPU. * This field provides device information, which is static and
        /// will not change over time. * Data for this field is controlled via policy:
        /// [ReportDeviceCpuInfo](https://chromeenterprise.google/policies/#ReportDeviceCpuInfo) * Data Collection
        /// Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If
        /// the device is offline, the collected data is stored locally, and will be reported when the device is next
        /// online: No * Reported for affiliated users only: N/A
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>
        /// Output only. Whether keylocker is configured.`TRUE` = Enabled; `FALSE` = disabled. Only reported if
        /// keylockerSupported = `TRUE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keylockerConfigured")]
        public virtual System.Nullable<bool> KeylockerConfigured { get; set; }

        /// <summary>Output only. Whether keylocker is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keylockerSupported")]
        public virtual System.Nullable<bool> KeylockerSupported { get; set; }

        /// <summary>Output only. The max CPU clock speed in kHz.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxClockSpeed")]
        public virtual System.Nullable<int> MaxClockSpeed { get; set; }

        /// <summary>Output only. The CPU model name. Example: Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides information about the status of the CPU. * This field is telemetry information and this will change
    /// over time as the device is utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceCpuInfo](https://chromeenterprise.google/policies/#ReportDeviceCpuInfo) * Data Collection
    /// Frequency: Every 10 minutes * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1CpuStatusReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. CPU temperature sample info per CPU core in Celsius</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuTemperatureInfo")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1CpuTemperatureInfo> CpuTemperatureInfo { get; set; }

        /// <summary>Output only. Sample of CPU utilization (0-100 percent).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuUtilizationPct")]
        public virtual System.Nullable<int> CpuUtilizationPct { get; set; }

        /// <summary>
        /// Output only. The timestamp in milliseconds representing time at which this report was sampled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>Output only. Frequency the report is sampled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleFrequency")]
        public virtual object SampleFrequency { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CPU temperature of a device. Sampled per CPU core in Celsius. * This field is telemetry information and this
    /// will change over time as the device is utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceCpuInfo](https://chromeenterprise.google/policies/#ReportDeviceCpuInfo) * Data Collection
    /// Frequency: Every 10 minutes * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1CpuTemperatureInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. CPU label. Example: Core 0</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>Output only. CPU temperature in Celsius.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temperatureCelsius")]
        public virtual System.Nullable<int> TemperatureCelsius { get; set; }

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

    /// <summary>
    /// Report for CountChromeDevicesPerAueDateResponse, contains the count of devices of a specific model and auto
    /// update expiration range.
    /// </summary>
    public class GoogleChromeManagementV1DeviceAueCountReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Enum value of month corresponding to the auto update expiration date in UTC time zone. If the device is
        /// already expired, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aueMonth")]
        public virtual string AueMonth { get; set; }

        /// <summary>
        /// Int value of year corresponding to the Auto Update Expiration date in UTC time zone. If the device is
        /// already expired, this field is empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aueYear")]
        public virtual System.Nullable<long> AueYear { get; set; }

        /// <summary>Count of devices of this model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Boolean value for whether or not the device has already expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expired")]
        public virtual System.Nullable<bool> Expired { get; set; }

        /// <summary>Public model name of the devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Status of the single storage device.</summary>
    public class GoogleChromeManagementV1DiskInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of bytes read since last boot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesReadThisSession")]
        public virtual System.Nullable<long> BytesReadThisSession { get; set; }

        /// <summary>Output only. Number of bytes written since last boot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesWrittenThisSession")]
        public virtual System.Nullable<long> BytesWrittenThisSession { get; set; }

        /// <summary>
        /// Output only. Time spent discarding since last boot. Discarding is writing to clear blocks which are no
        /// longer in use. Supported on kernels 4.18+.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discardTimeThisSession")]
        public virtual object DiscardTimeThisSession { get; set; }

        /// <summary>Output only. Disk health.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("health")]
        public virtual string Health { get; set; }

        /// <summary>
        /// Output only. Counts the time the disk and queue were busy, so unlike the fields above, parallel requests are
        /// not counted multiple times.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ioTimeThisSession")]
        public virtual object IoTimeThisSession { get; set; }

        /// <summary>Output only. Disk manufacturer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Output only. Disk model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>Output only. Time spent reading from disk since last boot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTimeThisSession")]
        public virtual object ReadTimeThisSession { get; set; }

        /// <summary>Output only. Disk serial number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>Output only. Disk size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>Output only. Disk type: eMMC / NVMe / ATA / SCSI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Output only. Disk volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeIds")]
        public virtual System.Collections.Generic.IList<string> VolumeIds { get; set; }

        /// <summary>Output only. Time spent writing to disk since last boot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeTimeThisSession")]
        public virtual object WriteTimeThisSession { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information for a display.</summary>
    public class GoogleChromeManagementV1DisplayInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Represents the graphics card device id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>Output only. Indicates if display is internal or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInternal")]
        public virtual System.Nullable<bool> IsInternal { get; set; }

        /// <summary>Output only. Refresh rate in Hz.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshRate")]
        public virtual System.Nullable<int> RefreshRate { get; set; }

        /// <summary>Output only. Resolution height in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolutionHeight")]
        public virtual System.Nullable<int> ResolutionHeight { get; set; }

        /// <summary>Output only. Resolution width in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolutionWidth")]
        public virtual System.Nullable<int> ResolutionWidth { get; set; }

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

    /// <summary>Information of a graphics adapter (GPU).</summary>
    public class GoogleChromeManagementV1GraphicsAdapterInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Adapter name. Example: Mesa DRI Intel(R) UHD Graphics 620 (Kabylake GT2).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapter")]
        public virtual string Adapter { get; set; }

        /// <summary>Output only. Represents the graphics card device id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual System.Nullable<long> DeviceId { get; set; }

        /// <summary>Output only. Version of the GPU driver.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driverVersion")]
        public virtual string DriverVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information of the graphics subsystem. * This field provides device information, which is static and will not
    /// change over time. * Data for this field is controlled via policy:
    /// [ReportDeviceGraphicsStatus](https://chromeenterprise.google/policies/#ReportDeviceGraphicsStatus) * Data
    /// Collection Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes *
    /// Cache: If the device is offline, the collected data is stored locally, and will be reported when the device is
    /// next online: No * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1GraphicsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information about the graphics adapter (GPU).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adapterInfo")]
        public virtual GoogleChromeManagementV1GraphicsAdapterInfo AdapterInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information of the graphics subsystem. * This field is telemetry information and this will change over time as
    /// the device is utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceGraphicsInfo](https://chromeenterprise.google/policies/#ReportDeviceGraphicsInfo) * Data Collection
    /// Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online: No
    /// * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1GraphicsStatusReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Information about the displays for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displays")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1DisplayInfo> Displays { get; set; }

        /// <summary>Output only. Time at which the graphics data was reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data that describes the result of the HTTPS latency diagnostics routine, with the HTTPS requests issued to
    /// Google websites.
    /// </summary>
    public class GoogleChromeManagementV1HttpsLatencyRoutineData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. HTTPS latency if routine succeeded or failed because of HIGH_LATENCY or VERY_HIGH_LATENCY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency")]
        public virtual object Latency { get; set; }

        /// <summary>Output only. HTTPS latency routine problem if a problem occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("problem")]
        public virtual string Problem { get; set; }

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

    public class GoogleChromeManagementV1ListTelemetryDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Telemetry devices returned in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1TelemetryDevice> Devices { get; set; }

        /// <summary>Token to specify next page in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Memory information of a device. * This field has both telemetry and device information: - `totalRamBytes` -
    /// Device information - `availableRamBytes` - Telemetry information - `totalMemoryEncryption` - Device information
    /// * Data for this field is controlled via policy:
    /// [ReportDeviceMemoryInfo](https://chromeenterprise.google/policies/#ReportDeviceMemoryInfo) * Data Collection
    /// Frequency: - `totalRamBytes` - Only at upload - `availableRamBytes` - Every 10 minutes - `totalMemoryEncryption`
    /// - at device startup * Default Data Reporting Frequency: - `totalRamBytes` - 3 hours - `availableRamBytes` - 3
    /// hours - `totalMemoryEncryption` - at device startup - Policy Controlled: Yes * Cache: If the device is offline,
    /// the collected data is stored locally, and will be reported when the device is next online: only for
    /// `totalMemoryEncryption` * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1MemoryInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Amount of available RAM in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableRamBytes")]
        public virtual System.Nullable<long> AvailableRamBytes { get; set; }

        /// <summary>Output only. Total memory encryption info for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalMemoryEncryption")]
        public virtual GoogleChromeManagementV1TotalMemoryEncryptionInfo TotalMemoryEncryption { get; set; }

        /// <summary>Output only. Total RAM in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRamBytes")]
        public virtual System.Nullable<long> TotalRamBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains samples of memory status reports. * This field is telemetry information and this will change over time
    /// as the device is utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceMemoryInfo](https://chromeenterprise.google/policies/#ReportDeviceMemoryInfo) * Data Collection
    /// Frequency: Only at upload, SystemRamFreeByes is collected every 10 minutes * Default Data Reporting Frequency:
    /// Every 3 hours - Policy Controlled: Yes * Cache: If the device is offline, the collected data is stored locally,
    /// and will be reported when the device is next online: No * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1MemoryStatusReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of page faults during this collection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageFaults")]
        public virtual System.Nullable<int> PageFaults { get; set; }

        /// <summary>
        /// Output only. The timestamp in milliseconds representing time at which this report was sampled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>Output only. Frequency the report is sampled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleFrequency")]
        public virtual object SampleFrequency { get; set; }

        /// <summary>Output only. Amount of free RAM in bytes (unreliable due to Garbage Collection).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemRamFreeBytes")]
        public virtual System.Nullable<long> SystemRamFreeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about the network device. * This field provides device information, which is static and will not change
    /// over time. * Data for this field is controlled via policy:
    /// [ReportNetworkDeviceConfiguration](https://chromeenterprise.google/policies/#ReportNetworkDeviceConfiguration) *
    /// Data Collection Frequency: At device startup * Default Data Reporting Frequency: At device startup - Policy
    /// Controlled: Yes * Cache: If the device is offline, the collected data is stored locally, and will be reported
    /// when the device is next online: Yes * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1NetworkDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The integrated circuit card ID associated with the device's sim card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iccid")]
        public virtual string Iccid { get; set; }

        /// <summary>Output only. IMEI (if applicable) of the corresponding network device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; }

        /// <summary>Output only. MAC address (if applicable) of the corresponding network device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macAddress")]
        public virtual string MacAddress { get; set; }

        /// <summary>Output only. The mobile directory number associated with the device's sim card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mdn")]
        public virtual string Mdn { get; set; }

        /// <summary>Output only. MEID (if applicable) of the corresponding network device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; }

        /// <summary>Output only. Network device type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Network testing results to determine the health of the device's network connection, for example whether the
    /// HTTPS latency is high or normal.
    /// </summary>
    public class GoogleChromeManagementV1NetworkDiagnosticsReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. HTTPS latency test data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpsLatencyData")]
        public virtual GoogleChromeManagementV1HttpsLatencyRoutineData HttpsLatencyData { get; set; }

        /// <summary>Output only. Timestamp of when the diagnostics were collected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Network device information. * This field provides device information, which is static and will not change over
    /// time. * Data for this field is controlled via policy:
    /// [ReportNetworkDeviceConfiguration](https://chromeenterprise.google/policies/#ReportNetworkDeviceConfiguration) *
    /// Data Collection Frequency: At device startup * Default Data Reporting Frequency: At device startup - Policy
    /// Controlled: Yes * Cache: If the device is offline, the collected data is stored locally, and will be reported
    /// when the device is next online: Yes * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1NetworkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. List of network devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkDevices")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1NetworkDevice> NetworkDevices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// State of visible/configured networks. * This field is telemetry information and this will change over time as
    /// the device is utilized. * Data for this field is controlled via policy:
    /// [ReportNetworkStatus](https://chromeenterprise.google/policies/#ReportNetworkStatus) * Data Collection
    /// Frequency: 60 minutes * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes * Cache: If the
    /// device is offline, the collected data is stored locally, and will be reported when the device is next online:
    /// Yes * Reported for affiliated users only: Yes
    /// </summary>
    public class GoogleChromeManagementV1NetworkStatusReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Current connection state of the network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionState")]
        public virtual string ConnectionState { get; set; }

        /// <summary>Output only. Network connection type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionType")]
        public virtual string ConnectionType { get; set; }

        /// <summary>Output only. Whether the wifi encryption key is turned off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionOn")]
        public virtual System.Nullable<bool> EncryptionOn { get; set; }

        /// <summary>Output only. Gateway IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayIpAddress")]
        public virtual string GatewayIpAddress { get; set; }

        /// <summary>Output only. Network connection guid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guid")]
        public virtual string Guid { get; set; }

        /// <summary>Output only. LAN IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lanIpAddress")]
        public virtual string LanIpAddress { get; set; }

        /// <summary>Output only. Receiving bit rate measured in Megabits per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receivingBitRateMbps")]
        public virtual System.Nullable<long> ReceivingBitRateMbps { get; set; }

        /// <summary>Output only. Time at which the network state was reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>Output only. Frequency the report is sampled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleFrequency")]
        public virtual object SampleFrequency { get; set; }

        /// <summary>Output only. Signal strength for wireless networks measured in decibels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalStrengthDbm")]
        public virtual System.Nullable<int> SignalStrengthDbm { get; set; }

        /// <summary>Output only. Transmission bit rate measured in Megabits per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transmissionBitRateMbps")]
        public virtual System.Nullable<long> TransmissionBitRateMbps { get; set; }

        /// <summary>Output only. Transmission power measured in decibels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transmissionPowerDbm")]
        public virtual System.Nullable<int> TransmissionPowerDbm { get; set; }

        /// <summary>
        /// Output only. Wifi link quality. Value ranges from [0, 70]. 0 indicates no signal and 70 indicates a strong
        /// signal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiLinkQuality")]
        public virtual System.Nullable<long> WifiLinkQuality { get; set; }

        /// <summary>Output only. Wifi power management enabled</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiPowerManagementEnabled")]
        public virtual System.Nullable<bool> WifiPowerManagementEnabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information regarding the current OS update status. * This field is telemetry information and this will
    /// change over time as the device is utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceOsUpdateStatus](https://chromeenterprise.google/policies/#ReportDeviceOsUpdateStatus) * Data
    /// Collection Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes *
    /// Cache: If the device is offline, the collected data is stored locally, and will be reported when the device is
    /// next online: No * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1OsUpdateStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp of the last reboot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRebootTime")]
        public virtual object LastRebootTime { get; set; }

        /// <summary>Output only. Timestamp of the last update check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateCheckTime")]
        public virtual object LastUpdateCheckTime { get; set; }

        /// <summary>Output only. Timestamp of the last successful update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        /// <summary>
        /// Output only. New platform version of the os image being downloaded and applied. It is only set when update
        /// status is OS_IMAGE_DOWNLOAD_IN_PROGRESS or OS_UPDATE_NEED_REBOOT. Note this could be a dummy "0.0.0.0" for
        /// OS_UPDATE_NEED_REBOOT status for some edge cases, e.g. update engine is restarted without a reboot.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPlatformVersion")]
        public virtual string NewPlatformVersion { get; set; }

        /// <summary>Output only. New requested platform version from the pending updated kiosk app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newRequestedPlatformVersion")]
        public virtual string NewRequestedPlatformVersion { get; set; }

        /// <summary>Output only. Current state of the os update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateState")]
        public virtual string UpdateState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Status data for storage. * This field is telemetry information and this will change over time as the device is
    /// utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceStorageStatus](https://chromeenterprise.google/policies/#ReportDeviceStorageStatus) * Data
    /// Collection Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes *
    /// Cache: If the device is offline, the collected data is stored locally, and will be reported when the device is
    /// next online: No * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1StorageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The available space for user data storage in the device in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableDiskBytes")]
        public virtual System.Nullable<long> AvailableDiskBytes { get; set; }

        /// <summary>The total space for user data storage in the device in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDiskBytes")]
        public virtual System.Nullable<long> TotalDiskBytes { get; set; }

        /// <summary>Information for disk volumes</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volume")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1StorageInfoDiskVolume> Volume { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information for disk volumes</summary>
    public class GoogleChromeManagementV1StorageInfoDiskVolume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Free storage space in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageFreeBytes")]
        public virtual System.Nullable<long> StorageFreeBytes { get; set; }

        /// <summary>Total storage space in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageTotalBytes")]
        public virtual System.Nullable<long> StorageTotalBytes { get; set; }

        /// <summary>Disk volume id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
        public virtual string VolumeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Status data for storage. * This field is telemetry information and this will change over time as the device is
    /// utilized. * Data for this field is controlled via policy:
    /// [ReportDeviceStorageStatus](https://chromeenterprise.google/policies/#ReportDeviceStorageStatus) * Data
    /// Collection Frequency: Only at Upload * Default Data Reporting Frequency: 3 hours - Policy Controlled: Yes *
    /// Cache: If the device is offline, the collected data is stored locally, and will be reported when the device is
    /// next online: No * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1StorageStatusReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Reports on disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1DiskInfo> Disk { get; set; }

        /// <summary>Output only. Timestamp of when the sample was collected on device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
        public virtual object ReportTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Telemetry data collected from a managed device.</summary>
    public class GoogleChromeManagementV1TelemetryDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Audio reports collected periodically sorted in a decreasing order of report_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioStatusReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1AudioStatusReport> AudioStatusReport { get; set; }

        /// <summary>Output only. Information on battery specs for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batteryInfo")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1BatteryInfo> BatteryInfo { get; set; }

        /// <summary>Output only. Battery reports collected periodically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("batteryStatusReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1BatteryStatusReport> BatteryStatusReport { get; set; }

        /// <summary>Output only. Information regarding CPU specs for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuInfo")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1CpuInfo> CpuInfo { get; set; }

        /// <summary>
        /// Output only. CPU status reports collected periodically sorted in a decreasing order of report_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuStatusReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1CpuStatusReport> CpuStatusReport { get; set; }

        /// <summary>Output only. Google Workspace Customer whose enterprise enrolled the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customer")]
        public virtual string Customer { get; set; }

        /// <summary>
        /// Output only. The unique Directory API ID of the device. This value is the same as the Admin Console's
        /// Directory API ID in the ChromeOS Devices tab
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>Output only. Contains information regarding Graphic peripherals for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("graphicsInfo")]
        public virtual GoogleChromeManagementV1GraphicsInfo GraphicsInfo { get; set; }

        /// <summary>Output only. Graphics reports collected periodically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("graphicsStatusReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1GraphicsStatusReport> GraphicsStatusReport { get; set; }

        /// <summary>Output only. Information regarding memory specs for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryInfo")]
        public virtual GoogleChromeManagementV1MemoryInfo MemoryInfo { get; set; }

        /// <summary>
        /// Output only. Memory status reports collected periodically sorted decreasing by report_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryStatusReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1MemoryStatusReport> MemoryStatusReport { get; set; }

        /// <summary>Output only. Resource name of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Network diagnostics collected periodically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkDiagnosticsReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1NetworkDiagnosticsReport> NetworkDiagnosticsReport { get; set; }

        /// <summary>Output only. Network devices information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkInfo")]
        public virtual GoogleChromeManagementV1NetworkInfo NetworkInfo { get; set; }

        /// <summary>Output only. Network specs collected periodically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkStatusReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1NetworkStatusReport> NetworkStatusReport { get; set; }

        /// <summary>Output only. Organization unit ID of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; }

        /// <summary>Output only. Contains relevant information regarding ChromeOS update status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osUpdateStatus")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1OsUpdateStatus> OsUpdateStatus { get; set; }

        /// <summary>
        /// Output only. Device serial number. This value is the same as the Admin Console's Serial Number in the
        /// ChromeOS Devices tab.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>Output only. Information of storage specs for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageInfo")]
        public virtual GoogleChromeManagementV1StorageInfo StorageInfo { get; set; }

        /// <summary>Output only. Storage reports collected periodically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageStatusReport")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1StorageStatusReport> StorageStatusReport { get; set; }

        /// <summary>Output only. Information on Thunderbolt bus.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thunderboltInfo")]
        public virtual System.Collections.Generic.IList<GoogleChromeManagementV1ThunderboltInfo> ThunderboltInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Thunderbolt bus info. * This field provides device information, which is static and will not change over time. *
    /// Data for this field is controlled via policy:
    /// [ReportDeviceSecurityStatus](https://chromeenterprise.google/policies/#ReportDeviceSecurityStatus) * Data
    /// Collection Frequency: At device startup * Default Data Reporting Frequency: At device startup - Policy
    /// Controlled: No * Cache: If the device is offline, the collected data is stored locally, and will be reported
    /// when the device is next online: Yes * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1ThunderboltInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Security level of the Thunderbolt bus.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityLevel")]
        public virtual string SecurityLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Memory encryption information of a device. * This field provides device information, which is static and will
    /// not change over time. * Data for this field is controlled via policy:
    /// [ReportDeviceMemoryInfo](https://chromeenterprise.google/policies/#ReportDeviceMemoryInfo) * Data Collection
    /// Frequency: At device startup * Default Data Reporting Frequency: At device startup - Policy Controlled: Yes *
    /// Cache: If the device is offline, the collected data is stored locally, and will be reported when the device is
    /// next online: Yes * Reported for affiliated users only: N/A
    /// </summary>
    public class GoogleChromeManagementV1TotalMemoryEncryptionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Memory encryption algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionAlgorithm")]
        public virtual string EncryptionAlgorithm { get; set; }

        /// <summary>The state of memory encryption on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionState")]
        public virtual string EncryptionState { get; set; }

        /// <summary>The length of the encryption keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyLength")]
        public virtual System.Nullable<long> KeyLength { get; set; }

        /// <summary>The maximum number of keys that can be used for encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxKeys")]
        public virtual System.Nullable<long> MaxKeys { get; set; }

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

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
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
}
