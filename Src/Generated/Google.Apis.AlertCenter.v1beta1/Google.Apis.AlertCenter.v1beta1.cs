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

namespace Google.Apis.AlertCenter.v1beta1
{
    /// <summary>The AlertCenter Service.</summary>
    public class AlertCenterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AlertCenterService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AlertCenterService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Alerts = new AlertsResource(this);
            V1beta1 = new V1beta1Resource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://alertcenter.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://alertcenter.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "alertcenter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Workspace Alert Center API.</summary>
        public class Scope
        {
            /// <summary>See and delete your domain's G Suite alerts, and send alert feedback</summary>
            public static string AppsAlerts = "https://www.googleapis.com/auth/apps.alerts";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Workspace Alert Center API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See and delete your domain's G Suite alerts, and send alert feedback</summary>
            public const string AppsAlerts = "https://www.googleapis.com/auth/apps.alerts";
        }

        /// <summary>Gets the Alerts resource.</summary>
        public virtual AlertsResource Alerts { get; }

        /// <summary>Gets the V1beta1 resource.</summary>
        public virtual V1beta1Resource V1beta1 { get; }
    }

    /// <summary>A base abstract class for AlertCenter requests.</summary>
    public abstract class AlertCenterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AlertCenterBaseServiceRequest instance.</summary>
        protected AlertCenterBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AlertCenter parameter list.</summary>
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

    /// <summary>The "alerts" collection of methods.</summary>
    public class AlertsResource
    {
        private const string Resource = "alerts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AlertsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Feedback = new FeedbackResource(service);
        }

        /// <summary>Gets the Feedback resource.</summary>
        public virtual FeedbackResource Feedback { get; }

        /// <summary>The "feedback" collection of methods.</summary>
        public class FeedbackResource
        {
            private const string Resource = "feedback";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FeedbackResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates new feedback for an alert. Attempting to create a feedback for a non-existent alert returns
            /// `NOT_FOUND` error. Attempting to create a feedback for an alert that is marked for deletion returns
            /// `FAILED_PRECONDITION' error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="alertId">Required. The identifier of the alert this feedback belongs to.</param>
            public virtual CreateRequest Create(Google.Apis.AlertCenter.v1beta1.Data.AlertFeedback body, string alertId)
            {
                return new CreateRequest(this.service, body, alertId);
            }

            /// <summary>
            /// Creates new feedback for an alert. Attempting to create a feedback for a non-existent alert returns
            /// `NOT_FOUND` error. Attempting to create a feedback for an alert that is marked for deletion returns
            /// `FAILED_PRECONDITION' error.
            /// </summary>
            public class CreateRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.AlertFeedback>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AlertCenter.v1beta1.Data.AlertFeedback body, string alertId) : base(service)
                {
                    AlertId = alertId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The identifier of the alert this feedback belongs to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alertId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AlertId { get; private set; }

                /// <summary>
                /// Optional. The unique identifier of the Google Workspace account of the customer the alert is
                /// associated with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`).
                /// Inferred from the caller identity if not provided. [Find your customer
                /// ID](https://support.google.com/cloudidentity/answer/10070793).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CustomerId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AlertCenter.v1beta1.Data.AlertFeedback Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/alerts/{alertId}/feedback";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("alertId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "alertId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Lists all the feedback for an alert. Attempting to list feedbacks for a non-existent alert returns
            /// `NOT_FOUND` error.
            /// </summary>
            /// <param name="alertId">
            /// Required. The alert identifier. The "-" wildcard could be used to represent all alerts.
            /// </param>
            public virtual ListRequest List(string alertId)
            {
                return new ListRequest(this.service, alertId);
            }

            /// <summary>
            /// Lists all the feedback for an alert. Attempting to list feedbacks for a non-existent alert returns
            /// `NOT_FOUND` error.
            /// </summary>
            public class ListRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.ListAlertFeedbackResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string alertId) : base(service)
                {
                    AlertId = alertId;
                    InitParameters();
                }

                /// <summary>
                /// Required. The alert identifier. The "-" wildcard could be used to represent all alerts.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("alertId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AlertId { get; private set; }

                /// <summary>
                /// Optional. The unique identifier of the Google Workspace account of the customer the alert is
                /// associated with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`).
                /// Inferred from the caller identity if not provided. [Find your customer
                /// ID](https://support.google.com/cloudidentity/answer/10070793).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string CustomerId { get; set; }

                /// <summary>
                /// Optional. A query string for filtering alert feedback results. For more details, see [Query
                /// filters](https://developers.google.com/workspace/admin/alertcenter/guides/query-filters) and
                /// [Supported query filter
                /// fields](https://developers.google.com/workspace/admin/alertcenter/reference/filter-fields#alerts.feedback.list).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/alerts/{alertId}/feedback";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("alertId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "alertId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
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
                }
            }
        }

        /// <summary>Performs batch delete operation on alerts.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchDeleteRequest BatchDelete(Google.Apis.AlertCenter.v1beta1.Data.BatchDeleteAlertsRequest body)
        {
            return new BatchDeleteRequest(this.service, body);
        }

        /// <summary>Performs batch delete operation on alerts.</summary>
        public class BatchDeleteRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.BatchDeleteAlertsResponse>
        {
            /// <summary>Constructs a new BatchDelete request.</summary>
            public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.AlertCenter.v1beta1.Data.BatchDeleteAlertsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AlertCenter.v1beta1.Data.BatchDeleteAlertsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchDelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/alerts:batchDelete";

            /// <summary>Initializes BatchDelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Performs batch undelete operation on alerts.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual BatchUndeleteRequest BatchUndelete(Google.Apis.AlertCenter.v1beta1.Data.BatchUndeleteAlertsRequest body)
        {
            return new BatchUndeleteRequest(this.service, body);
        }

        /// <summary>Performs batch undelete operation on alerts.</summary>
        public class BatchUndeleteRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.BatchUndeleteAlertsResponse>
        {
            /// <summary>Constructs a new BatchUndelete request.</summary>
            public BatchUndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.AlertCenter.v1beta1.Data.BatchUndeleteAlertsRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AlertCenter.v1beta1.Data.BatchUndeleteAlertsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUndelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/alerts:batchUndelete";

            /// <summary>Initializes BatchUndelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Marks the specified alert for deletion. An alert that has been marked for deletion is removed from Alert
        /// Center after 30 days. Marking an alert for deletion has no effect on an alert which has already been marked
        /// for deletion. Attempting to mark a nonexistent alert for deletion results in a `NOT_FOUND` error.
        /// </summary>
        /// <param name="alertId">Required. The identifier of the alert to delete.</param>
        public virtual DeleteRequest Delete(string alertId)
        {
            return new DeleteRequest(this.service, alertId);
        }

        /// <summary>
        /// Marks the specified alert for deletion. An alert that has been marked for deletion is removed from Alert
        /// Center after 30 days. Marking an alert for deletion has no effect on an alert which has already been marked
        /// for deletion. Attempting to mark a nonexistent alert for deletion results in a `NOT_FOUND` error.
        /// </summary>
        public class DeleteRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string alertId) : base(service)
            {
                AlertId = alertId;
                InitParameters();
            }

            /// <summary>Required. The identifier of the alert to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alertId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AlertId { get; private set; }

            /// <summary>
            /// Optional. The unique identifier of the Google Workspace account of the customer the alert is associated
            /// with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`). Inferred from the
            /// caller identity if not provided. [Find your customer
            /// ID](https://support.google.com/cloudidentity/answer/10070793).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/alerts/{alertId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("alertId", new Google.Apis.Discovery.Parameter
                {
                    Name = "alertId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets the specified alert. Attempting to get a nonexistent alert returns `NOT_FOUND` error.
        /// </summary>
        /// <param name="alertId">Required. The identifier of the alert to retrieve.</param>
        public virtual GetRequest Get(string alertId)
        {
            return new GetRequest(this.service, alertId);
        }

        /// <summary>
        /// Gets the specified alert. Attempting to get a nonexistent alert returns `NOT_FOUND` error.
        /// </summary>
        public class GetRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.Alert>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string alertId) : base(service)
            {
                AlertId = alertId;
                InitParameters();
            }

            /// <summary>Required. The identifier of the alert to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alertId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AlertId { get; private set; }

            /// <summary>
            /// Optional. The unique identifier of the Google Workspace account of the customer the alert is associated
            /// with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`). Inferred from the
            /// caller identity if not provided. [Find your customer
            /// ID](https://support.google.com/cloudidentity/answer/10070793).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/alerts/{alertId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("alertId", new Google.Apis.Discovery.Parameter
                {
                    Name = "alertId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns the metadata of an alert. Attempting to get metadata for a non-existent alert returns `NOT_FOUND`
        /// error.
        /// </summary>
        /// <param name="alertId">Required. The identifier of the alert this metadata belongs to.</param>
        public virtual GetMetadataRequest GetMetadata(string alertId)
        {
            return new GetMetadataRequest(this.service, alertId);
        }

        /// <summary>
        /// Returns the metadata of an alert. Attempting to get metadata for a non-existent alert returns `NOT_FOUND`
        /// error.
        /// </summary>
        public class GetMetadataRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.AlertMetadata>
        {
            /// <summary>Constructs a new GetMetadata request.</summary>
            public GetMetadataRequest(Google.Apis.Services.IClientService service, string alertId) : base(service)
            {
                AlertId = alertId;
                InitParameters();
            }

            /// <summary>Required. The identifier of the alert this metadata belongs to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alertId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AlertId { get; private set; }

            /// <summary>
            /// Optional. The unique identifier of the Google Workspace account of the customer the alert metadata is
            /// associated with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`).
            /// Inferred from the caller identity if not provided. [Find your customer
            /// ID](https://support.google.com/cloudidentity/answer/10070793).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getMetadata";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/alerts/{alertId}/metadata";

            /// <summary>Initializes GetMetadata parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("alertId", new Google.Apis.Discovery.Parameter
                {
                    Name = "alertId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists the alerts.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists the alerts.</summary>
        public class ListRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.ListAlertsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The unique identifier of the Google Workspace account of the customer the alerts are
            /// associated with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`).
            /// Inferred from the caller identity if not provided. [Find your customer
            /// ID](https://support.google.com/cloudidentity/answer/10070793).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// Optional. A query string for filtering alert results. For more details, see [Query
            /// filters](https://developers.google.com/workspace/admin/alertcenter/guides/query-filters) and [Supported
            /// query filter
            /// fields](https://developers.google.com/workspace/admin/alertcenter/reference/filter-fields#alerts.list).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. The sort order of the list results. If not specified results may be returned in arbitrary
            /// order. You can sort the results in descending order based on the creation timestamp using
            /// `order_by="create_time desc"`. Currently, supported sorting are `create_time asc`, `create_time desc`,
            /// `update_time desc`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrderBy { get; set; }

            /// <summary>
            /// Optional. The requested page size. Server may return fewer items than requested. If unspecified, server
            /// picks an appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A token identifying a page of results the server should return. If empty, a new iteration is
            /// started. To continue an iteration, pass in the value from the previous ListAlertsResponse's
            /// next_page_token field.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/alerts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
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
            }
        }

        /// <summary>
        /// Restores, or "undeletes", an alert that was marked for deletion within the past 30 days. Attempting to
        /// undelete an alert which was marked for deletion over 30 days ago (which has been removed from the Alert
        /// Center database) or a nonexistent alert returns a `NOT_FOUND` error. Attempting to undelete an alert which
        /// has not been marked for deletion has no effect.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="alertId">Required. The identifier of the alert to undelete.</param>
        public virtual UndeleteRequest Undelete(Google.Apis.AlertCenter.v1beta1.Data.UndeleteAlertRequest body, string alertId)
        {
            return new UndeleteRequest(this.service, body, alertId);
        }

        /// <summary>
        /// Restores, or "undeletes", an alert that was marked for deletion within the past 30 days. Attempting to
        /// undelete an alert which was marked for deletion over 30 days ago (which has been removed from the Alert
        /// Center database) or a nonexistent alert returns a `NOT_FOUND` error. Attempting to undelete an alert which
        /// has not been marked for deletion has no effect.
        /// </summary>
        public class UndeleteRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.Alert>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.AlertCenter.v1beta1.Data.UndeleteAlertRequest body, string alertId) : base(service)
            {
                AlertId = alertId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The identifier of the alert to undelete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alertId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AlertId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AlertCenter.v1beta1.Data.UndeleteAlertRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/alerts/{alertId}:undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("alertId", new Google.Apis.Discovery.Parameter
                {
                    Name = "alertId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "v1beta1" collection of methods.</summary>
    public class V1beta1Resource
    {
        private const string Resource = "v1beta1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1beta1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns customer-level settings.</summary>
        public virtual GetSettingsRequest GetSettings()
        {
            return new GetSettingsRequest(this.service);
        }

        /// <summary>Returns customer-level settings.</summary>
        public class GetSettingsRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.Settings>
        {
            /// <summary>Constructs a new GetSettings request.</summary>
            public GetSettingsRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. The unique identifier of the Google Workspace account of the customer the alert settings are
            /// associated with. The `customer_id` must/ have the initial "C" stripped (for example, `046psxkn`).
            /// Inferred from the caller identity if not provided. [Find your customer
            /// ID](https://support.google.com/cloudidentity/answer/10070793).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/settings";

            /// <summary>Initializes GetSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the customer-level settings.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual UpdateSettingsRequest UpdateSettings(Google.Apis.AlertCenter.v1beta1.Data.Settings body)
        {
            return new UpdateSettingsRequest(this.service, body);
        }

        /// <summary>Updates the customer-level settings.</summary>
        public class UpdateSettingsRequest : AlertCenterBaseServiceRequest<Google.Apis.AlertCenter.v1beta1.Data.Settings>
        {
            /// <summary>Constructs a new UpdateSettings request.</summary>
            public UpdateSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.AlertCenter.v1beta1.Data.Settings body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Optional. The unique identifier of the Google Workspace account of the customer the alert settings are
            /// associated with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`).
            /// Inferred from the caller identity if not provided. [Find your customer
            /// ID](https://support.google.com/cloudidentity/answer/10070793).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AlertCenter.v1beta1.Data.Settings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/settings";

            /// <summary>Initializes UpdateSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.AlertCenter.v1beta1.Data
{
    /// <summary>A generic alert for abusive user activity occurring with a customer.</summary>
    public class AbuseDetected : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of abusive users/entities to be displayed in a table in the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalDetails")]
        public virtual EntityList AdditionalDetails { get; set; }

        /// <summary>Product that the abuse is originating from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>Unique identifier of each sub alert that is onboarded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subAlertId")]
        public virtual string SubAlertId { get; set; }

        /// <summary>
        /// Variation of AbuseDetected alerts. The variation_type determines the texts displayed the alert details. This
        /// differs from sub_alert_id because each sub alert can have multiple variation_types, representing different
        /// stages of the alert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variationType")]
        public virtual string VariationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alert that is triggered when Google support requests to access customer data.</summary>
    public class AccessApproval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Justification for data access based on justification enums.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justificationReason")]
        public virtual System.Collections.Generic.IList<string> JustificationReason { get; set; }

        /// <summary>Office location of Google staff requesting access such as "US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("officeLocation")]
        public virtual string OfficeLocation { get; set; }

        /// <summary>Products within scope of the Access Approvals request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<string> Products { get; set; }

        /// <summary>
        /// ID of the Access Approvals request. This is a helpful field when requesting support from Google.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestId")]
        public virtual string RequestId { get; set; }

        /// <summary>
        /// Scope of access, also known as a resource. This is further narrowed down by the product field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// Support tickets related to this Access Approvals request. Populated if there is an associated case number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tickets")]
        public virtual System.Collections.Generic.IList<SupportTicket> Tickets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about why an account is receiving an account suspension warning.</summary>
    public class AccountSuspensionDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason why this account is receiving an account suspension warning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abuseReason")]
        public virtual string AbuseReason { get; set; }

        /// <summary>
        /// The name of the product being abused. This is restricted to only the following values: "Gmail" "Google
        /// Workspace" "Payments" "Voice" "YouTube" "Other"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productName")]
        public virtual string ProductName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A warning that the customer's account is about to be suspended.</summary>
    public class AccountSuspensionWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The amount of time remaining to appeal an imminent suspension. After this window has elapsed, the account
        /// will be suspended. Only populated if the account suspension is in WARNING state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appealWindow")]
        public virtual object AppealWindow { get; set; }

        /// <summary>Account suspension warning state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Details about why an account is being suspended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionDetails")]
        public virtual System.Collections.Generic.IList<AccountSuspensionDetails> SuspensionDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alerts for user account warning events.</summary>
    public class AccountWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The email of the user that this event belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Optional. Details of the login action associated with the warning event. This is only available for: *
        /// Suspicious login * Suspicious login (less secure app) * Suspicious programmatic login * User suspended
        /// (suspicious activity)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginDetails")]
        public virtual LoginDetails LoginDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata related to the action.</summary>
    public class ActionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alerts from Google Workspace Security Center rules service configured by an admin.</summary>
    public class ActivityRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of action names associated with the rule threshold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionNames")]
        public virtual System.Collections.Generic.IList<string> ActionNames { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Rule create timestamp.</summary>
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

        /// <summary>Description of the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Alert display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Rule name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Query that is used to get the data from the associated source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// List of alert IDs superseded by this alert. It is used to indicate that this alert is essentially extension
        /// of superseded alerts and we found the relationship after creating these alerts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supersededAlerts")]
        public virtual System.Collections.Generic.IList<string> SupersededAlerts { get; set; }

        /// <summary>
        /// Alert ID superseding this alert. It is used to indicate that superseding alert is essentially extension of
        /// this alert and we found the relationship after creating both alerts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supersedingAlert")]
        public virtual string SupersedingAlert { get; set; }

        /// <summary>Alert threshold is for example “COUNT &gt; 5”.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threshold")]
        public virtual string Threshold { get; set; }

        /// <summary>The trigger sources for this rule. * GMAIL_EVENTS * DEVICE_EVENTS * USER_EVENTS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerSource")]
        public virtual string TriggerSource { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The timestamp of the last update to the rule.</summary>
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

        /// <summary>Rule window size. Possible values are 1 hour or 24 hours.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowSize")]
        public virtual object WindowSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An alert affecting a customer.</summary>
    public class Alert : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique identifier for the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertId")]
        public virtual string AlertId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time this alert was created.</summary>
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

        /// <summary>Output only. The unique identifier of the Google Workspace account of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>
        /// Optional. The data associated with this alert, for example google.apps.alertcenter.type.DeviceCompromised.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IDictionary<string, object> Data { get; set; }

        /// <summary>Output only. `True` if this alert is marked for deletion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Optional. The time the event that caused this alert ceased being active. If provided, the end time must not
        /// be earlier than the start time. If not provided, it indicates an ongoing alert.
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

        /// <summary>
        /// Optional. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// an alert from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform alert updates in order to avoid race conditions: An `etag` is returned in
        /// the response which contains alerts, and systems are expected to put that etag in the request to update alert
        /// to ensure that their change will be applied to the same version of the alert. If no `etag` is provided in
        /// the call to update alert, then the existing alert is overwritten blindly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. The metadata associated with this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual AlertMetadata Metadata { get; set; }

        /// <summary>
        /// Output only. An optional [Security Investigation Tool](https://support.google.com/a/answer/7575955) query
        /// for this alert.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityInvestigationToolLink")]
        public virtual string SecurityInvestigationToolLink { get; set; }

        /// <summary>
        /// Required. A unique identifier for the system that reported the alert. This is output only after alert is
        /// created. Supported sources are any of the following: * Google Operations * Mobile device management * Gmail
        /// phishing * Data Loss Prevention * Domain wide takeout * State sponsored attack * Google identity * Apps
        /// outage
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. The time the event that caused this alert was started or detected.</summary>
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

        /// <summary>
        /// Required. The type of the alert. This is output only after alert is created. For a list of available alert
        /// types see [Google Workspace Alert
        /// types](https://developers.google.com/workspace/admin/alertcenter/reference/alert-types).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time this alert was last updated.</summary>
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

    /// <summary>A customer feedback about an alert.</summary>
    public class AlertFeedback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The alert identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertId")]
        public virtual string AlertId { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time this feedback was created.</summary>
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

        /// <summary>Output only. The unique identifier of the Google Workspace account of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>Output only. The email of the user that provided the feedback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Output only. The unique identifier for the feedback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedbackId")]
        public virtual string FeedbackId { get; set; }

        /// <summary>Required. The type of the feedback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An alert metadata.</summary>
    public class AlertMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The alert identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertId")]
        public virtual string AlertId { get; set; }

        /// <summary>The email address of the user assigned to the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignee")]
        public virtual string Assignee { get; set; }

        /// <summary>Output only. The unique identifier of the Google Workspace account of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>
        /// Optional. `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// an alert metadata from overwriting each other. It is strongly suggested that systems make use of the `etag`
        /// in the read-modify-write cycle to perform metadata updates in order to avoid race conditions: An `etag` is
        /// returned in the response which contains alert metadata, and systems are expected to put that etag in the
        /// request to update alert metadata to ensure that their change will be applied to the same version of the
        /// alert metadata. If no `etag` is provided in the call to update alert metadata, then the existing alert
        /// metadata is overwritten blindly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The severity value of the alert. Alert Center will set this field at alert creation time, default's to an
        /// empty string when it could not be determined. The supported values for update actions on this field are the
        /// following: * HIGH * MEDIUM * LOW
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// The current status of the alert. The supported values are the following: * NOT_STARTED * IN_PROGRESS *
        /// CLOSED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time this metadata was last updated.</summary>
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

    /// <summary>
    /// The explanation message associated with "APNS certificate is expiring soon" and "APNS certificate has expired"
    /// alerts.
    /// </summary>
    public class ApnsCertificateExpirationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Apple ID used to create the certificate. It may be blank if admins didn't enter it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appleId")]
        public virtual string AppleId { get; set; }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>The expiration date of the APNS certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The UID of the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alerts from App Maker to notify admins to set up default SQL instance.</summary>
    public class AppMakerSqlSetupNotification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of applications with requests for default SQL set up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestInfo")]
        public virtual System.Collections.Generic.IList<RequestInfo> RequestInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Alerts from AppSettingsChanged bucket Rules configured by Admin which contain the following rules: - Calendar
    /// settings changed - Drive settings changed - Email settings changed - Mobile settings changed
    /// </summary>
    public class AppSettingsChanged : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any other associated alert details, for example, AlertConfiguration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertDetails")]
        public virtual string AlertDetails { get; set; }

        /// <summary>Rule name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An outage incident reported for a Google Workspace service.</summary>
    public class AppsOutage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link to the outage event in Google Workspace Status Dashboard</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dashboardUri")]
        public virtual string DashboardUri { get; set; }

        /// <summary>Incident tracking ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("incidentTrackingId")]
        public virtual string IncidentTrackingId { get; set; }

        /// <summary>
        /// Indicates new alert details under which the outage is communicated. Only populated when Status is MERGED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeInfo")]
        public virtual MergeInfo MergeInfo { get; set; }

        private string _nextUpdateTimeRaw;

        private object _nextUpdateTime;

        /// <summary>Timestamp by which the next update is expected to arrive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextUpdateTime")]
        public virtual string NextUpdateTimeRaw
        {
            get => _nextUpdateTimeRaw;
            set
            {
                _nextUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _nextUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="NextUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use NextUpdateTimeDateTimeOffset instead.")]
        public virtual object NextUpdateTime
        {
            get => _nextUpdateTime;
            set
            {
                _nextUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _nextUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="NextUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? NextUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(NextUpdateTimeRaw);
            set => NextUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>List of products impacted by the outage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<string> Products { get; set; }

        private string _resolutionTimeRaw;

        private object _resolutionTime;

        /// <summary>
        /// Timestamp when the outage is expected to be resolved, or has confirmed resolution. Provided only when known.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolutionTime")]
        public virtual string ResolutionTimeRaw
        {
            get => _resolutionTimeRaw;
            set
            {
                _resolutionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _resolutionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ResolutionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ResolutionTimeDateTimeOffset instead.")]
        public virtual object ResolutionTime
        {
            get => _resolutionTime;
            set
            {
                _resolutionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _resolutionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ResolutionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ResolutionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ResolutionTimeRaw);
            set => ResolutionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Current outage status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Attachment with application-specific information about an alert.</summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A CSV file attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("csv")]
        public virtual Csv Csv { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Alert for setting the domain or IP that malicious email comes from as whitelisted domain or IP in Gmail advanced
    /// settings.
    /// </summary>
    public class BadWhitelist : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainId")]
        public virtual DomainId DomainId { get; set; }

        /// <summary>The entity whose actions triggered a Gmail phishing alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maliciousEntity")]
        public virtual MaliciousEntity MaliciousEntity { get; set; }

        /// <summary>The list of messages contained by this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GmailMessageInfo> Messages { get; set; }

        /// <summary>The source IP address of the malicious email, for example, `127.0.0.1`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to perform batch delete on alerts.</summary>
    public class BatchDeleteAlertsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of alert IDs to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertId")]
        public virtual System.Collections.Generic.IList<string> AlertId { get; set; }

        /// <summary>
        /// Optional. The unique identifier of the Google Workspace account of the customer the alerts are associated
        /// with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`). Inferred from the
        /// caller identity if not provided. [Find your customer
        /// ID](https://support.google.com/cloudidentity/answer/10070793).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to batch delete operation on alerts.</summary>
    public class BatchDeleteAlertsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status details for each failed `alert_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedAlertStatus")]
        public virtual System.Collections.Generic.IDictionary<string, Status> FailedAlertStatus { get; set; }

        /// <summary>The successful list of alert IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successAlertIds")]
        public virtual System.Collections.Generic.IList<string> SuccessAlertIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to perform batch undelete on alerts.</summary>
    public class BatchUndeleteAlertsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of alert IDs to undelete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertId")]
        public virtual System.Collections.Generic.IList<string> AlertId { get; set; }

        /// <summary>
        /// Optional. The unique identifier of the Google Workspace account of the customer the alerts are associated
        /// with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`). Inferred from the
        /// caller identity if not provided. [Find your customer
        /// ID](https://support.google.com/cloudidentity/answer/10070793).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to batch undelete operation on alerts.</summary>
    public class BatchUndeleteAlertsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status details for each failed `alert_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedAlertStatus")]
        public virtual System.Collections.Generic.IDictionary<string, Status> FailedAlertStatus { get; set; }

        /// <summary>The successful list of alert IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successAlertIds")]
        public virtual System.Collections.Generic.IList<string> SuccessAlertIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A reference to a Cloud Pubsub topic. To register for notifications, the owner of the topic must grant
    /// `alerts-api-push-notifications@system.gserviceaccount.com` the `projects.topics.publish` permission.
    /// </summary>
    public class CloudPubsubTopic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The format of the payload that would be sent. If not specified the format will be JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payloadFormat")]
        public virtual string PayloadFormat { get; set; }

        /// <summary>
        /// The `name` field of a Cloud Pubsub [Topic]
        /// (https://cloud.google.com/pubsub/docs/reference/rest/v1/projects.topics#Topic).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A representation of a CSV file attachment, as a list of column headers and a list of data rows.
    /// </summary>
    public class Csv : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of data rows in a CSV file, as string arrays rather than as a single comma-separated string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRows")]
        public virtual System.Collections.Generic.IList<CsvRow> DataRows { get; set; }

        /// <summary>The list of headers for data columns in a CSV file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<string> Headers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a single data row in a CSV file.</summary>
    public class CsvRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data entries in a CSV file row, as a string array rather than a single comma-separated string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entries")]
        public virtual System.Collections.Generic.IList<string> Entries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A mobile device compromised alert. Derived from audit logs.</summary>
    public class DeviceCompromised : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email of the user this alert was created for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Required. The list of security events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<DeviceCompromisedSecurityDetail> Events { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed information of a single MDM device compromised event.</summary>
    public class DeviceCompromisedSecurityDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device compromised state. Possible values are "`Compromised`" or "`Not Compromised`".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceCompromisedState")]
        public virtual string DeviceCompromisedState { get; set; }

        /// <summary>Required. The device ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>The model of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceModel")]
        public virtual string DeviceModel { get; set; }

        /// <summary>The type of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>Required for iOS, empty for others.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosVendorId")]
        public virtual string IosVendorId { get; set; }

        /// <summary>The device resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The serial number of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alerts from Device Management Rules configured by Admin.</summary>
    public class DeviceManagementRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The device ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>The model of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceModel")]
        public virtual string DeviceModel { get; set; }

        /// <summary>The type of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>The email of the user this alert was created for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>ID of the rule that triggered the alert</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required for iOS, empty for others.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosVendorId")]
        public virtual string IosVendorId { get; set; }

        /// <summary>Obfuscated ID of the owner of the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerId")]
        public virtual string OwnerId { get; set; }

        /// <summary>The device resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>Action taken as result of the rule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleAction")]
        public virtual string RuleAction { get; set; }

        /// <summary>The serial number of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alerts that get triggered on violations of Data Loss Prevention (DLP) rules.</summary>
    public class DlpRuleViolation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Details about the violated DLP rule. Admins can use the predefined detectors provided by Google Cloud DLP
        /// https://cloud.google.com/dlp/ when setting up a DLP rule. Matched Cloud DLP detectors in this violation if
        /// any will be captured in the MatchInfo.predefined_detector.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleViolationInfo")]
        public virtual RuleViolationInfo RuleViolationInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Domain ID of Gmail phishing alerts.</summary>
    public class DomainId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The primary domain for the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerPrimaryDomain")]
        public virtual string CustomerPrimaryDomain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A takeout operation for the entire domain was initiated by an admin. Derived from audit logs.</summary>
    public class DomainWideTakeoutInitiated : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email of the admin who initiated the takeout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The takeout request ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("takeoutRequestId")]
        public virtual string TakeoutRequestId { get; set; }

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

    /// <summary>Individual entity affected by, or related to, an alert.</summary>
    public class Entity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link to a Security Investigation Tool search based on this entity, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>Human-readable name of this entity, such as an email address, file ID, or device name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Extra values beyond name. The order of values should align with headers in EntityList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EntityList stores entities in a format that can be translated to a table in the Alert Center UI.
    /// </summary>
    public class EntityList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of entities affected by the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<Entity> Entities { get; set; }

        /// <summary>
        /// Headers of the values in entities. If no value is defined in Entity, this field should be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<string> Headers { get; set; }

        /// <summary>Name of the key detail used to display this entity list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a message in phishing spike alert.</summary>
    public class GmailMessageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `SHA256` hash of email's attachment and all MIME parts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentsSha256Hash")]
        public virtual System.Collections.Generic.IList<string> AttachmentsSha256Hash { get; set; }

        private string _dateRaw;

        private object _date;

        /// <summary>The date of the event related to this email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string DateRaw
        {
            get => _dateRaw;
            set
            {
                _date = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _dateRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DateDateTimeOffset instead.")]
        public virtual object Date
        {
            get => _date;
            set
            {
                _dateRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _date = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DateDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DateRaw);
            set => DateRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The hash of the message body text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5HashMessageBody")]
        public virtual string Md5HashMessageBody { get; set; }

        /// <summary>The MD5 Hash of email's subject (only available for reported emails).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5HashSubject")]
        public virtual string Md5HashSubject { get; set; }

        /// <summary>The snippet of the message body text (only available for reported emails).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageBodySnippet")]
        public virtual string MessageBodySnippet { get; set; }

        /// <summary>The message ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; }

        /// <summary>The recipient of this email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipient")]
        public virtual string Recipient { get; set; }

        private string _sentTimeRaw;

        private object _sentTime;

        /// <summary>The sent time of the email.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentTime")]
        public virtual string SentTimeRaw
        {
            get => _sentTimeRaw;
            set
            {
                _sentTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _sentTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SentTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SentTimeDateTimeOffset instead.")]
        public virtual object SentTime
        {
            get => _sentTime;
            set
            {
                _sentTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _sentTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SentTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SentTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SentTimeRaw);
            set => SentTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The email subject text (only available for reported emails).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjectText")]
        public virtual string SubjectText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An incident reported by Google Operations for a Google Workspace application.</summary>
    public class GoogleOperations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of emails which correspond to the users directly affected by the incident.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedUserEmails")]
        public virtual System.Collections.Generic.IList<string> AffectedUserEmails { get; set; }

        /// <summary>
        /// Optional. Application-specific data for an incident, provided when the Google Workspace application which
        /// reported the incident cannot be completely restored to a valid state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachmentData")]
        public virtual Attachment AttachmentData { get; set; }

        /// <summary>A detailed, freeform incident description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Customer domain for email template personalization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>
        /// A header to display above the incident message. Typically used to attach a localized notice on the timeline
        /// for followup comms translations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; }

        /// <summary>A one-line incident description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for an alert feedback listing request.</summary>
    public class ListAlertFeedbackResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of alert feedback. Feedback entries for each alert are ordered by creation time descending.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedback")]
        public virtual System.Collections.Generic.IList<AlertFeedback> Feedback { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for an alert listing request.</summary>
    public class ListAlertsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of alerts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alerts")]
        public virtual System.Collections.Generic.IList<Alert> Alerts { get; set; }

        /// <summary>
        /// The token for the next page. If not empty, indicates that there may be more alerts that match the listing
        /// request; this value can be used in a subsequent ListAlertsRequest to get alerts continuing from last result
        /// of the current list call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of the login action.</summary>
    public class LoginDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The human-readable IP address (for example, `11.22.33.44`) that is associated with the warning
        /// event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        private string _loginTimeRaw;

        private object _loginTime;

        /// <summary>
        /// Optional. The successful login time that is associated with the warning event. This isn't present for
        /// blocked login attempts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("loginTime")]
        public virtual string LoginTimeRaw
        {
            get => _loginTimeRaw;
            set
            {
                _loginTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _loginTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LoginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LoginTimeDateTimeOffset instead.")]
        public virtual object LoginTime
        {
            get => _loginTime;
            set
            {
                _loginTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _loginTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LoginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LoginTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LoginTimeRaw);
            set => LoginTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Proto for all phishing alerts with common payload. Supported types are any of the following: * User reported
    /// phishing * User reported spam spike * Suspicious message reported * Phishing reclassification * Malware
    /// reclassification * Gmail potential employee spoofing
    /// </summary>
    public class MailPhishing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainId")]
        public virtual DomainId DomainId { get; set; }

        /// <summary>If `true`, the email originated from within the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInternal")]
        public virtual System.Nullable<bool> IsInternal { get; set; }

        /// <summary>The entity whose actions triggered a Gmail phishing alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maliciousEntity")]
        public virtual MaliciousEntity MaliciousEntity { get; set; }

        /// <summary>The list of messages contained by this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GmailMessageInfo> Messages { get; set; }

        /// <summary>System actions on the messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemActionType")]
        public virtual string SystemActionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Entity whose actions triggered a Gmail phishing alert.</summary>
    public class MaliciousEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The header from display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The actor who triggered a gmail phishing alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual User Entity { get; set; }

        /// <summary>The sender email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromHeader")]
        public virtual string FromHeader { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Alert Created by the MSA team for communications necessary for continued use of Google Workspace Products.
    /// </summary>
    public class MandatoryServiceAnnouncement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed, freeform text describing the announcement</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>One line summary of the announcement</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto that contains match information from the condition part of the rule.</summary>
    public class MatchInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For matched detector predefined by Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predefinedDetector")]
        public virtual PredefinedDetectorInfo PredefinedDetector { get; set; }

        /// <summary>For matched detector defined by administrators.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefinedDetector")]
        public virtual UserDefinedDetectorInfo UserDefinedDetector { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>New alert tracking numbers.</summary>
    public class MergeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. New alert ID. Reference the [google.apps.alertcenter.Alert] with this ID for the current state.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newAlertId")]
        public virtual string NewAlertId { get; set; }

        /// <summary>The new tracking ID from the parent incident.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newIncidentTrackingId")]
        public virtual string NewIncidentTrackingId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings for callback notifications. For more details see [Google Workspace Alert
    /// Notification](https://developers.google.com/workspace/admin/alertcenter/guides/notifications).
    /// </summary>
    public class Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Google Cloud Pub/sub topic destination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudPubsubTopic")]
        public virtual CloudPubsubTopic CloudPubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Alert for a spike in user reported phishing. *Warning*: This type has been deprecated. Use
    /// [MailPhishing](https://developers.google.com/workspace/admin/alertcenter/reference/rest/v1beta1/MailPhishing)
    /// instead.
    /// </summary>
    public class PhishingSpike : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainId")]
        public virtual DomainId DomainId { get; set; }

        /// <summary>If `true`, the email originated from within the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isInternal")]
        public virtual System.Nullable<bool> IsInternal { get; set; }

        /// <summary>The entity whose actions triggered a Gmail phishing alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maliciousEntity")]
        public virtual MaliciousEntity MaliciousEntity { get; set; }

        /// <summary>The list of messages contained by this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GmailMessageInfo> Messages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detector provided by Google.</summary>
    public class PredefinedDetectorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name that uniquely identifies the detector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectorName")]
        public virtual string DetectorName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event occurred when primary admin changed in customer's account. The event are being received from insight
    /// forwarder
    /// </summary>
    public class PrimaryAdminChangedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>domain in which actioned occurred</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>Email of person who was the primary admin before the action</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousAdminEmail")]
        public virtual string PreviousAdminEmail { get; set; }

        /// <summary>Email of person who is the primary admin after the action</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedAdminEmail")]
        public virtual string UpdatedAdminEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alerts from Reporting Rules configured by Admin.</summary>
    public class ReportingRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Any other associated alert details, for example, AlertConfiguration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertDetails")]
        public virtual string AlertDetails { get; set; }

        /// <summary>Rule name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Alert Rule query Sample Query query { condition { filter { expected_application_id: 777491262838
        /// expected_event_name: "indexable_content_change" filter_op: IN } } conjunction_operator: OR }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Requests for one application that needs default SQL setup.</summary>
    public class RequestInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of app developers who triggered notifications for above application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appDeveloperEmail")]
        public virtual System.Collections.Generic.IList<string> AppDeveloperEmail { get; set; }

        /// <summary>Required. The application that requires the SQL setup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appKey")]
        public virtual string AppKey { get; set; }

        /// <summary>Required. Number of requests sent for this application to set up default SQL instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberOfRequests")]
        public virtual System.Nullable<long> NumberOfRequests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto that contains resource information.</summary>
    public class ResourceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Chat attachment ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatAttachmentId")]
        public virtual string ChatAttachmentId { get; set; }

        /// <summary>Chat message ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chatMessageId")]
        public virtual string ChatMessageId { get; set; }

        /// <summary>
        /// Id to identify a device. For example, for Android devices, this is the "Android Device Id" and for Chrome OS
        /// devices, it's the "Device Virtual Id".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>Drive file ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>Title of the resource, for example email subject, or document title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTitle")]
        public virtual string ResourceTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Proto that contains rule information.</summary>
    public class RuleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User provided name of the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource name that uniquely identifies the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Common alert information about violated rules that are configured by Google Workspace administrators.
    /// </summary>
    public class RuleViolationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual string DataSource { get; set; }

        /// <summary>Event associated with this alert after applying the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>List of matches that were found in the resource content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchInfo")]
        public virtual System.Collections.Generic.IList<MatchInfo> MatchInfo { get; set; }

        /// <summary>
        /// Resource recipients. For Drive, they are grantees that the Drive file was shared with at the time of rule
        /// triggering. Valid values include user emails, group emails, domains, or 'anyone' if the file was publicly
        /// accessible. If the file was private the recipients list will be empty. For Gmail, they are emails of the
        /// users or groups that the Gmail message was sent to.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipients")]
        public virtual System.Collections.Generic.IList<string> Recipients { get; set; }

        /// <summary>Details of the resource which violated the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceInfo")]
        public virtual ResourceInfo ResourceInfo { get; set; }

        /// <summary>Details of the violated rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleInfo")]
        public virtual RuleInfo RuleInfo { get; set; }

        /// <summary>Actions suppressed due to other actions with higher priority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suppressedActionTypes")]
        public virtual System.Collections.Generic.IList<string> SuppressedActionTypes { get; set; }

        /// <summary>Trigger of the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
        public virtual string Trigger { get; set; }

        /// <summary>Metadata related to the triggered actions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggeredActionInfo")]
        public virtual System.Collections.Generic.IList<ActionInfo> TriggeredActionInfo { get; set; }

        /// <summary>Actions applied as a consequence of the rule being triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggeredActionTypes")]
        public virtual System.Collections.Generic.IList<string> TriggeredActionTypes { get; set; }

        /// <summary>
        /// Email of the user who caused the violation. Value could be empty if not applicable, for example, a violation
        /// found by drive continuous scan.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggeringUserEmail")]
        public virtual string TriggeringUserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event occurred when SSO Profile created in customer's account. The event are being received from insight
    /// forwarder
    /// </summary>
    public class SSOProfileCreatedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>sso profile name which got created</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inboundSsoProfileName")]
        public virtual string InboundSsoProfileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event occurred when SSO Profile deleted in customer's account. The event are being received from insight
    /// forwarder
    /// </summary>
    public class SSOProfileDeletedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>sso profile name which got deleted</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inboundSsoProfileName")]
        public virtual string InboundSsoProfileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Event occurred when SSO Profile updated in customer's account. The event are being received from insight
    /// forwarder
    /// </summary>
    public class SSOProfileUpdatedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>changes made to sso profile</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inboundSsoProfileChanges")]
        public virtual string InboundSsoProfileChanges { get; set; }

        /// <summary>sso profile name which got updated</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inboundSsoProfileName")]
        public virtual string InboundSsoProfileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alert that is triggered when Sensitive Admin Action occur in customer account.</summary>
    public class SensitiveAdminAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email of person who performed the action</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actorEmail")]
        public virtual string ActorEmail { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>The time at which event occurred</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Event occurred when primary admin changed in customer's account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryAdminChangedEvent")]
        public virtual PrimaryAdminChangedEvent PrimaryAdminChangedEvent { get; set; }

        /// <summary>Event occurred when SSO Profile created in customer's account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssoProfileCreatedEvent")]
        public virtual SSOProfileCreatedEvent SsoProfileCreatedEvent { get; set; }

        /// <summary>Event occurred when SSO Profile deleted in customer's account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssoProfileDeletedEvent")]
        public virtual SSOProfileDeletedEvent SsoProfileDeletedEvent { get; set; }

        /// <summary>Event occurred when SSO Profile updated in customer's account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssoProfileUpdatedEvent")]
        public virtual SSOProfileUpdatedEvent SsoProfileUpdatedEvent { get; set; }

        /// <summary>Event occurred when password was reset for super admin in customer's account</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("superAdminPasswordResetEvent")]
        public virtual SuperAdminPasswordResetEvent SuperAdminPasswordResetEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer-level settings.</summary>
    public class Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifications")]
        public virtual System.Collections.Generic.IList<Notification> Notifications { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A state-sponsored attack alert. Derived from audit logs.</summary>
    public class StateSponsoredAttack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email of the user this incident was created for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

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

    /// <summary>
    /// Event occurred when password was reset for super admin in customer's account. The event are being received from
    /// insight forwarder
    /// </summary>
    public class SuperAdminPasswordResetEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>email of person whose password was reset</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Support ticket related to Access Approvals request</summary>
    public class SupportTicket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Support ticket ID</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketId")]
        public virtual string TicketId { get; set; }

        /// <summary>Link to support ticket</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ticketUrl")]
        public virtual string TicketUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A mobile suspicious activity alert. Derived from audit logs.</summary>
    public class SuspiciousActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email of the user this alert was created for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Required. The list of security events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<SuspiciousActivitySecurityDetail> Events { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed information of a single MDM suspicious activity event.</summary>
    public class SuspiciousActivitySecurityDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The device ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>The model of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceModel")]
        public virtual string DeviceModel { get; set; }

        /// <summary>The device property which was changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceProperty")]
        public virtual string DeviceProperty { get; set; }

        /// <summary>The type of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>Required for iOS, empty for others.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosVendorId")]
        public virtual string IosVendorId { get; set; }

        /// <summary>The new value of the device property after the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>The old value of the device property before the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>The device resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The serial number of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details for an invalid transfer or forward.</summary>
    public class TransferError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User's email address. This may be unavailable if the entity was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Type of entity being transferred to. For ring group members, this should always be USER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>Ring group or auto attendant ID. Not set for users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Reason for the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidReason")]
        public virtual string InvalidReason { get; set; }

        /// <summary>
        /// User's full name, or the ring group / auto attendant name. This may be unavailable if the entity was
        /// deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Error related to transferring or forwarding a phone call.</summary>
    public class TransferMisconfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details for each invalid transfer or forward.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<TransferError> Errors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to undelete a specific alert that was marked for deletion.</summary>
    public class UndeleteAlertRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The unique identifier of the Google Workspace account of the customer the alert is associated
        /// with. The `customer_id` must have the initial "C" stripped (for example, `046psxkn`). Inferred from the
        /// caller identity if not provided. [Find your customer
        /// ID](https://support.google.com/cloudidentity/answer/10070793).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Email address of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Alerts from UserChanges bucket Rules for predefined rules which contain the following rules: - Suspended user
    /// made active - New user added - User suspended (by admin) - User granted admin privileges - User admin privileges
    /// revoked - User deleted - Users password changed
    /// </summary>
    public class UserChanges : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rule name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detector defined by administrators.</summary>
    public class UserDefinedDetectorInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the detector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Resource name that uniquely identifies the detector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alert that is triggered when a Vault accelerated deletion request is created or canceled.</summary>
    public class VaultAcceleratedDeletion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action can be one of create and cancel</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionType")]
        public virtual string ActionType { get; set; }

        /// <summary>Currentlty only Gmail is supported as app type</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appType")]
        public virtual string AppType { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The UTC timestamp of when the AD request was created</summary>
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
        /// Accelerated deletion request ID intended to be used to construct the Vault UI link to the AD request
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionRequestId")]
        public virtual string DeletionRequestId { get; set; }

        /// <summary>
        /// Matter ID of the accelerated deletion request intended to be used to construct the Vault UI link to the AD
        /// request
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matterId")]
        public virtual string MatterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An alert triggered when Google Voice configuration becomes invalid, generally due to an external entity being
    /// modified or deleted.
    /// </summary>
    public class VoiceMisconfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the entity whose configuration is now invalid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityName")]
        public virtual string EntityName { get; set; }

        /// <summary>Type of the entity whose configuration is now invalid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; }

        /// <summary>Link that the admin can follow to fix the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixUri")]
        public virtual string FixUri { get; set; }

        /// <summary>Issue(s) with members of a ring group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membersMisconfiguration")]
        public virtual TransferMisconfiguration MembersMisconfiguration { get; set; }

        /// <summary>Issue(s) with transferring or forwarding to an external entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transferMisconfiguration")]
        public virtual TransferMisconfiguration TransferMisconfiguration { get; set; }

        /// <summary>Issue(s) with sending to voicemail.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voicemailMisconfiguration")]
        public virtual VoicemailMisconfiguration VoicemailMisconfiguration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Issue(s) with sending to voicemail.</summary>
    public class VoicemailMisconfiguration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Issue(s) with voicemail recipients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<VoicemailRecipientError> Errors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Issue(s) with a voicemail recipient.</summary>
    public class VoicemailRecipientError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Email address of the invalid recipient. This may be unavailable if the recipient was deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Reason for the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidReason")]
        public virtual string InvalidReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
