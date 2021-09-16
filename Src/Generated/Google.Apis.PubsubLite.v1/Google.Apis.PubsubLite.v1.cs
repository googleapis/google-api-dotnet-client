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

namespace Google.Apis.PubsubLite.v1
{
    /// <summary>The PubsubLite Service.</summary>
    public class PubsubLiteService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PubsubLiteService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PubsubLiteService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Admin = new AdminResource(this);
            Cursor = new CursorResource(this);
            TopicStats = new TopicStatsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "pubsublite";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://pubsublite.googleapis.com/";
        #else
            "https://pubsublite.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://pubsublite.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Pub/Sub Lite API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Pub/Sub Lite API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Admin resource.</summary>
        public virtual AdminResource Admin { get; }

        /// <summary>Gets the Cursor resource.</summary>
        public virtual CursorResource Cursor { get; }

        /// <summary>Gets the TopicStats resource.</summary>
        public virtual TopicStatsResource TopicStats { get; }
    }

    /// <summary>A base abstract class for PubsubLite requests.</summary>
    public abstract class PubsubLiteBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PubsubLiteBaseServiceRequest instance.</summary>
        protected PubsubLiteBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PubsubLite parameter list.</summary>
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

    /// <summary>The "admin" collection of methods.</summary>
    public class AdminResource
    {
        private const string Resource = "admin";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AdminResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Projects = new ProjectsResource(service);
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

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
                    Operations = new OperationsResource(service);
                    Reservations = new ReservationsResource(service);
                    Subscriptions = new SubscriptionsResource(service);
                    Topics = new TopicsResource(service);
                }

                /// <summary>Gets the Operations resource.</summary>
                public virtual OperationsResource Operations { get; }

                /// <summary>The "operations" collection of methods.</summary>
                public class OperationsResource
                {
                    private const string Resource = "operations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OperationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(Google.Apis.PubsubLite.v1.Data.CancelOperationRequest body, string name)
                    {
                        return new CancelRequest(service, body, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.CancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.CancelOperationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}:cancel";

                        /// <summary>Initializes Cancel parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    /// <param name="name">The name of the operation resource to be deleted.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes a long-running operation. This method indicates that the client is no longer interested
                    /// in the operation result. It does not cancel the operation. If the server doesn't support this
                    /// method, it returns `google.rpc.Code.UNIMPLEMENTED`.
                    /// </summary>
                    public class DeleteRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be deleted.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ListOperationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation's parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The standard list filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The standard list page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The standard list page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}/operations";

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

                /// <summary>Gets the Reservations resource.</summary>
                public virtual ReservationsResource Reservations { get; }

                /// <summary>The "reservations" collection of methods.</summary>
                public class ReservationsResource
                {
                    private const string Resource = "reservations";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ReservationsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Topics = new TopicsResource(service);
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
                        }

                        /// <summary>Lists the topics attached to the specified reservation.</summary>
                        /// <param name="name">
                        /// Required. The name of the reservation whose topics to list. Structured like:
                        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                        /// </param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>Lists the topics attached to the specified reservation.</summary>
                        public class ListRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ListReservationTopicsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the reservation whose topics to list. Structured like:
                            /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The maximum number of topics to return. The service may return fewer than this value. If
                            /// unset or zero, all topics for the given reservation will be returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListReservationTopics` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListReservationTopics` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/admin/{+name}/topics";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
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

                    /// <summary>Creates a new reservation.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent location in which to create the reservation. Structured like
                    /// `projects/{project_number}/locations/{location}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.PubsubLite.v1.Data.Reservation body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new reservation.</summary>
                    public class CreateRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Reservation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.Reservation body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent location in which to create the reservation. Structured like
                        /// `projects/{project_number}/locations/{location}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the reservation, which will become the final component of the
                        /// reservation's name. This value is structured like: `my-reservation-name`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("reservationId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ReservationId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.Reservation Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+parent}/reservations";

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
                            RequestParameters.Add("reservationId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "reservationId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified reservation.</summary>
                    /// <param name="name">
                    /// Required. The name of the reservation to delete. Structured like:
                    /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified reservation.</summary>
                    public class DeleteRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the reservation to delete. Structured like:
                        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the reservation configuration.</summary>
                    /// <param name="name">
                    /// Required. The name of the reservation whose configuration to return. Structured like:
                    /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns the reservation configuration.</summary>
                    public class GetRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Reservation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the reservation whose configuration to return. Structured like:
                        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the list of reservations for the given project.</summary>
                    /// <param name="parent">
                    /// Required. The parent whose reservations are to be listed. Structured like
                    /// `projects/{project_number}/locations/{location}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of reservations for the given project.</summary>
                    public class ListRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ListReservationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent whose reservations are to be listed. Structured like
                        /// `projects/{project_number}/locations/{location}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of reservations to return. The service may return fewer than this value.
                        /// If unset or zero, all reservations for the parent will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListReservations` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListReservations` must
                        /// match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+parent}/reservations";

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

                    /// <summary>Updates properties of the specified reservation.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the reservation. Structured like:
                    /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.PubsubLite.v1.Data.Reservation body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates properties of the specified reservation.</summary>
                    public class PatchRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Reservation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.Reservation body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the reservation. Structured like:
                        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. A mask specifying the reservation fields to change.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.Reservation Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
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

                    /// <summary>Creates a new subscription.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent location in which to create the subscription. Structured like
                    /// `projects/{project_number}/locations/{location}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.PubsubLite.v1.Data.Subscription body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new subscription.</summary>
                    public class CreateRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Subscription>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.Subscription body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent location in which to create the subscription. Structured like
                        /// `projects/{project_number}/locations/{location}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// If true, the newly created subscription will only receive messages published after the
                        /// subscription was created. Otherwise, the entire message backlog will be received on the
                        /// subscription. Defaults to false.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("skipBacklog", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> SkipBacklog { get; set; }

                        /// <summary>
                        /// Required. The ID to use for the subscription, which will become the final component of the
                        /// subscription's name. This value is structured like: `my-sub-name`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string SubscriptionId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.Subscription Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+parent}/subscriptions";

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
                            RequestParameters.Add("skipBacklog", new Google.Apis.Discovery.Parameter
                            {
                                Name = "skipBacklog",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "subscriptionId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified subscription.</summary>
                    /// <param name="name">Required. The name of the subscription to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified subscription.</summary>
                    public class DeleteRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the subscription to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the subscription configuration.</summary>
                    /// <param name="name">Required. The name of the subscription whose configuration to return.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns the subscription configuration.</summary>
                    public class GetRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Subscription>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the subscription whose configuration to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the list of subscriptions for the given project.</summary>
                    /// <param name="parent">
                    /// Required. The parent whose subscriptions are to be listed. Structured like
                    /// `projects/{project_number}/locations/{location}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of subscriptions for the given project.</summary>
                    public class ListRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ListSubscriptionsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent whose subscriptions are to be listed. Structured like
                        /// `projects/{project_number}/locations/{location}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of subscriptions to return. The service may return fewer than this value.
                        /// If unset or zero, all subscriptions for the parent will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListSubscriptions` call. Provide this to retrieve
                        /// the subsequent page. When paginating, all other parameters provided to `ListSubscriptions`
                        /// must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+parent}/subscriptions";

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

                    /// <summary>Updates properties of the specified subscription.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the subscription. Structured like:
                    /// projects/{project_number}/locations/{location}/subscriptions/{subscription_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.PubsubLite.v1.Data.Subscription body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates properties of the specified subscription.</summary>
                    public class PatchRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Subscription>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.Subscription body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the subscription. Structured like:
                        /// projects/{project_number}/locations/{location}/subscriptions/{subscription_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. A mask specifying the subscription fields to change.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.Subscription Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
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
                    /// Performs an out-of-band seek for a subscription to a specified target, which may be timestamps
                    /// or named positions within the message backlog. Seek translates these targets to cursors for each
                    /// partition and orchestrates subscribers to start consuming messages from these seek cursors. If
                    /// an operation is returned, the seek has been registered and subscribers will eventually receive
                    /// messages from the seek cursors (i.e. eventual consistency), as long as they are using a minimum
                    /// supported client library version and not a system that tracks cursors independently of Pub/Sub
                    /// Lite (e.g. Apache Beam, Dataflow, Spark). The seek operation will fail for unsupported clients.
                    /// If clients would like to know when subscribers react to the seek (or not), they can poll the
                    /// operation. The seek operation will succeed and complete once subscribers are ready to receive
                    /// messages from the seek cursors for all partitions of the topic. This means that the seek
                    /// operation will not complete until all subscribers come online. If the previous seek operation
                    /// has not yet completed, it will be aborted and the new invocation of seek will supersede it.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The name of the subscription to seek.</param>
                    public virtual SeekRequest Seek(Google.Apis.PubsubLite.v1.Data.SeekSubscriptionRequest body, string name)
                    {
                        return new SeekRequest(service, body, name);
                    }

                    /// <summary>
                    /// Performs an out-of-band seek for a subscription to a specified target, which may be timestamps
                    /// or named positions within the message backlog. Seek translates these targets to cursors for each
                    /// partition and orchestrates subscribers to start consuming messages from these seek cursors. If
                    /// an operation is returned, the seek has been registered and subscribers will eventually receive
                    /// messages from the seek cursors (i.e. eventual consistency), as long as they are using a minimum
                    /// supported client library version and not a system that tracks cursors independently of Pub/Sub
                    /// Lite (e.g. Apache Beam, Dataflow, Spark). The seek operation will fail for unsupported clients.
                    /// If clients would like to know when subscribers react to the seek (or not), they can poll the
                    /// operation. The seek operation will succeed and complete once subscribers are ready to receive
                    /// messages from the seek cursors for all partitions of the topic. This means that the seek
                    /// operation will not complete until all subscribers come online. If the previous seek operation
                    /// has not yet completed, it will be aborted and the new invocation of seek will supersede it.
                    /// </summary>
                    public class SeekRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Seek request.</summary>
                        public SeekRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.SeekSubscriptionRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the subscription to seek.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.SeekSubscriptionRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "seek";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}:seek";

                        /// <summary>Initializes Seek parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
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

                        /// <summary>Lists the subscriptions attached to the specified topic.</summary>
                        /// <param name="name">Required. The name of the topic whose subscriptions to list.</param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>Lists the subscriptions attached to the specified topic.</summary>
                        public class ListRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ListTopicSubscriptionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The name of the topic whose subscriptions to list.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The maximum number of subscriptions to return. The service may return fewer than this
                            /// value. If unset or zero, all subscriptions for the given topic will be returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListTopicSubscriptions` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListTopicSubscriptions` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/admin/{+name}/subscriptions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
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

                    /// <summary>Creates a new topic.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent location in which to create the topic. Structured like
                    /// `projects/{project_number}/locations/{location}`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.PubsubLite.v1.Data.Topic body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new topic.</summary>
                    public class CreateRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Topic>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.Topic body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent location in which to create the topic. Structured like
                        /// `projects/{project_number}/locations/{location}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the topic, which will become the final component of the topic's
                        /// name. This value is structured like: `my-topic-name`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("topicId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string TopicId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.Topic Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+parent}/topics";

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
                            RequestParameters.Add("topicId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "topicId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified topic.</summary>
                    /// <param name="name">Required. The name of the topic to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified topic.</summary>
                    public class DeleteRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the topic to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the topic configuration.</summary>
                    /// <param name="name">Required. The name of the topic whose configuration to return.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns the topic configuration.</summary>
                    public class GetRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Topic>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the topic whose configuration to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the partition information for the requested topic.</summary>
                    /// <param name="name">Required. The topic whose partition information to return.</param>
                    public virtual GetPartitionsRequest GetPartitions(string name)
                    {
                        return new GetPartitionsRequest(service, name);
                    }

                    /// <summary>Returns the partition information for the requested topic.</summary>
                    public class GetPartitionsRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.TopicPartitions>
                    {
                        /// <summary>Constructs a new GetPartitions request.</summary>
                        public GetPartitionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The topic whose partition information to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getPartitions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}/partitions";

                        /// <summary>Initializes GetPartitions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Returns the list of topics for the given project.</summary>
                    /// <param name="parent">
                    /// Required. The parent whose topics are to be listed. Structured like
                    /// `projects/{project_number}/locations/{location}`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of topics for the given project.</summary>
                    public class ListRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ListTopicsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent whose topics are to be listed. Structured like
                        /// `projects/{project_number}/locations/{location}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The maximum number of topics to return. The service may return fewer than this value. If
                        /// unset or zero, all topics for the parent will be returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListTopics` call. Provide this to retrieve the
                        /// subsequent page. When paginating, all other parameters provided to `ListTopics` must match
                        /// the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+parent}/topics";

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

                    /// <summary>Updates properties of the specified topic.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the topic. Structured like:
                    /// projects/{project_number}/locations/{location}/topics/{topic_id}
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.PubsubLite.v1.Data.Topic body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates properties of the specified topic.</summary>
                    public class PatchRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.Topic>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.Topic body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the topic. Structured like:
                        /// projects/{project_number}/locations/{location}/topics/{topic_id}
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. A mask specifying the topic fields to change.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.Topic Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/admin/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
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
                }
            }
        }
    }

    /// <summary>The "cursor" collection of methods.</summary>
    public class CursorResource
    {
        private const string Resource = "cursor";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CursorResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Projects = new ProjectsResource(service);
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

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
                        Cursors = new CursorsResource(service);
                    }

                    /// <summary>Gets the Cursors resource.</summary>
                    public virtual CursorsResource Cursors { get; }

                    /// <summary>The "cursors" collection of methods.</summary>
                    public class CursorsResource
                    {
                        private const string Resource = "cursors";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public CursorsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Returns all committed cursor information for a subscription.</summary>
                        /// <param name="parent">
                        /// Required. The subscription for which to retrieve cursors. Structured like
                        /// `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns all committed cursor information for a subscription.</summary>
                        public class ListRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ListPartitionCursorsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The subscription for which to retrieve cursors. Structured like
                            /// `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The maximum number of cursors to return. The service may return fewer than this value.
                            /// If unset or zero, all cursors for the parent will be returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// A page token, received from a previous `ListPartitionCursors` call. Provide this to
                            /// retrieve the subsequent page. When paginating, all other parameters provided to
                            /// `ListPartitionCursors` must match the call that provided the page token.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/cursor/{+parent}/cursors";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
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

                    /// <summary>Updates the committed cursor.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="subscription">The subscription for which to update the cursor.</param>
                    public virtual CommitCursorRequest CommitCursor(Google.Apis.PubsubLite.v1.Data.CommitCursorRequest body, string subscription)
                    {
                        return new CommitCursorRequest(service, body, subscription);
                    }

                    /// <summary>Updates the committed cursor.</summary>
                    public class CommitCursorRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.CommitCursorResponse>
                    {
                        /// <summary>Constructs a new CommitCursor request.</summary>
                        public CommitCursorRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.CommitCursorRequest body, string subscription) : base(service)
                        {
                            Subscription = subscription;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The subscription for which to update the cursor.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Subscription { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.CommitCursorRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "commitCursor";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/cursor/{+subscription}:commitCursor";

                        /// <summary>Initializes CommitCursor parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("subscription", new Google.Apis.Discovery.Parameter
                            {
                                Name = "subscription",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/subscriptions/[^/]+$",
                            });
                        }
                    }
                }
            }
        }
    }

    /// <summary>The "topicStats" collection of methods.</summary>
    public class TopicStatsResource
    {
        private const string Resource = "topicStats";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TopicStatsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Projects = new ProjectsResource(service);
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

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
                    Topics = new TopicsResource(service);
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
                    }

                    /// <summary>
                    /// Compute the head cursor for the partition. The head cursor's offset is guaranteed to be less
                    /// than or equal to all messages which have not yet been acknowledged as published, and greater
                    /// than the offset of any message whose publish has already been acknowledged. It is zero if there
                    /// have never been messages in the partition.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="topic">Required. The topic for which we should compute the head cursor.</param>
                    public virtual ComputeHeadCursorRequest ComputeHeadCursor(Google.Apis.PubsubLite.v1.Data.ComputeHeadCursorRequest body, string topic)
                    {
                        return new ComputeHeadCursorRequest(service, body, topic);
                    }

                    /// <summary>
                    /// Compute the head cursor for the partition. The head cursor's offset is guaranteed to be less
                    /// than or equal to all messages which have not yet been acknowledged as published, and greater
                    /// than the offset of any message whose publish has already been acknowledged. It is zero if there
                    /// have never been messages in the partition.
                    /// </summary>
                    public class ComputeHeadCursorRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ComputeHeadCursorResponse>
                    {
                        /// <summary>Constructs a new ComputeHeadCursor request.</summary>
                        public ComputeHeadCursorRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.ComputeHeadCursorRequest body, string topic) : base(service)
                        {
                            Topic = topic;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The topic for which we should compute the head cursor.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Topic { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.ComputeHeadCursorRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "computeHeadCursor";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/topicStats/{+topic}:computeHeadCursor";

                        /// <summary>Initializes ComputeHeadCursor parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                            {
                                Name = "topic",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Compute statistics about a range of messages in a given topic and partition.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="topic">Required. The topic for which we should compute message stats.</param>
                    public virtual ComputeMessageStatsRequest ComputeMessageStats(Google.Apis.PubsubLite.v1.Data.ComputeMessageStatsRequest body, string topic)
                    {
                        return new ComputeMessageStatsRequest(service, body, topic);
                    }

                    /// <summary>Compute statistics about a range of messages in a given topic and partition.</summary>
                    public class ComputeMessageStatsRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ComputeMessageStatsResponse>
                    {
                        /// <summary>Constructs a new ComputeMessageStats request.</summary>
                        public ComputeMessageStatsRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.ComputeMessageStatsRequest body, string topic) : base(service)
                        {
                            Topic = topic;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The topic for which we should compute message stats.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Topic { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.ComputeMessageStatsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "computeMessageStats";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/topicStats/{+topic}:computeMessageStats";

                        /// <summary>Initializes ComputeMessageStats parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                            {
                                Name = "topic",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Compute the corresponding cursor for a publish or event time in a topic partition.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="topic">Required. The topic for which we should compute the cursor.</param>
                    public virtual ComputeTimeCursorRequest ComputeTimeCursor(Google.Apis.PubsubLite.v1.Data.ComputeTimeCursorRequest body, string topic)
                    {
                        return new ComputeTimeCursorRequest(service, body, topic);
                    }

                    /// <summary>
                    /// Compute the corresponding cursor for a publish or event time in a topic partition.
                    /// </summary>
                    public class ComputeTimeCursorRequest : PubsubLiteBaseServiceRequest<Google.Apis.PubsubLite.v1.Data.ComputeTimeCursorResponse>
                    {
                        /// <summary>Constructs a new ComputeTimeCursor request.</summary>
                        public ComputeTimeCursorRequest(Google.Apis.Services.IClientService service, Google.Apis.PubsubLite.v1.Data.ComputeTimeCursorRequest body, string topic) : base(service)
                        {
                            Topic = topic;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The topic for which we should compute the cursor.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Topic { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.PubsubLite.v1.Data.ComputeTimeCursorRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "computeTimeCursor";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/topicStats/{+topic}:computeTimeCursor";

                        /// <summary>Initializes ComputeTimeCursor parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("topic", new Google.Apis.Discovery.Parameter
                            {
                                Name = "topic",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/topics/[^/]+$",
                            });
                        }
                    }
                }
            }
        }
    }
}
namespace Google.Apis.PubsubLite.v1.Data
{
    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The throughput capacity configuration for each partition.</summary>
    public class Capacity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishMibPerSec")]
        public virtual System.Nullable<int> PublishMibPerSec { get; set; }

