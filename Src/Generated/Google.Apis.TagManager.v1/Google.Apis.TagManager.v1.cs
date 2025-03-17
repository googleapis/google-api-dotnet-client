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

namespace Google.Apis.TagManager.v1
{
    /// <summary>The TagManager Service.</summary>
    public class TagManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TagManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TagManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://tagmanager.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://tagmanager.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "tagmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Tag Manager API.</summary>
        public class Scope
        {
            /// <summary>Delete your Google Tag Manager containers</summary>
            public static string TagmanagerDeleteContainers = "https://www.googleapis.com/auth/tagmanager.delete.containers";

            /// <summary>
            /// Manage your Google Tag Manager container and its subcomponents, excluding versioning and publishing
            /// </summary>
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

            /// <summary>
            /// Manage your Google Tag Manager container and its subcomponents, excluding versioning and publishing
            /// </summary>
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

    /// <summary>A base abstract class for TagManager requests.</summary>
    public abstract class TagManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TagManagerBaseServiceRequest instance.</summary>
        protected TagManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes TagManager parameter list.</summary>
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
            Permissions = new PermissionsResource(service);
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
                Folders = new FoldersResource(service);
                MoveFolders = new MoveFoldersResource(service);
                ReauthorizeEnvironments = new ReauthorizeEnvironmentsResource(service);
                Tags = new TagsResource(service);
                Triggers = new TriggersResource(service);
                Variables = new VariablesResource(service);
                Versions = new VersionsResource(service);
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
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.Environment body, string accountId, string containerId)
                {
                    return new CreateRequest(this.service, body, accountId, containerId);
                }

                /// <summary>Creates a GTM Environment.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Environment>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Environment body, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Environment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/environments";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a GTM Environment.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="environmentId">The GTM Environment ID.</param>
                public virtual DeleteRequest Delete(string accountId, string containerId, string environmentId)
                {
                    return new DeleteRequest(this.service, accountId, containerId, environmentId);
                }

                /// <summary>Deletes a GTM Environment.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string environmentId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        EnvironmentId = environmentId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Environment ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("environmentId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string EnvironmentId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/environments/{environmentId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("environmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environmentId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a GTM Environment.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="environmentId">The GTM Environment ID.</param>
                public virtual GetRequest Get(string accountId, string containerId, string environmentId)
                {
                    return new GetRequest(this.service, accountId, containerId, environmentId);
                }

                /// <summary>Gets a GTM Environment.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Environment>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string environmentId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        EnvironmentId = environmentId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Environment ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("environmentId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string EnvironmentId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/environments/{environmentId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("environmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environmentId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all GTM Environments of a GTM Container.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual ListRequest List(string accountId, string containerId)
                {
                    return new ListRequest(this.service, accountId, containerId);
                }

