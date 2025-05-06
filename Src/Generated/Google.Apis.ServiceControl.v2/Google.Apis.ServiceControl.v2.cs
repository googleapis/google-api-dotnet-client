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

namespace Google.Apis.ServiceControl.v2
{
    /// <summary>The ServiceControl Service.</summary>
    public class ServiceControlService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://servicecontrol.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://servicecontrol.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "servicecontrol";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Service Control API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Manage your Google Service Control data</summary>
            public static string Servicecontrol = "https://www.googleapis.com/auth/servicecontrol";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Service Control API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
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
        /// This method provides admission control for services that are integrated with [Service
        /// Infrastructure](https://cloud.google.com/service-infrastructure). It checks whether an operation should be
        /// allowed based on the service configuration and relevant policies. It must be called before the operation is
        /// executed. For more information, see [Admission
        /// Control](https://cloud.google.com/service-infrastructure/docs/admission-control). NOTE: The admission
        /// control has an expected policy propagation delay of 60s. The caller **must** not depend on the most recent
        /// policy changes. NOTE: The admission control has a hard limit of 1 referenced resources per call. If an
        /// operation refers to more than 1 resources, the caller must call the Check method multiple times. This method
        /// requires the `servicemanagement.services.check` permission on the specified service. For more information,
        /// see [Service Control API Access
        /// Control](https://cloud.google.com/service-infrastructure/docs/service-control/access-control).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="serviceName">
        /// The service name as specified in its service configuration. For example, `"pubsub.googleapis.com"`. See
        /// [google.api.Service](https://cloud.google.com/service-management/reference/rpc/google.api#google.api.Service)
        /// for the definition of a service name.
        /// </param>
        public virtual CheckRequest Check(Google.Apis.ServiceControl.v2.Data.CheckRequest body, string serviceName)
        {
            return new CheckRequest(this.service, body, serviceName);
        }

        /// <summary>
        /// This method provides admission control for services that are integrated with [Service
        /// Infrastructure](https://cloud.google.com/service-infrastructure). It checks whether an operation should be
        /// allowed based on the service configuration and relevant policies. It must be called before the operation is
        /// executed. For more information, see [Admission
        /// Control](https://cloud.google.com/service-infrastructure/docs/admission-control). NOTE: The admission
        /// control has an expected policy propagation delay of 60s. The caller **must** not depend on the most recent
        /// policy changes. NOTE: The admission control has a hard limit of 1 referenced resources per call. If an
        /// operation refers to more than 1 resources, the caller must call the Check method multiple times. This method
        /// requires the `servicemanagement.services.check` permission on the specified service. For more information,
        /// see [Service Control API Access
        /// Control](https://cloud.google.com/service-infrastructure/docs/service-control/access-control).
        /// </summary>
        public class CheckRequest : ServiceControlBaseServiceRequest<Google.Apis.ServiceControl.v2.Data.CheckResponse>
        {
            /// <summary>Constructs a new Check request.</summary>
            public CheckRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceControl.v2.Data.CheckRequest body, string serviceName) : base(service)
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
            Google.Apis.ServiceControl.v2.Data.CheckRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "check";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/services/{serviceName}:check";

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
        /// This method provides telemetry reporting for services that are integrated with [Service
        /// Infrastructure](https://cloud.google.com/service-infrastructure). It reports a list of operations that have
        /// occurred on a service. It must be called after the operations have been executed. For more information, see
        /// [Telemetry Reporting](https://cloud.google.com/service-infrastructure/docs/telemetry-reporting). NOTE: The
        /// telemetry reporting has a hard limit of 1000 operations and 1MB per Report call. It is recommended to have
        /// no more than 100 operations per call. This method requires the `servicemanagement.services.report`
        /// permission on the specified service. For more information, see [Service Control API Access
        /// Control](https://cloud.google.com/service-infrastructure/docs/service-control/access-control).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="serviceName">
        /// The service name as specified in its service configuration. For example, `"pubsub.googleapis.com"`. See
        /// [google.api.Service](https://cloud.google.com/service-management/reference/rpc/google.api#google.api.Service)
        /// for the definition of a service name.
        /// </param>
        public virtual ReportRequest Report(Google.Apis.ServiceControl.v2.Data.ReportRequest body, string serviceName)
        {
            return new ReportRequest(this.service, body, serviceName);
        }

