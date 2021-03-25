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

namespace Google.Apis.WebRisk.v1
{
    /// <summary>The WebRisk Service.</summary>
    public class WebRiskService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WebRiskService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WebRiskService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Hashes = new HashesResource(this);
            Projects = new ProjectsResource(this);
            ThreatLists = new ThreatListsResource(this);
            Uris = new UrisResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "webrisk";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://webrisk.googleapis.com/";
        #else
            "https://webrisk.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://webrisk.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Web Risk API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Web Risk API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Hashes resource.</summary>
        public virtual HashesResource Hashes { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the ThreatLists resource.</summary>
        public virtual ThreatListsResource ThreatLists { get; }

        /// <summary>Gets the Uris resource.</summary>
        public virtual UrisResource Uris { get; }
    }

    /// <summary>A base abstract class for WebRisk requests.</summary>
    public abstract class WebRiskBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WebRiskBaseServiceRequest instance.</summary>
        protected WebRiskBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes WebRisk parameter list.</summary>
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

    /// <summary>The "hashes" collection of methods.</summary>
    public class HashesResource
    {
        private const string Resource = "hashes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public HashesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix. This is used after a hash prefix is looked up in
        /// a threatList and there is a match. The client side threatList only holds partial hashes so the client must
        /// query this method to determine if there is a full hash match of a threat.
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// Gets the full hashes that match the requested hash prefix. This is used after a hash prefix is looked up in
        /// a threatList and there is a match. The client side threatList only holds partial hashes so the client must
        /// query this method to determine if there is a full hash match of a threat.
        /// </summary>
        public class SearchRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1SearchHashesResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// A hash prefix, consisting of the most significant 4-32 bytes of a SHA256 hash. For JSON requests, this
            /// field is base64-encoded. Note that if this parameter is provided by a URI, it must be encoded using the
            /// web safe base64 variant (RFC 4648).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("hashPrefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string HashPrefix { get; set; }

            /// <summary>Required. The ThreatLists to search in. Multiple ThreatLists may be specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("threatTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ThreatTypesEnum> ThreatTypes { get; set; }

            /// <summary>Required. The ThreatLists to search in. Multiple ThreatLists may be specified.</summary>
            public enum ThreatTypesEnum
            {
                /// <summary>No entries should match this threat type. This threat type is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("THREAT_TYPE_UNSPECIFIED")]
                THREATTYPEUNSPECIFIED = 0,

                /// <summary>Malware targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("MALWARE")]
                MALWARE = 1,

                /// <summary>Social engineering targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("SOCIAL_ENGINEERING")]
                SOCIALENGINEERING = 2,