        /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 32.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscribeMibPerSec")]
        public virtual System.Nullable<int> SubscribeMibPerSec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for CommitCursor.</summary>
    public class CommitCursorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new value for the committed cursor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cursor")]
        public virtual Cursor Cursor { get; set; }

        /// <summary>
        /// The partition for which to update the cursor. Partitions are zero indexed, so `partition` must be in the
        /// range [0, topic.num_partitions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual System.Nullable<long> Partition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for CommitCursor.</summary>
    public class CommitCursorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute the current head cursor for a partition.</summary>
    public class ComputeHeadCursorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The partition for which we should compute the head cursor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual System.Nullable<long> Partition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the head cursor for the requested topic and partition.</summary>
    public class ComputeHeadCursorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The head cursor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headCursor")]
        public virtual Cursor HeadCursor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute statistics about a range of messages in a given topic and partition.</summary>
    public class ComputeMessageStatsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The exclusive end of the range. The range is empty if end_cursor &amp;lt;= start_cursor. Specifying a
        /// start_cursor before the first message and an end_cursor after the last message will retrieve all messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endCursor")]
        public virtual Cursor EndCursor { get; set; }

        /// <summary>Required. The partition for which we should compute message stats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual System.Nullable<long> Partition { get; set; }

        /// <summary>The inclusive start of the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startCursor")]
        public virtual Cursor StartCursor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing stats for messages in the requested topic and partition.</summary>
    public class ComputeMessageStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of quota bytes accounted to these messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageBytes")]
        public virtual System.Nullable<long> MessageBytes { get; set; }

