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
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudkms";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudkms.googleapis.com/";
        #else
            "https://cloudkms.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudkms.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Key Management Service (KMS) API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your keys and secrets stored in Cloud Key Management Service</summary>
            public static string Cloudkms = "https://www.googleapis.com/auth/cloudkms";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Cloud Key Management Service (KMS) API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage your keys and secrets stored in Cloud Key Management Service</summary>
            public const string Cloudkms = "https://www.googleapis.com/auth/cloudkms";
        }

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
                KeyRings = new KeyRingsResource(service);
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
                            return new AsymmetricDecryptRequest(service, body, name);
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
                            return new AsymmetricSignRequest(service, body, name);
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
                            return new CreateRequest(service, body, parent);
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
                        /// CryptoKeyVersion.state will be set to DESTROY_SCHEDULED and destroy_time will be set to a
                        /// time 24 hours in the future, at which point the state will be changed to DESTROYED, and the
                        /// key material will be irrevocably destroyed. Before the destroy_time is reached,
                        /// RestoreCryptoKeyVersion may be called to reverse the process.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The resource name of the CryptoKeyVersion to destroy.</param>
                        public virtual DestroyRequest Destroy(Google.Apis.CloudKMS.v1.Data.DestroyCryptoKeyVersionRequest body, string name)
                        {
                            return new DestroyRequest(service, body, name);
                        }

                        /// <summary>
                        /// Schedule a CryptoKeyVersion for destruction. Upon calling this method,
                        /// CryptoKeyVersion.state will be set to DESTROY_SCHEDULED and destroy_time will be set to a
                        /// time 24 hours in the future, at which point the state will be changed to DESTROYED, and the
                        /// key material will be irrevocably destroyed. Before the destroy_time is reached,
                        /// RestoreCryptoKeyVersion may be called to reverse the process.
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
                            return new GetRequest(service, name);
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
                            return new GetPublicKeyRequest(service, name);
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
                            }
                        }

                        /// <summary>
                        /// Imports a new CryptoKeyVersion into an existing CryptoKey using the wrapped key material
                        /// provided in the request. The version ID will be assigned the next sequential id within the
                        /// CryptoKey.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The name of the CryptoKey to be imported into.</param>
                        public virtual ImportRequest Import(Google.Apis.CloudKMS.v1.Data.ImportCryptoKeyVersionRequest body, string parent)
                        {
                            return new ImportRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Imports a new CryptoKeyVersion into an existing CryptoKey using the wrapped key material
                        /// provided in the request. The version ID will be assigned the next sequential id within the
                        /// CryptoKey.
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

                            /// <summary>Required. The name of the CryptoKey to be imported into.</summary>
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
                            return new ListRequest(service, parent);
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
                            return new PatchRequest(service, body, name);
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
                        /// Restore a CryptoKeyVersion in the DESTROY_SCHEDULED state. Upon restoration of the
                        /// CryptoKeyVersion, state will be set to DISABLED, and destroy_time will be cleared.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The resource name of the CryptoKeyVersion to restore.</param>
                        public virtual RestoreRequest Restore(Google.Apis.CloudKMS.v1.Data.RestoreCryptoKeyVersionRequest body, string name)
                        {
                            return new RestoreRequest(service, body, name);
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
                        return new CreateRequest(service, body, parent);
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
                        return new DecryptRequest(service, body, name);
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
                        return new EncryptRequest(service, body, name);
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
                        return new GetRequest(service, name);
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
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
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
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
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
                        return new ListRequest(service, parent);
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
                        return new PatchRequest(service, body, name);
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
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
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
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
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
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
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
                        return new UpdatePrimaryVersionRequest(service, body, name);
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
                        return new CreateRequest(service, body, parent);
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
                        return new GetRequest(service, name);
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
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
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
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
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
                        return new ListRequest(service, parent);
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
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
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
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
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
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
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
                    return new CreateRequest(service, body, parent);
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
                    return new GetRequest(service, name);
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
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
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
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected. Requests for policies with any conditional
                    /// bindings must specify version 3. Policies without any conditional bindings may specify any valid
                    /// value or leave the field unset. To learn which resources support conditions in their IAM
                    /// policies, see the [IAM
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
                    return new ListRequest(service, parent);
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
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudKMS.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
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
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
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
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudKMS.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
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
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
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

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
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
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in [AIP-160](https://google.aip.dev/160).
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
        /// Optional. The digest of the data to sign. The digest must be produced with the same digest algorithm as
        /// specified by the key version's algorithm.
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
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
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

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

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

    /// <summary>
    /// A CryptoKey represents a logical key that can be used for cryptographic operations. A CryptoKey is made up of
    /// zero or more versions, which represent the actual key material used in cryptographic operations.
    /// </summary>
    public class CryptoKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which this CryptoKey was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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

        /// <summary>
        /// At next_rotation_time, the Key Management Service will automatically: 1. Create a new version of this
        /// CryptoKey. 2. Mark the new version as primary. Key rotations performed manually via CreateCryptoKeyVersion
        /// and UpdateCryptoKeyPrimaryVersion do not affect next_rotation_time. Keys with purpose ENCRYPT_DECRYPT
        /// support automatic rotation. For other keys, this field must be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRotationTime")]
        public virtual object NextRotationTime { get; set; }

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

        /// <summary>Output only. The time at which this CryptoKeyVersion was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The time this CryptoKeyVersion's key material was destroyed. Only present if state is
        /// DESTROYED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destroyEventTime")]
        public virtual object DestroyEventTime { get; set; }

        /// <summary>
        /// Output only. The time this CryptoKeyVersion's key material is scheduled for destruction. Only present if
        /// state is DESTROY_SCHEDULED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destroyTime")]
        public virtual object DestroyTime { get; set; }

        /// <summary>
        /// ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that
        /// are specific to the EXTERNAL protection level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalProtectionLevelOptions")]
        public virtual ExternalProtectionLevelOptions ExternalProtectionLevelOptions { get; set; }

        /// <summary>Output only. The time this CryptoKeyVersion's key material was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateTime")]
        public virtual object GenerateTime { get; set; }

        /// <summary>Output only. The root cause of an import failure. Only present if state is IMPORT_FAILED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importFailureReason")]
        public virtual string ImportFailureReason { get; set; }

        /// <summary>
        /// Output only. The name of the ImportJob used to import this CryptoKeyVersion. Only present if the underlying
        /// key material was imported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importJob")]
        public virtual string ImportJob { get; set; }

        /// <summary>Output only. The time at which this CryptoKeyVersion's key material was imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importTime")]
        public virtual object ImportTime { get; set; }

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

    /// <summary>Request message for KeyManagementService.Encrypt.</summary>
    public class EncryptRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional data that, if specified, must also be provided during decryption through
        /// DecryptRequest.additional_authenticated_data. The maximum size depends on the key version's
        /// protection_level. For SOFTWARE keys, the AAD must be no larger than 64KiB. For HSM keys, the combined length
        /// of the plaintext and additional_authenticated_data fields must be no larger than 8KiB.
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
        /// protection_level. For SOFTWARE keys, the plaintext must be no larger than 64KiB. For HSM keys, the combined
        /// length of the plaintext and additional_authenticated_data fields must be no larger than 8KiB.
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
    /// specific to the EXTERNAL protection level.
    /// </summary>
    public class ExternalProtectionLevelOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI for an external resource that this CryptoKeyVersion represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalKeyUri")]
        public virtual string ExternalKeyUri { get; set; }

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

        /// <summary>Required. The name of the ImportJob that was used to wrap this key material.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importJob")]
        public virtual string ImportJob { get; set; }

        /// <summary>
        /// Wrapped key material produced with RSA_OAEP_3072_SHA1_AES_256 or RSA_OAEP_4096_SHA1_AES_256. This field
        /// contains the concatenation of two wrapped keys: 1. An ephemeral AES-256 wrapping key wrapped with the
        /// public_key using RSAES-OAEP with SHA-1, MGF1 with SHA-1, and an empty label. 2. The key to be imported,
        /// wrapped with the ephemeral AES-256 key using AES-KWP (RFC 5649). If importing symmetric key material, it is
        /// expected that the unwrapped key contains plain bytes. If importing asymmetric key material, it is expected
        /// that the unwrapped key is in PKCS#8-encoded DER format (the PrivateKeyInfo structure from RFC 5208). This
        /// format is the same as the format produced by PKCS#11 mechanism CKM_RSA_AES_KEY_WRAP.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rsaAesWrappedKey")]
        public virtual string RsaAesWrappedKey { get; set; }

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

        /// <summary>Output only. The time at which this ImportJob was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The time this ImportJob expired. Only present if state is EXPIRED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireEventTime")]
        public virtual object ExpireEventTime { get; set; }

        /// <summary>
        /// Output only. The time at which this ImportJob is scheduled for expiration and can no longer be used to
        /// import key material.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>Output only. The time this ImportJob's key material was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateTime")]
        public virtual object GenerateTime { get; set; }

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
        /// <summary>Output only. The time at which this KeyRing was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

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

        /// <summary>The total number of CryptoKeyVersions that matched the query.</summary>
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

        /// <summary>The total number of CryptoKeys that matched the query.</summary>
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

        /// <summary>The total number of ImportJobs that matched the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

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

        /// <summary>The total number of KeyRings that matched the query.</summary>
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

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
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

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
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

    /// <summary>The public key for a given CryptoKeyVersion. Obtained via GetPublicKey.</summary>
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
        /// non-negative integer, which will never exceed 2^32-1, and can be safely downconverted to uint32 in languages
        /// that support this type. NOTE: This field is in Beta.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pemCrc32c")]
        public virtual System.Nullable<long> PemCrc32c { get; set; }

        /// <summary>The ProtectionLevel of the CryptoKeyVersion public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectionLevel")]
        public virtual string ProtectionLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for KeyManagementService.RestoreCryptoKeyVersion.</summary>
    public class RestoreCryptoKeyVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
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

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
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
