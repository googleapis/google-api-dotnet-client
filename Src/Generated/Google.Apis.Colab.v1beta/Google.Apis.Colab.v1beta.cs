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

namespace Google.Apis.Colab.v1beta
{
    /// <summary>The Colab Service.</summary>
    public class ColabService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ColabService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ColabService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Runtimes = new RuntimesResource(this);
            Runtimespecs = new RuntimespecsResource(this);
            V1beta = new V1betaResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://colaboratory.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://colaboratory.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "colaboratory";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Colab API.</summary>
        public class Scope
        {
            /// <summary>Read, write, and delete your Colab resources</summary>
            public static string Colaboratory = "https://www.googleapis.com/auth/colaboratory";

            /// <summary>Read-only access to your Colab resources</summary>
            public static string ColaboratoryReadonly = "https://www.googleapis.com/auth/colaboratory.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Colab API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Read, write, and delete your Colab resources</summary>
            public const string Colaboratory = "https://www.googleapis.com/auth/colaboratory";

            /// <summary>Read-only access to your Colab resources</summary>
            public const string ColaboratoryReadonly = "https://www.googleapis.com/auth/colaboratory.readonly";
        }

        /// <summary>Gets the Runtimes resource.</summary>
        public virtual RuntimesResource Runtimes { get; }

        /// <summary>Gets the Runtimespecs resource.</summary>
        public virtual RuntimespecsResource Runtimespecs { get; }