        /// <summary>
        /// This method provides telemetry reporting for services that are integrated with [Service
        /// Infrastructure](https://cloud.google.com/service-infrastructure). It reports a list of operations that have
        /// occurred on a service. It must be called after the operations have been executed. For more information, see
        /// [Telemetry Reporting](https://cloud.google.com/service-infrastructure/docs/telemetry-reporting). NOTE: The
        /// telemetry reporting has a hard limit of 1000 operations and 1MB per Report call. It is recommended to have
        /// no more than 100 operations per call. This method requires the `servicemanagement.services.report`
        /// permission on the specified service. For more information, see [Service Control API Access
        /// Control](https://cloud.google.com/service-infrastructure/docs/service-control/access-control).
        /// </summary>
        public class ReportRequest : ServiceControlBaseServiceRequest<Google.Apis.ServiceControl.v2.Data.ReportResponse>
        {
            /// <summary>Constructs a new Report request.</summary>
            public ReportRequest(Google.Apis.Services.IClientService service, Google.Apis.ServiceControl.v2.Data.ReportRequest body, string serviceName) : base(service)
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
            Google.Apis.ServiceControl.v2.Data.ReportRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "report";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/services/{serviceName}:report";

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
namespace Google.Apis.ServiceControl.v2.Data
{
    /// <summary>
    /// This message defines attributes associated with API operations, such as a network API request. The terminology
    /// is based on the conventions used by Google APIs, Istio, and OpenAPI.
    /// </summary>
    public class Api : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The API operation name. For gRPC requests, it is the fully qualified API method name, such as
        /// "google.pubsub.v1.Publisher.Publish". For OpenAPI requests, it is the `operationId`, such as "getPet".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>
        /// The API protocol used for sending the request, such as "http", "https", "grpc", or "internal".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The API service name. It is a logical identifier for a networked API, such as "pubsub.googleapis.com". The
        /// naming syntax depends on the API management system being used for handling the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The API version associated with the API operation above, such as "v1" or "v1alpha1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This message defines the standard attribute vocabulary for Google APIs. An attribute is a piece of metadata that
    /// describes an activity on a network service. For example, the size of an HTTP request, or the status code of an
    /// HTTP response. Each attribute has a type and a name, which is logically defined as a proto message field in
    /// `AttributeContext`. The field type becomes the attribute type, and the field path becomes the attribute name.
    /// For example, the attribute `source.ip` maps to field `AttributeContext.source.ip`. This message definition is
    /// guaranteed not to have any wire breaking change. So you can use it directly for passing attributes across
    /// different systems. NOTE: Different system may generate different subset of attributes. Please verify the system
    /// specification before relying on an attribute generated a system.
    /// </summary>
    public class AttributeContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents an API operation that is involved to a network activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("api")]
        public virtual Api Api { get; set; }

        /// <summary>
        /// The destination of a network activity, such as accepting a TCP connection. In a multi hop network activity,
        /// the destination represents the receiver of the last hop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual Peer Destination { get; set; }

        /// <summary>Supports extensions for advanced use cases, such as logs and metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>
        /// The origin of a network activity. In a multi hop network activity, the origin represents the sender of the
        /// first hop. For the first hop, the `source` and the `origin` must have the same content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual Peer Origin { get; set; }

        /// <summary>Represents a network request, such as an HTTP request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual Request Request { get; set; }

        /// <summary>
        /// Represents a target resource that is involved with a network activity. If multiple resources are involved
        /// with an activity, this must be the primary one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>Represents a network response, such as an HTTP response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual Response Response { get; set; }

        /// <summary>
        /// The source of a network activity, such as starting a TCP connection. In a multi hop network activity, the
        /// source represents the sender of the last hop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Peer Source { get; set; }

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
        /// Indicates the policy violations for this request. If the request is denied by the policy, violation
        /// information will be logged here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyViolationInfo")]
        public virtual PolicyViolationInfo PolicyViolationInfo { get; set; }

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

