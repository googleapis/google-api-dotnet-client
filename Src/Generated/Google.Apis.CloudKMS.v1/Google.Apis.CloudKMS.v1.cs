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

namespace Google.Apis.CloudKMS.v1
{
    /// <summary>The CloudKMS Service.</summary>
    public class CloudKMSService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudKMSService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudKMSService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudkms.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudkms.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudkms";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Key Management Service (KMS) API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your keys and secrets stored in Cloud Key Management Service</summary>
            public static string Cloudkms = "https://www.googleapis.com/auth/cloudkms";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Cloud Key Management Service (KMS) API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your keys and secrets stored in Cloud Key Management Service</summary>
            public const string Cloudkms = "https://www.googleapis.com/auth/cloudkms";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudKMS requests.</summary>
    public abstract class CloudKMSBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudKMSBaseServiceRequest instance.</summary>
        protected CloudKMSBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudKMS parameter list.</summary>
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

        /// <summary>Returns the AutokeyConfig for a folder.</summary>
        /// <param name="name">
        /// Required. Name of the AutokeyConfig resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        public virtual GetAutokeyConfigRequest GetAutokeyConfig(string name)
        {
            return new GetAutokeyConfigRequest(this.service, name);
        }

        /// <summary>Returns the AutokeyConfig for a folder.</summary>
        public class GetAutokeyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.AutokeyConfig>
        {
            /// <summary>Constructs a new GetAutokeyConfig request.</summary>
            public GetAutokeyConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the AutokeyConfig resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getAutokeyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetAutokeyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/autokeyConfig$",
                });
            }
        }

        /// <summary>Gets the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        /// <param name="name">Required. The name of the KeyAccessJustificationsPolicyConfig to get.</param>
        public virtual GetKajPolicyConfigRequest GetKajPolicyConfig(string name)
        {
            return new GetKajPolicyConfigRequest(this.service, name);
        }

        /// <summary>Gets the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        public class GetKajPolicyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig>
        {
            /// <summary>Constructs a new GetKajPolicyConfig request.</summary>
            public GetKajPolicyConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the KeyAccessJustificationsPolicyConfig to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getKajPolicyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetKajPolicyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/kajPolicyConfig$",
                });
            }
        }

        /// <summary>
        /// Updates the AutokeyConfig for a folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy` permission on the provided key
        /// project. A KeyHandle creation in the folder's descendant projects will use this configuration to determine
        /// where to create the resulting CryptoKey.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. Name of the AutokeyConfig resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        public virtual UpdateAutokeyConfigRequest UpdateAutokeyConfig(Google.Apis.CloudKMS.v1.Data.AutokeyConfig body, string name)
        {
            return new UpdateAutokeyConfigRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates the AutokeyConfig for a folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy` permission on the provided key
        /// project. A KeyHandle creation in the folder's descendant projects will use this configuration to determine
        /// where to create the resulting CryptoKey.
        /// </summary>
        public class UpdateAutokeyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.AutokeyConfig>
        {
            /// <summary>Constructs a new UpdateAutokeyConfig request.</summary>
            public UpdateAutokeyConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.AutokeyConfig body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. Name of the AutokeyConfig resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. Masks which fields of the AutokeyConfig to update, e.g. `keyProject`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudKMS.v1.Data.AutokeyConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateAutokeyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateAutokeyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/autokeyConfig$",
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

        /// <summary>Updates the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name for this KeyAccessJustificationsPolicyConfig in the format of
        /// "{organizations|folders|projects}/*/kajPolicyConfig".
        /// </param>
        public virtual UpdateKajPolicyConfigRequest UpdateKajPolicyConfig(Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig body, string name)
        {
            return new UpdateKajPolicyConfigRequest(this.service, body, name);
        }

        /// <summary>Updates the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        public class UpdateKajPolicyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig>
        {
            /// <summary>Constructs a new UpdateKajPolicyConfig request.</summary>
            public UpdateKajPolicyConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name for this KeyAccessJustificationsPolicyConfig in the format of
            /// "{organizations|folders|projects}/*/kajPolicyConfig".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. The list of fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateKajPolicyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateKajPolicyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/kajPolicyConfig$",
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
        }

        /// <summary>Gets the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        /// <param name="name">Required. The name of the KeyAccessJustificationsPolicyConfig to get.</param>
        public virtual GetKajPolicyConfigRequest GetKajPolicyConfig(string name)
        {
            return new GetKajPolicyConfigRequest(this.service, name);
        }

        /// <summary>Gets the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        public class GetKajPolicyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig>
        {
            /// <summary>Constructs a new GetKajPolicyConfig request.</summary>
            public GetKajPolicyConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the KeyAccessJustificationsPolicyConfig to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getKajPolicyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetKajPolicyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/kajPolicyConfig$",
                });
            }
        }

        /// <summary>Updates the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name for this KeyAccessJustificationsPolicyConfig in the format of
        /// "{organizations|folders|projects}/*/kajPolicyConfig".
        /// </param>
        public virtual UpdateKajPolicyConfigRequest UpdateKajPolicyConfig(Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig body, string name)
        {
            return new UpdateKajPolicyConfigRequest(this.service, body, name);
        }

        /// <summary>Updates the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        public class UpdateKajPolicyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig>
        {
            /// <summary>Constructs a new UpdateKajPolicyConfig request.</summary>
            public UpdateKajPolicyConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name for this KeyAccessJustificationsPolicyConfig in the format of
            /// "{organizations|folders|projects}/*/kajPolicyConfig".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. The list of fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateKajPolicyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateKajPolicyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/kajPolicyConfig$",
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
                EkmConfig = new EkmConfigResource(service);
                EkmConnections = new EkmConnectionsResource(service);
                KeyHandles = new KeyHandlesResource(service);
                KeyRings = new KeyRingsResource(service);
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the EkmConfig resource.</summary>
            public virtual EkmConfigResource EkmConfig { get; }

            /// <summary>The "ekmConfig" collection of methods.</summary>
            public class EkmConfigResource
            {
                private const string Resource = "ekmConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EkmConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConfig$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConfig$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConfig$",
                        });
                    }
                }
            }

            /// <summary>Gets the EkmConnections resource.</summary>
            public virtual EkmConnectionsResource EkmConnections { get; }

            /// <summary>The "ekmConnections" collection of methods.</summary>
            public class EkmConnectionsResource
            {
                private const string Resource = "ekmConnections";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EkmConnectionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Creates a new EkmConnection in a given Project and Location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the EkmConnection, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudKMS.v1.Data.EkmConnection body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a new EkmConnection in a given Project and Location.</summary>
                public class CreateRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.EkmConnection>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.EkmConnection body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the EkmConnection, in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. It must be unique within a location and match the regular expression
                    /// `[a-zA-Z0-9_-]{1,63}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("ekmConnectionId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string EkmConnectionId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudKMS.v1.Data.EkmConnection Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/ekmConnections";

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
                        RequestParameters.Add("ekmConnectionId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "ekmConnectionId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Returns metadata for a given EkmConnection.</summary>
                /// <param name="name">Required. The name of the EkmConnection to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns metadata for a given EkmConnection.</summary>
                public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.EkmConnection>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the EkmConnection to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConnections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConnections/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists EkmConnections.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the EkmConnections to list, in the
                /// format `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists EkmConnections.</summary>
                public class ListRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ListEkmConnectionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the EkmConnections to list, in the
                    /// format `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Only include resources that match the filter in the response. For more information,
                    /// see [Sorting and filtering list
                    /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specify how the results should be sorted. If not specified, the results will be sorted
                    /// in the default order. For more information, see [Sorting and filtering list
                    /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Optional limit on the number of EkmConnections to include in the response. Further
                    /// EkmConnections can subsequently be obtained by including the
                    /// ListEkmConnectionsResponse.next_page_token in a subsequent request. If unspecified, the server
                    /// will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Optional pagination token, returned earlier via
                    /// ListEkmConnectionsResponse.next_page_token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/ekmConnections";

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

                /// <summary>Updates an EkmConnection's metadata.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Output only. The resource name for the EkmConnection in the format
                /// `projects/*/locations/*/ekmConnections/*`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudKMS.v1.Data.EkmConnection body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Updates an EkmConnection's metadata.</summary>
                public class PatchRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.EkmConnection>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.EkmConnection body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Output only. The resource name for the EkmConnection in the format
                    /// `projects/*/locations/*/ekmConnections/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. List of fields to be updated in this request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudKMS.v1.Data.EkmConnection Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConnections/[^/]+$",
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
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConnections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConnections/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Verifies that Cloud KMS can successfully connect to the external key manager specified by an
                /// EkmConnection. If there is an error connecting to the EKM, this method returns a FAILED_PRECONDITION
                /// status containing structured information as described at
                /// https://cloud.google.com/kms/docs/reference/ekm_errors.
                /// </summary>
                /// <param name="name">Required. The name of the EkmConnection to verify.</param>
                public virtual VerifyConnectivityRequest VerifyConnectivity(string name)
                {
                    return new VerifyConnectivityRequest(this.service, name);
                }

                /// <summary>
                /// Verifies that Cloud KMS can successfully connect to the external key manager specified by an
                /// EkmConnection. If there is an error connecting to the EKM, this method returns a FAILED_PRECONDITION
                /// status containing structured information as described at
                /// https://cloud.google.com/kms/docs/reference/ekm_errors.
                /// </summary>
                public class VerifyConnectivityRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.VerifyConnectivityResponse>
                {
                    /// <summary>Constructs a new VerifyConnectivity request.</summary>
                    public VerifyConnectivityRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the EkmConnection to verify.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "verifyConnectivity";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:verifyConnectivity";

                    /// <summary>Initializes VerifyConnectivity parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConnections/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the KeyHandles resource.</summary>
            public virtual KeyHandlesResource KeyHandles { get; }

            /// <summary>The "keyHandles" collection of methods.</summary>
            public class KeyHandlesResource
            {
                private const string Resource = "keyHandles";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public KeyHandlesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new KeyHandle, triggering the provisioning of a new CryptoKey for CMEK use with the given
                /// resource type in the configured key project and the same location. GetOperation should be used to
                /// resolve the resulting long-running operation and get the resulting KeyHandle and CryptoKey.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the resource project and location to create the KeyHandle in, e.g.
                /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudKMS.v1.Data.KeyHandle body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Creates a new KeyHandle, triggering the provisioning of a new CryptoKey for CMEK use with the given
                /// resource type in the configured key project and the same location. GetOperation should be used to
                /// resolve the resulting long-running operation and get the resulting KeyHandle and CryptoKey.
                /// </summary>
                public class CreateRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.KeyHandle body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource project and location to create the KeyHandle in, e.g.
                    /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Id of the KeyHandle. Must be unique to the resource project and location. If not
                    /// provided by the caller, a new UUID is used.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("keyHandleId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string KeyHandleId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudKMS.v1.Data.KeyHandle Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/keyHandles";

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
                        RequestParameters.Add("keyHandleId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "keyHandleId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Returns the KeyHandle.</summary>
                /// <param name="name">
                /// Required. Name of the KeyHandle resource, e.g.
                /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns the KeyHandle.</summary>
                public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyHandle>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the KeyHandle resource, e.g.
                    /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keyHandles/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists KeyHandles.</summary>
                /// <param name="parent">
                /// Required. Name of the resource project and location from which to list KeyHandles, e.g.
                /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists KeyHandles.</summary>
                public class ListRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ListKeyHandlesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the resource project and location from which to list KeyHandles, e.g.
                    /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter to apply when listing KeyHandles, e.g.
                    /// `resource_type_selector="{SERVICE}.googleapis.com/{TYPE}"`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Optional limit on the number of KeyHandles to include in the response. The service may
                    /// return fewer than this value. Further KeyHandles can subsequently be obtained by including the
                    /// ListKeyHandlesResponse.next_page_token in a subsequent request. If unspecified, at most 100
                    /// KeyHandles will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Optional pagination token, returned earlier via
                    /// ListKeyHandlesResponse.next_page_token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/keyHandles";

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

            /// <summary>Gets the KeyRings resource.</summary>
            public virtual KeyRingsResource KeyRings { get; }

            /// <summary>The "keyRings" collection of methods.</summary>
            public class KeyRingsResource
            {
                private const string Resource = "keyRings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public KeyRingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    CryptoKeys = new CryptoKeysResource(service);
                    ImportJobs = new ImportJobsResource(service);
                }

                /// <summary>Gets the CryptoKeys resource.</summary>
                public virtual CryptoKeysResource CryptoKeys { get; }

                /// <summary>The "cryptoKeys" collection of methods.</summary>
                public class CryptoKeysResource
                {
                    private const string Resource = "cryptoKeys";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public CryptoKeysResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        CryptoKeyVersions = new CryptoKeyVersionsResource(service);
                    }

                    /// <summary>Gets the CryptoKeyVersions resource.</summary>
                    public virtual CryptoKeyVersionsResource CryptoKeyVersions { get; }

                    /// <summary>The "cryptoKeyVersions" collection of methods.</summary>
                    public class CryptoKeyVersionsResource
                    {
                        private const string Resource = "cryptoKeyVersions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public CryptoKeyVersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Decrypts data that was encrypted with a public key retrieved from GetPublicKey corresponding
                        /// to a CryptoKeyVersion with CryptoKey.purpose ASYMMETRIC_DECRYPT.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the CryptoKeyVersion to use for decryption.
                        /// </param>
                        public virtual AsymmetricDecryptRequest AsymmetricDecrypt(Google.Apis.CloudKMS.v1.Data.AsymmetricDecryptRequest body, string name)
                        {
                            return new AsymmetricDecryptRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Decrypts data that was encrypted with a public key retrieved from GetPublicKey corresponding
                        /// to a CryptoKeyVersion with CryptoKey.purpose ASYMMETRIC_DECRYPT.
                        /// </summary>
                        public class AsymmetricDecryptRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.AsymmetricDecryptResponse>
                        {
                            /// <summary>Constructs a new AsymmetricDecrypt request.</summary>
                            public AsymmetricDecryptRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.AsymmetricDecryptRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the CryptoKeyVersion to use for decryption.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.AsymmetricDecryptRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "asymmetricDecrypt";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:asymmetricDecrypt";

                            /// <summary>Initializes AsymmetricDecrypt parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Signs data using a CryptoKeyVersion with CryptoKey.purpose ASYMMETRIC_SIGN, producing a
                        /// signature that can be verified with the public key retrieved from GetPublicKey.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the CryptoKeyVersion to use for signing.
                        /// </param>
                        public virtual AsymmetricSignRequest AsymmetricSign(Google.Apis.CloudKMS.v1.Data.AsymmetricSignRequest body, string name)
                        {
                            return new AsymmetricSignRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Signs data using a CryptoKeyVersion with CryptoKey.purpose ASYMMETRIC_SIGN, producing a
                        /// signature that can be verified with the public key retrieved from GetPublicKey.
                        /// </summary>
                        public class AsymmetricSignRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.AsymmetricSignResponse>
                        {
                            /// <summary>Constructs a new AsymmetricSign request.</summary>
                            public AsymmetricSignRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.AsymmetricSignRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the CryptoKeyVersion to use for signing.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.AsymmetricSignRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "asymmetricSign";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:asymmetricSign";

                            /// <summary>Initializes AsymmetricSign parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Create a new CryptoKeyVersion in a CryptoKey. The server will assign the next sequential id.
                        /// If unset, state will be set to ENABLED.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The name of the CryptoKey associated with the CryptoKeyVersions.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion body, string parent)
                        {
                            return new CreateRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Create a new CryptoKeyVersion in a CryptoKey. The server will assign the next sequential id.
                        /// If unset, state will be set to ENABLED.
                        /// </summary>
                        public class CreateRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the CryptoKey associated with the CryptoKeyVersions.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/cryptoKeyVersions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Schedule a CryptoKeyVersion for destruction. Upon calling this method,
                        /// CryptoKeyVersion.state will be set to DESTROY_SCHEDULED, and destroy_time will be set to the
                        /// time destroy_scheduled_duration in the future. At that time, the state will automatically
                        /// change to DESTROYED, and the key material will be irrevocably destroyed. Before the
                        /// destroy_time is reached, RestoreCryptoKeyVersion may be called to reverse the process.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The resource name of the CryptoKeyVersion to destroy.</param>
                        public virtual DestroyRequest Destroy(Google.Apis.CloudKMS.v1.Data.DestroyCryptoKeyVersionRequest body, string name)
                        {
                            return new DestroyRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Schedule a CryptoKeyVersion for destruction. Upon calling this method,
                        /// CryptoKeyVersion.state will be set to DESTROY_SCHEDULED, and destroy_time will be set to the
                        /// time destroy_scheduled_duration in the future. At that time, the state will automatically
                        /// change to DESTROYED, and the key material will be irrevocably destroyed. Before the
                        /// destroy_time is reached, RestoreCryptoKeyVersion may be called to reverse the process.
                        /// </summary>
                        public class DestroyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion>
                        {
                            /// <summary>Constructs a new Destroy request.</summary>
                            public DestroyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.DestroyCryptoKeyVersionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the CryptoKeyVersion to destroy.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.DestroyCryptoKeyVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "destroy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:destroy";

                            /// <summary>Initializes Destroy parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Returns metadata for a given CryptoKeyVersion.</summary>
                        /// <param name="name">Required. The name of the CryptoKeyVersion to get.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(this.service, name);
                        }

                        /// <summary>Returns metadata for a given CryptoKeyVersion.</summary>
                        public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the CryptoKeyVersion to get.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Returns the public key for the given CryptoKeyVersion. The CryptoKey.purpose must be
                        /// ASYMMETRIC_SIGN or ASYMMETRIC_DECRYPT.
                        /// </summary>
                        /// <param name="name">Required. The name of the CryptoKeyVersion public key to get.</param>
                        public virtual GetPublicKeyRequest GetPublicKey(string name)
                        {
                            return new GetPublicKeyRequest(this.service, name);
                        }

                        /// <summary>
                        /// Returns the public key for the given CryptoKeyVersion. The CryptoKey.purpose must be
                        /// ASYMMETRIC_SIGN or ASYMMETRIC_DECRYPT.
                        /// </summary>
                        public class GetPublicKeyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.PublicKey>
                        {
                            /// <summary>Constructs a new GetPublicKey request.</summary>
                            public GetPublicKeyRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the CryptoKeyVersion public key to get.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. The PublicKey format specified by the user. This field is required for PQC
                            /// algorithms. If specified, the public key will be exported through the public_key field
                            /// in the requested format. Otherwise, the pem field will be populated for non-PQC
                            /// algorithms, and an error will be returned for PQC algorithms.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("publicKeyFormat", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<PublicKeyFormatEnum> PublicKeyFormat { get; set; }

                            /// <summary>
                            /// Optional. The PublicKey format specified by the user. This field is required for PQC
                            /// algorithms. If specified, the public key will be exported through the public_key field
                            /// in the requested format. Otherwise, the pem field will be populated for non-PQC
                            /// algorithms, and an error will be returned for PQC algorithms.
                            /// </summary>
                            public enum PublicKeyFormatEnum
                            {
                                /// <summary>
                                /// If the public_key_format field is not specified: - For PQC algorithms, an error will
                                /// be returned. - For non-PQC algorithms, the default format is PEM, and the field pem
                                /// will be populated. Otherwise, the public key will be exported through the public_key
                                /// field in the requested format.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("PUBLIC_KEY_FORMAT_UNSPECIFIED")]
                                PUBLICKEYFORMATUNSPECIFIED = 0,

                                /// <summary>
                                /// The returned public key will be encoded in PEM format. See the
                                /// [RFC7468](https://tools.ietf.org/html/rfc7468) sections for [General
                                /// Considerations](https://tools.ietf.org/html/rfc7468#section-2) and [Textual Encoding
                                /// of Subject Public Key Info] (https://tools.ietf.org/html/rfc7468#section-13) for
                                /// more information.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("PEM")]
                                PEM = 1,

                                /// <summary>
                                /// This is supported only for PQC algorithms. The key material is returned in the
                                /// format defined by NIST PQC standards (FIPS 203, FIPS 204, and FIPS 205).
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("NIST_PQC")]
                                NISTPQC = 2,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "getPublicKey";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/publicKey";

                            /// <summary>Initializes GetPublicKey parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                                RequestParameters.Add("publicKeyFormat", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "publicKeyFormat",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Import wrapped key material into a CryptoKeyVersion. All requests must specify a CryptoKey.
                        /// If a CryptoKeyVersion is additionally specified in the request, key material will be
                        /// reimported into that version. Otherwise, a new version will be created, and will be assigned
                        /// the next sequential id within the CryptoKey.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The name of the CryptoKey to be imported into. The create permission is only
                        /// required on this key when creating a new CryptoKeyVersion.
                        /// </param>
                        public virtual ImportRequest Import(Google.Apis.CloudKMS.v1.Data.ImportCryptoKeyVersionRequest body, string parent)
                        {
                            return new ImportRequest(this.service, body, parent);
                        }

                        /// <summary>
                        /// Import wrapped key material into a CryptoKeyVersion. All requests must specify a CryptoKey.
                        /// If a CryptoKeyVersion is additionally specified in the request, key material will be
                        /// reimported into that version. Otherwise, a new version will be created, and will be assigned
                        /// the next sequential id within the CryptoKey.
                        /// </summary>
                        public class ImportRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion>
                        {
                            /// <summary>Constructs a new Import request.</summary>
                            public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.ImportCryptoKeyVersionRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the CryptoKey to be imported into. The create permission is only
                            /// required on this key when creating a new CryptoKeyVersion.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.ImportCryptoKeyVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "import";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/cryptoKeyVersions:import";

                            /// <summary>Initializes Import parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists CryptoKeyVersions.</summary>
                        /// <param name="parent">
                        /// Required. The resource name of the CryptoKey to list, in the format
                        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(this.service, parent);
                        }

                        /// <summary>Lists CryptoKeyVersions.</summary>
                        public class ListRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ListCryptoKeyVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the CryptoKey to list, in the format
                            /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Only include resources that match the filter in the response. For more
                            /// information, see [Sorting and filtering list
                            /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Specify how the results should be sorted. If not specified, the results will
                            /// be sorted in the default order. For more information, see [Sorting and filtering list
                            /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Optional. Optional limit on the number of CryptoKeyVersions to include in the response.
                            /// Further CryptoKeyVersions can subsequently be obtained by including the
                            /// ListCryptoKeyVersionsResponse.next_page_token in a subsequent request. If unspecified,
                            /// the server will pick an appropriate default.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Optional pagination token, returned earlier via
                            /// ListCryptoKeyVersionsResponse.next_page_token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>The fields to include in the response.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>The fields to include in the response.</summary>
                            public enum ViewEnum
                            {
                                /// <summary>
                                /// Default view for each CryptoKeyVersion. Does not include the attestation field.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("CRYPTO_KEY_VERSION_VIEW_UNSPECIFIED")]
                                CRYPTOKEYVERSIONVIEWUNSPECIFIED = 0,

                                /// <summary>
                                /// Provides all fields in each CryptoKeyVersion, including the attestation.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("FULL")]
                                FULL = 1,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/cryptoKeyVersions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
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
                        /// Signs data using a CryptoKeyVersion with CryptoKey.purpose MAC, producing a tag that can be
                        /// verified by another source with the same key.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the CryptoKeyVersion to use for signing.
                        /// </param>
                        public virtual MacSignRequest MacSign(Google.Apis.CloudKMS.v1.Data.MacSignRequest body, string name)
                        {
                            return new MacSignRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Signs data using a CryptoKeyVersion with CryptoKey.purpose MAC, producing a tag that can be
                        /// verified by another source with the same key.
                        /// </summary>
                        public class MacSignRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.MacSignResponse>
                        {
                            /// <summary>Constructs a new MacSign request.</summary>
                            public MacSignRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.MacSignRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the CryptoKeyVersion to use for signing.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.MacSignRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "macSign";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:macSign";

                            /// <summary>Initializes MacSign parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Verifies MAC tag using a CryptoKeyVersion with CryptoKey.purpose MAC, and returns a response
                        /// that indicates whether or not the verification was successful.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the CryptoKeyVersion to use for verification.
                        /// </param>
                        public virtual MacVerifyRequest MacVerify(Google.Apis.CloudKMS.v1.Data.MacVerifyRequest body, string name)
                        {
                            return new MacVerifyRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Verifies MAC tag using a CryptoKeyVersion with CryptoKey.purpose MAC, and returns a response
                        /// that indicates whether or not the verification was successful.
                        /// </summary>
                        public class MacVerifyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.MacVerifyResponse>
                        {
                            /// <summary>Constructs a new MacVerify request.</summary>
                            public MacVerifyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.MacVerifyRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the CryptoKeyVersion to use for verification.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.MacVerifyRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "macVerify";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:macVerify";

                            /// <summary>Initializes MacVerify parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Update a CryptoKeyVersion's metadata. state may be changed between ENABLED and DISABLED
                        /// using this method. See DestroyCryptoKeyVersion and RestoreCryptoKeyVersion to move between
                        /// other states.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Output only. The resource name for this CryptoKeyVersion in the format
                        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*`.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion body, string name)
                        {
                            return new PatchRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Update a CryptoKeyVersion's metadata. state may be changed between ENABLED and DISABLED
                        /// using this method. See DestroyCryptoKeyVersion and RestoreCryptoKeyVersion to move between
                        /// other states.
                        /// </summary>
                        public class PatchRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Output only. The resource name for this CryptoKeyVersion in the format
                            /// `projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Required. List of fields to be updated in this request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion Body { get; set; }

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
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
                        /// Decrypts data that was originally encrypted using a raw cryptographic mechanism. The
                        /// CryptoKey.purpose must be RAW_ENCRYPT_DECRYPT.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the CryptoKeyVersion to use for decryption.
                        /// </param>
                        public virtual RawDecryptRequest RawDecrypt(Google.Apis.CloudKMS.v1.Data.RawDecryptRequest body, string name)
                        {
                            return new RawDecryptRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Decrypts data that was originally encrypted using a raw cryptographic mechanism. The
                        /// CryptoKey.purpose must be RAW_ENCRYPT_DECRYPT.
                        /// </summary>
                        public class RawDecryptRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.RawDecryptResponse>
                        {
                            /// <summary>Constructs a new RawDecrypt request.</summary>
                            public RawDecryptRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.RawDecryptRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the CryptoKeyVersion to use for decryption.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.RawDecryptRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "rawDecrypt";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:rawDecrypt";

                            /// <summary>Initializes RawDecrypt parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Encrypts data using portable cryptographic primitives. Most users should choose Encrypt and
                        /// Decrypt rather than their raw counterparts. The CryptoKey.purpose must be
                        /// RAW_ENCRYPT_DECRYPT.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the CryptoKeyVersion to use for encryption.
                        /// </param>
                        public virtual RawEncryptRequest RawEncrypt(Google.Apis.CloudKMS.v1.Data.RawEncryptRequest body, string name)
                        {
                            return new RawEncryptRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Encrypts data using portable cryptographic primitives. Most users should choose Encrypt and
                        /// Decrypt rather than their raw counterparts. The CryptoKey.purpose must be
                        /// RAW_ENCRYPT_DECRYPT.
                        /// </summary>
                        public class RawEncryptRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.RawEncryptResponse>
                        {
                            /// <summary>Constructs a new RawEncrypt request.</summary>
                            public RawEncryptRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.RawEncryptRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the CryptoKeyVersion to use for encryption.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.RawEncryptRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "rawEncrypt";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:rawEncrypt";

                            /// <summary>Initializes RawEncrypt parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Restore a CryptoKeyVersion in the DESTROY_SCHEDULED state. Upon restoration of the
                        /// CryptoKeyVersion, state will be set to DISABLED, and destroy_time will be cleared.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The resource name of the CryptoKeyVersion to restore.</param>
                        public virtual RestoreRequest Restore(Google.Apis.CloudKMS.v1.Data.RestoreCryptoKeyVersionRequest body, string name)
                        {
                            return new RestoreRequest(this.service, body, name);
                        }

                        /// <summary>
                        /// Restore a CryptoKeyVersion in the DESTROY_SCHEDULED state. Upon restoration of the
                        /// CryptoKeyVersion, state will be set to DISABLED, and destroy_time will be cleared.
                        /// </summary>
                        public class RestoreRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKeyVersion>
                        {
                            /// <summary>Constructs a new Restore request.</summary>
                            public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.RestoreCryptoKeyVersionRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the CryptoKeyVersion to restore.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudKMS.v1.Data.RestoreCryptoKeyVersionRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "restore";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:restore";

                            /// <summary>Initializes Restore parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+/cryptoKeyVersions/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Create a new CryptoKey within a KeyRing. CryptoKey.purpose and
                    /// CryptoKey.version_template.algorithm are required.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The name of the KeyRing associated with the CryptoKeys.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudKMS.v1.Data.CryptoKey body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>
                    /// Create a new CryptoKey within a KeyRing. CryptoKey.purpose and
                    /// CryptoKey.version_template.algorithm are required.
                    /// </summary>
                    public class CreateRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKey>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.CryptoKey body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the KeyRing associated with the CryptoKeys.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. It must be unique within a KeyRing and match the regular expression
                        /// `[a-zA-Z0-9_-]{1,63}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("cryptoKeyId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string CryptoKeyId { get; set; }

                        /// <summary>
                        /// If set to true, the request will create a CryptoKey without any CryptoKeyVersions. You must
                        /// manually call CreateCryptoKeyVersion or ImportCryptoKeyVersion before you can use this
                        /// CryptoKey.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("skipInitialVersionCreation", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> SkipInitialVersionCreation { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.CryptoKey Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/cryptoKeys";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
                            });
                            RequestParameters.Add("cryptoKeyId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "cryptoKeyId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("skipInitialVersionCreation", new Google.Apis.Discovery.Parameter
                            {
                                Name = "skipInitialVersionCreation",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Decrypts data that was protected by Encrypt. The CryptoKey.purpose must be ENCRYPT_DECRYPT.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the CryptoKey to use for decryption. The server will choose the
                    /// appropriate version.
                    /// </param>
                    public virtual DecryptRequest Decrypt(Google.Apis.CloudKMS.v1.Data.DecryptRequest body, string name)
                    {
                        return new DecryptRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Decrypts data that was protected by Encrypt. The CryptoKey.purpose must be ENCRYPT_DECRYPT.
                    /// </summary>
                    public class DecryptRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.DecryptResponse>
                    {
                        /// <summary>Constructs a new Decrypt request.</summary>
                        public DecryptRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.DecryptRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the CryptoKey to use for decryption. The server will choose
                        /// the appropriate version.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.DecryptRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "decrypt";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:decrypt";

                        /// <summary>Initializes Decrypt parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Encrypts data, so that it can only be recovered by a call to Decrypt. The CryptoKey.purpose must
                    /// be ENCRYPT_DECRYPT.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The resource name of the CryptoKey or CryptoKeyVersion to use for encryption. If a
                    /// CryptoKey is specified, the server will use its primary version.
                    /// </param>
                    public virtual EncryptRequest Encrypt(Google.Apis.CloudKMS.v1.Data.EncryptRequest body, string name)
                    {
                        return new EncryptRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Encrypts data, so that it can only be recovered by a call to Decrypt. The CryptoKey.purpose must
                    /// be ENCRYPT_DECRYPT.
                    /// </summary>
                    public class EncryptRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.EncryptResponse>
                    {
                        /// <summary>Constructs a new Encrypt request.</summary>
                        public EncryptRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.EncryptRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the CryptoKey or CryptoKeyVersion to use for encryption. If a
                        /// CryptoKey is specified, the server will use its primary version.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.EncryptRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "encrypt";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:encrypt";

                        /// <summary>Initializes Encrypt parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/.*$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns metadata for a given CryptoKey, as well as its primary CryptoKeyVersion.
                    /// </summary>
                    /// <param name="name">Required. The name of the CryptoKey to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>
                    /// Returns metadata for a given CryptoKey, as well as its primary CryptoKeyVersion.
                    /// </summary>
                    public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKey>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the CryptoKey to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists CryptoKeys.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the KeyRing to list, in the format
                    /// `projects/*/locations/*/keyRings/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists CryptoKeys.</summary>
                    public class ListRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ListCryptoKeysResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the KeyRing to list, in the format
                        /// `projects/*/locations/*/keyRings/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Only include resources that match the filter in the response. For more
                        /// information, see [Sorting and filtering list
                        /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify how the results should be sorted. If not specified, the results will be
                        /// sorted in the default order. For more information, see [Sorting and filtering list
                        /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Optional limit on the number of CryptoKeys to include in the response. Further
                        /// CryptoKeys can subsequently be obtained by including the
                        /// ListCryptoKeysResponse.next_page_token in a subsequent request. If unspecified, the server
                        /// will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Optional pagination token, returned earlier via
                        /// ListCryptoKeysResponse.next_page_token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>The fields of the primary version to include in the response.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("versionView", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<VersionViewEnum> VersionView { get; set; }

                        /// <summary>The fields of the primary version to include in the response.</summary>
                        public enum VersionViewEnum
                        {
                            /// <summary>
                            /// Default view for each CryptoKeyVersion. Does not include the attestation field.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("CRYPTO_KEY_VERSION_VIEW_UNSPECIFIED")]
                            CRYPTOKEYVERSIONVIEWUNSPECIFIED = 0,

                            /// <summary>
                            /// Provides all fields in each CryptoKeyVersion, including the attestation.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("FULL")]
                            FULL = 1,
                        }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/cryptoKeys";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
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
                            RequestParameters.Add("versionView", new Google.Apis.Discovery.Parameter
                            {
                                Name = "versionView",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Update a CryptoKey.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. The resource name for this CryptoKey in the format
                    /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudKMS.v1.Data.CryptoKey body, string name)
                    {
                        return new PatchRequest(this.service, body, name);
                    }

                    /// <summary>Update a CryptoKey.</summary>
                    public class PatchRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKey>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.CryptoKey body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. The resource name for this CryptoKey in the format
                        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. List of fields to be updated in this request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.CryptoKey Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Update the version of a CryptoKey that will be used in Encrypt. Returns an error if called on a
                    /// key whose purpose is not ENCRYPT_DECRYPT.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The resource name of the CryptoKey to update.</param>
                    public virtual UpdatePrimaryVersionRequest UpdatePrimaryVersion(Google.Apis.CloudKMS.v1.Data.UpdateCryptoKeyPrimaryVersionRequest body, string name)
                    {
                        return new UpdatePrimaryVersionRequest(this.service, body, name);
                    }

                    /// <summary>
                    /// Update the version of a CryptoKey that will be used in Encrypt. Returns an error if called on a
                    /// key whose purpose is not ENCRYPT_DECRYPT.
                    /// </summary>
                    public class UpdatePrimaryVersionRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.CryptoKey>
                    {
                        /// <summary>Constructs a new UpdatePrimaryVersion request.</summary>
                        public UpdatePrimaryVersionRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.UpdateCryptoKeyPrimaryVersionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the CryptoKey to update.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.UpdateCryptoKeyPrimaryVersionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "updatePrimaryVersion";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:updatePrimaryVersion";

                        /// <summary>Initializes UpdatePrimaryVersion parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/cryptoKeys/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the ImportJobs resource.</summary>
                public virtual ImportJobsResource ImportJobs { get; }

                /// <summary>The "importJobs" collection of methods.</summary>
                public class ImportJobsResource
                {
                    private const string Resource = "importJobs";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ImportJobsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create a new ImportJob within a KeyRing. ImportJob.import_method is required.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The name of the KeyRing associated with the ImportJobs.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudKMS.v1.Data.ImportJob body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create a new ImportJob within a KeyRing. ImportJob.import_method is required.</summary>
                    public class CreateRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ImportJob>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.ImportJob body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the KeyRing associated with the ImportJobs.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. It must be unique within a KeyRing and match the regular expression
                        /// `[a-zA-Z0-9_-]{1,63}`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("importJobId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ImportJobId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.ImportJob Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/importJobs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
                            });
                            RequestParameters.Add("importJobId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "importJobId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Returns metadata for a given ImportJob.</summary>
                    /// <param name="name">Required. The name of the ImportJob to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(this.service, name);
                    }

                    /// <summary>Returns metadata for a given ImportJob.</summary>
                    public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ImportJob>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the ImportJob to get.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/importJobs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(this.service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The maximum policy version that will be used to format the policy. Valid values
                        /// are 0, 1, and 3. Requests specifying an invalid value will be rejected. Requests for
                        /// policies with any conditional role bindings must specify version 3. Policies with no
                        /// conditional role bindings may specify any valid value or leave the field unset. The policy
                        /// in the response might use the policy version that you specified, or it might use a lower
                        /// policy version. For example, if you specify version 3, but the policy has no conditional
                        /// role bindings, the response uses version 1. To learn which resources support conditions in
                        /// their IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/importJobs/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists ImportJobs.</summary>
                    /// <param name="parent">
                    /// Required. The resource name of the KeyRing to list, in the format
                    /// `projects/*/locations/*/keyRings/*`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>Lists ImportJobs.</summary>
                    public class ListRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ListImportJobsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The resource name of the KeyRing to list, in the format
                        /// `projects/*/locations/*/keyRings/*`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Only include resources that match the filter in the response. For more
                        /// information, see [Sorting and filtering list
                        /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Specify how the results should be sorted. If not specified, the results will be
                        /// sorted in the default order. For more information, see [Sorting and filtering list
                        /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OrderBy { get; set; }

                        /// <summary>
                        /// Optional. Optional limit on the number of ImportJobs to include in the response. Further
                        /// ImportJobs can subsequently be obtained by including the
                        /// ListImportJobsResponse.next_page_token in a subsequent request. If unspecified, the server
                        /// will pick an appropriate default.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Optional pagination token, returned earlier via
                        /// ListImportJobsResponse.next_page_token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/importJobs";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
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
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/importJobs/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(this.service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+/importJobs/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Create a new KeyRing in a given Project and Location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the KeyRings, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudKMS.v1.Data.KeyRing body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Create a new KeyRing in a given Project and Location.</summary>
                public class CreateRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyRing>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.KeyRing body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the KeyRings, in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. It must be unique within a location and match the regular expression
                    /// `[a-zA-Z0-9_-]{1,63}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("keyRingId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string KeyRingId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudKMS.v1.Data.KeyRing Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/keyRings";

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
                        RequestParameters.Add("keyRingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "keyRingId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Returns metadata for a given KeyRing.</summary>
                /// <param name="name">Required. The name of the KeyRing to get.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Returns metadata for a given KeyRing.</summary>
                public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyRing>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the KeyRing to get.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(this.service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0,
                    /// 1, and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                    /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                    /// specify any valid value or leave the field unset. The policy in the response might use the
                    /// policy version that you specified, or it might use a lower policy version. For example, if you
                    /// specify version 3, but the policy has no conditional role bindings, the response uses version 1.
                    /// To learn which resources support conditions in their IAM policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists KeyRings.</summary>
                /// <param name="parent">
                /// Required. The resource name of the location associated with the KeyRings, in the format
                /// `projects/*/locations/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Lists KeyRings.</summary>
                public class ListRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ListKeyRingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the location associated with the KeyRings, in the format
                    /// `projects/*/locations/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Only include resources that match the filter in the response. For more information,
                    /// see [Sorting and filtering list
                    /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Specify how the results should be sorted. If not specified, the results will be sorted
                    /// in the default order. For more information, see [Sorting and filtering list
                    /// results](https://cloud.google.com/kms/docs/sorting-and-filtering).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Optional. Optional limit on the number of KeyRings to include in the response. Further KeyRings
                    /// can subsequently be obtained by including the ListKeyRingsResponse.next_page_token in a
                    /// subsequent request. If unspecified, the server will pick an appropriate default.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. Optional pagination token, returned earlier via ListKeyRingsResponse.next_page_token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/keyRings";

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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(this.service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(this.service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                    Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/keyRings/[^/]+$",
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
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Operation>
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
            }

            /// <summary>Generate random bytes using the Cloud KMS randomness source in the provided location.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="location">
            /// The project-specific location in which to generate random bytes. For example,
            /// "projects/my-project/locations/us-central1".
            /// </param>
            public virtual GenerateRandomBytesRequest GenerateRandomBytes(Google.Apis.CloudKMS.v1.Data.GenerateRandomBytesRequest body, string location)
            {
                return new GenerateRandomBytesRequest(this.service, body, location);
            }

            /// <summary>Generate random bytes using the Cloud KMS randomness source in the provided location.</summary>
            public class GenerateRandomBytesRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.GenerateRandomBytesResponse>
            {
                /// <summary>Constructs a new GenerateRandomBytes request.</summary>
                public GenerateRandomBytesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.GenerateRandomBytesRequest body, string location) : base(service)
                {
                    Location = location;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The project-specific location in which to generate random bytes. For example,
                /// "projects/my-project/locations/us-central1".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("location", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Location { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudKMS.v1.Data.GenerateRandomBytesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generateRandomBytes";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+location}:generateRandomBytes";

                /// <summary>Initializes GenerateRandomBytes parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("location", new Google.Apis.Discovery.Parameter
                    {
                        Name = "location",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.Location>
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

            /// <summary>Returns the EkmConfig singleton resource for a given project and location.</summary>
            /// <param name="name">Required. The name of the EkmConfig to get.</param>
            public virtual GetEkmConfigRequest GetEkmConfig(string name)
            {
                return new GetEkmConfigRequest(this.service, name);
            }

            /// <summary>Returns the EkmConfig singleton resource for a given project and location.</summary>
            public class GetEkmConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.EkmConfig>
            {
                /// <summary>Constructs a new GetEkmConfig request.</summary>
                public GetEkmConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the EkmConfig to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getEkmConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetEkmConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConfig$",
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
            public class ListRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ListLocationsResponse>
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

            /// <summary>Updates the EkmConfig singleton resource for a given project and location.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Output only. The resource name for the EkmConfig in the format `projects/*/locations/*/ekmConfig`.
            /// </param>
            public virtual UpdateEkmConfigRequest UpdateEkmConfig(Google.Apis.CloudKMS.v1.Data.EkmConfig body, string name)
            {
                return new UpdateEkmConfigRequest(this.service, body, name);
            }

            /// <summary>Updates the EkmConfig singleton resource for a given project and location.</summary>
            public class UpdateEkmConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.EkmConfig>
            {
                /// <summary>Constructs a new UpdateEkmConfig request.</summary>
                public UpdateEkmConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.EkmConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Output only. The resource name for the EkmConfig in the format `projects/*/locations/*/ekmConfig`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. List of fields to be updated in this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudKMS.v1.Data.EkmConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateEkmConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateEkmConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+/ekmConfig$",
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

        /// <summary>Gets the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        /// <param name="name">Required. The name of the KeyAccessJustificationsPolicyConfig to get.</param>
        public virtual GetKajPolicyConfigRequest GetKajPolicyConfig(string name)
        {
            return new GetKajPolicyConfigRequest(this.service, name);
        }

        /// <summary>Gets the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        public class GetKajPolicyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig>
        {
            /// <summary>Constructs a new GetKajPolicyConfig request.</summary>
            public GetKajPolicyConfigRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the KeyAccessJustificationsPolicyConfig to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getKajPolicyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetKajPolicyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/kajPolicyConfig$",
                });
            }
        }

        /// <summary>Returns the effective Cloud KMS Autokey configuration for a given project.</summary>
        /// <param name="parent">
        /// Required. Name of the resource project to the show effective Cloud KMS Autokey configuration for. This may
        /// be helpful for interrogating the effect of nested folder configurations on a given resource project.
        /// </param>
        public virtual ShowEffectiveAutokeyConfigRequest ShowEffectiveAutokeyConfig(string parent)
        {
            return new ShowEffectiveAutokeyConfigRequest(this.service, parent);
        }

        /// <summary>Returns the effective Cloud KMS Autokey configuration for a given project.</summary>
        public class ShowEffectiveAutokeyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ShowEffectiveAutokeyConfigResponse>
        {
            /// <summary>Constructs a new ShowEffectiveAutokeyConfig request.</summary>
            public ShowEffectiveAutokeyConfigRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the resource project to the show effective Cloud KMS Autokey configuration for. This
            /// may be helpful for interrogating the effect of nested folder configurations on a given resource project.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "showEffectiveAutokeyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+parent}:showEffectiveAutokeyConfig";

            /// <summary>Initializes ShowEffectiveAutokeyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns the KeyAccessJustificationsEnrollmentConfig of the resource closest to the given project in
        /// hierarchy.
        /// </summary>
        /// <param name="project">
        /// Required. The number or id of the project to get the effective KeyAccessJustificationsEnrollmentConfig for.
        /// </param>
        public virtual ShowEffectiveKeyAccessJustificationsEnrollmentConfigRequest ShowEffectiveKeyAccessJustificationsEnrollmentConfig(string project)
        {
            return new ShowEffectiveKeyAccessJustificationsEnrollmentConfigRequest(this.service, project);
        }

        /// <summary>
        /// Returns the KeyAccessJustificationsEnrollmentConfig of the resource closest to the given project in
        /// hierarchy.
        /// </summary>
        public class ShowEffectiveKeyAccessJustificationsEnrollmentConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ShowEffectiveKeyAccessJustificationsEnrollmentConfigResponse>
        {
            /// <summary>Constructs a new ShowEffectiveKeyAccessJustificationsEnrollmentConfig request.</summary>
            public ShowEffectiveKeyAccessJustificationsEnrollmentConfigRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>
            /// Required. The number or id of the project to get the effective KeyAccessJustificationsEnrollmentConfig
            /// for.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "showEffectiveKeyAccessJustificationsEnrollmentConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+project}:showEffectiveKeyAccessJustificationsEnrollmentConfig";

            /// <summary>Initializes ShowEffectiveKeyAccessJustificationsEnrollmentConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Returns the KeyAccessJustificationsPolicyConfig of the resource closest to the given project in hierarchy.
        /// </summary>
        /// <param name="project">
        /// Required. The number or id of the project to get the effective KeyAccessJustificationsPolicyConfig. In the
        /// format of "projects/{|}"
        /// </param>
        public virtual ShowEffectiveKeyAccessJustificationsPolicyConfigRequest ShowEffectiveKeyAccessJustificationsPolicyConfig(string project)
        {
            return new ShowEffectiveKeyAccessJustificationsPolicyConfigRequest(this.service, project);
        }

        /// <summary>
        /// Returns the KeyAccessJustificationsPolicyConfig of the resource closest to the given project in hierarchy.
        /// </summary>
        public class ShowEffectiveKeyAccessJustificationsPolicyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.ShowEffectiveKeyAccessJustificationsPolicyConfigResponse>
        {
            /// <summary>Constructs a new ShowEffectiveKeyAccessJustificationsPolicyConfig request.</summary>
            public ShowEffectiveKeyAccessJustificationsPolicyConfigRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>
            /// Required. The number or id of the project to get the effective KeyAccessJustificationsPolicyConfig. In
            /// the format of "projects/{|}"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "showEffectiveKeyAccessJustificationsPolicyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+project}:showEffectiveKeyAccessJustificationsPolicyConfig";

            /// <summary>Initializes ShowEffectiveKeyAccessJustificationsPolicyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }

        /// <summary>Updates the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name for this KeyAccessJustificationsPolicyConfig in the format of
        /// "{organizations|folders|projects}/*/kajPolicyConfig".
        /// </param>
        public virtual UpdateKajPolicyConfigRequest UpdateKajPolicyConfig(Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig body, string name)
        {
            return new UpdateKajPolicyConfigRequest(this.service, body, name);
        }

        /// <summary>Updates the KeyAccessJustificationsPolicyConfig for a given organization/folder/projects.</summary>
        public class UpdateKajPolicyConfigRequest : CloudKMSBaseServiceRequest<Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig>
        {
            /// <summary>Constructs a new UpdateKajPolicyConfig request.</summary>
            public UpdateKajPolicyConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name for this KeyAccessJustificationsPolicyConfig in the format of
            /// "{organizations|folders|projects}/*/kajPolicyConfig".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. The list of fields to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudKMS.v1.Data.KeyAccessJustificationsPolicyConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateKajPolicyConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateKajPolicyConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/kajPolicyConfig$",
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
namespace Google.Apis.CloudKMS.v1.Data
{
    /// <summary>Request message for KeyManagementService.AsymmetricDecrypt.</summary>
    public class AsymmetricDecryptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The data encrypted with the named CryptoKeyVersion's public key using OAEP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertext")]
        public virtual string Ciphertext { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the AsymmetricDecryptRequest.ciphertext. If specified,
        /// KeyManagementService will verify the integrity of the received AsymmetricDecryptRequest.ciphertext using
        /// this checksum. KeyManagementService will report an error if the checksum verification fails. If you receive
        /// a checksum error, your client should verify that CRC32C(AsymmetricDecryptRequest.ciphertext) is equal to
        /// AsymmetricDecryptRequest.ciphertext_crc32c, and if so, perform a limited number of retries. A persistent
        /// mismatch may indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as
        /// int64 for reasons of compatibility across different languages. However, it is a non-negative integer, which
        /// will never exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertextCrc32c")]
        public virtual System.Nullable<long> CiphertextCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.AsymmetricDecrypt.</summary>
    public class AsymmetricDecryptResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The decrypted data originally encrypted with the matching public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintext")]
        public virtual string Plaintext { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned AsymmetricDecryptResponse.plaintext. An
        /// integrity check of AsymmetricDecryptResponse.plaintext can be performed by computing the CRC32C checksum of
        /// AsymmetricDecryptResponse.plaintext and comparing your results to this field. Discard the response in case
        /// of non-matching checksum values, and perform a limited number of retries. A persistent mismatch may indicate
        /// an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for reasons of
        /// compatibility across different languages. However, it is a non-negative integer, which will never exceed
        /// 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintextCrc32c")]
        public virtual System.Nullable<long> PlaintextCrc32c { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used in decryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether AsymmetricDecryptRequest.ciphertext_crc32c was
        /// received by KeyManagementService and used for the integrity verification of the ciphertext. A false value of
        /// this field indicates either that AsymmetricDecryptRequest.ciphertext_crc32c was left unset or that it was
        /// not delivered to KeyManagementService. If you've set AsymmetricDecryptRequest.ciphertext_crc32c but this
        /// field is still false, discard the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedCiphertextCrc32c")]
        public virtual System.Nullable<bool> VerifiedCiphertextCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.AsymmetricSign.</summary>
    public class AsymmetricSignRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The data to sign. It can't be supplied if AsymmetricSignRequest.digest is supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the AsymmetricSignRequest.data. If specified, KeyManagementService
        /// will verify the integrity of the received AsymmetricSignRequest.data using this checksum.
        /// KeyManagementService will report an error if the checksum verification fails. If you receive a checksum
        /// error, your client should verify that CRC32C(AsymmetricSignRequest.data) is equal to
        /// AsymmetricSignRequest.data_crc32c, and if so, perform a limited number of retries. A persistent mismatch may
        /// indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for
        /// reasons of compatibility across different languages. However, it is a non-negative integer, which will never
        /// exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCrc32c")]
        public virtual System.Nullable<long> DataCrc32c { get; set; }

        /// <summary>
        /// Optional. The digest of the data to sign. The digest must be produced with the same digest algorithm as
        /// specified by the key version's algorithm. This field may not be supplied if AsymmetricSignRequest.data is
        /// supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digest")]
        public virtual Digest Digest { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the AsymmetricSignRequest.digest. If specified,
        /// KeyManagementService will verify the integrity of the received AsymmetricSignRequest.digest using this
        /// checksum. KeyManagementService will report an error if the checksum verification fails. If you receive a
        /// checksum error, your client should verify that CRC32C(AsymmetricSignRequest.digest) is equal to
        /// AsymmetricSignRequest.digest_crc32c, and if so, perform a limited number of retries. A persistent mismatch
        /// may indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for
        /// reasons of compatibility across different languages. However, it is a non-negative integer, which will never
        /// exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("digestCrc32c")]
        public virtual System.Nullable<long> DigestCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.AsymmetricSign.</summary>
    public class AsymmetricSignResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the CryptoKeyVersion used for signing. Check this field to verify that the intended
        /// resource was used for signing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used for signing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>The created signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signature")]
        public virtual string Signature { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned AsymmetricSignResponse.signature. An
        /// integrity check of AsymmetricSignResponse.signature can be performed by computing the CRC32C checksum of
        /// AsymmetricSignResponse.signature and comparing your results to this field. Discard the response in case of
        /// non-matching checksum values, and perform a limited number of retries. A persistent mismatch may indicate an
        /// issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for reasons of
        /// compatibility across different languages. However, it is a non-negative integer, which will never exceed
        /// 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureCrc32c")]
        public virtual System.Nullable<long> SignatureCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether AsymmetricSignRequest.data_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the data. A false value of this field
        /// indicates either that AsymmetricSignRequest.data_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set AsymmetricSignRequest.data_crc32c but this field is still false, discard
        /// the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedDataCrc32c")]
        public virtual System.Nullable<bool> VerifiedDataCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether AsymmetricSignRequest.digest_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the digest. A false value of this field
        /// indicates either that AsymmetricSignRequest.digest_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set AsymmetricSignRequest.digest_crc32c but this field is still false,
        /// discard the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedDigestCrc32c")]
        public virtual System.Nullable<bool> VerifiedDigestCrc32c { get; set; }

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

    /// <summary>Cloud KMS Autokey configuration for a folder.</summary>
    public class AutokeyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A checksum computed by the server based on the value of other fields. This may be sent on update
        /// requests to ensure that the client has an up-to-date value before proceeding. The request will be rejected
        /// with an ABORTED error on a mismatched etag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Name of the key project, e.g. `projects/{PROJECT_ID}` or `projects/{PROJECT_NUMBER}`, where Cloud
        /// KMS Autokey will provision a new CryptoKey when a KeyHandle is created. On UpdateAutokeyConfig, the caller
        /// will require `cloudkms.cryptoKeys.setIamPolicy` permission on this key project. Once configured, for Cloud
        /// KMS Autokey to function properly, this key project must have the Cloud KMS API activated and the Cloud KMS
        /// Service Agent for this key project must be granted the `cloudkms.admin` role (or pertinent permissions). A
        /// request with an empty key project field will clear the configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyProject")]
        public virtual string KeyProject { get; set; }

        /// <summary>
        /// Identifier. Name of the AutokeyConfig resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state for the AutokeyConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }
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

    /// <summary>
    /// A Certificate represents an X.509 certificate used to authenticate HTTPS connections to EKM replicas.
    /// </summary>
    public class Certificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The issuer distinguished name in RFC 2253 format. Only present if parsed is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        private string _notAfterTimeRaw;

        private object _notAfterTime;

        /// <summary>
        /// Output only. The certificate is not valid after this time. Only present if parsed is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notAfterTime")]
        public virtual string NotAfterTimeRaw
        {
            get => _notAfterTimeRaw;
            set
            {
                _notAfterTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notAfterTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotAfterTimeDateTimeOffset instead.")]
        public virtual object NotAfterTime
        {
            get => _notAfterTime;
            set
            {
                _notAfterTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notAfterTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NotAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotAfterTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotAfterTimeRaw);
            set => NotAfterTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _notBeforeTimeRaw;

        private object _notBeforeTime;

        /// <summary>
        /// Output only. The certificate is not valid before this time. Only present if parsed is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notBeforeTime")]
        public virtual string NotBeforeTimeRaw
        {
            get => _notBeforeTimeRaw;
            set
            {
                _notBeforeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _notBeforeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NotBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NotBeforeTimeDateTimeOffset instead.")]
        public virtual object NotBeforeTime
        {
            get => _notBeforeTime;
            set
            {
                _notBeforeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _notBeforeTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="NotBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NotBeforeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NotBeforeTimeRaw);
            set => NotBeforeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. True if the certificate was parsed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parsed")]
        public virtual System.Nullable<bool> Parsed { get; set; }

        /// <summary>Required. The raw certificate bytes in DER format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawDer")]
        public virtual string RawDer { get; set; }

        /// <summary>
        /// Output only. The certificate serial number as a hex string. Only present if parsed is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>
        /// Output only. The SHA-256 certificate fingerprint as a hex string. Only present if parsed is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Fingerprint")]
        public virtual string Sha256Fingerprint { get; set; }

        /// <summary>
        /// Output only. The subject distinguished name in RFC 2253 format. Only present if parsed is true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>Output only. The subject Alternative DNS names. Only present if parsed is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectAlternativeDnsNames")]
        public virtual System.Collections.Generic.IList<string> SubjectAlternativeDnsNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Certificate chains needed to verify the attestation. Certificates in chains are PEM-encoded and are ordered
    /// based on https://tools.ietf.org/html/rfc5246#section-7.4.2.
    /// </summary>
    public class CertificateChains : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Cavium certificate chain corresponding to the attestation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caviumCerts")]
        public virtual System.Collections.Generic.IList<string> CaviumCerts { get; set; }

        /// <summary>Google card certificate chain corresponding to the attestation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleCardCerts")]
        public virtual System.Collections.Generic.IList<string> GoogleCardCerts { get; set; }

        /// <summary>Google partition certificate chain corresponding to the attestation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googlePartitionCerts")]
        public virtual System.Collections.Generic.IList<string> GooglePartitionCerts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data with integrity verification field.</summary>
    public class ChecksummedData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned ChecksummedData.data. An integrity check of
        /// ChecksummedData.data can be performed by computing the CRC32C checksum of ChecksummedData.data and comparing
        /// your results to this field. Discard the response in case of non-matching checksum values, and perform a
        /// limited number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C
        /// checksum. Note: This field is defined as int64 for reasons of compatibility across different languages.
        /// However, it is a non-negative integer, which will never exceed `2^32-1`, and can be safely downconverted to
        /// uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cChecksum")]
        public virtual System.Nullable<long> Crc32cChecksum { get; set; }

        /// <summary>Raw Data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CryptoKey represents a logical key that can be used for cryptographic operations. A CryptoKey is made up of
    /// zero or more versions, which represent the actual key material used in cryptographic operations.
    /// </summary>
    public class CryptoKey : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this CryptoKey was created.</summary>
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
        /// Immutable. The resource name of the backend environment where the key material for all CryptoKeyVersions
        /// associated with this CryptoKey reside and where all related cryptographic operations are performed. Only
        /// applicable if CryptoKeyVersions have a ProtectionLevel of EXTERNAL_VPC, with the resource name in the format
        /// `projects/*/locations/*/ekmConnections/*`. Note, this list is non-exhaustive and may apply to additional
        /// ProtectionLevels in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyBackend")]
        public virtual string CryptoKeyBackend { get; set; }

        /// <summary>
        /// Immutable. The period of time that versions of this key spend in the DESTROY_SCHEDULED state before
        /// transitioning to DESTROYED. If not specified at creation time, the default duration is 30 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destroyScheduledDuration")]
        public virtual object DestroyScheduledDuration { get; set; }

        /// <summary>Immutable. Whether this key may contain imported versions only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importOnly")]
        public virtual System.Nullable<bool> ImportOnly { get; set; }

        /// <summary>
        /// Optional. The policy used for Key Access Justifications Policy Enforcement. If this field is present and
        /// this key is enrolled in Key Access Justifications Policy Enforcement, the policy will be evaluated in
        /// encrypt, decrypt, and sign operations, and the operation will fail if rejected by the policy. The policy is
        /// defined by specifying zero or more allowed justification codes.
        /// https://cloud.google.com/assured-workloads/key-access-justifications/docs/justification-codes By default,
        /// this field is absent, and all justification codes are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyAccessJustificationsPolicy")]
        public virtual KeyAccessJustificationsPolicy KeyAccessJustificationsPolicy { get; set; }

        /// <summary>
        /// Labels with user-defined metadata. For more information, see [Labeling
        /// Keys](https://cloud.google.com/kms/docs/labeling-keys).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. The resource name for this CryptoKey in the format
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _nextRotationTimeRaw;

        private object _nextRotationTime;

        /// <summary>
        /// At next_rotation_time, the Key Management Service will automatically: 1. Create a new version of this
        /// CryptoKey. 2. Mark the new version as primary. Key rotations performed manually via CreateCryptoKeyVersion
        /// and UpdateCryptoKeyPrimaryVersion do not affect next_rotation_time. Keys with purpose ENCRYPT_DECRYPT
        /// support automatic rotation. For other keys, this field must be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRotationTime")]
        public virtual string NextRotationTimeRaw
        {
            get => _nextRotationTimeRaw;
            set
            {
                _nextRotationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextRotationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextRotationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextRotationTimeDateTimeOffset instead.")]
        public virtual object NextRotationTime
        {
            get => _nextRotationTime;
            set
            {
                _nextRotationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextRotationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextRotationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextRotationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextRotationTimeRaw);
            set => NextRotationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. A copy of the "primary" CryptoKeyVersion that will be used by Encrypt when this CryptoKey is
        /// given in EncryptRequest.name. The CryptoKey's primary version can be updated via
        /// UpdateCryptoKeyPrimaryVersion. Keys with purpose ENCRYPT_DECRYPT may have a primary. For other keys, this
        /// field will be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual CryptoKeyVersion Primary { get; set; }

        /// <summary>Immutable. The immutable purpose of this CryptoKey.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purpose")]
        public virtual string Purpose { get; set; }

        /// <summary>
        /// next_rotation_time will be advanced by this period when the service automatically rotates a key. Must be at
        /// least 24 hours and at most 876,000 hours. If rotation_period is set, next_rotation_time must also be set.
        /// Keys with purpose ENCRYPT_DECRYPT support automatic rotation. For other keys, this field must be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotationPeriod")]
        public virtual object RotationPeriod { get; set; }

        /// <summary>
        /// A template describing settings for new CryptoKeyVersion instances. The properties of new CryptoKeyVersion
        /// instances created by either CreateCryptoKeyVersion or auto-rotation are controlled by this template.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionTemplate")]
        public virtual CryptoKeyVersionTemplate VersionTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CryptoKeyVersion represents an individual cryptographic key, and the associated key material. An ENABLED
    /// version can be used for cryptographic operations. For security reasons, the raw cryptographic key material
    /// represented by a CryptoKeyVersion can never be viewed or exported. It can only be used to encrypt, decrypt, or
    /// sign data when an authorized user or application invokes Cloud KMS.
    /// </summary>
    public class CryptoKeyVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The CryptoKeyVersionAlgorithm that this CryptoKeyVersion supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// Output only. Statement that was generated and signed by the HSM at key creation time. Use this statement to
        /// verify attributes of the key as stored on the HSM, independently of Google. Only provided for key versions
        /// with protection_level HSM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual KeyOperationAttestation Attestation { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this CryptoKeyVersion was created.</summary>
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

        private string _destroyEventTimeRaw;

        private object _destroyEventTime;

        /// <summary>
        /// Output only. The time this CryptoKeyVersion's key material was destroyed. Only present if state is
        /// DESTROYED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destroyEventTime")]
        public virtual string DestroyEventTimeRaw
        {
            get => _destroyEventTimeRaw;
            set
            {
                _destroyEventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _destroyEventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DestroyEventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DestroyEventTimeDateTimeOffset instead.")]
        public virtual object DestroyEventTime
        {
            get => _destroyEventTime;
            set
            {
                _destroyEventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _destroyEventTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DestroyEventTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DestroyEventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DestroyEventTimeRaw);
            set => DestroyEventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _destroyTimeRaw;

        private object _destroyTime;

        /// <summary>
        /// Output only. The time this CryptoKeyVersion's key material is scheduled for destruction. Only present if
        /// state is DESTROY_SCHEDULED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destroyTime")]
        public virtual string DestroyTimeRaw
        {
            get => _destroyTimeRaw;
            set
            {
                _destroyTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _destroyTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DestroyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DestroyTimeDateTimeOffset instead.")]
        public virtual object DestroyTime
        {
            get => _destroyTime;
            set
            {
                _destroyTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _destroyTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DestroyTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DestroyTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DestroyTimeRaw);
            set => DestroyTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The root cause of the most recent external destruction failure. Only present if state is
        /// EXTERNAL_DESTRUCTION_FAILED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalDestructionFailureReason")]
        public virtual string ExternalDestructionFailureReason { get; set; }

        /// <summary>
        /// ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that
        /// are specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalProtectionLevelOptions")]
        public virtual ExternalProtectionLevelOptions ExternalProtectionLevelOptions { get; set; }

        private string _generateTimeRaw;

        private object _generateTime;

        /// <summary>Output only. The time this CryptoKeyVersion's key material was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateTime")]
        public virtual string GenerateTimeRaw
        {
            get => _generateTimeRaw;
            set
            {
                _generateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _generateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="GenerateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use GenerateTimeDateTimeOffset instead.")]
        public virtual object GenerateTime
        {
            get => _generateTime;
            set
            {
                _generateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _generateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="GenerateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? GenerateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(GenerateTimeRaw);
            set => GenerateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The root cause of the most recent generation failure. Only present if state is
        /// GENERATION_FAILED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationFailureReason")]
        public virtual string GenerationFailureReason { get; set; }

        /// <summary>
        /// Output only. The root cause of the most recent import failure. Only present if state is IMPORT_FAILED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importFailureReason")]
        public virtual string ImportFailureReason { get; set; }

        /// <summary>
        /// Output only. The name of the ImportJob used in the most recent import of this CryptoKeyVersion. Only present
        /// if the underlying key material was imported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importJob")]
        public virtual string ImportJob { get; set; }

        private string _importTimeRaw;

        private object _importTime;

        /// <summary>
        /// Output only. The time at which this CryptoKeyVersion's key material was most recently imported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importTime")]
        public virtual string ImportTimeRaw
        {
            get => _importTimeRaw;
            set
            {
                _importTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _importTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ImportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ImportTimeDateTimeOffset instead.")]
        public virtual object ImportTime
        {
            get => _importTime;
            set
            {
                _importTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _importTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ImportTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ImportTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ImportTimeRaw);
            set => ImportTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The resource name for this CryptoKeyVersion in the format
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The ProtectionLevel describing how crypto operations are performed with this CryptoKeyVersion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// Output only. Whether or not this key version is eligible for reimport, by being specified as a target in
        /// ImportCryptoKeyVersionRequest.crypto_key_version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reimportEligible")]
        public virtual System.Nullable<bool> ReimportEligible { get; set; }

        /// <summary>The current state of the CryptoKeyVersion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CryptoKeyVersionTemplate specifies the properties to use when creating a new CryptoKeyVersion, either manually
    /// with CreateCryptoKeyVersion or automatically as a result of auto-rotation.
    /// </summary>
    public class CryptoKeyVersionTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Algorithm to use when creating a CryptoKeyVersion based on this template. For backwards
        /// compatibility, GOOGLE_SYMMETRIC_ENCRYPTION is implied if both this field is omitted and CryptoKey.purpose is
        /// ENCRYPT_DECRYPT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// ProtectionLevel to use when creating a CryptoKeyVersion based on this template. Immutable. Defaults to
        /// SOFTWARE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.Decrypt.</summary>
    public class DecryptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional data that must match the data originally supplied in
        /// EncryptRequest.additional_authenticated_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedData")]
        public virtual string AdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the DecryptRequest.additional_authenticated_data. If specified,
        /// KeyManagementService will verify the integrity of the received DecryptRequest.additional_authenticated_data
        /// using this checksum. KeyManagementService will report an error if the checksum verification fails. If you
        /// receive a checksum error, your client should verify that
        /// CRC32C(DecryptRequest.additional_authenticated_data) is equal to
        /// DecryptRequest.additional_authenticated_data_crc32c, and if so, perform a limited number of retries. A
        /// persistent mismatch may indicate an issue in your computation of the CRC32C checksum. Note: This field is
        /// defined as int64 for reasons of compatibility across different languages. However, it is a non-negative
        /// integer, which will never exceed 2^32-1, and can be safely downconverted to uint32 in languages that support
        /// this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedDataCrc32c")]
        public virtual System.Nullable<long> AdditionalAuthenticatedDataCrc32c { get; set; }

        /// <summary>Required. The encrypted data originally returned in EncryptResponse.ciphertext.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertext")]
        public virtual string Ciphertext { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the DecryptRequest.ciphertext. If specified, KeyManagementService
        /// will verify the integrity of the received DecryptRequest.ciphertext using this checksum.
        /// KeyManagementService will report an error if the checksum verification fails. If you receive a checksum
        /// error, your client should verify that CRC32C(DecryptRequest.ciphertext) is equal to
        /// DecryptRequest.ciphertext_crc32c, and if so, perform a limited number of retries. A persistent mismatch may
        /// indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for
        /// reasons of compatibility across different languages. However, it is a non-negative integer, which will never
        /// exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertextCrc32c")]
        public virtual System.Nullable<long> CiphertextCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.Decrypt.</summary>
    public class DecryptResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The decrypted data originally supplied in EncryptRequest.plaintext.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintext")]
        public virtual string Plaintext { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned DecryptResponse.plaintext. An integrity
        /// check of DecryptResponse.plaintext can be performed by computing the CRC32C checksum of
        /// DecryptResponse.plaintext and comparing your results to this field. Discard the response in case of
        /// non-matching checksum values, and perform a limited number of retries. A persistent mismatch may indicate an
        /// issue in your computation of the CRC32C checksum. Note: receiving this response message indicates that
        /// KeyManagementService is able to successfully decrypt the ciphertext. Note: This field is defined as int64
        /// for reasons of compatibility across different languages. However, it is a non-negative integer, which will
        /// never exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintextCrc32c")]
        public virtual System.Nullable<long> PlaintextCrc32c { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used in decryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>Whether the Decryption was performed using the primary key version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usedPrimary")]
        public virtual System.Nullable<bool> UsedPrimary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.DestroyCryptoKeyVersion.</summary>
    public class DestroyCryptoKeyVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Digest holds a cryptographic message digest.</summary>
    public class Digest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A message digest produced with the SHA-256 algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>A message digest produced with the SHA-384 algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha384")]
        public virtual string Sha384 { get; set; }

        /// <summary>A message digest produced with the SHA-512 algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha512")]
        public virtual string Sha512 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An EkmConfig is a singleton resource that represents configuration parameters that apply to all CryptoKeys and
    /// CryptoKeyVersions with a ProtectionLevel of EXTERNAL_VPC in a given project and location.
    /// </summary>
    public class EkmConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Resource name of the default EkmConnection. Setting this field to the empty string removes the
        /// default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultEkmConnection")]
        public virtual string DefaultEkmConnection { get; set; }

        /// <summary>
        /// Output only. The resource name for the EkmConfig in the format `projects/*/locations/*/ekmConfig`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An EkmConnection represents an individual EKM connection. It can be used for creating CryptoKeys and
    /// CryptoKeyVersions with a ProtectionLevel of EXTERNAL_VPC, as well as performing cryptographic operations using
    /// keys created within the EkmConnection.
    /// </summary>
    public class EkmConnection : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the EkmConnection was created.</summary>
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
        /// Optional. Identifies the EKM Crypto Space that this EkmConnection maps to. Note: This field is required if
        /// KeyManagementMode is CLOUD_KMS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoSpacePath")]
        public virtual string CryptoSpacePath { get; set; }

        /// <summary>Optional. Etag of the currently stored EkmConnection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Optional. Describes who can perform control plane operations on the EKM. If unset, this defaults to MANUAL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyManagementMode")]
        public virtual string KeyManagementMode { get; set; }

        /// <summary>
        /// Output only. The resource name for the EkmConnection in the format
        /// `projects/*/locations/*/ekmConnections/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. A list of ServiceResolvers where the EKM can be reached. There should be one ServiceResolver per
        /// EKM replica. Currently, only a single ServiceResolver is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceResolvers")]
        public virtual System.Collections.Generic.IList<ServiceResolver> ServiceResolvers { get; set; }
    }

    /// <summary>Request message for KeyManagementService.Encrypt.</summary>
    public class EncryptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional data that, if specified, must also be provided during decryption through
        /// DecryptRequest.additional_authenticated_data. The maximum size depends on the key version's
        /// protection_level. For SOFTWARE, EXTERNAL, and EXTERNAL_VPC keys the AAD must be no larger than 64KiB. For
        /// HSM keys, the combined length of the plaintext and additional_authenticated_data fields must be no larger
        /// than 8KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedData")]
        public virtual string AdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the EncryptRequest.additional_authenticated_data. If specified,
        /// KeyManagementService will verify the integrity of the received EncryptRequest.additional_authenticated_data
        /// using this checksum. KeyManagementService will report an error if the checksum verification fails. If you
        /// receive a checksum error, your client should verify that
        /// CRC32C(EncryptRequest.additional_authenticated_data) is equal to
        /// EncryptRequest.additional_authenticated_data_crc32c, and if so, perform a limited number of retries. A
        /// persistent mismatch may indicate an issue in your computation of the CRC32C checksum. Note: This field is
        /// defined as int64 for reasons of compatibility across different languages. However, it is a non-negative
        /// integer, which will never exceed 2^32-1, and can be safely downconverted to uint32 in languages that support
        /// this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedDataCrc32c")]
        public virtual System.Nullable<long> AdditionalAuthenticatedDataCrc32c { get; set; }

        /// <summary>
        /// Required. The data to encrypt. Must be no larger than 64KiB. The maximum size depends on the key version's
        /// protection_level. For SOFTWARE, EXTERNAL, and EXTERNAL_VPC keys, the plaintext must be no larger than 64KiB.
        /// For HSM keys, the combined length of the plaintext and additional_authenticated_data fields must be no
        /// larger than 8KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintext")]
        public virtual string Plaintext { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the EncryptRequest.plaintext. If specified, KeyManagementService
        /// will verify the integrity of the received EncryptRequest.plaintext using this checksum. KeyManagementService
        /// will report an error if the checksum verification fails. If you receive a checksum error, your client should
        /// verify that CRC32C(EncryptRequest.plaintext) is equal to EncryptRequest.plaintext_crc32c, and if so, perform
        /// a limited number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C
        /// checksum. Note: This field is defined as int64 for reasons of compatibility across different languages.
        /// However, it is a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to
        /// uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintextCrc32c")]
        public virtual System.Nullable<long> PlaintextCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.Encrypt.</summary>
    public class EncryptResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encrypted data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertext")]
        public virtual string Ciphertext { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned EncryptResponse.ciphertext. An integrity
        /// check of EncryptResponse.ciphertext can be performed by computing the CRC32C checksum of
        /// EncryptResponse.ciphertext and comparing your results to this field. Discard the response in case of
        /// non-matching checksum values, and perform a limited number of retries. A persistent mismatch may indicate an
        /// issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for reasons of
        /// compatibility across different languages. However, it is a non-negative integer, which will never exceed
        /// 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertextCrc32c")]
        public virtual System.Nullable<long> CiphertextCrc32c { get; set; }

        /// <summary>
        /// The resource name of the CryptoKeyVersion used in encryption. Check this field to verify that the intended
        /// resource was used for encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used in encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether EncryptRequest.additional_authenticated_data_crc32c
        /// was received by KeyManagementService and used for the integrity verification of the AAD. A false value of
        /// this field indicates either that EncryptRequest.additional_authenticated_data_crc32c was left unset or that
        /// it was not delivered to KeyManagementService. If you've set
        /// EncryptRequest.additional_authenticated_data_crc32c but this field is still false, discard the response and
        /// perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedAdditionalAuthenticatedDataCrc32c")]
        public virtual System.Nullable<bool> VerifiedAdditionalAuthenticatedDataCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether EncryptRequest.plaintext_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the plaintext. A false value of this field
        /// indicates either that EncryptRequest.plaintext_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set EncryptRequest.plaintext_crc32c but this field is still false, discard
        /// the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedPlaintextCrc32c")]
        public virtual System.Nullable<bool> VerifiedPlaintextCrc32c { get; set; }

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
    /// ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are
    /// specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels.
    /// </summary>
    public class ExternalProtectionLevelOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The path to the external key material on the EKM when using EkmConnection e.g., "v0/my/key". Set this field
        /// instead of external_key_uri when using an EkmConnection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmConnectionKeyPath")]
        public virtual string EkmConnectionKeyPath { get; set; }

        /// <summary>The URI for an external resource that this CryptoKeyVersion represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalKeyUri")]
        public virtual string ExternalKeyUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.GenerateRandomBytes.</summary>
    public class GenerateRandomBytesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The length in bytes of the amount of randomness to retrieve. Minimum 8 bytes, maximum 1024 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lengthBytes")]
        public virtual System.Nullable<int> LengthBytes { get; set; }

        /// <summary>
        /// The ProtectionLevel to use when generating the random data. Currently, only HSM protection level is
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.GenerateRandomBytes.</summary>
    public class GenerateRandomBytesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The generated data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned GenerateRandomBytesResponse.data. An
        /// integrity check of GenerateRandomBytesResponse.data can be performed by computing the CRC32C checksum of
        /// GenerateRandomBytesResponse.data and comparing your results to this field. Discard the response in case of
        /// non-matching checksum values, and perform a limited number of retries. A persistent mismatch may indicate an
        /// issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for reasons of
        /// compatibility across different languages. However, it is a non-negative integer, which will never exceed
        /// 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCrc32c")]
        public virtual System.Nullable<long> DataCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.ImportCryptoKeyVersion.</summary>
    public class ImportCryptoKeyVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The algorithm of the key being imported. This does not need to match the version_template of the
        /// CryptoKey this version imports into.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// Optional. The optional name of an existing CryptoKeyVersion to target for an import operation. If this field
        /// is not present, a new CryptoKeyVersion containing the supplied key material is created. If this field is
        /// present, the supplied key material is imported into the existing CryptoKeyVersion. To import into an
        /// existing CryptoKeyVersion, the CryptoKeyVersion must be a child of ImportCryptoKeyVersionRequest.parent,
        /// have been previously created via ImportCryptoKeyVersion, and be in DESTROYED or IMPORT_FAILED state. The key
        /// material and algorithm must match the previous CryptoKeyVersion exactly if the CryptoKeyVersion has ever
        /// contained key material.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyVersion")]
        public virtual string CryptoKeyVersion { get; set; }

        /// <summary>Required. The name of the ImportJob that was used to wrap this key material.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importJob")]
        public virtual string ImportJob { get; set; }

        /// <summary>
        /// Optional. This field has the same meaning as wrapped_key. Prefer to use that field in new work. Either that
        /// field or this field (but not both) must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rsaAesWrappedKey")]
        public virtual string RsaAesWrappedKey { get; set; }

        /// <summary>
        /// Optional. The wrapped key material to import. Before wrapping, key material must be formatted. If importing
        /// symmetric key material, the expected key material format is plain bytes. If importing asymmetric key
        /// material, the expected key material format is PKCS#8-encoded DER (the PrivateKeyInfo structure from RFC
        /// 5208). When wrapping with import methods (RSA_OAEP_3072_SHA1_AES_256 or RSA_OAEP_4096_SHA1_AES_256 or
        /// RSA_OAEP_3072_SHA256_AES_256 or RSA_OAEP_4096_SHA256_AES_256), this field must contain the concatenation of:
        /// 1. An ephemeral AES-256 wrapping key wrapped with the public_key using RSAES-OAEP with SHA-1/SHA-256, MGF1
        /// with SHA-1/SHA-256, and an empty label. 2. The formatted key to be imported, wrapped with the ephemeral
        /// AES-256 key using AES-KWP (RFC 5649). This format is the same as the format produced by PKCS#11 mechanism
        /// CKM_RSA_AES_KEY_WRAP. When wrapping with import methods (RSA_OAEP_3072_SHA256 or RSA_OAEP_4096_SHA256), this
        /// field must contain the formatted key to be imported, wrapped with the public_key using RSAES-OAEP with
        /// SHA-256, MGF1 with SHA-256, and an empty label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrappedKey")]
        public virtual string WrappedKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An ImportJob can be used to create CryptoKeys and CryptoKeyVersions using pre-existing key material, generated
    /// outside of Cloud KMS. When an ImportJob is created, Cloud KMS will generate a "wrapping key", which is a
    /// public/private key pair. You use the wrapping key to encrypt (also known as wrap) the pre-existing key material
    /// to protect it during the import process. The nature of the wrapping key depends on the choice of import_method.
    /// When the wrapping key generation is complete, the state will be set to ACTIVE and the public_key can be fetched.
    /// The fetched public key can then be used to wrap your pre-existing key material. Once the key material is
    /// wrapped, it can be imported into a new CryptoKeyVersion in an existing CryptoKey by calling
    /// ImportCryptoKeyVersion. Multiple CryptoKeyVersions can be imported with a single ImportJob. Cloud KMS uses the
    /// private key portion of the wrapping key to unwrap the key material. Only Cloud KMS has access to the private
    /// key. An ImportJob expires 3 days after it is created. Once expired, Cloud KMS will no longer be able to import
    /// or unwrap any key material that was wrapped with the ImportJob's public key. For more information, see
    /// [Importing a key](https://cloud.google.com/kms/docs/importing-a-key).
    /// </summary>
    public class ImportJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Statement that was generated and signed by the key creator (for example, an HSM) at key
        /// creation time. Use this statement to verify attributes of the key as stored on the HSM, independently of
        /// Google. Only present if the chosen ImportMethod is one with a protection level of HSM.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestation")]
        public virtual KeyOperationAttestation Attestation { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this ImportJob was created.</summary>
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

        private string _expireEventTimeRaw;

        private object _expireEventTime;

        /// <summary>Output only. The time this ImportJob expired. Only present if state is EXPIRED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireEventTime")]
        public virtual string ExpireEventTimeRaw
        {
            get => _expireEventTimeRaw;
            set
            {
                _expireEventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireEventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireEventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireEventTimeDateTimeOffset instead.")]
        public virtual object ExpireEventTime
        {
            get => _expireEventTime;
            set
            {
                _expireEventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireEventTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireEventTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireEventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireEventTimeRaw);
            set => ExpireEventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. The time at which this ImportJob is scheduled for expiration and can no longer be used to
        /// import key material.
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

        private string _generateTimeRaw;

        private object _generateTime;

        /// <summary>Output only. The time this ImportJob's key material was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateTime")]
        public virtual string GenerateTimeRaw
        {
            get => _generateTimeRaw;
            set
            {
                _generateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _generateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="GenerateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use GenerateTimeDateTimeOffset instead.")]
        public virtual object GenerateTime
        {
            get => _generateTime;
            set
            {
                _generateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _generateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="GenerateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? GenerateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(GenerateTimeRaw);
            set => GenerateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. Immutable. The wrapping method to be used for incoming key material.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importMethod")]
        public virtual string ImportMethod { get; set; }

        /// <summary>
        /// Output only. The resource name for this ImportJob in the format
        /// `projects/*/locations/*/keyRings/*/importJobs/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. The protection level of the ImportJob. This must match the protection_level of the
        /// version_template on the CryptoKey you attempt to import into.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// Output only. The public key with which to wrap key material prior to import. Only returned if state is
        /// ACTIVE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual WrappingPublicKey PublicKey { get; set; }

        /// <summary>Output only. The current state of the ImportJob, indicating if it can be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of a protection level for a project's Key Access Justifications enrollment.</summary>
    public class KeyAccessJustificationsEnrollmentConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the project has KAJ logging enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogging")]
        public virtual System.Nullable<bool> AuditLogging { get; set; }

        /// <summary>Whether the project is enrolled in KAJ policy enforcement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyEnforcement")]
        public virtual System.Nullable<bool> PolicyEnforcement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A KeyAccessJustificationsPolicy specifies zero or more allowed AccessReason values for encrypt, decrypt, and
    /// sign operations on a CryptoKey.
    /// </summary>
    public class KeyAccessJustificationsPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of allowed reasons for access to a CryptoKey. Zero allowed access reasons means all encrypt,
        /// decrypt, and sign operations for the CryptoKey associated with this policy will fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedAccessReasons")]
        public virtual System.Collections.Generic.IList<string> AllowedAccessReasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A singleton configuration for Key Access Justifications policies.</summary>
    public class KeyAccessJustificationsPolicyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The default key access justification policy used when a CryptoKey is created in this folder. This
        /// is only used when a Key Access Justifications policy is not provided in the CreateCryptoKeyRequest. This
        /// overrides any default policies in its ancestry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultKeyAccessJustificationPolicy")]
        public virtual KeyAccessJustificationsPolicy DefaultKeyAccessJustificationPolicy { get; set; }

        /// <summary>
        /// Identifier. The resource name for this KeyAccessJustificationsPolicyConfig in the format of
        /// "{organizations|folders|projects}/*/kajPolicyConfig".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Resource-oriented representation of a request to Cloud KMS Autokey and the resulting provisioning of a
    /// CryptoKey.
    /// </summary>
    public class KeyHandle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Name of a CryptoKey that has been provisioned for Customer Managed Encryption Key (CMEK) use in
        /// the KeyHandle project and location for the requested resource type. The CryptoKey project will reflect the
        /// value configured in the AutokeyConfig on the resource project's ancestor folder at the time of the KeyHandle
        /// creation. If more than one ancestor folder has a configured AutokeyConfig, the nearest of these
        /// configurations is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKey")]
        public virtual string KmsKey { get; set; }

        /// <summary>
        /// Identifier. Name of the KeyHandle resource, e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Indicates the resource type that the resulting CryptoKey is meant to protect, e.g.
        /// `{SERVICE}.googleapis.com/{TYPE}`. See documentation for supported resource types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypeSelector")]
        public virtual string ResourceTypeSelector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains an HSM-generated attestation about a key operation. For more information, see [Verifying attestations]
    /// (https://cloud.google.com/kms/docs/attest-key).
    /// </summary>
    public class KeyOperationAttestation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The certificate chains needed to validate the attestation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certChains")]
        public virtual CertificateChains CertChains { get; set; }

        /// <summary>
        /// Output only. The attestation data provided by the HSM when the key operation was performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Output only. The format of the attestation data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A KeyRing is a toplevel logical grouping of CryptoKeys.</summary>
    public class KeyRing : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which this KeyRing was created.</summary>
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
        /// Output only. The resource name for the KeyRing in the format `projects/*/locations/*/keyRings/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.ListCryptoKeyVersions.</summary>
    public class ListCryptoKeyVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CryptoKeyVersions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyVersions")]
        public virtual System.Collections.Generic.IList<CryptoKeyVersion> CryptoKeyVersions { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListCryptoKeyVersionsRequest.page_token to
        /// retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The total number of CryptoKeyVersions that matched the query. This field is not populated if
        /// ListCryptoKeyVersionsRequest.filter is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.ListCryptoKeys.</summary>
    public class ListCryptoKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CryptoKeys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeys")]
        public virtual System.Collections.Generic.IList<CryptoKey> CryptoKeys { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListCryptoKeysRequest.page_token to retrieve
        /// the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The total number of CryptoKeys that matched the query. This field is not populated if
        /// ListCryptoKeysRequest.filter is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for EkmService.ListEkmConnections.</summary>
    public class ListEkmConnectionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of EkmConnections.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmConnections")]
        public virtual System.Collections.Generic.IList<EkmConnection> EkmConnections { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListEkmConnectionsRequest.page_token to
        /// retrieve the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The total number of EkmConnections that matched the query. This field is not populated if
        /// ListEkmConnectionsRequest.filter is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.ListImportJobs.</summary>
    public class ListImportJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of ImportJobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importJobs")]
        public virtual System.Collections.Generic.IList<ImportJob> ImportJobs { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListImportJobsRequest.page_token to retrieve
        /// the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The total number of ImportJobs that matched the query. This field is not populated if
        /// ListImportJobsRequest.filter is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for Autokey.ListKeyHandles.</summary>
    public class ListKeyHandlesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resulting KeyHandles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyHandles")]
        public virtual System.Collections.Generic.IList<KeyHandle> KeyHandles { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListKeyHandlesRequest.page_token to retrieve
        /// the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.ListKeyRings.</summary>
    public class ListKeyRingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of KeyRings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyRings")]
        public virtual System.Collections.Generic.IList<KeyRing> KeyRings { get; set; }

        /// <summary>
        /// A token to retrieve next page of results. Pass this value in ListKeyRingsRequest.page_token to retrieve the
        /// next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The total number of KeyRings that matched the query. This field is not populated if
        /// ListKeyRingsRequest.filter is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

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

    /// <summary>Cloud KMS metadata for the given google.cloud.location.Location.</summary>
    public class LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates whether CryptoKeys with protection_level EXTERNAL can be created in this location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ekmAvailable")]
        public virtual System.Nullable<bool> EkmAvailable { get; set; }

        /// <summary>Indicates whether CryptoKeys with protection_level HSM can be created in this location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hsmAvailable")]
        public virtual System.Nullable<bool> HsmAvailable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.MacSign.</summary>
    public class MacSignRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The data to sign. The MAC tag is computed over this data field based on the specific algorithm.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the MacSignRequest.data. If specified, KeyManagementService will
        /// verify the integrity of the received MacSignRequest.data using this checksum. KeyManagementService will
        /// report an error if the checksum verification fails. If you receive a checksum error, your client should
        /// verify that CRC32C(MacSignRequest.data) is equal to MacSignRequest.data_crc32c, and if so, perform a limited
        /// number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C checksum.
        /// Note: This field is defined as int64 for reasons of compatibility across different languages. However, it is
        /// a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to uint32 in
        /// languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCrc32c")]
        public virtual System.Nullable<long> DataCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.MacSign.</summary>
    public class MacSignResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The created signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mac")]
        public virtual string Mac { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned MacSignResponse.mac. An integrity check of
        /// MacSignResponse.mac can be performed by computing the CRC32C checksum of MacSignResponse.mac and comparing
        /// your results to this field. Discard the response in case of non-matching checksum values, and perform a
        /// limited number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C
        /// checksum. Note: This field is defined as int64 for reasons of compatibility across different languages.
        /// However, it is a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to
        /// uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macCrc32c")]
        public virtual System.Nullable<long> MacCrc32c { get; set; }

        /// <summary>
        /// The resource name of the CryptoKeyVersion used for signing. Check this field to verify that the intended
        /// resource was used for signing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used for signing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether MacSignRequest.data_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the data. A false value of this field
        /// indicates either that MacSignRequest.data_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set MacSignRequest.data_crc32c but this field is still false, discard the
        /// response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedDataCrc32c")]
        public virtual System.Nullable<bool> VerifiedDataCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.MacVerify.</summary>
    public class MacVerifyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The data used previously as a MacSignRequest.data to generate the MAC tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the MacVerifyRequest.data. If specified, KeyManagementService will
        /// verify the integrity of the received MacVerifyRequest.data using this checksum. KeyManagementService will
        /// report an error if the checksum verification fails. If you receive a checksum error, your client should
        /// verify that CRC32C(MacVerifyRequest.data) is equal to MacVerifyRequest.data_crc32c, and if so, perform a
        /// limited number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C
        /// checksum. Note: This field is defined as int64 for reasons of compatibility across different languages.
        /// However, it is a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to
        /// uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataCrc32c")]
        public virtual System.Nullable<long> DataCrc32c { get; set; }

        /// <summary>Required. The signature to verify.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mac")]
        public virtual string Mac { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the MacVerifyRequest.mac. If specified, KeyManagementService will
        /// verify the integrity of the received MacVerifyRequest.mac using this checksum. KeyManagementService will
        /// report an error if the checksum verification fails. If you receive a checksum error, your client should
        /// verify that CRC32C(MacVerifyRequest.mac) is equal to MacVerifyRequest.mac_crc32c, and if so, perform a
        /// limited number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C
        /// checksum. Note: This field is defined as int64 for reasons of compatibility across different languages.
        /// However, it is a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to
        /// uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macCrc32c")]
        public virtual System.Nullable<long> MacCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.MacVerify.</summary>
    public class MacVerifyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the CryptoKeyVersion used for verification. Check this field to verify that the
        /// intended resource was used for verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used for verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// This field indicates whether or not the verification operation for MacVerifyRequest.mac over
        /// MacVerifyRequest.data was successful.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("success")]
        public virtual System.Nullable<bool> Success { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether MacVerifyRequest.data_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the data. A false value of this field
        /// indicates either that MacVerifyRequest.data_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set MacVerifyRequest.data_crc32c but this field is still false, discard the
        /// response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedDataCrc32c")]
        public virtual System.Nullable<bool> VerifiedDataCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether MacVerifyRequest.mac_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the data. A false value of this field
        /// indicates either that MacVerifyRequest.mac_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set MacVerifyRequest.mac_crc32c but this field is still false, discard the
        /// response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedMacCrc32c")]
        public virtual System.Nullable<bool> VerifiedMacCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. This value is used for the integrity verification of
        /// [MacVerifyResponse.success]. If the value of this field contradicts the value of
        /// [MacVerifyResponse.success], discard the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedSuccessIntegrity")]
        public virtual System.Nullable<bool> VerifiedSuccessIntegrity { get; set; }

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

    /// <summary>The public keys for a given CryptoKeyVersion. Obtained via GetPublicKey.</summary>
    public class PublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Algorithm associated with this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary>
        /// The name of the CryptoKeyVersion public key. Provided here for verification. NOTE: This field is in Beta.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The public key, encoded in PEM format. For more information, see the [RFC
        /// 7468](https://tools.ietf.org/html/rfc7468) sections for [General
        /// Considerations](https://tools.ietf.org/html/rfc7468#section-2) and [Textual Encoding of Subject Public Key
        /// Info] (https://tools.ietf.org/html/rfc7468#section-13).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pem")]
        public virtual string Pem { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned PublicKey.pem. An integrity check of
        /// PublicKey.pem can be performed by computing the CRC32C checksum of PublicKey.pem and comparing your results
        /// to this field. Discard the response in case of non-matching checksum values, and perform a limited number of
        /// retries. A persistent mismatch may indicate an issue in your computation of the CRC32C checksum. Note: This
        /// field is defined as int64 for reasons of compatibility across different languages. However, it is a
        /// non-negative integer, which will never exceed `2^32-1`, and can be safely downconverted to uint32 in
        /// languages that support this type. NOTE: This field is in Beta.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCrc32c")]
        public virtual System.Nullable<long> PemCrc32c { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// This field contains the public key (with integrity verification), formatted according to the
        /// public_key_format field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual ChecksummedData PublicKeyValue { get; set; }

        /// <summary>The PublicKey format specified by the customer through the public_key_format field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyFormat")]
        public virtual string PublicKeyFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.RawDecrypt.</summary>
    public class RawDecryptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional data that must match the data originally supplied in
        /// RawEncryptRequest.additional_authenticated_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedData")]
        public virtual string AdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the RawDecryptRequest.additional_authenticated_data. If specified,
        /// KeyManagementService will verify the integrity of the received additional_authenticated_data using this
        /// checksum. KeyManagementService will report an error if the checksum verification fails. If you receive a
        /// checksum error, your client should verify that CRC32C(additional_authenticated_data) is equal to
        /// additional_authenticated_data_crc32c, and if so, perform a limited number of retries. A persistent mismatch
        /// may indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for
        /// reasons of compatibility across different languages. However, it is a non-negative integer, which will never
        /// exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedDataCrc32c")]
        public virtual System.Nullable<long> AdditionalAuthenticatedDataCrc32c { get; set; }

        /// <summary>Required. The encrypted data originally returned in RawEncryptResponse.ciphertext.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertext")]
        public virtual string Ciphertext { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the RawDecryptRequest.ciphertext. If specified,
        /// KeyManagementService will verify the integrity of the received ciphertext using this checksum.
        /// KeyManagementService will report an error if the checksum verification fails. If you receive a checksum
        /// error, your client should verify that CRC32C(ciphertext) is equal to ciphertext_crc32c, and if so, perform a
        /// limited number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C
        /// checksum. Note: This field is defined as int64 for reasons of compatibility across different languages.
        /// However, it is a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to
        /// uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertextCrc32c")]
        public virtual System.Nullable<long> CiphertextCrc32c { get; set; }

        /// <summary>
        /// Required. The initialization vector (IV) used during encryption, which must match the data originally
        /// provided in RawEncryptResponse.initialization_vector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializationVector")]
        public virtual string InitializationVector { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the RawDecryptRequest.initialization_vector. If specified,
        /// KeyManagementService will verify the integrity of the received initialization_vector using this checksum.
        /// KeyManagementService will report an error if the checksum verification fails. If you receive a checksum
        /// error, your client should verify that CRC32C(initialization_vector) is equal to
        /// initialization_vector_crc32c, and if so, perform a limited number of retries. A persistent mismatch may
        /// indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for
        /// reasons of compatibility across different languages. However, it is a non-negative integer, which will never
        /// exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializationVectorCrc32c")]
        public virtual System.Nullable<long> InitializationVectorCrc32c { get; set; }

        /// <summary>
        /// The length of the authentication tag that is appended to the end of the ciphertext. If unspecified (0), the
        /// default value for the key's algorithm will be used (for AES-GCM, the default value is 16).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagLength")]
        public virtual System.Nullable<int> TagLength { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.RawDecrypt.</summary>
    public class RawDecryptResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The decrypted data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintext")]
        public virtual string Plaintext { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned RawDecryptResponse.plaintext. An integrity
        /// check of plaintext can be performed by computing the CRC32C checksum of plaintext and comparing your results
        /// to this field. Discard the response in case of non-matching checksum values, and perform a limited number of
        /// retries. A persistent mismatch may indicate an issue in your computation of the CRC32C checksum. Note:
        /// receiving this response message indicates that KeyManagementService is able to successfully decrypt the
        /// ciphertext. Note: This field is defined as int64 for reasons of compatibility across different languages.
        /// However, it is a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to
        /// uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintextCrc32c")]
        public virtual System.Nullable<long> PlaintextCrc32c { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used in decryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether
        /// RawDecryptRequest.additional_authenticated_data_crc32c was received by KeyManagementService and used for the
        /// integrity verification of additional_authenticated_data. A false value of this field indicates either that
        /// // RawDecryptRequest.additional_authenticated_data_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set RawDecryptRequest.additional_authenticated_data_crc32c but this field is
        /// still false, discard the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedAdditionalAuthenticatedDataCrc32c")]
        public virtual System.Nullable<bool> VerifiedAdditionalAuthenticatedDataCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether RawDecryptRequest.ciphertext_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the ciphertext. A false value of this field
        /// indicates either that RawDecryptRequest.ciphertext_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set RawDecryptRequest.ciphertext_crc32c but this field is still false,
        /// discard the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedCiphertextCrc32c")]
        public virtual System.Nullable<bool> VerifiedCiphertextCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether RawDecryptRequest.initialization_vector_crc32c was
        /// received by KeyManagementService and used for the integrity verification of initialization_vector. A false
        /// value of this field indicates either that RawDecryptRequest.initialization_vector_crc32c was left unset or
        /// that it was not delivered to KeyManagementService. If you've set
        /// RawDecryptRequest.initialization_vector_crc32c but this field is still false, discard the response and
        /// perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedInitializationVectorCrc32c")]
        public virtual System.Nullable<bool> VerifiedInitializationVectorCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.RawEncrypt.</summary>
    public class RawEncryptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional data that, if specified, must also be provided during decryption through
        /// RawDecryptRequest.additional_authenticated_data. This field may only be used in conjunction with an
        /// algorithm that accepts additional authenticated data (for example, AES-GCM). The maximum size depends on the
        /// key version's protection_level. For SOFTWARE keys, the plaintext must be no larger than 64KiB. For HSM keys,
        /// the combined length of the plaintext and additional_authenticated_data fields must be no larger than 8KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedData")]
        public virtual string AdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the RawEncryptRequest.additional_authenticated_data. If specified,
        /// KeyManagementService will verify the integrity of the received additional_authenticated_data using this
        /// checksum. KeyManagementService will report an error if the checksum verification fails. If you receive a
        /// checksum error, your client should verify that CRC32C(additional_authenticated_data) is equal to
        /// additional_authenticated_data_crc32c, and if so, perform a limited number of retries. A persistent mismatch
        /// may indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for
        /// reasons of compatibility across different languages. However, it is a non-negative integer, which will never
        /// exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalAuthenticatedDataCrc32c")]
        public virtual System.Nullable<long> AdditionalAuthenticatedDataCrc32c { get; set; }

        /// <summary>
        /// Optional. A customer-supplied initialization vector that will be used for encryption. If it is not provided
        /// for AES-CBC and AES-CTR, one will be generated. It will be returned in
        /// RawEncryptResponse.initialization_vector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializationVector")]
        public virtual string InitializationVector { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the RawEncryptRequest.initialization_vector. If specified,
        /// KeyManagementService will verify the integrity of the received initialization_vector using this checksum.
        /// KeyManagementService will report an error if the checksum verification fails. If you receive a checksum
        /// error, your client should verify that CRC32C(initialization_vector) is equal to
        /// initialization_vector_crc32c, and if so, perform a limited number of retries. A persistent mismatch may
        /// indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as int64 for
        /// reasons of compatibility across different languages. However, it is a non-negative integer, which will never
        /// exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializationVectorCrc32c")]
        public virtual System.Nullable<long> InitializationVectorCrc32c { get; set; }

        /// <summary>
        /// Required. The data to encrypt. Must be no larger than 64KiB. The maximum size depends on the key version's
        /// protection_level. For SOFTWARE keys, the plaintext must be no larger than 64KiB. For HSM keys, the combined
        /// length of the plaintext and additional_authenticated_data fields must be no larger than 8KiB.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintext")]
        public virtual string Plaintext { get; set; }

        /// <summary>
        /// Optional. An optional CRC32C checksum of the RawEncryptRequest.plaintext. If specified, KeyManagementService
        /// will verify the integrity of the received plaintext using this checksum. KeyManagementService will report an
        /// error if the checksum verification fails. If you receive a checksum error, your client should verify that
        /// CRC32C(plaintext) is equal to plaintext_crc32c, and if so, perform a limited number of retries. A persistent
        /// mismatch may indicate an issue in your computation of the CRC32C checksum. Note: This field is defined as
        /// int64 for reasons of compatibility across different languages. However, it is a non-negative integer, which
        /// will never exceed 2^32-1, and can be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plaintextCrc32c")]
        public virtual System.Nullable<long> PlaintextCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyManagementService.RawEncrypt.</summary>
    public class RawEncryptResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The encrypted data. In the case of AES-GCM, the authentication tag is the tag_length bytes at the end of
        /// this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertext")]
        public virtual string Ciphertext { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned RawEncryptResponse.ciphertext. An integrity
        /// check of ciphertext can be performed by computing the CRC32C checksum of ciphertext and comparing your
        /// results to this field. Discard the response in case of non-matching checksum values, and perform a limited
        /// number of retries. A persistent mismatch may indicate an issue in your computation of the CRC32C checksum.
        /// Note: This field is defined as int64 for reasons of compatibility across different languages. However, it is
        /// a non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to uint32 in
        /// languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ciphertextCrc32c")]
        public virtual System.Nullable<long> CiphertextCrc32c { get; set; }

        /// <summary>
        /// The initialization vector (IV) generated by the service during encryption. This value must be stored and
        /// provided in RawDecryptRequest.initialization_vector at decryption time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializationVector")]
        public virtual string InitializationVector { get; set; }

        /// <summary>
        /// Integrity verification field. A CRC32C checksum of the returned RawEncryptResponse.initialization_vector. An
        /// integrity check of initialization_vector can be performed by computing the CRC32C checksum of
        /// initialization_vector and comparing your results to this field. Discard the response in case of non-matching
        /// checksum values, and perform a limited number of retries. A persistent mismatch may indicate an issue in
        /// your computation of the CRC32C checksum. Note: This field is defined as int64 for reasons of compatibility
        /// across different languages. However, it is a non-negative integer, which will never exceed 2^32-1, and can
        /// be safely downconverted to uint32 in languages that support this type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initializationVectorCrc32c")]
        public virtual System.Nullable<long> InitializationVectorCrc32c { get; set; }

        /// <summary>
        /// The resource name of the CryptoKeyVersion used in encryption. Check this field to verify that the intended
        /// resource was used for encryption.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion used in encryption.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>The length of the authentication tag that is appended to the end of the ciphertext.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagLength")]
        public virtual System.Nullable<int> TagLength { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether
        /// RawEncryptRequest.additional_authenticated_data_crc32c was received by KeyManagementService and used for the
        /// integrity verification of additional_authenticated_data. A false value of this field indicates either that
        /// // RawEncryptRequest.additional_authenticated_data_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set RawEncryptRequest.additional_authenticated_data_crc32c but this field is
        /// still false, discard the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedAdditionalAuthenticatedDataCrc32c")]
        public virtual System.Nullable<bool> VerifiedAdditionalAuthenticatedDataCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether RawEncryptRequest.initialization_vector_crc32c was
        /// received by KeyManagementService and used for the integrity verification of initialization_vector. A false
        /// value of this field indicates either that RawEncryptRequest.initialization_vector_crc32c was left unset or
        /// that it was not delivered to KeyManagementService. If you've set
        /// RawEncryptRequest.initialization_vector_crc32c but this field is still false, discard the response and
        /// perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedInitializationVectorCrc32c")]
        public virtual System.Nullable<bool> VerifiedInitializationVectorCrc32c { get; set; }

        /// <summary>
        /// Integrity verification field. A flag indicating whether RawEncryptRequest.plaintext_crc32c was received by
        /// KeyManagementService and used for the integrity verification of the plaintext. A false value of this field
        /// indicates either that RawEncryptRequest.plaintext_crc32c was left unset or that it was not delivered to
        /// KeyManagementService. If you've set RawEncryptRequest.plaintext_crc32c but this field is still false,
        /// discard the response and perform a limited number of retries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedPlaintextCrc32c")]
        public virtual System.Nullable<bool> VerifiedPlaintextCrc32c { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.RestoreCryptoKeyVersion.</summary>
    public class RestoreCryptoKeyVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ServiceResolver represents an EKM replica that can be reached within an EkmConnection.</summary>
    public class ServiceResolver : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The filter applied to the endpoints of the resolved service. If no filter is specified, all
        /// endpoints will be considered. An endpoint will be chosen arbitrarily from the filtered list for each
        /// request. For endpoint filter syntax and examples, see
        /// https://cloud.google.com/service-directory/docs/reference/rpc/google.cloud.servicedirectory.v1#resolveservicerequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointFilter")]
        public virtual string EndpointFilter { get; set; }

        /// <summary>Required. The hostname of the EKM replica used at TLS and HTTP layers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>
        /// Required. A list of leaf server certificates used to authenticate HTTPS connections to the EKM replica.
        /// Currently, a maximum of 10 Certificate is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverCertificates")]
        public virtual System.Collections.Generic.IList<Certificate> ServerCertificates { get; set; }

        /// <summary>
        /// Required. The resource name of the Service Directory service pointing to an EKM replica, in the format
        /// `projects/*/locations/*/namespaces/*/services/*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDirectoryService")]
        public virtual string ServiceDirectoryService { get; set; }

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

    /// <summary>Response message for ShowEffectiveAutokeyConfig.</summary>
    public class ShowEffectiveAutokeyConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the key project configured in the resource project's folder ancestry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyProject")]
        public virtual string KeyProject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for KeyAccessJustificationsConfig.ShowEffectiveKeyAccessJustificationsEnrollmentConfig
    /// </summary>
    public class ShowEffectiveKeyAccessJustificationsEnrollmentConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The effective KeyAccessJustificationsEnrollmentConfig for external keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalConfig")]
        public virtual KeyAccessJustificationsEnrollmentConfig ExternalConfig { get; set; }

        /// <summary>The effective KeyAccessJustificationsEnrollmentConfig for hardware keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareConfig")]
        public virtual KeyAccessJustificationsEnrollmentConfig HardwareConfig { get; set; }

        /// <summary>The effective KeyAccessJustificationsEnrollmentConfig for software keys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareConfig")]
        public virtual KeyAccessJustificationsEnrollmentConfig SoftwareConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for KeyAccessJustificationsConfig.ShowEffectiveKeyAccessJustificationsPolicyConfig.
    /// </summary>
    public class ShowEffectiveKeyAccessJustificationsPolicyConfigResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The effective KeyAccessJustificationsPolicyConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveKajPolicy")]
        public virtual KeyAccessJustificationsPolicyConfig EffectiveKajPolicy { get; set; }

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

    /// <summary>Request message for KeyManagementService.UpdateCryptoKeyPrimaryVersion.</summary>
    public class UpdateCryptoKeyPrimaryVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The id of the child CryptoKeyVersion to use as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyVersionId")]
        public virtual string CryptoKeyVersionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for EkmService.VerifyConnectivity.</summary>
    public class VerifyConnectivityResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The public key component of the wrapping key. For details of the type of key this public key corresponds to, see
    /// the ImportMethod.
    /// </summary>
    public class WrappingPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The public key, encoded in PEM format. For more information, see the [RFC
        /// 7468](https://tools.ietf.org/html/rfc7468) sections for [General
        /// Considerations](https://tools.ietf.org/html/rfc7468#section-2) and [Textual Encoding of Subject Public Key
        /// Info] (https://tools.ietf.org/html/rfc7468#section-13).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pem")]
        public virtual string Pem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
