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

namespace Google.Apis.ServiceControl.v1
{
    /// <summary>The ServiceControl Service.</summary>
    public class ServiceControlService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ServiceControlService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ServiceControlService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Services = new ServicesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "servicecontrol";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://servicecontrol.googleapis.com/";
        #else
            "https://servicecontrol.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://servicecontrol.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Service Control API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google Service Control data</summary>
            public static string Servicecontrol = "https://www.googleapis.com/auth/servicecontrol";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Service Control API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google Service Control data</summary>
            public const string Servicecontrol = "https://www.googleapis.com/auth/servicecontrol";
        }

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }
    }

    /// <summary>A base abstract class for ServiceControl requests.</summary>
    public abstract class ServiceControlBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ServiceControlBaseServiceRequest instance.</summary>
        protected ServiceControlBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ServiceControl parameter list.</summary>
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

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be called before the operation is executed.
        /// This method requires the `servicemanagement.services.quota` permission on the specified service. For more
        /// information, see [Cloud IAM](https://cloud.google.com/iam). **NOTE:** The client **must** fail-open on
        /// server errors `INTERNAL`, `UNKNOWN`, `DEADLINE_EXCEEDED`, and `UNAVAILABLE`. To ensure system reliability,
        /// the server may inject these errors to prohibit any hard dependency on the quota functionality.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="serviceName">
        /// Name of the service as specified in the service configuration. For example, `"pubsub.googleapis.com"`. See
        /// google.api.Service for the definition of a service name.
        /// </param>
        public virtual AllocateQuotaRequest AllocateQuota(Google.Apis.ServiceControl.v1.Data.AllocateQuotaRequest body, string serviceName)
        {
            return new AllocateQuotaRequest(service, body, serviceName);
        }

        /// <summary>
        /// Attempts to allocate quota for the specified consumer. It should be called before the operation is executed.
        /// This method requires the `servicemanagement.services.quota` permission on the specified service. For more
        /// information, see [Cloud IAM](https://cloud.google.com/iam). **NOTE:** The client **must** fail-open on
        /// server errors `INTERNAL`, `UNKNOWN`, `DEADLINE_EXCEEDED`, and `UNAVAILABLE`. To ensure system reliability,
        /// the server may inject these errors to prohibit any hard dependency on the quota functionality.
        /// </summary>
        public class AllocateQuotaRequest : ServiceControlBaseServiceRequest<Google.Apis.ServiceControl.v1.Data.AllocateQuotaResponse>
        {
            /// <summary>Constructs a new AllocateQuota request.</summary>
            public AllocateQuotaRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceControl.v1.Data.AllocateQuotaRequest body, string serviceName) : base(service)
            {
                ServiceName = serviceName;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Name of the service as specified in the service configuration. For example, `"pubsub.googleapis.com"`.
            /// See google.api.Service for the definition of a service name.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ServiceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceControl.v1.Data.AllocateQuotaRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "allocateQuota";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{serviceName}:allocateQuota";

            /// <summary>Initializes AllocateQuota parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Checks whether an operation on a service should be allowed to proceed based on the configuration of the
        /// service and related policies. It must be called before the operation is executed. If feasible, the client
        /// should cache the check results and reuse them for 60 seconds. In case of any server errors, the client
        /// should rely on the cached results for much longer time to avoid outage. WARNING: There is general 60s delay
        /// for the configuration and policy propagation, therefore callers MUST NOT depend on the `Check` method having
        /// the latest policy information. NOTE: the CheckRequest has the size limit (wire-format byte size) of 1MB.
        /// This method requires the `servicemanagement.services.check` permission on the specified service. For more
        /// information, see [Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="serviceName">
        /// The service name as specified in its service configuration. For example, `"pubsub.googleapis.com"`. See
        /// [google.api.Service](https://cloud.google.com/service-management/reference/rpc/google.api#google.api.Service)
        /// for the definition of a service name.
        /// </param>
        public virtual CheckRequest Check(Google.Apis.ServiceControl.v1.Data.CheckRequest body, string serviceName)
        {
            return new CheckRequest(service, body, serviceName);
        }

        /// <summary>
        /// Checks whether an operation on a service should be allowed to proceed based on the configuration of the
        /// service and related policies. It must be called before the operation is executed. If feasible, the client
        /// should cache the check results and reuse them for 60 seconds. In case of any server errors, the client
        /// should rely on the cached results for much longer time to avoid outage. WARNING: There is general 60s delay
        /// for the configuration and policy propagation, therefore callers MUST NOT depend on the `Check` method having
        /// the latest policy information. NOTE: the CheckRequest has the size limit (wire-format byte size) of 1MB.
        /// This method requires the `servicemanagement.services.check` permission on the specified service. For more
        /// information, see [Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        public class CheckRequest : ServiceControlBaseServiceRequest<Google.Apis.ServiceControl.v1.Data.CheckResponse>
        {
            /// <summary>Constructs a new Check request.</summary>
            public CheckRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceControl.v1.Data.CheckRequest body, string serviceName) : base(service)
            {
                ServiceName = serviceName;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The service name as specified in its service configuration. For example, `"pubsub.googleapis.com"`. See
            /// [google.api.Service](https://cloud.google.com/service-management/reference/rpc/google.api#google.api.Service)
            /// for the definition of a service name.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ServiceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceControl.v1.Data.CheckRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "check";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{serviceName}:check";

            /// <summary>Initializes Check parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and metrics. It should be called after an
        /// operation is completed. If feasible, the client should aggregate reporting data for up to 5 seconds to
        /// reduce API traffic. Limiting aggregation to 5 seconds is to reduce data loss during client crashes. Clients
        /// should carefully choose the aggregation time window to avoid data loss risk more than 0.01% for business and
        /// compliance reasons. NOTE: the ReportRequest has the size limit (wire-format byte size) of 1MB. This method
        /// requires the `servicemanagement.services.report` permission on the specified service. For more information,
        /// see [Google Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="serviceName">
        /// The service name as specified in its service configuration. For example, `"pubsub.googleapis.com"`. See
        /// [google.api.Service](https://cloud.google.com/service-management/reference/rpc/google.api#google.api.Service)
        /// for the definition of a service name.
        /// </param>
        public virtual ReportRequest Report(Google.Apis.ServiceControl.v1.Data.ReportRequest body, string serviceName)
        {
            return new ReportRequest(service, body, serviceName);
        }

        /// <summary>
        /// Reports operation results to Google Service Control, such as logs and metrics. It should be called after an
        /// operation is completed. If feasible, the client should aggregate reporting data for up to 5 seconds to
        /// reduce API traffic. Limiting aggregation to 5 seconds is to reduce data loss during client crashes. Clients
        /// should carefully choose the aggregation time window to avoid data loss risk more than 0.01% for business and
        /// compliance reasons. NOTE: the ReportRequest has the size limit (wire-format byte size) of 1MB. This method
        /// requires the `servicemanagement.services.report` permission on the specified service. For more information,
        /// see [Google Cloud IAM](https://cloud.google.com/iam).
        /// </summary>
        public class ReportRequest : ServiceControlBaseServiceRequest<Google.Apis.ServiceControl.v1.Data.ReportResponse>
        {
            /// <summary>Constructs a new Report request.</summary>
            public ReportRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceControl.v1.Data.ReportRequest body, string serviceName) : base(service)
            {
                ServiceName = serviceName;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The service name as specified in its service configuration. For example, `"pubsub.googleapis.com"`. See
            /// [google.api.Service](https://cloud.google.com/service-management/reference/rpc/google.api#google.api.Service)
            /// for the definition of a service name.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("serviceName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ServiceName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ServiceControl.v1.Data.ReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "report";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/services/{serviceName}:report";

            /// <summary>Initializes Report parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("serviceName", new Google.Apis.Discovery.Parameter
                {
                    Name = "serviceName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.ServiceControl.v1.Data
{
    public class AllocateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of label keys that were unused by the server in processing the request. Thus, for similar requests
        /// repeated in a certain future time window, the caller can choose to ignore these labels in the requests to
        /// achieve better client-side cache hits and quota aggregation for rate quota. This field is not populated for
        /// allocation quota checks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unusedArguments")]
        public virtual System.Collections.Generic.IList<string> UnusedArguments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the AllocateQuota method.</summary>
    public class AllocateQuotaRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Operation that describes the quota allocation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocateOperation")]
        public virtual QuotaOperation AllocateOperation { get; set; }

        /// <summary>
        /// Specifies which version of service configuration should be used to process the request. If unspecified or no
        /// matching version can be found, the latest one will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the AllocateQuota method.</summary>
    public class AllocateQuotaResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the decision of the allocate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocateErrors")]
        public virtual System.Collections.Generic.IList<QuotaError> AllocateErrors { get; set; }

        /// <summary>WARNING: DO NOT use this field until this warning message is removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allocateInfo")]
        public virtual AllocateInfo AllocateInfo { get; set; }

        /// <summary>
        /// The same operation_id value used in the AllocateQuotaRequest. Used for logging and diagnostics purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>
        /// Quota metrics to indicate the result of allocation. Depending on the request, one or more of the following
        /// metrics will be included: 1. Per quota group or per quota metric incremental usage will be specified using
        /// the following delta metric : "serviceruntime.googleapis.com/api/consumer/quota_used_count" 2. The quota
        /// limit reached condition will be specified using the following boolean metric :
        /// "serviceruntime.googleapis.com/quota/exceeded"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaMetrics")]
        public virtual System.Collections.Generic.IList<MetricValueSet> QuotaMetrics { get; set; }

        /// <summary>ID of the actual config used to process the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The allowed types for [VALUE] in a `[KEY]:[VALUE]` attribute.</summary>
    public class AttributeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Boolean value represented by `true` or `false`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>A 64-bit signed integer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>A string up to 256 bytes long.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual TruncatableString StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of attributes, each in the format `[KEY]:[VALUE]`.</summary>
    public class Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of attributes. Each attribute's key can be up to 128 bytes long. The value can be a string up to 256
        /// bytes, a signed 64-bit integer, or the Boolean values `true` and `false`. For example: "/instance_id":
        /// "my-instance" "/http/user_agent": "" "/http/request_bytes": 300 "abc.com/myattribute": true
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeMap")]
        public virtual System.Collections.Generic.IDictionary<string, AttributeValue> AttributeMap { get; set; }

        /// <summary>
        /// The number of attributes that were discarded. Attributes can be discarded because their keys are too long or
        /// because there are too many attributes. If this value is 0 then all attributes are valid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedAttributesCount")]
        public virtual System.Nullable<int> DroppedAttributesCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common audit log format for Google Cloud Platform API operations. </summary>
    public class AuditLog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Authentication information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationInfo")]
        public virtual AuthenticationInfo AuthenticationInfo { get; set; }

        /// <summary>
        /// Authorization information. If there are multiple resources or permissions involved, then there is one
        /// AuthorizationInfo element for each {resource, permission} tuple.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationInfo")]
        public virtual System.Collections.Generic.IList<AuthorizationInfo> AuthorizationInfo { get; set; }

        /// <summary>
        /// Other service-specific data about the request, response, and other information associated with the current
        /// audited event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The name of the service method or operation. For API calls, this should be the name of the API method. For
        /// example, "google.cloud.bigquery.v2.TableService.InsertTable" "google.logging.v2.ConfigServiceV2.CreateSink"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        /// <summary>The number of items returned from a List or Query API method, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numResponseItems")]
        public virtual System.Nullable<long> NumResponseItems { get; set; }

        /// <summary>
        /// The operation request. This may not include all request parameters, such as those that are too large,
        /// privacy-sensitive, or duplicated elsewhere in the log record. It should never include user-generated data,
        /// such as file contents. When the JSON object represented here has a proto equivalent, the proto name will be
        /// indicated in the `@type` property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual System.Collections.Generic.IDictionary<string, object> Request { get; set; }

        /// <summary>Metadata about the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMetadata")]
        public virtual RequestMetadata RequestMetadata { get; set; }

        /// <summary>The resource location information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLocation")]
        public virtual ResourceLocation ResourceLocation { get; set; }

        /// <summary>
        /// The resource or collection that is the target of the operation. The name is a scheme-less URI, not including
        /// the API service name. For example: "projects/PROJECT_ID/zones/us-central1-a/instances"
        /// "projects/PROJECT_ID/datasets/DATASET_ID"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// The resource's original state before mutation. Present only for operations which have successfully modified
        /// the targeted resource(s). In general, this field should contain all changed fields, except those that are
        /// already been included in `request`, `response`, `metadata` or `service_data` fields. When the JSON object
        /// represented here has a proto equivalent, the proto name will be indicated in the `@type` property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceOriginalState")]
        public virtual System.Collections.Generic.IDictionary<string, object> ResourceOriginalState { get; set; }

        /// <summary>
        /// The operation response. This may not include all response elements, such as those that are too large,
        /// privacy-sensitive, or duplicated elsewhere in the log record. It should never include user-generated data,
        /// such as file contents. When the JSON object represented here has a proto equivalent, the proto name will be
        /// indicated in the `@type` property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>
        /// Deprecated. Use the `metadata` field instead. Other service-specific data about the request, response, and
        /// other activities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceData")]
        public virtual System.Collections.Generic.IDictionary<string, object> ServiceData { get; set; }

        /// <summary>
        /// The name of the API service performing the operation. For example, `"compute.googleapis.com"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The status of the overall operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message defines request authentication attributes. Terminology is based on the JSON Web Token (JWT)
    /// standard, but the terms also correlate to concepts in other standards.
    /// </summary>
    public class Auth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of access level resource names that allow resources to be accessed by authenticated requester. It is
        /// part of Secure GCP processing for the incoming request. An access level string has the format:
        /// "//{api_service_name}/accessPolicies/{policy_id}/accessLevels/{short_name}" Example:
        /// "//accesscontextmanager.googleapis.com/accessPolicies/MY_POLICY_ID/accessLevels/MY_LEVEL"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>
        /// The intended audience(s) for this authentication information. Reflects the audience (`aud`) claim within a
        /// JWT. The audience value(s) depends on the `issuer`, but typically include one or more of the following
        /// pieces of information: * The services intended to receive the credential. For example,
        /// ["https://pubsub.googleapis.com/", "https://storage.googleapis.com/"]. * A set of service-based scopes. For
        /// example, ["https://www.googleapis.com/auth/cloud-platform"]. * The client id of an app, such as the Firebase
        /// project id for JWTs from Firebase Auth. Consult the documentation for the credential issuer to determine the
        /// information provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audiences")]
        public virtual System.Collections.Generic.IList<string> Audiences { get; set; }

        /// <summary>
        /// Structured claims presented with the credential. JWTs include `{key: value}` pairs for standard and private
        /// claims. The following is a subset of the standard required and optional claims that would typically be
        /// presented for a Google-based JWT: {'iss': 'accounts.google.com', 'sub': '113289723416554971153', 'aud':
        /// ['123456789012', 'pubsub.googleapis.com'], 'azp': '123456789012.apps.googleusercontent.com', 'email':
        /// 'jsmith@example.com', 'iat': 1353601026, 'exp': 1353604926} SAML assertions are similarly specified, but
        /// with an identity provider dependent structure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("claims")]
        public virtual System.Collections.Generic.IDictionary<string, object> Claims { get; set; }

        /// <summary>
        /// The authorized presenter of the credential. Reflects the optional Authorized Presenter (`azp`) claim within
        /// a JWT or the OAuth client id. For example, a Google Cloud Platform client id looks as follows:
        /// "123456789012.apps.googleusercontent.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presenter")]
        public virtual string Presenter { get; set; }

        /// <summary>
        /// The authenticated principal. Reflects the issuer (`iss`) and subject (`sub`) claims within a JWT. The issuer
        /// and subject should be `/` delimited, with `/` percent-encoded within the subject fragment. For Google
        /// accounts, the principal format is: "https://accounts.google.com/{id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Authentication information for the operation.</summary>
    public class AuthenticationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The authority selector specified by the requestor, if any. It is not guaranteed that the principal was
        /// allowed to use this authority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authoritySelector")]
        public virtual string AuthoritySelector { get; set; }

        /// <summary>
        /// The email address of the authenticated user (or service account on behalf of third party principal) making
        /// the request. For third party identity callers, the `principal_subject` field is populated instead of this
        /// field. For privacy reasons, the principal email address is sometimes redacted. For more information, see
        /// [Caller identities in audit logs](https://cloud.google.com/logging/docs/audit#user-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// String representation of identity of requesting party. Populated for both first and third party identities.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>
        /// Identity delegation history of an authenticated service account that makes the request. It contains
        /// information on the real authorities that try to access GCP resources by delegating on a service account.
        /// When multiple authorities present, they are guaranteed to be sorted based on the original ordering of the
        /// identity delegation events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountDelegationInfo")]
        public virtual System.Collections.Generic.IList<ServiceAccountDelegationInfo> ServiceAccountDelegationInfo { get; set; }

        /// <summary>
        /// The name of the service account key used to create or exchange credentials for authenticating the service
        /// account making the request. This is a scheme-less URI full resource name. For example:
        /// "//iam.googleapis.com/projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyName")]
        public virtual string ServiceAccountKeyName { get; set; }

        /// <summary>
        /// The third party identification (if any) of the authenticated user making the request. When the JSON object
        /// represented here has a proto equivalent, the proto name will be indicated in the `@type` property.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyPrincipal")]
        public virtual System.Collections.Generic.IDictionary<string, object> ThirdPartyPrincipal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Authorization information for the operation.</summary>
    public class AuthorizationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether or not authorization for `resource` and `permission` was granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("granted")]
        public virtual System.Nullable<bool> Granted { get; set; }

        /// <summary>The required IAM permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>
        /// The resource being accessed, as a REST-style or cloud resource string. For example:
        /// bigquery.googleapis.com/projects/PROJECTID/datasets/DATASETID or projects/PROJECTID/datasets/DATASETID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>
        /// Resource attributes used in IAM condition evaluation. This field contains resource attributes like resource
        /// type and resource name. To get the whole view of the attributes used in IAM condition evaluation, the user
        /// must also look into `AuditLog.request_metadata.request_attributes`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceAttributes")]
        public virtual Resource ResourceAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the errors to be returned in google.api.servicecontrol.v1.CheckResponse.check_errors.</summary>
    public class CheckError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Free-form text providing details on the error cause of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual string Detail { get; set; }

        /// <summary>
        /// Contains public information about the check error. If available, `status.code` will be non zero and client
        /// can propagate it out as public error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>
        /// Subject to whom this error applies. See the specific code enum for more details on this field. For example:
        /// - "project:" - "folder:" - "organization:"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains additional information about the check operation.</summary>
    public class CheckInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Consumer info of this check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerInfo")]
        public virtual ConsumerInfo ConsumerInfo { get; set; }

        /// <summary>
        /// A list of fields and label keys that are ignored by the server. The client doesn't need to send them for
        /// following requests to improve performance and allow better aggregation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unusedArguments")]
        public virtual System.Collections.Generic.IList<string> UnusedArguments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the Check method.</summary>
    public class CheckRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The operation to be checked.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual Operation Operation { get; set; }

        /// <summary>Requests the project settings to be returned as part of the check response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestProjectSettings")]
        public virtual System.Nullable<bool> RequestProjectSettings { get; set; }

        /// <summary>
        /// Specifies which version of service configuration should be used to process the request. If unspecified or no
        /// matching version can be found, the latest one will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>
        /// Indicates if service activation check should be skipped for this request. Default behavior is to perform the
        /// check and apply relevant quota. WARNING: Setting this flag to "true" will disable quota enforcement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipActivationCheck")]
        public virtual System.Nullable<bool> SkipActivationCheck { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the Check method.</summary>
    public class CheckResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicate the decision of the check. If no check errors are present, the service should process the
        /// operation. Otherwise the service should use the list of errors to determine the appropriate action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkErrors")]
        public virtual System.Collections.Generic.IList<CheckError> CheckErrors { get; set; }

        /// <summary>Feedback data returned from the server during processing a Check request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkInfo")]
        public virtual CheckInfo CheckInfo { get; set; }

        /// <summary>
        /// The same operation_id value used in the CheckRequest. Used for logging and diagnostics purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>Quota information for the check request associated with this response. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaInfo")]
        public virtual QuotaInfo QuotaInfo { get; set; }

        /// <summary>The actual config id used to process the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>The current service rollout id used to process the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceRolloutId")]
        public virtual string ServiceRolloutId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`ConsumerInfo` provides information about the consumer.</summary>
    public class ConsumerInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The consumer identity number, can be Google cloud project number, folder number or organization number e.g.
        /// 1234567890. A value of 0 indicates no consumer number is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerNumber")]
        public virtual System.Nullable<long> ConsumerNumber { get; set; }

        /// <summary>
        /// The Google cloud project number, e.g. 1234567890. A value of 0 indicates no project number is found. NOTE:
        /// This field is deprecated after Chemist support flexible consumer id. New code should not depend on this
        /// field anymore.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual System.Nullable<long> ProjectNumber { get; set; }

        /// <summary>
        /// The type of the consumer which should have been defined in [Google Resource
        /// Manager](https://cloud.google.com/resource-manager/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Distribution represents a frequency distribution of double-valued sample points. It contains the size of the
    /// population of sample points plus additional optional information: - the arithmetic mean of the samples - the
    /// minimum and maximum of the samples - the sum-squared-deviation of the samples, used to compute variance - a
    /// histogram of the values of the sample points
    /// </summary>
    public class Distribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of samples in each histogram bucket. `bucket_counts` are optional. If present, they must sum to
        /// the `count` value. The buckets are defined below in `bucket_option`. There are N buckets. `bucket_counts[0]`
        /// is the number of samples in the underflow bucket. `bucket_counts[1]` to `bucket_counts[N-1]` are the numbers
        /// of samples in each of the finite buckets. And `bucket_counts[N] is the number of samples in the overflow
        /// bucket. See the comments of `bucket_option` below for more details. Any suffix of trailing zeros may be
        /// omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketCounts")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> BucketCounts { get; set; }

        /// <summary>The total number of samples in the distribution. Must be &gt;= 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Example points. Must be in increasing order of `value` field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemplars")]
        public virtual System.Collections.Generic.IList<Exemplar> Exemplars { get; set; }

        /// <summary>Buckets with arbitrary user-provided width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("explicitBuckets")]
        public virtual ExplicitBuckets ExplicitBuckets { get; set; }

        /// <summary>Buckets with exponentially growing width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exponentialBuckets")]
        public virtual ExponentialBuckets ExponentialBuckets { get; set; }

        /// <summary>Buckets with constant width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linearBuckets")]
        public virtual LinearBuckets LinearBuckets { get; set; }

        /// <summary>The maximum of the population of values. Ignored if `count` is zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual System.Nullable<double> Maximum { get; set; }

        /// <summary>
        /// The arithmetic mean of the samples in the distribution. If `count` is zero then this field must be zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mean")]
        public virtual System.Nullable<double> Mean { get; set; }

        /// <summary>The minimum of the population of values. Ignored if `count` is zero.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual System.Nullable<double> Minimum { get; set; }

        /// <summary>
        /// The sum of squared deviations from the mean: Sum[i=1..count]((x_i - mean)^2) where each x_i is a sample
        /// values. If `count` is zero then this field must be zero, otherwise validation of the request fails.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sumOfSquaredDeviation")]
        public virtual System.Nullable<double> SumOfSquaredDeviation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exemplars are example points that may be used to annotate aggregated distribution values. They are metadata that
    /// gives information about a particular value added to a Distribution bucket, such as a trace ID that was active
    /// when a value was added. They may contain further information, such as a example values and timestamps, origin,
    /// etc.
    /// </summary>
    public class Exemplar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contextual information about the example value. Examples are: Trace:
        /// type.googleapis.com/google.monitoring.v3.SpanContext Literal string:
        /// type.googleapis.com/google.protobuf.StringValue Labels dropped during aggregation:
        /// type.googleapis.com/google.monitoring.v3.DroppedLabels There may be only a single attachment of any given
        /// message type in a single exemplar, and this is enforced by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Attachments { get; set; }

        /// <summary>The observation (sampling) time of the above value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>Value of the exemplar point. This value determines to which bucket the exemplar belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describing buckets with arbitrary user-provided width.</summary>
    public class ExplicitBuckets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// 'bound' is a list of strictly increasing boundaries between buckets. Note that a list of length N-1 defines
        /// N buckets because of fenceposting. See comments on `bucket_options` for details. The i'th finite bucket
        /// covers the interval [bound[i-1], bound[i]) where i ranges from 1 to bound_size() - 1. Note that there are no
        /// finite buckets at all if 'bound' only contains a single element; in that special case the single bound
        /// defines the boundary between the underflow and overflow buckets. bucket number lower bound upper bound i ==
        /// 0 (underflow) -inf bound[i] 0 &amp;lt; i &amp;lt; bound_size() bound[i-1] bound[i] i == bound_size()
        /// (overflow) bound[i-1] +inf
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bounds")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Bounds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describing buckets with exponentially growing width.</summary>
    public class ExponentialBuckets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The i'th exponential bucket covers the interval [scale * growth_factor^(i-1), scale * growth_factor^i) where
        /// i ranges from 1 to num_finite_buckets inclusive. Must be larger than 1.0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("growthFactor")]
        public virtual System.Nullable<double> GrowthFactor { get; set; }

        /// <summary>
        /// The number of finite buckets. With the underflow and overflow buckets, the total number of buckets is
        /// `num_finite_buckets` + 2. See comments on `bucket_options` for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>
        /// The i'th exponential bucket covers the interval [scale * growth_factor^(i-1), scale * growth_factor^i) where
        /// i ranges from 1 to num_finite_buckets inclusive. Must be &amp;gt; 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<double> Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>First party identity principal.</summary>
    public class FirstPartyPrincipal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of a Google account. .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>Metadata about the service that uses the service account. .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> ServiceMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A common proto for logging HTTP requests. Only contains semantics defined by the HTTP specification.
    /// Product-specific logging information MUST be defined in a separate message.
    /// </summary>
    public class HttpRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of HTTP response bytes inserted into cache. Set only when a cache fill was attempted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheFillBytes")]
        public virtual System.Nullable<long> CacheFillBytes { get; set; }

        /// <summary>Whether or not an entity was served from cache (with or without validation).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheHit")]
        public virtual System.Nullable<bool> CacheHit { get; set; }

        /// <summary>Whether or not a cache lookup was attempted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheLookup")]
        public virtual System.Nullable<bool> CacheLookup { get; set; }

        /// <summary>
        /// Whether or not the response was validated with the origin server before being served from cache. This field
        /// is only meaningful if `cache_hit` is True.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheValidatedWithOriginServer")]
        public virtual System.Nullable<bool> CacheValidatedWithOriginServer { get; set; }

        /// <summary>
        /// The request processing latency on the server, from the time the request was received until the response was
        /// sent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency")]
        public virtual object Latency { get; set; }

        /// <summary>Protocol used for the request. Examples: "HTTP/1.1", "HTTP/2", "websocket"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The referer URL of the request, as defined in [HTTP/1.1 Header Field
        /// Definitions](http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referer")]
        public virtual string Referer { get; set; }

        /// <summary>
        /// The IP address (IPv4 or IPv6) of the client that issued the HTTP request. Examples: `"192.168.1.1"`,
        /// `"FE80::0202:B3FF:FE1E:8329"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteIp")]
        public virtual string RemoteIp { get; set; }

        /// <summary>The request method. Examples: `"GET"`, `"HEAD"`, `"PUT"`, `"POST"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestMethod")]
        public virtual string RequestMethod { get; set; }

        /// <summary>
        /// The size of the HTTP request message in bytes, including the request headers and the request body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestSize")]
        public virtual System.Nullable<long> RequestSize { get; set; }

        /// <summary>
        /// The scheme (http, https), the host name, the path, and the query portion of the URL that was requested.
        /// Example: `"http://example.com/some/info?color=red"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestUrl")]
        public virtual string RequestUrl { get; set; }

        /// <summary>
        /// The size of the HTTP response message sent back to the client, in bytes, including the response headers and
        /// the response body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseSize")]
        public virtual System.Nullable<long> ResponseSize { get; set; }

        /// <summary>The IP address (IPv4 or IPv6) of the origin server that the request was sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serverIp")]
        public virtual string ServerIp { get; set; }

        /// <summary>The response code indicating the status of the response. Examples: 200, 404.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<int> Status { get; set; }

        /// <summary>
        /// The user agent sent by the client. Example: `"Mozilla/4.0 (compatible; MSIE 6.0; Windows 98; Q312461; .NET
        /// CLR 1.0.3705)"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describing buckets with constant width.</summary>
    public class LinearBuckets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of finite buckets. With the underflow and overflow buckets, the total number of buckets is
        /// `num_finite_buckets` + 2. See comments on `bucket_options` for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numFiniteBuckets")]
        public virtual System.Nullable<int> NumFiniteBuckets { get; set; }

        /// <summary>
        /// The i'th linear bucket covers the interval [offset + (i-1) * width, offset + i * width) where i ranges from
        /// 1 to num_finite_buckets, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<double> Offset { get; set; }

        /// <summary>
        /// The i'th linear bucket covers the interval [offset + (i-1) * width, offset + i * width) where i ranges from
        /// 1 to num_finite_buckets, inclusive. Must be strictly positive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<double> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual log entry.</summary>
    public class LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Information about the HTTP request associated with this log entry, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual HttpRequest HttpRequest { get; set; }

        /// <summary>
        /// A unique ID for the log entry used for deduplication. If omitted, the implementation will generate one based
        /// on operation_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertId")]
        public virtual string InsertId { get; set; }

        /// <summary>
        /// A set of user-defined (key, value) data that provides additional information about the log entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Required. The log to which this log entry belongs. Examples: `"syslog"`, `"book_log"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Information about an operation associated with the log entry, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual LogEntryOperation Operation { get; set; }

        /// <summary>
        /// The log entry payload, represented as a protocol buffer that is expressed as a JSON object. The only
        /// accepted type currently is AuditLog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protoPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> ProtoPayload { get; set; }

        /// <summary>The severity of the log entry. The default value is `LogSeverity.DEFAULT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Optional. Source code location information associated with the log entry, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceLocation")]
        public virtual LogEntrySourceLocation SourceLocation { get; set; }

        /// <summary>The log entry payload, represented as a structure that is expressed as a JSON object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructPayload { get; set; }

        /// <summary>The log entry payload, represented as a Unicode string (UTF-8).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textPayload")]
        public virtual string TextPayload { get; set; }

        /// <summary>
        /// The time the event described by the log entry occurred. If omitted, defaults to operation start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>
        /// Optional. Resource name of the trace associated with the log entry, if any. If this field contains a
        /// relative resource name, you can assume the name is relative to `//tracing.googleapis.com`. Example:
        /// `projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trace")]
        public virtual string Trace { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Additional information about a potentially long-running operation with which a log entry is associated.
    /// </summary>
    public class LogEntryOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Set this to True if this is the first log entry in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("first")]
        public virtual System.Nullable<bool> First { get; set; }

        /// <summary>
        /// Optional. An arbitrary operation identifier. Log entries with the same identifier are assumed to be part of
        /// the same operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. Set this to True if this is the last log entry in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("last")]
        public virtual System.Nullable<bool> Last { get; set; }

        /// <summary>
        /// Optional. An arbitrary producer identifier. The combination of `id` and `producer` must be globally unique.
        /// Examples for `producer`: `"MyDivision.MyBigCompany.com"`, `"github.com/MyProject/MyApplication"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producer")]
        public virtual string Producer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information about the source code location that produced the log entry.</summary>
    public class LogEntrySourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Source file name. Depending on the runtime environment, this might be a simple name or a
        /// fully-qualified name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

        /// <summary>
        /// Optional. Human-readable name of the function or method being invoked, with optional context such as the
        /// class or package name. This information may be used in contexts such as the logs viewer, where a file and
        /// line number are less meaningful. The format can vary by language. For example: `qual.if.ied.Class.method`
        /// (Java), `dir/package.func` (Go), `function` (Python).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("function")]
        public virtual string Function { get; set; }

        /// <summary>Optional. Line within the source file. 1-based; 0 indicates no line number available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<long> Line { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single metric value.</summary>
    public class MetricValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>A distribution value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distributionValue")]
        public virtual Distribution DistributionValue { get; set; }

        /// <summary>A double precision floating point value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>
        /// The end of the time period over which this metric value's measurement applies. If not specified,
        /// google.api.servicecontrol.v1.Operation.end_time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>A signed 64-bit integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("int64Value")]
        public virtual System.Nullable<long> Int64Value { get; set; }

        /// <summary>
        /// The labels describing the metric value. See comments on google.api.servicecontrol.v1.Operation.labels for
        /// the overriding relationship. Note that this map must not contain monitored resource labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>A money value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moneyValue")]
        public virtual Money MoneyValue { get; set; }

        /// <summary>
        /// The start of the time period over which this metric value's measurement applies. The time period has
        /// different semantics for different metric types (cumulative, delta, and gauge). See the metric definition
        /// documentation in the service configuration for details. If not specified,
        /// google.api.servicecontrol.v1.Operation.start_time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>A text string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a set of metric values in the same metric. Each metric value in the set should have a unique
    /// combination of start time, end time, and label values.
    /// </summary>
    public class MetricValueSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metric name defined in the service configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricName")]
        public virtual string MetricName { get; set; }

        /// <summary>The values in this metric.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValues")]
        public virtual System.Collections.Generic.IList<MetricValue> MetricValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents information regarding an operation.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identity of the consumer who is using the service. This field should be filled in for the operations
        /// initiated by a consumer, but not for service-initiated operations that are not related to a specific
        /// consumer. - This can be in one of the following formats: - project:PROJECT_ID, -
        /// project`_`number:PROJECT_NUMBER, - projects/PROJECT_ID or PROJECT_NUMBER, - folders/FOLDER_NUMBER, -
        /// organizations/ORGANIZATION_NUMBER, - api`_`key:API_KEY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerId")]
        public virtual string ConsumerId { get; set; }

        /// <summary>
        /// End time of the operation. Required when the operation is used in ServiceController.Report, but optional
        /// when the operation is used in ServiceController.Check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Unimplemented.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>DO NOT USE. This is an experimental field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("importance")]
        public virtual string Importance { get; set; }

        /// <summary>
        /// Labels describing the operation. Only the following labels are allowed: - Labels describing monitored
        /// resources as defined in the service configuration. - Default labels of metric values. When specified, labels
        /// defined in the metric value override these default. - The following labels defined by Google Cloud Platform:
        /// - `cloud.googleapis.com/location` describing the location where the operation happened, -
        /// `servicecontrol.googleapis.com/user_agent` describing the user agent of the API request, -
        /// `servicecontrol.googleapis.com/service_agent` describing the service used to handle the API request (e.g.
        /// ESP), - `servicecontrol.googleapis.com/platform` describing the platform where the API is served, such as
        /// App Engine, Compute Engine, or Kubernetes Engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Represents information to be logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logEntries")]
        public virtual System.Collections.Generic.IList<LogEntry> LogEntries { get; set; }

        /// <summary>
        /// Represents information about this operation. Each MetricValueSet corresponds to a metric defined in the
        /// service configuration. The data type used in the MetricValueSet must agree with the data type specified in
        /// the metric definition. Within a single operation, it is not allowed to have more than one MetricValue
        /// instances that have the same metric names and identical label value combinations. If a request has such
        /// duplicated MetricValue instances, the entire request is rejected with an invalid argument error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValueSets")]
        public virtual System.Collections.Generic.IList<MetricValueSet> MetricValueSets { get; set; }

        /// <summary>
        /// Identity of the operation. This must be unique within the scope of the service that generated the operation.
        /// If the service calls Check() and Report() on the same operation, the two calls should carry the same id.
        /// UUID version 4 is recommended, though not required. In scenarios where an operation is computed from
        /// existing information and an idempotent id is desirable for deduplication purpose, UUID version 5 is
        /// recommended. See RFC 4122 for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>Fully qualified name of the operation. Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationName")]
        public virtual string OperationName { get; set; }

        /// <summary>
        /// Represents the properties needed for quota check. Applicable only if this operation is for a quota check
        /// request. If this is not specified, no quota check will be performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaProperties")]
        public virtual QuotaProperties QuotaProperties { get; set; }

        /// <summary>
        /// The resources that are involved in the operation. The maximum supported number of entries in this field is
        /// 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ResourceInfo> Resources { get; set; }

        /// <summary>Required. Start time of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>
        /// Unimplemented. A list of Cloud Trace spans. The span names shall contain the id of the destination project
        /// which can be either the produce or the consumer project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceSpans")]
        public virtual System.Collections.Generic.IList<TraceSpan> TraceSpans { get; set; }

        /// <summary>
        /// Private Preview. This feature is only available for approved services. User defined labels for the resource
        /// that this operation is associated with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> UserLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message defines attributes for a node that handles a network request. The node can be either a service or
    /// an application that sends, forwards, or receives the request. Service peers should fill in `principal` and
    /// `labels` as appropriate.
    /// </summary>
    public class Peer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The IP address of the peer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>The labels associated with the peer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The network port of the peer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<long> Port { get; set; }

        /// <summary>
        /// The identity of this peer. Similar to `Request.auth.principal`, but relative to the peer instead of the
        /// request. For example, the idenity associated with a load balancer that forwared the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>
        /// The CLDR country/region code associated with the above IP address. If the IP address is private, the
        /// `region_code` should reflect the physical location where this peer is running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents error information for QuotaOperation.</summary>
    public class QuotaError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Free-form text that provides details on the cause of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Contains additional information about the quota error. If available, `status.code` will be non zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>
        /// Subject to whom this error applies. See the specific enum for more details on this field. For example,
        /// "clientip:" or "project:".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the quota information for a quota check response.</summary>
    public class QuotaInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Quota Metrics that have exceeded quota limits. For QuotaGroup-based quota, this is QuotaGroup.name For
        /// QuotaLimit-based quota, this is QuotaLimit.name See: google.api.Quota Deprecated: Use quota_metrics to get
        /// per quota group limit exceeded status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitExceeded")]
        public virtual System.Collections.Generic.IList<string> LimitExceeded { get; set; }

        /// <summary>
        /// Map of quota group name to the actual number of tokens consumed. If the quota check was not successful, then
        /// this will not be populated due to no quota consumption. We are not merging this field with 'quota_metrics'
        /// field because of the complexity of scaling in Chemist client code base. For simplicity, we will keep this
        /// field for Castor (that scales quota usage) and 'quota_metrics' for SuperQuota (that doesn't scale quota
        /// usage).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaConsumed")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> QuotaConsumed { get; set; }

        /// <summary>
        /// Quota metrics to indicate the usage. Depending on the check request, one or more of the following metrics
        /// will be included: 1. For rate quota, per quota group or per quota metric incremental usage will be specified
        /// using the following delta metric: "serviceruntime.googleapis.com/api/consumer/quota_used_count" 2. For
        /// allocation quota, per quota metric total usage will be specified using the following gauge metric:
        /// "serviceruntime.googleapis.com/allocation/consumer/quota_used_count" 3. For both rate quota and allocation
        /// quota, the quota limit reached condition will be specified using the following boolean metric:
        /// "serviceruntime.googleapis.com/quota/exceeded"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaMetrics")]
        public virtual System.Collections.Generic.IList<MetricValueSet> QuotaMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents information regarding a quota operation.</summary>
    public class QuotaOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identity of the consumer for whom this quota operation is being performed. This can be in one of the
        /// following formats: project:, project_number:, api_key:.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerId")]
        public virtual string ConsumerId { get; set; }

        /// <summary>Labels describing the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Fully qualified name of the API method for which this quota operation is requested. This name is used for
        /// matching quota rules or metric rules and billing status rules defined in service configuration. This field
        /// should not be set if any of the following is true: (1) the quota operation is performed on non-API
        /// resources. (2) quota_metrics is set because the caller is doing quota override. Example of an RPC method
        /// name: google.example.library.v1.LibraryService.CreateShelf
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        /// <summary>
        /// Identity of the operation. This is expected to be unique within the scope of the service that generated the
        /// operation, and guarantees idempotency in case of retries. In order to ensure best performance and latency in
        /// the Quota backends, operation_ids are optimally associated with time, so that related operations can be
        /// accessed fast in storage. For this reason, the recommended token for services that intend to operate at a
        /// high QPS is Unix time in nanos + UUID
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>
        /// Represents information about this operation. Each MetricValueSet corresponds to a metric defined in the
        /// service configuration. The data type used in the MetricValueSet must agree with the data type specified in
        /// the metric definition. Within a single operation, it is not allowed to have more than one MetricValue
        /// instances that have the same metric names and identical label value combinations. If a request has such
        /// duplicated MetricValue instances, the entire request is rejected with an invalid argument error. This field
        /// is mutually exclusive with method_name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaMetrics")]
        public virtual System.Collections.Generic.IList<MetricValueSet> QuotaMetrics { get; set; }

        /// <summary>Quota mode for this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaMode")]
        public virtual string QuotaMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the properties needed for quota operations.</summary>
    public class QuotaProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Quota mode for this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaMode")]
        public virtual string QuotaMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the processing error of one Operation in the request.</summary>
    public class ReportError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Operation.operation_id value from the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
        public virtual string OperationId { get; set; }

        /// <summary>Details of the error when processing the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the Report method.</summary>
    public class ReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Operations to be reported. Typically the service should report one operation per request. Putting multiple
        /// operations into a single request is allowed, but should be used only when multiple operations are natually
        /// available at the time of the report. There is no limit on the number of operations in the same
        /// ReportRequest, however the ReportRequest size should be no larger than 1MB. See ReportResponse.report_errors
        /// for partial failure behavior.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>
        /// Specifies which version of service config should be used to process the request. If unspecified or no
        /// matching version can be found, the latest one will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the Report method.</summary>
    public class ReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Partial failures, one for each `Operation` in the request that failed processing. There are three possible
        /// combinations of the RPC status: 1. The combination of a successful RPC status and an empty `report_errors`
        /// list indicates a complete success where all `Operations` in the request are processed successfully. 2. The
        /// combination of a successful RPC status and a non-empty `report_errors` list indicates a partial success
        /// where some `Operations` in the request succeeded. Each `Operation` that failed processing has a
        /// corresponding item in this list. 3. A failed RPC status indicates a general non-deterministic failure. When
        /// this happens, it's impossible to know which of the 'Operations' in the request succeeded or failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportErrors")]
        public virtual System.Collections.Generic.IList<ReportError> ReportErrors { get; set; }

        /// <summary>The actual config id used to process the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>The current service rollout id used to process the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceRolloutId")]
        public virtual string ServiceRolloutId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message defines attributes for an HTTP request. If the actual request is not an HTTP request, the runtime
    /// system should try to map the actual request to an equivalent HTTP request.
    /// </summary>
    public class Request : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The request authentication. May be absent for unauthenticated requests. Derived from the HTTP request
        /// `Authorization` header or equivalent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auth")]
        public virtual Auth Auth { get; set; }

        /// <summary>
        /// The HTTP request headers. If multiple headers share the same key, they must be merged according to the HTTP
        /// spec. All header keys must be lowercased, because HTTP header keys are case-insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>The HTTP request `Host` header value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// The unique ID for a request, which can be propagated to downstream systems. The ID should have low
        /// probability of collision within a single day for a specific service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The HTTP request method, such as `GET`, `POST`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>The HTTP URL path, excluding the query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// The network protocol used with the request, such as "http/1.1", "spdy/3", "h2", "h2c", "webrtc", "tcp",
        /// "udp", "quic". See
        /// https://www.iana.org/assignments/tls-extensiontype-values/tls-extensiontype-values.xhtml#alpn-protocol-ids
        /// for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The HTTP URL query in the format of `name1=value1&amp;amp;name2=value2`, as it appears in the first line of
        /// the HTTP request. No decoding is performed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// A special parameter for request reason. It is used by security systems to associate auditing information
        /// with a request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The HTTP URL scheme, such as `http` and `https`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheme")]
        public virtual string Scheme { get; set; }

        /// <summary>The HTTP request size in bytes. If unknown, it must be -1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        /// <summary>The timestamp when the `destination` service receives the last byte of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual object Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the request.</summary>
    public class RequestMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The IP address of the caller. For caller from internet, this will be public IPv4 or IPv6 address. For caller
        /// from a Compute Engine VM with external IP address, this will be the VM's external IP address. For caller
        /// from a Compute Engine VM without external IP address, if the VM is in the same organization (or project) as
        /// the accessed resource, `caller_ip` will be the VM's internal IPv4 address, otherwise the `caller_ip` will be
        /// redacted to "gce-internal-ip". See https://cloud.google.com/compute/docs/vpc/ for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIp")]
        public virtual string CallerIp { get; set; }

        /// <summary>
        /// The network of the caller. Set only if the network host project is part of the same GCP organization (or
        /// project) as the accessed resource. See https://cloud.google.com/compute/docs/vpc/ for more information. This
        /// is a scheme-less URI full resource name. For example:
        /// "//compute.googleapis.com/projects/PROJECT_ID/global/networks/NETWORK_ID"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerNetwork")]
        public virtual string CallerNetwork { get; set; }

        /// <summary>
        /// The user agent of the caller. This information is not authenticated and should be treated accordingly. For
        /// example: + `google-api-python-client/1.4.0`: The request was made by the Google API client for Python. +
        /// `Cloud SDK Command Line Tool apitools-client/1.0 gcloud/0.9.62`: The request was made by the Google Cloud
        /// SDK CLI (gcloud). + `AppEngine-Google; (+http://code.google.com/appengine; appid: s~my-project`: The request
        /// was made from the `my-project` App Engine app. NOLINT
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerSuppliedUserAgent")]
        public virtual string CallerSuppliedUserAgent { get; set; }

        /// <summary>
        /// The destination of a network activity, such as accepting a TCP connection. In a multi hop network activity,
        /// the destination represents the receiver of the last hop. Only two fields are used in this message, Peer.port
        /// and Peer.ip. These fields are optionally populated by those services utilizing the IAM condition feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationAttributes")]
        public virtual Peer DestinationAttributes { get; set; }

        /// <summary>
        /// Request attributes used in IAM condition evaluation. This field contains request attributes like request
        /// time and access levels associated with the request. To get the whole view of the attributes used in IAM
        /// condition evaluation, the user must also look into `AuditLog.authentication_info.resource_attributes`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAttributes")]
        public virtual Request RequestAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message defines core attributes for a resource. A resource is an addressable (named) entity provided by the
    /// destination service. For example, a file stored on a network storage service.
    /// </summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Annotations is an unstructured key-value map stored with a resource that may be set by external tools to
        /// store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying
        /// objects. More info: https://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Output only. The timestamp when the resource was created. This may be either the time creation was initiated
        /// or when it was completed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The timestamp when the resource was deleted. If the resource is not deleted, this must be
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteTime")]
        public virtual object DeleteTime { get; set; }

        /// <summary>Mutable. The display name set by clients. Must be &lt;= 63 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. An opaque value that uniquely identifies a version or generation of a resource. It can be used
        /// to confirm that the client and server agree on the ordering of a resource being written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The labels or tags on the resource, such as AWS resource tags and Kubernetes resource labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Immutable. The location of the resource. The location encoding is specific to the service provider, and new
        /// encoding may be introduced as the service evolves. For Google Cloud products, the encoding is what is used
        /// by Google Cloud APIs, such as `us-east1`, `aws-us-east-1`, and `azure-eastus2`. The semantics of `location`
        /// is identical to the `cloud.googleapis.com/location` label used by some Google Cloud APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// The stable identifier (name) of a resource on the `service`. A resource can be logically identified as
        /// "//{resource.service}/{resource.name}". The differences between a resource name and a URI are: * Resource
        /// name is a logical identifier, independent of network protocol and API version. For example,
        /// `//pubsub.googleapis.com/projects/123/topics/news-feed`. * URI often includes protocol and version
        /// information, so it can be used directly by applications. For example,
        /// `https://pubsub.googleapis.com/v1/projects/123/topics/news-feed`. See
        /// https://cloud.google.com/apis/design/resource_names for details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the service that this resource belongs to, such as `pubsub.googleapis.com`. The service may be
        /// different from the DNS hostname that actually serves the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>
        /// The type of the resource. The syntax is platform-specific because different platforms define their resources
        /// differently. For Google APIs, the type format must be "{service}/{kind}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The unique identifier of the resource. UID is unique in the time and space for this resource within the
        /// scope of the service. It is typically generated by the server on successful creation of a resource and must
        /// not be changed. UID is used to uniquely identify resources with resource name reuses. This should be a
        /// UUID4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }
    }

    /// <summary>Describes a resource associated with this operation.</summary>
    public class ResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The identifier of the parent of this resource instance. Must be in one of the following formats: -
        /// `projects/` - `folders/` - `organizations/`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceContainer")]
        public virtual string ResourceContainer { get; set; }

        /// <summary>
        /// The location of the resource. If not empty, the resource will be checked against location policy. The value
        /// must be a valid zone, region or multiregion. For example: "europe-west4" or "northamerica-northeast1-a"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceLocation")]
        public virtual string ResourceLocation { get; set; }

        /// <summary>Name of the resource. This is used for auditing purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location information about a resource.</summary>
    public class ResourceLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The locations of a resource after the execution of the operation. Requests to create or delete a location
        /// based resource must populate the 'current_locations' field and not the 'original_locations' field. For
        /// example: "europe-west1-a" "us-east1" "nam3"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentLocations")]
        public virtual System.Collections.Generic.IList<string> CurrentLocations { get; set; }

        /// <summary>
        /// The locations of a resource prior to the execution of the operation. Requests that mutate the resource's
        /// location must populate both the 'original_locations' as well as the 'current_locations' fields. For example:
        /// "europe-west1-a" "us-east1" "nam3"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalLocations")]
        public virtual System.Collections.Generic.IList<string> OriginalLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identity delegation history of an authenticated service account.</summary>
    public class ServiceAccountDelegationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>First party (Google) identity as the real authority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstPartyPrincipal")]
        public virtual FirstPartyPrincipal FirstPartyPrincipal { get; set; }

        /// <summary>
        /// A string representing the principal_subject associated with the identity. For most identities, the format
        /// will be `principal://iam.googleapis.com/{identity pool name}/subject/{subject)` except for some GKE
        /// identities (GKE_WORKLOAD, FREEFORM, GKE_HUB_WORKLOAD) that are still in the legacy format
        /// `serviceAccount:{identity pool name}[{subject}]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>Third party identity as the real authority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyPrincipal")]
        public virtual ThirdPartyPrincipal ThirdPartyPrincipal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The context of a span. This is attached to an Exemplar in Distribution values during aggregation. It contains
    /// the name of a span with format: projects/[PROJECT_ID_OR_NUMBER]/traces/[TRACE_ID]/spans/[SPAN_ID]
    /// </summary>
    public class SpanContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the span. The format is:
        /// projects/[PROJECT_ID_OR_NUMBER]/traces/[TRACE_ID]/spans/[SPAN_ID] `[TRACE_ID]` is a unique identifier for a
        /// trace within a project; it is a 32-character hexadecimal encoding of a 16-byte array. `[SPAN_ID]` is a
        /// unique identifier for a span within a trace; it is a 16-character hexadecimal encoding of an 8-byte array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanName")]
        public virtual string SpanName { get; set; }

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

    /// <summary>Third party identity principal.</summary>
    public class ThirdPartyPrincipal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Metadata about third party identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thirdPartyClaims")]
        public virtual System.Collections.Generic.IDictionary<string, object> ThirdPartyClaims { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A span represents a single operation within a trace. Spans can be nested to form a trace tree. Often, a trace
    /// contains a root span that describes the end-to-end latency, and one or more subspans for its sub-operations. A
    /// trace can also contain multiple root spans, or none at all. Spans do not need to be contiguous—there may be gaps
    /// or overlaps between spans in a trace.
    /// </summary>
    public class TraceSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of attributes on the span. You can have up to 32 attributes per span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// An optional number of child spans that were generated while this span was active. If set, allows
        /// implementation to detect missing child spans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childSpanCount")]
        public virtual System.Nullable<int> ChildSpanCount { get; set; }

        /// <summary>
        /// A description of the span's operation (up to 128 bytes). Stackdriver Trace displays the description in the
        /// Google Cloud Platform Console. For example, the display name can be a qualified method name or a file name
        /// and a line number where the operation is called. A best practice is to use the same display name within an
        /// application and at the same call point. This makes it easier to correlate spans in different traces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual TruncatableString DisplayName { get; set; }

        /// <summary>
        /// The end time of the span. On the client side, this is the time kept by the local machine where the span
        /// execution ends. On the server side, this is the time when the server application handler stops running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// The resource name of the span in the following format: projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/SPAN_ID
        /// is a unique identifier for a trace within a project; it is a 32-character hexadecimal encoding of a 16-byte
        /// array. [SPAN_ID] is a unique identifier for a span within a trace; it is a 16-character hexadecimal encoding
        /// of an 8-byte array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The [SPAN_ID] of this span's parent span. If this is a root span, then this field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentSpanId")]
        public virtual string ParentSpanId { get; set; }

        /// <summary>
        /// (Optional) Set this parameter to indicate whether this span is in the same process as its parent. If you do
        /// not set this parameter, Stackdriver Trace is unable to take advantage of this helpful information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sameProcessAsParentSpan")]
        public virtual System.Nullable<bool> SameProcessAsParentSpan { get; set; }

        /// <summary>The [SPAN_ID] portion of the span's resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanId")]
        public virtual string SpanId { get; set; }

        /// <summary>
        /// Distinguishes between spans generated in a particular context. For example, two spans with the same name may
        /// be distinguished using `CLIENT` (caller) and `SERVER` (callee) to identify an RPC call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanKind")]
        public virtual string SpanKind { get; set; }

        /// <summary>
        /// The start time of the span. On the client side, this is the time kept by the local machine where the span
        /// execution starts. On the server side, this is the time when the server's application handler starts running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>An optional final status for this span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a string that might be shortened to a specified length.</summary>
    public class TruncatableString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of bytes removed from the original string. If this value is 0, then the string was not shortened.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truncatedByteCount")]
        public virtual System.Nullable<int> TruncatedByteCount { get; set; }

        /// <summary>
        /// The shortened string. For example, if the original string is 500 bytes long and the limit of the string is
        /// 128 bytes, then `value` contains the first 128 bytes of the 500-byte string. Truncation always happens on a
        /// UTF8 character boundary. If there are multi-byte characters in the string, then the length of the shortened
        /// string might be less than the size limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