        /// <summary>Records the history of delegated resource access across Google services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDelegationHistory")]
        public virtual ServiceDelegationHistory ServiceDelegationHistory { get; set; }

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
        /// The type of the permission that was checked. For data access audit logs this corresponds with the permission
        /// type that must be enabled in the project/folder/organization IAM policy in order for the log to be written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionType")]
        public virtual string PermissionType { get; set; }

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

    /// <summary>Request message for the Check method.</summary>
    public class CheckRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Describes attributes about the operation being executed by the service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual AttributeContext Attributes { get; set; }

        /// <summary>Optional. Contains a comma-separated list of flags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flags")]
        public virtual string Flags { get; set; }

        /// <summary>Describes the resources and the policies applied to each resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<ResourceInfo> Resources { get; set; }

        /// <summary>
        /// Specifies the version of the service configuration that should be used to process the request. Must not be
        /// empty. Set this field to 'latest' to specify using the latest configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceConfigId")]
        public virtual string ServiceConfigId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the Check method.</summary>
    public class CheckResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional response metadata that will be emitted as dynamic metadata to be consumed by the caller of
        /// ServiceController. For compatibility with the ext_authz interface.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> DynamicMetadata { get; set; }

        /// <summary>Returns a set of request contexts generated from the `CheckRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Operation is allowed when this field is not set. Any non-'OK' status indicates a denial;
        /// google.rpc.Status.details would contain additional details about the denial.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

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

    /// <summary>Represents OrgPolicy Violation information.</summary>
    public class OrgPolicyViolationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Deprecated. Resource payload that is currently in scope and is subjected to orgpolicy conditions.
        /// This payload may be the subset of the actual Resource that may come in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string, object> Payload { get; set; }

        /// <summary>Optional. Deprecated. Tags referenced on the resource at the time of evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTags")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceTags { get; set; }

        /// <summary>
        /// Optional. Resource type that the orgpolicy is checked against. Example: compute.googleapis.com/Instance,
        /// store.googleapis.com/bucket
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Optional. Policy violations</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("violationInfo")]
        public virtual System.Collections.Generic.IList<ViolationInfo> ViolationInfo { get; set; }

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
        /// request. For example, the identity associated with a load balancer that forwarded the request.
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

    /// <summary>Information related to policy violations for this request.</summary>
    public class PolicyViolationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the orgpolicy violations for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgPolicyViolationInfo")]
        public virtual OrgPolicyViolationInfo OrgPolicyViolationInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the Report method.</summary>
    public class ReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describes the list of operations to be reported. Each operation is represented as an AttributeContext, and
        /// contains all attributes around an API access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<AttributeContext> Operations { get; set; }

        /// <summary>
        /// Specifies the version of the service configuration that should be used to process the request. Must not be
        /// empty. Set this field to 'latest' to specify using the latest configuration.
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
        /// The extension field to store serialized OTel responses. e.g. ExportLogsServiceResponse,
        /// ExportMetricsServiceResponse.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IDictionary<string, object> Extensions { get; set; }

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

        /// <summary>
        /// The values from Origin header from the HTTP request, such as "https://console.cloud.google.com". Modern
        /// browsers can only have one origin. Special browsers and/or HTTP clients may require multiple origins.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("origin")]
        public virtual string Origin { get; set; }

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

        private string _timeRaw;

        private object _time;