                /// <summary>Unwanted software targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("UNWANTED_SOFTWARE")]
                UNWANTEDSOFTWARE = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/hashes:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("hashPrefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "hashPrefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("threatTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "threatTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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
            Operations = new OperationsResource(service);
            Submissions = new SubmissionsResource(service);
            Uris = new UrisResource(service);
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
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The name of the operation resource to be cancelled.</param>
            public virtual CancelRequest Cancel(Google.Apis.WebRisk.v1.Data.GoogleLongrunningCancelOperationRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            public class CancelRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.WebRisk.v1.Data.GoogleLongrunningCancelOperationRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The name of the operation resource to be cancelled.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebRisk.v1.Data.GoogleLongrunningCancelOperationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:cancel";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            /// <param name="name">The name of the operation resource to be deleted.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            public class DeleteRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleProtobufEmpty>
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
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            /// <param name="name">The name of the operation resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            public class GetRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleLongrunningOperation>
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
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding
            /// to use different resource name schemes, such as `users/*/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection id.
            /// </summary>
            public class ListRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleLongrunningListOperationsResponse>
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
                public override string RestPath => "v1/{+name}/operations";

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
                        Pattern = @"^projects/[^/]+$",
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

        /// <summary>Gets the Submissions resource.</summary>
        public virtual SubmissionsResource Submissions { get; }

        /// <summary>The "submissions" collection of methods.</summary>
        public class SubmissionsResource
        {
            private const string Resource = "submissions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubmissionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a Submission of a URI suspected of containing phishing content to be reviewed. If the result
            /// verifies the existence of malicious phishing content, the site will be added to the [Google's Social
            /// Engineering lists](https://support.google.com/webmasters/answer/6350487/) in order to protect users that
            /// could get exposed to this threat in the future. Only allowlisted projects can use this method during
            /// Early Access. Please reach out to Sales or your customer engineer to obtain access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project that is making the submission. This string is in the format
            /// "projects/{project_number}".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1Submission body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a Submission of a URI suspected of containing phishing content to be reviewed. If the result
            /// verifies the existence of malicious phishing content, the site will be added to the [Google's Social
            /// Engineering lists](https://support.google.com/webmasters/answer/6350487/) in order to protect users that
            /// could get exposed to this threat in the future. Only allowlisted projects can use this method during
            /// Early Access. Please reach out to Sales or your customer engineer to obtain access.
            /// </summary>
            public class CreateRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1Submission>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1Submission body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project that is making the submission. This string is in the format
                /// "projects/{project_number}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1Submission Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/submissions";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Uris resource.</summary>
        public virtual UrisResource Uris { get; }

        /// <summary>The "uris" collection of methods.</summary>
        public class UrisResource
        {
            private const string Resource = "uris";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public UrisResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Submits a URI suspected of containing malicious content to be reviewed. Returns a
            /// google.longrunning.Operation which, once the review is complete, is updated with its result. You can use
            /// the [Pub/Sub API] (https://cloud.google.com/pubsub) to receive notifications for the returned Operation.
            /// If the result verifies the existence of malicious content, the site will be added to the [Google's
            /// Social Engineering lists] (https://support.google.com/webmasters/answer/6350487/) in order to protect
            /// users that could get exposed to this threat in the future. Only allowlisted projects can use this method
            /// during Early Access. Please reach out to Sales or your customer engineer to obtain access.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project that is making the submission. This string is in the format
            /// "projects/{project_number}".
            /// </param>
            public virtual SubmitRequest Submit(Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1SubmitUriRequest body, string parent)
            {
                return new SubmitRequest(service, body, parent);
            }

            /// <summary>
            /// Submits a URI suspected of containing malicious content to be reviewed. Returns a
            /// google.longrunning.Operation which, once the review is complete, is updated with its result. You can use
            /// the [Pub/Sub API] (https://cloud.google.com/pubsub) to receive notifications for the returned Operation.
            /// If the result verifies the existence of malicious content, the site will be added to the [Google's
            /// Social Engineering lists] (https://support.google.com/webmasters/answer/6350487/) in order to protect
            /// users that could get exposed to this threat in the future. Only allowlisted projects can use this method
            /// during Early Access. Please reach out to Sales or your customer engineer to obtain access.
            /// </summary>
            public class SubmitRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Submit request.</summary>
                public SubmitRequest(Google.Apis.Services.IClientService service, Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1SubmitUriRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project that is making the submission. This string is in the format
                /// "projects/{project_number}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1SubmitUriRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "submit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/uris:submit";

                /// <summary>Initializes Submit parameter list.</summary>
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
                }
            }
        }
    }

    /// <summary>The "threatLists" collection of methods.</summary>
    public class ThreatListsResource
    {
        private const string Resource = "threatLists";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ThreatListsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the most recent threat list diffs. These diffs should be applied to a local database of hashes to keep
        /// it up-to-date. If the local database is empty or excessively out-of-date, a complete snapshot of the
        /// database will be returned. This Method only updates a single ThreatList at a time. To update multiple
        /// ThreatList databases, this method needs to be called once for each list.
        /// </summary>
        public virtual ComputeDiffRequest ComputeDiff()
        {
            return new ComputeDiffRequest(service);
        }

        /// <summary>
        /// Gets the most recent threat list diffs. These diffs should be applied to a local database of hashes to keep
        /// it up-to-date. If the local database is empty or excessively out-of-date, a complete snapshot of the
        /// database will be returned. This Method only updates a single ThreatList at a time. To update multiple
        /// ThreatList databases, this method needs to be called once for each list.
        /// </summary>
        public class ComputeDiffRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1ComputeThreatListDiffResponse>
        {
            /// <summary>Constructs a new ComputeDiff request.</summary>
            public ComputeDiffRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Sets the maximum number of entries that the client is willing to have in the local database. This should
            /// be a power of 2 between 2**10 and 2**20. If zero, no database size limit is set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("constraints.maxDatabaseEntries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ConstraintsMaxDatabaseEntries { get; set; }

            /// <summary>
            /// The maximum size in number of entries. The diff will not contain more entries than this value. This
            /// should be a power of 2 between 2**10 and 2**20. If zero, no diff size limit is set.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("constraints.maxDiffEntries", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> ConstraintsMaxDiffEntries { get; set; }

            /// <summary>The compression types supported by the client.</summary>
            [Google.Apis.Util.RequestParameterAttribute("constraints.supportedCompressions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ConstraintsSupportedCompressionsEnum> ConstraintsSupportedCompressions { get; set; }

            /// <summary>The compression types supported by the client.</summary>
            public enum ConstraintsSupportedCompressionsEnum
            {
                /// <summary>Unknown.</summary>
                [Google.Apis.Util.StringValueAttribute("COMPRESSION_TYPE_UNSPECIFIED")]
                COMPRESSIONTYPEUNSPECIFIED = 0,

                /// <summary>Raw, uncompressed data.</summary>
                [Google.Apis.Util.StringValueAttribute("RAW")]
                RAW = 1,

                /// <summary>Rice-Golomb encoded data.</summary>
                [Google.Apis.Util.StringValueAttribute("RICE")]
                RICE = 2,
            }

            /// <summary>
            /// Required. The threat list to update. Only a single ThreatType should be specified per request. If you
            /// want to handle multiple ThreatTypes, you must make one request per ThreatType.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("threatType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ThreatTypeEnum> ThreatType { get; set; }

            /// <summary>
            /// Required. The threat list to update. Only a single ThreatType should be specified per request. If you
            /// want to handle multiple ThreatTypes, you must make one request per ThreatType.
            /// </summary>
            public enum ThreatTypeEnum
            {
                /// <summary>No entries should match this threat type. This threat type is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("THREAT_TYPE_UNSPECIFIED")]
                THREATTYPEUNSPECIFIED = 0,

                /// <summary>Malware targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("MALWARE")]
                MALWARE = 1,

                /// <summary>Social engineering targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("SOCIAL_ENGINEERING")]
                SOCIALENGINEERING = 2,

                /// <summary>Unwanted software targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("UNWANTED_SOFTWARE")]
                UNWANTEDSOFTWARE = 3,
            }

            /// <summary>
            /// The current version token of the client for the requested list (the client version that was received
            /// from the last successful diff). If the client does not have a version token (this is the first time
            /// calling ComputeThreatListDiff), this may be left empty and a full database snapshot will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("versionToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string VersionToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "computeDiff";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/threatLists:computeDiff";

            /// <summary>Initializes ComputeDiff parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("constraints.maxDatabaseEntries", new Google.Apis.Discovery.Parameter
                {
                    Name = "constraints.maxDatabaseEntries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("constraints.maxDiffEntries", new Google.Apis.Discovery.Parameter
                {
                    Name = "constraints.maxDiffEntries",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("constraints.supportedCompressions", new Google.Apis.Discovery.Parameter
                {
                    Name = "constraints.supportedCompressions",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("threatType", new Google.Apis.Discovery.Parameter
                {
                    Name = "threatType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("versionToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "versionToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "uris" collection of methods.</summary>
    public class UrisResource
    {
        private const string Resource = "uris";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UrisResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList. Multiple threatLists may be searched in
        /// a single query. The response will list all requested threatLists the URI was found to match. If the URI is
        /// not found on any of the requested ThreatList an empty response will be returned.
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// This method is used to check whether a URI is on a given threatList. Multiple threatLists may be searched in
        /// a single query. The response will list all requested threatLists the URI was found to match. If the URI is
        /// not found on any of the requested ThreatList an empty response will be returned.
        /// </summary>
        public class SearchRequest : WebRiskBaseServiceRequest<Google.Apis.WebRisk.v1.Data.GoogleCloudWebriskV1SearchUrisResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Required. The ThreatLists to search in. Multiple ThreatLists may be specified.</summary>
            [Google.Apis.Util.RequestParameterAttribute("threatTypes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ThreatTypesEnum> ThreatTypes { get; set; }

            /// <summary>Required. The ThreatLists to search in. Multiple ThreatLists may be specified.</summary>
            public enum ThreatTypesEnum
            {
                /// <summary>No entries should match this threat type. This threat type is unused.</summary>
                [Google.Apis.Util.StringValueAttribute("THREAT_TYPE_UNSPECIFIED")]
                THREATTYPEUNSPECIFIED = 0,

                /// <summary>Malware targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("MALWARE")]
                MALWARE = 1,

                /// <summary>Social engineering targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("SOCIAL_ENGINEERING")]
                SOCIALENGINEERING = 2,

                /// <summary>Unwanted software targeting any platform.</summary>
                [Google.Apis.Util.StringValueAttribute("UNWANTED_SOFTWARE")]
                UNWANTEDSOFTWARE = 3,
            }

            /// <summary>Required. The URI to be checked for matches.</summary>
            [Google.Apis.Util.RequestParameterAttribute("uri", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Uri { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/uris:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("threatTypes", new Google.Apis.Discovery.Parameter
                {
                    Name = "threatTypes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("uri", new Google.Apis.Discovery.Parameter
                {
                    Name = "uri",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.WebRisk.v1.Data
{
    public class GoogleCloudWebriskV1ComputeThreatListDiffResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A set of entries to add to a local threat type's list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additions")]
        public virtual GoogleCloudWebriskV1ThreatEntryAdditions Additions { get; set; }

        /// <summary>
        /// The expected SHA256 hash of the client state; that is, of the sorted list of all hashes present in the
        /// database after applying the provided diff. If the client state doesn't match the expected state, the client
        /// must discard this diff and retry later.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksum")]
        public virtual GoogleCloudWebriskV1ComputeThreatListDiffResponseChecksum Checksum { get; set; }

        /// <summary>
        /// The new opaque client version token. This should be retained by the client and passed into the next call of
        /// ComputeThreatListDiff as 'version_token'. A separate version token should be stored and used for each
        /// threatList.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newVersionToken")]
        public virtual string NewVersionToken { get; set; }

        /// <summary>
        /// The soonest the client should wait before issuing any diff request. Querying sooner is unlikely to produce a
        /// meaningful diff. Waiting longer is acceptable considering the use case. If this field is not set clients may
        /// update as soon as they want.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendedNextDiff")]
        public virtual object RecommendedNextDiff { get; set; }

        /// <summary>A set of entries to remove from a local threat type's list. This field may be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removals")]
        public virtual GoogleCloudWebriskV1ThreatEntryRemovals Removals { get; set; }

        /// <summary>
        /// The type of response. This may indicate that an action must be taken by the client when the response is
        /// received.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseType")]
        public virtual string ResponseType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The expected state of a client's local database.</summary>
    public class GoogleCloudWebriskV1ComputeThreatListDiffResponseChecksum : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The SHA256 hash of the client state; that is, of the sorted list of all hashes present in the database.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The uncompressed threat entries in hash format. Hashes can be anywhere from 4 to 32 bytes in size. A large
    /// majority are 4 bytes, but some hashes are lengthened if they collide with the hash of a popular URI. Used for
    /// sending ThreatEntryAdditons to clients that do not support compression, or when sending non-4-byte hashes to
    /// clients that do support compression.
    /// </summary>
    public class GoogleCloudWebriskV1RawHashes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of bytes for each prefix encoded below. This field can be anywhere from 4 (shortest prefix) to 32
        /// (full SHA256 hash). In practice this is almost always 4, except in exceptional circumstances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixSize")]
        public virtual System.Nullable<int> PrefixSize { get; set; }

        /// <summary>
        /// The hashes, in binary format, concatenated into one long string. Hashes are sorted in lexicographic order.
        /// For JSON API users, hashes are base64-encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawHashes")]
        public virtual string RawHashes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of raw indices to remove from a local list.</summary>
    public class GoogleCloudWebriskV1RawIndices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The indices to remove from a lexicographically-sorted local list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indices")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Indices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Rice-Golomb encoded data. Used for sending compressed 4-byte hashes or compressed removal indices.
    /// </summary>
    public class GoogleCloudWebriskV1RiceDeltaEncoding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The encoded deltas that are encoded using the Golomb-Rice coder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encodedData")]
        public virtual string EncodedData { get; set; }

        /// <summary>
        /// The number of entries that are delta encoded in the encoded data. If only a single integer was encoded, this
        /// will be zero and the single value will be stored in `first_value`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryCount")]
        public virtual System.Nullable<int> EntryCount { get; set; }

        /// <summary>
        /// The offset of the first entry in the encoded data, or, if only a single integer was encoded, that single
        /// integer's value. If the field is empty or missing, assume zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValue")]
        public virtual System.Nullable<long> FirstValue { get; set; }

        /// <summary>
        /// The Golomb-Rice parameter, which is a number between 2 and 28. This field is missing (that is, zero) if
        /// `num_entries` is zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceParameter")]
        public virtual System.Nullable<int> RiceParameter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudWebriskV1SearchHashesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For requested entities that did not match the threat list, how long to cache the response until.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeExpireTime")]
        public virtual object NegativeExpireTime { get; set; }

        /// <summary>
        /// The full hashes that matched the requested prefixes. The hash will be populated in the key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threats")]
        public virtual System.Collections.Generic.IList<GoogleCloudWebriskV1SearchHashesResponseThreatHash> Threats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains threat information on a matching hash.</summary>
    public class GoogleCloudWebriskV1SearchHashesResponseThreatHash : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cache lifetime for the returned match. Clients must not cache this response past this timestamp to avoid
        /// false positives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// A 32 byte SHA256 hash. This field is in binary format. For JSON requests, hashes are base64-encoded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary>The ThreatList this threat belongs to. This must contain at least one entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatTypes")]
        public virtual System.Collections.Generic.IList<string> ThreatTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudWebriskV1SearchUrisResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The threat list matches. This may be empty if the URI is on no list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threat")]
        public virtual GoogleCloudWebriskV1SearchUrisResponseThreatUri Threat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains threat information on a matching uri.</summary>
    public class GoogleCloudWebriskV1SearchUrisResponseThreatUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cache lifetime for the returned match. Clients must not cache this response past this timestamp to avoid
        /// false positives.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The ThreatList this threat belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatTypes")]
        public virtual System.Collections.Generic.IList<string> ThreatTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Wraps a URI that might be displaying malicious content.</summary>
    public class GoogleCloudWebriskV1Submission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// ThreatTypes found to be associated with the submitted URI after reviewing it. This may be empty if the URI
        /// was not added to any list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatTypes")]
        public virtual System.Collections.Generic.IList<string> ThreatTypes { get; set; }

        /// <summary>Required. The URI that is being reported for malicious content to be analyzed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the Submit URI long-running operation.</summary>
    public class GoogleCloudWebriskV1SubmitUriMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The state of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Latest update time of the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to send a potentially malicious URI to WebRisk.</summary>
    public class GoogleCloudWebriskV1SubmitUriRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The submission that contains the URI to be scanned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submission")]
        public virtual GoogleCloudWebriskV1Submission Submission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the set of entries to add to a local database. May contain a combination of compressed and raw data in
    /// a single response.
    /// </summary>
    public class GoogleCloudWebriskV1ThreatEntryAdditions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The raw SHA256-formatted entries. Repeated to allow returning sets of hashes with different prefix sizes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawHashes")]
        public virtual System.Collections.Generic.IList<GoogleCloudWebriskV1RawHashes> RawHashes { get; set; }

        /// <summary>
        /// The encoded 4-byte prefixes of SHA256-formatted entries, using a Golomb-Rice encoding. The hashes are
        /// converted to uint32, sorted in ascending order, then delta encoded and stored as encoded_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceHashes")]
        public virtual GoogleCloudWebriskV1RiceDeltaEncoding RiceHashes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the set of entries to remove from a local database.</summary>
    public class GoogleCloudWebriskV1ThreatEntryRemovals : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The raw removal indices for a local list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawIndices")]
        public virtual GoogleCloudWebriskV1RawIndices RawIndices { get; set; }

        /// <summary>
        /// The encoded local, lexicographically-sorted list indices, using a Golomb-Rice encoding. Used for sending
        /// compressed removal indices. The removal indices (uint32) are sorted in ascending order, then delta encoded
        /// and stored as encoded_data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riceIndices")]
        public virtual GoogleCloudWebriskV1RiceDeltaEncoding RiceIndices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class GoogleLongrunningCancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

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

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
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
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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
}
