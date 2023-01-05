// Copyright 2023 Google LLC
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

namespace Google.Apis.ApiKeysService.v2
{
    /// <summary>The ApiKeysService Service.</summary>
    public class ApiKeysServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ApiKeysServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ApiKeysServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Keys = new KeysResource(this);
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "apikeys";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://apikeys.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://apikeys.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the API Keys API.</summary>
        public class Scope
        {
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

        /// <summary>Available OAuth 2.0 scope constants for use with the API Keys API.</summary>
        public static class ScopeConstants
        {
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

        /// <summary>Gets the Keys resource.</summary>
        public virtual KeysResource Keys { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for ApiKeysService requests.</summary>
    public abstract class ApiKeysServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ApiKeysServiceBaseServiceRequest instance.</summary>
        protected ApiKeysServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ApiKeysService parameter list.</summary>
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

    /// <summary>The "keys" collection of methods.</summary>
    public class KeysResource
    {
        private const string Resource = "keys";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public KeysResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Find the parent project and resource name of the API key that matches the key string in the request. If the
        /// API key has been purged, resource name will not be set. The service account must have the
        /// `apikeys.keys.lookup` permission on the parent project.
        /// </summary>
        public virtual LookupKeyRequest LookupKey()
        {
            return new LookupKeyRequest(service);
        }

        /// <summary>
        /// Find the parent project and resource name of the API key that matches the key string in the request. If the
        /// API key has been purged, resource name will not be set. The service account must have the
        /// `apikeys.keys.lookup` permission on the parent project.
        /// </summary>
        public class LookupKeyRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.V2LookupKeyResponse>
        {
            /// <summary>Constructs a new LookupKey request.</summary>
            public LookupKeyRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. Finds the project that owns the key string value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("keyString", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string KeyString { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lookupKey";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/keys:lookupKey";

            /// <summary>Initializes LookupKey parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("keyString", new Google.Apis.Discovery.Parameter
                {
                    Name = "keyString",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.Operation>
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
            public override string RestPath => "v2/{+name}";

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
                    Pattern = @"^operations/[^/]+$",
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
                Keys = new KeysResource(service);
            }

            /// <summary>Gets the Keys resource.</summary>
            public virtual KeysResource Keys { get; }

            /// <summary>The "keys" collection of methods.</summary>
            public class KeysResource
            {
                private const string Resource = "keys";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public KeysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new API key. NOTE: Key is a global resource; hence the only supported value for location
                /// is `global`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The project in which the API key is created.</param>
                public virtual CreateRequest Create(Google.Apis.ApiKeysService.v2.Data.V2Key body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new API key. NOTE: Key is a global resource; hence the only supported value for location
                /// is `global`.
                /// </summary>
                public class CreateRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.ApiKeysService.v2.Data.V2Key body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The project in which the API key is created.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// User specified key id (optional). If specified, it will become the final component of the key
                    /// resource name. The id must be unique within the project, must conform with RFC-1034, is
                    /// restricted to lower-cased letters, and has a maximum length of 63 characters. In another word,
                    /// the id must match the regular expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`. The id must NOT be
                    /// a UUID-like string.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("keyId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string KeyId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApiKeysService.v2.Data.V2Key Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/keys";

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
                        RequestParameters.Add("keyId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "keyId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes an API key. Deleted key can be retrieved within 30 days of deletion. Afterward, key will be
                /// purged from the project. NOTE: Key is a global resource; hence the only supported value for location
                /// is `global`.
                /// </summary>
                /// <param name="name">Required. The resource name of the API key to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an API key. Deleted key can be retrieved within 30 days of deletion. Afterward, key will be
                /// purged from the project. NOTE: Key is a global resource; hence the only supported value for location
                /// is `global`.
                /// </summary>
                public class DeleteRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the API key to be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The etag known to the client for the expected state of the key. This is to be used for
                    /// optimistic concurrency.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("etag", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Etag { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keys/[^/]+$",
                        });
                        RequestParameters.Add("etag", new Google.Apis.Discovery.Parameter
                        {
                            Name = "etag",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the metadata for an API key. The key string of the API key isn't included in the response.
                /// NOTE: Key is a global resource; hence the only supported value for location is `global`.
                /// </summary>
                /// <param name="name">Required. The resource name of the API key to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the metadata for an API key. The key string of the API key isn't included in the response.
                /// NOTE: Key is a global resource; hence the only supported value for location is `global`.
                /// </summary>
                public class GetRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.V2Key>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the API key to get.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keys/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Get the key string for an API key. NOTE: Key is a global resource; hence the only supported value
                /// for location is `global`.
                /// </summary>
                /// <param name="name">Required. The resource name of the API key to be retrieved.</param>
                public virtual GetKeyStringRequest GetKeyString(string name)
                {
                    return new GetKeyStringRequest(service, name);
                }

                /// <summary>
                /// Get the key string for an API key. NOTE: Key is a global resource; hence the only supported value
                /// for location is `global`.
                /// </summary>
                public class GetKeyStringRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.V2GetKeyStringResponse>
                {
                    /// <summary>Constructs a new GetKeyString request.</summary>
                    public GetKeyStringRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the API key to be retrieved.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getKeyString";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}/keyString";

                    /// <summary>Initializes GetKeyString parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keys/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the API keys owned by a project. The key string of the API key isn't included in the response.
                /// NOTE: Key is a global resource; hence the only supported value for location is `global`.
                /// </summary>
                /// <param name="parent">Required. Lists all API keys associated with this project.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists the API keys owned by a project. The key string of the API key isn't included in the response.
                /// NOTE: Key is a global resource; hence the only supported value for location is `global`.
                /// </summary>
                public class ListRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.V2ListKeysResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. Lists all API keys associated with this project.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. Specifies the maximum number of results to be returned at a time.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. Requests a specific page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. Indicate that keys deleted in the past 30 days should also be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> ShowDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/keys";

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
                        RequestParameters.Add("showDeleted", new Google.Apis.Discovery.Parameter
                        {
                            Name = "showDeleted",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Patches the modifiable fields of an API key. The key string of the API key isn't included in the
                /// response. NOTE: Key is a global resource; hence the only supported value for location is `global`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name of the key. The `name` has the form:
                /// `projects//locations/global/keys/`. For example:
                /// `projects/123456867718/locations/global/keys/b7ff1f9f-8275-410a-94dd-3855ee9b5dd2` NOTE: Key is a
                /// global resource; hence the only supported value for location is `global`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.ApiKeysService.v2.Data.V2Key body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Patches the modifiable fields of an API key. The key string of the API key isn't included in the
                /// response. NOTE: Key is a global resource; hence the only supported value for location is `global`.
                /// </summary>
                public class PatchRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.ApiKeysService.v2.Data.V2Key body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name of the key. The `name` has the form:
                    /// `projects//locations/global/keys/`. For example:
                    /// `projects/123456867718/locations/global/keys/b7ff1f9f-8275-410a-94dd-3855ee9b5dd2` NOTE: Key is
                    /// a global resource; hence the only supported value for location is `global`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The field mask specifies which fields to be updated as part of this request. All other fields
                    /// are ignored. Mutable fields are: `display_name`, `restrictions`, and `annotations`. If an update
                    /// mask is not provided, the service treats it as an implied mask equivalent to all allowed fields
                    /// that are set on the wire. If the field mask has a special value "*", the service treats it
                    /// equivalent to replace all allowed mutable fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApiKeysService.v2.Data.V2Key Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keys/[^/]+$",
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
                /// Undeletes an API key which was deleted within 30 days. NOTE: Key is a global resource; hence the
                /// only supported value for location is `global`.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The resource name of the API key to be undeleted.</param>
                public virtual UndeleteRequest Undelete(Google.Apis.ApiKeysService.v2.Data.V2UndeleteKeyRequest body, string name)
                {
                    return new UndeleteRequest(service, body, name);
                }

                /// <summary>
                /// Undeletes an API key which was deleted within 30 days. NOTE: Key is a global resource; hence the
                /// only supported value for location is `global`.
                /// </summary>
                public class UndeleteRequest : ApiKeysServiceBaseServiceRequest<Google.Apis.ApiKeysService.v2.Data.Operation>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.ApiKeysService.v2.Data.V2UndeleteKeyRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The resource name of the API key to be undeleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.ApiKeysService.v2.Data.V2UndeleteKeyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:undelete";

                    /// <summary>Initializes Undelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keys/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.ApiKeysService.v2.Data
{
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

    /// <summary>Identifier of an Android application for key use.</summary>
    public class V2AndroidApplication : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The package name of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// The SHA1 fingerprint of the application. For example, both sha1 formats are acceptable :
        /// DA:39:A3:EE:5E:6B:4B:0D:32:55:BF:EF:95:60:18:90:AF:D8:07:09 or DA39A3EE5E6B4B0D3255BFEF95601890AFD80709.
        /// Output format is the latter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Fingerprint")]
        public virtual string Sha1Fingerprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Android apps that are allowed to use the key.</summary>
    public class V2AndroidKeyRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Android applications that are allowed to make API calls with this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedApplications")]
        public virtual System.Collections.Generic.IList<V2AndroidApplication> AllowedApplications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A restriction for a specific service and optionally one or multiple specific methods. Both fields are case
    /// insensitive.
    /// </summary>
    public class V2ApiTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of one or more methods that can be called. If empty, all methods for the service are allowed.
        /// A wildcard (*) can be used as the last symbol. Valid examples:
        /// `google.cloud.translate.v2.TranslateService.GetSupportedLanguage` `TranslateText` `Get*`
        /// `translate.googleapis.com.Get*`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methods")]
        public virtual System.Collections.Generic.IList<string> Methods { get; set; }

        /// <summary>
        /// The service for this restriction. It should be the canonical service name, for example:
        /// `translate.googleapis.com`. You can use [`gcloud services list`](/sdk/gcloud/reference/services/list) to get
        /// a list of services that are enabled in the project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The HTTP referrers (websites) that are allowed to use the key.</summary>
    public class V2BrowserKeyRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of regular expressions for the referrer URLs that are allowed to make API calls with this key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedReferrers")]
        public virtual System.Collections.Generic.IList<string> AllowedReferrers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `GetKeyString` method.</summary>
    public class V2GetKeyStringResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An encrypted and signed value of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyString")]
        public virtual string KeyString { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The iOS apps that are allowed to use the key.</summary>
    public class V2IosKeyRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of bundle IDs that are allowed when making API calls with this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedBundleIds")]
        public virtual System.Collections.Generic.IList<string> AllowedBundleIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The representation of a key managed by the API Keys API.</summary>
    public class V2Key : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations is an unstructured key-value map stored with a policy that may be set by external tools to store
        /// and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>Output only. A timestamp identifying the time this key was originally created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. A timestamp when this key was deleted. If the resource is not deleted, this must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>
        /// Human-readable display name of this key that you can modify. The maximum length is 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. A checksum computed by the server based on the current value of the Key resource. This may be
        /// sent on update and delete requests to ensure the client has an up-to-date value before proceeding. See
        /// https://google.aip.dev/154.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. An encrypted and signed value held by this key. This field can be accessed only through the
        /// `GetKeyString` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyString")]
        public virtual string KeyString { get; set; }

        /// <summary>
        /// Output only. The resource name of the key. The `name` has the form: `projects//locations/global/keys/`. For
        /// example: `projects/123456867718/locations/global/keys/b7ff1f9f-8275-410a-94dd-3855ee9b5dd2` NOTE: Key is a
        /// global resource; hence the only supported value for location is `global`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Key restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictions")]
        public virtual V2Restrictions Restrictions { get; set; }

        /// <summary>Output only. Unique id in UUID4 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Output only. A timestamp identifying the time this key was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>Response message for `ListKeys` method.</summary>
    public class V2ListKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of API keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<V2Key> Keys { get; set; }

        /// <summary>The pagination token for the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `LookupKey` method.</summary>
    public class V2LookupKeyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the API key. If the API key has been purged, resource name is empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The project that owns the key with the value specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes the restrictions on the key.</summary>
    public class V2Restrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Android apps that are allowed to use the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidKeyRestrictions")]
        public virtual V2AndroidKeyRestrictions AndroidKeyRestrictions { get; set; }

        /// <summary>
        /// A restriction for a specific service and optionally one or more specific methods. Requests are allowed if
        /// they match any of these restrictions. If no restrictions are specified, all targets are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiTargets")]
        public virtual System.Collections.Generic.IList<V2ApiTarget> ApiTargets { get; set; }

        /// <summary>The HTTP referrers (websites) that are allowed to use the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browserKeyRestrictions")]
        public virtual V2BrowserKeyRestrictions BrowserKeyRestrictions { get; set; }

        /// <summary>The iOS apps that are allowed to use the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosKeyRestrictions")]
        public virtual V2IosKeyRestrictions IosKeyRestrictions { get; set; }

        /// <summary>The IP addresses of callers that are allowed to use the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverKeyRestrictions")]
        public virtual V2ServerKeyRestrictions ServerKeyRestrictions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The IP addresses of callers that are allowed to use the key.</summary>
    public class V2ServerKeyRestrictions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of the caller IP addresses that are allowed to make API calls with this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedIps")]
        public virtual System.Collections.Generic.IList<string> AllowedIps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `UndeleteKey` method.</summary>
    public class V2UndeleteKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