        /// <summary>The timestamp when the `destination` service receives the last byte of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual string TimeRaw
        {
            get => _timeRaw;
            set
            {
                _time = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeDateTimeOffset instead.")]
        public virtual object Time
        {
            get => _time;
            set
            {
                _timeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _time = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimeRaw);
            set => TimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the request.</summary>
    public class RequestMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The IP address of the caller. For a caller from the internet, this will be the public IPv4 or IPv6 address.
        /// For calls made from inside Google's internal production network from one GCP service to another, `caller_ip`
        /// will be redacted to "private". For a caller from a Compute Engine VM with a external IP address, `caller_ip`
        /// will be the VM's external IP address. For a caller from a Compute Engine VM without a external IP address,
        /// if the VM is in the same organization (or project) as the accessed resource, `caller_ip` will be the VM's
        /// internal IPv4 address, otherwise `caller_ip` will be redacted to "gce-internal-ip". See
        /// https://cloud.google.com/compute/docs/vpc/ for more information.
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
        /// was made from the `my-project` App Engine app.
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
        /// objects. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The timestamp when the resource was created. This may be either the time creation was initiated
        /// or when it was completed.
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

        private string _deleteTimeRaw;

        private object _deleteTime;

        /// <summary>
        /// Output only. The timestamp when the resource was deleted. If the resource is not deleted, this must be
        /// empty.
        /// </summary>
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
        /// differently. For Google APIs, the type format must be "{service}/{kind}", such as
        /// "pubsub.googleapis.com/Topic".
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

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the resource was last updated. Any change to the resource made by users must
        /// refresh this value. Changes to a resource made by the service should refresh this value.
        /// </summary>
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

    /// <summary>Describes a resource referenced in the request.</summary>
    public class ResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The identifier of the container of this resource. For Google Cloud APIs, the resource container
        /// must be one of the following formats: - `projects/` - `folders/` - `organizations/` Required for the policy
        /// enforcement on the container level (e.g. VPCSC, Location Policy check, Org Policy check).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual string Container { get; set; }

        /// <summary>
        /// Optional. The location of the resource, it must be a valid zone, region or multiregion, for example:
        /// "europe-west4", "northamerica-northeast1-a". Required for location policy check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The name of the resource referenced in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The resource permission needed for this request. The format must be "{service}/{plural}.{verb}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The resource type in the format of "{service}/{kind}".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>
    /// This message defines attributes for a typical network response. It generally models semantics of an HTTP
    /// response.
    /// </summary>
    public class Response : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of time it takes the backend service to fully respond to a request. Measured from when the
        /// destination service starts to send the request to the backend until when the destination service receives
        /// the complete response from the backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backendLatency")]
        public virtual object BackendLatency { get; set; }

        /// <summary>The HTTP response status code, such as `200` and `404`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<long> Code { get; set; }

        /// <summary>
        /// The HTTP response headers. If multiple headers share the same key, they must be merged according to HTTP
        /// spec. All header keys must be lowercased, because HTTP header keys are case-insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers { get; set; }

        /// <summary>The HTTP response size in bytes. If unknown, it must be -1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        private string _timeRaw;

        private object _time;

        /// <summary>The timestamp when the `destination` service sends the last byte of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual string TimeRaw
        {
            get => _timeRaw;
            set
            {
                _time = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeDateTimeOffset instead.")]
        public virtual object Time
        {
            get => _time;
            set
            {
                _timeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _time = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimeRaw);
            set => TimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
    /// The history of delegation across multiple services as the result of the original user's action. Such as "service
    /// A uses its own account to do something for user B". This differs from ServiceAccountDelegationInfo, which only
    /// tracks the history of direct token exchanges (impersonation).
    /// </summary>
    public class ServiceDelegationHistory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The original end user who initiated the request to GCP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPrincipal")]
        public virtual string OriginalPrincipal { get; set; }

        /// <summary>
        /// Data identifying the service specific jobs or units of work that were involved in a chain of service calls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceMetadata")]
        public virtual System.Collections.Generic.IList<ServiceMetadata> ServiceMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata describing the service and additional service specific information used to identify the job or unit of
    /// work at hand.
    /// </summary>
    public class ServiceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional metadata provided by service teams to describe service specific job information that was
        /// triggered by the original principal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> JobMetadata { get; set; }

        /// <summary>
        /// A string representing the principal_subject associated with the identity. For most identities, the format
        /// will be `principal://iam.googleapis.com/{identity pool name}/subject/{subject)` except for some GKE
        /// identities (GKE_WORKLOAD, FREEFORM, GKE_HUB_WORKLOAD) that are still in the legacy format
        /// `serviceAccount:{identity pool name}[{subject}]` If the identity is a Google account (e.g. workspace user
        /// account or service account), this will be the email of the prefixed by `serviceAccount:`. For example:
        /// `serviceAccount:my-service-account@project-1.iam.gserviceaccount.com`. If the identity is an individual
        /// user, the identity will be formatted as: `user:user_ABC@email.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The service's fully qualified domain name, e.g. "dataproc.googleapis.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceDomain")]
        public virtual string ServiceDomain { get; set; }

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
    /// A common proto for logging HTTP requests. Only contains semantics defined by the HTTP specification.
    /// Product-specific logging information MUST be defined in a separate message.
    /// </summary>
    public class V2HttpRequest : Google.Apis.Requests.IDirectResponseSchema
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
        /// Definitions](https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html).
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

    /// <summary>An individual log entry.</summary>
    public class V2LogEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Information about the HTTP request associated with this log entry, if applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpRequest")]
        public virtual V2HttpRequest HttpRequest { get; set; }

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

        /// <summary>
        /// A set of user-defined (key, value) data that provides additional information about the moniotored resource
        /// that the log entry belongs to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monitoredResourceLabels")]
        public virtual System.Collections.Generic.IDictionary<string, string> MonitoredResourceLabels { get; set; }

        /// <summary>Required. The log to which this log entry belongs. Examples: `"syslog"`, `"book_log"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Information about an operation associated with the log entry, if applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual V2LogEntryOperation Operation { get; set; }

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
        public virtual V2LogEntrySourceLocation SourceLocation { get; set; }

        /// <summary>The log entry payload, represented as a structure that is expressed as a JSON object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("structPayload")]
        public virtual System.Collections.Generic.IDictionary<string, object> StructPayload { get; set; }

        /// <summary>The log entry payload, represented as a Unicode string (UTF-8).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textPayload")]
        public virtual string TextPayload { get; set; }

        private string _timestampRaw;

        private object _timestamp;

        /// <summary>
        /// The time the event described by the log entry occurred. If omitted, defaults to operation start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual string TimestampRaw
        {
            get => _timestampRaw;
            set
            {
                _timestamp = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _timestampRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimestampDateTimeOffset instead.")]
        public virtual object Timestamp
        {
            get => _timestamp;
            set
            {
                _timestampRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _timestamp = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimestampDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TimestampRaw);
            set => TimestampRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

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
    public class V2LogEntryOperation : Google.Apis.Requests.IDirectResponseSchema
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
    public class V2LogEntrySourceLocation : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// Report v2 extension proto for passing the resource metadata associated with a resource
    /// create/update/delete/undelete event from ESF to Chemist. ResourceEvent proto should be serialized into the
    /// ReportRequest.operations.extensions.
    /// </summary>
    public class V2ResourceEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ESF unique context id of the api request, from which this resource event originated. This field is only
        /// needed for CAIS integration via api annotation. See go/cais-lro-delete for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contextId")]
        public virtual System.Nullable<long> ContextId { get; set; }

        /// <summary>
        /// The destinations field determines which backend services should handle the event. This should be specified
        /// as a comma-delimited string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinations")]
        public virtual string Destinations { get; set; }

        /// <summary>The parent resource for the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual Resource Parent { get; set; }

        /// <summary>
        /// The api path the resource event was created in. This should match the source of the `payload` field. For
        /// direct integrations with Chemist, this should generally be the RESPONSE. go/resource-event-pipeline-type
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// The payload contains metadata associated with the resource event. A ResourceEventPayloadStatus is provided
        /// instead if the original payload cannot be returned due to a limitation (e.g. size limit).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string, object> Payload { get; set; }

        /// <summary>The resource associated with the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>The resource event type determines how the backend service should process the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides information about the Policy violation info for this request.</summary>
    public class ViolationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Value that is being checked for the policy. This could be in encrypted form (if pii sensitive).
        /// This field will only be emitted in LIST_POLICY types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkedValue")]
        public virtual string CheckedValue { get; set; }

        /// <summary>Optional. Constraint name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("constraint")]
        public virtual string Constraint { get; set; }

        /// <summary>Optional. Error message that policy is indicating.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Optional. Indicates the type of the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyType")]
        public virtual string PolicyType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
