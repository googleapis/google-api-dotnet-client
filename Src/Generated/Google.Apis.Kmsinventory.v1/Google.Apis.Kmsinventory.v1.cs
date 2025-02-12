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

namespace Google.Apis.Kmsinventory.v1
{
    /// <summary>The Kmsinventory Service.</summary>
    public class KmsinventoryService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public KmsinventoryService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public KmsinventoryService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://kmsinventory.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://kmsinventory.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "kmsinventory";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the KMS Inventory API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the KMS Inventory API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Kmsinventory requests.</summary>
    public abstract class KmsinventoryBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new KmsinventoryBaseServiceRequest instance.</summary>
        protected KmsinventoryBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Kmsinventory parameter list.</summary>
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
            ProtectedResources = new ProtectedResourcesResource(service);
        }

        /// <summary>Gets the ProtectedResources resource.</summary>
        public virtual ProtectedResourcesResource ProtectedResources { get; }

        /// <summary>The "protectedResources" collection of methods.</summary>
        public class ProtectedResourcesResource
        {
            private const string Resource = "protectedResources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProtectedResourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns metadata about the resources protected by the given Cloud KMS CryptoKey in the given Cloud
            /// organization.
            /// </summary>
            /// <param name="scope">Required. Resource name of the organization. Example: organizations/123</param>
            public virtual SearchRequest Search(string scope)
            {
                return new SearchRequest(this.service, scope);
            }

            /// <summary>
            /// Returns metadata about the resources protected by the given Cloud KMS CryptoKey in the given Cloud
            /// organization.
            /// </summary>
            public class SearchRequest : KmsinventoryBaseServiceRequest<Google.Apis.Kmsinventory.v1.Data.GoogleCloudKmsInventoryV1SearchProtectedResourcesResponse>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, string scope) : base(service)
                {
                    Scope = scope;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the organization. Example: organizations/123</summary>
                [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Scope { get; private set; }

                /// <summary>Required. The resource name of the CryptoKey.</summary>
                [Google.Apis.Util.RequestParameterAttribute("cryptoKey", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CryptoKey { get; set; }

                /// <summary>
                /// The maximum number of resources to return. The service may return fewer than this value. If
                /// unspecified, at most 500 resources will be returned. The maximum value is 500; values above 500 will
                /// be coerced to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous KeyTrackingService.SearchProtectedResources call. Provide
                /// this to retrieve the subsequent page. When paginating, all other parameters provided to
                /// KeyTrackingService.SearchProtectedResources must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. A list of resource types that this request searches for. If empty, it will search all the
                /// [trackable resource types](https://cloud.google.com/kms/docs/view-key-usage#tracked-resource-types).
                /// Regular expressions are also supported. For example: * `compute.googleapis.com.*` snapshots
                /// resources whose type starts with `compute.googleapis.com`. * `.*Image` snapshots resources whose
                /// type ends with `Image`. * `.*Image.*` snapshots resources whose type contains `Image`. See
                /// [RE2](https://github.com/google/re2/wiki/Syntax) for all supported regular expression syntax. If the
                /// regular expression does not match any supported resource type, an INVALID_ARGUMENT error will be
                /// returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceTypes", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ResourceTypes { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+scope}/protectedResources:search";

                /// <summary>Initializes Search parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("scope", new Google.Apis.Discovery.Parameter
                    {
                        Name = "scope",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("cryptoKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "cryptoKey",
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
                    RequestParameters.Add("resourceTypes", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceTypes",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
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
            CryptoKeys = new CryptoKeysResource(service);
            Locations = new LocationsResource(service);
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
            }

            /// <summary>
            /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project. Note that this data is sourced
            /// from snapshots, meaning it may not completely reflect the actual state of key metadata at call time.
            /// </summary>
            /// <param name="parent">
            /// Required. The Google Cloud project for which to retrieve key metadata, in the format `projects/*`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Returns cryptographic keys managed by Cloud KMS in a given Cloud project. Note that this data is sourced
            /// from snapshots, meaning it may not completely reflect the actual state of key metadata at call time.
            /// </summary>
            public class ListRequest : KmsinventoryBaseServiceRequest<Google.Apis.Kmsinventory.v1.Data.GoogleCloudKmsInventoryV1ListCryptoKeysResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The Google Cloud project for which to retrieve key metadata, in the format `projects/*`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of keys to return. The service may return fewer than this value. If
                /// unspecified, at most 1000 keys will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. Pass this into a subsequent request in order to receive the next page of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

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
                        Pattern = @"^projects/[^/]+$",
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
                    }

                    /// <summary>
                    /// Returns aggregate information about the resources protected by the given Cloud KMS CryptoKey.
                    /// Only resources within the same Cloud organization as the key will be returned. The project that
                    /// holds the key must be part of an organization in order for this call to succeed.
                    /// </summary>
                    /// <param name="name">Required. The resource name of the CryptoKey.</param>
                    public virtual GetProtectedResourcesSummaryRequest GetProtectedResourcesSummary(string name)
                    {
                        return new GetProtectedResourcesSummaryRequest(this.service, name);
                    }

                    /// <summary>
                    /// Returns aggregate information about the resources protected by the given Cloud KMS CryptoKey.
                    /// Only resources within the same Cloud organization as the key will be returned. The project that
                    /// holds the key must be part of an organization in order for this call to succeed.
                    /// </summary>
                    public class GetProtectedResourcesSummaryRequest : KmsinventoryBaseServiceRequest<Google.Apis.Kmsinventory.v1.Data.GoogleCloudKmsInventoryV1ProtectedResourcesSummary>
                    {
                        /// <summary>Constructs a new GetProtectedResourcesSummary request.</summary>
                        public GetProtectedResourcesSummaryRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the CryptoKey.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getProtectedResourcesSummary";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/protectedResourcesSummary";

                        /// <summary>Initializes GetProtectedResourcesSummary parameter list.</summary>
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
                }
            }
        }
    }
}
namespace Google.Apis.Kmsinventory.v1.Data
{
    /// <summary>Response message for KeyDashboardService.ListCryptoKeys.</summary>
    public class GoogleCloudKmsInventoryV1ListCryptoKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of CryptoKeys.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeys")]
        public virtual System.Collections.Generic.IList<GoogleCloudKmsV1CryptoKey> CryptoKeys { get; set; }

        /// <summary>The page token returned from the previous response if the next page is desired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a resource protected by a Cloud KMS key.</summary>
    public class GoogleCloudKmsInventoryV1ProtectedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud product that owns the resource. Example: `compute`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProduct")]
        public virtual string CloudProduct { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which this resource was created. The granularity is in seconds. Timestamp.nanos
        /// will always be 0.
        /// </summary>
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
        /// The name of the Cloud KMS
        /// [CryptoKeyVersion](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys.cryptoKeyVersions?hl=en)
        /// used to protect this resource via CMEK. This field is empty if the Google Cloud product owning the resource
        /// does not provide key version data to Asset Inventory. If there are multiple key versions protecting the
        /// resource, then this is same value as the first element of crypto_key_versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyVersion")]
        public virtual string CryptoKeyVersion { get; set; }

        /// <summary>
        /// The names of the Cloud KMS
        /// [CryptoKeyVersion](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys.cryptoKeyVersions?hl=en)
        /// used to protect this resource via CMEK. This field is empty if the Google Cloud product owning the resource
        /// does not provide key versions data to Asset Inventory. The first element of this field is stored in
        /// crypto_key_version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyVersions")]
        public virtual System.Collections.Generic.IList<string> CryptoKeyVersions { get; set; }

        /// <summary>A key-value pair of the resource's labels (v1) to their values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Location can be `global`, regional like `us-east1`, or zonal like `us-west1-b`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The full resource name of the resource. Example:
        /// `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Format: `projects/{PROJECT_NUMBER}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The ID of the project that owns the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Example: `compute.googleapis.com/Disk`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Aggregate information about the resources protected by a Cloud KMS key in the same Cloud organization as the
    /// key.
    /// </summary>
    public class GoogleCloudKmsInventoryV1ProtectedResourcesSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of resources protected by the key grouped by Cloud product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudProducts")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> CloudProducts { get; set; }

        /// <summary>The number of resources protected by the key grouped by region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> Locations { get; set; }

        /// <summary>
        /// The full name of the ProtectedResourcesSummary resource. Example:
        /// projects/test-project/locations/us/keyRings/test-keyring/cryptoKeys/test-key/protectedResourcesSummary
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The number of distinct Cloud projects in the same Cloud organization as the key that have resources
        /// protected by the key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectCount")]
        public virtual System.Nullable<int> ProjectCount { get; set; }

        /// <summary>The total number of protected resources in the same Cloud organization as the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCount")]
        public virtual System.Nullable<long> ResourceCount { get; set; }

        /// <summary>The number of resources protected by the key grouped by resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> ResourceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for KeyTrackingService.SearchProtectedResources.</summary>
    public class GoogleCloudKmsInventoryV1SearchProtectedResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Protected resources for this page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudKmsInventoryV1ProtectedResource> ProtectedResources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CryptoKey represents a logical key that can be used for cryptographic operations. A CryptoKey is made up of
    /// zero or more versions, which represent the actual key material used in cryptographic operations.
    /// </summary>
    public class GoogleCloudKmsV1CryptoKey : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleCloudKmsV1KeyAccessJustificationsPolicy KeyAccessJustificationsPolicy { get; set; }

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
        public virtual GoogleCloudKmsV1CryptoKeyVersion Primary { get; set; }

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
        public virtual GoogleCloudKmsV1CryptoKeyVersionTemplate VersionTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A CryptoKeyVersion represents an individual cryptographic key, and the associated key material. An ENABLED
    /// version can be used for cryptographic operations. For security reasons, the raw cryptographic key material
    /// represented by a CryptoKeyVersion can never be viewed or exported. It can only be used to encrypt, decrypt, or
    /// sign data when an authorized user or application invokes Cloud KMS.
    /// </summary>
    public class GoogleCloudKmsV1CryptoKeyVersion : Google.Apis.Requests.IDirectResponseSchema
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
        public virtual GoogleCloudKmsV1KeyOperationAttestation Attestation { get; set; }

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
        public virtual GoogleCloudKmsV1ExternalProtectionLevelOptions ExternalProtectionLevelOptions { get; set; }

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
    public class GoogleCloudKmsV1CryptoKeyVersionTemplate : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// ExternalProtectionLevelOptions stores a group of additional fields for configuring a CryptoKeyVersion that are
    /// specific to the EXTERNAL protection level and EXTERNAL_VPC protection levels.
    /// </summary>
    public class GoogleCloudKmsV1ExternalProtectionLevelOptions : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// A KeyAccessJustificationsPolicy specifies zero or more allowed AccessReason values for encrypt, decrypt, and
    /// sign operations on a CryptoKey.
    /// </summary>
    public class GoogleCloudKmsV1KeyAccessJustificationsPolicy : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Contains an HSM-generated attestation about a key operation. For more information, see [Verifying attestations]
    /// (https://cloud.google.com/kms/docs/attest-key).
    /// </summary>
    public class GoogleCloudKmsV1KeyOperationAttestation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The certificate chains needed to validate the attestation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certChains")]
        public virtual GoogleCloudKmsV1KeyOperationAttestationCertificateChains CertChains { get; set; }

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

    /// <summary>
    /// Certificate chains needed to verify the attestation. Certificates in chains are PEM-encoded and are ordered
    /// based on https://tools.ietf.org/html/rfc5246#section-7.4.2.
    /// </summary>
    public class GoogleCloudKmsV1KeyOperationAttestationCertificateChains : Google.Apis.Requests.IDirectResponseSchema
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
}
