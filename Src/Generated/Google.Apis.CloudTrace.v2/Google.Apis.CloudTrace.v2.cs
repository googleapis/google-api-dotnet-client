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

namespace Google.Apis.CloudTrace.v2
{
    /// <summary>The CloudTrace Service.</summary>
    public class CloudTraceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudTraceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudTraceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://cloudtrace.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://cloudtrace.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudtrace";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Trace API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Write Trace data for a project or application</summary>
            public static string TraceAppend = "https://www.googleapis.com/auth/trace.append";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Trace API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Write Trace data for a project or application</summary>
            public const string TraceAppend = "https://www.googleapis.com/auth/trace.append";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudTrace requests.</summary>
    public abstract class CloudTraceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudTraceBaseServiceRequest instance.</summary>
        protected CloudTraceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudTrace parameter list.</summary>
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
            Traces = new TracesResource(service);
        }

        /// <summary>Gets the Traces resource.</summary>
        public virtual TracesResource Traces { get; }

        /// <summary>The "traces" collection of methods.</summary>
        public class TracesResource
        {
            private const string Resource = "traces";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TracesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Spans = new SpansResource(service);
            }

            /// <summary>Gets the Spans resource.</summary>
            public virtual SpansResource Spans { get; }

            /// <summary>The "spans" collection of methods.</summary>
            public class SpansResource
            {
                private const string Resource = "spans";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SpansResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new span. If a span ID already exists, an additional copy of the span will be stored.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The resource name of the span in the following format: *
                /// `projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]` `[TRACE_ID]` is a unique identifier for a
                /// trace within a project; it is a 32-character hexadecimal encoding of a 16-byte array. It should not
                /// be zero. `[SPAN_ID]` is a unique identifier for a span within a trace; it is a 16-character
                /// hexadecimal encoding of an 8-byte array. It should not be zero. .
                /// </param>
                public virtual CreateSpanRequest CreateSpan(Google.Apis.CloudTrace.v2.Data.Span body, string name)
                {
                    return new CreateSpanRequest(this.service, body, name);
                }

                /// <summary>
                /// Creates a new span. If a span ID already exists, an additional copy of the span will be stored.
                /// </summary>
                public class CreateSpanRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v2.Data.Span>
                {
                    /// <summary>Constructs a new CreateSpan request.</summary>
                    public CreateSpanRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTrace.v2.Data.Span body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the span in the following format: *
                    /// `projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]` `[TRACE_ID]` is a unique identifier
                    /// for a trace within a project; it is a 32-character hexadecimal encoding of a 16-byte array. It
                    /// should not be zero. `[SPAN_ID]` is a unique identifier for a span within a trace; it is a
                    /// 16-character hexadecimal encoding of an 8-byte array. It should not be zero. .
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudTrace.v2.Data.Span Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createSpan";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes CreateSpan parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/traces/[^/]+/spans/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Batch writes new spans to new or existing traces. You cannot update existing spans. If a span ID already
            /// exists, an additional copy of the span will be stored.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the project where the spans belong. The format is `projects/[PROJECT_ID]`.
            /// </param>
            public virtual BatchWriteRequest BatchWrite(Google.Apis.CloudTrace.v2.Data.BatchWriteSpansRequest body, string name)
            {
                return new BatchWriteRequest(this.service, body, name);
            }

            /// <summary>
            /// Batch writes new spans to new or existing traces. You cannot update existing spans. If a span ID already
            /// exists, an additional copy of the span will be stored.
            /// </summary>
            public class BatchWriteRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v2.Data.Empty>
            {
                /// <summary>Constructs a new BatchWrite request.</summary>
                public BatchWriteRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTrace.v2.Data.BatchWriteSpansRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project where the spans belong. The format is `projects/[PROJECT_ID]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudTrace.v2.Data.BatchWriteSpansRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchWrite";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}/traces:batchWrite";

                /// <summary>Initializes BatchWrite parameter list.</summary>
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
                }
            }
        }
    }
}
namespace Google.Apis.CloudTrace.v2.Data
{
    /// <summary>Text annotation with a set of attributes.</summary>
    public class Annotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of attributes on the annotation. You can have up to 4 attributes per Annotation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// A user-supplied message describing the event. The maximum length for the description is 256 bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual TruncatableString Description { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The allowed types for `[VALUE]` in a `[KEY]:[VALUE]` attribute.</summary>
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

    /// <summary>A set of attributes as key-value pairs.</summary>
    public class Attributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A set of attributes. Each attribute's key can be up to 128 bytes long. The value can be a string up to 256
        /// bytes, a signed 64-bit integer, or the boolean values `true` or `false`. For example: "/instance_id": {
        /// "string_value": { "value": "my-instance" } } "/http/request_bytes": { "int_value": 300 }
        /// "example.com/myattribute": { "bool_value": false }
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

    /// <summary>The request message for the `BatchWriteSpans` method.</summary>
    public class BatchWriteSpansRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of new spans. The span names must not match existing spans, otherwise the results are
        /// undefined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spans")]
        public virtual System.Collections.Generic.IList<Span> Spans { get; set; }

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
    /// A pointer from the current span to another span in the same trace or in a different trace. For example, this can
    /// be used in batching operations, where a single batch handler processes multiple requests from different traces
    /// or when the handler receives a request from a different project.
    /// </summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of attributes on the link. Up to 32 attributes can be specified per link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>The `[SPAN_ID]` for a span within a trace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanId")]
        public virtual string SpanId { get; set; }

        /// <summary>The `[TRACE_ID]` for a trace within a project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceId")]
        public virtual string TraceId { get; set; }

        /// <summary>The relationship of the current span relative to the linked span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection of links, which are references from this span to a span in the same or different trace.
    /// </summary>
    public class Links : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of dropped links after the maximum size was enforced. If this value is 0, then no links were
        /// dropped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedLinksCount")]
        public virtual System.Nullable<int> DroppedLinksCount { get; set; }

        /// <summary>A collection of links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual System.Collections.Generic.IList<Link> Link { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event describing a message sent/received between Spans.</summary>
    public class MessageEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of compressed bytes sent or received. If missing, the compressed size is assumed to be the same
        /// size as the uncompressed size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compressedSizeBytes")]
        public virtual System.Nullable<long> CompressedSizeBytes { get; set; }

        /// <summary>
        /// An identifier for the MessageEvent's message that can be used to match `SENT` and `RECEIVED` MessageEvents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>Type of MessageEvent. Indicates whether the message was sent or received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The number of uncompressed bytes sent or received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncompressedSizeBytes")]
        public virtual System.Nullable<long> UncompressedSizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Binary module.</summary>
    public class Module : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique identifier for the module, usually a hash of its contents (up to 128 bytes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildId")]
        public virtual TruncatableString BuildId { get; set; }

        /// <summary>
        /// For example: main binary, kernel modules, and dynamic libraries such as libc.so, sharedlib.so (up to 256
        /// bytes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("module")]
        public virtual TruncatableString ModuleValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A span represents a single operation within a trace. Spans can be nested to form a trace tree. Often, a trace
    /// contains a root span that describes the end-to-end latency, and one or more subspans for its sub-operations. A
    /// trace can also contain multiple root spans, or none at all. Spans do not need to be contiguous. There might be
    /// gaps or overlaps between spans in a trace.
    /// </summary>
    public class Span : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of attributes on the span. You can have up to 32 attributes per span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual Attributes Attributes { get; set; }

        /// <summary>
        /// Optional. The number of child spans that were generated while this span was active. If set, allows
        /// implementation to detect missing child spans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childSpanCount")]
        public virtual System.Nullable<int> ChildSpanCount { get; set; }

        /// <summary>
        /// Required. A description of the span's operation (up to 128 bytes). Cloud Trace displays the description in
        /// the Cloud console. For example, the display name can be a qualified method name or a file name and a line
        /// number where the operation is called. A best practice is to use the same display name within an application
        /// and at the same call point. This makes it easier to correlate spans in different traces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual TruncatableString DisplayName { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Required. The end time of the span. On the client side, this is the time kept by the local machine where the
        /// span execution ends. On the server side, this is the time when the server application handler stops running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Links associated with the span. You can have up to 128 links per Span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("links")]
        public virtual Links Links { get; set; }

        /// <summary>
        /// Required. The resource name of the span in the following format: *
        /// `projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]` `[TRACE_ID]` is a unique identifier for a trace
        /// within a project; it is a 32-character hexadecimal encoding of a 16-byte array. It should not be zero.
        /// `[SPAN_ID]` is a unique identifier for a span within a trace; it is a 16-character hexadecimal encoding of
        /// an 8-byte array. It should not be zero. .
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The `[SPAN_ID]` of this span's parent span. If this is a root span, then this field must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentSpanId")]
        public virtual string ParentSpanId { get; set; }

        /// <summary>
        /// Optional. Set this parameter to indicate whether this span is in the same process as its parent. If you do
        /// not set this parameter, Trace is unable to take advantage of this helpful information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sameProcessAsParentSpan")]
        public virtual System.Nullable<bool> SameProcessAsParentSpan { get; set; }

        /// <summary>Required. The `[SPAN_ID]` portion of the span's resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanId")]
        public virtual string SpanId { get; set; }

        /// <summary>
        /// Optional. Distinguishes between spans generated in a particular context. For example, two spans with the
        /// same name may be distinguished using `CLIENT` (caller) and `SERVER` (callee) to identify an RPC call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanKind")]
        public virtual string SpanKind { get; set; }

        /// <summary>Stack trace captured at the start of the span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTrace")]
        public virtual StackTrace StackTrace { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Required. The start time of the span. On the client side, this is the time kept by the local machine where
        /// the span execution starts. On the server side, this is the time when the server's application handler starts
        /// running.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The final status for this span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual Status Status { get; set; }

        /// <summary>A set of time events. You can have up to 32 annotations and 128 message events per span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeEvents")]
        public virtual TimeEvents TimeEvents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single stack frame in a stack trace.</summary>
    public class StackFrame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The column number where the function call appears, if available. This is important in JavaScript because of
        /// its anonymous functions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnNumber")]
        public virtual System.Nullable<long> ColumnNumber { get; set; }

        /// <summary>The name of the source file where the function call appears (up to 256 bytes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual TruncatableString FileName { get; set; }

        /// <summary>
        /// The fully-qualified name that uniquely identifies the function or method that is active in this frame (up to
        /// 1024 bytes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("functionName")]
        public virtual TruncatableString FunctionName { get; set; }

        /// <summary>The line number in `file_name` where the function call appears.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineNumber")]
        public virtual System.Nullable<long> LineNumber { get; set; }

        /// <summary>The binary module from where the code was loaded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loadModule")]
        public virtual Module LoadModule { get; set; }

        /// <summary>
        /// An un-mangled function name, if `function_name` is mangled. To get information about name mangling, run
        /// [this search](https://www.google.com/search?q=cxx+name+mangling). The name can be fully-qualified (up to
        /// 1024 bytes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalFunctionName")]
        public virtual TruncatableString OriginalFunctionName { get; set; }

        /// <summary>The version of the deployed source code (up to 128 bytes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceVersion")]
        public virtual TruncatableString SourceVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of stack frames, which can be truncated.</summary>
    public class StackFrames : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of stack frames that were dropped because there were too many stack frames. If this value is 0,
        /// then no stack frames were dropped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedFramesCount")]
        public virtual System.Nullable<int> DroppedFramesCount { get; set; }

        /// <summary>Stack frames in this call stack.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frame")]
        public virtual System.Collections.Generic.IList<StackFrame> Frame { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A call stack appearing in a trace.</summary>
    public class StackTrace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Stack frames in this stack trace. A maximum of 128 frames are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackFrames")]
        public virtual StackFrames StackFrames { get; set; }

        /// <summary>
        /// The hash ID is used to conserve network bandwidth for duplicate stack traces within a single trace. Often
        /// multiple spans will have identical stack traces. The first occurrence of a stack trace should contain both
        /// the `stackFrame` content and a value in `stackTraceHashId`. Subsequent spans within the same request can
        /// refer to that stack trace by only setting `stackTraceHashId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackTraceHashId")]
        public virtual System.Nullable<long> StackTraceHashId { get; set; }

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

    /// <summary>A time-stamped annotation or message event in the Span.</summary>
    public class TimeEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text annotation with a set of attributes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotation")]
        public virtual Annotation Annotation { get; set; }

        /// <summary>An event describing a message sent/received between Spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageEvent")]
        public virtual MessageEvent MessageEvent { get; set; }

        private string _timeRaw;

        private object _time;

        /// <summary>The timestamp indicating the time the event occurred.</summary>
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

    /// <summary>
    /// A collection of `TimeEvent`s. A `TimeEvent` is a time-stamped annotation on the span, consisting of either
    /// user-supplied key:value pairs, or details of a message sent/received between Spans.
    /// </summary>
    public class TimeEvents : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of dropped annotations in all the included time events. If the value is 0, then no annotations
        /// were dropped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedAnnotationsCount")]
        public virtual System.Nullable<int> DroppedAnnotationsCount { get; set; }

        /// <summary>
        /// The number of dropped message events in all the included time events. If the value is 0, then no message
        /// events were dropped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("droppedMessageEventsCount")]
        public virtual System.Nullable<int> DroppedMessageEventsCount { get; set; }

        /// <summary>A collection of `TimeEvent`s.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeEvent")]
        public virtual System.Collections.Generic.IList<TimeEvent> TimeEvent { get; set; }

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
