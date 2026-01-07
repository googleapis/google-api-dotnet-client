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

namespace Google.Apis.GSuiteMarketplaceAPI.v2
{
    /// <summary>The GSuiteMarketplaceAPI Service.</summary>
    public class GSuiteMarketplaceAPIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GSuiteMarketplaceAPIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GSuiteMarketplaceAPIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            CustomerLicense = new CustomerLicenseResource(this);
            UserLicense = new UserLicenseResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://appsmarket.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://appsmarket.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "appsmarket";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Workspace Marketplace API.</summary>
        public class Scope
        {
            /// <summary>View your installed application's licensing information</summary>
            public static string AppsmarketplaceLicense = "https://www.googleapis.com/auth/appsmarketplace.license";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Workspace Marketplace API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View your installed application's licensing information</summary>
            public const string AppsmarketplaceLicense = "https://www.googleapis.com/auth/appsmarketplace.license";
        }

        /// <summary>Gets the CustomerLicense resource.</summary>
        public virtual CustomerLicenseResource CustomerLicense { get; }

        /// <summary>Gets the UserLicense resource.</summary>
        public virtual UserLicenseResource UserLicense { get; }
    }

    /// <summary>A base abstract class for GSuiteMarketplaceAPI requests.</summary>
    public abstract class GSuiteMarketplaceAPIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GSuiteMarketplaceAPIBaseServiceRequest instance.</summary>
        protected GSuiteMarketplaceAPIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GSuiteMarketplaceAPI parameter list.</summary>
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

    /// <summary>The "customerLicense" collection of methods.</summary>
    public class CustomerLicenseResource
    {
        private const string Resource = "customerLicense";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomerLicenseResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the status of a license for a customer to determine if they have access for a given app.
        /// </summary>
        /// <param name="applicationId">Application Id</param>
        /// <param name="customerId">Customer Id</param>
        public virtual GetRequest Get(string applicationId, string customerId)
        {
            return new GetRequest(this.service, applicationId, customerId);
        }

        /// <summary>
        /// Gets the status of a license for a customer to determine if they have access for a given app.
        /// </summary>
        public class GetRequest : GSuiteMarketplaceAPIBaseServiceRequest<Google.Apis.GSuiteMarketplaceAPI.v2.Data.CustomerLicense>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string applicationId, string customerId) : base(service)
            {
                ApplicationId = applicationId;
                CustomerId = customerId;
                InitParameters();
            }

            /// <summary>Application Id</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>Customer Id</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "appsmarket/v2/customerLicense/{applicationId}/{customerId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "userLicense" collection of methods.</summary>
    public class UserLicenseResource
    {
        private const string Resource = "userLicense";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UserLicenseResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the user's licensing status for their permission to use a given app.</summary>
        /// <param name="applicationId">Application Id</param>
        /// <param name="userId">User Id</param>
        public virtual GetRequest Get(string applicationId, string userId)
        {
            return new GetRequest(this.service, applicationId, userId);
        }

        /// <summary>Gets the user's licensing status for their permission to use a given app.</summary>
        public class GetRequest : GSuiteMarketplaceAPIBaseServiceRequest<Google.Apis.GSuiteMarketplaceAPI.v2.Data.UserLicense>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string applicationId, string userId) : base(service)
            {
                ApplicationId = applicationId;
                UserId = userId;
                InitParameters();
            }

            /// <summary>Application Id</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ApplicationId { get; private set; }

            /// <summary>User Id</summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "appsmarket/v2/userLicense/{applicationId}/{userId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("applicationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.GSuiteMarketplaceAPI.v2.Data
{
    public class CustomerLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the application corresponding to this license query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
        public virtual string ApplicationId { get; set; }

        /// <summary>The domain name of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>(Deprecated)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editions")]
        public virtual System.Collections.Generic.IList<Editions> Editions { get; set; }

        /// <summary>The ID of the customer license.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of API resource. This is always appsmarket#customerLicense.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The customer's license status. One of: - `ACTIVE`: The customer has a valid license. - `UNLICENSED`: There
        /// is no license: either this customer has never installed your application, or else has deleted it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Editions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Deprecated)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedSeats")]
        public virtual System.Nullable<int> AssignedSeats { get; set; }

        /// <summary>(Deprecated)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editionId")]
        public virtual string EditionId { get; set; }

        /// <summary>(Deprecated)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seatCount")]
        public virtual System.Nullable<int> SeatCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UserLicense : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the application corresponding to the license query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
        public virtual string ApplicationId { get; set; }

        /// <summary>The domain name of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>(Deprecated)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editionId")]
        public virtual string EditionId { get; set; }

        /// <summary>The domain administrator has activated the application for this domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ID of user license.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The type of API resource. This is always appsmarket#userLicense.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The user's licensing status. One of: - `ACTIVE`: The user has a valid license and should be permitted to use
        /// the application. - `UNLICENSED`: The administrator of this user's domain never assigned a seat for the
        /// application to this user. - `EXPIRED`: The administrator assigned a seat to this user, but the license is
        /// expired.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The email address of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
