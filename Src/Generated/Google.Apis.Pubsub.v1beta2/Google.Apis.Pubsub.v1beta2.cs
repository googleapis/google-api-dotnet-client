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

namespace Google.Apis.Pubsub.v1beta2
{
    /// <summary>The Pubsub Service.</summary>
    public class PubsubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta2";

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
            Projects = new ProjectsResource(this);
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

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
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
            Subscriptions = new SubscriptionsResource(service);
            Topics = new TopicsResource(service);
        }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

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
            /// Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The Pub/Sub system
            /// can remove the relevant messages from the subscription. Acknowledging a message whose ack deadline has
            /// expired may succeed, but such a message may be redelivered later. Acknowledging a message more than once
            /// will not result in an error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">The subscription whose message is being acknowledged.</param>
            public virtual AcknowledgeRequest Acknowledge(Google.Apis.Pubsub.v1beta2.Data.AcknowledgeRequest body, string subscription)
            {
                return new AcknowledgeRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The Pub/Sub system
            /// can remove the relevant messages from the subscription. Acknowledging a message whose ack deadline has
            /// expired may succeed, but such a message may be redelivered later. Acknowledging a message more than once
            /// will not result in an error.
            /// </summary>
            public class AcknowledgeRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Empty>
            {
                /// <summary>Constructs a new Acknowledge request.</summary>
                public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.AcknowledgeRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The subscription whose message is being acknowledged.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1beta2.Data.AcknowledgeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "acknowledge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+subscription}:acknowledge";

                /// <summary>Initializes Acknowledge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a subscription to a given topic. If the subscription already exists, returns `ALREADY_EXISTS`.
            /// If the corresponding topic doesn't exist, returns `NOT_FOUND`. If the name is not provided in the
            /// request, the server will assign a random name for this subscription on the same project as the topic.
            /// Note that for REST API requests, you must specify a name.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the subscription. It must have the format
            /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
            /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`),
            /// tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and
            /// it must not start with `"goog"`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1beta2.Data.Subscription body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>
            /// Creates a subscription to a given topic. If the subscription already exists, returns `ALREADY_EXISTS`.
            /// If the corresponding topic doesn't exist, returns `NOT_FOUND`. If the name is not provided in the
            /// request, the server will assign a random name for this subscription on the same project as the topic.
            /// Note that for REST API requests, you must specify a name.
            /// </summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Subscription>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.Subscription body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the subscription. It must have the format
                /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
                /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods
                /// (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in
                /// length, and it must not start with `"goog"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1beta2.Data.Subscription Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an existing subscription. All pending messages in the subscription are immediately dropped.
            /// Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is deleted, a new one may
            /// be created with the same name, but the new one has no association with the old subscription, or its
            /// topic unless the same topic is specified.
            /// </summary>
            /// <param name="subscription">The subscription to delete.</param>
            public virtual DeleteRequest Delete(string subscription)
            {
                return new DeleteRequest(this.service, subscription);
            }

            /// <summary>
            /// Deletes an existing subscription. All pending messages in the subscription are immediately dropped.
            /// Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is deleted, a new one may
            /// be created with the same name, but the new one has no association with the old subscription, or its
            /// topic unless the same topic is specified.
            /// </summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Empty>
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
                public override string RestPath => "v1beta2/{+subscription}";

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
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
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Subscription>
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
                public override string RestPath => "v1beta2/{+subscription}";

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Policy>
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
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
                /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
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

            /// <summary>Lists matching subscriptions.</summary>
            /// <param name="project">The name of the cloud project that subscriptions belong to.</param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(this.service, project);
            }

            /// <summary>Lists matching subscriptions.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.ListSubscriptionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
                {
                    Project = project;
                    InitParameters();
                }

                /// <summary>The name of the cloud project that subscriptions belong to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Maximum number of subscriptions to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSubscriptionsResponse`; indicates that this is a continuation of
                /// a prior `ListSubscriptions` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+project}/subscriptions";

                /// <summary>Initializes List parameter list.</summary>
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
            /// Modifies the ack deadline for a specific message. This method is useful to indicate that more time is
            /// needed to process a message by the subscriber, or to make the message available for redelivery if the
            /// processing was interrupted. Note that this does not modify the subscription-level `ackDeadlineSeconds`
            /// used for subsequent messages.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">The name of the subscription.</param>
            public virtual ModifyAckDeadlineRequest ModifyAckDeadline(Google.Apis.Pubsub.v1beta2.Data.ModifyAckDeadlineRequest body, string subscription)
            {
                return new ModifyAckDeadlineRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Modifies the ack deadline for a specific message. This method is useful to indicate that more time is
            /// needed to process a message by the subscriber, or to make the message available for redelivery if the
            /// processing was interrupted. Note that this does not modify the subscription-level `ackDeadlineSeconds`
            /// used for subsequent messages.
            /// </summary>
            public class ModifyAckDeadlineRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Empty>
            {
                /// <summary>Constructs a new ModifyAckDeadline request.</summary>
                public ModifyAckDeadlineRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.ModifyAckDeadlineRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the subscription.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1beta2.Data.ModifyAckDeadlineRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modifyAckDeadline";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+subscription}:modifyAckDeadline";

                /// <summary>Initializes ModifyAckDeadline parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Modifies the `PushConfig` for a specified subscription. This may be used to change a push subscription
            /// to a pull one (signified by an empty `PushConfig`) or vice versa, or change the endpoint URL and other
            /// attributes of a push subscription. Messages will accumulate for delivery continuously through the call
            /// regardless of changes to the `PushConfig`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">The name of the subscription.</param>
            public virtual ModifyPushConfigRequest ModifyPushConfig(Google.Apis.Pubsub.v1beta2.Data.ModifyPushConfigRequest body, string subscription)
            {
                return new ModifyPushConfigRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Modifies the `PushConfig` for a specified subscription. This may be used to change a push subscription
            /// to a pull one (signified by an empty `PushConfig`) or vice versa, or change the endpoint URL and other
            /// attributes of a push subscription. Messages will accumulate for delivery continuously through the call
            /// regardless of changes to the `PushConfig`.
            /// </summary>
            public class ModifyPushConfigRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Empty>
            {
                /// <summary>Constructs a new ModifyPushConfig request.</summary>
                public ModifyPushConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.ModifyPushConfigRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the subscription.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1beta2.Data.ModifyPushConfigRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modifyPushConfig";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+subscription}:modifyPushConfig";

                /// <summary>Initializes ModifyPushConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Pulls messages from the server. Returns an empty list if there are no messages available in the backlog.
            /// The server may return `UNAVAILABLE` if there are too many concurrent pull requests pending for the given
            /// subscription.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">The subscription from which messages should be pulled.</param>
            public virtual PullRequest Pull(Google.Apis.Pubsub.v1beta2.Data.PullRequest body, string subscription)
            {
                return new PullRequest(this.service, body, subscription);
            }

            /// <summary>
            /// Pulls messages from the server. Returns an empty list if there are no messages available in the backlog.
            /// The server may return `UNAVAILABLE` if there are too many concurrent pull requests pending for the given
            /// subscription.
            /// </summary>
            public class PullRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.PullResponse>
            {
                /// <summary>Constructs a new Pull request.</summary>
                public PullRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.PullRequest body, string subscription) : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The subscription from which messages should be pulled.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1beta2.Data.PullRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "pull";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+subscription}:pull";

                /// <summary>Initializes Pull parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscription",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
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
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1beta2.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                        Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Topics resource.</summary>
        public virtual TopicsResource Topics { get; }

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
                Subscriptions = new SubscriptionsResource(service);
            }

            /// <summary>Gets the Subscriptions resource.</summary>
            public virtual SubscriptionsResource Subscriptions { get; }

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

                /// <summary>Lists the name of the subscriptions for this topic.</summary>
                /// <param name="topic">The name of the topic that subscriptions are attached to.</param>
                public virtual ListRequest List(string topic)
                {
                    return new ListRequest(this.service, topic);
                }

                /// <summary>Lists the name of the subscriptions for this topic.</summary>
                public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.ListTopicSubscriptionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string topic) : base(service)
                    {
                        Topic = topic;
                        InitParameters();
                    }

                    /// <summary>The name of the topic that subscriptions are attached to.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Topic { get; private set; }

                    /// <summary>Maximum number of subscription names to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListTopicSubscriptionsResponse`; indicates that this is a
                    /// continuation of a prior `ListTopicSubscriptions` call, and that the system should return the
                    /// next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+topic}/subscriptions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                        {
                            Name = "topic",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
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

            /// <summary>Creates the given topic with the given name.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`. `{topic}` must
            /// start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores
            /// (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255
            /// characters in length, and it must not start with `"goog"`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1beta2.Data.Topic body, string name)
            {
                return new CreateRequest(this.service, body, name);
            }

            /// <summary>Creates the given topic with the given name.</summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Topic>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.Topic body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`. `{topic}` must
                /// start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
                /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be
                /// between 3 and 255 characters in length, and it must not start with `"goog"`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1beta2.Data.Topic Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic does not exist. After a topic is
            /// deleted, a new topic may be created with the same name; this is an entirely new topic with none of the
            /// old configuration or subscriptions. Existing subscriptions to this topic are not deleted, but their
            /// `topic` field is set to `_deleted-topic_`.
            /// </summary>
            /// <param name="topic">Name of the topic to delete.</param>
            public virtual DeleteRequest Delete(string topic)
            {
                return new DeleteRequest(this.service, topic);
            }

            /// <summary>
            /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic does not exist. After a topic is
            /// deleted, a new topic may be created with the same name; this is an entirely new topic with none of the
            /// old configuration or subscriptions. Existing subscriptions to this topic are not deleted, but their
            /// `topic` field is set to `_deleted-topic_`.
            /// </summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Empty>
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
                public override string RestPath => "v1beta2/{+topic}";

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the configuration of a topic.</summary>
            /// <param name="topic">The name of the topic to get.</param>
            public virtual GetRequest Get(string topic)
            {
                return new GetRequest(this.service, topic);
            }

            /// <summary>Gets the configuration of a topic.</summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Topic>
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
                public override string RestPath => "v1beta2/{+topic}";

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(this.service, resource);
            }

            /// <summary>
            /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and does
            /// not have a policy set.
            /// </summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Policy>
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
                /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1,
                /// and 3. Requests specifying an invalid value will be rejected. Requests for policies with any
                /// conditional role bindings must specify version 3. Policies with no conditional role bindings may
                /// specify any valid value or leave the field unset. The policy in the response might use the policy
                /// version that you specified, or it might use a lower policy version. For example, if you specify
                /// version 3, but the policy has no conditional role bindings, the response uses version 1. To learn
                /// which resources support conditions in their IAM policies, see the [IAM
                /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+resource}:getIamPolicy";

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
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

            /// <summary>Lists matching topics.</summary>
            /// <param name="project">The name of the cloud project that topics belong to.</param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(this.service, project);
            }

            /// <summary>Lists matching topics.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.ListTopicsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
                {
                    Project = project;
                    InitParameters();
                }

                /// <summary>The name of the cloud project that topics belong to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Maximum number of topics to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListTopicsResponse`; indicates that this is a continuation of a
                /// prior `ListTopics` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+project}/topics";

                /// <summary>Initializes List parameter list.</summary>
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
            /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic does not exist. The message
            /// payload must not be empty; it must contain either a non-empty data field, or at least one attribute.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="topic">The messages in the request will be published on this topic.</param>
            public virtual PublishRequest Publish(Google.Apis.Pubsub.v1beta2.Data.PublishRequest body, string topic)
            {
                return new PublishRequest(this.service, body, topic);
            }

            /// <summary>
            /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic does not exist. The message
            /// payload must not be empty; it must contain either a non-empty data field, or at least one attribute.
            /// </summary>
            public class PublishRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.PublishResponse>
            {
                /// <summary>Constructs a new Publish request.</summary>
                public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.PublishRequest body, string topic) : base(service)
                {
                    Topic = topic;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The messages in the request will be published on this topic.</summary>
                [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Topic { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1beta2.Data.PublishRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "publish";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+topic}:publish";

                /// <summary>Initializes Publish parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                    {
                        Name = "topic",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
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
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1beta2.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(this.service, body, resource);
            }

            /// <summary>
            /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
            /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
            /// </summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.SetIamPolicyRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1beta2.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+resource}:setIamPolicy";

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(this.service, body, resource);
            }

            /// <summary>
            /// Returns permissions that a caller has on the specified resource. If the resource does not exist, this
            /// will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is designed to be
            /// used for building permission-aware UIs and command-line tools, not for authorization checking. This
            /// operation may "fail open" without warning.
            /// </summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsRequest body, string resource) : base(service)
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
                Google.Apis.Pubsub.v1beta2.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+resource}:testIamPermissions";

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
                        Pattern = @"^projects/[^/]+/topics/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Pubsub.v1beta2.Data
{
    /// <summary>Request for the Acknowledge method.</summary>
    public class AcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The acknowledgment ID for the messages being acknowledged that was returned by the Pub/Sub system in the
        /// `Pull` response. Must not be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackIds")]
        public virtual System.Collections.Generic.IList<string> AckIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
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

    /// <summary>Response for the `ListSubscriptions` method.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, indicates that there may be more subscriptions that match the request; this value should be
        /// passed in a new `ListSubscriptionsRequest` to get more subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The subscriptions that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListTopicSubscriptions` method.</summary>
    public class ListTopicSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, indicates that there may be more subscriptions that match the request; this value should be
        /// passed in a new `ListTopicSubscriptionsRequest` to get more subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The names of the subscriptions that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<string> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `ListTopics` method.</summary>
    public class ListTopicsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If not empty, indicates that there may be more topics that match the request; this value should be passed in
        /// a new `ListTopicsRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting topics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<Topic> Topics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the ModifyAckDeadline method.</summary>
    public class ModifyAckDeadlineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new ack deadline with respect to the time this request was sent to the Pub/Sub system. Must be &amp;gt;=
        /// 0. For example, if the value is 10, the new ack deadline will expire 10 seconds after the
        /// `ModifyAckDeadline` call was made. Specifying zero may immediately make the message available for another
        /// pull request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; }

        /// <summary>The acknowledgment ID. Either this or ack_ids must be populated, but not both.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackId")]
        public virtual string AckId { get; set; }

        /// <summary>List of acknowledgment IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackIds")]
        public virtual System.Collections.Generic.IList<string> AckIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the ModifyPushConfig method.</summary>
    public class ModifyPushConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The push configuration for future deliveries. An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow messages to be pulled and acknowledged -
        /// effectively pausing the subscription if `Pull` is not called.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains information needed for generating an [OpenID Connect
    /// token](https://developers.google.com/identity/protocols/OpenIDConnect).
    /// </summary>
    public class OidcToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Audience to be used when generating OIDC token. The audience claim identifies the recipients that the JWT is
        /// intended for. The audience value is a single case-sensitive string. Having multiple values (array) for the
        /// audience field is not supported. More info about the OIDC JWT token audience here:
        /// https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>
        /// [Service account email](https://cloud.google.com/iam/docs/service-accounts) to be used for generating the
        /// OIDC token. The caller (for CreateSubscription, UpdateSubscription, and ModifyPushConfig RPCs) must have the
        /// iam.serviceAccounts.actAs permission for the service account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

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

    /// <summary>Request for the Publish method.</summary>
    public class PublishRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The messages to publish.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<PubsubMessage> Messages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `Publish` method.</summary>
    public class PublishResponse : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>
    /// A message data and its attributes. The message payload must not be empty; it must contain either a non-empty
    /// data field, or at least one attribute.
    /// </summary>
    public class PubsubMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional attributes for this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// The message payload. For JSON requests, the value of this field must be
        /// [base64-encoded](https://tools.ietf.org/html/rfc4648).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// ID of this message, assigned by the server when the message is published. Guaranteed to be unique within the
        /// topic. This value may be read by a subscriber that receives a `PubsubMessage` via a `Pull` call or a push
        /// delivery. It must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; }

        private string _publishTimeRaw;

        private object _publishTime;

        /// <summary>
        /// The time at which the message was published, populated by the server when it receives the `Publish` call. It
        /// must not be populated by the publisher in a `Publish` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual string PublishTimeRaw
        {
            get => _publishTimeRaw;
            set
            {
                _publishTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _publishTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishTimeDateTimeOffset instead.")]
        public virtual object PublishTime
        {
            get => _publishTime;
            set
            {
                _publishTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _publishTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PublishTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PublishTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishTimeRaw);
            set => PublishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the `Pull` method.</summary>
    public class PullRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of messages returned for this request. The Pub/Sub system may return fewer than the
        /// number specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMessages")]
        public virtual System.Nullable<int> MaxMessages { get; set; }

        /// <summary>
        /// Optional. If this is specified as true the system will respond immediately even if it is not able to return
        /// a message in the `Pull` response. Otherwise the system is allowed to wait until at least one message is
        /// available rather than returning no messages. The client may cancel the request if it does not wish to wait
        /// any longer for the response. Warning: setting this field to `true` is discouraged because it adversely
        /// impacts the performance of `Pull` operations. We recommend that users do not set this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnImmediately")]
        public virtual System.Nullable<bool> ReturnImmediately { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the `Pull` method.</summary>
    public class PullResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Received Pub/Sub messages. The Pub/Sub system will return zero messages if there are no more available in
        /// the backlog. The Pub/Sub system may return fewer than the `maxMessages` requested even if there are more
        /// messages available in the backlog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receivedMessages")]
        public virtual System.Collections.Generic.IList<ReceivedMessage> ReceivedMessages { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a push delivery endpoint.</summary>
    public class PushConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Endpoint configuration attributes. Every endpoint has a set of API supported attributes that can be used to
        /// control different aspects of the message delivery. The currently supported attribute is `x-goog-version`,
        /// which you can use to change the format of the push message. This attribute indicates the version of the data
        /// expected by the endpoint. This controls the shape of the envelope (i.e. its fields and metadata). The
        /// endpoint version is based on the version of the Pub/Sub API. If not present during the `CreateSubscription`
        /// call, it will default to the version of the API used to make such call. If not present during a
        /// `ModifyPushConfig` call, its value will not be changed. `GetSubscription` calls will always return a valid
        /// version, even if the subscription was created without this attribute. The possible values for this attribute
        /// are: * `v1beta1`: uses the push format defined in the v1beta1 Pub/Sub API. * `v1` or `v1beta2`: uses the
        /// push format defined in the v1 Pub/Sub API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// If specified, Pub/Sub will generate and attach an OIDC JWT token as an `Authorization` header in the HTTP
        /// request for every pushed message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcToken")]
        public virtual OidcToken OidcToken { get; set; }

        /// <summary>
        /// A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint might use
        /// "https://example.com/push".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushEndpoint")]
        public virtual string PushEndpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A message and its corresponding acknowledgment ID.</summary>
    public class ReceivedMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This ID can be used to acknowledge the received message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackId")]
        public virtual string AckId { get; set; }

        /// <summary>The message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual PubsubMessage Message { get; set; }

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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A subscription resource.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This value is the maximum time after a subscriber receives a message before the subscriber should
        /// acknowledge the message. After message delivery but before the ack deadline expires and before the message
        /// is acknowledged, it is an outstanding message and will not be delivered again during that time (on a
        /// best-effort basis). For pull subscriptions, this value is used as the initial value for the ack deadline. To
        /// override this value for a given message, call `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull. The maximum custom deadline you can specify is 600 seconds (10 minutes). For push delivery, this value
        /// is also used to set the request timeout for the call to the push endpoint. If the subscriber never
        /// acknowledges the message, the Pub/Sub system will eventually redeliver the message. If this parameter is 0,
        /// a default value of 10 seconds is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; }

        /// <summary>
        /// The name of the subscription. It must have the format `"projects/{project}/subscriptions/{subscription}"`.
        /// `{subscription}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes
        /// (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between
        /// 3 and 255 characters in length, and it must not start with `"goog"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If push delivery is used with this subscription, this field is used to configure it. An empty `pushConfig`
        /// signifies that the subscriber will pull and ack messages using API methods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; }

        /// <summary>
        /// The name of the topic from which this subscription is receiving messages. The value of this field will be
        /// `_deleted-topic_` if the topic has been deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

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

    /// <summary>A topic resource.</summary>
    public class Topic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`. `{topic}` must start
        /// with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`),
        /// periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in
        /// length, and it must not start with `"goog"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