        /// <summary>The count of messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageCount")]
        public virtual System.Nullable<long> MessageCount { get; set; }

        /// <summary>
        /// The minimum event timestamp across these messages. For the purposes of this computation, if a message does
        /// not have an event time, we use the publish time. The timestamp will be unset if there are no messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumEventTime")]
        public virtual object MinimumEventTime { get; set; }

        /// <summary>
        /// The minimum publish timestamp across these messages. Note that publish timestamps within a partition are not
        /// guaranteed to be non-decreasing. The timestamp will be unset if there are no messages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumPublishTime")]
        public virtual object MinimumPublishTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute the corresponding cursor for a publish or event time in a topic partition.</summary>
    public class ComputeTimeCursorRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The partition for which we should compute the cursor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual System.Nullable<long> Partition { get; set; }

        /// <summary>
        /// Required. The target publish or event time. Specifying a future time will return an unset cursor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual TimeTarget Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the cursor corresponding to a publish or event time in a topic partition.</summary>
    public class ComputeTimeCursorResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If present, the cursor references the first message with time greater than or equal to the specified target
        /// time. If such a message cannot be found, the cursor will be unset (i.e. `cursor` is not present).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cursor")]
        public virtual Cursor Cursor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A cursor that describes the position of a message within a topic partition.</summary>
    public class Cursor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The offset of a message within a topic partition. Must be greater than or equal 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<long> Offset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The settings for a subscription's message delivery.</summary>
    public class DeliveryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DeliveryRequirement for this subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryRequirement")]
        public virtual string DeliveryRequirement { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListPartitionCursors</summary>
    public class ListPartitionCursorsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The partition cursors from this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionCursors")]
        public virtual System.Collections.Generic.IList<PartitionCursor> PartitionCursors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListReservationTopics.</summary>
    public class ListReservationTopicsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The names of topics attached to the reservation. The order of the topics is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<string> Topics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListReservations.</summary>
    public class ListReservationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of reservation in the requested parent. The order of the reservations is unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservations")]
        public virtual System.Collections.Generic.IList<Reservation> Reservations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListSubscriptions.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of subscriptions in the requested parent. The order of the subscriptions is unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListTopicSubscriptions.</summary>
    public class ListTopicSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The names of subscriptions attached to the topic. The order of the subscriptions is unspecified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<string> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListTopics.</summary>
    public class ListTopicsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page of results. If this field is omitted,
        /// there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of topic in the requested parent. The order of the topics is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<Topic> Topics { get; set; }

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
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for long running operations.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time the operation was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time the operation finished running. Not set if the operation has not completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Resource path for the target of the operation. For example, targets of seeks are subscription resources,
        /// structured like: projects/{project_number}/locations/{location}/subscriptions/{subscription_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>Name of the verb executed by the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The settings for a topic's partitions.</summary>
    public class PartitionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The capacity configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacity")]
        public virtual Capacity Capacity { get; set; }

        /// <summary>
        /// The number of partitions in the topic. Must be at least 1. Once a topic has been created the number of
        /// partitions can be increased but not decreased. Message ordering is not guaranteed across a topic resize. For
        /// more information see https://cloud.google.com/pubsub/lite/docs/topics#scaling_capacity
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// DEPRECATED: Use capacity instead which can express a superset of configurations. Every partition in the
        /// topic is allocated throughput equivalent to `scale` times the standard partition throughput (4 MiB/s). This
        /// is also reflected in the cost of this topic; a topic with `scale` of 2 and count of 10 is charged for 20
        /// partitions. This value must be in the range [1,4].
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual System.Nullable<int> Scale { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pair of a Cursor and the partition it is for.</summary>
    public class PartitionCursor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The value of the cursor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cursor")]
        public virtual Cursor Cursor { get; set; }

        /// <summary>The partition this is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partition")]
        public virtual System.Nullable<long> Partition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a reservation resource.</summary>
    public class Reservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the reservation. Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The reserved throughput capacity. Every unit of throughput capacity is equivalent to 1 MiB/s of published
        /// messages or 2 MiB/s of subscribed messages. Any topics which are declared as using capacity from a
        /// Reservation will consume resources from this reservation instead of being charged individually.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("throughputCapacity")]
        public virtual System.Nullable<long> ThroughputCapacity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The settings for this topic's Reservation usage.</summary>
    public class ReservationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Reservation to use for this topic's throughput capacity. Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("throughputReservation")]
        public virtual string ThroughputReservation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The settings for a topic's message retention.</summary>
    public class RetentionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The provisioned storage, in bytes, per partition. If the number of bytes stored in any of the topic's
        /// partitions grows beyond this value, older messages will be dropped to make room for newer ones, regardless
        /// of the value of `period`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perPartitionBytes")]
        public virtual System.Nullable<long> PerPartitionBytes { get; set; }

        /// <summary>
        /// How long a published message is retained. If unset, messages will be retained as long as the bytes retained
        /// for each partition is below `per_partition_bytes`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual object Period { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for SeekSubscription.</summary>
    public class SeekSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Seek to a named position with respect to the message backlog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedTarget")]
        public virtual string NamedTarget { get; set; }

        /// <summary>
        /// Seek to the first message whose publish or event time is greater than or equal to the specified query time.
        /// If no such message can be located, will seek to the end of the message backlog.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeTarget")]
        public virtual TimeTarget TimeTarget { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for SeekSubscription long running operation.</summary>
    public class SeekSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>Metadata about a subscription resource.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The settings for this subscription's message delivery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryConfig")]
        public virtual DeliveryConfig DeliveryConfig { get; set; }

        /// <summary>
        /// The name of the subscription. Structured like:
        /// projects/{project_number}/locations/{location}/subscriptions/{subscription_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the topic this subscription is attached to. Structured like:
        /// projects/{project_number}/locations/{location}/topics/{topic_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A target publish or event time. Can be used for seeking to or retrieving the corresponding cursor.
    /// </summary>
    public class TimeTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Request the cursor of the first message with event time greater than or equal to `event_time`. If messages
        /// are missing an event time, the publish time is used as a fallback. As event times are user supplied,
        /// subsequent messages may have event times less than `event_time` and should be filtered by the client, if
        /// necessary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// Request the cursor of the first message with publish time greater than or equal to `publish_time`. All
        /// messages thereafter are guaranteed to have publish times &amp;gt;= `publish_time`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a topic resource.</summary>
    public class Topic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name of the topic. Structured like: projects/{project_number}/locations/{location}/topics/{topic_id}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The settings for this topic's partitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionConfig")]
        public virtual PartitionConfig PartitionConfig { get; set; }

        /// <summary>The settings for this topic's Reservation usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationConfig")]
        public virtual ReservationConfig ReservationConfig { get; set; }

        /// <summary>The settings for this topic's message retention.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionConfig")]
        public virtual RetentionConfig RetentionConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for GetTopicPartitions.</summary>
    public class TopicPartitions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of partitions in the topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionCount")]
        public virtual System.Nullable<long> PartitionCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