                /// <summary>Lists all GTM Environments of a GTM Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListEnvironmentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/environments";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a GTM Environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="environmentId">The GTM Environment ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Environment body, string accountId, string containerId, string environmentId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, environmentId);
                }

                /// <summary>Updates a GTM Environment.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Environment>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Environment body, string accountId, string containerId, string environmentId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        EnvironmentId = environmentId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Environment ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("environmentId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string EnvironmentId { get; private set; }

                    /// <summary>
                    /// When provided, this fingerprint must match the fingerprint of the environment in storage.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Environment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/environments/{environmentId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("environmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environmentId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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
                    Entities = new EntitiesResource(service);
                }

                /// <summary>Gets the Entities resource.</summary>
                public virtual EntitiesResource Entities { get; }

                /// <summary>The "entities" collection of methods.</summary>
                public class EntitiesResource
                {
                    private const string Resource = "entities";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EntitiesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>List all entities in a GTM Folder.</summary>
                    /// <param name="accountId">The GTM Account ID.</param>
                    /// <param name="containerId">The GTM Container ID.</param>
                    /// <param name="folderId">The GTM Folder ID.</param>
                    public virtual ListRequest List(string accountId, string containerId, string folderId)
                    {
                        return new ListRequest(this.service, accountId, containerId, folderId);
                    }

                    /// <summary>List all entities in a GTM Folder.</summary>
                    public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.FolderEntities>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string folderId) : base(service)
                        {
                            AccountId = accountId;
                            ContainerId = containerId;
                            FolderId = folderId;
                            InitParameters();
                        }

                        /// <summary>The GTM Account ID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string AccountId { get; private set; }

                        /// <summary>The GTM Container ID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ContainerId { get; private set; }

                        /// <summary>The GTM Folder ID.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string FolderId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/folders/{folderId}/entities";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "accountId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "containerId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "folderId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>Creates a GTM Folder.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.Folder body, string accountId, string containerId)
                {
                    return new CreateRequest(this.service, body, accountId, containerId);
                }

                /// <summary>Creates a GTM Folder.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Folder>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Folder body, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Folder Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/folders";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a GTM Folder.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="folderId">The GTM Folder ID.</param>
                public virtual DeleteRequest Delete(string accountId, string containerId, string folderId)
                {
                    return new DeleteRequest(this.service, accountId, containerId, folderId);
                }

                /// <summary>Deletes a GTM Folder.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string folderId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        FolderId = folderId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Folder ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FolderId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/folders/{folderId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "folderId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a GTM Folder.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="folderId">The GTM Folder ID.</param>
                public virtual GetRequest Get(string accountId, string containerId, string folderId)
                {
                    return new GetRequest(this.service, accountId, containerId, folderId);
                }

                /// <summary>Gets a GTM Folder.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Folder>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string folderId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        FolderId = folderId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Folder ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FolderId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/folders/{folderId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "folderId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all GTM Folders of a Container.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual ListRequest List(string accountId, string containerId)
                {
                    return new ListRequest(this.service, accountId, containerId);
                }

                /// <summary>Lists all GTM Folders of a Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListFoldersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/folders";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a GTM Folder.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="folderId">The GTM Folder ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Folder body, string accountId, string containerId, string folderId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, folderId);
                }

                /// <summary>Updates a GTM Folder.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Folder>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Folder body, string accountId, string containerId, string folderId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        FolderId = folderId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Folder ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FolderId { get; private set; }

                    /// <summary>
                    /// When provided, this fingerprint must match the fingerprint of the folder in storage.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Folder Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/folders/{folderId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "folderId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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

            /// <summary>Gets the MoveFolders resource.</summary>
            public virtual MoveFoldersResource MoveFolders { get; }

            /// <summary>The "move_folders" collection of methods.</summary>
            public class MoveFoldersResource
            {
                private const string Resource = "moveFolders";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MoveFoldersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Moves entities to a GTM Folder.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="folderId">The GTM Folder ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Folder body, string accountId, string containerId, string folderId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, folderId);
                }

                /// <summary>Moves entities to a GTM Folder.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Folder body, string accountId, string containerId, string folderId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        FolderId = folderId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Folder ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("folderId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string FolderId { get; private set; }

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
                    Google.Apis.TagManager.v1.Data.Folder Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/move_folders/{folderId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("folderId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "folderId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("tagId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tagId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "triggerId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("variableId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "variableId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the ReauthorizeEnvironments resource.</summary>
            public virtual ReauthorizeEnvironmentsResource ReauthorizeEnvironments { get; }

            /// <summary>The "reauthorize_environments" collection of methods.</summary>
            public class ReauthorizeEnvironmentsResource
            {
                private const string Resource = "reauthorizeEnvironments";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReauthorizeEnvironmentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Re-generates the authorization code for a GTM Environment.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="environmentId">The GTM Environment ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Environment body, string accountId, string containerId, string environmentId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, environmentId);
                }

                /// <summary>Re-generates the authorization code for a GTM Environment.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Environment>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Environment body, string accountId, string containerId, string environmentId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        EnvironmentId = environmentId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Environment ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("environmentId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string EnvironmentId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Environment Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/reauthorize_environments/{environmentId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("environmentId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "environmentId",
                            IsRequired = true,
                            ParameterType = "path",
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
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.Tag body, string accountId, string containerId)
                {
                    return new CreateRequest(this.service, body, accountId, containerId);
                }

                /// <summary>Creates a GTM Tag.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Tag>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Tag body, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Tag Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/tags";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a GTM Tag.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="tagId">The GTM Tag ID.</param>
                public virtual DeleteRequest Delete(string accountId, string containerId, string tagId)
                {
                    return new DeleteRequest(this.service, accountId, containerId, tagId);
                }

                /// <summary>Deletes a GTM Tag.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string tagId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        TagId = tagId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Tag ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tagId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string TagId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/tags/{tagId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("tagId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tagId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a GTM Tag.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="tagId">The GTM Tag ID.</param>
                public virtual GetRequest Get(string accountId, string containerId, string tagId)
                {
                    return new GetRequest(this.service, accountId, containerId, tagId);
                }

                /// <summary>Gets a GTM Tag.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Tag>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string tagId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        TagId = tagId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Tag ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tagId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string TagId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/tags/{tagId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("tagId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tagId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all GTM Tags of a Container.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual ListRequest List(string accountId, string containerId)
                {
                    return new ListRequest(this.service, accountId, containerId);
                }

                /// <summary>Lists all GTM Tags of a Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListTagsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/tags";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a GTM Tag.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="tagId">The GTM Tag ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Tag body, string accountId, string containerId, string tagId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, tagId);
                }

                /// <summary>Updates a GTM Tag.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Tag>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Tag body, string accountId, string containerId, string tagId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        TagId = tagId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Tag ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("tagId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string TagId { get; private set; }

                    /// <summary>
                    /// When provided, this fingerprint must match the fingerprint of the tag in storage.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Tag Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/tags/{tagId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("tagId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "tagId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.Trigger body, string accountId, string containerId)
                {
                    return new CreateRequest(this.service, body, accountId, containerId);
                }

                /// <summary>Creates a GTM Trigger.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Trigger>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Trigger body, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Trigger Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/triggers";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a GTM Trigger.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="triggerId">The GTM Trigger ID.</param>
                public virtual DeleteRequest Delete(string accountId, string containerId, string triggerId)
                {
                    return new DeleteRequest(this.service, accountId, containerId, triggerId);
                }

                /// <summary>Deletes a GTM Trigger.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string triggerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        TriggerId = triggerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Trigger ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string TriggerId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/triggers/{triggerId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "triggerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a GTM Trigger.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="triggerId">The GTM Trigger ID.</param>
                public virtual GetRequest Get(string accountId, string containerId, string triggerId)
                {
                    return new GetRequest(this.service, accountId, containerId, triggerId);
                }

                /// <summary>Gets a GTM Trigger.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Trigger>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string triggerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        TriggerId = triggerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Trigger ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string TriggerId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/triggers/{triggerId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "triggerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all GTM Triggers of a Container.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual ListRequest List(string accountId, string containerId)
                {
                    return new ListRequest(this.service, accountId, containerId);
                }

                /// <summary>Lists all GTM Triggers of a Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListTriggersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/triggers";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a GTM Trigger.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="triggerId">The GTM Trigger ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Trigger body, string accountId, string containerId, string triggerId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, triggerId);
                }

                /// <summary>Updates a GTM Trigger.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Trigger>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Trigger body, string accountId, string containerId, string triggerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        TriggerId = triggerId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Trigger ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("triggerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string TriggerId { get; private set; }

                    /// <summary>
                    /// When provided, this fingerprint must match the fingerprint of the trigger in storage.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Trigger Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/triggers/{triggerId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("triggerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "triggerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.Variable body, string accountId, string containerId)
                {
                    return new CreateRequest(this.service, body, accountId, containerId);
                }

                /// <summary>Creates a GTM Variable.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Variable>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Variable body, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Variable Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/variables";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a GTM Variable.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="variableId">The GTM Variable ID.</param>
                public virtual DeleteRequest Delete(string accountId, string containerId, string variableId)
                {
                    return new DeleteRequest(this.service, accountId, containerId, variableId);
                }

                /// <summary>Deletes a GTM Variable.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string variableId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        VariableId = variableId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Variable ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("variableId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string VariableId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/variables/{variableId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("variableId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "variableId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a GTM Variable.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="variableId">The GTM Variable ID.</param>
                public virtual GetRequest Get(string accountId, string containerId, string variableId)
                {
                    return new GetRequest(this.service, accountId, containerId, variableId);
                }

                /// <summary>Gets a GTM Variable.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Variable>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string variableId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        VariableId = variableId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Variable ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("variableId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string VariableId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/variables/{variableId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("variableId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "variableId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all GTM Variables of a Container.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual ListRequest List(string accountId, string containerId)
                {
                    return new ListRequest(this.service, accountId, containerId);
                }

                /// <summary>Lists all GTM Variables of a Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListVariablesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/variables";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a GTM Variable.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="variableId">The GTM Variable ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Variable body, string accountId, string containerId, string variableId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, variableId);
                }

                /// <summary>Updates a GTM Variable.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Variable>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Variable body, string accountId, string containerId, string variableId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        VariableId = variableId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Variable ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("variableId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string VariableId { get; private set; }

                    /// <summary>
                    /// When provided, this fingerprint must match the fingerprint of the variable in storage.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.Variable Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/variables/{variableId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("variableId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "variableId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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

                /// <summary>Creates a Container Version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.CreateContainerVersionRequestVersionOptions body, string accountId, string containerId)
                {
                    return new CreateRequest(this.service, body, accountId, containerId);
                }

                /// <summary>Creates a Container Version.</summary>
                public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.CreateContainerVersionResponse>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.CreateContainerVersionRequestVersionOptions body, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.CreateContainerVersionRequestVersionOptions Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Deletes a Container Version.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="containerVersionId">The GTM Container Version ID.</param>
                public virtual DeleteRequest Delete(string accountId, string containerId, string containerVersionId)
                {
                    return new DeleteRequest(this.service, accountId, containerId, containerVersionId);
                }

                /// <summary>Deletes a Container Version.</summary>
                public class DeleteRequest : TagManagerBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string containerVersionId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        ContainerVersionId = containerVersionId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Container Version ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerVersionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerVersionId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions/{containerVersionId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerVersionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerVersionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets a Container Version.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="containerVersionId">
                /// The GTM Container Version ID. Specify published to retrieve the currently published version.
                /// </param>
                public virtual GetRequest Get(string accountId, string containerId, string containerVersionId)
                {
                    return new GetRequest(this.service, accountId, containerId, containerVersionId);
                }

                /// <summary>Gets a Container Version.</summary>
                public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string containerVersionId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        ContainerVersionId = containerVersionId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>
                    /// The GTM Container Version ID. Specify published to retrieve the currently published version.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerVersionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerVersionId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions/{containerVersionId}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerVersionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerVersionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists all Container Versions of a GTM Container.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                public virtual ListRequest List(string accountId, string containerId)
                {
                    return new ListRequest(this.service, accountId, containerId);
                }

                /// <summary>Lists all Container Versions of a GTM Container.</summary>
                public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListContainerVersionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>Retrieve headers only when true.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("headers", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Headers { get; set; }

                    /// <summary>Also retrieve deleted (archived) versions when true.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeDeleted { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("headers", new Google.Apis.Discovery.Parameter
                        {
                            Name = "headers",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = "false",
                            Pattern = null,
                        });
                        RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeDeleted",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = "false",
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Publishes a Container Version.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="containerVersionId">The GTM Container Version ID.</param>
                public virtual PublishRequest Publish(string accountId, string containerId, string containerVersionId)
                {
                    return new PublishRequest(this.service, accountId, containerId, containerVersionId);
                }

                /// <summary>Publishes a Container Version.</summary>
                public class PublishRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.PublishContainerVersionResponse>
                {
                    /// <summary>Constructs a new Publish request.</summary>
                    public PublishRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string containerVersionId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        ContainerVersionId = containerVersionId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Container Version ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerVersionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerVersionId { get; private set; }

                    /// <summary>
                    /// When provided, this fingerprint must match the fingerprint of the container version in storage.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "publish";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions/{containerVersionId}/publish";

                    /// <summary>Initializes Publish parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerVersionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerVersionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fingerprint",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Restores a Container Version. This will overwrite the container's current configuration (including
                /// its variables, triggers and tags). The operation will not have any effect on the version that is
                /// being served (i.e. the published version).
                /// </summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="containerVersionId">The GTM Container Version ID.</param>
                public virtual RestoreRequest Restore(string accountId, string containerId, string containerVersionId)
                {
                    return new RestoreRequest(this.service, accountId, containerId, containerVersionId);
                }

                /// <summary>
                /// Restores a Container Version. This will overwrite the container's current configuration (including
                /// its variables, triggers and tags). The operation will not have any effect on the version that is
                /// being served (i.e. the published version).
                /// </summary>
                public class RestoreRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string containerVersionId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        ContainerVersionId = containerVersionId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Container Version ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerVersionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerVersionId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions/{containerVersionId}/restore";

                    /// <summary>Initializes Restore parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerVersionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerVersionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Undeletes a Container Version.</summary>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="containerVersionId">The GTM Container Version ID.</param>
                public virtual UndeleteRequest Undelete(string accountId, string containerId, string containerVersionId)
                {
                    return new UndeleteRequest(this.service, accountId, containerId, containerVersionId);
                }

                /// <summary>Undeletes a Container Version.</summary>
                public class UndeleteRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Undelete request.</summary>
                    public UndeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId, string containerVersionId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        ContainerVersionId = containerVersionId;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Container Version ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerVersionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerVersionId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "undelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions/{containerVersionId}/undelete";

                    /// <summary>Initializes Undelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerVersionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerVersionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a Container Version.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="accountId">The GTM Account ID.</param>
                /// <param name="containerId">The GTM Container ID.</param>
                /// <param name="containerVersionId">The GTM Container Version ID.</param>
                public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.ContainerVersion body, string accountId, string containerId, string containerVersionId)
                {
                    return new UpdateRequest(this.service, body, accountId, containerId, containerVersionId);
                }

                /// <summary>Updates a Container Version.</summary>
                public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ContainerVersion>
                {
                    /// <summary>Constructs a new Update request.</summary>
                    public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.ContainerVersion body, string accountId, string containerId, string containerVersionId) : base(service)
                    {
                        AccountId = accountId;
                        ContainerId = containerId;
                        ContainerVersionId = containerVersionId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>The GTM Account ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string AccountId { get; private set; }

                    /// <summary>The GTM Container ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerId { get; private set; }

                    /// <summary>The GTM Container Version ID.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("containerVersionId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ContainerVersionId { get; private set; }

                    /// <summary>
                    /// When provided, this fingerprint must match the fingerprint of the container version in storage.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Fingerprint { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.TagManager.v1.Data.ContainerVersion Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "update";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PUT";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}/versions/{containerVersionId}";

                    /// <summary>Initializes Update parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "accountId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("containerVersionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "containerVersionId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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
            /// <param name="accountId">The GTM Account ID.</param>
            public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.Container body, string accountId)
            {
                return new CreateRequest(this.service, body, accountId);
            }

            /// <summary>Creates a Container.</summary>
            public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Container>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Container body, string accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v1.Data.Container Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a Container.</summary>
            /// <param name="accountId">The GTM Account ID.</param>
            /// <param name="containerId">The GTM Container ID.</param>
            public virtual DeleteRequest Delete(string accountId, string containerId)
            {
                return new DeleteRequest(this.service, accountId, containerId);
            }

            /// <summary>Deletes a Container.</summary>
            public class DeleteRequest : TagManagerBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                {
                    AccountId = accountId;
                    ContainerId = containerId;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The GTM Container ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ContainerId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "containerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a Container.</summary>
            /// <param name="accountId">The GTM Account ID.</param>
            /// <param name="containerId">The GTM Container ID.</param>
            public virtual GetRequest Get(string accountId, string containerId)
            {
                return new GetRequest(this.service, accountId, containerId);
            }

            /// <summary>Gets a Container.</summary>
            public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Container>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string containerId) : base(service)
                {
                    AccountId = accountId;
                    ContainerId = containerId;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The GTM Container ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ContainerId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "containerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all Containers that belongs to a GTM Account.</summary>
            /// <param name="accountId">The GTM Account ID.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(this.service, accountId);
            }

            /// <summary>Lists all Containers that belongs to a GTM Account.</summary>
            public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListContainersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a Container.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The GTM Account ID.</param>
            /// <param name="containerId">The GTM Container ID.</param>
            public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Container body, string accountId, string containerId)
            {
                return new UpdateRequest(this.service, body, accountId, containerId);
            }

            /// <summary>Updates a Container.</summary>
            public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Container>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Container body, string accountId, string containerId) : base(service)
                {
                    AccountId = accountId;
                    ContainerId = containerId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The GTM Container ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("containerId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ContainerId { get; private set; }

                /// <summary>
                /// When provided, this fingerprint must match the fingerprint of the container in storage.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Fingerprint { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v1.Data.Container Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/containers/{containerId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("containerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "containerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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

        /// <summary>Gets the Permissions resource.</summary>
        public virtual PermissionsResource Permissions { get; }

        /// <summary>The "permissions" collection of methods.</summary>
        public class PermissionsResource
        {
            private const string Resource = "permissions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PermissionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a user's Account &amp; Container Permissions.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The GTM Account ID.</param>
            public virtual CreateRequest Create(Google.Apis.TagManager.v1.Data.UserAccess body, string accountId)
            {
                return new CreateRequest(this.service, body, accountId);
            }

            /// <summary>Creates a user's Account &amp; Container Permissions.</summary>
            public class CreateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.UserAccess>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.UserAccess body, string accountId) : base(service)
                {
                    AccountId = accountId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v1.Data.UserAccess Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/permissions";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Removes a user from the account, revoking access to it and all of its containers.</summary>
            /// <param name="accountId">The GTM Account ID.</param>
            /// <param name="permissionId">The GTM User ID.</param>
            public virtual DeleteRequest Delete(string accountId, string permissionId)
            {
                return new DeleteRequest(this.service, accountId, permissionId);
            }

            /// <summary>Removes a user from the account, revoking access to it and all of its containers.</summary>
            public class DeleteRequest : TagManagerBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string permissionId) : base(service)
                {
                    AccountId = accountId;
                    PermissionId = permissionId;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The GTM User ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PermissionId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/permissions/{permissionId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "permissionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a user's Account &amp; Container Permissions.</summary>
            /// <param name="accountId">The GTM Account ID.</param>
            /// <param name="permissionId">The GTM User ID.</param>
            public virtual GetRequest Get(string accountId, string permissionId)
            {
                return new GetRequest(this.service, accountId, permissionId);
            }

            /// <summary>Gets a user's Account &amp; Container Permissions.</summary>
            public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.UserAccess>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string permissionId) : base(service)
                {
                    AccountId = accountId;
                    PermissionId = permissionId;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The GTM User ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PermissionId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/permissions/{permissionId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "permissionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// List all users that have access to the account along with Account and Container Permissions granted to
            /// each of them.
            /// </summary>
            /// <param name="accountId">The GTM Account ID.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(this.service, accountId);
            }

            /// <summary>
            /// List all users that have access to the account along with Account and Container Permissions granted to
            /// each of them.
            /// </summary>
            public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListAccountUsersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/permissions";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a user's Account &amp; Container Permissions.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">The GTM Account ID.</param>
            /// <param name="permissionId">The GTM User ID.</param>
            public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.UserAccess body, string accountId, string permissionId)
            {
                return new UpdateRequest(this.service, body, accountId, permissionId);
            }

            /// <summary>Updates a user's Account &amp; Container Permissions.</summary>
            public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.UserAccess>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.UserAccess body, string accountId, string permissionId) : base(service)
                {
                    AccountId = accountId;
                    PermissionId = permissionId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The GTM Account ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The GTM User ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("permissionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PermissionId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.TagManager.v1.Data.UserAccess Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "tagmanager/v1/accounts/{accountId}/permissions/{permissionId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("permissionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "permissionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets a GTM Account.</summary>
        /// <param name="accountId">The GTM Account ID.</param>
        public virtual GetRequest Get(string accountId)
        {
            return new GetRequest(this.service, accountId);
        }

        /// <summary>Gets a GTM Account.</summary>
        public class GetRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
            {
                AccountId = accountId;
                InitParameters();
            }

            /// <summary>The GTM Account ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AccountId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tagmanager/v1/accounts/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all GTM Accounts that a user has access to.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists all GTM Accounts that a user has access to.</summary>
        public class ListRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.ListAccountsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tagmanager/v1/accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Updates a GTM Account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The GTM Account ID.</param>
        public virtual UpdateRequest Update(Google.Apis.TagManager.v1.Data.Account body, string accountId)
        {
            return new UpdateRequest(this.service, body, accountId);
        }

        /// <summary>Updates a GTM Account.</summary>
        public class UpdateRequest : TagManagerBaseServiceRequest<Google.Apis.TagManager.v1.Data.Account>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.TagManager.v1.Data.Account body, string accountId) : base(service)
            {
                AccountId = accountId;
                Body = body;
                InitParameters();
            }

            /// <summary>The GTM Account ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AccountId { get; private set; }

            /// <summary>When provided, this fingerprint must match the fingerprint of the account in storage.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fingerprint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fingerprint { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.TagManager.v1.Data.Account Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "tagmanager/v1/accounts/{accountId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fingerprint", new Google.Apis.Discovery.Parameter
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
namespace Google.Apis.TagManager.v1.Data
{
    /// <summary>Represents a Google Tag Manager Account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Account ID uniquely identifies the GTM Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Account as computed at storage time. This value is recomputed whenever the
        /// account is modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>Account display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Whether the account shares data anonymously with Google and others.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareData")]
        public virtual System.Nullable<bool> ShareData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the Google Tag Manager Account access permissions.</summary>
    public class AccountAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Account permissions. Valid account permissions are read and manage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual System.Collections.Generic.IList<string> Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a predicate.</summary>
    public class Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of named parameters (key/value), depending on the condition's type. Notes: - For binary operators,
        /// include parameters named arg0 and arg1 for specifying the left and right operands, respectively. - At this
        /// time, the left operand (arg0) must be a reference to a variable. - For case-insensitive Regex matching,
        /// include a boolean parameter named ignore_case that is set to true. If not specified or set to any other
        /// value, the matching will be case sensitive. - To negate an operator, include a boolean parameter named
        /// negate boolean parameter that is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; }

        /// <summary>The type of operator for this condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Google Tag Manager Container.</summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The Container ID uniquely identifies the GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        /// <summary>Optional list of domain names associated with the Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual System.Collections.Generic.IList<string> DomainName { get; set; }

        /// <summary>
        /// List of enabled built-in variables. Valid values include: pageUrl, pageHostname, pagePath, referrer, event,
        /// clickElement, clickClasses, clickId, clickTarget, clickUrl, clickText, formElement, formClasses, formId,
        /// formTarget, formUrl, formText, errorMessage, errorUrl, errorLine, newHistoryFragment, oldHistoryFragment,
        /// newHistoryState, oldHistoryState, historySource, containerVersion, debugMode, randomNumber, containerId.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledBuiltInVariable")]
        public virtual System.Collections.Generic.IList<string> EnabledBuiltInVariable { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Container as computed at storage time. This value is recomputed whenever the
        /// account is modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>Container display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Container Notes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>Container Public ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicId")]
        public virtual string PublicId { get; set; }

        /// <summary>Container Country ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneCountryId")]
        public virtual string TimeZoneCountryId { get; set; }

        /// <summary>Container Time Zone ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneId")]
        public virtual string TimeZoneId { get; set; }

        /// <summary>List of Usage Contexts for the Container. Valid values include: web, android, ios.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageContext")]
        public virtual System.Collections.Generic.IList<string> UsageContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the Google Tag Manager Container access permissions.</summary>
    public class ContainerAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        /// <summary>
        /// List of Container permissions. Valid container permissions are: read, edit, delete, publish.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual System.Collections.Generic.IList<string> Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Google Tag Manager Container Version.</summary>
    public class ContainerVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual Container Container { get; set; }

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        /// <summary>The Container Version ID uniquely identifies the GTM Container Version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersionId")]
        public virtual string ContainerVersionId { get; set; }

        /// <summary>A value of true indicates this container version has been deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Container Version as computed at storage time. This value is recomputed whenever
        /// the container version is modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>The folders in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folder")]
        public virtual System.Collections.Generic.IList<Folder> Folder { get; set; }

        /// <summary>The macros in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macro")]
        public virtual System.Collections.Generic.IList<Macro> Macro { get; set; }

        /// <summary>Container version display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User notes on how to apply this container version in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>The rules in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual System.Collections.Generic.IList<Rule> Rule { get; set; }

        /// <summary>The tags in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual System.Collections.Generic.IList<Tag> Tag { get; set; }

        /// <summary>The triggers in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual System.Collections.Generic.IList<Trigger> Trigger { get; set; }

        /// <summary>The variables in the container that this version was taken from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variable")]
        public virtual System.Collections.Generic.IList<Variable> Variable { get; set; }

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

        /// <summary>The creation of this version may be for quick preview and shouldn't be saved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quickPreview")]
        public virtual System.Nullable<bool> QuickPreview { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a Google Tag Manager Environment. Note that a user can create, delete and update environments of type
    /// USER, but can only update the enable_debug and url fields of environments of other types.
    /// </summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The environment authorization code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationCode")]
        public virtual string AuthorizationCode { get; set; }

        /// <summary>The last update time-stamp for the authorization code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationTimestampMs")]
        public virtual System.Nullable<long> AuthorizationTimestampMs { get; set; }

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("containerVersionId")]
        public virtual string ContainerVersionId { get; set; }

        /// <summary>The environment description. Can be set or changed only on USER type environments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Whether or not to enable debug by default on for the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableDebug")]
        public virtual System.Nullable<bool> EnableDebug { get; set; }

        /// <summary>GTM Environment ID uniquely identifies the GTM Environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environmentId")]
        public virtual string EnvironmentId { get; set; }

        /// <summary>
        /// The fingerprint of the GTM environment as computed at storage time. This value is recomputed whenever the
        /// environment is modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>The environment display name. Can be set or changed only on USER type environments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The type of this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Default preview page url for the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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

        /// <summary>
        /// The fingerprint of the GTM Folder as computed at storage time. This value is recomputed whenever the folder
        /// is modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>The Folder ID uniquely identifies the GTM Folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderId")]
        public virtual string FolderId { get; set; }

        /// <summary>Folder display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Google Tag Manager Folder's contents.</summary>
    public class FolderEntities : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>List AccountUsers Response.</summary>
    public class ListAccountUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All GTM AccountUsers of a GTM Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAccess")]
        public virtual System.Collections.Generic.IList<UserAccess> UserAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List Accounts Response.</summary>
    public class ListAccountsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of GTM Accounts that a user has access to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accounts")]
        public virtual System.Collections.Generic.IList<Account> Accounts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List container versions response.</summary>
    public class ListContainerVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All versions of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersion")]
        public virtual System.Collections.Generic.IList<ContainerVersion> ContainerVersion { get; set; }

        /// <summary>All container version headers of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersionHeader")]
        public virtual System.Collections.Generic.IList<ContainerVersionHeader> ContainerVersionHeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List Containers Response.</summary>
    public class ListContainersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All Containers of a GTM Account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List Environments Response.</summary>
    public class ListEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All Environments of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IList<Environment> Environments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List Folders Response.</summary>
    public class ListFoldersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All GTM Folders of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List Tags Response.</summary>
    public class ListTagsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All GTM Tags of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List triggers response.</summary>
    public class ListTriggersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All GTM Triggers of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggers")]
        public virtual System.Collections.Generic.IList<Trigger> Triggers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List Variables Response.</summary>
    public class ListVariablesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All GTM Variables of a GTM Container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variables")]
        public virtual System.Collections.Generic.IList<Variable> Variables { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Google Tag Manager Macro.</summary>
    public class Macro : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        /// <summary>
        /// For mobile containers only: A list of rule IDs for disabling conditional macros; the macro is enabled if one
        /// of the enabling rules is true while all the disabling rules are false. Treated as an unordered set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablingRuleId")]
        public virtual System.Collections.Generic.IList<string> DisablingRuleId { get; set; }

        /// <summary>
        /// For mobile containers only: A list of rule IDs for enabling conditional macros; the macro is enabled if one
        /// of the enabling rules is true while all the disabling rules are false. Treated as an unordered set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablingRuleId")]
        public virtual System.Collections.Generic.IList<string> EnablingRuleId { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Macro as computed at storage time. This value is recomputed whenever the macro is
        /// modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>The Macro ID uniquely identifies the GTM Macro.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macroId")]
        public virtual string MacroId { get; set; }

        /// <summary>Macro display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User notes on how to apply this macro in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>The macro's parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; }

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; }

        /// <summary>The end timestamp in milliseconds to schedule a macro.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleEndMs")]
        public virtual System.Nullable<long> ScheduleEndMs { get; set; }

        /// <summary>The start timestamp in milliseconds to schedule a macro.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleStartMs")]
        public virtual System.Nullable<long> ScheduleStartMs { get; set; }

        /// <summary>GTM Macro Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Google Tag Manager Parameter.</summary>
    public class Parameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The named key that uniquely identifies a parameter. Required for top-level parameters, as well as map
        /// values. Ignored for list values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>This list parameter's parameters (keys will be ignored).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("list")]
        public virtual System.Collections.Generic.IList<Parameter> List { get; set; }

        /// <summary>This map parameter's parameters (must have keys; keys must be unique).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("map")]
        public virtual System.Collections.Generic.IList<Parameter> Map { get; set; }

        /// <summary>
        /// The parameter type. Valid values are: - boolean: The value represents a boolean, represented as 'true' or
        /// 'false' - integer: The value represents a 64-bit signed integer value, in base 10 - list: A list of
        /// parameters should be specified - map: A map of parameters should be specified - template: The value
        /// represents any text; this can include variable references (even variable references that might return
        /// non-string types) - trigger_reference: The value represents a trigger, represented as the trigger id -
        /// tag_reference: The value represents a tag, represented as the tag name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// A parameter's value (may contain variable references). as appropriate to the specified type.
        /// </summary>
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

    /// <summary>Represents a Google Tag Manager Rule.</summary>
    public class Rule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>The list of conditions that make up this rule (implicit AND between them).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual System.Collections.Generic.IList<Condition> Condition { get; set; }

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Rule as computed at storage time. This value is recomputed whenever the rule is
        /// modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>Rule display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User notes on how to apply this rule in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>The Rule ID uniquely identifies the GTM Rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleId")]
        public virtual string RuleId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class SetupTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, fire the main tag if and only if the setup tag fires successfully. If false, fire the main tag
        /// regardless of setup tag firing status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stopOnSetupFailure")]
        public virtual System.Nullable<bool> StopOnSetupFailure { get; set; }

        /// <summary>The name of the setup tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagName")]
        public virtual string TagName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Google Tag Manager Tag.</summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Blocking rule IDs. If any of the listed rules evaluate to true, the tag will not fire.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingRuleId")]
        public virtual System.Collections.Generic.IList<string> BlockingRuleId { get; set; }

        /// <summary>
        /// Blocking trigger IDs. If any of the listed triggers evaluate to true, the tag will not fire.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockingTriggerId")]
        public virtual System.Collections.Generic.IList<string> BlockingTriggerId { get; set; }

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Tag as computed at storage time. This value is recomputed whenever the tag is
        /// modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>
        /// Firing rule IDs. A tag will fire when any of the listed rules are true and all of its blockingRuleIds (if
        /// any specified) are false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firingRuleId")]
        public virtual System.Collections.Generic.IList<string> FiringRuleId { get; set; }

        /// <summary>
        /// Firing trigger IDs. A tag will fire when any of the listed triggers are true and all of its
        /// blockingTriggerIds (if any specified) are false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firingTriggerId")]
        public virtual System.Collections.Generic.IList<string> FiringTriggerId { get; set; }

        /// <summary>
        /// If set to true, this tag will only fire in the live environment (e.g. not in preview or debug mode).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveOnly")]
        public virtual System.Nullable<bool> LiveOnly { get; set; }

        /// <summary>Tag display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User notes on how to apply this tag in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>The tag's parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; }

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; }

        /// <summary>True if the tag is paused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paused")]
        public virtual System.Nullable<bool> Paused { get; set; }

        /// <summary>
        /// User defined numeric priority of the tag. Tags are fired asynchronously in order of priority. Tags with
        /// higher numeric value fire first. A tag's priority can be a positive or negative value. The default value is
        /// 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual Parameter Priority { get; set; }

        /// <summary>The end timestamp in milliseconds to schedule a tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleEndMs")]
        public virtual System.Nullable<long> ScheduleEndMs { get; set; }

        /// <summary>The start timestamp in milliseconds to schedule a tag.</summary>
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

        /// <summary>The list of teardown tags. Currently we only allow one.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teardownTag")]
        public virtual System.Collections.Generic.IList<TeardownTag> TeardownTag { get; set; }

        /// <summary>GTM Tag Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TeardownTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, fire the teardown tag if and only if the main tag fires successfully. If false, fire the teardown
        /// tag regardless of main tag firing status.
        /// </summary>
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

        /// <summary>Used in the case of auto event tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoEventFilter")]
        public virtual System.Collections.Generic.IList<Condition> AutoEventFilter { get; set; }

        /// <summary>
        /// Whether or not we should only fire tags if the form submit or link click event is not cancelled by some
        /// other event handler (e.g. because of validation). Only valid for Form Submission and Link Click triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkValidation")]
        public virtual Parameter CheckValidation { get; set; }

        /// <summary>GTM Container ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerId")]
        public virtual string ContainerId { get; set; }

        /// <summary>
        /// A visibility trigger minimum continuous visible time (in milliseconds). Only valid for AMP Visibility
        /// trigger.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continuousTimeMinMilliseconds")]
        public virtual Parameter ContinuousTimeMinMilliseconds { get; set; }

        /// <summary>Used in the case of custom event, which is fired iff all Conditions are true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customEventFilter")]
        public virtual System.Collections.Generic.IList<Condition> CustomEventFilter { get; set; }

        /// <summary>Name of the GTM event that is fired. Only valid for Timer triggers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventName")]
        public virtual Parameter EventName { get; set; }

        /// <summary>The trigger will only fire iff all Conditions are true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual System.Collections.Generic.IList<Condition> Filter { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Trigger as computed at storage time. This value is recomputed whenever the
        /// trigger is modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>
        /// List of integer percentage values for scroll triggers. The trigger will fire when each percentage is reached
        /// when the view is scrolled horizontally. Only valid for AMP scroll triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalScrollPercentageList")]
        public virtual Parameter HorizontalScrollPercentageList { get; set; }

        /// <summary>
        /// Time between triggering recurring Timer Events (in milliseconds). Only valid for Timer triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual Parameter Interval { get; set; }

        /// <summary>Time between Timer Events to fire (in seconds). Only valid for AMP Timer trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervalSeconds")]
        public virtual Parameter IntervalSeconds { get; set; }

        /// <summary>
        /// Limit of the number of GTM events this Timer Trigger will fire. If no limit is set, we will continue to fire
        /// GTM events until the user leaves the page. Only valid for Timer triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limit")]
        public virtual Parameter Limit { get; set; }

        /// <summary>Max time to fire Timer Events (in seconds). Only valid for AMP Timer trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxTimerLengthSeconds")]
        public virtual Parameter MaxTimerLengthSeconds { get; set; }

        /// <summary>Trigger display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Additional parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; }

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; }

        /// <summary>A click trigger CSS selector (i.e. "a", "button" etc.). Only valid for AMP Click trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selector")]
        public virtual Parameter Selector { get; set; }

        /// <summary>
        /// A visibility trigger minimum total visible time (in milliseconds). Only valid for AMP Visibility trigger.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalTimeMinMilliseconds")]
        public virtual Parameter TotalTimeMinMilliseconds { get; set; }

        /// <summary>The Trigger ID uniquely identifies the GTM Trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>Defines the data layer event that causes this trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Globally unique id of the trigger that auto-generates this (a Form Submit, Link Click or Timer listener) if
        /// any. Used to make incompatible auto-events work together with trigger filtering based on trigger ids. This
        /// value is populated during output generation since the tags implied by triggers don't exist until then. Only
        /// valid for Form Submit, Link Click and Timer triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uniqueTriggerId")]
        public virtual Parameter UniqueTriggerId { get; set; }

        /// <summary>
        /// List of integer percentage values for scroll triggers. The trigger will fire when each percentage is reached
        /// when the view is scrolled vertically. Only valid for AMP scroll triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalScrollPercentageList")]
        public virtual Parameter VerticalScrollPercentageList { get; set; }

        /// <summary>A visibility trigger CSS selector (i.e. "#id"). Only valid for AMP Visibility trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibilitySelector")]
        public virtual Parameter VisibilitySelector { get; set; }

        /// <summary>A visibility trigger maximum percent visibility. Only valid for AMP Visibility trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visiblePercentageMax")]
        public virtual Parameter VisiblePercentageMax { get; set; }

        /// <summary>A visibility trigger minimum percent visibility. Only valid for AMP Visibility trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visiblePercentageMin")]
        public virtual Parameter VisiblePercentageMin { get; set; }

        /// <summary>
        /// Whether or not we should delay the form submissions or link opening until all of the tags have fired (by
        /// preventing the default action and later simulating the default action). Only valid for Form Submission and
        /// Link Click triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitForTags")]
        public virtual Parameter WaitForTags { get; set; }

        /// <summary>
        /// How long to wait (in milliseconds) for tags to fire when 'waits_for_tags' above evaluates to true. Only
        /// valid for Form Submission and Link Click triggers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waitForTagsTimeout")]
        public virtual Parameter WaitForTagsTimeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a user's permissions to an account and its container.</summary>
    public class UserAccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GTM Account access permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountAccess")]
        public virtual AccountAccess AccountAccess { get; set; }

        /// <summary>GTM Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>GTM Container access permissions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerAccess")]
        public virtual System.Collections.Generic.IList<ContainerAccess> ContainerAccess { get; set; }

        /// <summary>User's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Account Permission ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionId")]
        public virtual string PermissionId { get; set; }

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

        /// <summary>
        /// For mobile containers only: A list of trigger IDs for disabling conditional variables; the variable is
        /// enabled if one of the enabling trigger is true while all the disabling trigger are false. Treated as an
        /// unordered set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disablingTriggerId")]
        public virtual System.Collections.Generic.IList<string> DisablingTriggerId { get; set; }

        /// <summary>
        /// For mobile containers only: A list of trigger IDs for enabling conditional variables; the variable is
        /// enabled if one of the enabling triggers is true while all the disabling triggers are false. Treated as an
        /// unordered set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablingTriggerId")]
        public virtual System.Collections.Generic.IList<string> EnablingTriggerId { get; set; }

        /// <summary>
        /// The fingerprint of the GTM Variable as computed at storage time. This value is recomputed whenever the
        /// variable is modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; }

        /// <summary>Variable display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User notes on how to apply this variable in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>The variable's parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual System.Collections.Generic.IList<Parameter> Parameter { get; set; }

        /// <summary>Parent folder id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFolderId")]
        public virtual string ParentFolderId { get; set; }

        /// <summary>The end timestamp in milliseconds to schedule a variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleEndMs")]
        public virtual System.Nullable<long> ScheduleEndMs { get; set; }

        /// <summary>The start timestamp in milliseconds to schedule a variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduleStartMs")]
        public virtual System.Nullable<long> ScheduleStartMs { get; set; }

        /// <summary>GTM Variable Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The Variable ID uniquely identifies the GTM Variable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variableId")]
        public virtual string VariableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
