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

namespace Google.Apis.DeveloperConnect.v1
{
    /// <summary>The DeveloperConnect Service.</summary>
    public class DeveloperConnectService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DeveloperConnectService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DeveloperConnectService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://developerconnect.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://developerconnect.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "developerconnect";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Developer Connect API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Developer Connect API.</summary>
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

    /// <summary>A base abstract class for DeveloperConnect requests.</summary>
    public abstract class DeveloperConnectBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DeveloperConnectBaseServiceRequest instance.</summary>
        protected DeveloperConnectBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DeveloperConnect parameter list.</summary>
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
                AccountConnectors = new AccountConnectorsResource(service);
                Connections = new ConnectionsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the AccountConnectors resource.</summary>
            public virtual AccountConnectorsResource AccountConnectors { get; }

            /// <summary>The "accountConnectors" collection of methods.</summary>
            public class AccountConnectorsResource
            {
                private const string Resource = "accountConnectors";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AccountConnectorsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Users = new UsersResource(service);
                }

                /// <summary>Gets the Users resource.</summary>
                public virtual UsersResource Users { get; }

                /// <summary>The "users" collection of methods.</summary>
                public class UsersResource
                {
                    private const string Resource = "users";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public UsersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Deletes a single User.</summary>
                    /// <param name="name">Required. Name of the resource</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single User.</summary>
                    public class DeleteRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. This checksum is computed by the server based on the value of other fields, and
                        /// may be sent on update and delete requests to ensure the client has an up-to-date value
                        /// before proceeding.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+/users/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Delete the User based on the user credentials.</summary>
                    /// <param name="name">Required. Name of the AccountConnector resource</param>
                    public virtual DeleteSelfRequest DeleteSelf(string name)
                    {
                        return new DeleteSelfRequest(this.service, name);
                    }

                    /// <summary>Delete the User based on the user credentials.</summary>
                    public class DeleteSelfRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new DeleteSelf request.</summary>
                        public DeleteSelfRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the AccountConnector resource</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deleteSelf";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/users:deleteSelf";

                        /// <summary>Initializes DeleteSelf parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches OAuth access token based on end user credentials.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="accountConnector">
                    /// Required. The resource name of the AccountConnector in the format
                    /// `projects/*/locations/*/accountConnectors/*`.
                    /// </param>
                    public virtual FetchAccessTokenRequest FetchAccessToken(Google.Apis.DeveloperConnect.v1.Data.FetchAccessTokenRequest body, string accountConnector)
                    {
                        return new FetchAccessTokenRequest(this.service, body, accountConnector);
                    }

