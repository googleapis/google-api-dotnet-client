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

namespace Google.Apis.CloudTrace.v1
{
    /// <summary>The CloudTrace Service.</summary>
    public class CloudTraceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

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

            /// <summary>Read Trace data for a project or application</summary>
            public static string TraceReadonly = "https://www.googleapis.com/auth/trace.readonly";
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

            /// <summary>Read Trace data for a project or application</summary>
            public const string TraceReadonly = "https://www.googleapis.com/auth/trace.readonly";
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
            }

            /// <summary>Gets a single trace by its ID.</summary>
            /// <param name="projectId">Required. ID of the Cloud project where the trace data is stored.</param>
            /// <param name="traceId">Required. ID of the trace to return.</param>
            public virtual GetRequest Get(string projectId, string traceId)
            {
                return new GetRequest(this.service, projectId, traceId);
            }

            /// <summary>Gets a single trace by its ID.</summary>
            public class GetRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v1.Data.Trace>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string traceId) : base(service)
                {
                    ProjectId = projectId;
                    TraceId = traceId;
                    InitParameters();
                }

                /// <summary>Required. ID of the Cloud project where the trace data is stored.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Required. ID of the trace to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("traceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TraceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/traces/{traceId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("traceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "traceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns a list of traces that match the specified filter conditions.</summary>
            /// <param name="projectId">Required. ID of the Cloud project where the trace data is stored.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(this.service, projectId);
            }

            /// <summary>Returns a list of traces that match the specified filter conditions.</summary>
            public class ListRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v1.Data.ListTracesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>Required. ID of the Cloud project where the trace data is stored.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                private object _endTime;

                /// <summary>
                /// String representation of <see cref="EndTimeDateTimeOffset"/>, formatted for inclusion in the HTTP
                /// request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
                public virtual object EndTime
                {
                    get => _endTime;
                    set
                    {
                        EndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _endTime = value;
                    }
                }

                public virtual System.DateTimeOffset? EndTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
                    set
                    {
                        EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _endTime = value;
                    }
                }

                /// <summary>
                /// Optional. A filter against properties of the trace. See [filter syntax
                /// documentation](https://cloud.google.com/trace/docs/trace-filters) for details.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Field used to sort the returned traces. Can be one of the following: * `trace_id` * `name`
                /// (`name` field of root span in the trace) * `duration` (difference between `end_time` and
                /// `start_time` fields of the root span) * `start` (`start_time` field of the root span) Descending
                /// order can be specified by appending `desc` to the sort field (for example, `name desc`). Only one
                /// sort field is permitted.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. Maximum number of traces to return. If not specified or &amp;lt;= 0, the implementation
                /// selects a reasonable value. The implementation may return fewer traces than the requested page size.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Token identifying the page of results to return. If provided, use the value of the `next_page_token`
                /// field from a previous request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                private object _startTime;

                /// <summary>
                /// String representation of <see cref="StartTimeDateTimeOffset"/>, formatted for inclusion in the HTTP
                /// request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
                public virtual object StartTime
                {
                    get => _startTime;
                    set
                    {
                        StartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _startTime = value;
                    }
                }

                public virtual System.DateTimeOffset? StartTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
                    set
                    {
                        StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _startTime = value;
                    }
                }

                /// <summary>Optional. Type of data returned for traces in the list. Default is `MINIMAL`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Optional. Type of data returned for traces in the list. Default is `MINIMAL`.</summary>
                public enum ViewEnum
                {
                    /// <summary>Default is `MINIMAL` if unspecified.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                    VIEWTYPEUNSPECIFIED = 0,

                    /// <summary>
                    /// Minimal view of the trace record that contains only the project and trace IDs.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("MINIMAL")]
                    MINIMAL = 1,

                    /// <summary>
                    /// Root span view of the trace record that returns the root spans along with the minimal trace
                    /// data.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("ROOTSPAN")]
                    ROOTSPAN = 2,

                    /// <summary>
                    /// Complete view of the trace record that contains the actual trace data. This is equivalent to
                    /// calling the REST `get` or RPC `GetTrace` method using the ID of each listed trace.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("COMPLETE")]
                    COMPLETE = 3,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/projects/{projectId}/traces";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endTime",
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
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
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
        }

        /// <summary>
        /// Sends trace spans to Cloud Trace. Spans cannot be updated. If the trace ID and span ID already exist, an
        /// additional copy of the span will be stored.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">Required. ID of the Cloud project where the trace data is stored.</param>
        public virtual PatchTracesRequest PatchTraces(Google.Apis.CloudTrace.v1.Data.Traces body, string projectId)
        {
            return new PatchTracesRequest(this.service, body, projectId);
        }

        /// <summary>
        /// Sends trace spans to Cloud Trace. Spans cannot be updated. If the trace ID and span ID already exist, an
        /// additional copy of the span will be stored.
        /// </summary>
        public class PatchTracesRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v1.Data.Empty>
        {
            /// <summary>Constructs a new PatchTraces request.</summary>
            public PatchTracesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTrace.v1.Data.Traces body, string projectId) : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. ID of the Cloud project where the trace data is stored.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTrace.v1.Data.Traces Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patchTraces";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/projects/{projectId}/traces";

            /// <summary>Initializes PatchTraces parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                {
                    Name = "projectId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.CloudTrace.v1.Data
{
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

    /// <summary>The response message for the `ListTraces` method.</summary>
    public class ListTracesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If defined, indicates that there are more traces that match the request and that this value should be passed
        /// to the next request to continue retrieving additional traces.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of trace records as specified by the view parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traces")]
        public virtual System.Collections.Generic.IList<Trace> Traces { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A trace describes how long it takes for an application to perform an operation. It consists of a set of spans,
    /// each of which represent a single timed event within the operation.
    /// </summary>
    public class Trace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Project ID of the Cloud project where the trace data is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Collection of spans in the trace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spans")]
        public virtual System.Collections.Generic.IList<TraceSpan> Spans { get; set; }

        /// <summary>
        /// Globally unique identifier for the trace. This identifier is a 128-bit numeric value formatted as a 32-byte
        /// hex string. For example, `382d4f4c6b7bb2f4a972559d9085001d`. The numeric value should not be zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceId")]
        public virtual string TraceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A span represents a single timed event within a trace. Spans can be nested and form a trace tree. Often, a trace
    /// contains a root span that describes the end-to-end latency of an operation and, optionally, one or more subspans
    /// for its suboperations. Spans do not need to be contiguous. There may be gaps between spans in a trace.
    /// </summary>
    public class TraceSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>End time of the span in seconds and nanoseconds from the UNIX epoch.</summary>
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

        /// <summary>
        /// Distinguishes between spans generated in a particular context. For example, two spans with the same name may
        /// be distinguished using `RPC_CLIENT` and `RPC_SERVER` to identify queueing latency associated with the span.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Collection of labels associated with the span. Label keys must be less than 128 bytes. Label values must be
        /// less than 16 KiB. Some keys might have predefined meaning, and you can also create your own. For more
        /// information, see [Cloud Trace labels](https://cloud.google.com/trace/docs/trace-labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Name of the span. Must be less than 128 bytes. The span name is sanitized and displayed in the Trace tool in
        /// the Google Cloud Platform Console. The name may be a method name or some other per-call site name. For the
        /// same executable and the same call point, a best practice is to use a consistent name, which makes it easier
        /// to correlate cross-trace spans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. ID of the parent span, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentSpanId")]
        public virtual System.Nullable<ulong> ParentSpanId { get; set; }

        /// <summary>
        /// Identifier for the span. Must be a 64-bit integer other than 0 and unique within a trace. For example,
        /// `2205310701640571284`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanId")]
        public virtual System.Nullable<ulong> SpanId { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Start time of the span in seconds and nanoseconds from the UNIX epoch.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of new or updated traces.</summary>
    public class Traces : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of traces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traces")]
        public virtual System.Collections.Generic.IList<Trace> TracesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