        /// <summary>Gets the V1beta resource.</summary>
        public virtual V1betaResource V1beta { get; }
    }

    /// <summary>A base abstract class for Colab requests.</summary>
    public abstract class ColabBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ColabBaseServiceRequest instance.</summary>
        protected ColabBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Colab parameter list.</summary>
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

    /// <summary>The "runtimes" collection of methods.</summary>
    public class RuntimesResource
    {
        private const string Resource = "runtimes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RuntimesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a Colab runtime assignment. When runtime creation is refused with a [`FAILED_PRECONDITION` (code:
        /// 9)](https://github.com/googleapis/googleapis/blob/437254f595a380cd9323111700ce0fcf9d6d2c21/google/rpc/code.proto#L128)
        /// error, a more specific error reason will be returned in the details of the Operation error wrapped in
        /// google.rpc.ErrorInfo. A requests-per-minute-per-project and a requests-per-minute-per-user quota are
        /// enforced on this API. To see the exact limit your project is subject to, after you enable the Colab API,
        /// view it in your project's [Quotas &amp;amp; System
        /// Limits](https://console.cloud.google.com/apis/api/colaboratory.googleapis.com/quotas) page. Note that there
        /// is no usage reporting on the per-user limit and it is not overridable at the individual user level.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Colab.v1beta.Data.Runtime body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates a Colab runtime assignment. When runtime creation is refused with a [`FAILED_PRECONDITION` (code:
        /// 9)](https://github.com/googleapis/googleapis/blob/437254f595a380cd9323111700ce0fcf9d6d2c21/google/rpc/code.proto#L128)
        /// error, a more specific error reason will be returned in the details of the Operation error wrapped in
        /// google.rpc.ErrorInfo. A requests-per-minute-per-project and a requests-per-minute-per-user quota are
        /// enforced on this API. To see the exact limit your project is subject to, after you enable the Colab API,
        /// view it in your project's [Quotas &amp;amp; System
        /// Limits](https://console.cloud.google.com/apis/api/colaboratory.googleapis.com/quotas) page. Note that there
        /// is no usage reporting on the per-user limit and it is not overridable at the individual user level.
        /// </summary>
        public class CreateRequest : ColabBaseServiceRequest<Google.Apis.Colab.v1beta.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Colab.v1beta.Data.Runtime body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. A unique identifier for this request. This request is only idempotent if a `request_id` is
            /// provided. See [AIP-155](https://google.aip.dev/155) for more details. If provided, the request ID must
            /// be in UUID4 format per https://linter.aip.dev/155/request-id-format.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("requestId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RequestId { get; set; }

            /// <summary>
            /// Optional. A unique identifier for the runtime. If not supplied, a random ID will be generated. If a
            /// runtime with the given ID owned by the requesting user already exists, a completed Operation with an
            /// [`ALREADY_EXISTS` (code:
            /// 6)](https://github.com/googleapis/googleapis/blob/437254f595a380cd9323111700ce0fcf9d6d2c21/google/rpc/code.proto#L84)
            /// error will be returned. See [AIP-133](https://google.aip.dev/133#user-specified-ids) for more details.
            /// The ID must conform to [RFC-1034](https://datatracker.ietf.org/doc/html/rfc1034), specifically: - 1 to
            /// 63 characters - Lower-case letters, digits, and hyphens - Start with a letter - End with a letter or
            /// digit
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("runtimeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RuntimeId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Colab.v1beta.Data.Runtime Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/runtimes";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("requestId", new Google.Apis.Discovery.Parameter
                {
                    Name = "requestId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("runtimeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "runtimeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes a Colab runtime assignment. **Best Practices:** - Avoid deleting runtimes unless necessary. Reuse
        /// runtimes for efficiency. - Open a new Jupyter session on an existing runtime for state isolation.
        /// </summary>
        /// <param name="name">Required. The name of the runtime to unassign. Format: `runtimes/{runtime_id}`.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes a Colab runtime assignment. **Best Practices:** - Avoid deleting runtimes unless necessary. Reuse
        /// runtimes for efficiency. - Open a new Jupyter session on an existing runtime for state isolation.
        /// </summary>
        public class DeleteRequest : ColabBaseServiceRequest<Google.Apis.Colab.v1beta.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the runtime to unassign. Format: `runtimes/{runtime_id}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. If set to `true`, and the runtime is not found, the request will succeed but no action will be
            /// taken on the server.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllowMissing { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^runtimes/[^/]+$",
                });
                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                {
                    Name = "allowMissing",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a Colab runtime assigned to the requesting user.</summary>
        /// <param name="name">Required. The name of the runtime to retrieve. Format: `runtimes/{runtime_id}`.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets a Colab runtime assigned to the requesting user.</summary>
        public class GetRequest : ColabBaseServiceRequest<Google.Apis.Colab.v1beta.Data.Runtime>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the runtime to retrieve. Format: `runtimes/{runtime_id}`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

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
                    Pattern = @"^runtimes/[^/]+$",
                });
            }
        }

        /// <summary>Lists Colab runtimes assigned to the requesting user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists Colab runtimes assigned to the requesting user.</summary>
        public class ListRequest : ColabBaseServiceRequest<Google.Apis.Colab.v1beta.Data.ListRuntimesResponse>
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
            public override string RestPath => "v1beta/runtimes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "runtimespecs" collection of methods.</summary>
    public class RuntimespecsResource
    {
        private const string Resource = "runtimespecs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RuntimespecsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Lists available Colab runtime specs and their eligibility to the requesting user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists available Colab runtime specs and their eligibility to the requesting user.</summary>
        public class ListRequest : ColabBaseServiceRequest<Google.Apis.Colab.v1beta.Data.ListRuntimeSpecsResponse>
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
            public override string RestPath => "v1beta/runtimespecs";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "v1beta" collection of methods.</summary>
    public class V1betaResource
    {
        private const string Resource = "v1beta";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1betaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets the subscription of the requesting user.</summary>
        /// <param name="name">
        /// Required. The name of the subscription to retrieve. The only valid value is "subscription".
        /// </param>
        public virtual GetSubscriptionRequest GetSubscription(string name)
        {
            return new GetSubscriptionRequest(this.service, name);
        }

        /// <summary>Gets the subscription of the requesting user.</summary>
        public class GetSubscriptionRequest : ColabBaseServiceRequest<Google.Apis.Colab.v1beta.Data.Subscription>
        {
            /// <summary>Constructs a new GetSubscription request.</summary>
            public GetSubscriptionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the subscription to retrieve. The only valid value is "subscription".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSubscription";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes GetSubscription parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^subscription$",
                });
            }
        }
    }
}
namespace Google.Apis.Colab.v1beta.Data
{
    /// <summary>Connection info used to authenticate to the runtime.</summary>
    public class ConnectionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>Required. Output only. The expiration time of the runtime proxy token.</summary>
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

        /// <summary>
        /// Required. Output only. The runtime proxy token. This is a short-lived credential used to authenticate to the
        /// runtime. Clients should set this token as the value of the `X-Colab-Runtime-Proxy-Token` HTTP header when
        /// connecting to the runtime, and call the GetRuntime API to refresh this token when approaching `expire_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>Required. Output only. The authenticated URL that can be used to connect to the runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

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
    /// Describes the cause of the error with structured details. Example of an error when contacting the
    /// "pubsub.googleapis.com" API when it is not enabled: { "reason": "API_DISABLED" "domain": "googleapis.com"
    /// "metadata": { "resource": "projects/123", "service": "pubsub.googleapis.com" } } This response indicates that
    /// the pubsub.googleapis.com API is not enabled. Example of an error that is returned when attempting to create a
    /// Spanner instance in a region that is out of stock: { "reason": "STOCKOUT" "domain": "spanner.googleapis.com",
    /// "metadata": { "availableRegions": "us-central1,us-east2" } }
    /// </summary>
    public class ErrorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The logical grouping to which the "reason" belongs. The error domain is typically the registered service
        /// name of the tool or product that generates the error. Example: "pubsub.googleapis.com". If the error is
        /// generated by some common infrastructure, the error domain must be a globally unique value that identifies
        /// the infrastructure. For Google API infrastructure, the error domain is "googleapis.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// Additional structured details about this error. Keys must match a regular expression of `a-z+` but should
        /// ideally be lowerCamelCase. Also, they must be limited to 64 characters in length. When identifying the
        /// current value of an exceeded limit, the units should be contained in the key, not the value. For example,
        /// rather than `{"instanceLimit": "100/request"}`, should be returned as, `{"instanceLimitPerRequest": "100"}`,
        /// if the client exceeds the number of instances that can be created in a single (batch) request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The reason for the error. This is a constant value that identifies the proximate cause of the error. Error
        /// reasons are unique within a particular domain of errors. This should be at most 63 characters and match a
        /// regular expression of `A-Z+[A-Z0-9]`, which represents UPPER_SNAKE_CASE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Key fields that uniquely identify a runtime spec.</summary>
    public class Key : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Runtime accelerator model name (e.g., "T4", "L4", "A100"). For CPU runtime specs, this field will
        /// be "NONE".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerator")]
        public virtual string Accelerator { get; set; }

        /// <summary>Required. Runtime shape.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual string Shape { get; set; }

        /// <summary>Required. Runtime variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variant")]
        public virtual string Variant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListRuntimeSpecs`.</summary>
    public class ListRuntimeSpecsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of runtime specs available to the requesting user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSpecs")]
        public virtual System.Collections.Generic.IList<RuntimeSpec> RuntimeSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `ListRuntimes`.</summary>
    public class ListRuntimesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of runtimes assigned to the requesting user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimes")]
        public virtual System.Collections.Generic.IList<Runtime> Runtimes { get; set; }

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
    /// A Colab managed runtime. This is essentially a Jupyter server that runs on Google infrastructure. Clients should
    /// use the connection_info provided to connect to the runtime, and leverage the standard Jupyter [REST
    /// API](https://jupyter-server.readthedocs.io/en/stable/developers/rest-api.html) and/or [client
    /// library](https://jupyter-client.readthedocs.io/en/stable/api/jupyter_client.html) to interact with the runtime.
    /// </summary>
    public class Runtime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The connection info used to authenticate to the runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectionInfo")]
        public virtual ConnectionInfo ConnectionInfo { get; set; }

        /// <summary>
        /// Identifier. The name of the runtime in the format `runtimes/{runtime_id}`, where `runtime_id` is either the
        /// value supplied via CreateRuntimeRequest.runtime_id or, if none was supplied, a random ID generated by the
        /// backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The specification of the runtime. When calling `CreateRuntime`, this field should be set to an
        /// eligible runtime spec obtained from the ListRuntimeSpecsResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeSpec")]
        public virtual Key RuntimeSpec { get; set; }

        /// <summary>
        /// Optional. The version of the runtime image. See [Colab Runtime Version
        /// FAQ](https://research.google.com/colaboratory/runtime-version-faq.html) for supported runtime versions. If
        /// omitted (empty), the latest runtime image is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specification of a runtime.</summary>
    public class RuntimeSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether the requesting user is eligible for the runtime spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligible")]
        public virtual System.Nullable<bool> Eligible { get; set; }

        /// <summary>Required. The key of the runtime spec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual Key Key { get; set; }

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

    /// <summary>Colab user subscription information.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier. Name of the subscription. This will always be "subscription".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. User's Colab subscription tier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