                    /// <summary>Fetches OAuth access token based on end user credentials.</summary>
                    public class FetchAccessTokenRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.FetchAccessTokenResponse>
                    {
                        /// <summary>Constructs a new FetchAccessToken request.</summary>
                        public FetchAccessTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.FetchAccessTokenRequest body, string accountConnector) : base(service)
                        {
                            AccountConnector = accountConnector;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the AccountConnector in the format
                        /// `projects/*/locations/*/accountConnectors/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("accountConnector", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AccountConnector { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.FetchAccessTokenRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchAccessToken";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+accountConnector}/users:fetchAccessToken";

                        /// <summary>Initializes FetchAccessToken parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("accountConnector", new Google.Apis.Discovery.Parameter
                            {
                                Name = "accountConnector",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetch the User based on the user credentials.</summary>
                    /// <param name="name">Required. Name of the AccountConnector resource</param>
                    public virtual FetchSelfRequest FetchSelf(string name)
                    {
                        return new FetchSelfRequest(this.service, name);
                    }

                    /// <summary>Fetch the User based on the user credentials.</summary>
                    public class FetchSelfRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.User>
                    {
                        /// <summary>Constructs a new FetchSelf request.</summary>
                        public FetchSelfRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the AccountConnector resource</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchSelf";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/users:fetchSelf";

                        /// <summary>Initializes FetchSelf parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists Users in a given project, location, and account_connector.</summary>
                    /// <param name="parent">Required. Parent value for ListUsersRequest</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists Users in a given project, location, and account_connector.</summary>
                    public class ListRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.ListUsersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for ListUsersRequest</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/users";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+$",
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

                /// <summary>Creates a new AccountConnector in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Location resource name as the account_connector’s parent.</param>
                public virtual CreateRequest Create(Google.Apis.DeveloperConnect.v1.Data.AccountConnector body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new AccountConnector in a given project and location.</summary>
                public class CreateRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.AccountConnector body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Location resource name as the account_connector’s parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The ID to use for the AccountConnector, which will become the final component of the
                    /// AccountConnector's resource name. Its format should adhere to
                    /// https://google.aip.dev/122#resource-id-segments Names must be unique per-project per-location.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountConnectorId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string AccountConnectorId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeveloperConnect.v1.Data.AccountConnector Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/accountConnectors";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("accountConnectorId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountConnectorId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single AccountConnector.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single AccountConnector.</summary>
                public class DeleteRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The current etag of the AccountConnectorn. If an etag is provided and does not match
                    /// the current etag of the AccountConnector, deletion will be blocked and an ABORTED error will be
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. If set to true, any Users from this AccountConnector will also be deleted. (Otherwise,
                    /// the request will only work if the AccountConnector has no Users.)
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets details of a single AccountConnector.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single AccountConnector.</summary>
                public class GetRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.AccountConnector>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists AccountConnectors in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListAccountConnectorsRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists AccountConnectors in a given project and location.</summary>
                public class ListRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.ListAccountConnectorsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListAccountConnectorsRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/accountConnectors";

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
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
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

                /// <summary>Updates the parameters of a single AccountConnector.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the accountConnector, in the format
                /// `projects/{project}/locations/{location}/accountConnectors/{account_connector_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DeveloperConnect.v1.Data.AccountConnector body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single AccountConnector.</summary>
                public class PatchRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.AccountConnector body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the accountConnector, in the format
                    /// `projects/{project}/locations/{location}/accountConnectors/{account_connector_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, and the accountConnector is not found a new accountConnector will be
                    /// created. In this situation `update_mask` is ignored. The creation will succeed only if the input
                    /// accountConnector has all the necessary
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Optional. The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeveloperConnect.v1.Data.AccountConnector Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/accountConnectors/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Connections resource.</summary>
            public virtual ConnectionsResource Connections { get; }

            /// <summary>The "connections" collection of methods.</summary>
            public class ConnectionsResource
            {
                private const string Resource = "connections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ConnectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    GitRepositoryLinks = new GitRepositoryLinksResource(service);
                }

                /// <summary>Gets the GitRepositoryLinks resource.</summary>
                public virtual GitRepositoryLinksResource GitRepositoryLinks { get; }

                /// <summary>The "gitRepositoryLinks" collection of methods.</summary>
                public class GitRepositoryLinksResource
                {
                    private const string Resource = "gitRepositoryLinks";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GitRepositoryLinksResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer Connect will configure the
                    /// Git Repository to send webhook events to Developer Connect. Connections that use Firebase GitHub
                    /// Application will have events forwarded to the Firebase service. All other Connections will have
                    /// events forwarded to Cloud Build.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. Value for parent.</param>
                    public virtual CreateRequest Create(Google.Apis.DeveloperConnect.v1.Data.GitRepositoryLink body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Creates a GitRepositoryLink. Upon linking a Git Repository, Developer Connect will configure the
                    /// Git Repository to send webhook events to Developer Connect. Connections that use Firebase GitHub
                    /// Application will have events forwarded to the Firebase service. All other Connections will have
                    /// events forwarded to Cloud Build.
                    /// </summary>
                    public class CreateRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.GitRepositoryLink body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Value for parent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the repository, which will become the final component of the
                        /// repository's resource name. This ID should be unique in the connection. Allows alphanumeric
                        /// characters and any of -._~%!$&amp;amp;'()*+,;=@.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("gitRepositoryLinkId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string GitRepositoryLinkId { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes since the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.GitRepositoryLink Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/gitRepositoryLinks";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                            });
                            RequestParameters.Add("gitRepositoryLinkId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gitRepositoryLinkId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes a single GitRepositoryLink.</summary>
                    /// <param name="name">Required. Name of the resource</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Deletes a single GitRepositoryLink.</summary>
                    public class DeleteRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Optional. This checksum is computed by the server based on the value of other fields, and
                        /// may be sent on update and delete requests to ensure the client has an up-to-date value
                        /// before proceeding.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Etag { get; set; }

                        /// <summary>
                        /// Optional. An optional request ID to identify requests. Specify a unique request ID so that
                        /// if you must retry your request, the server will know to ignore the request if it has already
                        /// been completed. The server will guarantee that for at least 60 minutes after the first
                        /// request. For example, consider a situation where you make an initial request and the request
                        /// times out. If you make the request again with the same request ID, the server can check if
                        /// original operation with the same request ID was received, and if so, will ignore the second
                        /// request. This prevents clients from accidentally creating duplicate commitments. The request
                        /// ID must be a valid UUID with the exception that zero UUID is not supported
                        /// (00000000-0000-0000-0000-000000000000).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RequestId { get; set; }

                        /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                            RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                            {
                                Name = "etag",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "requestId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                            {
                                Name = "validateOnly",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Fetch the list of branches or tags for a given repository.</summary>
                    /// <param name="gitRepositoryLink">
                    /// Required. The resource name of GitRepositoryLink in the format
                    /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                    /// </param>
                    public virtual FetchGitRefsRequest FetchGitRefs(string gitRepositoryLink)
                    {
                        return new FetchGitRefsRequest(this.service, gitRepositoryLink);
                    }

                    /// <summary>Fetch the list of branches or tags for a given repository.</summary>
                    public class FetchGitRefsRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.FetchGitRefsResponse>
                    {
                        /// <summary>Constructs a new FetchGitRefs request.</summary>
                        public FetchGitRefsRequest(Google.Apis.Services.IClientService service, string gitRepositoryLink) : base(service)
                        {
                            GitRepositoryLink = gitRepositoryLink;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of GitRepositoryLink in the format
                        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("gitRepositoryLink", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string GitRepositoryLink { get; private set; }

                        /// <summary>Optional. Number of results to return in the list. Default to 20.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. Page start.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Required. Type of refs to fetch.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("refType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<RefTypeEnum> RefType { get; set; }

                        /// <summary>Required. Type of refs to fetch.</summary>
                        public enum RefTypeEnum
                        {
                            /// <summary>No type specified.</summary>
                            [Google.Apis.Util.StringValueAttribute("REF_TYPE_UNSPECIFIED")]
                            REFTYPEUNSPECIFIED = 0,

                            /// <summary>To fetch tags.</summary>
                            [Google.Apis.Util.StringValueAttribute("TAG")]
                            TAG = 1,

                            /// <summary>To fetch branches.</summary>
                            [Google.Apis.Util.StringValueAttribute("BRANCH")]
                            BRANCH = 2,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchGitRefs";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+gitRepositoryLink}:fetchGitRefs";

                        /// <summary>Initializes FetchGitRefs parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("gitRepositoryLink", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gitRepositoryLink",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
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
                            RequestParameters.Add("refType", new Google.Apis.Discovery.Parameter
                            {
                                Name = "refType",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Fetches read token of a given gitRepositoryLink.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="gitRepositoryLink">
                    /// Required. The resource name of the gitRepositoryLink in the format
                    /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                    /// </param>
                    public virtual FetchReadTokenRequest FetchReadToken(Google.Apis.DeveloperConnect.v1.Data.FetchReadTokenRequest body, string gitRepositoryLink)
                    {
                        return new FetchReadTokenRequest(this.service, body, gitRepositoryLink);
                    }

                    /// <summary>Fetches read token of a given gitRepositoryLink.</summary>
                    public class FetchReadTokenRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.FetchReadTokenResponse>
                    {
                        /// <summary>Constructs a new FetchReadToken request.</summary>
                        public FetchReadTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.FetchReadTokenRequest body, string gitRepositoryLink) : base(service)
                        {
                            GitRepositoryLink = gitRepositoryLink;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the gitRepositoryLink in the format
                        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("gitRepositoryLink", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string GitRepositoryLink { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.FetchReadTokenRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchReadToken";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+gitRepositoryLink}:fetchReadToken";

                        /// <summary>Initializes FetchReadToken parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("gitRepositoryLink", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gitRepositoryLink",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Fetches read/write token of a given gitRepositoryLink.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="gitRepositoryLink">
                    /// Required. The resource name of the gitRepositoryLink in the format
                    /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                    /// </param>
                    public virtual FetchReadWriteTokenRequest FetchReadWriteToken(Google.Apis.DeveloperConnect.v1.Data.FetchReadWriteTokenRequest body, string gitRepositoryLink)
                    {
                        return new FetchReadWriteTokenRequest(this.service, body, gitRepositoryLink);
                    }

                    /// <summary>Fetches read/write token of a given gitRepositoryLink.</summary>
                    public class FetchReadWriteTokenRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.FetchReadWriteTokenResponse>
                    {
                        /// <summary>Constructs a new FetchReadWriteToken request.</summary>
                        public FetchReadWriteTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.FetchReadWriteTokenRequest body, string gitRepositoryLink) : base(service)
                        {
                            GitRepositoryLink = gitRepositoryLink;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the gitRepositoryLink in the format
                        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("gitRepositoryLink", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string GitRepositoryLink { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.FetchReadWriteTokenRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "fetchReadWriteToken";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+gitRepositoryLink}:fetchReadWriteToken";

                        /// <summary>Initializes FetchReadWriteToken parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("gitRepositoryLink", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gitRepositoryLink",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details of a single GitRepositoryLink.</summary>
                    /// <param name="name">Required. Name of the resource</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Gets details of a single GitRepositoryLink.</summary>
                    public class GetRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.GitRepositoryLink>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the resource</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists GitRepositoryLinks in a given project, location, and connection.</summary>
                    /// <param name="parent">Required. Parent value for ListGitRepositoryLinksRequest</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists GitRepositoryLinks in a given project, location, and connection.</summary>
                    public class ListRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.ListGitRepositoryLinksResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Parent value for ListGitRepositoryLinksRequest</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Optional. Filtering results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>Optional. Hint for how to order the results</summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                        /// server will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/gitRepositoryLinks";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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
                    /// ProcessBitbucketCloudWebhook is called by the external Bitbucket Cloud instances for notifying
                    /// events.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The GitRepositoryLink where the webhook will be received. Format:
                    /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                    /// </param>
                    public virtual ProcessBitbucketCloudWebhookRequest ProcessBitbucketCloudWebhook(Google.Apis.DeveloperConnect.v1.Data.ProcessBitbucketCloudWebhookRequest body, string name)
                    {
                        return new ProcessBitbucketCloudWebhookRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// ProcessBitbucketCloudWebhook is called by the external Bitbucket Cloud instances for notifying
                    /// events.
                    /// </summary>
                    public class ProcessBitbucketCloudWebhookRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new ProcessBitbucketCloudWebhook request.</summary>
                        public ProcessBitbucketCloudWebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.ProcessBitbucketCloudWebhookRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The GitRepositoryLink where the webhook will be received. Format:
                        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.ProcessBitbucketCloudWebhookRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "processBitbucketCloudWebhook";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:processBitbucketCloudWebhook";

                        /// <summary>Initializes ProcessBitbucketCloudWebhook parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// ProcessBitbucketDataCenterWebhook is called by the external Bitbucket Data Center instances for
                    /// notifying events.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The GitRepositoryLink where the webhook will be received. Format:
                    /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                    /// </param>
                    public virtual ProcessBitbucketDataCenterWebhookRequest ProcessBitbucketDataCenterWebhook(Google.Apis.DeveloperConnect.v1.Data.ProcessBitbucketDataCenterWebhookRequest body, string name)
                    {
                        return new ProcessBitbucketDataCenterWebhookRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// ProcessBitbucketDataCenterWebhook is called by the external Bitbucket Data Center instances for
                    /// notifying events.
                    /// </summary>
                    public class ProcessBitbucketDataCenterWebhookRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new ProcessBitbucketDataCenterWebhook request.</summary>
                        public ProcessBitbucketDataCenterWebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.ProcessBitbucketDataCenterWebhookRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The GitRepositoryLink where the webhook will be received. Format:
                        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.ProcessBitbucketDataCenterWebhookRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "processBitbucketDataCenterWebhook";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:processBitbucketDataCenterWebhook";

                        /// <summary>Initializes ProcessBitbucketDataCenterWebhook parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// ProcessGitLabEnterpriseWebhook is called by the external GitLab Enterprise instances for
                    /// notifying events.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The GitRepositoryLink resource where the webhook will be received. Format:
                    /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                    /// </param>
                    public virtual ProcessGitLabEnterpriseWebhookRequest ProcessGitLabEnterpriseWebhook(Google.Apis.DeveloperConnect.v1.Data.ProcessGitLabEnterpriseWebhookRequest body, string name)
                    {
                        return new ProcessGitLabEnterpriseWebhookRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// ProcessGitLabEnterpriseWebhook is called by the external GitLab Enterprise instances for
                    /// notifying events.
                    /// </summary>
                    public class ProcessGitLabEnterpriseWebhookRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new ProcessGitLabEnterpriseWebhook request.</summary>
                        public ProcessGitLabEnterpriseWebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.ProcessGitLabEnterpriseWebhookRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The GitRepositoryLink resource where the webhook will be received. Format:
                        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.ProcessGitLabEnterpriseWebhookRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "processGitLabEnterpriseWebhook";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:processGitLabEnterpriseWebhook";

                        /// <summary>Initializes ProcessGitLabEnterpriseWebhook parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                        }
                    }

                    /// <summary>ProcessGitLabWebhook is called by the GitLab.com for notifying events.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The GitRepositoryLink resource where the webhook will be received. Format:
                    /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                    /// </param>
                    public virtual ProcessGitLabWebhookRequest ProcessGitLabWebhook(Google.Apis.DeveloperConnect.v1.Data.ProcessGitLabWebhookRequest body, string name)
                    {
                        return new ProcessGitLabWebhookRequest(this.service, body, name);
                    }

                    /// <summary>ProcessGitLabWebhook is called by the GitLab.com for notifying events.</summary>
                    public class ProcessGitLabWebhookRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new ProcessGitLabWebhook request.</summary>
                        public ProcessGitLabWebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.ProcessGitLabWebhookRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The GitRepositoryLink resource where the webhook will be received. Format:
                        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.DeveloperConnect.v1.Data.ProcessGitLabWebhookRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "processGitLabWebhook";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:processGitLabWebhook";

                        /// <summary>Initializes ProcessGitLabWebhook parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+/gitRepositoryLinks/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Creates a new Connection in a given project and location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. Value for parent.</param>
                public virtual CreateRequest Create(Google.Apis.DeveloperConnect.v1.Data.Connection body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new Connection in a given project and location.</summary>
                public class CreateRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.Connection body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. Value for parent.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Id of the requesting object If auto-generating Id server-side, remove this field and
                    /// connection_id from the method_signature of Create RPC
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connectionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ConnectionId { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeveloperConnect.v1.Data.Connection Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connections";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("connectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connectionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a single Connection.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>Deletes a single Connection.</summary>
                public class DeleteRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The current etag of the Connection. If an etag is provided and does not match the
                    /// current etag of the Connection, deletion will be blocked and an ABORTED error will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes after the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// FetchGitHubInstallations returns the list of GitHub Installations that are available to be added to
                /// a Connection. For github.com, only installations accessible to the authorizer token are returned.
                /// For GitHub Enterprise, all installations are returned.
                /// </summary>
                /// <param name="connection">
                /// Required. The resource name of the connection in the format `projects/*/locations/*/connections/*`.
                /// </param>
                public virtual FetchGitHubInstallationsRequest FetchGitHubInstallations(string connection)
                {
                    return new FetchGitHubInstallationsRequest(this.service, connection);
                }

                /// <summary>
                /// FetchGitHubInstallations returns the list of GitHub Installations that are available to be added to
                /// a Connection. For github.com, only installations accessible to the authorizer token are returned.
                /// For GitHub Enterprise, all installations are returned.
                /// </summary>
                public class FetchGitHubInstallationsRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.FetchGitHubInstallationsResponse>
                {
                    /// <summary>Constructs a new FetchGitHubInstallations request.</summary>
                    public FetchGitHubInstallationsRequest(Google.Apis.Services.IClientService service, string connection) : base(service)
                    {
                        Connection = connection;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the connection in the format
                    /// `projects/*/locations/*/connections/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connection", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Connection { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchGitHubInstallations";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+connection}:fetchGitHubInstallations";

                    /// <summary>Initializes FetchGitHubInstallations parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("connection", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connection",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// FetchLinkableGitRepositories returns a list of git repositories from an SCM that are available to be
                /// added to a Connection.
                /// </summary>
                /// <param name="connection">
                /// Required. The name of the Connection. Format: `projects/*/locations/*/connections/*`.
                /// </param>
                public virtual FetchLinkableGitRepositoriesRequest FetchLinkableGitRepositories(string connection)
                {
                    return new FetchLinkableGitRepositoriesRequest(this.service, connection);
                }

                /// <summary>
                /// FetchLinkableGitRepositories returns a list of git repositories from an SCM that are available to be
                /// added to a Connection.
                /// </summary>
                public class FetchLinkableGitRepositoriesRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.FetchLinkableGitRepositoriesResponse>
                {
                    /// <summary>Constructs a new FetchLinkableGitRepositories request.</summary>
                    public FetchLinkableGitRepositoriesRequest(Google.Apis.Services.IClientService service, string connection) : base(service)
                    {
                        Connection = connection;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the Connection. Format: `projects/*/locations/*/connections/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("connection", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Connection { get; private set; }

                    /// <summary>Optional. Number of results to return in the list. Defaults to 20.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. Page start.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchLinkableGitRepositories";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+connection}:fetchLinkableGitRepositories";

                    /// <summary>Initializes FetchLinkableGitRepositories parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("connection", new Google.Apis.Discovery.Parameter
                        {
                            Name = "connection",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
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

                /// <summary>Gets details of a single Connection.</summary>
                /// <param name="name">Required. Name of the resource</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets details of a single Connection.</summary>
                public class GetRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Connection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Name of the resource</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists Connections in a given project and location.</summary>
                /// <param name="parent">Required. Parent value for ListConnectionsRequest</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists Connections in a given project and location.</summary>
                public class ListRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.ListConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Parent value for ListConnectionsRequest</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Filtering results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Hint for how to order the results</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Requested page size. Server may return fewer items than requested. If unspecified,
                    /// server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A token identifying a page of results the server should return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connections";

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
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
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

                /// <summary>Updates the parameters of a single Connection.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. The resource name of the connection, in the format
                /// `projects/{project}/locations/{location}/connections/{connection_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DeveloperConnect.v1.Data.Connection body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates the parameters of a single Connection.</summary>
                public class PatchRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.Connection body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. The resource name of the connection, in the format
                    /// `projects/{project}/locations/{location}/connections/{connection_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. If set to true, and the connection is not found a new connection will be created. In
                    /// this situation `update_mask` is ignored. The creation will succeed only if the input connection
                    /// has all the necessary information (e.g a github_config with both user_oauth_token and
                    /// installation_id properties).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> AllowMissing { get; set; }

                    /// <summary>
                    /// Optional. An optional request ID to identify requests. Specify a unique request ID so that if
                    /// you must retry your request, the server will know to ignore the request if it has already been
                    /// completed. The server will guarantee that for at least 60 minutes since the first request. For
                    /// example, consider a situation where you make an initial request and the request times out. If
                    /// you make the request again with the same request ID, the server can check if original operation
                    /// with the same request ID was received, and if so, will ignore the second request. This prevents
                    /// clients from accidentally creating duplicate commitments. The request ID must be a valid UUID
                    /// with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string RequestId { get; set; }

                    /// <summary>
                    /// Required. Field mask is used to specify the fields to be overwritten in the Connection resource
                    /// by the update. The fields specified in the update_mask are relative to the resource, not the
                    /// full request. A field will be overwritten if it is in the mask. If the user does not provide a
                    /// mask then all fields will be overwritten.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Optional. If set, validate the request, but do not actually post it.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("validateOnly", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ValidateOnly { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeveloperConnect.v1.Data.Connection Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/connections/[^/]+$",
                        });
                        RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                        {
                            Name = "allowMissing",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "requestId",
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
                        RequestParameters.Add("validateOnly", new Google.Apis.Discovery.Parameter
                        {
                            Name = "validateOnly",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// ProcessGitHubEnterpriseWebhook is called by the external GitHub Enterprise instances for notifying
                /// events.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Project and location where the webhook will be received. Format: `projects/*/locations/*`.
                /// </param>
                public virtual ProcessGitHubEnterpriseWebhookRequest ProcessGitHubEnterpriseWebhook(Google.Apis.DeveloperConnect.v1.Data.ProcessGitHubEnterpriseWebhookRequest body, string parent)
                {
                    return new ProcessGitHubEnterpriseWebhookRequest(this.service, body, parent);
                }

                /// <summary>
                /// ProcessGitHubEnterpriseWebhook is called by the external GitHub Enterprise instances for notifying
                /// events.
                /// </summary>
                public class ProcessGitHubEnterpriseWebhookRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Empty>
                {
                    /// <summary>Constructs a new ProcessGitHubEnterpriseWebhook request.</summary>
                    public ProcessGitHubEnterpriseWebhookRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.ProcessGitHubEnterpriseWebhookRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Project and location where the webhook will be received. Format:
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeveloperConnect.v1.Data.ProcessGitHubEnterpriseWebhookRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "processGitHubEnterpriseWebhook";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/connections:processGitHubEnterpriseWebhook";

                    /// <summary>Initializes ProcessGitHubEnterpriseWebhook parameter list.</summary>
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
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.DeveloperConnect.v1.Data.CancelOperationRequest body, string name)
                {
                    return new CancelRequest(this.service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
                /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
                /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
                /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
                /// Operation.error value with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
                /// </summary>
                public class CancelRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DeveloperConnect.v1.Data.CancelOperationRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DeveloperConnect.v1.Data.CancelOperationRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
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
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(this.service, name);
                }

                /// <summary>
                /// Deletes a long-running operation. This method indicates that the client is no longer interested in
                /// the operation result. It does not cancel the operation. If the server doesn't support this method,
                /// it returns `google.rpc.Code.UNIMPLEMENTED`.
                /// </summary>
                public class DeleteRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource to be deleted.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
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
                public class GetRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Operation>
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
                public class ListRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.ListOperationsResponse>
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.Location>
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
                return new ListRequest(this.service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : DeveloperConnectBaseServiceRequest<Google.Apis.DeveloperConnect.v1.Data.ListLocationsResponse>
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
                /// Optional. A list of extra location types that should be used as conditions for controlling the
                /// visibility of the locations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("extraLocationTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ExtraLocationTypes { get; set; }

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
namespace Google.Apis.DeveloperConnect.v1.Data
{
    /// <summary>
    /// AccountConnector encapsulates what a platform administrator needs to configure for users to connect to the
    /// service providers, which includes, among other fields, the OAuth client ID, client secret, and authorization and
    /// token endpoints.
    /// </summary>
    public class AccountConnector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Allows users to store small amounts of arbitrary data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the accountConnector was created.</summary>
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
        /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Optional. Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the accountConnector, in the format
        /// `projects/{project}/locations/{location}/accountConnectors/{account_connector_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Start OAuth flow by clicking on this URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthStartUri")]
        public virtual string OauthStartUri { get; set; }

        /// <summary>Provider OAuth config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("providerOauthConfig")]
        public virtual ProviderOAuthConfig ProviderOauthConfig { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The timestamp when the accountConnector was updated.</summary>
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
    }

    /// <summary>Configuration for connections to an instance of Bitbucket Cloud.</summary>
    public class BitbucketCloudConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. An access token with the minimum `repository`, `pullrequest` and `webhook` scope access. It can
        /// either be a workspace, project or repository access token. This is needed to create webhooks. It's
        /// recommended to use a system account to generate these credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizerCredential")]
        public virtual UserCredential AuthorizerCredential { get; set; }

        /// <summary>
        /// Required. An access token with the minimum `repository` access. It can either be a workspace, project or
        /// repository access token. It's recommended to use a system account to generate the credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAuthorizerCredential")]
        public virtual UserCredential ReadAuthorizerCredential { get; set; }

        /// <summary>
        /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events,
        /// formatted as `projects/*/secrets/*/versions/*`. This is used to validate and create webhooks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretSecretVersion")]
        public virtual string WebhookSecretSecretVersion { get; set; }

        /// <summary>Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspace")]
        public virtual string Workspace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for connections to an instance of Bitbucket Data Center.</summary>
    public class BitbucketDataCenterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. An http access token with the minimum `Repository admin` scope access. This is needed to create
        /// webhooks. It's recommended to use a system account to generate these credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizerCredential")]
        public virtual UserCredential AuthorizerCredential { get; set; }

        /// <summary>Required. The URI of the Bitbucket Data Center host this connection is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>
        /// Required. An http access token with the minimum `Repository read` access. It's recommended to use a system
        /// account to generate the credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAuthorizerCredential")]
        public virtual UserCredential ReadAuthorizerCredential { get; set; }

        /// <summary>Output only. Version of the Bitbucket Data Center server running on the `host_uri`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverVersion")]
        public virtual string ServerVersion { get; set; }

        /// <summary>
        /// Optional. Configuration for using Service Directory to privately connect to a Bitbucket Data Center
        /// instance. This should only be set if the Bitbucket Data Center is hosted on-premises and not reachable by
        /// public internet. If this field is left empty, calls to the Bitbucket Data Center will be made over the
        /// public internet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>
        /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data Center.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCaCertificate")]
        public virtual string SslCaCertificate { get; set; }

        /// <summary>
        /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook events,
        /// formatted as `projects/*/secrets/*/versions/*`. This is used to validate webhooks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretSecretVersion")]
        public virtual string WebhookSecretSecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing Connection object</summary>
    public class Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Allows clients to store small amounts of arbitrary data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Configuration for connections to an instance of Bitbucket Clouds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketCloudConfig")]
        public virtual BitbucketCloudConfig BitbucketCloudConfig { get; set; }

        /// <summary>Configuration for connections to an instance of Bitbucket Data Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bitbucketDataCenterConfig")]
        public virtual BitbucketDataCenterConfig BitbucketDataCenterConfig { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. [Output only] Create timestamp</summary>
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
        /// Optional. The crypto key configuration. This field is used by the Customer-Managed Encryption Keys (CMEK)
        /// feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyConfig")]
        public virtual CryptoKeyConfig CryptoKeyConfig { get; set; }

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. [Output only] Delete timestamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. If disabled is set to true, functionality is disabled for this connection. Repository based API
        /// methods and webhooks processing for repositories in this connection will be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Configuration for the git proxy feature. Enabling the git proxy allows clients to perform git
        /// operations on the repositories linked in the connection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitProxyConfig")]
        public virtual GitProxyConfig GitProxyConfig { get; set; }

        /// <summary>Configuration for connections to github.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubConfig")]
        public virtual GitHubConfig GithubConfig { get; set; }

        /// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubEnterpriseConfig")]
        public virtual GitHubEnterpriseConfig GithubEnterpriseConfig { get; set; }

        /// <summary>Configuration for connections to gitlab.com.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabConfig")]
        public virtual GitLabConfig GitlabConfig { get; set; }

        /// <summary>Configuration for connections to an instance of GitLab Enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitlabEnterpriseConfig")]
        public virtual GitLabEnterpriseConfig GitlabEnterpriseConfig { get; set; }

        /// <summary>Output only. Installation state of the Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installationState")]
        public virtual InstallationState InstallationState { get; set; }

        /// <summary>Optional. Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. The resource name of the connection, in the format
        /// `projects/{project}/locations/{location}/connections/{connection_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Set to true when the connection is being set up or updated in the background.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. A system-assigned unique identifier for the Connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. [Output only] Update timestamp</summary>
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
    }

    /// <summary>
    /// The crypto key configuration. This field is used by the Customer-managed encryption keys (CMEK) feature.
    /// </summary>
    public class CryptoKeyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The name of the key which is used to encrypt/decrypt customer data. For key in Cloud KMS, the key
        /// should be in the format of `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyReference")]
        public virtual string KeyReference { get; set; }

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

    /// <summary>Message for representing an error from exchanging OAuth tokens.</summary>
    public class ExchangeError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>https://datatracker.ietf.org/doc/html/rfc6749#section-5.2 - error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>https://datatracker.ietf.org/doc/html/rfc6749#section-5.2 - error_description</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for fetching an OAuth access token.</summary>
    public class FetchAccessTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for responding to getting an OAuth access token.</summary>
    public class FetchAccessTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error resulted from exchanging OAuth tokens from the service provider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exchangeError")]
        public virtual ExchangeError ExchangeError { get; set; }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>Expiration timestamp. Can be empty if unknown or non-expiring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The scopes of the access token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The token content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of fetching github installations.</summary>
    public class FetchGitHubInstallationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of installations available to the OAuth user (for github.com) or all the installations (for GitHub
        /// enterprise).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installations")]
        public virtual System.Collections.Generic.IList<Installation> Installations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for fetching git refs.</summary>
    public class FetchGitRefsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Name of the refs fetched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refNames")]
        public virtual System.Collections.Generic.IList<string> RefNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for FetchLinkableGitRepositories.</summary>
    public class FetchLinkableGitRepositoriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The git repositories that can be linked to the connection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkableGitRepositories")]
        public virtual System.Collections.Generic.IList<LinkableGitRepository> LinkableGitRepositories { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for fetching SCM read token.</summary>
    public class FetchReadTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for responding to get read token.</summary>
    public class FetchReadTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>Expiration timestamp. Can be empty if unknown or non-expiring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The git_username to specify when making a git clone with the token. For example, for GitHub
        /// GitRepositoryLinks, this would be "x-access-token"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitUsername")]
        public virtual string GitUsername { get; set; }

        /// <summary>The token content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for fetching SCM read/write token.</summary>
    public class FetchReadWriteTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for responding to get read/write token.</summary>
    public class FetchReadWriteTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>Expiration timestamp. Can be empty if unknown or non-expiring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The git_username to specify when making a git clone with the token. For example, for GitHub
        /// GitRepositoryLinks, this would be "x-access-token"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitUsername")]
        public virtual string GitUsername { get; set; }

        /// <summary>The token content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for connections to github.com.</summary>
    public class GitHubConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. GitHub App installation id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInstallationId")]
        public virtual System.Nullable<long> AppInstallationId { get; set; }

        /// <summary>
        /// Optional. OAuth credential of the account that authorized the GitHub App. It is recommended to use a robot
        /// account instead of a human user account. The OAuth token must be tied to the GitHub App of this config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizerCredential")]
        public virtual OAuthCredential AuthorizerCredential { get; set; }

        /// <summary>
        /// Required. Immutable. The GitHub Application that was installed to the GitHub user or organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("githubApp")]
        public virtual string GithubApp { get; set; }

        /// <summary>
        /// Output only. The URI to navigate to in order to manage the installation associated with this GitHubConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installationUri")]
        public virtual string InstallationUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for connections to an instance of GitHub Enterprise.</summary>
    public class GitHubEnterpriseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. ID of the GitHub App created from the manifest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public virtual System.Nullable<long> AppId { get; set; }

        /// <summary>Optional. ID of the installation of the GitHub App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appInstallationId")]
        public virtual System.Nullable<long> AppInstallationId { get; set; }

        /// <summary>Output only. The URL-friendly name of the GitHub App.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appSlug")]
        public virtual string AppSlug { get; set; }

        /// <summary>Required. The URI of the GitHub Enterprise host this connection is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>
        /// Output only. The URI to navigate to in order to manage the installation associated with this
        /// GitHubEnterpriseConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installationUri")]
        public virtual string InstallationUri { get; set; }

        /// <summary>
        /// Optional. SecretManager resource containing the private key of the GitHub App, formatted as
        /// `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeySecretVersion")]
        public virtual string PrivateKeySecretVersion { get; set; }

        /// <summary>Output only. GitHub Enterprise version installed at the host_uri.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverVersion")]
        public virtual string ServerVersion { get; set; }

        /// <summary>
        /// Optional. Configuration for using Service Directory to privately connect to a GitHub Enterprise server. This
        /// should only be set if the GitHub Enterprise server is hosted on-premises and not reachable by public
        /// internet. If this field is left empty, calls to the GitHub Enterprise server will be made over the public
        /// internet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>Optional. SSL certificate to use for requests to GitHub Enterprise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCaCertificate")]
        public virtual string SslCaCertificate { get; set; }

        /// <summary>
        /// Optional. SecretManager resource containing the webhook secret of the GitHub App, formatted as
        /// `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretSecretVersion")]
        public virtual string WebhookSecretSecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for connections to gitlab.com.</summary>
    public class GitLabConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A GitLab personal access token with the minimum `api` scope access and a minimum role of
        /// `maintainer`. The GitLab Projects visible to this Personal Access Token will control which Projects
        /// Developer Connect has access to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizerCredential")]
        public virtual UserCredential AuthorizerCredential { get; set; }

        /// <summary>
        /// Required. A GitLab personal access token with the minimum `read_api` scope access and a minimum role of
        /// `reporter`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer
        /// Connect has access to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAuthorizerCredential")]
        public virtual UserCredential ReadAuthorizerCredential { get; set; }

        /// <summary>
        /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project, formatted as
        /// `projects/*/secrets/*/versions/*`. This is used to validate webhooks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretSecretVersion")]
        public virtual string WebhookSecretSecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for connections to an instance of GitLab Enterprise.</summary>
    public class GitLabEnterpriseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A GitLab personal access token with the minimum `api` scope access and a minimum role of
        /// `maintainer`. The GitLab Projects visible to this Personal Access Token will control which Projects
        /// Developer Connect has access to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizerCredential")]
        public virtual UserCredential AuthorizerCredential { get; set; }

        /// <summary>Required. The URI of the GitLab Enterprise host this connection is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostUri")]
        public virtual string HostUri { get; set; }

        /// <summary>
        /// Required. A GitLab personal access token with the minimum `read_api` scope access and a minimum role of
        /// `reporter`. The GitLab Projects visible to this Personal Access Token will control which Projects Developer
        /// Connect has access to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAuthorizerCredential")]
        public virtual UserCredential ReadAuthorizerCredential { get; set; }

        /// <summary>Output only. Version of the GitLab Enterprise server running on the `host_uri`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverVersion")]
        public virtual string ServerVersion { get; set; }

        /// <summary>
        /// Optional. Configuration for using Service Directory to privately connect to a GitLab Enterprise instance.
        /// This should only be set if the GitLab Enterprise server is hosted on-premises and not reachable by public
        /// internet. If this field is left empty, calls to the GitLab Enterprise server will be made over the public
        /// internet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryConfig")]
        public virtual ServiceDirectoryConfig ServiceDirectoryConfig { get; set; }

        /// <summary>
        /// Optional. SSL Certificate Authority certificate to use for requests to GitLab Enterprise instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sslCaCertificate")]
        public virtual string SslCaCertificate { get; set; }

        /// <summary>
        /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project, formatted as
        /// `projects/*/secrets/*/versions/*`. This is used to validate webhooks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSecretSecretVersion")]
        public virtual string WebhookSecretSecretVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The git proxy configuration.</summary>
    public class GitProxyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Setting this to true allows the git proxy to be used for performing git operations on the
        /// repositories linked in the connection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message describing the GitRepositoryLink object</summary>
    public class GitRepositoryLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Allows clients to store small amounts of arbitrary data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Required. Git Clone URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloneUri")]
        public virtual string CloneUri { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. [Output only] Create timestamp</summary>
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>Output only. [Output only] Delete timestamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual string DeleteTimeRaw
        {
            get => _deleteTimeRaw;
            set
            {
                _deleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeleteTimeDateTimeOffset instead.")]
        public virtual object DeleteTime
        {
            get => _deleteTime;
            set
            {
                _deleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deleteTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeleteTimeRaw);
            set => DeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. This checksum is computed by the server based on the value of other fields, and may be sent on
        /// update and delete requests to ensure the client has an up-to-date value before proceeding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. URI to access the linked repository through the Git Proxy. This field is only populated if the
        /// git proxy is enabled for the connection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitProxyUri")]
        public virtual string GitProxyUri { get; set; }

        /// <summary>Optional. Labels as key value pairs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Identifier. Resource name of the repository, in the format
        /// `projects/*/locations/*/connections/*/gitRepositoryLinks/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Set to true when the connection is being set up or updated in the background.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reconciling")]
        public virtual System.Nullable<bool> Reconciling { get; set; }

        /// <summary>Output only. A system-assigned unique identifier for the GitRepositoryLink.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. [Output only] Update timestamp</summary>
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

        /// <summary>Output only. External ID of the webhook created for the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookId")]
        public virtual string WebhookId { get; set; }
    }

    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class HttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an installation of the GitHub App.</summary>
    public class Installation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the installation in GitHub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Name of the GitHub user or organization that owns this installation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Either "user" or "organization".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes stage and necessary actions to be taken by the user to complete the installation. Used for GitHub and
    /// GitHub Enterprise based connections.
    /// </summary>
    public class InstallationState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Link to follow for next action. Empty string if the installation is already complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionUri")]
        public virtual string ActionUri { get; set; }

        /// <summary>
        /// Output only. Message of what the user should do next to continue the installation. Empty string if the
        /// installation is already complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Output only. Current step of the installation process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage")]
        public virtual string Stage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>LinkableGitRepository represents a git repository that can be linked to a connection.</summary>
    public class LinkableGitRepository : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The clone uri of the repository.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloneUri")]
        public virtual string CloneUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing AccountConnectors</summary>
    public class ListAccountConnectorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of AccountConnectors</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountConnectors")]
        public virtual System.Collections.Generic.IList<AccountConnector> AccountConnectors { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing Connections</summary>
    public class ListConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Connection</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Connection> Connections { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for response to listing GitRepositoryLinks</summary>
    public class ListGitRepositoryLinksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of GitRepositoryLinks</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gitRepositoryLinks")]
        public virtual System.Collections.Generic.IList<GitRepositoryLink> GitRepositoryLinks { get; set; }

        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

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

    /// <summary>Message for response to listing Users</summary>
    public class ListUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A token identifying a page of results the server should return.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The list of Users</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<User> Users { get; set; }

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

    /// <summary>
    /// Represents an OAuth token of the account that authorized the Connection, and associated metadata.
    /// </summary>
    public class OAuthCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A SecretManager resource containing the OAuth token that authorizes the connection. Format:
        /// `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oauthTokenSecretVersion")]
        public virtual string OauthTokenSecretVersion { get; set; }

        /// <summary>Output only. The username associated with this token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

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

    /// <summary>Represents the metadata of the long-running operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. API version used to start the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the operation was created.</summary>
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

        /// <summary>Output only. The time the operation finished running.</summary>
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

        /// <summary>
        /// Output only. Identifies whether the user has requested cancellation of the operation. Operations that have
        /// been cancelled successfully have google.longrunning.Operation.error value with a google.rpc.Status.code of
        /// 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedCancellation")]
        public virtual System.Nullable<bool> RequestedCancellation { get; set; }

        /// <summary>Output only. Human-readable status of the operation, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; }

        /// <summary>Output only. Server-defined resource path for the target of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Output only. Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by the ProcessBitbucketCloudWebhook RPC method.</summary>
    public class ProcessBitbucketCloudWebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. HTTP request body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual HttpBody Body { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by the ProcessBitbucketDataCenterWebhook RPC method.</summary>
    public class ProcessBitbucketDataCenterWebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. HTTP request body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual HttpBody Body { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by the ProcessGitHubEnterpriseWebhook RPC method.</summary>
    public class ProcessGitHubEnterpriseWebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. HTTP request body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual HttpBody Body { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by the ProcessGitLabEnterpriseWebhook RPC method.</summary>
    public class ProcessGitLabEnterpriseWebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. HTTP request body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual HttpBody Body { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>RPC request object accepted by the ProcessGitLabWebhook RPC method.</summary>
    public class ProcessGitLabWebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. HTTP request body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual HttpBody Body { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ProviderOAuthConfig is the OAuth config for a provider.</summary>
    public class ProviderOAuthConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. User selected scopes to apply to the Oauth config In the event of changing scopes, user records
        /// under AccountConnector will be deleted and users will re-auth again.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>Immutable. Developer Connect provided OAuth.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemProviderId")]
        public virtual string SystemProviderId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ServiceDirectoryConfig represents Service Directory configuration for a connection.</summary>
    public class ServiceDirectoryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Service Directory service name. Format:
        /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

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

    /// <summary>User represents a user connected to the service providers through a AccountConnector.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp when the user was created.</summary>
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
        /// Output only. Developer Connect automatically converts user identity to some human readable description,
        /// e.g., email address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        private string _lastTokenRequestTimeRaw;

        private object _lastTokenRequestTime;

        /// <summary>Output only. The timestamp when the token was last requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTokenRequestTime")]
        public virtual string LastTokenRequestTimeRaw
        {
            get => _lastTokenRequestTimeRaw;
            set
            {
                _lastTokenRequestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastTokenRequestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastTokenRequestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastTokenRequestTimeDateTimeOffset instead.")]
        public virtual object LastTokenRequestTime
        {
            get => _lastTokenRequestTime;
            set
            {
                _lastTokenRequestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastTokenRequestTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastTokenRequestTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastTokenRequestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastTokenRequestTimeRaw);
            set => LastTokenRequestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Identifier. Resource name of the user, in the format `projects/*/locations/*/accountConnectors/*/users/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a personal access token that authorized the Connection, and associated metadata.</summary>
    public class UserCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A SecretManager resource containing the user token that authorizes the Developer Connect
        /// connection. Format: `projects/*/secrets/*/versions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userTokenSecretVersion")]
        public virtual string UserTokenSecretVersion { get; set; }

        /// <summary>Output only. The username associated with this token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
