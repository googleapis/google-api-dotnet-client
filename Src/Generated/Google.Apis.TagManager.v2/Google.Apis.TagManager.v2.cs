// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.TagManager.v2
{
    /// <summary>The TagManager Service.</summary>
    public class TagManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TagManagerService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TagManagerService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Accounts = new AccountsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "tagmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://tagmanager.googleapis.com/";
        #else
            "https://tagmanager.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://tagmanager.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Tag Manager API.</summary>
        public class Scope
        {
            /// <summary>Delete your Google Tag Manager containers</summary>
            public static string TagmanagerDeleteContainers = "https://www.googleapis.com/auth/tagmanager.delete.containers";

            /// <summary>Manage your Google Tag Manager container and its subcomponents, excluding versioning and
            /// publishing</summary>
            public static string TagmanagerEditContainers = "https://www.googleapis.com/auth/tagmanager.edit.containers";

            /// <summary>Manage your Google Tag Manager container versions</summary>
            public static string TagmanagerEditContainerversions = "https://www.googleapis.com/auth/tagmanager.edit.containerversions";

            /// <summary>View and manage your Google Tag Manager accounts</summary>
            public static string TagmanagerManageAccounts = "https://www.googleapis.com/auth/tagmanager.manage.accounts";

            /// <summary>Manage user permissions of your Google Tag Manager account and container</summary>
            public static string TagmanagerManageUsers = "https://www.googleapis.com/auth/tagmanager.manage.users";

            /// <summary>Publish your Google Tag Manager container versions</summary>
            public static string TagmanagerPublish = "https://www.googleapis.com/auth/tagmanager.publish";

            /// <summary>View your Google Tag Manager container and its subcomponents</summary>
            public static string TagmanagerReadonly = "https://www.googleapis.com/auth/tagmanager.readonly";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Tag Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Delete your Google Tag Manager containers</summary>
            public const string TagmanagerDeleteContainers = "https://www.googleapis.com/auth/tagmanager.delete.containers";

            /// <summary>Manage your Google Tag Manager container and its subcomponents, excluding versioning and
            /// publishing</summary>
            public const string TagmanagerEditContainers = "https://www.googleapis.com/auth/tagmanager.edit.containers";

            /// <summary>Manage your Google Tag Manager container versions</summary>
            public const string TagmanagerEditContainerversions = "https://www.googleapis.com/auth/tagmanager.edit.containerversions";

            /// <summary>View and manage your Google Tag Manager accounts</summary>
            public const string TagmanagerManageAccounts = "https://www.googleapis.com/auth/tagmanager.manage.accounts";

            /// <summary>Manage user permissions of your Google Tag Manager account and container</summary>
            public const string TagmanagerManageUsers = "https://www.googleapis.com/auth/tagmanager.manage.users";

            /// <summary>Publish your Google Tag Manager container versions</summary>
            public const string TagmanagerPublish = "https://www.googleapis.com/auth/tagmanager.publish";

            /// <summary>View your Google Tag Manager container and its subcomponents</summary>
            public const string TagmanagerReadonly = "https://www.googleapis.com/auth/tagmanager.readonly";

        }



        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    ///<summary>A base abstract class for TagManager requests.</summary>
    public abstract class TagManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new TagManagerBaseServiceRequest instance.</summary>
        protected TagManagerBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
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
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
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
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes TagManager parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Containers = new ContainersResource(service);
            UserPermissions = new UserPermissionsResource(service);

        }

        /// <summary>Gets the Containers resource.</summary>
        public virtual ContainersResource Containers { get; }

        /// <summary>The "containers" collection of methods.</summary>
        public class ContainersResource
        {
            private const string Resource = "containers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContainersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Environments = new EnvironmentsResource(service);
                VersionHeaders = new VersionHeadersResource(service);
                Versions = new VersionsResource(service);
                Workspaces = new WorkspacesResource(service);

            }

            /// <summary>Gets the Environments resource.</summary>
            public virtual EnvironmentsResource Environments { get; }

            /// <summary>The "environments" collection of methods.</summary>
            public class EnvironmentsResource
            {
                private const string Resource = "environments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EnvironmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Creates a GTM Environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Environment body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a GTM Environment.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Environment>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Environment body, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM Container's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.Environment Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+parent}/environments";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                            });
                    }

                }

                /// <summary>Deletes a GTM Environment.</summary>
                /// <param name="path">GTM Environment's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</param>
                public virtual DeleteRequest Delete(string path)
                {
                    return new DeleteRequest(service, path);
                }

                /// <summary>Deletes a GTM Environment.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM Environment's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/environments/[^/]+$",
                            });
                    }

                }

                /// <summary>Gets a GTM Environment.</summary>
                /// <param name="path">GTM Environment's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</param>
                public virtual GetRequest Get(string path)
                {
                    return new GetRequest(service, path);
                }

                /// <summary>Gets a GTM Environment.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Environment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM Environment's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/environments/[^/]+$",
                            });
                    }

                }

                /// <summary>Lists all GTM Environments of a GTM Container.</summary>
                /// <param name="parent">GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all GTM Environments of a GTM Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListEnvironmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>GTM Container's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Continuation token for fetching the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+parent}/environments";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                            });
                        RequestParameters.Add(
                            "pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Re-generates the authorization code for a GTM Environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="path">GTM Environment's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</param>
                public virtual ReauthorizeRequest Reauthorize(Google.Apis.TagManager.v2.Data.Environment body, string path)
                {
                    return new ReauthorizeRequest(service, body, path);
                }

                /// <summary>Re-generates the authorization code for a GTM Environment.</summary>
                public class ReauthorizeRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Environment>
                {
                    /// <summary>Constructs a new Reauthorize request.</summary>
                    public ReauthorizeRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Environment body, string path)
                        : base(service)
                    {
                        Path = path;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM Environment's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.Environment Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "reauthorize";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:reauthorize";

                    /// <summary>Initializes Reauthorize parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/environments/[^/]+$",
                            });
                    }

                }

                /// <summary>Updates a GTM Environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="path">GTM Environment's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Environment body, string path)
                {
                    return new UpdateRequest(service, body, path);
                }

                /// <summary>Updates a GTM Environment.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Environment>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Environment body, string path)
                        : base(service)
                    {
                        Path = path;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM Environment's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/environments/{environment_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }

                    /// <summary>When provided, this fingerprint must match the fingerprint of the environment in
                    /// storage.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.Environment Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/environments/[^/]+$",
                            });
                        RequestParameters.Add(
                            "fingerprint", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fingerprint",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }
            }
            /// <summary>Gets the VersionHeaders resource.</summary>
            public virtual VersionHeadersResource VersionHeaders { get; }

            /// <summary>The "version_headers" collection of methods.</summary>
            public class VersionHeadersResource
            {
                private const string Resource = "versionHeaders";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public VersionHeadersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Gets the latest container version header</summary>
                /// <param name="parent">GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</param>
                public virtual LatestRequest Latest(string parent)
                {
                    return new LatestRequest(service, parent);
                }

                /// <summary>Gets the latest container version header</summary>
                public class LatestRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ContainerVersionHeader>
                {
                    /// <summary>Constructs a new Latest request.</summary>
                    public LatestRequest(Google.Apis.Services.IClientService service, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>GTM Container's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "latest";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+parent}/version_headers:latest";

                    /// <summary>Initializes Latest parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                            });
                    }

                }

                /// <summary>Lists all Container Versions of a GTM Container.</summary>
                /// <param name="parent">GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all Container Versions of a GTM Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListContainerVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>GTM Container's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Also retrieve deleted (archived) versions when true.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeDeleted { get; set; }

                    /// <summary>Continuation token for fetching the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+parent}/version_headers";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                            });
                        RequestParameters.Add(
                            "includeDeleted", new Google.Apis.Discovery.Parameter
                            {
                                Name = "includeDeleted",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        RequestParameters.Add(
                            "pageToken", new Google.Apis.Discovery.Parameter
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


                /// <summary>Deletes a Container Version.</summary>
                /// <param name="path">GTM ContainerVersion's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</param>
                public virtual DeleteRequest Delete(string path)
                {
                    return new DeleteRequest(service, path);
                }

                /// <summary>Deletes a Container Version.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM ContainerVersion's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/versions/[^/]+$",
                            });
                    }

                }

                /// <summary>Gets a Container Version.</summary>
                /// <param name="path">GTM ContainerVersion's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</param>
                public virtual GetRequest Get(string path)
                {
                    return new GetRequest(service, path);
                }

                /// <summary>Gets a Container Version.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM ContainerVersion's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }

                    /// <summary>The GTM ContainerVersion ID. Specify published to retrieve the currently published
                    /// version.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerVersionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ContainerVersionId { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/versions/[^/]+$",
                            });
                        RequestParameters.Add(
                            "containerVersionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "containerVersionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Gets the live (i.e. published) container version</summary>
                /// <param name="parent">GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</param>
                public virtual LiveRequest Live(string parent)
                {
                    return new LiveRequest(service, parent);
                }

                /// <summary>Gets the live (i.e. published) container version</summary>
                public class LiveRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Live request.</summary>
                    public LiveRequest(Google.Apis.Services.IClientService service, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>GTM Container's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "live";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+parent}/versions:live";

                    /// <summary>Initializes Live parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                            });
                    }

                }

                /// <summary>Publishes a Container Version.</summary>
                /// <param name="path">GTM ContainerVersion's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</param>
                public virtual PublishRequest Publish(string path)
                {
                    return new PublishRequest(service, path);
                }

                /// <summary>Publishes a Container Version.</summary>
                public class PublishRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.PublishContainerVersionResponse>
                {
                    /// <summary>Constructs a new Publish request.</summary>
                    public PublishRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM ContainerVersion's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }

                    /// <summary>When provided, this fingerprint must match the fingerprint of the container version in
                    /// storage.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "publish";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:publish";

                    /// <summary>Initializes Publish parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/versions/[^/]+$",
                            });
                        RequestParameters.Add(
                            "fingerprint", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fingerprint",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Sets the latest version used for synchronization of workspaces when detecting conflicts and
                /// errors.</summary>
                /// <param name="path">GTM ContainerVersion's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</param>
                public virtual SetLatestRequest SetLatest(string path)
                {
                    return new SetLatestRequest(service, path);
                }

                /// <summary>Sets the latest version used for synchronization of workspaces when detecting conflicts and
                /// errors.</summary>
                public class SetLatestRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new SetLatest request.</summary>
                    public SetLatestRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM ContainerVersion's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "set_latest";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:set_latest";

                    /// <summary>Initializes SetLatest parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/versions/[^/]+$",
                            });
                    }

                }

                /// <summary>Undeletes a Container Version.</summary>
                /// <param name="path">GTM ContainerVersion's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</param>
                public virtual UndeleteRequest Undelete(string path)
                {
                    return new UndeleteRequest(service, path);
                }

                /// <summary>Undeletes a Container Version.</summary>
                public class UndeleteRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM ContainerVersion's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:undelete";

                    /// <summary>Initializes Undelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/versions/[^/]+$",
                            });
                    }

                }

                /// <summary>Updates a Container Version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="path">GTM ContainerVersion's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.ContainerVersion body, string path)
                {
                    return new UpdateRequest(service, body, path);
                }

                /// <summary>Updates a Container Version.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.ContainerVersion body, string path)
                        : base(service)
                    {
                        Path = path;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM ContainerVersion's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/versions/{version_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }

                    /// <summary>When provided, this fingerprint must match the fingerprint of the container version in
                    /// storage.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.ContainerVersion Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/versions/[^/]+$",
                            });
                        RequestParameters.Add(
                            "fingerprint", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fingerprint",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }
            }
            /// <summary>Gets the Workspaces resource.</summary>
            public virtual WorkspacesResource Workspaces { get; }

            /// <summary>The "workspaces" collection of methods.</summary>
            public class WorkspacesResource
            {
                private const string Resource = "workspaces";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public WorkspacesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    BuiltInVariables = new BuiltInVariablesResource(service);
                    Folders = new FoldersResource(service);
                    Tags = new TagsResource(service);
                    Templates = new TemplatesResource(service);
                    Triggers = new TriggersResource(service);
                    Variables = new VariablesResource(service);
                    Zones = new ZonesResource(service);

                }

                /// <summary>Gets the BuiltInVariables resource.</summary>
                public virtual BuiltInVariablesResource BuiltInVariables { get; }

                /// <summary>The "built_in_variables" collection of methods.</summary>
                public class BuiltInVariablesResource
                {
                    private const string Resource = "builtInVariables";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public BuiltInVariablesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates one or more GTM Built-In Variables.</summary>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual CreateRequest Create(string parent)
                    {
                        return new CreateRequest(service, parent);
                    }

                    /// <summary>Creates one or more GTM Built-In Variables.</summary>
                    public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.CreateBuiltInVariableResponse>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The types of built-in variables to enable.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<TypeEnum> Type { get; set; }

                        /// <summary>The types of built-in variables to enable.</summary>
                        public enum TypeEnum
                        {
                            [Google.Apis.Util.StringValueAttribute("builtInVariableTypeUnspecified")]
                            BuiltInVariableTypeUnspecified,
                            [Google.Apis.Util.StringValueAttribute("pageUrl")]
                            PageUrl,
                            [Google.Apis.Util.StringValueAttribute("pageHostname")]
                            PageHostname,
                            [Google.Apis.Util.StringValueAttribute("pagePath")]
                            PagePath,
                            [Google.Apis.Util.StringValueAttribute("referrer")]
                            Referrer,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("event")]
                            Event__,
                            [Google.Apis.Util.StringValueAttribute("clickElement")]
                            ClickElement,
                            [Google.Apis.Util.StringValueAttribute("clickClasses")]
                            ClickClasses,
                            [Google.Apis.Util.StringValueAttribute("clickId")]
                            ClickId,
                            [Google.Apis.Util.StringValueAttribute("clickTarget")]
                            ClickTarget,
                            [Google.Apis.Util.StringValueAttribute("clickUrl")]
                            ClickUrl,
                            [Google.Apis.Util.StringValueAttribute("clickText")]
                            ClickText,
                            [Google.Apis.Util.StringValueAttribute("firstPartyServingUrl")]
                            FirstPartyServingUrl,
                            [Google.Apis.Util.StringValueAttribute("formElement")]
                            FormElement,
                            [Google.Apis.Util.StringValueAttribute("formClasses")]
                            FormClasses,
                            [Google.Apis.Util.StringValueAttribute("formId")]
                            FormId,
                            [Google.Apis.Util.StringValueAttribute("formTarget")]
                            FormTarget,
                            [Google.Apis.Util.StringValueAttribute("formUrl")]
                            FormUrl,
                            [Google.Apis.Util.StringValueAttribute("formText")]
                            FormText,
                            [Google.Apis.Util.StringValueAttribute("errorMessage")]
                            ErrorMessage,
                            [Google.Apis.Util.StringValueAttribute("errorUrl")]
                            ErrorUrl,
                            [Google.Apis.Util.StringValueAttribute("errorLine")]
                            ErrorLine,
                            [Google.Apis.Util.StringValueAttribute("newHistoryUrl")]
                            NewHistoryUrl,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryUrl")]
                            OldHistoryUrl,
                            [Google.Apis.Util.StringValueAttribute("newHistoryFragment")]
                            NewHistoryFragment,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryFragment")]
                            OldHistoryFragment,
                            [Google.Apis.Util.StringValueAttribute("newHistoryState")]
                            NewHistoryState,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryState")]
                            OldHistoryState,
                            [Google.Apis.Util.StringValueAttribute("historySource")]
                            HistorySource,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("containerVersion")]
                            ContainerVersion,
                            [Google.Apis.Util.StringValueAttribute("debugMode")]
                            DebugMode,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("randomNumber")]
                            RandomNumber,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("containerId")]
                            ContainerId,
                            [Google.Apis.Util.StringValueAttribute("appId")]
                            AppId,
                            [Google.Apis.Util.StringValueAttribute("appName")]
                            AppName,
                            [Google.Apis.Util.StringValueAttribute("appVersionCode")]
                            AppVersionCode,
                            [Google.Apis.Util.StringValueAttribute("appVersionName")]
                            AppVersionName,
                            [Google.Apis.Util.StringValueAttribute("language")]
                            Language,
                            [Google.Apis.Util.StringValueAttribute("osVersion")]
                            OsVersion,
                            [Google.Apis.Util.StringValueAttribute("platform")]
                            Platform,
                            [Google.Apis.Util.StringValueAttribute("sdkVersion")]
                            SdkVersion,
                            [Google.Apis.Util.StringValueAttribute("deviceName")]
                            DeviceName,
                            [Google.Apis.Util.StringValueAttribute("resolution")]
                            Resolution,
                            [Google.Apis.Util.StringValueAttribute("advertiserId")]
                            AdvertiserId,
                            [Google.Apis.Util.StringValueAttribute("advertisingTrackingEnabled")]
                            AdvertisingTrackingEnabled,
                            [Google.Apis.Util.StringValueAttribute("htmlId")]
                            HtmlId,
                            [Google.Apis.Util.StringValueAttribute("environmentName")]
                            EnvironmentName,
                            [Google.Apis.Util.StringValueAttribute("ampBrowserLanguage")]
                            AmpBrowserLanguage,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalPath")]
                            AmpCanonicalPath,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalUrl")]
                            AmpCanonicalUrl,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalHost")]
                            AmpCanonicalHost,
                            [Google.Apis.Util.StringValueAttribute("ampReferrer")]
                            AmpReferrer,
                            [Google.Apis.Util.StringValueAttribute("ampTitle")]
                            AmpTitle,
                            [Google.Apis.Util.StringValueAttribute("ampClientId")]
                            AmpClientId,
                            [Google.Apis.Util.StringValueAttribute("ampClientTimezone")]
                            AmpClientTimezone,
                            [Google.Apis.Util.StringValueAttribute("ampClientTimestamp")]
                            AmpClientTimestamp,
                            [Google.Apis.Util.StringValueAttribute("ampClientScreenWidth")]
                            AmpClientScreenWidth,
                            [Google.Apis.Util.StringValueAttribute("ampClientScreenHeight")]
                            AmpClientScreenHeight,
                            [Google.Apis.Util.StringValueAttribute("ampClientScrollX")]
                            AmpClientScrollX,
                            [Google.Apis.Util.StringValueAttribute("ampClientScrollY")]
                            AmpClientScrollY,
                            [Google.Apis.Util.StringValueAttribute("ampClientMaxScrollX")]
                            AmpClientMaxScrollX,
                            [Google.Apis.Util.StringValueAttribute("ampClientMaxScrollY")]
                            AmpClientMaxScrollY,
                            [Google.Apis.Util.StringValueAttribute("ampTotalEngagedTime")]
                            AmpTotalEngagedTime,
                            [Google.Apis.Util.StringValueAttribute("ampPageViewId")]
                            AmpPageViewId,
                            [Google.Apis.Util.StringValueAttribute("ampPageLoadTime")]
                            AmpPageLoadTime,
                            [Google.Apis.Util.StringValueAttribute("ampPageDownloadTime")]
                            AmpPageDownloadTime,
                            [Google.Apis.Util.StringValueAttribute("ampGtmEvent")]
                            AmpGtmEvent,
                            [Google.Apis.Util.StringValueAttribute("eventName")]
                            EventName,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaign")]
                            FirebaseEventParameterCampaign,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignAclid")]
                            FirebaseEventParameterCampaignAclid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignAnid")]
                            FirebaseEventParameterCampaignAnid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignClickTimestamp")]
                            FirebaseEventParameterCampaignClickTimestamp,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignContent")]
                            FirebaseEventParameterCampaignContent,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignCp1")]
                            FirebaseEventParameterCampaignCp1,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignGclid")]
                            FirebaseEventParameterCampaignGclid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignSource")]
                            FirebaseEventParameterCampaignSource,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignTerm")]
                            FirebaseEventParameterCampaignTerm,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCurrency")]
                            FirebaseEventParameterCurrency,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterDynamicLinkAcceptTime")]
                            FirebaseEventParameterDynamicLinkAcceptTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterDynamicLinkLinkid")]
                            FirebaseEventParameterDynamicLinkLinkid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageDeviceTime")]
                            FirebaseEventParameterNotificationMessageDeviceTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageId")]
                            FirebaseEventParameterNotificationMessageId,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageName")]
                            FirebaseEventParameterNotificationMessageName,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageTime")]
                            FirebaseEventParameterNotificationMessageTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationTopic")]
                            FirebaseEventParameterNotificationTopic,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPreviousAppVersion")]
                            FirebaseEventParameterPreviousAppVersion,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPreviousOsVersion")]
                            FirebaseEventParameterPreviousOsVersion,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPrice")]
                            FirebaseEventParameterPrice,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterProductId")]
                            FirebaseEventParameterProductId,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterQuantity")]
                            FirebaseEventParameterQuantity,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterValue")]
                            FirebaseEventParameterValue,
                            [Google.Apis.Util.StringValueAttribute("videoProvider")]
                            VideoProvider,
                            [Google.Apis.Util.StringValueAttribute("videoUrl")]
                            VideoUrl,
                            [Google.Apis.Util.StringValueAttribute("videoTitle")]
                            VideoTitle,
                            [Google.Apis.Util.StringValueAttribute("videoDuration")]
                            VideoDuration,
                            [Google.Apis.Util.StringValueAttribute("videoPercent")]
                            VideoPercent,
                            [Google.Apis.Util.StringValueAttribute("videoVisible")]
                            VideoVisible,
                            [Google.Apis.Util.StringValueAttribute("videoStatus")]
                            VideoStatus,
                            [Google.Apis.Util.StringValueAttribute("videoCurrentTime")]
                            VideoCurrentTime,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthThreshold")]
                            ScrollDepthThreshold,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthUnits")]
                            ScrollDepthUnits,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthDirection")]
                            ScrollDepthDirection,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityRatio")]
                            ElementVisibilityRatio,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityTime")]
                            ElementVisibilityTime,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityFirstTime")]
                            ElementVisibilityFirstTime,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityRecentTime")]
                            ElementVisibilityRecentTime,
                            [Google.Apis.Util.StringValueAttribute("requestPath")]
                            RequestPath,
                            [Google.Apis.Util.StringValueAttribute("requestMethod")]
                            RequestMethod,
                            [Google.Apis.Util.StringValueAttribute("clientName")]
                            ClientName,
                            [Google.Apis.Util.StringValueAttribute("queryString")]
                            QueryString,
                        }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/built_in_variables";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "type", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "type",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Deletes one or more GTM Built-In Variables.</summary>
                    /// <param name="path">GTM BuiltInVariable's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/built_in_variables</param>
                    public virtual DeleteRequest Delete(string path)
                    {
                        return new DeleteRequest(service, path);
                    }

                    /// <summary>Deletes one or more GTM Built-In Variables.</summary>
                    public class DeleteRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM BuiltInVariable's API relative path. Example: accounts/{account_id}/containers/
                        /// {container_id}/workspaces/{workspace_id}/built_in_variables</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>The types of built-in variables to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<TypeEnum> Type { get; set; }

                        /// <summary>The types of built-in variables to delete.</summary>
                        public enum TypeEnum
                        {
                            [Google.Apis.Util.StringValueAttribute("builtInVariableTypeUnspecified")]
                            BuiltInVariableTypeUnspecified,
                            [Google.Apis.Util.StringValueAttribute("pageUrl")]
                            PageUrl,
                            [Google.Apis.Util.StringValueAttribute("pageHostname")]
                            PageHostname,
                            [Google.Apis.Util.StringValueAttribute("pagePath")]
                            PagePath,
                            [Google.Apis.Util.StringValueAttribute("referrer")]
                            Referrer,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("event")]
                            Event__,
                            [Google.Apis.Util.StringValueAttribute("clickElement")]
                            ClickElement,
                            [Google.Apis.Util.StringValueAttribute("clickClasses")]
                            ClickClasses,
                            [Google.Apis.Util.StringValueAttribute("clickId")]
                            ClickId,
                            [Google.Apis.Util.StringValueAttribute("clickTarget")]
                            ClickTarget,
                            [Google.Apis.Util.StringValueAttribute("clickUrl")]
                            ClickUrl,
                            [Google.Apis.Util.StringValueAttribute("clickText")]
                            ClickText,
                            [Google.Apis.Util.StringValueAttribute("firstPartyServingUrl")]
                            FirstPartyServingUrl,
                            [Google.Apis.Util.StringValueAttribute("formElement")]
                            FormElement,
                            [Google.Apis.Util.StringValueAttribute("formClasses")]
                            FormClasses,
                            [Google.Apis.Util.StringValueAttribute("formId")]
                            FormId,
                            [Google.Apis.Util.StringValueAttribute("formTarget")]
                            FormTarget,
                            [Google.Apis.Util.StringValueAttribute("formUrl")]
                            FormUrl,
                            [Google.Apis.Util.StringValueAttribute("formText")]
                            FormText,
                            [Google.Apis.Util.StringValueAttribute("errorMessage")]
                            ErrorMessage,
                            [Google.Apis.Util.StringValueAttribute("errorUrl")]
                            ErrorUrl,
                            [Google.Apis.Util.StringValueAttribute("errorLine")]
                            ErrorLine,
                            [Google.Apis.Util.StringValueAttribute("newHistoryUrl")]
                            NewHistoryUrl,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryUrl")]
                            OldHistoryUrl,
                            [Google.Apis.Util.StringValueAttribute("newHistoryFragment")]
                            NewHistoryFragment,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryFragment")]
                            OldHistoryFragment,
                            [Google.Apis.Util.StringValueAttribute("newHistoryState")]
                            NewHistoryState,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryState")]
                            OldHistoryState,
                            [Google.Apis.Util.StringValueAttribute("historySource")]
                            HistorySource,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("containerVersion")]
                            ContainerVersion,
                            [Google.Apis.Util.StringValueAttribute("debugMode")]
                            DebugMode,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("randomNumber")]
                            RandomNumber,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("containerId")]
                            ContainerId,
                            [Google.Apis.Util.StringValueAttribute("appId")]
                            AppId,
                            [Google.Apis.Util.StringValueAttribute("appName")]
                            AppName,
                            [Google.Apis.Util.StringValueAttribute("appVersionCode")]
                            AppVersionCode,
                            [Google.Apis.Util.StringValueAttribute("appVersionName")]
                            AppVersionName,
                            [Google.Apis.Util.StringValueAttribute("language")]
                            Language,
                            [Google.Apis.Util.StringValueAttribute("osVersion")]
                            OsVersion,
                            [Google.Apis.Util.StringValueAttribute("platform")]
                            Platform,
                            [Google.Apis.Util.StringValueAttribute("sdkVersion")]
                            SdkVersion,
                            [Google.Apis.Util.StringValueAttribute("deviceName")]
                            DeviceName,
                            [Google.Apis.Util.StringValueAttribute("resolution")]
                            Resolution,
                            [Google.Apis.Util.StringValueAttribute("advertiserId")]
                            AdvertiserId,
                            [Google.Apis.Util.StringValueAttribute("advertisingTrackingEnabled")]
                            AdvertisingTrackingEnabled,
                            [Google.Apis.Util.StringValueAttribute("htmlId")]
                            HtmlId,
                            [Google.Apis.Util.StringValueAttribute("environmentName")]
                            EnvironmentName,
                            [Google.Apis.Util.StringValueAttribute("ampBrowserLanguage")]
                            AmpBrowserLanguage,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalPath")]
                            AmpCanonicalPath,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalUrl")]
                            AmpCanonicalUrl,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalHost")]
                            AmpCanonicalHost,
                            [Google.Apis.Util.StringValueAttribute("ampReferrer")]
                            AmpReferrer,
                            [Google.Apis.Util.StringValueAttribute("ampTitle")]
                            AmpTitle,
                            [Google.Apis.Util.StringValueAttribute("ampClientId")]
                            AmpClientId,
                            [Google.Apis.Util.StringValueAttribute("ampClientTimezone")]
                            AmpClientTimezone,
                            [Google.Apis.Util.StringValueAttribute("ampClientTimestamp")]
                            AmpClientTimestamp,
                            [Google.Apis.Util.StringValueAttribute("ampClientScreenWidth")]
                            AmpClientScreenWidth,
                            [Google.Apis.Util.StringValueAttribute("ampClientScreenHeight")]
                            AmpClientScreenHeight,
                            [Google.Apis.Util.StringValueAttribute("ampClientScrollX")]
                            AmpClientScrollX,
                            [Google.Apis.Util.StringValueAttribute("ampClientScrollY")]
                            AmpClientScrollY,
                            [Google.Apis.Util.StringValueAttribute("ampClientMaxScrollX")]
                            AmpClientMaxScrollX,
                            [Google.Apis.Util.StringValueAttribute("ampClientMaxScrollY")]
                            AmpClientMaxScrollY,
                            [Google.Apis.Util.StringValueAttribute("ampTotalEngagedTime")]
                            AmpTotalEngagedTime,
                            [Google.Apis.Util.StringValueAttribute("ampPageViewId")]
                            AmpPageViewId,
                            [Google.Apis.Util.StringValueAttribute("ampPageLoadTime")]
                            AmpPageLoadTime,
                            [Google.Apis.Util.StringValueAttribute("ampPageDownloadTime")]
                            AmpPageDownloadTime,
                            [Google.Apis.Util.StringValueAttribute("ampGtmEvent")]
                            AmpGtmEvent,
                            [Google.Apis.Util.StringValueAttribute("eventName")]
                            EventName,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaign")]
                            FirebaseEventParameterCampaign,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignAclid")]
                            FirebaseEventParameterCampaignAclid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignAnid")]
                            FirebaseEventParameterCampaignAnid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignClickTimestamp")]
                            FirebaseEventParameterCampaignClickTimestamp,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignContent")]
                            FirebaseEventParameterCampaignContent,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignCp1")]
                            FirebaseEventParameterCampaignCp1,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignGclid")]
                            FirebaseEventParameterCampaignGclid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignSource")]
                            FirebaseEventParameterCampaignSource,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignTerm")]
                            FirebaseEventParameterCampaignTerm,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCurrency")]
                            FirebaseEventParameterCurrency,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterDynamicLinkAcceptTime")]
                            FirebaseEventParameterDynamicLinkAcceptTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterDynamicLinkLinkid")]
                            FirebaseEventParameterDynamicLinkLinkid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageDeviceTime")]
                            FirebaseEventParameterNotificationMessageDeviceTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageId")]
                            FirebaseEventParameterNotificationMessageId,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageName")]
                            FirebaseEventParameterNotificationMessageName,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageTime")]
                            FirebaseEventParameterNotificationMessageTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationTopic")]
                            FirebaseEventParameterNotificationTopic,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPreviousAppVersion")]
                            FirebaseEventParameterPreviousAppVersion,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPreviousOsVersion")]
                            FirebaseEventParameterPreviousOsVersion,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPrice")]
                            FirebaseEventParameterPrice,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterProductId")]
                            FirebaseEventParameterProductId,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterQuantity")]
                            FirebaseEventParameterQuantity,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterValue")]
                            FirebaseEventParameterValue,
                            [Google.Apis.Util.StringValueAttribute("videoProvider")]
                            VideoProvider,
                            [Google.Apis.Util.StringValueAttribute("videoUrl")]
                            VideoUrl,
                            [Google.Apis.Util.StringValueAttribute("videoTitle")]
                            VideoTitle,
                            [Google.Apis.Util.StringValueAttribute("videoDuration")]
                            VideoDuration,
                            [Google.Apis.Util.StringValueAttribute("videoPercent")]
                            VideoPercent,
                            [Google.Apis.Util.StringValueAttribute("videoVisible")]
                            VideoVisible,
                            [Google.Apis.Util.StringValueAttribute("videoStatus")]
                            VideoStatus,
                            [Google.Apis.Util.StringValueAttribute("videoCurrentTime")]
                            VideoCurrentTime,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthThreshold")]
                            ScrollDepthThreshold,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthUnits")]
                            ScrollDepthUnits,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthDirection")]
                            ScrollDepthDirection,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityRatio")]
                            ElementVisibilityRatio,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityTime")]
                            ElementVisibilityTime,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityFirstTime")]
                            ElementVisibilityFirstTime,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityRecentTime")]
                            ElementVisibilityRecentTime,
                            [Google.Apis.Util.StringValueAttribute("requestPath")]
                            RequestPath,
                            [Google.Apis.Util.StringValueAttribute("requestMethod")]
                            RequestMethod,
                            [Google.Apis.Util.StringValueAttribute("clientName")]
                            ClientName,
                            [Google.Apis.Util.StringValueAttribute("queryString")]
                            QueryString,
                        }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/built_in_variables$",
                                });
                            RequestParameters.Add(
                                "type", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "type",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Lists all the enabled Built-In Variables of a GTM Container.</summary>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all the enabled Built-In Variables of a GTM Container.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListEnabledBuiltInVariablesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/built_in_variables";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Reverts changes to a GTM Built-In Variables in a GTM Workspace.</summary>
                    /// <param name="path">GTM BuiltInVariable's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/built_in_variables</param>
                    public virtual RevertRequest Revert(string path)
                    {
                        return new RevertRequest(service, path);
                    }

                    /// <summary>Reverts changes to a GTM Built-In Variables in a GTM Workspace.</summary>
                    public class RevertRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.RevertBuiltInVariableResponse>
                    {
                        /// <summary>Constructs a new Revert request.</summary>
                        public RevertRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM BuiltInVariable's API relative path. Example: accounts/{account_id}/containers/
                        /// {container_id}/workspaces/{workspace_id}/built_in_variables</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>The type of built-in variable to revert.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<TypeEnum> Type { get; set; }

                        /// <summary>The type of built-in variable to revert.</summary>
                        public enum TypeEnum
                        {
                            [Google.Apis.Util.StringValueAttribute("builtInVariableTypeUnspecified")]
                            BuiltInVariableTypeUnspecified,
                            [Google.Apis.Util.StringValueAttribute("pageUrl")]
                            PageUrl,
                            [Google.Apis.Util.StringValueAttribute("pageHostname")]
                            PageHostname,
                            [Google.Apis.Util.StringValueAttribute("pagePath")]
                            PagePath,
                            [Google.Apis.Util.StringValueAttribute("referrer")]
                            Referrer,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("event")]
                            Event__,
                            [Google.Apis.Util.StringValueAttribute("clickElement")]
                            ClickElement,
                            [Google.Apis.Util.StringValueAttribute("clickClasses")]
                            ClickClasses,
                            [Google.Apis.Util.StringValueAttribute("clickId")]
                            ClickId,
                            [Google.Apis.Util.StringValueAttribute("clickTarget")]
                            ClickTarget,
                            [Google.Apis.Util.StringValueAttribute("clickUrl")]
                            ClickUrl,
                            [Google.Apis.Util.StringValueAttribute("clickText")]
                            ClickText,
                            [Google.Apis.Util.StringValueAttribute("firstPartyServingUrl")]
                            FirstPartyServingUrl,
                            [Google.Apis.Util.StringValueAttribute("formElement")]
                            FormElement,
                            [Google.Apis.Util.StringValueAttribute("formClasses")]
                            FormClasses,
                            [Google.Apis.Util.StringValueAttribute("formId")]
                            FormId,
                            [Google.Apis.Util.StringValueAttribute("formTarget")]
                            FormTarget,
                            [Google.Apis.Util.StringValueAttribute("formUrl")]
                            FormUrl,
                            [Google.Apis.Util.StringValueAttribute("formText")]
                            FormText,
                            [Google.Apis.Util.StringValueAttribute("errorMessage")]
                            ErrorMessage,
                            [Google.Apis.Util.StringValueAttribute("errorUrl")]
                            ErrorUrl,
                            [Google.Apis.Util.StringValueAttribute("errorLine")]
                            ErrorLine,
                            [Google.Apis.Util.StringValueAttribute("newHistoryUrl")]
                            NewHistoryUrl,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryUrl")]
                            OldHistoryUrl,
                            [Google.Apis.Util.StringValueAttribute("newHistoryFragment")]
                            NewHistoryFragment,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryFragment")]
                            OldHistoryFragment,
                            [Google.Apis.Util.StringValueAttribute("newHistoryState")]
                            NewHistoryState,
                            [Google.Apis.Util.StringValueAttribute("oldHistoryState")]
                            OldHistoryState,
                            [Google.Apis.Util.StringValueAttribute("historySource")]
                            HistorySource,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("containerVersion")]
                            ContainerVersion,
                            [Google.Apis.Util.StringValueAttribute("debugMode")]
                            DebugMode,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("randomNumber")]
                            RandomNumber,
                            /// <summary>For web or mobile.</summary>
                            [Google.Apis.Util.StringValueAttribute("containerId")]
                            ContainerId,
                            [Google.Apis.Util.StringValueAttribute("appId")]
                            AppId,
                            [Google.Apis.Util.StringValueAttribute("appName")]
                            AppName,
                            [Google.Apis.Util.StringValueAttribute("appVersionCode")]
                            AppVersionCode,
                            [Google.Apis.Util.StringValueAttribute("appVersionName")]
                            AppVersionName,
                            [Google.Apis.Util.StringValueAttribute("language")]
                            Language,
                            [Google.Apis.Util.StringValueAttribute("osVersion")]
                            OsVersion,
                            [Google.Apis.Util.StringValueAttribute("platform")]
                            Platform,
                            [Google.Apis.Util.StringValueAttribute("sdkVersion")]
                            SdkVersion,
                            [Google.Apis.Util.StringValueAttribute("deviceName")]
                            DeviceName,
                            [Google.Apis.Util.StringValueAttribute("resolution")]
                            Resolution,
                            [Google.Apis.Util.StringValueAttribute("advertiserId")]
                            AdvertiserId,
                            [Google.Apis.Util.StringValueAttribute("advertisingTrackingEnabled")]
                            AdvertisingTrackingEnabled,
                            [Google.Apis.Util.StringValueAttribute("htmlId")]
                            HtmlId,
                            [Google.Apis.Util.StringValueAttribute("environmentName")]
                            EnvironmentName,
                            [Google.Apis.Util.StringValueAttribute("ampBrowserLanguage")]
                            AmpBrowserLanguage,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalPath")]
                            AmpCanonicalPath,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalUrl")]
                            AmpCanonicalUrl,
                            [Google.Apis.Util.StringValueAttribute("ampCanonicalHost")]
                            AmpCanonicalHost,
                            [Google.Apis.Util.StringValueAttribute("ampReferrer")]
                            AmpReferrer,
                            [Google.Apis.Util.StringValueAttribute("ampTitle")]
                            AmpTitle,
                            [Google.Apis.Util.StringValueAttribute("ampClientId")]
                            AmpClientId,
                            [Google.Apis.Util.StringValueAttribute("ampClientTimezone")]
                            AmpClientTimezone,
                            [Google.Apis.Util.StringValueAttribute("ampClientTimestamp")]
                            AmpClientTimestamp,
                            [Google.Apis.Util.StringValueAttribute("ampClientScreenWidth")]
                            AmpClientScreenWidth,
                            [Google.Apis.Util.StringValueAttribute("ampClientScreenHeight")]
                            AmpClientScreenHeight,
                            [Google.Apis.Util.StringValueAttribute("ampClientScrollX")]
                            AmpClientScrollX,
                            [Google.Apis.Util.StringValueAttribute("ampClientScrollY")]
                            AmpClientScrollY,
                            [Google.Apis.Util.StringValueAttribute("ampClientMaxScrollX")]
                            AmpClientMaxScrollX,
                            [Google.Apis.Util.StringValueAttribute("ampClientMaxScrollY")]
                            AmpClientMaxScrollY,
                            [Google.Apis.Util.StringValueAttribute("ampTotalEngagedTime")]
                            AmpTotalEngagedTime,
                            [Google.Apis.Util.StringValueAttribute("ampPageViewId")]
                            AmpPageViewId,
                            [Google.Apis.Util.StringValueAttribute("ampPageLoadTime")]
                            AmpPageLoadTime,
                            [Google.Apis.Util.StringValueAttribute("ampPageDownloadTime")]
                            AmpPageDownloadTime,
                            [Google.Apis.Util.StringValueAttribute("ampGtmEvent")]
                            AmpGtmEvent,
                            [Google.Apis.Util.StringValueAttribute("eventName")]
                            EventName,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaign")]
                            FirebaseEventParameterCampaign,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignAclid")]
                            FirebaseEventParameterCampaignAclid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignAnid")]
                            FirebaseEventParameterCampaignAnid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignClickTimestamp")]
                            FirebaseEventParameterCampaignClickTimestamp,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignContent")]
                            FirebaseEventParameterCampaignContent,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignCp1")]
                            FirebaseEventParameterCampaignCp1,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignGclid")]
                            FirebaseEventParameterCampaignGclid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignSource")]
                            FirebaseEventParameterCampaignSource,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCampaignTerm")]
                            FirebaseEventParameterCampaignTerm,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterCurrency")]
                            FirebaseEventParameterCurrency,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterDynamicLinkAcceptTime")]
                            FirebaseEventParameterDynamicLinkAcceptTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterDynamicLinkLinkid")]
                            FirebaseEventParameterDynamicLinkLinkid,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageDeviceTime")]
                            FirebaseEventParameterNotificationMessageDeviceTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageId")]
                            FirebaseEventParameterNotificationMessageId,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageName")]
                            FirebaseEventParameterNotificationMessageName,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationMessageTime")]
                            FirebaseEventParameterNotificationMessageTime,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterNotificationTopic")]
                            FirebaseEventParameterNotificationTopic,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPreviousAppVersion")]
                            FirebaseEventParameterPreviousAppVersion,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPreviousOsVersion")]
                            FirebaseEventParameterPreviousOsVersion,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterPrice")]
                            FirebaseEventParameterPrice,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterProductId")]
                            FirebaseEventParameterProductId,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterQuantity")]
                            FirebaseEventParameterQuantity,
                            [Google.Apis.Util.StringValueAttribute("firebaseEventParameterValue")]
                            FirebaseEventParameterValue,
                            [Google.Apis.Util.StringValueAttribute("videoProvider")]
                            VideoProvider,
                            [Google.Apis.Util.StringValueAttribute("videoUrl")]
                            VideoUrl,
                            [Google.Apis.Util.StringValueAttribute("videoTitle")]
                            VideoTitle,
                            [Google.Apis.Util.StringValueAttribute("videoDuration")]
                            VideoDuration,
                            [Google.Apis.Util.StringValueAttribute("videoPercent")]
                            VideoPercent,
                            [Google.Apis.Util.StringValueAttribute("videoVisible")]
                            VideoVisible,
                            [Google.Apis.Util.StringValueAttribute("videoStatus")]
                            VideoStatus,
                            [Google.Apis.Util.StringValueAttribute("videoCurrentTime")]
                            VideoCurrentTime,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthThreshold")]
                            ScrollDepthThreshold,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthUnits")]
                            ScrollDepthUnits,
                            [Google.Apis.Util.StringValueAttribute("scrollDepthDirection")]
                            ScrollDepthDirection,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityRatio")]
                            ElementVisibilityRatio,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityTime")]
                            ElementVisibilityTime,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityFirstTime")]
                            ElementVisibilityFirstTime,
                            [Google.Apis.Util.StringValueAttribute("elementVisibilityRecentTime")]
                            ElementVisibilityRecentTime,
                            [Google.Apis.Util.StringValueAttribute("requestPath")]
                            RequestPath,
                            [Google.Apis.Util.StringValueAttribute("requestMethod")]
                            RequestMethod,
                            [Google.Apis.Util.StringValueAttribute("clientName")]
                            ClientName,
                            [Google.Apis.Util.StringValueAttribute("queryString")]
                            QueryString,
                        }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "revert";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}/built_in_variables:revert";

                        /// <summary>Initializes Revert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "type", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "type",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }
                /// <summary>Gets the Folders resource.</summary>
                public virtual FoldersResource Folders { get; }

                /// <summary>The "folders" collection of methods.</summary>
                public class FoldersResource
                {
                    private const string Resource = "folders";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FoldersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates a GTM Folder.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Folder body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a GTM Folder.</summary>
                    public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Folder>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Folder body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Folder Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/folders";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes a GTM Folder.</summary>
                    /// <param name="path">GTM Folder's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/folders/{folder_id}</param>
                    public virtual DeleteRequest Delete(string path)
                    {
                        return new DeleteRequest(service, path);
                    }

                    /// <summary>Deletes a GTM Folder.</summary>
                    public class DeleteRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Folder's API relative path. Example: accounts/{account_id}/containers/{containe
                        /// r_id}/workspaces/{workspace_id}/folders/{folder_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/folders/[^/]+$",
                                });
                        }

                    }

                    /// <summary>List all entities in a GTM Folder.</summary>
                    /// <param name="path">GTM Folder's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/folders/{folder_id}</param>
                    public virtual EntitiesRequest Entities(string path)
                    {
                        return new EntitiesRequest(service, path);
                    }

                    /// <summary>List all entities in a GTM Folder.</summary>
                    public class EntitiesRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.FolderEntities>
                    {
                        /// <summary>Constructs a new Entities request.</summary>
                        public EntitiesRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Folder's API relative path. Example: accounts/{account_id}/containers/{containe
                        /// r_id}/workspaces/{workspace_id}/folders/{folder_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "entities";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:entities";

                        /// <summary>Initializes Entities parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/folders/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Gets a GTM Folder.</summary>
                    /// <param name="path">GTM Folder's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/folders/{folder_id}</param>
                    public virtual GetRequest Get(string path)
                    {
                        return new GetRequest(service, path);
                    }

                    /// <summary>Gets a GTM Folder.</summary>
                    public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Folder>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Folder's API relative path. Example: accounts/{account_id}/containers/{containe
                        /// r_id}/workspaces/{workspace_id}/folders/{folder_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/folders/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Lists all GTM Folders of a Container.</summary>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all GTM Folders of a Container.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListFoldersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/folders";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Moves entities to a GTM Folder.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="path">GTM Folder's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/folders/{folder_id}</param>
                    public virtual MoveEntitiesToFolderRequest MoveEntitiesToFolder(Google.Apis.TagManager.v2.Data.Folder body, string path)
                    {
                        return new MoveEntitiesToFolderRequest(service, body, path);
                    }

                    /// <summary>Moves entities to a GTM Folder.</summary>
                    public class MoveEntitiesToFolderRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new MoveEntitiesToFolder request.</summary>
                        public MoveEntitiesToFolderRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Folder body, string path)
                            : base(service)
                        {
                            Path = path;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Folder's API relative path. Example: accounts/{account_id}/containers/{containe
                        /// r_id}/workspaces/{workspace_id}/folders/{folder_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>The tags to be moved to the folder.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("tagId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> TagId { get; set; }

                        /// <summary>The triggers to be moved to the folder.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> TriggerId { get; set; }

                        /// <summary>The variables to be moved to the folder.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("variableId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> VariableId { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Folder Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "move_entities_to_folder";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:move_entities_to_folder";

                        /// <summary>Initializes MoveEntitiesToFolder parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/folders/[^/]+$",
                                });
                            RequestParameters.Add(
                                "tagId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "tagId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "triggerId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "triggerId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "variableId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "variableId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Reverts changes to a GTM Folder in a GTM Workspace.</summary>
                    /// <param name="path">GTM Folder's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/folders/{folder_id}</param>
                    public virtual RevertRequest Revert(string path)
                    {
                        return new RevertRequest(service, path);
                    }

                    /// <summary>Reverts changes to a GTM Folder in a GTM Workspace.</summary>
                    public class RevertRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.RevertFolderResponse>
                    {
                        /// <summary>Constructs a new Revert request.</summary>
                        public RevertRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Folder's API relative path. Example: accounts/{account_id}/containers/{containe
                        /// r_id}/workspaces/{workspace_id}/folders/{folder_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the tag in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "revert";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:revert";

                        /// <summary>Initializes Revert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/folders/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Updates a GTM Folder.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="path">GTM Folder's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/folders/{folder_id}</param>
                    public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Folder body, string path)
                    {
                        return new UpdateRequest(service, body, path);
                    }

                    /// <summary>Updates a GTM Folder.</summary>
                    public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Folder>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Folder body, string path)
                            : base(service)
                        {
                            Path = path;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Folder's API relative path. Example: accounts/{account_id}/containers/{containe
                        /// r_id}/workspaces/{workspace_id}/folders/{folder_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the folder in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Folder Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/folders/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }
                /// <summary>Gets the Tags resource.</summary>
                public virtual TagsResource Tags { get; }

                /// <summary>The "tags" collection of methods.</summary>
                public class TagsResource
                {
                    private const string Resource = "tags";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TagsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates a GTM Tag.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Tag body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a GTM Tag.</summary>
                    public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Tag>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Tag body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Tag Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/tags";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes a GTM Tag.</summary>
                    /// <param name="path">GTM Tag's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/tags/{tag_id}</param>
                    public virtual DeleteRequest Delete(string path)
                    {
                        return new DeleteRequest(service, path);
                    }

                    /// <summary>Deletes a GTM Tag.</summary>
                    public class DeleteRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Tag's API relative path. Example: accounts/{account_id}/containers/{container_i
                        /// d}/workspaces/{workspace_id}/tags/{tag_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/tags/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Gets a GTM Tag.</summary>
                    /// <param name="path">GTM Tag's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/tags/{tag_id}</param>
                    public virtual GetRequest Get(string path)
                    {
                        return new GetRequest(service, path);
                    }

                    /// <summary>Gets a GTM Tag.</summary>
                    public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Tag>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Tag's API relative path. Example: accounts/{account_id}/containers/{container_i
                        /// d}/workspaces/{workspace_id}/tags/{tag_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/tags/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Lists all GTM Tags of a Container.</summary>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all GTM Tags of a Container.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListTagsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/tags";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Reverts changes to a GTM Tag in a GTM Workspace.</summary>
                    /// <param name="path">GTM Tag's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/tags/{tag_id}</param>
                    public virtual RevertRequest Revert(string path)
                    {
                        return new RevertRequest(service, path);
                    }

                    /// <summary>Reverts changes to a GTM Tag in a GTM Workspace.</summary>
                    public class RevertRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.RevertTagResponse>
                    {
                        /// <summary>Constructs a new Revert request.</summary>
                        public RevertRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Tag's API relative path. Example: accounts/{account_id}/containers/{container_i
                        /// d}/workspaces/{workspace_id}/tags/{tag_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of thetag in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "revert";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:revert";

                        /// <summary>Initializes Revert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/tags/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Updates a GTM Tag.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="path">GTM Tag's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/tags/{tag_id}</param>
                    public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Tag body, string path)
                    {
                        return new UpdateRequest(service, body, path);
                    }

                    /// <summary>Updates a GTM Tag.</summary>
                    public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Tag>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Tag body, string path)
                            : base(service)
                        {
                            Path = path;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Tag's API relative path. Example: accounts/{account_id}/containers/{container_i
                        /// d}/workspaces/{workspace_id}/tags/{tag_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the tag in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Tag Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/tags/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }
                /// <summary>Gets the Templates resource.</summary>
                public virtual TemplatesResource Templates { get; }

                /// <summary>The "templates" collection of methods.</summary>
                public class TemplatesResource
                {
                    private const string Resource = "templates";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TemplatesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates a GTM Custom Template.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.CustomTemplate body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a GTM Custom Template.</summary>
                    public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.CustomTemplate>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.CustomTemplate body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.CustomTemplate Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/templates";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes a GTM Template.</summary>
                    /// <param name="path">GTM Custom Template's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/templates/{template_id}</param>
                    public virtual DeleteRequest Delete(string path)
                    {
                        return new DeleteRequest(service, path);
                    }

                    /// <summary>Deletes a GTM Template.</summary>
                    public class DeleteRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Custom Template's API relative path. Example: accounts/{account_id}/containers/
                        /// {container_id}/workspaces/{workspace_id}/templates/{template_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/templates/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Gets a GTM Template.</summary>
                    /// <param name="path">GTM Custom Template's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/templates/{template_id}</param>
                    public virtual GetRequest Get(string path)
                    {
                        return new GetRequest(service, path);
                    }

                    /// <summary>Gets a GTM Template.</summary>
                    public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.CustomTemplate>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Custom Template's API relative path. Example: accounts/{account_id}/containers/
                        /// {container_id}/workspaces/{workspace_id}/templates/{template_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/templates/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Lists all GTM Templates of a GTM container workspace.</summary>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all GTM Templates of a GTM container workspace.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListTemplatesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/templates";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Reverts changes to a GTM Template in a GTM Workspace.</summary>
                    /// <param name="path">GTM Custom Template's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/templates/{template_id}</param>
                    public virtual RevertRequest Revert(string path)
                    {
                        return new RevertRequest(service, path);
                    }

                    /// <summary>Reverts changes to a GTM Template in a GTM Workspace.</summary>
                    public class RevertRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.RevertTemplateResponse>
                    {
                        /// <summary>Constructs a new Revert request.</summary>
                        public RevertRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Custom Template's API relative path. Example: accounts/{account_id}/containers/
                        /// {container_id}/workspaces/{workspace_id}/templates/{template_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the template in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "revert";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:revert";

                        /// <summary>Initializes Revert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/templates/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Updates a GTM Template.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="path">GTM Custom Template's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/templates/{template_id}</param>
                    public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.CustomTemplate body, string path)
                    {
                        return new UpdateRequest(service, body, path);
                    }

                    /// <summary>Updates a GTM Template.</summary>
                    public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.CustomTemplate>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.CustomTemplate body, string path)
                            : base(service)
                        {
                            Path = path;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Custom Template's API relative path. Example: accounts/{account_id}/containers/
                        /// {container_id}/workspaces/{workspace_id}/templates/{template_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the templates in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.CustomTemplate Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/templates/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }
                /// <summary>Gets the Triggers resource.</summary>
                public virtual TriggersResource Triggers { get; }

                /// <summary>The "triggers" collection of methods.</summary>
                public class TriggersResource
                {
                    private const string Resource = "triggers";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public TriggersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates a GTM Trigger.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">GTM Workspaces's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Trigger body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a GTM Trigger.</summary>
                    public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Trigger>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Trigger body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Workspaces's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Trigger Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/triggers";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes a GTM Trigger.</summary>
                    /// <param name="path">GTM Trigger's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/triggers/{trigger_id}</param>
                    public virtual DeleteRequest Delete(string path)
                    {
                        return new DeleteRequest(service, path);
                    }

                    /// <summary>Deletes a GTM Trigger.</summary>
                    public class DeleteRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Trigger's API relative path. Example: accounts/{account_id}/containers/{contain
                        /// er_id}/workspaces/{workspace_id}/triggers/{trigger_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/triggers/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Gets a GTM Trigger.</summary>
                    /// <param name="path">GTM Trigger's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/triggers/{trigger_id}</param>
                    public virtual GetRequest Get(string path)
                    {
                        return new GetRequest(service, path);
                    }

                    /// <summary>Gets a GTM Trigger.</summary>
                    public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Trigger>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Trigger's API relative path. Example: accounts/{account_id}/containers/{contain
                        /// er_id}/workspaces/{workspace_id}/triggers/{trigger_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/triggers/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Lists all GTM Triggers of a Container.</summary>
                    /// <param name="parent">GTM Workspaces's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all GTM Triggers of a Container.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListTriggersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspaces's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/triggers";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Reverts changes to a GTM Trigger in a GTM Workspace.</summary>
                    /// <param name="path">GTM Trigger's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/triggers/{trigger_id}</param>
                    public virtual RevertRequest Revert(string path)
                    {
                        return new RevertRequest(service, path);
                    }

                    /// <summary>Reverts changes to a GTM Trigger in a GTM Workspace.</summary>
                    public class RevertRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.RevertTriggerResponse>
                    {
                        /// <summary>Constructs a new Revert request.</summary>
                        public RevertRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Trigger's API relative path. Example: accounts/{account_id}/containers/{contain
                        /// er_id}/workspaces/{workspace_id}/triggers/{trigger_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the trigger in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "revert";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:revert";

                        /// <summary>Initializes Revert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/triggers/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Updates a GTM Trigger.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="path">GTM Trigger's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/triggers/{trigger_id}</param>
                    public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Trigger body, string path)
                    {
                        return new UpdateRequest(service, body, path);
                    }

                    /// <summary>Updates a GTM Trigger.</summary>
                    public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Trigger>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Trigger body, string path)
                            : base(service)
                        {
                            Path = path;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Trigger's API relative path. Example: accounts/{account_id}/containers/{contain
                        /// er_id}/workspaces/{workspace_id}/triggers/{trigger_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the trigger in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Trigger Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/triggers/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }
                /// <summary>Gets the Variables resource.</summary>
                public virtual VariablesResource Variables { get; }

                /// <summary>The "variables" collection of methods.</summary>
                public class VariablesResource
                {
                    private const string Resource = "variables";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public VariablesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates a GTM Variable.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Variable body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a GTM Variable.</summary>
                    public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Variable>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Variable body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Variable Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/variables";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes a GTM Variable.</summary>
                    /// <param name="path">GTM Variable's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/variables/{variable_id}</param>
                    public virtual DeleteRequest Delete(string path)
                    {
                        return new DeleteRequest(service, path);
                    }

                    /// <summary>Deletes a GTM Variable.</summary>
                    public class DeleteRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Variable's API relative path. Example: accounts/{account_id}/containers/{contai
                        /// ner_id}/workspaces/{workspace_id}/variables/{variable_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/variables/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Gets a GTM Variable.</summary>
                    /// <param name="path">GTM Variable's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/variables/{variable_id}</param>
                    public virtual GetRequest Get(string path)
                    {
                        return new GetRequest(service, path);
                    }

                    /// <summary>Gets a GTM Variable.</summary>
                    public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Variable>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Variable's API relative path. Example: accounts/{account_id}/containers/{contai
                        /// ner_id}/workspaces/{workspace_id}/variables/{variable_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/variables/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Lists all GTM Variables of a Container.</summary>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all GTM Variables of a Container.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListVariablesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/variables";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Reverts changes to a GTM Variable in a GTM Workspace.</summary>
                    /// <param name="path">GTM Variable's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/variables/{variable_id}</param>
                    public virtual RevertRequest Revert(string path)
                    {
                        return new RevertRequest(service, path);
                    }

                    /// <summary>Reverts changes to a GTM Variable in a GTM Workspace.</summary>
                    public class RevertRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.RevertVariableResponse>
                    {
                        /// <summary>Constructs a new Revert request.</summary>
                        public RevertRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Variable's API relative path. Example: accounts/{account_id}/containers/{contai
                        /// ner_id}/workspaces/{workspace_id}/variables/{variable_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the variable in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "revert";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:revert";

                        /// <summary>Initializes Revert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/variables/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Updates a GTM Variable.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="path">GTM Variable's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/variables/{variable_id}</param>
                    public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Variable body, string path)
                    {
                        return new UpdateRequest(service, body, path);
                    }

                    /// <summary>Updates a GTM Variable.</summary>
                    public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Variable>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Variable body, string path)
                            : base(service)
                        {
                            Path = path;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Variable's API relative path. Example: accounts/{account_id}/containers/{contai
                        /// ner_id}/workspaces/{workspace_id}/variables/{variable_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the variable in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Variable Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/variables/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }
                /// <summary>Gets the Zones resource.</summary>
                public virtual ZonesResource Zones { get; }

                /// <summary>The "zones" collection of methods.</summary>
                public class ZonesResource
                {
                    private const string Resource = "zones";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ZonesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates a GTM Zone.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Zone body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a GTM Zone.</summary>
                    public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Zone>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Zone body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Zone Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/zones";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes a GTM Zone.</summary>
                    /// <param name="path">GTM Zone's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/zones/{zone_id}</param>
                    public virtual DeleteRequest Delete(string path)
                    {
                        return new DeleteRequest(service, path);
                    }

                    /// <summary>Deletes a GTM Zone.</summary>
                    public class DeleteRequest : TagManagerBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Zone's API relative path. Example: accounts/{account_id}/containers/{container_
                        /// id}/workspaces/{workspace_id}/zones/{zone_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/zones/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Gets a GTM Zone.</summary>
                    /// <param name="path">GTM Zone's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/zones/{zone_id}</param>
                    public virtual GetRequest Get(string path)
                    {
                        return new GetRequest(service, path);
                    }

                    /// <summary>Gets a GTM Zone.</summary>
                    public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Zone>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Zone's API relative path. Example: accounts/{account_id}/containers/{container_
                        /// id}/workspaces/{workspace_id}/zones/{zone_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/zones/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Lists all GTM Zones of a GTM container workspace.</summary>
                    /// <param name="parent">GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all GTM Zones of a GTM container workspace.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListZonesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>GTM Workspace's API relative path. Example:
                        /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Continuation token for fetching the next page of results.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+parent}/zones";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                                });
                            RequestParameters.Add(
                                "pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Reverts changes to a GTM Zone in a GTM Workspace.</summary>
                    /// <param name="path">GTM Zone's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/zones/{zone_id}</param>
                    public virtual RevertRequest Revert(string path)
                    {
                        return new RevertRequest(service, path);
                    }

                    /// <summary>Reverts changes to a GTM Zone in a GTM Workspace.</summary>
                    public class RevertRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.RevertZoneResponse>
                    {
                        /// <summary>Constructs a new Revert request.</summary>
                        public RevertRequest(Google.Apis.Services.IClientService service, string path)
                            : base(service)
                        {
                            Path = path;
                            InitParameters();
                        }


                        /// <summary>GTM Zone's API relative path. Example: accounts/{account_id}/containers/{container_
                        /// id}/workspaces/{workspace_id}/zones/{zone_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the zone in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "revert";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}:revert";

                        /// <summary>Initializes Revert parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/zones/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Updates a GTM Zone.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="path">GTM Zone's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}/zones/{zone_id}</param>
                    public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Zone body, string path)
                    {
                        return new UpdateRequest(service, body, path);
                    }

                    /// <summary>Updates a GTM Zone.</summary>
                    public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Zone>
                    {
                        /// <summary>Constructs a new Update request.</summary>
                        public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Zone body, string path)
                            : base(service)
                        {
                            Path = path;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>GTM Zone's API relative path. Example: accounts/{account_id}/containers/{container_
                        /// id}/workspaces/{workspace_id}/zones/{zone_id}</summary>
                        [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Path { get; private set; }

                        /// <summary>When provided, this fingerprint must match the fingerprint of the zone in
                        /// storage.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Fingerprint { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.TagManager.v2.Data.Zone Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "update";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PUT";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v2/{+path}";

                        /// <summary>Initializes Update parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "path", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "path",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+/zones/[^/]+$",
                                });
                            RequestParameters.Add(
                                "fingerprint", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fingerprint",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }
                }

                /// <summary>Creates a Workspace.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">GTM parent Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Workspace body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a Workspace.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Workspace>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Workspace body, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM parent Container's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.Workspace Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+parent}/workspaces";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                            });
                    }

                }

                /// <summary>Creates a Container Version from the entities present in the workspace, deletes the
                /// workspace, and sets the base container version to the newly created version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual CreateVersionRequest CreateVersion(Google.Apis.TagManager.v2.Data.CreateContainerVersionRequestVersionOptions body, string path)
                {
                    return new CreateVersionRequest(service, body, path);
                }

                /// <summary>Creates a Container Version from the entities present in the workspace, deletes the
                /// workspace, and sets the base container version to the newly created version.</summary>
                public class CreateVersionRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.CreateContainerVersionResponse>
                {
                    /// <summary>Constructs a new CreateVersion request.</summary>
                    public CreateVersionRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.CreateContainerVersionRequestVersionOptions body, string path)
                        : base(service)
                    {
                        Path = path;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.CreateContainerVersionRequestVersionOptions Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "create_version";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:create_version";

                    /// <summary>Initializes CreateVersion parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                    }

                }

                /// <summary>Deletes a Workspace.</summary>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual DeleteRequest Delete(string path)
                {
                    return new DeleteRequest(service, path);
                }

                /// <summary>Deletes a Workspace.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                    }

                }

                /// <summary>Gets a Workspace.</summary>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual GetRequest Get(string path)
                {
                    return new GetRequest(service, path);
                }

                /// <summary>Gets a Workspace.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Workspace>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                    }

                }

                /// <summary>Finds conflicting and modified entities in the workspace.</summary>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual GetStatusRequest GetStatus(string path)
                {
                    return new GetStatusRequest(service, path);
                }

                /// <summary>Finds conflicting and modified entities in the workspace.</summary>
                public class GetStatusRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.GetWorkspaceStatusResponse>
                {
                    /// <summary>Constructs a new GetStatus request.</summary>
                    public GetStatusRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "getStatus";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}/status";

                    /// <summary>Initializes GetStatus parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                    }

                }

                /// <summary>Lists all Workspaces that belong to a GTM Container.</summary>
                /// <param name="parent">GTM parent Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all Workspaces that belong to a GTM Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListWorkspacesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>GTM parent Container's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Continuation token for fetching the next page of results.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+parent}/workspaces";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                            });
                        RequestParameters.Add(
                            "pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Quick previews a workspace by creating a fake container version from all entities in the
                /// provided workspace.</summary>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual QuickPreviewRequest QuickPreview(string path)
                {
                    return new QuickPreviewRequest(service, path);
                }

                /// <summary>Quick previews a workspace by creating a fake container version from all entities in the
                /// provided workspace.</summary>
                public class QuickPreviewRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.QuickPreviewResponse>
                {
                    /// <summary>Constructs a new QuickPreview request.</summary>
                    public QuickPreviewRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "quick_preview";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:quick_preview";

                    /// <summary>Initializes QuickPreview parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                    }

                }

                /// <summary>Resolves a merge conflict for a workspace entity by updating it to the resolved entity
                /// passed in the request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual ResolveConflictRequest ResolveConflict(Google.Apis.TagManager.v2.Data.Entity body, string path)
                {
                    return new ResolveConflictRequest(service, body, path);
                }

                /// <summary>Resolves a merge conflict for a workspace entity by updating it to the resolved entity
                /// passed in the request.</summary>
                public class ResolveConflictRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new ResolveConflict request.</summary>
                    public ResolveConflictRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Entity body, string path)
                        : base(service)
                    {
                        Path = path;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }

                    /// <summary>When provided, this fingerprint must match the fingerprint of the entity_in_workspace
                    /// in the merge conflict.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.Entity Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "resolve_conflict";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:resolve_conflict";

                    /// <summary>Initializes ResolveConflict parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                        RequestParameters.Add(
                            "fingerprint", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fingerprint",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Syncs a workspace to the latest container version by updating all unmodified workspace
                /// entities and displaying conflicts for modified entities.</summary>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual SyncRequest Sync(string path)
                {
                    return new SyncRequest(service, path);
                }

                /// <summary>Syncs a workspace to the latest container version by updating all unmodified workspace
                /// entities and displaying conflicts for modified entities.</summary>
                public class SyncRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.SyncWorkspaceResponse>
                {
                    /// <summary>Constructs a new Sync request.</summary>
                    public SyncRequest(Google.Apis.Services.IClientService service, string path)
                        : base(service)
                    {
                        Path = path;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "sync";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}:sync";

                    /// <summary>Initializes Sync parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                    }

                }

                /// <summary>Updates a Workspace.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="path">GTM Workspace's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Workspace body, string path)
                {
                    return new UpdateRequest(service, body, path);
                }

                /// <summary>Updates a Workspace.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Workspace>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Workspace body, string path)
                        : base(service)
                    {
                        Path = path;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>GTM Workspace's API relative path. Example:
                    /// accounts/{account_id}/containers/{container_id}/workspaces/{workspace_id}</summary>
                    [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Path { get; private set; }

                    /// <summary>When provided, this fingerprint must match the fingerprint of the workspace in
                    /// storage.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v2.Data.Workspace Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v2/{+path}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "path", new Google.Apis.Discovery.Parameter
                            {
                                Name = "path",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^accounts/[^/]+/containers/[^/]+/workspaces/[^/]+$",
                            });
                        RequestParameters.Add(
                            "fingerprint", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fingerprint",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }
            }

            /// <summary>Creates a Container.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">GTM Account's API relative path. Example: accounts/{account_id}.</param>
            public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.Container body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a Container.</summary>
            public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Container>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Container body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>GTM Account's API relative path. Example: accounts/{account_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v2.Data.Container Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+parent}/containers";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+$",
                        });
                }

            }

            /// <summary>Deletes a Container.</summary>
            /// <param name="path">GTM Container's API relative path. Example:
            /// accounts/{account_id}/containers/{container_id}</param>
            public virtual DeleteRequest Delete(string path)
            {
                return new DeleteRequest(service, path);
            }

            /// <summary>Deletes a Container.</summary>
            public class DeleteRequest : TagManagerBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                    : base(service)
                {
                    Path = path;
                    InitParameters();
                }


                /// <summary>GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Path { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+path}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "path", new Google.Apis.Discovery.Parameter
                        {
                            Name = "path",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                        });
                }

            }

            /// <summary>Gets a Container.</summary>
            /// <param name="path">GTM Container's API relative path. Example:
            /// accounts/{account_id}/containers/{container_id}</param>
            public virtual GetRequest Get(string path)
            {
                return new GetRequest(service, path);
            }

            /// <summary>Gets a Container.</summary>
            public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Container>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string path)
                    : base(service)
                {
                    Path = path;
                    InitParameters();
                }


                /// <summary>GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Path { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+path}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "path", new Google.Apis.Discovery.Parameter
                        {
                            Name = "path",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                        });
                }

            }

            /// <summary>Lists all Containers that belongs to a GTM Account.</summary>
            /// <param name="parent">GTM Accounts's API relative path. Example: accounts/{account_id}.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all Containers that belongs to a GTM Account.</summary>
            public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListContainersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>GTM Accounts's API relative path. Example: accounts/{account_id}.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+parent}/containers";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+$",
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Updates a Container.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="path">GTM Container's API relative path. Example:
            /// accounts/{account_id}/containers/{container_id}</param>
            public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Container body, string path)
            {
                return new UpdateRequest(service, body, path);
            }

            /// <summary>Updates a Container.</summary>
            public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Container>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Container body, string path)
                    : base(service)
                {
                    Path = path;
                    Body = body;
                    InitParameters();
                }


                /// <summary>GTM Container's API relative path. Example:
                /// accounts/{account_id}/containers/{container_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Path { get; private set; }

                /// <summary>When provided, this fingerprint must match the fingerprint of the container in
                /// storage.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Fingerprint { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v2.Data.Container Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+path}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "path", new Google.Apis.Discovery.Parameter
                        {
                            Name = "path",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/containers/[^/]+$",
                        });
                    RequestParameters.Add(
                        "fingerprint", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fingerprint",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
        /// <summary>Gets the UserPermissions resource.</summary>
        public virtual UserPermissionsResource UserPermissions { get; }

        /// <summary>The "user_permissions" collection of methods.</summary>
        public class UserPermissionsResource
        {
            private const string Resource = "userPermissions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UserPermissionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates a user's Account & Container access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">GTM Account's API relative path. Example: accounts/{account_id}</param>
            public virtual CreateRequest Create(Google.Apis.TagManager.v2.Data.UserPermission body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a user's Account & Container access.</summary>
            public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.UserPermission>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.UserPermission body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>GTM Account's API relative path. Example: accounts/{account_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v2.Data.UserPermission Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+parent}/user_permissions";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+$",
                        });
                }

            }

            /// <summary>Removes a user from the account, revoking access to it and all of its containers.</summary>
            /// <param name="path">GTM UserPermission's API relative path. Example:
            /// accounts/{account_id}/user_permissions/{user_permission_id}</param>
            public virtual DeleteRequest Delete(string path)
            {
                return new DeleteRequest(service, path);
            }

            /// <summary>Removes a user from the account, revoking access to it and all of its containers.</summary>
            public class DeleteRequest : TagManagerBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string path)
                    : base(service)
                {
                    Path = path;
                    InitParameters();
                }


                /// <summary>GTM UserPermission's API relative path. Example:
                /// accounts/{account_id}/user_permissions/{user_permission_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Path { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+path}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "path", new Google.Apis.Discovery.Parameter
                        {
                            Name = "path",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/user_permissions/[^/]+$",
                        });
                }

            }

            /// <summary>Gets a user's Account & Container access.</summary>
            /// <param name="path">GTM UserPermission's API relative path. Example:
            /// accounts/{account_id}/user_permissions/{user_permission_id}</param>
            public virtual GetRequest Get(string path)
            {
                return new GetRequest(service, path);
            }

            /// <summary>Gets a user's Account & Container access.</summary>
            public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.UserPermission>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string path)
                    : base(service)
                {
                    Path = path;
                    InitParameters();
                }


                /// <summary>GTM UserPermission's API relative path. Example:
                /// accounts/{account_id}/user_permissions/{user_permission_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Path { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+path}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "path", new Google.Apis.Discovery.Parameter
                        {
                            Name = "path",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/user_permissions/[^/]+$",
                        });
                }

            }

            /// <summary>List all users that have access to the account along with Account and Container user access
            /// granted to each of them.</summary>
            /// <param name="parent">GTM Accounts's API relative path. Example: accounts/{account_id}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List all users that have access to the account along with Account and Container user access
            /// granted to each of them.</summary>
            public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListUserPermissionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>GTM Accounts's API relative path. Example: accounts/{account_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Continuation token for fetching the next page of results.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+parent}/user_permissions";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+$",
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Updates a user's Account & Container access.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="path">GTM UserPermission's API relative path. Example:
            /// accounts/{account_id}/user_permissions/{user_permission_id}</param>
            public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.UserPermission body, string path)
            {
                return new UpdateRequest(service, body, path);
            }

            /// <summary>Updates a user's Account & Container access.</summary>
            public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.UserPermission>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.UserPermission body, string path)
                    : base(service)
                {
                    Path = path;
                    Body = body;
                    InitParameters();
                }


                /// <summary>GTM UserPermission's API relative path. Example:
                /// accounts/{account_id}/user_permissions/{user_permission_id}</summary>
                [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Path { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v2.Data.UserPermission Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v2/{+path}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "path", new Google.Apis.Discovery.Parameter
                        {
                            Name = "path",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/user_permissions/[^/]+$",
                        });
                }

            }
        }

        /// <summary>Gets a GTM Account.</summary>
        /// <param name="path">GTM Accounts's API relative path. Example: accounts/{account_id}</param>
        public virtual GetRequest Get(string path)
        {
            return new GetRequest(service, path);
        }

        /// <summary>Gets a GTM Account.</summary>
        public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string path)
                : base(service)
            {
                Path = path;
                InitParameters();
            }


            /// <summary>GTM Accounts's API relative path. Example: accounts/{account_id}</summary>
            [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Path { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "tagmanager/v2/{+path}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "path", new Google.Apis.Discovery.Parameter
                    {
                        Name = "path",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
            }

        }

        /// <summary>Lists all GTM Accounts that a user has access to.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all GTM Accounts that a user has access to.</summary>
        public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.ListAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Continuation token for fetching the next page of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "tagmanager/v2/accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates a GTM Account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="path">GTM Accounts's API relative path. Example: accounts/{account_id}</param>
        public virtual UpdateRequest Update(Google.Apis.TagManager.v2.Data.Account body, string path)
        {
            return new UpdateRequest(service, body, path);
        }

        /// <summary>Updates a GTM Account.</summary>
        public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v2.Data.Account>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v2.Data.Account body, string path)
                : base(service)
            {
                Path = path;
                Body = body;
                InitParameters();
            }


            /// <summary>GTM Accounts's API relative path. Example: accounts/{account_id}</summary>
            [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Path { get; private set; }

            /// <summary>When provided, this fingerprint must match the fingerprint of the account in storage.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fingerprint { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.TagManager.v2.Data.Account Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "tagmanager/v2/{+path}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "path", new Google.Apis.Discovery.Parameter
                    {
                        Name = "path",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                RequestParameters.Add(
                    "fingerprint", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fingerprint",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.TagManager.v2.Data
{    

    /// <summary>Represents a Google Tag Manager Account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Account ID uniquely identifies the GTM Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The fingerprint of the GTM Account as computed at storage time. This value is recomputed whenever
        /// the account is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Account display name. @mutable tagmanager.accounts.create @mutable
        /// tagmanager.accounts.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>GTM Account's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Whether the account shares data anonymously with Google and others. This flag enables benchmarking
        /// by sharing your data in an anonymous form. Google will remove all identifiable information about your
        /// website, combine the data with hundreds of other anonymous sites and report aggregate trends in the
        /// benchmarking service. @mutable tagmanager.accounts.create @mutable tagmanager.accounts.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareData")]
        public virtual System.Nullable<bool> ShareData { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines the Google Tag Manager Account access permissions.</summary>
    public class AccountAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the user has no access, user access, or admin access to an account. @mutable
        /// tagmanager.accounts.permissions.create @mutable tagmanager.accounts.permissions.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Built-in variables are a special category of variables that are pre-created and non-customizable. They
    /// provide common functionality like accessing propeties of the gtm data layer, monitoring clicks, or accessing
    /// elements of a page URL.</summary>
    public class BuiltInVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>Name of the built-in variable to be used to refer to the built-in variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>GTM BuiltInVariable's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Type of built-in variable.
        /// @required.tagmanager.accounts.containers.workspaces.built_in_variable.update @mutable
        /// tagmanager.accounts.containers.workspaces.built_in_variable.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Client : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The Client ID uniquely identifies the GTM client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>The fingerprint of the GTM Client as computed at storage time. This value is recomputed whenever
        /// the client is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Client display name. @mutable tagmanager.accounts.containers.workspaces.clients.create @mutable
        /// tagmanager.accounts.containers.workspaces.clients.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The client's parameters. @mutable tagmanager.accounts.containers.workspaces.clients.create @mutable
        /// tagmanager.accounts.containers.workspaces.clients.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; } 

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; } 

        /// <summary>GTM client's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Priority determines relative firing order. @mutable
        /// tagmanager.accounts.containers.workspaces.clients.create @mutable
        /// tagmanager.accounts.containers.workspaces.clients.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>Client type. @mutable tagmanager.accounts.containers.workspaces.clients.create @mutable
        /// tagmanager.accounts.containers.workspaces.clients.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a predicate.</summary>
    public class Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of named parameters (key/value), depending on the condition's type. Notes: - For binary
        /// operators, include parameters named arg0 and arg1 for specifying the left and right operands, respectively.
        /// - At this time, the left operand (arg0) must be a reference to a variable. - For case-insensitive Regex
        /// matching, include a boolean parameter named ignore_case that is set to true. If not specified or set to any
        /// other value, the matching will be case sensitive. - To negate an operator, include a boolean parameter named
        /// negate boolean parameter that is set to true. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; } 

        /// <summary>The type of operator for this condition. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Container, which specifies the platform tags will run on, manages
    /// workspaces, and retains container versions.</summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The Container ID uniquely identifies the GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>List of domain names associated with the Container. @mutable tagmanager.accounts.containers.create
        /// @mutable tagmanager.accounts.containers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual System.Collections.Generic.IList<string> DomainName { get; set; } 

        /// <summary>The fingerprint of the GTM Container as computed at storage time. This value is recomputed whenever
        /// the account is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Container display name. @mutable tagmanager.accounts.containers.create @mutable
        /// tagmanager.accounts.containers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Container Notes. @mutable tagmanager.accounts.containers.create @mutable
        /// tagmanager.accounts.containers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>GTM Container's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Container Public ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicId")]
        public virtual string PublicId { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>List of Usage Contexts for the Container. Valid values include: web, android, or ios. @mutable
        /// tagmanager.accounts.containers.create @mutable tagmanager.accounts.containers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageContext")]
        public virtual System.Collections.Generic.IList<string> UsageContext { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines the Google Tag Manager Container access permissions.</summary>
    public class ContainerAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Container ID. @mutable tagmanager.accounts.permissions.create @mutable
        /// tagmanager.accounts.permissions.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>List of Container permissions. @mutable tagmanager.accounts.permissions.create @mutable
        /// tagmanager.accounts.permissions.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Container Version.</summary>
    public class ContainerVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The built-in variables in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtInVariable")]
        public virtual System.Collections.Generic.IList<BuiltInVariable> BuiltInVariable { get; set; } 

        /// <summary>The clients in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual System.Collections.Generic.IList<Client> Client { get; set; } 

        /// <summary>The container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual Container Container { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>The Container Version ID uniquely identifies the GTM Container Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersionId")]
        public virtual string ContainerVersionId { get; set; } 

        /// <summary>The custom templates in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTemplate")]
        public virtual System.Collections.Generic.IList<CustomTemplate> CustomTemplate { get; set; } 

        /// <summary>A value of true indicates this container version has been deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; } 

        /// <summary>Container version description. @mutable tagmanager.accounts.containers.versions.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The fingerprint of the GTM Container Version as computed at storage time. This value is recomputed
        /// whenever the container version is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>The folders in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual System.Collections.Generic.IList<Folder> Folder { get; set; } 

        /// <summary>Container version display name. @mutable tagmanager.accounts.containers.versions.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>GTM ContainerVersions's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>The tags in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual System.Collections.Generic.IList<Tag> Tag { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>The triggers in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual System.Collections.Generic.IList<Trigger> Trigger { get; set; } 

        /// <summary>The variables in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual System.Collections.Generic.IList<Variable> Variable { get; set; } 

        /// <summary>The zones in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual System.Collections.Generic.IList<Zone> Zone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Container Version Header.</summary>
    public class ContainerVersionHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>The Container Version ID uniquely identifies the GTM Container Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersionId")]
        public virtual string ContainerVersionId { get; set; } 

        /// <summary>A value of true indicates this container version has been deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; } 

        /// <summary>Container version display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Number of custom templates in the container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numCustomTemplates")]
        public virtual string NumCustomTemplates { get; set; } 

        /// <summary>Number of macros in the container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numMacros")]
        public virtual string NumMacros { get; set; } 

        /// <summary>Number of rules in the container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numRules")]
        public virtual string NumRules { get; set; } 

        /// <summary>Number of tags in the container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTags")]
        public virtual string NumTags { get; set; } 

        /// <summary>Number of triggers in the container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numTriggers")]
        public virtual string NumTriggers { get; set; } 

        /// <summary>Number of variables in the container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numVariables")]
        public virtual string NumVariables { get; set; } 

        /// <summary>Number of zones in the container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numZones")]
        public virtual string NumZones { get; set; } 

        /// <summary>GTM Container Versions's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class CreateBuiltInVariableResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of created built-in variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtInVariable")]
        public virtual System.Collections.Generic.IList<BuiltInVariable> BuiltInVariable { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Options for new container versions.</summary>
    public class CreateContainerVersionRequestVersionOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the container version to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The notes of the container version to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Create container versions response.</summary>
    public class CreateContainerVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compiler errors or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilerError")]
        public virtual System.Nullable<bool> CompilerError { get; set; } 

        /// <summary>The container version created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersion")]
        public virtual ContainerVersion ContainerVersion { get; set; } 

        /// <summary>Auto generated workspace path created as a result of version creation. This field should only be
        /// populated if the created version was not a quick preview.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newWorkspacePath")]
        public virtual string NewWorkspacePath { get; set; } 

        /// <summary>Whether version creation failed when syncing the workspace to the latest container
        /// version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncStatus")]
        public virtual SyncStatus SyncStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Custom Template's contents.</summary>
    public class CustomTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>The fingerprint of the GTM Custom Template as computed at storage time. This value is recomputed
        /// whenever the template is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>A reference to the Community Template Gallery entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("galleryReference")]
        public virtual GalleryReference GalleryReference { get; set; } 

        /// <summary>Custom Template display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>GTM Custom Template's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>The custom template in text format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateData")]
        public virtual string TemplateData { get; set; } 

        /// <summary>The Custom Template ID uniquely identifies the GTM custom template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateId")]
        public virtual string TemplateId { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A workspace entity that may represent a tag, trigger, variable, or folder in addition to its status in
    /// the workspace.</summary>
    public class Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents how the entity has been changed in the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changeStatus")]
        public virtual string ChangeStatus { get; set; } 

        /// <summary>The Folder being represented by the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual Folder Folder { get; set; } 

        /// <summary>The tag being represented by the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual Tag Tag { get; set; } 

        /// <summary>The trigger being represented by the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual Trigger Trigger { get; set; } 

        /// <summary>The variable being represented by the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual Variable Variable { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Environment. Note that a user can create, delete and update
    /// environments of type USER, but can only update the enable_debug and url fields of environments of other
    /// types.</summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The environment authorization code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationCode")]
        public virtual string AuthorizationCode { get; set; } 

        /// <summary>The last update time-stamp for the authorization code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationTimestamp")]
        public virtual object AuthorizationTimestamp { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>Represents a link to a container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersionId")]
        public virtual string ContainerVersionId { get; set; } 

        /// <summary>The environment description. Can be set or changed only on USER type environments. @mutable
        /// tagmanager.accounts.containers.environments.create @mutable
        /// tagmanager.accounts.containers.environments.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Whether or not to enable debug by default for the environment. @mutable
        /// tagmanager.accounts.containers.environments.create @mutable
        /// tagmanager.accounts.containers.environments.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDebug")]
        public virtual System.Nullable<bool> EnableDebug { get; set; } 

        /// <summary>GTM Environment ID uniquely identifies the GTM Environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentId")]
        public virtual string EnvironmentId { get; set; } 

        /// <summary>The fingerprint of the GTM environment as computed at storage time. This value is recomputed
        /// whenever the environment is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>The environment display name. Can be set or changed only on USER type environments. @mutable
        /// tagmanager.accounts.containers.environments.create @mutable
        /// tagmanager.accounts.containers.environments.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>GTM Environment's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>The type of this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Default preview page url for the environment. @mutable
        /// tagmanager.accounts.containers.environments.create @mutable
        /// tagmanager.accounts.containers.environments.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>Represents a link to a quick preview of a workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Folder.</summary>
    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>The fingerprint of the GTM Folder as computed at storage time. This value is recomputed whenever
        /// the folder is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>The Folder ID uniquely identifies the GTM Folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderId")]
        public virtual string FolderId { get; set; } 

        /// <summary>Folder display name. @mutable tagmanager.accounts.containers.workspaces.folders.create @mutable
        /// tagmanager.accounts.containers.workspaces.folders.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>User notes on how to apply this folder in the container. @mutable
        /// tagmanager.accounts.containers.workspaces.folders.create @mutable
        /// tagmanager.accounts.containers.workspaces.folders.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>GTM Folder's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Folder's contents.</summary>
    public class FolderEntities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of tags inside the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual System.Collections.Generic.IList<Tag> Tag { get; set; } 

        /// <summary>The list of triggers inside the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual System.Collections.Generic.IList<Trigger> Trigger { get; set; } 

        /// <summary>The list of variables inside the folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual System.Collections.Generic.IList<Variable> Variable { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the link between a custom template and an entry on the Community Template Gallery
    /// site.</summary>
    public class GalleryReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the host for the community gallery template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; } 

        /// <summary>If a user has manually edited the community gallery template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isModified")]
        public virtual System.Nullable<bool> IsModified { get; set; } 

        /// <summary>The name of the owner for the community gallery template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual string Owner { get; set; } 

        /// <summary>The name of the repository for the community gallery template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repository")]
        public virtual string Repository { get; set; } 

        /// <summary>The signature of the community gallery template as computed at import time. This value is
        /// recomputed whenever the template is updated from the gallery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; } 

        /// <summary>The version of the community gallery template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The changes that have occurred in the workspace since the base container version.</summary>
    public class GetWorkspaceStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The merge conflict after sync.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeConflict")]
        public virtual System.Collections.Generic.IList<MergeConflict> MergeConflict { get; set; } 

        /// <summary>Entities that have been changed in the workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceChange")]
        public virtual System.Collections.Generic.IList<Entity> WorkspaceChange { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List Accounts Response.</summary>
    public class ListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GTM Accounts that a user has access to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual System.Collections.Generic.IList<Account> Account { get; set; } 

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List container versions response.</summary>
    public class ListContainerVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All container version headers of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersionHeader")]
        public virtual System.Collections.Generic.IList<ContainerVersionHeader> ContainerVersionHeader { get; set; } 

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List Containers Response.</summary>
    public class ListContainersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All Containers of a GTM Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual System.Collections.Generic.IList<Container> Container { get; set; } 

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of enabled built-in variables.</summary>
    public class ListEnabledBuiltInVariablesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All GTM BuiltInVariables of a GTM container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("builtInVariable")]
        public virtual System.Collections.Generic.IList<BuiltInVariable> BuiltInVariable { get; set; } 

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List Environments Response.</summary>
    public class ListEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All Environments of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IList<Environment> Environment { get; set; } 

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List Folders Response.</summary>
    public class ListFoldersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All GTM Folders of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual System.Collections.Generic.IList<Folder> Folder { get; set; } 

        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List Tags Response.</summary>
    public class ListTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>All GTM Tags of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual System.Collections.Generic.IList<Tag> Tag { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListTemplatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>All GTM Custom Templates of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual System.Collections.Generic.IList<CustomTemplate> Template { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List triggers response.</summary>
    public class ListTriggersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>All GTM Triggers of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual System.Collections.Generic.IList<Trigger> Trigger { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List user permissions response.</summary>
    public class ListUserPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>All GTM UserPermissions of a GTM Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userPermission")]
        public virtual System.Collections.Generic.IList<UserPermission> UserPermission { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List Variables Response.</summary>
    public class ListVariablesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>All GTM Variables of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual System.Collections.Generic.IList<Variable> Variable { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of workspaces in a container.</summary>
    public class ListWorkspacesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>All Workspaces of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspace")]
        public virtual System.Collections.Generic.IList<Workspace> Workspace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListZonesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Continuation token for fetching the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>All GTM Zones of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual System.Collections.Generic.IList<Zone> Zone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a merge conflict.</summary>
    public class MergeConflict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base version entity (since the latest sync operation) that has conflicting changes compared to
        /// the workspace. If this field is missing, it means the workspace entity is deleted from the base
        /// version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityInBaseVersion")]
        public virtual Entity EntityInBaseVersion { get; set; } 

        /// <summary>The workspace entity that has conflicting changes compared to the base version. If an entity is
        /// deleted in a workspace, it will still appear with a deleted change status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityInWorkspace")]
        public virtual Entity EntityInWorkspace { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Parameter.</summary>
    public class Parameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The named key that uniquely identifies a parameter. Required for top-level parameters, as well as
        /// map values. Ignored for list values. @mutable tagmanager.accounts.containers.workspaces.variables.create
        /// @mutable tagmanager.accounts.containers.workspaces.variables.update @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>This list parameter's parameters (keys will be ignored). @mutable
        /// tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("list")]
        public virtual System.Collections.Generic.IList<Parameter> List { get; set; } 

        /// <summary>This map parameter's parameters (must have keys; keys must be unique). @mutable
        /// tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("map")]
        public virtual System.Collections.Generic.IList<Parameter> Map { get; set; } 

        /// <summary>The parameter type. Valid values are: - boolean: The value represents a boolean, represented as
        /// 'true' or 'false' - integer: The value represents a 64-bit signed integer value, in base 10 - list: A list
        /// of parameters should be specified - map: A map of parameters should be specified - template: The value
        /// represents any text; this can include variable references (even variable references that might return non-
        /// string types) - trigger_reference: The value represents a trigger, represented as the trigger id -
        /// tag_reference: The value represents a tag, represented as the tag name @mutable
        /// tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>A parameter's value (may contain variable references such as "{{myVariable}}") as appropriate to
        /// the specified type. @mutable tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Publish container version response.</summary>
    public class PublishContainerVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compiler errors or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilerError")]
        public virtual System.Nullable<bool> CompilerError { get; set; } 

        /// <summary>The container version created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersion")]
        public virtual ContainerVersion ContainerVersion { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response to quick previewing a workspace.</summary>
    public class QuickPreviewResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Were there compiler errors or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compilerError")]
        public virtual System.Nullable<bool> CompilerError { get; set; } 

        /// <summary>The quick previewed container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersion")]
        public virtual ContainerVersion ContainerVersion { get; set; } 

        /// <summary>Whether quick previewing failed when syncing the workspace to the latest container
        /// version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncStatus")]
        public virtual SyncStatus SyncStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of reverting a built-in variable in a workspace.</summary>
    public class RevertBuiltInVariableResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the built-in variable is enabled after reversion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of reverting folder changes in a workspace.</summary>
    public class RevertFolderResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Folder as it appears in the latest container version since the last workspace synchronization
        /// operation. If no folder is present, that means the folder was deleted in the latest container
        /// version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual Folder Folder { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of reverting a tag in a workspace.</summary>
    public class RevertTagResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tag as it appears in the latest container version since the last workspace synchronization
        /// operation. If no tag is present, that means the tag was deleted in the latest container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual Tag Tag { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of reverting a template in a workspace.</summary>
    public class RevertTemplateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Template as it appears in the latest container version since the last workspace synchronization
        /// operation. If no template is present, that means the template was deleted in the latest container
        /// version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual CustomTemplate Template { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of reverting a trigger in a workspace.</summary>
    public class RevertTriggerResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Trigger as it appears in the latest container version since the last workspace synchronization
        /// operation. If no trigger is present, that means the trigger was deleted in the latest container
        /// version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual Trigger Trigger { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of reverting a variable in a workspace.</summary>
    public class RevertVariableResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Variable as it appears in the latest container version since the last workspace synchronization
        /// operation. If no variable is present, that means the variable was deleted in the latest container
        /// version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual Variable Variable { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of reverting a zone in a workspace.</summary>
    public class RevertZoneResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Zone as it appears in the latest container version since the last workspace synchronization
        /// operation. If no zone is present, that means the zone was deleted in the latest container version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual Zone Zone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a reference to atag that fires before another tag in order to set up dependencies.</summary>
    public class SetupTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, fire the main tag if and only if the setup tag fires successfully. If false, fire the main
        /// tag regardless of setup tag firing status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopOnSetupFailure")]
        public virtual System.Nullable<bool> StopOnSetupFailure { get; set; } 

        /// <summary>The name of the setup tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The status of a workspace after synchronization.</summary>
    public class SyncStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Synchornization operation detected a merge conflict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeConflict")]
        public virtual System.Nullable<bool> MergeConflict { get; set; } 

        /// <summary>An error occurred during the synchronization operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncError")]
        public virtual System.Nullable<bool> SyncError { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response after synchronizing the workspace to the latest container version.</summary>
    public class SyncWorkspaceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The merge conflict after sync. If this field is not empty, the sync is still treated as successful.
        /// But a version cannot be created until all conflicts are resolved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeConflict")]
        public virtual System.Collections.Generic.IList<MergeConflict> MergeConflict { get; set; } 

        /// <summary>Indicates whether synchronization caused a merge conflict or sync error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncStatus")]
        public virtual SyncStatus SyncStatus { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Tag.</summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>Blocking rule IDs. If any of the listed rules evaluate to true, the tag will not fire. @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingRuleId")]
        public virtual System.Collections.Generic.IList<string> BlockingRuleId { get; set; } 

        /// <summary>Blocking trigger IDs. If any of the listed triggers evaluate to true, the tag will not fire.
        /// @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingTriggerId")]
        public virtual System.Collections.Generic.IList<string> BlockingTriggerId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>The fingerprint of the GTM Tag as computed at storage time. This value is recomputed whenever the
        /// tag is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Firing rule IDs. A tag will fire when any of the listed rules are true and all of its
        /// blockingRuleIds (if any specified) are false. @mutable tagmanager.accounts.containers.workspaces.tags.create
        /// @mutable tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firingRuleId")]
        public virtual System.Collections.Generic.IList<string> FiringRuleId { get; set; } 

        /// <summary>Firing trigger IDs. A tag will fire when any of the listed triggers are true and all of its
        /// blockingTriggerIds (if any specified) are false. @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firingTriggerId")]
        public virtual System.Collections.Generic.IList<string> FiringTriggerId { get; set; } 

        /// <summary>If set to true, this tag will only fire in the live environment (e.g. not in preview or debug
        /// mode). @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveOnly")]
        public virtual System.Nullable<bool> LiveOnly { get; set; } 

        /// <summary>A map of key-value pairs of tag metadata to be included in the event data for tag monitoring.
        /// Notes: - This parameter must be type MAP. - Each parameter in the map are type TEMPLATE, however cannot
        /// contain variable references. @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoringMetadata")]
        public virtual Parameter MonitoringMetadata { get; set; } 

        /// <summary>If non-empty, then the tag display name will be included in the monitoring metadata map using the
        /// key specified. @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoringMetadataTagNameKey")]
        public virtual string MonitoringMetadataTagNameKey { get; set; } 

        /// <summary>Tag display name. @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>User notes on how to apply this tag in the container. @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>The tag's parameters. @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; } 

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; } 

        /// <summary>GTM Tag's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Indicates whether the tag is paused, which prevents the tag from firing. @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paused")]
        public virtual System.Nullable<bool> Paused { get; set; } 

        /// <summary>User defined numeric priority of the tag. Tags are fired asynchronously in order of priority. Tags
        /// with higher numeric value fire first. A tag's priority can be a positive or negative value. The default
        /// value is 0. @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual Parameter Priority { get; set; } 

        /// <summary>The end timestamp in milliseconds to schedule a tag. @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleEndMs")]
        public virtual System.Nullable<long> ScheduleEndMs { get; set; } 

        /// <summary>The start timestamp in milliseconds to schedule a tag. @mutable
        /// tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleStartMs")]
        public virtual System.Nullable<long> ScheduleStartMs { get; set; } 

        /// <summary>The list of setup tags. Currently we only allow one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setupTag")]
        public virtual System.Collections.Generic.IList<SetupTag> SetupTag { get; set; } 

        /// <summary>Option to fire this tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagFiringOption")]
        public virtual string TagFiringOption { get; set; } 

        /// <summary>The Tag ID uniquely identifies the GTM Tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagId")]
        public virtual string TagId { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>The list of teardown tags. Currently we only allow one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teardownTag")]
        public virtual System.Collections.Generic.IList<TeardownTag> TeardownTag { get; set; } 

        /// <summary>GTM Tag Type. @mutable tagmanager.accounts.containers.workspaces.tags.create @mutable
        /// tagmanager.accounts.containers.workspaces.tags.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a tag that fires after another tag in order to tear down dependencies.</summary>
    public class TeardownTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If true, fire the teardown tag if and only if the main tag fires successfully. If false, fire the
        /// teardown tag regardless of main tag firing status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopTeardownOnFailure")]
        public virtual System.Nullable<bool> StopTeardownOnFailure { get; set; } 

        /// <summary>The name of the teardown tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Trigger</summary>
    public class Trigger : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>Used in the case of auto event tracking. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoEventFilter")]
        public virtual System.Collections.Generic.IList<Condition> AutoEventFilter { get; set; } 

        /// <summary>Whether or not we should only fire tags if the form submit or link click event is not cancelled by
        /// some other event handler (e.g. because of validation). Only valid for Form Submission and Link Click
        /// triggers. @mutable tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkValidation")]
        public virtual Parameter CheckValidation { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>A visibility trigger minimum continuous visible time (in milliseconds). Only valid for AMP
        /// Visibility trigger. @mutable tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousTimeMinMilliseconds")]
        public virtual Parameter ContinuousTimeMinMilliseconds { get; set; } 

        /// <summary>Used in the case of custom event, which is fired iff all Conditions are true. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEventFilter")]
        public virtual System.Collections.Generic.IList<Condition> CustomEventFilter { get; set; } 

        /// <summary>Name of the GTM event that is fired. Only valid for Timer triggers. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual Parameter EventName { get; set; } 

        /// <summary>The trigger will only fire iff all Conditions are true. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual System.Collections.Generic.IList<Condition> Filter { get; set; } 

        /// <summary>The fingerprint of the GTM Trigger as computed at storage time. This value is recomputed whenever
        /// the trigger is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>List of integer percentage values for scroll triggers. The trigger will fire when each percentage
        /// is reached when the view is scrolled horizontally. Only valid for AMP scroll triggers. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalScrollPercentageList")]
        public virtual Parameter HorizontalScrollPercentageList { get; set; } 

        /// <summary>Time between triggering recurring Timer Events (in milliseconds). Only valid for Timer triggers.
        /// @mutable tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual Parameter Interval { get; set; } 

        /// <summary>Time between Timer Events to fire (in seconds). Only valid for AMP Timer trigger. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervalSeconds")]
        public virtual Parameter IntervalSeconds { get; set; } 

        /// <summary>Limit of the number of GTM events this Timer Trigger will fire. If no limit is set, we will
        /// continue to fire GTM events until the user leaves the page. Only valid for Timer triggers. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual Parameter Limit { get; set; } 

        /// <summary>Max time to fire Timer Events (in seconds). Only valid for AMP Timer trigger. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTimerLengthSeconds")]
        public virtual Parameter MaxTimerLengthSeconds { get; set; } 

        /// <summary>Trigger display name. @mutable tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>User notes on how to apply this trigger in the container. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>Additional parameters. @mutable tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; } 

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; } 

        /// <summary>GTM Trigger's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>A click trigger CSS selector (i.e. "a", "button" etc.). Only valid for AMP Click trigger. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual Parameter Selector { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>A visibility trigger minimum total visible time (in milliseconds). Only valid for AMP Visibility
        /// trigger. @mutable tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalTimeMinMilliseconds")]
        public virtual Parameter TotalTimeMinMilliseconds { get; set; } 

        /// <summary>The Trigger ID uniquely identifies the GTM Trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; } 

        /// <summary>Defines the data layer event that causes this trigger. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Globally unique id of the trigger that auto-generates this (a Form Submit, Link Click or Timer
        /// listener) if any. Used to make incompatible auto-events work together with trigger filtering based on
        /// trigger ids. This value is populated during output generation since the tags implied by triggers don't exist
        /// until then. Only valid for Form Submit, Link Click and Timer triggers. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueTriggerId")]
        public virtual Parameter UniqueTriggerId { get; set; } 

        /// <summary>List of integer percentage values for scroll triggers. The trigger will fire when each percentage
        /// is reached when the view is scrolled vertically. Only valid for AMP scroll triggers. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalScrollPercentageList")]
        public virtual Parameter VerticalScrollPercentageList { get; set; } 

        /// <summary>A visibility trigger CSS selector (i.e. "#id"). Only valid for AMP Visibility trigger. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibilitySelector")]
        public virtual Parameter VisibilitySelector { get; set; } 

        /// <summary>A visibility trigger maximum percent visibility. Only valid for AMP Visibility trigger. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visiblePercentageMax")]
        public virtual Parameter VisiblePercentageMax { get; set; } 

        /// <summary>A visibility trigger minimum percent visibility. Only valid for AMP Visibility trigger. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visiblePercentageMin")]
        public virtual Parameter VisiblePercentageMin { get; set; } 

        /// <summary>Whether or not we should delay the form submissions or link opening until all of the tags have
        /// fired (by preventing the default action and later simulating the default action). Only valid for Form
        /// Submission and Link Click triggers. @mutable tagmanager.accounts.containers.workspaces.triggers.create
        /// @mutable tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitForTags")]
        public virtual Parameter WaitForTags { get; set; } 

        /// <summary>How long to wait (in milliseconds) for tags to fire when 'waits_for_tags' above evaluates to true.
        /// Only valid for Form Submission and Link Click triggers. @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.create @mutable
        /// tagmanager.accounts.containers.workspaces.triggers.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitForTagsTimeout")]
        public virtual Parameter WaitForTagsTimeout { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a user's permissions to an account and its container.</summary>
    public class UserPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account access permissions. @mutable tagmanager.accounts.permissions.create @mutable
        /// tagmanager.accounts.permissions.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountAccess")]
        public virtual AccountAccess AccountAccess { get; set; } 

        /// <summary>The Account ID uniquely identifies the GTM Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>GTM Container access permissions. @mutable tagmanager.accounts.permissions.create @mutable
        /// tagmanager.accounts.permissions.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerAccess")]
        public virtual System.Collections.Generic.IList<ContainerAccess> ContainerAccess { get; set; } 

        /// <summary>User's email address. @mutable tagmanager.accounts.permissions.create</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; } 

        /// <summary>GTM UserPermission's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Variable.</summary>
    public class Variable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>For mobile containers only: A list of trigger IDs for disabling conditional variables; the variable
        /// is enabled if one of the enabling trigger is true while all the disabling trigger are false. Treated as an
        /// unordered set. @mutable tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablingTriggerId")]
        public virtual System.Collections.Generic.IList<string> DisablingTriggerId { get; set; } 

        /// <summary>For mobile containers only: A list of trigger IDs for enabling conditional variables; the variable
        /// is enabled if one of the enabling triggers is true while all the disabling triggers are false. Treated as an
        /// unordered set. @mutable tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablingTriggerId")]
        public virtual System.Collections.Generic.IList<string> EnablingTriggerId { get; set; } 

        /// <summary>The fingerprint of the GTM Variable as computed at storage time. This value is recomputed whenever
        /// the variable is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Option to convert a variable value to other value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatValue")]
        public virtual VariableFormatValue FormatValue { get; set; } 

        /// <summary>Variable display name. @mutable tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>User notes on how to apply this variable in the container. @mutable
        /// tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>The variable's parameters. @mutable tagmanager.accounts.containers.workspaces.variables.create
        /// @mutable tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; } 

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; } 

        /// <summary>GTM Variable's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>The end timestamp in milliseconds to schedule a variable. @mutable
        /// tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleEndMs")]
        public virtual System.Nullable<long> ScheduleEndMs { get; set; } 

        /// <summary>The start timestamp in milliseconds to schedule a variable. @mutable
        /// tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleStartMs")]
        public virtual System.Nullable<long> ScheduleStartMs { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>GTM Variable Type. @mutable tagmanager.accounts.containers.workspaces.variables.create @mutable
        /// tagmanager.accounts.containers.workspaces.variables.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The Variable ID uniquely identifies the GTM Variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variableId")]
        public virtual string VariableId { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class VariableFormatValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The option to convert a string-type variable value to either lowercase or uppercase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseConversionType")]
        public virtual string CaseConversionType { get; set; } 

        /// <summary>The value to convert if a variable value is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertFalseToValue")]
        public virtual Parameter ConvertFalseToValue { get; set; } 

        /// <summary>The value to convert if a variable value is null.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertNullToValue")]
        public virtual Parameter ConvertNullToValue { get; set; } 

        /// <summary>The value to convert if a variable value is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertTrueToValue")]
        public virtual Parameter ConvertTrueToValue { get; set; } 

        /// <summary>The value to convert if a variable value is undefined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertUndefinedToValue")]
        public virtual Parameter ConvertUndefinedToValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Container Workspace.</summary>
    public class Workspace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>Workspace description. @mutable tagmanager.accounts.containers.workspaces.create @mutable
        /// tagmanager.accounts.containers.workspaces.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The fingerprint of the GTM Workspace as computed at storage time. This value is recomputed whenever
        /// the workspace is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Workspace display name. @mutable tagmanager.accounts.containers.workspaces.create @mutable
        /// tagmanager.accounts.containers.workspaces.update</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>GTM Workspace's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>The Workspace ID uniquely identifies the GTM Workspace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Google Tag Manager Zone's contents.</summary>
    public class Zone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>This Zone's boundary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundary")]
        public virtual ZoneBoundary Boundary { get; set; } 

        /// <summary>Containers that are children of this Zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childContainer")]
        public virtual System.Collections.Generic.IList<ZoneChildContainer> ChildContainer { get; set; } 

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; } 

        /// <summary>The fingerprint of the GTM Zone as computed at storage time. This value is recomputed whenever the
        /// zone is modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>Zone display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>User notes on how to apply this zone in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>GTM Zone's API relative path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>Auto generated link to the tag manager UI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagManagerUrl")]
        public virtual string TagManagerUrl { get; set; } 

        /// <summary>This Zone's type restrictions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeRestriction")]
        public virtual ZoneTypeRestriction TypeRestriction { get; set; } 

        /// <summary>GTM Workspace ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workspaceId")]
        public virtual string WorkspaceId { get; set; } 

        /// <summary>The Zone ID uniquely identifies the GTM Zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zoneId")]
        public virtual string ZoneId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Zone's boundaries.</summary>
    public class ZoneBoundary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The conditions that, when conjoined, make up the boundary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual System.Collections.Generic.IList<Condition> Condition { get; set; } 

        /// <summary>Custom evaluation trigger IDs. A zone will evaluate its boundary conditions when any of the listed
        /// triggers are true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEvaluationTriggerId")]
        public virtual System.Collections.Generic.IList<string> CustomEvaluationTriggerId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a child container of a Zone.</summary>
    public class ZoneChildContainer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The zone's nickname for the child container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nickname")]
        public virtual string Nickname { get; set; } 

        /// <summary>The child container's public id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicId")]
        public virtual string PublicId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a Zone's type restrictions.</summary>
    public class ZoneTypeRestriction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if type restrictions have been enabled for this Zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enable")]
        public virtual System.Nullable<bool> Enable { get; set; } 

        /// <summary>List of type public ids that have been whitelisted for use in this Zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whitelistedTypeId")]
        public virtual System.Collections.Generic.IList<string> WhitelistedTypeId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
