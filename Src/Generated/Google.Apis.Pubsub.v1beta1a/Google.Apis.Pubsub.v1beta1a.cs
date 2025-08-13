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

namespace Google.Apis.Pubsub.v1beta1a
{
    /// <summary>The Pubsub Service.</summary>
    public class PubsubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1a";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PubsubService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PubsubService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Subscriptions = new SubscriptionsResource(this);
            Topics = new TopicsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://pubsub.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://pubsub.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "pubsub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Pub/Sub API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Pub/Sub topics and subscriptions</summary>
            public static string Pubsub = "https://www.googleapis.com/auth/pubsub";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Pub/Sub API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Pub/Sub topics and subscriptions</summary>
            public const string Pubsub = "https://www.googleapis.com/auth/pubsub";
        }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

        /// <summary>Gets the Topics resource.</summary>
        public virtual TopicsResource Topics { get; }
    }

    /// <summary>A base abstract class for Pubsub requests.</summary>
    public abstract class PubsubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PubsubBaseServiceRequest instance.</summary>
        protected PubsubBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Pubsub parameter list.</summary>
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

    /// <summary>The "subscriptions" collection of methods.</summary>
    public class SubscriptionsResource
    {
        private const string Resource = "subscriptions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SubscriptionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Acknowledges a particular received message: the Pub/Sub system can remove the given message from the
        /// subscription. Acknowledging a message whose Ack deadline has expired may succeed, but the message could have
        /// been already redelivered. Acknowledging a message more than once will not result in an error. This is only
        /// used for messages received via pull.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual AcknowledgeRequest Acknowledge(Google.Apis.Pubsub.v1beta1a.Data.AcknowledgeRequest body)
        {
            return new AcknowledgeRequest(this.service, body);
        }

        /// <summary>
        /// Acknowledges a particular received message: the Pub/Sub system can remove the given message from the
        /// subscription. Acknowledging a message whose Ack deadline has expired may succeed, but the message could have
        /// been already redelivered. Acknowledging a message more than once will not result in an error. This is only
        /// used for messages received via pull.
        /// </summary>
        public class AcknowledgeRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Empty>
        {
            /// <summary>Constructs a new Acknowledge request.</summary>
            public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.AcknowledgeRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.AcknowledgeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "acknowledge";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions/acknowledge";

            /// <summary>Initializes Acknowledge parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Creates a subscription on a given topic for a given subscriber. If the subscription already exists, returns
        /// ALREADY_EXISTS. If the corresponding topic doesn't exist, returns NOT_FOUND. If the name is not provided in
        /// the request, the server will assign a random name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Pubsub.v1beta1a.Data.Subscription body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>
        /// Creates a subscription on a given topic for a given subscriber. If the subscription already exists, returns
        /// ALREADY_EXISTS. If the corresponding topic doesn't exist, returns NOT_FOUND. If the name is not provided in
        /// the request, the server will assign a random name for this subscription on the same project as the topic.
        /// </summary>
        public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Subscription>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.Subscription body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.Subscription Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription are immediately dropped. Calls to
        /// Pull after deletion will return NOT_FOUND.
        /// </summary>
        /// <param name="subscription">The subscription to delete.</param>
        public virtual DeleteRequest Delete(string subscription)
        {
            return new DeleteRequest(this.service, subscription);
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription are immediately dropped. Calls to
        /// Pull after deletion will return NOT_FOUND.
        /// </summary>
        public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string subscription) : base(service)
            {
                Subscription = subscription;
                InitParameters();
            }

            /// <summary>The subscription to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Subscription { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions/{+subscription}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscription",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Gets the configuration details of a subscription.</summary>
        /// <param name="subscription">The name of the subscription to get.</param>
        public virtual GetRequest Get(string subscription)
        {
            return new GetRequest(this.service, subscription);
        }

        /// <summary>Gets the configuration details of a subscription.</summary>
        public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Subscription>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string subscription) : base(service)
            {
                Subscription = subscription;
                InitParameters();
            }

            /// <summary>The name of the subscription to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Subscription { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions/{+subscription}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                {
                    Name = "subscription",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Lists matching subscriptions.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists matching subscriptions.</summary>
        public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.ListSubscriptionsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of subscriptions to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The value obtained in the last ListSubscriptionsResponse for continuation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>A valid label query expression.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Modifies the Ack deadline for a message received from a pull request.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual ModifyAckDeadlineRequest ModifyAckDeadline(Google.Apis.Pubsub.v1beta1a.Data.ModifyAckDeadlineRequest body)
        {
            return new ModifyAckDeadlineRequest(this.service, body);
        }

        /// <summary>Modifies the Ack deadline for a message received from a pull request.</summary>
        public class ModifyAckDeadlineRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Empty>
        {
            /// <summary>Constructs a new ModifyAckDeadline request.</summary>
            public ModifyAckDeadlineRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.ModifyAckDeadlineRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.ModifyAckDeadlineRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "modifyAckDeadline";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions/modifyAckDeadline";

            /// <summary>Initializes ModifyAckDeadline parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Modifies the PushConfig for a specified subscription. This method can be used to suspend the flow of
        /// messages to an endpoint by clearing the PushConfig field in the request. Messages will be accumulated for
        /// delivery even if no push configuration is defined or while the configuration is modified.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual ModifyPushConfigRequest ModifyPushConfig(Google.Apis.Pubsub.v1beta1a.Data.ModifyPushConfigRequest body)
        {
            return new ModifyPushConfigRequest(this.service, body);
        }

        /// <summary>
        /// Modifies the PushConfig for a specified subscription. This method can be used to suspend the flow of
        /// messages to an endpoint by clearing the PushConfig field in the request. Messages will be accumulated for
        /// delivery even if no push configuration is defined or while the configuration is modified.
        /// </summary>
        public class ModifyPushConfigRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Empty>
        {
            /// <summary>Constructs a new ModifyPushConfig request.</summary>
            public ModifyPushConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.ModifyPushConfigRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.ModifyPushConfigRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "modifyPushConfig";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions/modifyPushConfig";

            /// <summary>Initializes ModifyPushConfig parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Pulls a single message from the server. If return_immediately is true, and no messages are available in the
        /// subscription, this method returns FAILED_PRECONDITION. The system is free to return an UNAVAILABLE error if
        /// no messages are available in a reasonable amount of time (to reduce system load).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual PullRequest Pull(Google.Apis.Pubsub.v1beta1a.Data.PullRequest body)
        {
            return new PullRequest(this.service, body);
        }

        /// <summary>
        /// Pulls a single message from the server. If return_immediately is true, and no messages are available in the
        /// subscription, this method returns FAILED_PRECONDITION. The system is free to return an UNAVAILABLE error if
        /// no messages are available in a reasonable amount of time (to reduce system load).
        /// </summary>
        public class PullRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.PullResponse>
        {
            /// <summary>Constructs a new Pull request.</summary>
            public PullRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.PullRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.PullRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "pull";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions/pull";

            /// <summary>Initializes Pull parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no messages available in the backlog. The
        /// system is free to return UNAVAILABLE if there are too many pull requests outstanding for the given
        /// subscription.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual PullBatchRequest PullBatch(Google.Apis.Pubsub.v1beta1a.Data.PullBatchRequest body)
        {
            return new PullBatchRequest(this.service, body);
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no messages available in the backlog. The
        /// system is free to return UNAVAILABLE if there are too many pull requests outstanding for the given
        /// subscription.
        /// </summary>
        public class PullBatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.PullBatchResponse>
        {
            /// <summary>Constructs a new PullBatch request.</summary>
            public PullBatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.PullBatchRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.PullBatchRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "pullBatch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/subscriptions/pullBatch";

            /// <summary>Initializes PullBatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "topics" collection of methods.</summary>
    public class TopicsResource
    {
        private const string Resource = "topics";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TopicsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates the given topic with the given name.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Pubsub.v1beta1a.Data.Topic body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>Creates the given topic with the given name.</summary>
        public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Topic>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.Topic body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.Topic Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/topics";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns NOT_FOUND if the topic does not exist. After a topic is
        /// deleted, a new topic may be created with the same name.
        /// </summary>
        /// <param name="topic">Name of the topic to delete.</param>
        public virtual DeleteRequest Delete(string topic)
        {
            return new DeleteRequest(this.service, topic);
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns NOT_FOUND if the topic does not exist. After a topic is
        /// deleted, a new topic may be created with the same name.
        /// </summary>
        public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string topic) : base(service)
            {
                Topic = topic;
                InitParameters();
            }

            /// <summary>Name of the topic to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Topic { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/topics/{+topic}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                {
                    Name = "topic",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>
        /// Gets the configuration of a topic. Since the topic only has the name attribute, this method is only useful
        /// to check the existence of a topic. If other attributes are added in the future, they will be returned here.
        /// </summary>
        /// <param name="topic">The name of the topic to get.</param>
        public virtual GetRequest Get(string topic)
        {
            return new GetRequest(this.service, topic);
        }

        /// <summary>
        /// Gets the configuration of a topic. Since the topic only has the name attribute, this method is only useful
        /// to check the existence of a topic. If other attributes are added in the future, they will be returned here.
        /// </summary>
        public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Topic>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string topic) : base(service)
            {
                Topic = topic;
                InitParameters();
            }

            /// <summary>The name of the topic to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Topic { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/topics/{+topic}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                {
                    Name = "topic",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>Lists matching topics.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists matching topics.</summary>
        public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.ListTopicsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Maximum number of topics to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>The value obtained in the last ListTopicsResponse for continuation.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>A valid label query expression.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/topics";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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
                RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                {
                    Name = "query",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Adds a message to the topic. Returns NOT_FOUND if the topic does not exist.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual PublishRequest Publish(Google.Apis.Pubsub.v1beta1a.Data.PublishRequest body)
        {
            return new PublishRequest(this.service, body);
        }

        /// <summary>Adds a message to the topic. Returns NOT_FOUND if the topic does not exist.</summary>
        public class PublishRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.Empty>
        {
            /// <summary>Constructs a new Publish request.</summary>
            public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.PublishRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.PublishRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "publish";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/topics/publish";

            /// <summary>Initializes Publish parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Adds one or more messages to the topic. Returns NOT_FOUND if the topic does not exist.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual PublishBatchRequest PublishBatch(Google.Apis.Pubsub.v1beta1a.Data.PublishBatchRequest body)
        {
            return new PublishBatchRequest(this.service, body);
        }

        /// <summary>Adds one or more messages to the topic. Returns NOT_FOUND if the topic does not exist.</summary>
        public class PublishBatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta1a.Data.PublishBatchResponse>
        {
            /// <summary>Constructs a new PublishBatch request.</summary>
            public PublishBatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta1a.Data.PublishBatchRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Pubsub.v1beta1a.Data.PublishBatchRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "publishBatch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1a/topics/publishBatch";

            /// <summary>Initializes PublishBatch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Pubsub.v1beta1a.Data
{
    /// <summary>Request for the Acknowledge method.</summary>
    public class AcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The acknowledgment ID for the message being acknowledged. This was returned by the Pub/Sub system in the
        /// Pull response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackId")]
        public virtual System.Collections.Generic.IList<string> AckId { get; set; }

        /// <summary>The subscription whose message is being acknowledged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An empty message that you can re-use to avoid defining duplicated empty messages in your project. A typical
    /// example is to use it as argument or the return value of a service API. For instance: service Foo { rpc Bar
    /// (proto2.Empty) returns (proto2.Empty) { }; }; BEGIN GOOGLE-INTERNAL The difference between this one and
    /// net/rpc/empty-message.proto is that 1) The generated message here is in proto2 C++ API. 2) The proto2.Empty has
    /// minimum dependencies (no message_set or net/rpc dependencies) END GOOGLE-INTERNAL
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A key-value pair applied to a given object.</summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The key of a label is a syntactically valid URL (as per RFC 1738) with the "scheme" and initial slashes
        /// omitted and with the additional restrictions noted below. Each key should be globally unique. The "host"
        /// portion is called the "namespace" and is not necessarily resolvable to a network endpoint. Instead, the
        /// namespace indicates what system or entity defines the semantics of the label. Namespaces do not restrict the
        /// set of objects to which a label may be associated. Keys are defined by the following grammar: key = hostname
        /// "/" kpath kpath = ksegment *[ "/" ksegment ] ksegment = alphadigit | *[ alphadigit | "-" | "_" | "." ] where
        /// "hostname" and "alphadigit" are defined as in RFC 1738. Example key: spanner.google.com/universe
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>An integer value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numValue")]
        public virtual System.Nullable<long> NumValue { get; set; }

        /// <summary>A string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strValue")]
        public virtual string StrValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListSubscriptions method.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, indicates that there are more subscriptions that match the request and this value should be
        /// passed to the next ListSubscriptionsRequest to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The subscriptions that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual System.Collections.Generic.IList<Subscription> Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the ListTopics method.</summary>
    public class ListTopicsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, indicates that there are more topics that match the request, and this value should be passed
        /// to the next ListTopicsRequest to continue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting topics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual System.Collections.Generic.IList<Topic> Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the ModifyAckDeadline method.</summary>
    public class ModifyAckDeadlineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new ack deadline with respect to the time this request was sent to the Pub/Sub system. Must be &amp;gt;=
        /// 0. For example, if the value is 10, the new ack deadline will expire 10 seconds after the ModifyAckDeadline
        /// call was made. Specifying zero may immediately make the message available for another pull request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; }

        /// <summary>The acknowledgment ID. Either this or ack_ids must be populated, not both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackId")]
        public virtual string AckId { get; set; }

        /// <summary>List of acknowledgment IDs. Either this field or ack_id should be populated, not both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackIds")]
        public virtual System.Collections.Generic.IList<string> AckIds { get; set; }

        /// <summary>Next Index: 5 The name of the subscription from which messages are being pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the ModifyPushConfig method.</summary>
    public class ModifyPushConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An empty push_config indicates that the Pub/Sub system should pause pushing messages from the given
        /// subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; }

        /// <summary>The name of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the PublishBatch method.</summary>
    public class PublishBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The messages to publish.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<PubsubMessage> Messages { get; set; }

        /// <summary>The messages in the request will be published on this topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the PublishBatch method.</summary>
    public class PublishBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The server-assigned ID of each published message, in the same order as the messages in the request. IDs are
        /// guaranteed to be unique within the topic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageIds")]
        public virtual System.Collections.Generic.IList<string> MessageIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the Publish method.</summary>
    public class PublishRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message to publish.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual PubsubMessage Message { get; set; }

        /// <summary>The message in the request will be published on this topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event indicating a received message or truncation event.</summary>
    public class PubsubEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Indicates that this subscription has been deleted. (Note that pull subscribers will always receive NOT_FOUND
        /// in response in their pull request on the subscription, rather than seeing this boolean.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Nullable<bool> Deleted { get; set; }

        /// <summary>A received message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual PubsubMessage Message { get; set; }

        /// <summary>The subscription that received the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>Indicates that this subscription has been truncated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("truncated")]
        public virtual System.Nullable<bool> Truncated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message data and its labels.</summary>
    public class PubsubMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The message payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>Optional list of labels for this message. Keys in this collection must be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual System.Collections.Generic.IList<Label> Label { get; set; }

        /// <summary>
        /// ID of this message assigned by the server at publication time. Guaranteed to be unique within the topic.
        /// This value may be read by a subscriber that receives a PubsubMessage via a Pull call or a push delivery. It
        /// must not be populated by a publisher in a Publish call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; }

        /// <summary>
        /// The time at which the message was published. The time is milliseconds since the UNIX epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual System.Nullable<long> PublishTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the PullBatch method.</summary>
    public class PullBatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of PubsubEvents returned for this request. The Pub/Sub system may return fewer than the
        /// number of events specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEvents")]
        public virtual System.Nullable<int> MaxEvents { get; set; }

        /// <summary>
        /// If this is specified as true the system will respond immediately even if it is not able to return a message
        /// in the Pull response. Otherwise the system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does not wish to wait any longer for the
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnImmediately")]
        public virtual System.Nullable<bool> ReturnImmediately { get; set; }

        /// <summary>The subscription from which messages should be pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the PullBatch method.</summary>
    public class PullBatchResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Received Pub/Sub messages or status events. The Pub/Sub system will return zero messages if there are no
        /// more messages available in the backlog. The Pub/Sub system may return fewer than the max_events requested
        /// even if there are more messages available in the backlog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pullResponses")]
        public virtual System.Collections.Generic.IList<PullResponse> PullResponses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the Pull method.</summary>
    public class PullRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If this is specified as true the system will respond immediately even if it is not able to return a message
        /// in the Pull response. Otherwise the system is allowed to wait until at least one message is available rather
        /// than returning FAILED_PRECONDITION. The client may cancel the request if it does not wish to wait any longer
        /// for the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnImmediately")]
        public virtual System.Nullable<bool> ReturnImmediately { get; set; }

        /// <summary>The subscription from which a message should be pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Either a PubsubMessage or a truncation event. One of these two must be populated.</summary>
    public class PullResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This ID must be used to acknowledge the received event or message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackId")]
        public virtual string AckId { get; set; }

        /// <summary>A pubsub message or truncation event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubEvent")]
        public virtual PubsubEvent PubsubEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a push delivery endpoint.</summary>
    public class PushConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use
        /// "https://example.com/push".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushEndpoint")]
        public virtual string PushEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A subscription resource.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For either push or pull delivery, the value is the maximum time after a subscriber receives a message before
        /// the subscriber should acknowledge or Nack the message. If the Ack deadline for a message passes without an
        /// Ack or a Nack, the Pub/Sub system will eventually redeliver the message. If a subscriber acknowledges after
        /// the deadline, the Pub/Sub system may accept the Ack, but it is possible that the message has been already
        /// delivered again. Multiple Acks to the message are allowed and will succeed. For push delivery, this value is
        /// used to set the request timeout for the call to the push endpoint. For pull delivery, this value is used as
        /// the initial value for the Ack deadline. It may be overridden for each message using its corresponding ack_id
        /// with ModifyAckDeadline. While a message is outstanding (i.e. it has been delivered to a pull subscriber and
        /// the subscriber has not yet Acked or Nacked), the Pub/Sub system will not deliver that message to another
        /// pull subscriber (on a best-effort basis).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; }

        /// <summary>Name of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>If push delivery is used with this subscription, this field is used to configure it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; }

        /// <summary>The name of the topic from which this subscription is receiving messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A topic resource.</summary>
    public class Topic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
