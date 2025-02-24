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

namespace Google.Apis.AccessContextManager.v1
{
    /// <summary>The AccessContextManager Service.</summary>
    public class AccessContextManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AccessContextManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AccessContextManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AccessPolicies = new AccessPoliciesResource(this);
            Operations = new OperationsResource(this);
            Organizations = new OrganizationsResource(this);
            Services = new ServicesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://accesscontextmanager.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://accesscontextmanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "accesscontextmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Access Context Manager API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Access Context Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the AccessPolicies resource.</summary>
        public virtual AccessPoliciesResource AccessPolicies { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }
    }

    /// <summary>A base abstract class for AccessContextManager requests.</summary>
    public abstract class AccessContextManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AccessContextManagerBaseServiceRequest instance.</summary>
        protected AccessContextManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AccessContextManager parameter list.</summary>
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

    /// <summary>The "accessPolicies" collection of methods.</summary>
    public class AccessPoliciesResource
    {
        private const string Resource = "accessPolicies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccessPoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AccessLevels = new AccessLevelsResource(service);
            AuthorizedOrgsDescs = new AuthorizedOrgsDescsResource(service);
            ServicePerimeters = new ServicePerimetersResource(service);
        }

        /// <summary>Gets the AccessLevels resource.</summary>
        public virtual AccessLevelsResource AccessLevels { get; }

        /// <summary>The "accessLevels" collection of methods.</summary>
        public class AccessLevelsResource
        {
            private const string Resource = "accessLevels";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccessLevelsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an access level. The long-running operation from this RPC has a successful status after the
            /// access level propagates to long-lasting storage. If access levels contain errors, an error response is
            /// returned for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns this Access Level. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates an access level. The long-running operation from this RPC has a successful status after the
            /// access level propagates to long-lasting storage. If access levels contain errors, an error response is
            /// returned for the first error encountered.
            /// </summary>
            public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns this Access Level. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.AccessLevel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/accessLevels";

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
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an access level based on the resource name. The long-running operation from this RPC has a
            /// successful status after the access level has been removed from long-lasting storage.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name for the Access Level. Format:
            /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes an access level based on the resource name. The long-running operation from this RPC has a
            /// successful status after the access level has been removed from long-lasting storage.
            /// </summary>
            public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Access Level. Format:
                /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
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
                        Pattern = @"^accessPolicies/[^/]+/accessLevels/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an access level based on the resource name.</summary>
            /// <param name="name">
            /// Required. Resource name for the Access Level. Format:
            /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets an access level based on the resource name.</summary>
            public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.AccessLevel>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Access Level. Format:
                /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression Language rather than as
                /// `BasicLevels`. Defaults to AS_DEFINED, where Access Levels are returned as `BasicLevels` or
                /// `CustomLevels` based on how they were created. If set to CEL, all Access Levels are returned as
                /// `CustomLevels`. In the CEL case, `BasicLevels` are translated to equivalent `CustomLevels`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accessLevelFormat", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AccessLevelFormatEnum> AccessLevelFormat { get; set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression Language rather than as
                /// `BasicLevels`. Defaults to AS_DEFINED, where Access Levels are returned as `BasicLevels` or
                /// `CustomLevels` based on how they were created. If set to CEL, all Access Levels are returned as
                /// `CustomLevels`. In the CEL case, `BasicLevels` are translated to equivalent `CustomLevels`.
                /// </summary>
                public enum AccessLevelFormatEnum
                {
                    /// <summary>The format was not specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("LEVEL_FORMAT_UNSPECIFIED")]
                    LEVELFORMATUNSPECIFIED = 0,

                    /// <summary>
                    /// Uses the format the resource was defined in. BasicLevels are returned as BasicLevels,
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AS_DEFINED")]
                    ASDEFINED = 1,

                    /// <summary>
                    /// Use Cloud Common Expression Language when returning the resource. Both BasicLevels and
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CEL")]
                    CEL = 2,
                }

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
                        Pattern = @"^accessPolicies/[^/]+/accessLevels/[^/]+$",
                    });
                    RequestParameters.Add("accessLevelFormat", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accessLevelFormat",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all access levels for an access policy.</summary>
            /// <param name="parent">
            /// Required. Resource name for the access policy to list Access Levels from. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all access levels for an access policy.</summary>
            public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListAccessLevelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy to list Access Levels from. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression language, as `CustomLevels`, rather
                /// than as `BasicLevels`. Defaults to returning `AccessLevels` in the format they were defined.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accessLevelFormat", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AccessLevelFormatEnum> AccessLevelFormat { get; set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression language, as `CustomLevels`, rather
                /// than as `BasicLevels`. Defaults to returning `AccessLevels` in the format they were defined.
                /// </summary>
                public enum AccessLevelFormatEnum
                {
                    /// <summary>The format was not specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("LEVEL_FORMAT_UNSPECIFIED")]
                    LEVELFORMATUNSPECIFIED = 0,

                    /// <summary>
                    /// Uses the format the resource was defined in. BasicLevels are returned as BasicLevels,
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AS_DEFINED")]
                    ASDEFINED = 1,

                    /// <summary>
                    /// Use Cloud Common Expression Language when returning the resource. Both BasicLevels and
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CEL")]
                    CEL = 2,
                }

                /// <summary>Number of Access Levels to include in the list. Default 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Next page token for the next batch of Access Level instances. Defaults to the first page of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/accessLevels";

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
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                    RequestParameters.Add("accessLevelFormat", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accessLevelFormat",
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
            /// Updates an access level. The long-running operation from this RPC has a successful status after the
            /// changes to the access level propagate to long-lasting storage. If access levels contain errors, an error
            /// response is returned for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. Resource name for the `AccessLevel`. Format:
            /// `accessPolicies/{access_policy}/accessLevels/{access_level}`. The `access_level` component must begin
            /// with a letter, followed by alphanumeric characters or `_`. Its maximum length is 50 characters. After
            /// you create an `AccessLevel`, you cannot change its `name`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an access level. The long-running operation from this RPC has a successful status after the
            /// changes to the access level propagate to long-lasting storage. If access levels contain errors, an error
            /// response is returned for the first error encountered.
            /// </summary>
            public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. Resource name for the `AccessLevel`. Format:
                /// `accessPolicies/{access_policy}/accessLevels/{access_level}`. The `access_level` component must
                /// begin with a letter, followed by alphanumeric characters or `_`. Its maximum length is 50
                /// characters. After you create an `AccessLevel`, you cannot change its `name`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. Mask to control which fields get updated. Must be non-empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.AccessLevel Body { get; set; }

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
                        Pattern = @"^accessPolicies/[^/]+/accessLevels/[^/]+$",
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
            /// Replaces all existing access levels in an access policy with the access levels provided. This is done
            /// atomically. The long-running operation from this RPC has a successful status after all replacements
            /// propagate to long-lasting storage. If the replacement contains errors, an error response is returned for
            /// the first error encountered. Upon error, the replacement is cancelled, and existing access levels are
            /// not affected. The Operation.response field contains ReplaceAccessLevelsResponse. Removing access levels
            /// contained in existing service perimeters result in an error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns these Access Levels. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ReplaceAllRequest ReplaceAll(Google.Apis.AccessContextManager.v1.Data.ReplaceAccessLevelsRequest body, string parent)
            {
                return new ReplaceAllRequest(this.service, body, parent);
            }

            /// <summary>
            /// Replaces all existing access levels in an access policy with the access levels provided. This is done
            /// atomically. The long-running operation from this RPC has a successful status after all replacements
            /// propagate to long-lasting storage. If the replacement contains errors, an error response is returned for
            /// the first error encountered. Upon error, the replacement is cancelled, and existing access levels are
            /// not affected. The Operation.response field contains ReplaceAccessLevelsResponse. Removing access levels
            /// contained in existing service perimeters result in an error.
            /// </summary>
            public class ReplaceAllRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new ReplaceAll request.</summary>
                public ReplaceAllRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ReplaceAccessLevelsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns these Access Levels. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ReplaceAccessLevelsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "replaceAll";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/accessLevels:replaceAll";

                /// <summary>Initializes ReplaceAll parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the IAM permissions that the caller has on the specified Access Context Manager resource. The
            /// resource can be an AccessPolicy, AccessLevel, or ServicePerimeter. This method does not support other
            /// resources.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns the IAM permissions that the caller has on the specified Access Context Manager resource. The
            /// resource can be an AccessPolicy, AccessLevel, or ServicePerimeter. This method does not support other
            /// resources.
            /// </summary>
            public class TestIamPermissionsRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^accessPolicies/[^/]+/accessLevels/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the AuthorizedOrgsDescs resource.</summary>
        public virtual AuthorizedOrgsDescsResource AuthorizedOrgsDescs { get; }

        /// <summary>The "authorizedOrgsDescs" collection of methods.</summary>
        public class AuthorizedOrgsDescsResource
        {
            private const string Resource = "authorizedOrgsDescs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AuthorizedOrgsDescsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an authorized orgs desc. The long-running operation from this RPC has a successful status after
            /// the authorized orgs desc propagates to long-lasting storage. If a authorized orgs desc contains errors,
            /// an error response is returned for the first error encountered. The name of this `AuthorizedOrgsDesc`
            /// will be assigned during creation.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns this Authorized Orgs Desc. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.AuthorizedOrgsDesc body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates an authorized orgs desc. The long-running operation from this RPC has a successful status after
            /// the authorized orgs desc propagates to long-lasting storage. If a authorized orgs desc contains errors,
            /// an error response is returned for the first error encountered. The name of this `AuthorizedOrgsDesc`
            /// will be assigned during creation.
            /// </summary>
            public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AuthorizedOrgsDesc body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns this Authorized Orgs Desc. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.AuthorizedOrgsDesc Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/authorizedOrgsDescs";

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
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an authorized orgs desc based on the resource name. The long-running operation from this RPC has
            /// a successful status after the authorized orgs desc is removed from long-lasting storage.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name for the Authorized Orgs Desc. Format:
            /// `accessPolicies/{policy_id}/authorizedOrgsDesc/{authorized_orgs_desc_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes an authorized orgs desc based on the resource name. The long-running operation from this RPC has
            /// a successful status after the authorized orgs desc is removed from long-lasting storage.
            /// </summary>
            public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Authorized Orgs Desc. Format:
                /// `accessPolicies/{policy_id}/authorizedOrgsDesc/{authorized_orgs_desc_id}`
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
                        Pattern = @"^accessPolicies/[^/]+/authorizedOrgsDescs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an authorized orgs desc based on the resource name.</summary>
            /// <param name="name">
            /// Required. Resource name for the Authorized Orgs Desc. Format:
            /// `accessPolicies/{policy_id}/authorizedOrgsDescs/{authorized_orgs_descs_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets an authorized orgs desc based on the resource name.</summary>
            public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.AuthorizedOrgsDesc>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Authorized Orgs Desc. Format:
                /// `accessPolicies/{policy_id}/authorizedOrgsDescs/{authorized_orgs_descs_id}`
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
                        Pattern = @"^accessPolicies/[^/]+/authorizedOrgsDescs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all authorized orgs descs for an access policy.</summary>
            /// <param name="parent">
            /// Required. Resource name for the access policy to list Authorized Orgs Desc from. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all authorized orgs descs for an access policy.</summary>
            public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListAuthorizedOrgsDescsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy to list Authorized Orgs Desc from. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Number of Authorized Orgs Descs to include in the list. Default 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Next page token for the next batch of Authorized Orgs Desc instances. Defaults to the first page of
                /// results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/authorizedOrgsDescs";

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
                        Pattern = @"^accessPolicies/[^/]+$",
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
            /// Updates an authorized orgs desc. The long-running operation from this RPC has a successful status after
            /// the authorized orgs desc propagates to long-lasting storage. If a authorized orgs desc contains errors,
            /// an error response is returned for the first error encountered. Only the organization list in
            /// `AuthorizedOrgsDesc` can be updated. The name, authorization_type, asset_type and
            /// authorization_direction cannot be updated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. Resource name for the `AuthorizedOrgsDesc`. Format:
            /// `accessPolicies/{access_policy}/authorizedOrgsDescs/{authorized_orgs_desc}`. The `authorized_orgs_desc`
            /// component must begin with a letter, followed by alphanumeric characters or `_`. After you create an
            /// `AuthorizedOrgsDesc`, you cannot change its `name`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.AuthorizedOrgsDesc body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates an authorized orgs desc. The long-running operation from this RPC has a successful status after
            /// the authorized orgs desc propagates to long-lasting storage. If a authorized orgs desc contains errors,
            /// an error response is returned for the first error encountered. Only the organization list in
            /// `AuthorizedOrgsDesc` can be updated. The name, authorization_type, asset_type and
            /// authorization_direction cannot be updated.
            /// </summary>
            public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AuthorizedOrgsDesc body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. Resource name for the `AuthorizedOrgsDesc`. Format:
                /// `accessPolicies/{access_policy}/authorizedOrgsDescs/{authorized_orgs_desc}`. The
                /// `authorized_orgs_desc` component must begin with a letter, followed by alphanumeric characters or
                /// `_`. After you create an `AuthorizedOrgsDesc`, you cannot change its `name`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. Mask to control which fields get updated. Must be non-empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.AuthorizedOrgsDesc Body { get; set; }

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
                        Pattern = @"^accessPolicies/[^/]+/authorizedOrgsDescs/[^/]+$",
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

        /// <summary>Gets the ServicePerimeters resource.</summary>
        public virtual ServicePerimetersResource ServicePerimeters { get; }

        /// <summary>The "servicePerimeters" collection of methods.</summary>
        public class ServicePerimetersResource
        {
            private const string Resource = "servicePerimeters";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServicePerimetersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Commits the dry-run specification for all the service perimeters in an access policy. A commit operation
            /// on a service perimeter involves copying its `spec` field to the `status` field of the service perimeter.
            /// Only service perimeters with `use_explicit_dry_run_spec` field set to true are affected by a commit
            /// operation. The long-running operation from this RPC has a successful status after the dry-run
            /// specifications for all the service perimeters have been committed. If a commit fails, it causes the
            /// long-running operation to return an error response and the entire commit operation is cancelled. When
            /// successful, the Operation.response field contains CommitServicePerimetersResponse. The `dry_run` and the
            /// `spec` fields are cleared after a successful commit operation.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the parent Access Policy which owns all Service Perimeters in scope for the
            /// commit operation. Format: `accessPolicies/{policy_id}`
            /// </param>
            public virtual CommitRequest Commit(Google.Apis.AccessContextManager.v1.Data.CommitServicePerimetersRequest body, string parent)
            {
                return new CommitRequest(this.service, body, parent);
            }

            /// <summary>
            /// Commits the dry-run specification for all the service perimeters in an access policy. A commit operation
            /// on a service perimeter involves copying its `spec` field to the `status` field of the service perimeter.
            /// Only service perimeters with `use_explicit_dry_run_spec` field set to true are affected by a commit
            /// operation. The long-running operation from this RPC has a successful status after the dry-run
            /// specifications for all the service perimeters have been committed. If a commit fails, it causes the
            /// long-running operation to return an error response and the entire commit operation is cancelled. When
            /// successful, the Operation.response field contains CommitServicePerimetersResponse. The `dry_run` and the
            /// `spec` fields are cleared after a successful commit operation.
            /// </summary>
            public class CommitRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Commit request.</summary>
                public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.CommitServicePerimetersRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the parent Access Policy which owns all Service Perimeters in scope for
                /// the commit operation. Format: `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.CommitServicePerimetersRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "commit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters:commit";

                /// <summary>Initializes Commit parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a service perimeter. The long-running operation from this RPC has a successful status after the
            /// service perimeter propagates to long-lasting storage. If a service perimeter contains errors, an error
            /// response is returned for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns this Service Perimeter. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a service perimeter. The long-running operation from this RPC has a successful status after the
            /// service perimeter propagates to long-lasting storage. If a service perimeter contains errors, an error
            /// response is returned for the first error encountered.
            /// </summary>
            public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns this Service Perimeter. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ServicePerimeter Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters";

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
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a service perimeter based on the resource name. The long-running operation from this RPC has a
            /// successful status after the service perimeter is removed from long-lasting storage.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name for the Service Perimeter. Format:
            /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a service perimeter based on the resource name. The long-running operation from this RPC has a
            /// successful status after the service perimeter is removed from long-lasting storage.
            /// </summary>
            public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Service Perimeter. Format:
                /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
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
                        Pattern = @"^accessPolicies/[^/]+/servicePerimeters/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a service perimeter based on the resource name.</summary>
            /// <param name="name">
            /// Required. Resource name for the Service Perimeter. Format:
            /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a service perimeter based on the resource name.</summary>
            public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ServicePerimeter>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Service Perimeter. Format:
                /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
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
                        Pattern = @"^accessPolicies/[^/]+/servicePerimeters/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all service perimeters for an access policy.</summary>
            /// <param name="parent">
            /// Required. Resource name for the access policy to list Service Perimeters from. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all service perimeters for an access policy.</summary>
            public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListServicePerimetersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy to list Service Perimeters from. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Number of Service Perimeters to include in the list. Default 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Next page token for the next batch of Service Perimeter instances. Defaults to the first page of
                /// results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters";

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
                        Pattern = @"^accessPolicies/[^/]+$",
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
            /// Updates a service perimeter. The long-running operation from this RPC has a successful status after the
            /// service perimeter propagates to long-lasting storage. If a service perimeter contains errors, an error
            /// response is returned for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. Resource name for the `ServicePerimeter`. Format:
            /// `accessPolicies/{access_policy}/servicePerimeters/{service_perimeter}`. The `service_perimeter`
            /// component must begin with a letter, followed by alphanumeric characters or `_`. After you create a
            /// `ServicePerimeter`, you cannot change its `name`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a service perimeter. The long-running operation from this RPC has a successful status after the
            /// service perimeter propagates to long-lasting storage. If a service perimeter contains errors, an error
            /// response is returned for the first error encountered.
            /// </summary>
            public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. Resource name for the `ServicePerimeter`. Format:
                /// `accessPolicies/{access_policy}/servicePerimeters/{service_perimeter}`. The `service_perimeter`
                /// component must begin with a letter, followed by alphanumeric characters or `_`. After you create a
                /// `ServicePerimeter`, you cannot change its `name`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. Mask to control which fields get updated. Must be non-empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ServicePerimeter Body { get; set; }

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
                        Pattern = @"^accessPolicies/[^/]+/servicePerimeters/[^/]+$",
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
            /// Replace all existing service perimeters in an access policy with the service perimeters provided. This
            /// is done atomically. The long-running operation from this RPC has a successful status after all
            /// replacements propagate to long-lasting storage. Replacements containing errors result in an error
            /// response for the first error encountered. Upon an error, replacement are cancelled and existing service
            /// perimeters are not affected. The Operation.response field contains ReplaceServicePerimetersResponse.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns these Service Perimeters. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ReplaceAllRequest ReplaceAll(Google.Apis.AccessContextManager.v1.Data.ReplaceServicePerimetersRequest body, string parent)
            {
                return new ReplaceAllRequest(this.service, body, parent);
            }

            /// <summary>
            /// Replace all existing service perimeters in an access policy with the service perimeters provided. This
            /// is done atomically. The long-running operation from this RPC has a successful status after all
            /// replacements propagate to long-lasting storage. Replacements containing errors result in an error
            /// response for the first error encountered. Upon an error, replacement are cancelled and existing service
            /// perimeters are not affected. The Operation.response field contains ReplaceServicePerimetersResponse.
            /// </summary>
            public class ReplaceAllRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new ReplaceAll request.</summary>
                public ReplaceAllRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ReplaceServicePerimetersRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns these Service Perimeters. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ReplaceServicePerimetersRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "replaceAll";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters:replaceAll";

                /// <summary>Initializes ReplaceAll parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns the IAM permissions that the caller has on the specified Access Context Manager resource. The
            /// resource can be an AccessPolicy, AccessLevel, or ServicePerimeter. This method does not support other
            /// resources.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns the IAM permissions that the caller has on the specified Access Context Manager resource. The
            /// resource can be an AccessPolicy, AccessLevel, or ServicePerimeter. This method does not support other
            /// resources.
            /// </summary>
            public class TestIamPermissionsRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                        Pattern = @"^accessPolicies/[^/]+/servicePerimeters/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Creates an access policy. This method fails if the organization already has an access policy. The
        /// long-running operation has a successful status after the access policy propagates to long-lasting storage.
        /// Syntactic and basic semantic errors are returned in `metadata` as a BadRequest proto.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.AccessPolicy body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates an access policy. This method fails if the organization already has an access policy. The
        /// long-running operation has a successful status after the access policy propagates to long-lasting storage.
        /// Syntactic and basic semantic errors are returned in `metadata` as a BadRequest proto.
        /// </summary>
        public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessPolicy body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.AccessPolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accessPolicies";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes an access policy based on the resource name. The long-running operation has a successful status
        /// after the access policy is removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete. Format `accessPolicies/{policy_id}`
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes an access policy based on the resource name. The long-running operation has a successful status
        /// after the access policy is removed from long-lasting storage.
        /// </summary>
        public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name for the access policy to delete. Format `accessPolicies/{policy_id}`
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
                    Pattern = @"^accessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>Returns an access policy based on the name.</summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get. Format `accessPolicies/{policy_id}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Returns an access policy based on the name.</summary>
        public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.AccessPolicy>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name for the access policy to get. Format `accessPolicies/{policy_id}`
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
                    Pattern = @"^accessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>Gets the IAM policy for the specified Access Context Manager access policy.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.AccessContextManager.v1.Data.GetIamPolicyRequest body, string resource)
        {
            return new GetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>Gets the IAM policy for the specified Access Context Manager access policy.</summary>
        public class GetIamPolicyRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.GetIamPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

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
                    Pattern = @"^accessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>Lists all access policies in an organization.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists all access policies in an organization.</summary>
        public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListAccessPoliciesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Number of AccessPolicy instances to include in the list. Default 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Next page token for the next batch of AccessPolicy instances. Defaults to the first page of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. Resource name for the container to list AccessPolicy instances from. Format:
            /// `organizations/{org_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accessPolicies";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates an access policy. The long-running operation from this RPC has a successful status after the changes
        /// to the access policy propagate to long-lasting storage.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Identifier. Resource name of the `AccessPolicy`. Format: `accessPolicies/{access_policy}`
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.AccessPolicy body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates an access policy. The long-running operation from this RPC has a successful status after the changes
        /// to the access policy propagate to long-lasting storage.
        /// </summary>
        public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessPolicy body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. Identifier. Resource name of the `AccessPolicy`. Format: `accessPolicies/{access_policy}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. Mask to control which fields get updated. Must be non-empty.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.AccessPolicy Body { get; set; }

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
                    Pattern = @"^accessPolicies/[^/]+$",
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
        /// Sets the IAM policy for the specified Access Context Manager access policy. This method replaces the
        /// existing IAM policy on the access policy. The IAM policy controls the set of users who can perform specific
        /// operations on the Access Context Manager access policy.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.AccessContextManager.v1.Data.SetIamPolicyRequest body, string resource)
        {
            return new SetIamPolicyRequest(this.service, body, resource);
        }

        /// <summary>
        /// Sets the IAM policy for the specified Access Context Manager access policy. This method replaces the
        /// existing IAM policy on the access policy. The IAM policy controls the set of users who can perform specific
        /// operations on the Access Context Manager access policy.
        /// </summary>
        public class SetIamPolicyRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                    Pattern = @"^accessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns the IAM permissions that the caller has on the specified Access Context Manager resource. The
        /// resource can be an AccessPolicy, AccessLevel, or ServicePerimeter. This method does not support other
        /// resources.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
        /// </param>
        public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest body, string resource)
        {
            return new TestIamPermissionsRequest(this.service, body, resource);
        }

        /// <summary>
        /// Returns the IAM permissions that the caller has on the specified Access Context Manager resource. The
        /// resource can be an AccessPolicy, AccessLevel, or ServicePerimeter. This method does not support other
        /// resources.
        /// </summary>
        public class TestIamPermissionsRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
            {
                Resource = resource;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Resource { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                    Pattern = @"^accessPolicies/[^/]+$",
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
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.AccessContextManager.v1.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(this.service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        public class CancelRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.CancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.CancelOperationRequest Body { get; set; }

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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Empty>
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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(this.service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`.
        /// </summary>
        public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListOperationsResponse>
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
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^operations$",
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

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            GcpUserAccessBindings = new GcpUserAccessBindingsResource(service);
        }

        /// <summary>Gets the GcpUserAccessBindings resource.</summary>
        public virtual GcpUserAccessBindingsResource GcpUserAccessBindings { get; }

        /// <summary>The "gcpUserAccessBindings" collection of methods.</summary>
        public class GcpUserAccessBindingsResource
        {
            private const string Resource = "gcpUserAccessBindings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GcpUserAccessBindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a GcpUserAccessBinding. If the client specifies a name, the server ignores it. Fails if a
            /// resource already exists with the same group_key. Completion of this long-running operation does not
            /// necessarily signify that the new binding is deployed onto all affected users, which may take more time.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example: "organizations/256"</param>
            public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a GcpUserAccessBinding. If the client specifies a name, the server ignores it. Fails if a
            /// resource already exists with the same group_key. Completion of this long-running operation does not
            /// necessarily signify that the new binding is deployed onto all affected users, which may take more time.
            /// </summary>
            public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/gcpUserAccessBindings";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the binding deletion is deployed onto all affected users, which may take more time.
            /// </summary>
            /// <param name="name">Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the binding deletion is deployed onto all affected users, which may take more time.
            /// </summary>
            public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</summary>
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
                        Pattern = @"^organizations/[^/]+/gcpUserAccessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the GcpUserAccessBinding with the given name.</summary>
            /// <param name="name">Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets the GcpUserAccessBinding with the given name.</summary>
            public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</summary>
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
                        Pattern = @"^organizations/[^/]+/gcpUserAccessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all GcpUserAccessBindings for a Google Cloud organization.</summary>
            /// <param name="parent">Required. Example: "organizations/256"</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all GcpUserAccessBindings for a Google Cloud organization.</summary>
            public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListGcpUserAccessBindingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Maximum number of items to return. The server may return fewer items. If left blank, the
                /// server may return any number of items.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If left blank, returns the first page. To enumerate all items, use the next_page_token
                /// from your previous list operation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/gcpUserAccessBindings";

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
                        Pattern = @"^organizations/[^/]+$",
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
            /// Updates a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the changed binding is deployed onto all affected users, which may take more time.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only
            /// URI unreserved characters (as defined by [RFC 3986 Section
            /// 2.3](https://tools.ietf.org/html/rfc3986#section-2.3)). Should not be specified by the client during
            /// creation. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the changed binding is deployed onto all affected users, which may take more time.
            /// </summary>
            public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has
                /// only URI unreserved characters (as defined by [RFC 3986 Section
                /// 2.3](https://tools.ietf.org/html/rfc3986#section-2.3)). Should not be specified by the client during
                /// creation. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. This field controls whether or not certain repeated settings in the update request
                /// overwrite or append to existing settings on the binding. If true, then append. Otherwise overwrite.
                /// So far, only scoped_access_settings with reauth_settings supports appending. Global access_levels,
                /// access_levels in scoped_access_settings, dry_run_access_levels, reauth_settings, and
                /// session_settings are not compatible with append functionality, and the request will return an error
                /// if append=true when these settings are in the update_mask. The request will also return an error if
                /// append=true when "scoped_access_settings" is not set in the update_mask.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("append", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Append { get; set; }

                /// <summary>
                /// Required. Only the fields specified in this mask are updated. Because name and group_key cannot be
                /// changed, update_mask is required and may only contain the following fields: `access_levels`,
                /// `dry_run_access_levels`, `reauth_settings` `session_settings`, `scoped_access_settings`. update_mask
                /// { paths: "access_levels" }
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/gcpUserAccessBindings/[^/]+$",
                    });
                    RequestParameters.Add("append", new Google.Apis.Discovery.Parameter
                    {
                        Name = "append",
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
    }

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
        }

        /// <summary>Returns a VPC-SC supported service based on the service name.</summary>
        /// <param name="name">
        /// The name of the service to get information about. The names must be in the same format as used in defining a
        /// service perimeter, for example, `storage.googleapis.com`.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Returns a VPC-SC supported service based on the service name.</summary>
        public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.SupportedService>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// The name of the service to get information about. The names must be in the same format as used in
            /// defining a service perimeter, for example, `storage.googleapis.com`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{name}";

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
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all VPC-SC supported services.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists all VPC-SC supported services.</summary>
        public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListSupportedServicesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// This flag specifies the maximum number of services to return per page. Default is 100.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Token to start on a later page. Default is the first page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
namespace Google.Apis.AccessContextManager.v1.Data
{
    /// <summary>Metadata of Access Context Manager's Long Running Operations.</summary>
    public class AccessContextManagerOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An `AccessLevel` is a label that can be applied to requests to Google Cloud services, along with a list of
    /// requirements necessary for the label to be applied.
    /// </summary>
    public class AccessLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A `BasicLevel` composed of `Conditions`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basic")]
        public virtual BasicLevel Basic { get; set; }

        /// <summary>A `CustomLevel` written in the Common Expression Language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual CustomLevel Custom { get; set; }

        /// <summary>Description of the `AccessLevel` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Identifier. Resource name for the `AccessLevel`. Format:
        /// `accessPolicies/{access_policy}/accessLevels/{access_level}`. The `access_level` component must begin with a
        /// letter, followed by alphanumeric characters or `_`. Its maximum length is 50 characters. After you create an
        /// `AccessLevel`, you cannot change its `name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `AccessPolicy` is a container for `AccessLevels` (which define the necessary attributes to use Google Cloud
    /// services) and `ServicePerimeters` (which define regions of services able to freely pass data within a
    /// perimeter). An access policy is globally visible within an organization, and the restrictions it specifies apply
    /// to all projects within an organization.
    /// </summary>
    public class AccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. An opaque identifier for the current version of the `AccessPolicy`. This will always be a
        /// strongly validated etag, meaning that two Access Policies will be identical if and only if their etags are
        /// identical. Clients should not expect this to be in any specific format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. Identifier. Resource name of the `AccessPolicy`. Format: `accessPolicies/{access_policy}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The parent of this `AccessPolicy` in the Cloud Resource Hierarchy. Currently immutable once
        /// created. Format: `organizations/{organization_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// The scopes of the AccessPolicy. Scopes define which resources a policy can restrict and where its resources
        /// can be referenced. For example, policy A with `scopes=["folders/123"]` has the following behavior: -
        /// ServicePerimeter can only restrict projects within `folders/123`. - ServicePerimeter within policy A can
        /// only reference access levels defined within policy A. - Only one policy can include a given scope; thus,
        /// attempting to create a second policy which includes `folders/123` will result in an error. If no scopes are
        /// provided, then any resource within the organization can be restricted. Scopes cannot be modified after a
        /// policy is created. Policies can only have a single scope. Format: list of `folders/{folder_number}` or
        /// `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>Required. Human readable title. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }
    }

    /// <summary>Access scope represents the client scope, etc. to which the settings will be applied to.</summary>
    public class AccessScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Client scope for this access scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientScope")]
        public virtual ClientScope ClientScope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Access settings represent the set of conditions that must be met for access to be granted. At least one of the
    /// fields must be set.
    /// </summary>
    public class AccessSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not
        /// multiple. This repeated field must have exactly one element. Example:
        /// "accessPolicies/9522/accessLevels/device_trusted"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>Optional. Session settings applied to user access on a given AccessScope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionSettings")]
        public virtual SessionSettings SessionSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identification for an API Operation.</summary>
    public class ApiOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// API methods or permissions to allow. Method or permission must belong to the service specified by
        /// `service_name` field. A single MethodSelector entry with `*` specified for the `method` field will allow all
        /// methods AND permissions for the service specified in `service_name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodSelectors")]
        public virtual System.Collections.Generic.IList<MethodSelector> MethodSelectors { get; set; }

        /// <summary>
        /// The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single
        /// ApiOperation with `service_name` field set to `*` will allow all methods AND permissions for all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An application that accesses Google Cloud APIs.</summary>
    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OAuth client ID of the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The name of the application. Example: "Cloud Console"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

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

    /// <summary>`AuthorizedOrgsDesc` contains data for an organization's authorization policy.</summary>
    public class AuthorizedOrgsDesc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The asset type of this authorized orgs desc. Valid values are `ASSET_TYPE_DEVICE`, and
        /// `ASSET_TYPE_CREDENTIAL_STRENGTH`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetType")]
        public virtual string AssetType { get; set; }

        /// <summary>
        /// The direction of the authorization relationship between this organization and the organizations listed in
        /// the `orgs` field. The valid values for this field include the following: `AUTHORIZATION_DIRECTION_FROM`:
        /// Allows this organization to evaluate traffic in the organizations listed in the `orgs` field.
        /// `AUTHORIZATION_DIRECTION_TO`: Allows the organizations listed in the `orgs` field to evaluate the traffic in
        /// this organization. For the authorization relationship to take effect, all of the organizations must
        /// authorize and specify the appropriate relationship direction. For example, if organization A authorized
        /// organization B and C to evaluate its traffic, by specifying `AUTHORIZATION_DIRECTION_TO` as the
        /// authorization direction, organizations B and C must specify `AUTHORIZATION_DIRECTION_FROM` as the
        /// authorization direction in their `AuthorizedOrgsDesc` resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationDirection")]
        public virtual string AuthorizationDirection { get; set; }

        /// <summary>
        /// A granular control type for authorization levels. Valid value is `AUTHORIZATION_TYPE_TRUST`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationType")]
        public virtual string AuthorizationType { get; set; }

        /// <summary>
        /// Identifier. Resource name for the `AuthorizedOrgsDesc`. Format:
        /// `accessPolicies/{access_policy}/authorizedOrgsDescs/{authorized_orgs_desc}`. The `authorized_orgs_desc`
        /// component must begin with a letter, followed by alphanumeric characters or `_`. After you create an
        /// `AuthorizedOrgsDesc`, you cannot change its `name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The list of organization ids in this AuthorizedOrgsDesc. Format: `organizations/` Example:
        /// `organizations/123456`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgs")]
        public virtual System.Collections.Generic.IList<string> Orgs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`BasicLevel` is an `AccessLevel` using a set of recommended features.</summary>
    public class BasicLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How the `conditions` list should be combined to determine if a request is granted this `AccessLevel`. If AND
        /// is used, each `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied. If OR is
        /// used, at least one `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied.
        /// Default behavior is AND.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combiningFunction")]
        public virtual string CombiningFunction { get; set; }

        /// <summary>Required. A list of requirements for the `AccessLevel` to be granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Condition> Conditions { get; set; }

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

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Client scope represents the application, etc. subject to this binding's restrictions.</summary>
    public class ClientScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The application that is subject to this binding's scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedClientApplication")]
        public virtual Application RestrictedClientApplication { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to commit dry-run specs in all Service Perimeters belonging to an Access Policy.</summary>
    public class CommitServicePerimetersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The etag for the version of the Access Policy that this commit operation is to be performed on.
        /// If, at the time of commit, the etag for the Access Policy stored in Access Context Manager is different from
        /// the specified etag, then the commit operation will not be performed and the call will fail. This field is
        /// not required. If etag is not provided, the operation will be performed as if a valid etag is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response to CommitServicePerimetersRequest. This will be put inside of Operation.response field.
    /// </summary>
    public class CommitServicePerimetersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all the Service Perimeter instances in the Access Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition necessary for an `AccessLevel` to be granted. The Condition is an AND over its fields. So a
    /// Condition is true if: 1) the request IP is from one of the listed subnetworks AND 2) the originating device
    /// complies with the listed device policy AND 3) all listed access levels are granted AND 4) the request was sent
    /// at a time allowed by the DateTimeRestriction.
    /// </summary>
    public class Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all
        /// devices are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePolicy")]
        public virtual DevicePolicy DevicePolicy { get; set; }

        /// <summary>
        /// CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the
        /// specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input
        /// is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for
        /// IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be
        /// in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipSubnetworks")]
        public virtual System.Collections.Generic.IList<string> IpSubnetworks { get; set; }

        /// <summary>
        /// The request must be made by one of the provided user or service accounts. Groups are not supported. Syntax:
        /// `user:{emailid}` `serviceAccount:{emailid}` If not specified, a request may come from any user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields. Any
        /// non-empty field criteria evaluating to false will result in the Condition to be satisfied. Defaults to
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negate")]
        public virtual System.Nullable<bool> Negate { get; set; }

        /// <summary>
        /// The request must originate from one of the provided countries/regions. Must be valid ISO 3166-1 alpha-2
        /// codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>
        /// A list of other access levels defined in the same `Policy`, referenced by resource name. Referencing an
        /// `AccessLevel` which does not exist is an error. All access levels listed must be granted for the Condition
        /// to be true. Example: "`accessPolicies/MY_POLICY/accessLevels/LEVEL_NAME"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredAccessLevels")]
        public virtual System.Collections.Generic.IList<string> RequiredAccessLevels { get; set; }

        /// <summary>
        /// The request must originate from one of the provided VPC networks in Google Cloud. Cannot specify this field
        /// together with `ip_subnetworks`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcNetworkSources")]
        public virtual System.Collections.Generic.IList<VpcNetworkSource> VpcNetworkSources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `CustomLevel` is an `AccessLevel` using the Cloud Common Expression Language to represent the necessary
    /// conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec
    /// </summary>
    public class CustomLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A Cloud CEL expression evaluating to a boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expr")]
        public virtual Expr Expr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `DevicePolicy` specifies device specific restrictions necessary to acquire a given access level. A
    /// `DevicePolicy` specifies requirements for requests from devices to be granted access levels, it does not do any
    /// enforcement on the device. `DevicePolicy` acts as an AND over all specified fields, and each repeated field is
    /// an OR over its elements. Any unset fields are ignored. For example, if the proto is { os_type : DESKTOP_WINDOWS,
    /// os_type : DESKTOP_LINUX, encryption_status: ENCRYPTED}, then the DevicePolicy will be true for requests
    /// originating from encrypted Linux desktops and encrypted Windows desktops.
    /// </summary>
    public class DevicePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allowed device management levels, an empty list allows all management levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedDeviceManagementLevels")]
        public virtual System.Collections.Generic.IList<string> AllowedDeviceManagementLevels { get; set; }

        /// <summary>Allowed encryptions statuses, an empty list allows all statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedEncryptionStatuses")]
        public virtual System.Collections.Generic.IList<string> AllowedEncryptionStatuses { get; set; }

        /// <summary>Allowed OS versions, an empty list allows all types and all versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osConstraints")]
        public virtual System.Collections.Generic.IList<OsConstraint> OsConstraints { get; set; }

        /// <summary>Whether the device needs to be approved by the customer admin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireAdminApproval")]
        public virtual System.Nullable<bool> RequireAdminApproval { get; set; }

        /// <summary>Whether the device needs to be corp owned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireCorpOwned")]
        public virtual System.Nullable<bool> RequireCorpOwned { get; set; }

        /// <summary>
        /// Whether or not screenlock is required for the DevicePolicy to be true. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireScreenlock")]
        public virtual System.Nullable<bool> RequireScreenlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions based on information about the
    /// source of the request. Note that if the destination of the request is also protected by a ServicePerimeter, then
    /// that ServicePerimeter must have an IngressPolicy which allows access in order for this request to succeed.
    /// </summary>
    public class EgressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through [EgressPolicy]. Identities can be an individual user,
        /// service account, Google group, or third-party identity. For third-party identity, only single identities are
        /// supported and other identity types are not supported. The `v1` identities that have the prefix `user`,
        /// `group`, `serviceAccount`, and `principal` in https://cloud.google.com/iam/docs/principal-identifiers#v1 are
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then
        /// members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>
        /// Whether to enforce traffic restrictions based on `sources` field. If the `sources` fields is non-empty, then
        /// this field must be set to `SOURCE_RESTRICTION_ENABLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRestriction")]
        public virtual string SourceRestriction { get; set; }

        /// <summary>
        /// Sources that this EgressPolicy authorizes access from. If this field is not empty, then `source_restriction`
        /// must be set to `SOURCE_RESTRICTION_ENABLED`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<EgressSource> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for egress from perimeter. EgressPolicies match requests based on `egress_from` and `egress_to` stanzas.
    /// For an EgressPolicy to match, both `egress_from` and `egress_to` stanzas must be matched. If an EgressPolicy
    /// matches a request, the request is allowed to span the ServicePerimeter boundary. For example, an EgressPolicy
    /// can be used to allow VMs on networks within the ServicePerimeter to access a defined set of projects outside the
    /// perimeter in certain contexts (e.g. to read data from a Cloud Storage bucket or query against a BigQuery
    /// dataset). EgressPolicies are concerned with the *resources* that a request relates as well as the API services
    /// and API actions being used. They do not related to the direction of data movement. More detailed documentation
    /// for this concept can be found in the descriptions of EgressFrom and EgressTo.
    /// </summary>
    public class EgressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressFrom")]
        public virtual EgressFrom EgressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressTo")]
        public virtual EgressTo EgressTo { get; set; }

        /// <summary>
        /// Optional. Human-readable title for the egress rule. The title must be unique within the perimeter and can
        /// not exceed 100 characters. Within the access policy, the combined length of all rule titles must not exceed
        /// 240,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The source that EgressPolicy authorizes access from inside the ServicePerimeter to somewhere outside the
    /// ServicePerimeter boundaries.
    /// </summary>
    public class EgressSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AccessLevel resource name that allows protected resources inside the ServicePerimeters to access outside
        /// the ServicePerimeter boundaries. AccessLevels listed must be in the same policy as this ServicePerimeter.
        /// Referencing a nonexistent AccessLevel will cause an error. If an AccessLevel name is not specified, only
        /// resources within the perimeter can be accessed through Google Cloud calls with request origins within the
        /// perimeter. Example: `accessPolicies/MY_POLICY/accessLevels/MY_LEVEL`. If a single `*` is specified for
        /// `access_level`, then all EgressSources will be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual string AccessLevel { get; set; }

        /// <summary>
        /// A Google Cloud resource from the service perimeter that you want to allow to access data outside the
        /// perimeter. This field supports only projects. The project format is `projects/{project_number}`. You can't
        /// use `*` in this field to allow all Google Cloud resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the `resources` specified. Note that if the destination of the
    /// request is also protected by a ServicePerimeter, then that ServicePerimeter must have an IngressPolicy which
    /// allows access in order for this request to succeed. The request must match `operations` AND `resources` fields
    /// in order to be allowed egress out of the perimeter.
    /// </summary>
    public class EgressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of external resources that are allowed to be accessed. Only AWS and Azure resources are supported.
        /// For Amazon S3, the supported formats are s3://BUCKET_NAME, s3a://BUCKET_NAME, and s3n://BUCKET_NAME. For
        /// Azure Storage, the supported format is azure://myaccount.blob.core.windows.net/CONTAINER_NAME. A request
        /// matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not
        /// allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalResources")]
        public virtual System.Collections.Generic.IList<string> ExternalResources { get; set; }

        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in the corresponding EgressFrom. A
        /// request matches if it uses an operation/service in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, that are allowed to be accessed by
        /// sources defined in the corresponding EgressFrom. A request matches if it contains a resource in this list.
        /// If `*` is specified for `resources`, then this EgressTo rule will authorize access to all resources outside
        /// the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

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
    /// Restricts access to Cloud Console and Google Cloud APIs for a set of users using Context-Aware Access.
    /// </summary>
    public class GcpUserAccessBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Access level that a user must have to be granted access. Only one access level is supported, not
        /// multiple. This repeated field must have exactly one element. Example:
        /// "accessPolicies/9522/accessLevels/device_trusted"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>
        /// Optional. Dry run access level that will be evaluated but will not be enforced. The access denial based on
        /// dry run policy will be logged. Only one access level is supported, not multiple. This list must have exactly
        /// one element. Example: "accessPolicies/9522/accessLevels/device_trusted"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRunAccessLevels")]
        public virtual System.Collections.Generic.IList<string> DryRunAccessLevels { get; set; }

        /// <summary>
        /// Required. Immutable. Google Group id whose members are subject to this binding's restrictions. See "id" in
        /// the [G Suite Directory API's Groups resource]
        /// (https://developers.google.com/admin-sdk/directory/v1/reference/groups#resource). If a group's email
        /// address/alias is changed, this resource will continue to point at the changed group. This field does not
        /// accept group email addresses or aliases. Example: "01d520gv4vjcrht"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupKey")]
        public virtual string GroupKey { get; set; }

        /// <summary>
        /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only URI
        /// unreserved characters (as defined by [RFC 3986 Section
        /// 2.3](https://tools.ietf.org/html/rfc3986#section-2.3)). Should not be specified by the client during
        /// creation. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. A list of applications that are subject to this binding's restrictions. If the list is empty, the
        /// binding restrictions will universally apply to all applications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedClientApplications")]
        public virtual System.Collections.Generic.IList<Application> RestrictedClientApplications { get; set; }

        /// <summary>
        /// Optional. A list of scoped access settings that set this binding's restrictions on a subset of applications.
        /// This field cannot be set if restricted_client_applications is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopedAccessSettings")]
        public virtual System.Collections.Generic.IList<ScopedAccessSettings> ScopedAccessSettings { get; set; }

        /// <summary>Optional. The Google Cloud session length (GCSL) policy for the group key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionSettings")]
        public virtual SessionSettings SessionSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of Google Cloud Access Binding Long Running Operations.</summary>
    public class GcpUserAccessBindingOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and 3.
        /// Requests specifying an invalid value will be rejected. Requests for policies with any conditional role
        /// bindings must specify version 3. Policies with no conditional role bindings may specify any valid value or
        /// leave the field unset. The policy in the response might use the policy version that you specified, or it
        /// might use a lower policy version. For example, if you specify version 3, but the policy has no conditional
        /// role bindings, the response uses version 1. To learn which resources support conditions in their IAM
        /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the source of the request. The request must satisfy what is defined in `sources` AND identity related fields in
    /// order to match.
    /// </summary>
    public class IngressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through [IngressPolicy]. Identities can be an individual user,
        /// service account, Google group, or third-party identity. For third-party identity, only single identities are
        /// supported and other identity types are not supported. The `v1` identities that have the prefix `user`,
        /// `group`, `serviceAccount`, and `principal` in https://cloud.google.com/iam/docs/principal-identifiers#v1 are
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified,
        /// then members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>Sources that this IngressPolicy authorizes access from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<IngressSource> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for ingress into ServicePerimeter. IngressPolicies match requests based on `ingress_from` and
    /// `ingress_to` stanzas. For an ingress policy to match, both the `ingress_from` and `ingress_to` stanzas must be
    /// matched. If an IngressPolicy matches a request, the request is allowed through the perimeter boundary from
    /// outside the perimeter. For example, access from the internet can be allowed either based on an AccessLevel or,
    /// for traffic hosted on Google Cloud, the project of the source network. For access from private networks, using
    /// the project of the hosting network is required. Individual ingress policies can be limited by restricting which
    /// services and/or actions they match using the `ingress_to` field.
    /// </summary>
    public class IngressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressFrom")]
        public virtual IngressFrom IngressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressTo")]
        public virtual IngressTo IngressTo { get; set; }

        /// <summary>
        /// Optional. Human-readable title for the ingress rule. The title must be unique within the perimeter and can
        /// not exceed 100 characters. Within the access policy, the combined length of all rule titles must not exceed
        /// 240,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The source that IngressPolicy authorizes access from.</summary>
    public class IngressSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the
        /// internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent
        /// AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only
        /// be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `accessPolicies/MY_POLICY/accessLevels/MY_LEVEL`. If a single `*` is specified for `access_level`, then all
        /// IngressSources will be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual string AccessLevel { get; set; }

        /// <summary>
        /// A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be
        /// allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format:
        /// `projects/{project_number}` VPC network format:
        /// `//compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}`. The project may be in any Google
        /// Cloud organization, not just the organization that the perimeter is defined in. `*` is not allowed, the case
        /// of allowing all Google Cloud resources only is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the target resource of the request. The request must satisfy what
    /// is defined in `operations` AND `resources` in order to match.
    /// </summary>
    public class IngressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in corresponding IngressFrom in
        /// this ServicePerimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, protected by this ServicePerimeter
        /// that are allowed to be accessed by sources defined in the corresponding IngressFrom. If a single `*` is
        /// specified, then access to all resources inside the perimeter are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ListAccessLevelsRequest`.</summary>
    public class ListAccessLevelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the Access Level instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<AccessLevel> AccessLevels { get; set; }

        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ListAccessPoliciesRequest`.</summary>
    public class ListAccessPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the AccessPolicy instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessPolicies")]
        public virtual System.Collections.Generic.IList<AccessPolicy> AccessPolicies { get; set; }

        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ListAuthorizedOrgsDescsRequest`.</summary>
    public class ListAuthorizedOrgsDescsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all the Authorized Orgs Desc instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedOrgsDescs")]
        public virtual System.Collections.Generic.IList<AuthorizedOrgsDesc> AuthorizedOrgsDescs { get; set; }

        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListGcpUserAccessBindings.</summary>
    public class ListGcpUserAccessBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GcpUserAccessBinding</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpUserAccessBindings")]
        public virtual System.Collections.Generic.IList<GcpUserAccessBinding> GcpUserAccessBindings { get; set; }

        /// <summary>Token to get the next page of items. If blank, there are no more items.</summary>
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

    /// <summary>A response to `ListServicePerimetersRequest`.</summary>
    public class ListServicePerimetersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of the Service Perimeter instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ListSupportedServicesRequest`.</summary>
    public class ListSupportedServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of services supported by VPC Service Controls instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedServices")]
        public virtual System.Collections.Generic.IList<SupportedService> SupportedServices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An allowed method or permission of a service specified in ApiOperation.</summary>
    public class MethodSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A valid method name for the corresponding `service_name` in ApiOperation. If `*` is used as the value for
        /// the `method`, then ALL methods and permissions are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>A valid Cloud IAM permission for the corresponding `service_name` in ApiOperation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

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

    /// <summary>A restriction on the OS type and version of devices making requests.</summary>
    public class OsConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format:
        /// `"major.minor.patch"`. Examples: `"10.5.301"`, `"9.2.1"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVersion")]
        public virtual string MinimumVersion { get; set; }

        /// <summary>Required. The allowed OS type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osType")]
        public virtual string OsType { get; set; }

        /// <summary>
        /// Only allows requests from devices with a verified Chrome OS. Verifications includes requirements that the
        /// device is enterprise-managed, conformant to domain policies, and the caller has permission to call the API
        /// targeted by the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireVerifiedChromeOs")]
        public virtual System.Nullable<bool> RequireVerifiedChromeOs { get; set; }

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
    /// A request to replace all existing Access Levels in an Access Policy with the Access Levels provided. This is
    /// done atomically.
    /// </summary>
    public class ReplaceAccessLevelsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The desired Access Levels that should replace all existing Access Levels in the Access Policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<AccessLevel> AccessLevels { get; set; }

        /// <summary>
        /// Optional. The etag for the version of the Access Policy that this replace operation is to be performed on.
        /// If, at the time of replace, the etag for the Access Policy stored in Access Context Manager is different
        /// from the specified etag, then the replace operation will not be performed and the call will fail. This field
        /// is not required. If etag is not provided, the operation will be performed as if a valid etag is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response to ReplaceAccessLevelsRequest. This will be put inside of Operation.response field.
    /// </summary>
    public class ReplaceAccessLevelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the Access Level instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<AccessLevel> AccessLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to replace all existing Service Perimeters in an Access Policy with the Service Perimeters provided.
    /// This is done atomically.
    /// </summary>
    public class ReplaceServicePerimetersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The etag for the version of the Access Policy that this replace operation is to be performed on.
        /// If, at the time of replace, the etag for the Access Policy stored in Access Context Manager is different
        /// from the specified etag, then the replace operation will not be performed and the call will fail. This field
        /// is not required. If etag is not provided, the operation will be performed as if a valid etag is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. The desired Service Perimeters that should replace all existing Service Perimeters in the Access
        /// Policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }
    }

    /// <summary>
    /// A response to ReplaceServicePerimetersRequest. This will be put inside of Operation.response field.
    /// </summary>
    public class ReplaceServicePerimetersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the Service Perimeter instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A relationship between access settings and its scope.</summary>
    public class ScopedAccessSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Access settings for this scoped access settings. This field may be empty if dry_run_settings is
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeSettings")]
        public virtual AccessSettings ActiveSettings { get; set; }

        /// <summary>
        /// Optional. Dry-run access settings for this scoped access settings. This field may be empty if
        /// active_settings is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRunSettings")]
        public virtual AccessSettings DryRunSettings { get; set; }

        /// <summary>
        /// Optional. Application, etc. to which the access settings will be applied to. Implicitly, this is the scoped
        /// access settings key; as such, it must be unique and non-empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual AccessScope Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ServicePerimeter` describes a set of Google Cloud resources which can freely import and export data amongst
    /// themselves, but not export outside of the `ServicePerimeter`. If a request with a source within this
    /// `ServicePerimeter` has a target outside of the `ServicePerimeter`, the request will be blocked. Otherwise the
    /// request is allowed. There are two types of Service Perimeter - Regular and Bridge. Regular Service Perimeters
    /// cannot overlap, a single Google Cloud project or VPC network can only belong to a single regular Service
    /// Perimeter. Service Perimeter Bridges can contain only Google Cloud projects as members, a single Google Cloud
    /// project may belong to multiple Service Perimeter Bridges.
    /// </summary>
    public class ServicePerimeter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the `ServicePerimeter` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional. An opaque identifier for the current version of the `ServicePerimeter`. This identifier does not
        /// follow any specific format. If an etag is not provided, the operation will be performed as if a valid etag
        /// is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Identifier. Resource name for the `ServicePerimeter`. Format:
        /// `accessPolicies/{access_policy}/servicePerimeters/{service_perimeter}`. The `service_perimeter` component
        /// must begin with a letter, followed by alphanumeric characters or `_`. After you create a `ServicePerimeter`,
        /// you cannot change its `name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Perimeter type indicator. A single project or VPC network is allowed to be a member of single regular
        /// perimeter, but multiple service perimeter bridges. A project cannot be a included in a perimeter bridge
        /// without being included in regular perimeter. For perimeter bridges, the restricted service list as well as
        /// access level lists must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perimeterType")]
        public virtual string PerimeterType { get; set; }

        /// <summary>
        /// Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test
        /// ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the
        /// "use_explicit_dry_run_spec" flag is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ServicePerimeterConfig Spec { get; set; }

        /// <summary>
        /// Current ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels
        /// that determine perimeter content and boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ServicePerimeterConfig Status { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and
        /// that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the
        /// generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to
        /// use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced
        /// config ("status") without actually enforcing them. This testing is done through analyzing the differences
        /// between currently enforced and suggested restrictions. use_explicit_dry_run_spec must bet set to True if any
        /// of the fields in the spec are set to non-default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useExplicitDryRunSpec")]
        public virtual System.Nullable<bool> UseExplicitDryRunSpec { get; set; }
    }

    /// <summary>
    /// `ServicePerimeterConfig` specifies a set of Google Cloud resources that describe specific Service Perimeter
    /// configuration.
    /// </summary>
    public class ServicePerimeterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of `AccessLevel` resource names that allow resources within the `ServicePerimeter` to be accessed
        /// from the internet. `AccessLevels` listed must be in the same policy as this `ServicePerimeter`. Referencing
        /// a nonexistent `AccessLevel` is a syntax error. If no `AccessLevel` names are listed, resources within the
        /// perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `"accessPolicies/MY_POLICY/accessLevels/MY_LEVEL"`. For Service Perimeter Bridge, must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>
        /// List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of
        /// which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressPolicies")]
        public virtual System.Collections.Generic.IList<EgressPolicy> EgressPolicies { get; set; }

        /// <summary>
        /// List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of
        /// which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressPolicies")]
        public virtual System.Collections.Generic.IList<IngressPolicy> IngressPolicies { get; set; }

        /// <summary>
        /// A list of Google Cloud resources that are inside of the service perimeter. Currently only projects and VPCs
        /// are allowed. Project format: `projects/{project_number}` VPC network format:
        /// `//compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>
        /// Google Cloud services that are subject to the Service Perimeter restrictions. For example, if
        /// `storage.googleapis.com` is specified, access to the storage buckets inside the perimeter must meet the
        /// perimeter's access restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedServices")]
        public virtual System.Collections.Generic.IList<string> RestrictedServices { get; set; }

        /// <summary>Configuration for APIs allowed within Perimeter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccessibleServices")]
        public virtual VpcAccessibleServices VpcAccessibleServices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Stores settings related to Google Cloud Session Length including session duration, the type of challenge (i.e.
    /// method) they should face when their session expires, and other related settings.
    /// </summary>
    public class SessionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. How long a user is allowed to take between actions before a new access token must be issued. Only
        /// set for Google Cloud apps.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxInactivity")]
        public virtual object MaxInactivity { get; set; }

        /// <summary>
        /// Optional. The session length. Setting this field to zero is equal to disabling session. Also can set
        /// infinite session by flipping the enabled bit to false below. If use_oidc_max_age is true, for OIDC apps, the
        /// session length will be the minimum of this field and OIDC max_age param.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionLength")]
        public virtual object SessionLength { get; set; }

        /// <summary>
        /// Optional. This field enables or disables Google Cloud session length. When false, all fields set above will
        /// be disregarded and the session length is basically infinite.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionLengthEnabled")]
        public virtual System.Nullable<bool> SessionLengthEnabled { get; set; }

        /// <summary>Optional. Session method when user's Google Cloud session is up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionReauthMethod")]
        public virtual string SessionReauthMethod { get; set; }

        /// <summary>
        /// Optional. Only useful for OIDC apps. When false, the OIDC max_age param, if passed in the authentication
        /// request will be ignored. When true, the re-auth period will be the minimum of the session_length field and
        /// the max_age OIDC param.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useOidcMaxAge")]
        public virtual System.Nullable<bool> UseOidcMaxAge { get; set; }

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

    /// <summary>`SupportedService` specifies the VPC Service Controls and its properties.</summary>
    public class SupportedService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the service is available on the restricted VIP. Services on the restricted VIP typically either
        /// support VPC Service Controls or are core infrastructure services required for the functioning of Google
        /// Cloud.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableOnRestrictedVip")]
        public virtual System.Nullable<bool> AvailableOnRestrictedVip { get; set; }

        /// <summary>
        /// True if the service is supported with some limitations. Check
        /// [documentation](https://cloud.google.com/vpc-service-controls/docs/supported-products) for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knownLimitations")]
        public virtual System.Nullable<bool> KnownLimitations { get; set; }

        /// <summary>The service name or address of the supported service, such as `service.googleapis.com`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The support stage of the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceSupportStage")]
        public virtual string ServiceSupportStage { get; set; }

        /// <summary>The support stage of the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportStage")]
        public virtual string SupportStage { get; set; }

        /// <summary>
        /// The list of the supported methods. This field exists only in response to GetSupportedService
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedMethods")]
        public virtual System.Collections.Generic.IList<MethodSelector> SupportedMethods { get; set; }

        /// <summary>The name of the supported product, such as 'Cloud Product API'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

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

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    public class VpcAccessibleServices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of APIs usable within the Service Perimeter. Must be empty unless 'enable_restriction' is True. You
        /// can specify a list of individual services, as well as include the 'RESTRICTED-SERVICES' value, which
        /// automatically includes all of the services protected by the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedServices")]
        public virtual System.Collections.Generic.IList<string> AllowedServices { get; set; }

        /// <summary>
        /// Whether to restrict API calls within the Service Perimeter to the list of APIs specified in
        /// 'allowed_services'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRestriction")]
        public virtual System.Nullable<bool> EnableRestriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The originating network source in Google Cloud.</summary>
    public class VpcNetworkSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sub-segment ranges of a VPC network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcSubnetwork")]
        public virtual VpcSubNetwork VpcSubnetwork { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sub-segment ranges inside of a VPC Network.</summary>
    public class VpcSubNetwork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Network name. If the network is not part of the organization, the `compute.network.get` permission
        /// must be granted to the caller. Format:
        /// `//compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NETWORK_NAME}` Example:
        /// `//compute.googleapis.com/projects/my-project/global/networks/network-1`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual string Network { get; set; }

        /// <summary>
        /// CIDR block IP subnetwork specification. The IP address must be an IPv4 address and can be a public or
        /// private IP address. Note that for a CIDR IP address block, the specified IP address portion must be properly
        /// truncated (i.e. all the host bits must be zero) or the input is considered malformed. For example,
        /// "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. If empty, all IP addresses are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcIpSubnetworks")]
        public virtual System.Collections.Generic.IList<string> VpcIpSubnetworks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
