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

namespace Google.Apis.GoogleHealthAPI.v4
{
    /// <summary>The GoogleHealthAPI Service.</summary>
    public class GoogleHealthAPIService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v4";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GoogleHealthAPIService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GoogleHealthAPIService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            Users = new UsersResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://health.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://health.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "health";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Health API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Health API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for GoogleHealthAPI requests.</summary>
    public abstract class GoogleHealthAPIBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GoogleHealthAPIBaseServiceRequest instance.</summary>
        protected GoogleHealthAPIBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes GoogleHealthAPI parameter list.</summary>
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
            Subscribers = new SubscribersResource(service);
        }

        /// <summary>Gets the Subscribers resource.</summary>
        public virtual SubscribersResource Subscribers { get; }

        /// <summary>The "subscribers" collection of methods.</summary>
        public class SubscribersResource
        {
            private const string Resource = "subscribers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubscribersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Registers a new subscriber endpoint to receive notifications. A subscriber represents an application or
            /// service that wishes to receive data change notifications for users who have granted consent. **Endpoint
            /// Verification:** For a subscriber to be successfully created, the provided `endpoint_uri` must be a valid
            /// HTTPS endpoint and must pass an automated verification check. The backend will send two HTTP POST
            /// requests to the `endpoint_uri`: 1. **Verification with Authorization:** * **Headers:** Includes
            /// `Content-Type: application/json` and `Authorization` (with the exact value from
            /// `CreateSubscriberPayload.endpoint_authorization.secret`). * **Body:** `{"type": "verification"}` *
            /// **Expected Response:** HTTP `201 Created`. 2. **Verification without Authorization:** * **Headers:**
            /// Includes `Content-Type: application/json`. The `Authorization` header is OMITTED. * **Body:** `{"type":
            /// "verification"}` * **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`. Both tests must
            /// pass for the subscriber creation to succeed. If verification fails, the operation will not be completed
            /// and an error will be returned. This process ensures the endpoint is reachable and correctly validates
            /// the `Authorization` header.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this subscriber will be created. Format: projects/{project} Example:
            /// projects/my-project-123
            /// </param>
            public virtual CreateRequest Create(Google.Apis.GoogleHealthAPI.v4.Data.CreateSubscriberPayload body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Registers a new subscriber endpoint to receive notifications. A subscriber represents an application or
            /// service that wishes to receive data change notifications for users who have granted consent. **Endpoint
            /// Verification:** For a subscriber to be successfully created, the provided `endpoint_uri` must be a valid
            /// HTTPS endpoint and must pass an automated verification check. The backend will send two HTTP POST
            /// requests to the `endpoint_uri`: 1. **Verification with Authorization:** * **Headers:** Includes
            /// `Content-Type: application/json` and `Authorization` (with the exact value from
            /// `CreateSubscriberPayload.endpoint_authorization.secret`). * **Body:** `{"type": "verification"}` *
            /// **Expected Response:** HTTP `201 Created`. 2. **Verification without Authorization:** * **Headers:**
            /// Includes `Content-Type: application/json`. The `Authorization` header is OMITTED. * **Body:** `{"type":
            /// "verification"}` * **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`. Both tests must
            /// pass for the subscriber creation to succeed. If verification fails, the operation will not be completed
            /// and an error will be returned. This process ensures the endpoint is reachable and correctly validates
            /// the `Authorization` header.
            /// </summary>
            public class CreateRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.CreateSubscriberPayload body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this subscriber will be created. Format: projects/{project}
                /// Example: projects/my-project-123
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The ID to use for the subscriber, which will become the final component of the
                /// subscriber's resource name. This value should be 4-36 characters, and valid characters are
                /// /[a-z]([a-z0-9-]{2,34}[a-z0-9])/.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriberId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string SubscriberId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleHealthAPI.v4.Data.CreateSubscriberPayload Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/{+parent}/subscribers";

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
                    RequestParameters.Add("subscriberId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriberId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a subscriber registration. This will stop all notifications to the subscriber's endpoint.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the subscriber to delete. Format: projects/{project}/subscribers/{subscriber}
            /// Example: projects/my-project/subscribers/my-subscriber-123 The {subscriber} ID is user-settable (4-36
            /// characters, matching /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided during
            /// creation.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>
            /// Deletes a subscriber registration. This will stop all notifications to the subscriber's endpoint.
            /// </summary>
            public class DeleteRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the subscriber to delete. Format: projects/{project}/subscribers/{subscriber}
                /// Example: projects/my-project/subscribers/my-subscriber-123 The {subscriber} ID is user-settable
                /// (4-36 characters, matching /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided
                /// during creation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. If set to true, any child resources (e.g., subscriptions) will also be deleted. If false
                /// (default) and child resources exist, the request will fail.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Force { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/{+name}";

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
                        Pattern = @"^projects/[^/]+/subscribers/[^/]+$",
                    });
                    RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                    {
                        Name = "force",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all subscribers registered within the owned Google Cloud Project.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns this collection of subscribers. Format: projects/{project}
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists all subscribers registered within the owned Google Cloud Project.</summary>
            public class ListRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.ListSubscribersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns this collection of subscribers. Format: projects/{project}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of subscribers to return. The service may return fewer than this value.
                /// If unspecified, at most 50 subscribers will be returned. The maximum value is 1000; values above
                /// 1000 will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListSubscribers` call. Provide this to retrieve
                /// the subsequent page. When paginating, all other parameters provided to `ListSubscribers` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/{+parent}/subscribers";

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
            /// Updates the configuration of an existing subscriber, such as the endpoint URI or the data types it's
            /// interested in. **Endpoint Verification:** If the `endpoint_uri` or `endpoint_authorization` field is
            /// included in the `update_mask`, the backend will re-verify the endpoint. The verification process is the
            /// same as described in `CreateSubscriber`: 1. **Verification with Authorization:** POST to the new or
            /// existing `endpoint_uri` with the new or existing `Authorization` secret. Expects HTTP `201 Created`. 2.
            /// **Verification without Authorization:** POST to the `endpoint_uri` without the `Authorization` header.
            /// Expects HTTP `401 Unauthorized` or `403 Forbidden`. Both tests must pass using the potentially updated
            /// values for the subscriber update to succeed. If verification fails, the update will not be applied, and
            /// an error will be returned.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the Subscriber. Format: projects/{project}/subscribers/{subscriber} The
            /// {project} ID is a Google Cloud Project ID or Project Number. The {subscriber} ID is user-settable (4-36
            /// characters, matching /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) if provided during creation, or system-generated
            /// otherwise (e.g., a UUID). Example (User-settable subscriber ID):
            /// projects/my-project/subscribers/my-sub-123 Example (System-generated subscriber ID):
            /// projects/my-project/subscribers/a1b2c3d4-e5f6-7890-1234-567890abcdef
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.GoogleHealthAPI.v4.Data.Subscriber body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>
            /// Updates the configuration of an existing subscriber, such as the endpoint URI or the data types it's
            /// interested in. **Endpoint Verification:** If the `endpoint_uri` or `endpoint_authorization` field is
            /// included in the `update_mask`, the backend will re-verify the endpoint. The verification process is the
            /// same as described in `CreateSubscriber`: 1. **Verification with Authorization:** POST to the new or
            /// existing `endpoint_uri` with the new or existing `Authorization` secret. Expects HTTP `201 Created`. 2.
            /// **Verification without Authorization:** POST to the `endpoint_uri` without the `Authorization` header.
            /// Expects HTTP `401 Unauthorized` or `403 Forbidden`. Both tests must pass using the potentially updated
            /// values for the subscriber update to succeed. If verification fails, the update will not be applied, and
            /// an error will be returned.
            /// </summary>
            public class PatchRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.Subscriber body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the Subscriber. Format: projects/{project}/subscribers/{subscriber}
                /// The {project} ID is a Google Cloud Project ID or Project Number. The {subscriber} ID is
                /// user-settable (4-36 characters, matching /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) if provided during
                /// creation, or system-generated otherwise (e.g., a UUID). Example (User-settable subscriber ID):
                /// projects/my-project/subscribers/my-sub-123 Example (System-generated subscriber ID):
                /// projects/my-project/subscribers/a1b2c3d4-e5f6-7890-1234-567890abcdef
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. A field mask that specifies which fields of the Subscriber message are to be updated. This
                /// allows for partial updates. Supported fields: - endpoint_uri - subscriber_configs -
                /// endpoint_authorization
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.GoogleHealthAPI.v4.Data.Subscriber Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/{+name}";

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
                        Pattern = @"^projects/[^/]+/subscribers/[^/]+$",
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

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            DataTypes = new DataTypesResource(service);
        }

        /// <summary>Gets the DataTypes resource.</summary>
        public virtual DataTypesResource DataTypes { get; }

        /// <summary>The "dataTypes" collection of methods.</summary>
        public class DataTypesResource
        {
            private const string Resource = "dataTypes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DataTypesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                DataPoints = new DataPointsResource(service);
            }

            /// <summary>Gets the DataPoints resource.</summary>
            public virtual DataPointsResource DataPoints { get; }

            /// <summary>The "dataPoints" collection of methods.</summary>
            public class DataPointsResource
            {
                private const string Resource = "dataPoints";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DataPointsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Delete a batch of identifyable data points.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Optional. Parent (data type) for the Data Point collection Format: `users/me/dataTypes/{data_type}`,
                /// e.g.: - `users/me/dataTypes/steps` - `users/me/dataTypes/-` For a list of the supported data types
                /// see the DataPoint data union field. Deleting data points across multiple data type collections is
                /// supported following https://aip.dev/159. If this is set, the parent of all of the data points
                /// specified in `names` must match this field.
                /// </param>
                public virtual BatchDeleteRequest BatchDelete(Google.Apis.GoogleHealthAPI.v4.Data.BatchDeleteDataPointsRequest body, string parent)
                {
                    return new BatchDeleteRequest(this.service, body, parent);
                }

                /// <summary>Delete a batch of identifyable data points.</summary>
                public class BatchDeleteRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Operation>
                {
                    /// <summary>Constructs a new BatchDelete request.</summary>
                    public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.BatchDeleteDataPointsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Optional. Parent (data type) for the Data Point collection Format:
                    /// `users/me/dataTypes/{data_type}`, e.g.: - `users/me/dataTypes/steps` - `users/me/dataTypes/-`
                    /// For a list of the supported data types see the DataPoint data union field. Deleting data points
                    /// across multiple data type collections is supported following https://aip.dev/159. If this is
                    /// set, the parent of all of the data points specified in `names` must match this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleHealthAPI.v4.Data.BatchDeleteDataPointsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchDelete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+parent}/dataPoints:batchDelete";

                    /// <summary>Initializes BatchDelete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a single identifiable data point.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource name where the data point will be created. Format:
                /// `users/{user}/dataTypes/{data_type}`
                /// </param>
                public virtual CreateRequest Create(Google.Apis.GoogleHealthAPI.v4.Data.DataPoint body, string parent)
                {
                    return new CreateRequest(this.service, body, parent);
                }

                /// <summary>Creates a single identifiable data point.</summary>
                public class CreateRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.DataPoint body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource name where the data point will be created. Format:
                    /// `users/{user}/dataTypes/{data_type}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleHealthAPI.v4.Data.DataPoint Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+parent}/dataPoints";

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
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>Roll up data points over civil time intervals for supported data types.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent data type of the Data Point collection. Format:
                /// `users/{user}/dataTypes/{data_type}`, e.g.: - `users/me/dataTypes/steps` -
                /// `users/me/dataTypes/distance` For a list of the supported data types see the DailyRollupDataPoint
                /// value union field.
                /// </param>
                public virtual DailyRollUpRequest DailyRollUp(Google.Apis.GoogleHealthAPI.v4.Data.DailyRollUpDataPointsRequest body, string parent)
                {
                    return new DailyRollUpRequest(this.service, body, parent);
                }

                /// <summary>Roll up data points over civil time intervals for supported data types.</summary>
                public class DailyRollUpRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.DailyRollUpDataPointsResponse>
                {
                    /// <summary>Constructs a new DailyRollUp request.</summary>
                    public DailyRollUpRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.DailyRollUpDataPointsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent data type of the Data Point collection. Format:
                    /// `users/{user}/dataTypes/{data_type}`, e.g.: - `users/me/dataTypes/steps` -
                    /// `users/me/dataTypes/distance` For a list of the supported data types see the
                    /// DailyRollupDataPoint value union field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleHealthAPI.v4.Data.DailyRollUpDataPointsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "dailyRollUp";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+parent}/dataPoints:dailyRollUp";

                    /// <summary>Initializes DailyRollUp parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Exports exercise data in TCX format. Note: While the Authorization section below states that any one
                /// of the listed scopes is accepted, this specific method requires the user to provide both one of the
                /// `activity_and_fitness` scopes (`normal` or `readonly`) AND one of the `location` scopes (`normal` or
                /// `readonly`) in their access token to succeed.
                /// </summary>
                /// <param name="name">
                /// Required. The resource name of the exercise data point to export. Format:
                /// `users/{user}/dataTypes/exercise/dataPoints/{data_point}` Example:
                /// `users/me/dataTypes/exercise/dataPoints/2026443605080188808` The `{user}` is the alias `"me"`
                /// currently. Future versions may support user IDs. The `{data_point}` ID maps to the exercise ID,
                /// which is a long integer.
                /// </param>
                public virtual ExportExerciseTcxRequest ExportExerciseTcx(string name)
                {
                    return new ExportExerciseTcxRequest(this.service, name);
                }

                /// <summary>
                /// Exports exercise data in TCX format. Note: While the Authorization section below states that any one
                /// of the listed scopes is accepted, this specific method requires the user to provide both one of the
                /// `activity_and_fitness` scopes (`normal` or `readonly`) AND one of the `location` scopes (`normal` or
                /// `readonly`) in their access token to succeed.
                /// </summary>
                public class ExportExerciseTcxRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.ExportExerciseTcxResponse>
                {
                    /// <summary>Constructs a new ExportExerciseTcx request.</summary>
                    public ExportExerciseTcxRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name of the exercise data point to export. Format:
                    /// `users/{user}/dataTypes/exercise/dataPoints/{data_point}` Example:
                    /// `users/me/dataTypes/exercise/dataPoints/2026443605080188808` The `{user}` is the alias `"me"`
                    /// currently. Future versions may support user IDs. The `{data_point}` ID maps to the exercise ID,
                    /// which is a long integer.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Indicates whether to include the TCX data points when the GPS data is not available.
                    /// If not specified, defaults to `false` and partial data will not be included.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("partialData", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> PartialData { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "exportExerciseTcx";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+name}:exportExerciseTcx";

                    /// <summary>Initializes ExportExerciseTcx parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+/dataPoints/[^/]+$",
                        });
                        RequestParameters.Add("partialData", new Google.Apis.Discovery.Parameter
                        {
                            Name = "partialData",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                    /// <summary>Gets the media downloader.</summary>
                    public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

                    /// <summary>
                    /// <para>Synchronously download the media into the given stream.</para>
                    /// <para>
                    /// Warning: This method hides download errors; use
                    /// <see cref="DownloadWithStatus(System.IO.Stream)"/> instead.
                    /// </para>
                    /// </summary>
                    /// <remarks>
                    /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress
                    /// event handlers and other configuration may be performed using that property prior to calling
                    /// this method.
                    /// </remarks>
                    public virtual void Download(System.IO.Stream stream)
                    {
                        var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                        mediaDownloader.Range = null;
                        mediaDownloader.Download(this.GenerateRequestUri(), stream);
                    }

                    /// <summary>Synchronously download the media into the given stream.</summary>
                    /// <remarks>
                    /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress
                    /// event handlers and other configuration may be performed using that property prior to calling
                    /// this method.
                    /// </remarks>
                    /// <returns>
                    /// The final status of the download; including whether the download succeeded or failed.
                    /// </returns>
                    public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
                    {
                        var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                        mediaDownloader.Range = null;
                        return mediaDownloader.Download(this.GenerateRequestUri(), stream);
                    }

                    /// <summary>Asynchronously download the media into the given stream.</summary>
                    /// <remarks>
                    /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress
                    /// event handlers and other configuration may be performed using that property prior to calling
                    /// this method.
                    /// </remarks>
                    public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
                    {
                        var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                        mediaDownloader.Range = null;
                        return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
                    }

                    /// <summary>Asynchronously download the media into the given stream.</summary>
                    /// <remarks>
                    /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress
                    /// event handlers and other configuration may be performed using that property prior to calling
                    /// this method.
                    /// </remarks>
                    public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                        System.Threading.CancellationToken cancellationToken)
                    {
                        var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                        mediaDownloader.Range = null;
                        return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
                    }

                    /// <summary>Synchronously download a range of the media into the given stream.</summary>
                    /// <remarks>
                    /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress
                    /// event handlers and other configuration may be performed using that property prior to calling
                    /// this method.
                    /// </remarks>
                    public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
                    {
                        var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                        mediaDownloader.Range = range;
                        return mediaDownloader.Download(this.GenerateRequestUri(), stream);
                    }

                    /// <summary>Asynchronously download a range of the media into the given stream.</summary>
                    /// <remarks>
                    /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress
                    /// event handlers and other configuration may be performed using that property prior to calling
                    /// this method.
                    /// </remarks>
                    public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                        System.Net.Http.Headers.RangeHeaderValue range,
                        System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
                    {
                        var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                        mediaDownloader.Range = range;
                        return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
                    }
                }

                /// <summary>Get a single identifyable data point.</summary>
                /// <param name="name">
                /// Required. The name of the data point to retrieve. Format:
                /// `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}` See DataPoint.name for examples and
                /// possible values.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get a single identifyable data point.</summary>
                public class GetRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.DataPoint>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the data point to retrieve. Format:
                    /// `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}` See DataPoint.name for examples and
                    /// possible values.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+name}";

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
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+/dataPoints/[^/]+$",
                        });
                    }
                }

                /// <summary>Query user health and fitness data points.</summary>
                /// <param name="parent">
                /// Required. Parent data type of the Data Point collection. Format: `users/me/dataTypes/{data_type}`,
                /// e.g.: - `users/me/dataTypes/steps` - `users/me/dataTypes/weight` For a list of the supported data
                /// types see the DataPoint data union field.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Query user health and fitness data points.</summary>
                public class ListRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.ListDataPointsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent data type of the Data Point collection. Format:
                    /// `users/me/dataTypes/{data_type}`, e.g.: - `users/me/dataTypes/steps` -
                    /// `users/me/dataTypes/weight` For a list of the supported data types see the DataPoint data union
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Filter expression following https://google.aip.dev/160. A time range (either physical
                    /// or civil) can be specified. The supported filter fields are: - Interval start time: - Pattern:
                    /// `{interval_data_type}.interval.start_time` - Supported comparison operators: `&amp;gt;=`,
                    /// `&amp;lt;` - Timestamp literal expected in RFC-3339 format - Supported logical operators: `AND`
                    /// - Example: - `steps.interval.start_time &amp;gt;= "2023-11-24T00:00:00Z" AND
                    /// steps.interval.start_time &amp;lt; "2023-11-25T00:00:00Z"` - `distance.interval.start_time
                    /// &amp;gt;= "2024-08-14T12:34:56Z"` - Interval civil start time: - Pattern:
                    /// `{interval_data_type}.interval.civil_start_time` - Supported comparison operators: `&amp;gt;=`,
                    /// `&amp;lt;` - Date with optional time literal expected in ISO 8601 `YYYY-MM-DD[THH:mm:ss]` format
                    /// - Supported logical operators: `AND` - Example: - `steps.interval.civil_start_time &amp;gt;=
                    /// "2023-11-24" AND steps.interval.civil_start_time &amp;lt; "2023-11-25"` -
                    /// `distance.interval.civil_start_time &amp;gt;= "2024-08-14T12:34:56"` - Sample observation
                    /// physical time: - Pattern: `{sample_data_type}.sample_time.physical_time` - Supported comparison
                    /// operators: `&amp;gt;=`, `&amp;lt;` - Timestamp literal expected in RFC-3339 format - Supported
                    /// logical operators: `AND` - Example: - `weight.sample_time.physical_time &amp;gt;=
                    /// "2023-11-24T00:00:00Z" AND weight.sample_time.physical_time &amp;lt; "2023-11-25T00:00:00Z"` -
                    /// `weight.sample_time.physical_time &amp;gt;= "2024-08-14T12:34:56Z"` - Sample observation civil
                    /// time: - Pattern: `{sample_data_type}.sample_time.civil_time` - Supported comparison operators:
                    /// `&amp;gt;=`, `&amp;lt;` - Date with optional time literal expected in ISO 8601
                    /// `YYYY-MM-DD[THH:mm:ss]` format - Supported logical operators: `AND` - Example: -
                    /// `weight.sample_time.civil_time &amp;gt;= "2023-11-24" AND weight.sample_time.civil_time &amp;lt;
                    /// "2023-11-25"` - `weight.sample_time.civil_time &amp;gt;= "2024-08-14T12:34:56"` - Daily summary
                    /// date: - Pattern: `{daily_summary_data_type}.date` - Supported comparison operators: `&amp;gt;=`,
                    /// `&amp;lt;` - Date literal expected in ISO 8601 `YYYY-MM-DD` format - Supported logical
                    /// operators: `AND` - Example: - `daily_heart_rate_variability.date &amp;lt; "2024-08-15"` -
                    /// Session civil start time (**Excluding Sleep**): - Pattern:
                    /// `{session_data_type}.interval.civil_start_time` - Supported comparison operators: `&amp;gt;=`,
                    /// `&amp;lt;` - Date with optional time literal expected in ISO 8601 `YYYY-MM-DD[THH:mm:ss]` format
                    /// - Supported logical operators: `AND` - Example: - `exercise.interval.civil_start_time &amp;gt;=
                    /// "2023-11-24" AND exercise.interval.civil_start_time &amp;lt; "2023-11-25"` -
                    /// `exercise.interval.civil_start_time &amp;gt;= "2024-08-14T12:34:56"` - Session end time (**Sleep
                    /// specific**): - Pattern: `sleep.interval.end_time` - Supported comparison operators: `&amp;gt;=`,
                    /// `&amp;lt;` - Timestamp literal expected in RFC-3339 format - Supported logical operators: `AND`,
                    /// `OR` - Example: - `sleep.interval.end_time &amp;gt;= "2023-11-24T00:00:00Z" AND
                    /// sleep.interval.end_time &amp;lt; "2023-11-25T00:00:00Z"` - Session civil end time (**Sleep
                    /// specific**): - Pattern: `sleep.interval.civil_end_time` - Supported comparison operators:
                    /// `&amp;gt;=`, `&amp;lt;` - Date with optional time literal expected in ISO 8601
                    /// `YYYY-MM-DD[THH:mm:ss]` format - Supported logical operators: `AND`, `OR` - Example: -
                    /// `sleep.interval.civil_end_time &amp;gt;= "2023-11-24" AND sleep.interval.civil_end_time &amp;lt;
                    /// "2023-11-25"` Data points in the response will be ordered by the interval start time in
                    /// descending order.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of data points to return. If unspecified, at most 1440 data points
                    /// will be returned. The maximum page size is 10000; values above that will be truncated
                    /// accordingly. For `exercise` and `sleep` the default page size is 25. The maximum page size for
                    /// `exercise` and `sleep` is 25.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. The `next_page_token` from a previous request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+parent}/dataPoints";

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
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+$",
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

                /// <summary>
                /// Updates a single identifiable data point. If a data point with the specified `name` is not found,
                /// the request will fail.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Identifier. Data point name, only supported for the subset of identifiable data types. For the
                /// majority of the data types, individual data points do not need to be identified and this field would
                /// be empty. Format: `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}` Example:
                /// `users/abcd1234/dataTypes/sleep/dataPoints/a1b2c3d4-e5f6-7890-1234-567890abcdef` The `{user}` ID is
                /// a system-generated identifier, as described in Identity.health_user_id. The `{data_type}` ID
                /// corresponds to the kebab-case version of the field names in the DataPoint data union field, e.g.
                /// `total-calories` for the `total_calories` field. The `{data_point}` ID can be client-provided or
                /// system-generated. If client-provided, it must be a string of 4-63 characters, containing only
                /// lowercase letters, numbers, and hyphens.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.GoogleHealthAPI.v4.Data.DataPoint body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>
                /// Updates a single identifiable data point. If a data point with the specified `name` is not found,
                /// the request will fail.
                /// </summary>
                public class PatchRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.DataPoint body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier. Data point name, only supported for the subset of identifiable data types. For the
                    /// majority of the data types, individual data points do not need to be identified and this field
                    /// would be empty. Format: `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}` Example:
                    /// `users/abcd1234/dataTypes/sleep/dataPoints/a1b2c3d4-e5f6-7890-1234-567890abcdef` The `{user}` ID
                    /// is a system-generated identifier, as described in Identity.health_user_id. The `{data_type}` ID
                    /// corresponds to the kebab-case version of the field names in the DataPoint data union field, e.g.
                    /// `total-calories` for the `total_calories` field. The `{data_point}` ID can be client-provided or
                    /// system-generated. If client-provided, it must be a string of 4-63 characters, containing only
                    /// lowercase letters, numbers, and hyphens.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleHealthAPI.v4.Data.DataPoint Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+name}";

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
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+/dataPoints/[^/]+$",
                        });
                    }
                }

                /// <summary>Reconcile data points from multiple data sources into a single data stream.</summary>
                /// <param name="parent">
                /// Required. Parent data type of the Data Point collection. Format: `users/me/dataTypes/{data_type}`,
                /// e.g.: - `users/me/dataTypes/steps` - `users/me/dataTypes/heart-rate` For a list of the supported
                /// data types see the DataPoint data union field.
                /// </param>
                public virtual ReconcileRequest Reconcile(string parent)
                {
                    return new ReconcileRequest(this.service, parent);
                }

                /// <summary>Reconcile data points from multiple data sources into a single data stream.</summary>
                public class ReconcileRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.ReconcileDataPointsResponse>
                {
                    /// <summary>Constructs a new Reconcile request.</summary>
                    public ReconcileRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent data type of the Data Point collection. Format:
                    /// `users/me/dataTypes/{data_type}`, e.g.: - `users/me/dataTypes/steps` -
                    /// `users/me/dataTypes/heart-rate` For a list of the supported data types see the DataPoint data
                    /// union field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The data source family name to reconcile. If empty, data points from all data sources
                    /// will be reconciled. Format: `users/me/dataSourceFamilies/{data_source_family}` The supported
                    /// values are: - `users/me/dataSourceFamilies/all-sources` - default value -
                    /// `users/me/dataSourceFamilies/google-wearables` - tracker devices -
                    /// `users/me/dataSourceFamilies/google-sources` - Google first party sources
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataSourceFamily", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DataSourceFamily { get; set; }

                    /// <summary>
                    /// Optional. Filter expression based on https://aip.dev/160. A time range, either physical or
                    /// civil, can be specified. See the ListDataPointsRequest.filter for the supported fields and
                    /// syntax.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. The maximum number of data points to return. If unspecified, at most 1440 data points
                    /// will be returned. The maximum page size is 10000; values above that will be truncated
                    /// accordingly. For `exercise` and `sleep` the default page size is 25. The maximum page size for
                    /// `exercise` and `sleep` is 25.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. The `next_page_token` from a previous request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reconcile";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+parent}/dataPoints:reconcile";

                    /// <summary>Initializes Reconcile parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+$",
                        });
                        RequestParameters.Add("dataSourceFamily", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataSourceFamily",
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

                /// <summary>Roll up data points over physical time intervals for supported data types.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent data type of the Data Point collection. Format:
                /// `users/{user}/dataTypes/{data_type}`, e.g.: - `users/me/dataTypes/steps` -
                /// `users/me/dataTypes/distance` For a list of the supported data types see the RollupDataPoint value
                /// union field.
                /// </param>
                public virtual RollUpRequest RollUp(Google.Apis.GoogleHealthAPI.v4.Data.RollUpDataPointsRequest body, string parent)
                {
                    return new RollUpRequest(this.service, body, parent);
                }

                /// <summary>Roll up data points over physical time intervals for supported data types.</summary>
                public class RollUpRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.RollUpDataPointsResponse>
                {
                    /// <summary>Constructs a new RollUp request.</summary>
                    public RollUpRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.RollUpDataPointsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent data type of the Data Point collection. Format:
                    /// `users/{user}/dataTypes/{data_type}`, e.g.: - `users/me/dataTypes/steps` -
                    /// `users/me/dataTypes/distance` For a list of the supported data types see the RollupDataPoint
                    /// value union field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.GoogleHealthAPI.v4.Data.RollUpDataPointsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "rollUp";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v4/{+parent}/dataPoints:rollUp";

                    /// <summary>Initializes RollUp parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^users/[^/]+/dataTypes/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>
        /// Gets the user's identity. It includes the legacy Fitbit user ID and the Google user ID and it can be used by
        /// migrating clients to map identifiers between the two systems.
        /// </summary>
        /// <param name="name">Required. The resource name of the Identity. Format: `users/me/identity`</param>
        public virtual GetIdentityRequest GetIdentity(string name)
        {
            return new GetIdentityRequest(this.service, name);
        }

        /// <summary>
        /// Gets the user's identity. It includes the legacy Fitbit user ID and the Google user ID and it can be used by
        /// migrating clients to map identifiers between the two systems.
        /// </summary>
        public class GetIdentityRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Identity>
        {
            /// <summary>Constructs a new GetIdentity request.</summary>
            public GetIdentityRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The resource name of the Identity. Format: `users/me/identity`</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIdentity";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/{+name}";

            /// <summary>Initializes GetIdentity parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^users/[^/]+/identity$",
                });
            }
        }

        /// <summary>Returns user Profile details.</summary>
        /// <param name="name">Required. The name of the Profile. Format: `users/me/profile`.</param>
        public virtual GetProfileRequest GetProfile(string name)
        {
            return new GetProfileRequest(this.service, name);
        }

        /// <summary>Returns user Profile details.</summary>
        public class GetProfileRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Profile>
        {
            /// <summary>Constructs a new GetProfile request.</summary>
            public GetProfileRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the Profile. Format: `users/me/profile`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getProfile";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/{+name}";

            /// <summary>Initializes GetProfile parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^users/[^/]+/profile$",
                });
            }
        }

        /// <summary>Returns user settings details.</summary>
        /// <param name="name">Required. The name of the Settings. Format: `users/me/settings`.</param>
        public virtual GetSettingsRequest GetSettings(string name)
        {
            return new GetSettingsRequest(this.service, name);
        }

        /// <summary>Returns user settings details.</summary>
        public class GetSettingsRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Settings>
        {
            /// <summary>Constructs a new GetSettings request.</summary>
            public GetSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The name of the Settings. Format: `users/me/settings`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/{+name}";

            /// <summary>Initializes GetSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^users/[^/]+/settings$",
                });
            }
        }

        /// <summary>Updates the user's profile details.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name of this Profile resource. Format: `users/{user}/profile` Example:
        /// `users/1234567890/profile` or `users/me/profile` The {user} ID is a system-generated Google Health API user
        /// ID, a string of 1-63 characters consisting of lowercase and uppercase letters, numbers, and hyphens. The
        /// literal `me` can also be used to refer to the authenticated user.
        /// </param>
        public virtual UpdateProfileRequest UpdateProfile(Google.Apis.GoogleHealthAPI.v4.Data.Profile body, string name)
        {
            return new UpdateProfileRequest(this.service, body, name);
        }

        /// <summary>Updates the user's profile details.</summary>
        public class UpdateProfileRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Profile>
        {
            /// <summary>Constructs a new UpdateProfile request.</summary>
            public UpdateProfileRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.Profile body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name of this Profile resource. Format: `users/{user}/profile` Example:
            /// `users/1234567890/profile` or `users/me/profile` The {user} ID is a system-generated Google Health API
            /// user ID, a string of 1-63 characters consisting of lowercase and uppercase letters, numbers, and
            /// hyphens. The literal `me` can also be used to refer to the authenticated user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleHealthAPI.v4.Data.Profile Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateProfile";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/{+name}";

            /// <summary>Initializes UpdateProfile parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^users/[^/]+/profile$",
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

        /// <summary>Updates the user's settings details.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Identifier. The resource name of this Settings resource. Format: `users/{user}/settings` Example:
        /// `users/1234567890/settings` or `users/me/settings` The {user} ID is a system-generated Google Health API
        /// user ID, a string of 1-63 characters consisting of lowercase and uppercase letters, numbers, and hyphens.
        /// The literal `me` can also be used to refer to the authenticated user.
        /// </param>
        public virtual UpdateSettingsRequest UpdateSettings(Google.Apis.GoogleHealthAPI.v4.Data.Settings body, string name)
        {
            return new UpdateSettingsRequest(this.service, body, name);
        }

        /// <summary>Updates the user's settings details.</summary>
        public class UpdateSettingsRequest : GoogleHealthAPIBaseServiceRequest<Google.Apis.GoogleHealthAPI.v4.Data.Settings>
        {
            /// <summary>Constructs a new UpdateSettings request.</summary>
            public UpdateSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.GoogleHealthAPI.v4.Data.Settings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier. The resource name of this Settings resource. Format: `users/{user}/settings` Example:
            /// `users/1234567890/settings` or `users/me/settings` The {user} ID is a system-generated Google Health API
            /// user ID, a string of 1-63 characters consisting of lowercase and uppercase letters, numbers, and
            /// hyphens. The literal `me` can also be used to refer to the authenticated user.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.GoogleHealthAPI.v4.Data.Settings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/{+name}";

            /// <summary>Initializes UpdateSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^users/[^/]+/settings$",
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
namespace Google.Apis.GoogleHealthAPI.v4.Data
{
    /// <summary>Record of active minutes in a given time interval.</summary>
    public class ActiveMinutes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Active minutes by activity level. At most one record per activity level is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutesByActivityLevel")]
        public virtual System.Collections.Generic.IList<ActiveMinutesByActivityLevel> ActiveMinutesByActivityLevel { get; set; }

        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Active minutes at a given activity level.</summary>
    public class ActiveMinutesByActivityLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Number of whole minutes spent in activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutes")]
        public virtual System.Nullable<long> ActiveMinutes { get; set; }

        /// <summary>Required. The level of activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevel")]
        public virtual string ActivityLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Active minutes by activity level.</summary>
    public class ActiveMinutesRollupByActivityLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of whole minutes spent in activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutesSum")]
        public virtual System.Nullable<long> ActiveMinutesSum { get; set; }

        /// <summary>The level of activity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevel")]
        public virtual string ActivityLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the active minutes data type.</summary>
    public class ActiveMinutesRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Active minutes by activity level. At most one record per activity level is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutesRollupByActivityLevel")]
        public virtual System.Collections.Generic.IList<ActiveMinutesRollupByActivityLevel> ActiveMinutesRollupByActivityLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Record of active zone minutes in a given time interval.</summary>
    public class ActiveZoneMinutes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Number of Active Zone Minutes earned in the given time interval. Note: active_zone_minutes equals
        /// to 1 for low intensity (fat burn) zones or 2 for high intensity zones (cardio, peak).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeZoneMinutes")]
        public virtual System.Nullable<long> ActiveZoneMinutesValue { get; set; }

        /// <summary>
        /// Required. Heart rate zone in which the active zone minutes have been earned, in the given time interval.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateZone")]
        public virtual string HeartRateZone { get; set; }

        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the active zone minutes data type.</summary>
    public class ActiveZoneMinutesRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Active zone minutes in `HeartRateZone.CARDIO`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sumInCardioHeartZone")]
        public virtual System.Nullable<long> SumInCardioHeartZone { get; set; }

        /// <summary>Active zone minutes in `HeartRateZone.FAT_BURN`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sumInFatBurnHeartZone")]
        public virtual System.Nullable<long> SumInFatBurnHeartZone { get; set; }

        /// <summary>Active zone minutes in `HeartRateZone.PEAK`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sumInPeakHeartZone")]
        public virtual System.Nullable<long> SumInPeakHeartZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Internal type to capture activity level during a certain time interval.</summary>
    public class ActivityLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Activity level type in the given time interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevelType")]
        public virtual string ActivityLevelType { get; set; }

        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the total duration in a specific activity level type.</summary>
    public class ActivityLevelRollupByActivityLevelType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Activity level type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevelType")]
        public virtual string ActivityLevelType { get; set; }

        /// <summary>Total duration in the activity level type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDuration")]
        public virtual object TotalDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the activity level data type.</summary>
    public class ActivityLevelRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of total durations in each activity level type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevelRollupsByActivityLevelType")]
        public virtual System.Collections.Generic.IList<ActivityLevelRollupByActivityLevelType> ActivityLevelRollupsByActivityLevelType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures the altitude gain (i.e. deltas), and not level above sea, for a user in millimeters.</summary>
    public class Altitude : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Altitude gain in millimeters over the observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gainMillimeters")]
        public virtual System.Nullable<long> GainMillimeters { get; set; }

        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the user's altitude.</summary>
    public class AltitudeRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sum of the altitude gain in millimeters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gainMillimetersSum")]
        public virtual System.Nullable<long> GainMillimetersSum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Optional metadata for the application that provided this data.</summary>
    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Google OAuth 2.0 client ID of the web application or service that recorded the data. This
        /// is the client ID used during the Google OAuth flow to obtain user credentials. This field is
        /// system-populated when the data is uploaded from Google Web API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleWebClientId")]
        public virtual string GoogleWebClientId { get; set; }

        /// <summary>
        /// Output only. A unique identifier for the mobile application that was the source of the data. This is
        /// typically the application's package name on Android (e.g., `com.google.fitbit`) or the bundle ID on iOS.
        /// This field is informational and helps trace data origin. This field is system-populated when the data is
        /// uploaded from the Fitbit mobile application, Health Connect or Health Kit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Output only. The client ID of the application that recorded the data. This ID is a legacy Fitbit API client
        /// ID, which is different from a Google OAuth client ID. Example format: `ABC123`. This field is
        /// system-populated and used for tracing data from legacy Fitbit API integrations. This field is
        /// system-populated when the data is uploaded from a legacy Fitbit API integration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webClientId")]
        public virtual string WebClientId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Number of calories burned due to basal metabolic rate (BMR) over a period of time.</summary>
    public class BasalEnergyBurned : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>
        /// Required. Number of calories burned due to basal metabolic rate in kilocalories over the observed interval.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kcal")]
        public virtual System.Nullable<double> Kcal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to delete a batch of identifiable data points.</summary>
    public class BatchDeleteDataPointsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The names of the DataPoints to delete. A maximum of 10000 data points can be deleted in a single
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Body fat measurement.</summary>
    public class BodyFat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Body fat percentage, in range [0, 100].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<double> Percentage { get; set; }

        /// <summary>Required. The time at which body fat was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the body fat data type.</summary>
    public class BodyFatRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average body fat percentage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyFatPercentageAvg")]
        public virtual System.Nullable<double> BodyFatPercentageAvg { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the calories in heart rate zone data type.</summary>
    public class CaloriesInHeartRateZoneRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of calories burned in each heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caloriesInHeartRateZones")]
        public virtual System.Collections.Generic.IList<CaloriesInHeartRateZoneValue> CaloriesInHeartRateZones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the amount of kilocalories burned in a specific heart rate zone.</summary>
    public class CaloriesInHeartRateZoneValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateZone")]
        public virtual string HeartRateZone { get; set; }

        /// <summary>The amount of kilocalories burned in the specified heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kcal")]
        public virtual System.Nullable<double> Kcal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Civil time representation similar to google.type.DateTime, but ensures that neither the timezone nor the UTC
    /// offset can be set to avoid confusion between civil and physical time queries.
    /// </summary>
    public class CivilDateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Calendar date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Optional. Time of day. Defaults to the start of the day, at midnight if omitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual TimeOfDay Time { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Counterpart of google.type.Interval, but using CivilDateTime.</summary>
    public class CivilTimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The exclusive end of the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual CivilDateTime End { get; set; }

        /// <summary>Required. The inclusive start of the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual CivilDateTime Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Payload for creating a subscriber.</summary>
    public class CreateSubscriberPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Authorization mechanism for the subscriber endpoint. The `secret` within this message is crucial
        /// for endpoint verification and for securing webhook notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointAuthorization")]
        public virtual EndpointAuthorization EndpointAuthorization { get; set; }

        /// <summary>
        /// Required. The full HTTPS URI where update notifications will be sent. The URI must be a valid URL and use
        /// HTTPS as the scheme. This endpoint will be verified during the `CreateSubscriber` call. See CreateSubscriber
        /// RPC documentation for verification details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>Optional. Configuration for the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberConfigs")]
        public virtual System.Collections.Generic.IList<SubscriberConfig> SubscriberConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the daily heart rate variability data type. At least one of the following fields must be set: -
    /// `average_heart_rate_variability_milliseconds` - `non_rem_heart_rate_beats_per_minute` - `entropy` -
    /// `deep_sleep_root_mean_square_of_successive_differences_milliseconds`
    /// </summary>
    public class DailyHeartRateVariability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A user's average heart rate variability calculated using the root mean square of successive
        /// differences (RMSSD) in times between heartbeats.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageHeartRateVariabilityMilliseconds")]
        public virtual System.Nullable<double> AverageHeartRateVariabilityMilliseconds { get; set; }

        /// <summary>Required. Date (in the user's timezone) of heart rate variability measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Optional. The root mean square of successive differences (RMSSD) value during deep sleep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deepSleepRootMeanSquareOfSuccessiveDifferencesMilliseconds")]
        public virtual System.Nullable<double> DeepSleepRootMeanSquareOfSuccessiveDifferencesMilliseconds { get; set; }

        /// <summary>
        /// Optional. The Shanon entropy of heartbeat intervals. Entropy quantifies randomness or disorder in a system.
        /// High entropy indicates high HRV. Entropy is measured from the histogram of time interval between successive
        /// heart beats values measured during sleep.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entropy")]
        public virtual System.Nullable<double> Entropy { get; set; }

        /// <summary>Optional. Non-REM heart rate</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonRemHeartRateBeatsPerMinute")]
        public virtual System.Nullable<long> NonRemHeartRateBeatsPerMinute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User's heart rate zone thresholds based on the Karvonen algorithm for a specific day.</summary>
    public class DailyHeartRateZones : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Date (in user's timezone) of the heart rate zones record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>Required. The heart rate zones.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateZones")]
        public virtual System.Collections.Generic.IList<HeartRateZone> HeartRateZones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A daily oxygen saturation (SpO2) record. Represents the user's daily oxygen saturation summary, typically
    /// calculated during sleep.
    /// </summary>
    public class DailyOxygenSaturation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The average value of the oxygen saturation samples during the sleep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averagePercentage")]
        public virtual System.Nullable<double> AveragePercentage { get; set; }

        /// <summary>Required. Date (in user's timezone) of the daily oxygen saturation record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Required. The lower bound of the confidence interval of oxygen saturation samples during sleep.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBoundPercentage")]
        public virtual System.Nullable<double> LowerBoundPercentage { get; set; }

        /// <summary>
        /// Optional. Standard deviation of the daily oxygen saturation averages from the past 7-30 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardDeviationPercentage")]
        public virtual System.Nullable<double> StandardDeviationPercentage { get; set; }

        /// <summary>
        /// Required. The upper bound of the confidence interval of oxygen saturation samples during sleep.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperBoundPercentage")]
        public virtual System.Nullable<double> UpperBoundPercentage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A daily average respiratory rate (breaths per minute) for a day of the year. One data point per day calculated
    /// for the main sleep.
    /// </summary>
    public class DailyRespiratoryRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The average number of breaths taken per minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breathsPerMinute")]
        public virtual System.Nullable<double> BreathsPerMinute { get; set; }

        /// <summary>Required. The date on which the respiratory rate was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Measures the daily resting heart rate for a user, calculated using the all day heart rate measurements.
    /// </summary>
    public class DailyRestingHeartRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resting heart rate value in beats per minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatsPerMinute")]
        public virtual System.Nullable<long> BeatsPerMinute { get; set; }

        /// <summary>Optional. Metadata for the daily resting heart rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyRestingHeartRateMetadata")]
        public virtual DailyRestingHeartRateMetadata DailyRestingHeartRateMetadata { get; set; }

        /// <summary>Required. Date (in the user's timezone) of the resting heart rate measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for the daily resting heart rate.</summary>
    public class DailyRestingHeartRateMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The method used to calculate the resting heart rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculationMethod")]
        public virtual string CalculationMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to roll up data points by civil time intervals.</summary>
    public class DailyRollUpDataPointsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The data source family name to roll up. If empty, data points from all available data sources will
        /// be rolled up. Format: `users/me/dataSourceFamilies/{data_source_family}` The supported values are: -
        /// `users/me/dataSourceFamilies/all-sources` - default value - `users/me/dataSourceFamilies/google-wearables` -
        /// tracker devices - `users/me/dataSourceFamilies/google-sources` - Google first party sources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceFamily")]
        public virtual string DataSourceFamily { get; set; }

        /// <summary>
        /// Optional. The maximum number of data points to return. If unspecified, at most 1440 data points will be
        /// returned. The maximum page size is 10000; values above that will be truncated accordingly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. The `next_page_token` from a previous request, if any. All other request fields need to be the
        /// same as in the initial request when the page token is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. Closed-open range of data points that will be rolled up. The start time must be aligned with the
        /// aggregation window. The maximum range for `calories-in-heart-rate-zone`, `heart-rate`, `active-minutes` and
        /// `total-calories` is 14 days. The maximum range for all other data types is 90 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual CivilTimeInterval Range { get; set; }

        /// <summary>Optional. Aggregation window size, in number of days. Defaults to 1 if not specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowSizeDays")]
        public virtual System.Nullable<int> WindowSizeDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the list of rolled up data points.</summary>
    public class DailyRollUpDataPointsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Values for each aggregation time window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollupDataPoints")]
        public virtual System.Collections.Generic.IList<DailyRollupDataPoint> RollupDataPoints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Value of a daily rollup for a single civil time interval (aggregation window)</summary>
    public class DailyRollupDataPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Returned by default when rolling up data points from the `active-minutes` data type, or when requested
        /// explicitly using the `active-minutes` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutes")]
        public virtual ActiveMinutesRollupValue ActiveMinutes { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `active-zone-minutes` data type, or when requested
        /// explicitly using the `active-zone-minutes` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeZoneMinutes")]
        public virtual ActiveZoneMinutesRollupValue ActiveZoneMinutes { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `activity-level` data type, or when requested
        /// explicitly using the `activity-level` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevel")]
        public virtual ActivityLevelRollupValue ActivityLevel { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `altitude` data type, or when requested explicitly
        /// using the `altitude` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual AltitudeRollupValue Altitude { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `body-fat` data type, or when requested explicitly
        /// using the `body-fat` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyFat")]
        public virtual BodyFatRollupValue BodyFat { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `calories-in-heart-rate-zone` data type, or when
        /// requested explicitly using the `calories-in-heart-rate-zone` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caloriesInHeartRateZone")]
        public virtual CaloriesInHeartRateZoneRollupValue CaloriesInHeartRateZone { get; set; }

        /// <summary>End time of the window this value aggregates over</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("civilEndTime")]
        public virtual CivilDateTime CivilEndTime { get; set; }

        /// <summary>Start time of the window this value aggregates over</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("civilStartTime")]
        public virtual CivilDateTime CivilStartTime { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `distance` data type, or when requested explicitly
        /// using the `distance` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distance")]
        public virtual DistanceRollupValue Distance { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `floors` data type, or when requested explicitly
        /// using the `floors` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floors")]
        public virtual FloorsRollupValue Floors { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `heart-rate` data type, or when requested
        /// explicitly using the `heart-rate` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRate")]
        public virtual HeartRateRollupValue HeartRate { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `daily-heart-rate-variability` data type, or when
        /// requested explicitly using the `heart-rate-variability-personal-range` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateVariabilityPersonalRange")]
        public virtual HeartRateVariabilityPersonalRangeRollupValue HeartRateVariabilityPersonalRange { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `hydration-log` data type, or when requested
        /// explicitly using the `hydration-log` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hydrationLog")]
        public virtual HydrationLogRollupValue HydrationLog { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `daily-resting-heart-rate` data type, or when
        /// requested explicitly using the `resting-heart-rate-personal-range` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restingHeartRatePersonalRange")]
        public virtual RestingHeartRatePersonalRangeRollupValue RestingHeartRatePersonalRange { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `run-vo2-max` data type, or when requested
        /// explicitly using the `run-vo2-max` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runVo2Max")]
        public virtual RunVO2MaxRollupValue RunVo2Max { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `sedentary-period` data type, or when requested
        /// explicitly using the `sedentary-period` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sedentaryPeriod")]
        public virtual SedentaryPeriodRollupValue SedentaryPeriod { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `steps` data type, or when requested explicitly
        /// using the `steps` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual StepsRollupValue Steps { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `swim-lengths-data` data type, or when requested
        /// explicitly using the `swim-lengths-data` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swimLengthsData")]
        public virtual SwimLengthsDataRollupValue SwimLengthsData { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `time-in-heart-rate-zone` data type, or when
        /// requested explicitly using the `time-in-heart-rate-zone` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInHeartRateZone")]
        public virtual TimeInHeartRateZoneRollupValue TimeInHeartRateZone { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `total-calories` data type, or when requested
        /// explicitly using the `total-calories` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCalories")]
        public virtual TotalCaloriesRollupValue TotalCalories { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `weight` data type, or when requested explicitly
        /// using the `weight` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual WeightRollupValue Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides derived sleep temperature values, calculated from skin or internal device temperature readings during
    /// sleep.
    /// </summary>
    public class DailySleepTemperatureDerivations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The user's baseline skin temperature. It is the median of the user's nightly skin temperature over
        /// the past 30 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineTemperatureCelsius")]
        public virtual System.Nullable<double> BaselineTemperatureCelsius { get; set; }

        /// <summary>Required. Date for which the sleep temperature derivations are calculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Required. The user's nightly skin temperature. It is the mean of skin temperature samples taken from the
        /// user’s sleep.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nightlyTemperatureCelsius")]
        public virtual System.Nullable<double> NightlyTemperatureCelsius { get; set; }

        /// <summary>
        /// Optional. The standard deviation of the user’s relative nightly skin temperature (temperature - baseline)
        /// over the past 30 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeNightlyStddev30dCelsius")]
        public virtual System.Nullable<double> RelativeNightlyStddev30dCelsius { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains a daily summary of the user's VO2 max (cardio fitness score), which is the maximum rate of oxygen the
    /// body can use during exercise.
    /// </summary>
    public class DailyVO2Max : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Represents the user's cardio fitness level based on their VO2 max.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardioFitnessLevel")]
        public virtual string CardioFitnessLevel { get; set; }

        /// <summary>Required. The date for which the Daily VO2 max was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual Date Date { get; set; }

        /// <summary>
        /// Optional. An estimated field is added to indicate when the confidence has decreased sufficiently to consider
        /// the value an estimation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimated")]
        public virtual System.Nullable<bool> Estimated { get; set; }

        /// <summary>
        /// Required. Daily VO2 max value measured as in ml consumed oxygen / kg of body weight / min.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vo2Max")]
        public virtual System.Nullable<double> Vo2Max { get; set; }

        /// <summary>Optional. The covariance of the VO2 max value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vo2MaxCovariance")]
        public virtual System.Nullable<double> Vo2MaxCovariance { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A computed or recorded metric.</summary>
    public class DataPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Data for points in the `active-minutes` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutes")]
        public virtual ActiveMinutes ActiveMinutes { get; set; }

        /// <summary>
        /// Optional. Data for points in the `active-zone-minutes` interval data type collection, measured in minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeZoneMinutes")]
        public virtual ActiveZoneMinutes ActiveZoneMinutes { get; set; }

        /// <summary>Optional. Data for points in the `activity-level` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevel")]
        public virtual ActivityLevel ActivityLevel { get; set; }

        /// <summary>Optional. Data for points in the `altitude` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual Altitude Altitude { get; set; }

        /// <summary>Optional. Data for points in the `basal-energy-burned` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basalEnergyBurned")]
        public virtual BasalEnergyBurned BasalEnergyBurned { get; set; }

        /// <summary>Optional. Data for points in the `body-fat` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyFat")]
        public virtual BodyFat BodyFat { get; set; }

        /// <summary>
        /// Optional. Data for points in the `daily-heart-rate-variability` daily data type collection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyHeartRateVariability")]
        public virtual DailyHeartRateVariability DailyHeartRateVariability { get; set; }

        /// <summary>Optional. Data for points in the `daily-heart-rate-zones` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyHeartRateZones")]
        public virtual DailyHeartRateZones DailyHeartRateZones { get; set; }

        /// <summary>Optional. Data for points in the `daily-oxygen-saturation` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyOxygenSaturation")]
        public virtual DailyOxygenSaturation DailyOxygenSaturation { get; set; }

        /// <summary>Optional. Data for points in the `daily-respiratory-rate` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyRespiratoryRate")]
        public virtual DailyRespiratoryRate DailyRespiratoryRate { get; set; }

        /// <summary>Optional. Data for points in the `daily-resting-heart-rate` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyRestingHeartRate")]
        public virtual DailyRestingHeartRate DailyRestingHeartRate { get; set; }

        /// <summary>
        /// Optional. Data for points in the `daily-sleep-temperature-derivations` daily data type collection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailySleepTemperatureDerivations")]
        public virtual DailySleepTemperatureDerivations DailySleepTemperatureDerivations { get; set; }

        /// <summary>Optional. Data for points in the `daily-vo2-max` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyVo2Max")]
        public virtual DailyVO2Max DailyVo2Max { get; set; }

        /// <summary>Optional. Data source information for the metric</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual DataSource DataSource { get; set; }

        /// <summary>Optional. Data for points in the `distance` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distance")]
        public virtual Distance Distance { get; set; }

        /// <summary>Optional. Data for points in the `exercise` session data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exercise")]
        public virtual Exercise Exercise { get; set; }

        /// <summary>Optional. Data for points in the `floors` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floors")]
        public virtual Floors Floors { get; set; }

        /// <summary>Optional. Data for points in the `heart-rate` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRate")]
        public virtual HeartRate HeartRate { get; set; }

        /// <summary>Optional. Data for points in the `heart-rate-variability` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateVariability")]
        public virtual HeartRateVariability HeartRateVariability { get; set; }

        /// <summary>Optional. Data for points in the `height` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual Height Height { get; set; }

        /// <summary>Optional. Data for points in the `hydration-log` session data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hydrationLog")]
        public virtual HydrationLog HydrationLog { get; set; }

        /// <summary>
        /// Identifier. Data point name, only supported for the subset of identifiable data types. For the majority of
        /// the data types, individual data points do not need to be identified and this field would be empty. Format:
        /// `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}` Example:
        /// `users/abcd1234/dataTypes/sleep/dataPoints/a1b2c3d4-e5f6-7890-1234-567890abcdef` The `{user}` ID is a
        /// system-generated identifier, as described in Identity.health_user_id. The `{data_type}` ID corresponds to
        /// the kebab-case version of the field names in the DataPoint data union field, e.g. `total-calories` for the
        /// `total_calories` field. The `{data_point}` ID can be client-provided or system-generated. If
        /// client-provided, it must be a string of 4-63 characters, containing only lowercase letters, numbers, and
        /// hyphens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Data for points in the `oxygen-saturation` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oxygenSaturation")]
        public virtual OxygenSaturation OxygenSaturation { get; set; }

        /// <summary>
        /// Optional. Data for points in the `respiratory-rate-sleep-summary` sample data type collection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("respiratoryRateSleepSummary")]
        public virtual RespiratoryRateSleepSummary RespiratoryRateSleepSummary { get; set; }

        /// <summary>Optional. Data for points in the `run-vo2-max` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runVo2Max")]
        public virtual RunVO2Max RunVo2Max { get; set; }

        /// <summary>Optional. Data for points in the `sedentary-period` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sedentaryPeriod")]
        public virtual SedentaryPeriod SedentaryPeriod { get; set; }

        /// <summary>Optional. Data for points in the `sleep` session data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sleep")]
        public virtual Sleep Sleep { get; set; }

        /// <summary>Optional. Data for points in the `steps` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual Steps Steps { get; set; }

        /// <summary>Optional. Data for points in the `swim-lengths-data` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swimLengthsData")]
        public virtual SwimLengthsData SwimLengthsData { get; set; }

        /// <summary>Optional. Data for points in the `time-in-heart-rate-zone` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInHeartRateZone")]
        public virtual TimeInHeartRateZone TimeInHeartRateZone { get; set; }

        /// <summary>Optional. Data for points in the `vo2-max` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vo2Max")]
        public virtual VO2Max Vo2Max { get; set; }

        /// <summary>Optional. Data for points in the `weight` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual Weight Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data Source definition to track the origin of data. Each health data point, regardless of the complexity or data
    /// model (whether a simple step count or a detailed sleep session) must retain information about its source of
    /// origin (e.g. the device or app that collected it).
    /// </summary>
    public class DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Captures metadata for the application that provided this data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual Application Application { get; set; }

        /// <summary>
        /// Optional. Captures metadata for raw data points originating from devices. We expect this data source to be
        /// used for data points written on device sync.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        /// <summary>Output only. Captures the platform that uploaded the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>Optional. Captures how the data was recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingMethod")]
        public virtual string RecordingMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents civil time (or occasionally physical time). This type can represent a civil time in one of a few
    /// possible ways: * When utc_offset is set and time_zone is unset: a civil time on a calendar day with a particular
    /// offset from UTC. * When time_zone is set and utc_offset is unset: a civil time on a calendar day in a particular
    /// time zone. * When neither time_zone nor utc_offset is set: a civil time on a calendar day in local time. The
    /// date is relative to the Proleptic Gregorian Calendar. If year, month, or day are 0, the DateTime is considered
    /// not to have a specific year, month, or day respectively. This type may also be used to represent a physical time
    /// if all the date and time fields are set and either case of the `time_offset` oneof is set. Consider using
    /// `Timestamp` message for physical time instead. If your use case also would like to store the user's timezone,
    /// that can be done in another field. This type is more flexible than some applications may want. Make sure to
    /// document and validate your application's limitations.
    /// </summary>
    public class DateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a datetime
        /// without a day.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>
        /// Optional. Hours of day in 24 hour format. Should be from 0 to 23, defaults to 0 (midnight). An API may
        /// choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Optional. Minutes of hour of day. Must be from 0 to 59, defaults to 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Optional. Month of year. Must be from 1 to 12, or 0 if specifying a datetime without a month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>
        /// Optional. Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999, defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Optional. Seconds of minutes of the time. Must normally be from 0 to 59, defaults to 0. An API may allow the
        /// value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>Time zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>
        /// UTC offset. Must be whole seconds, between -18 hours and +18 hours. For example, a UTC offset of -4:00 would
        /// be represented as { seconds: -14400 }.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>
        /// Optional. Year of date. Must be from 1 to 9999, or 0 if specifying a datetime without a year.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures metadata about the device that recorded the measurement.</summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. An optional name for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Captures the form factor of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>Optional. An optional manufacturer of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Distance traveled over an interval of time.</summary>
    public class Distance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>Required. Distance in millimeters over the observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("millimeters")]
        public virtual System.Nullable<long> Millimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of the rollup of the user's distance.</summary>
    public class DistanceRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sum of the distance in millimeters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("millimetersSum")]
        public virtual System.Nullable<long> MillimetersSum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Authorization mechanism for a subscriber endpoint. For all requests sent by the Webhooks service, the JSON
    /// payload is cryptographically signed. The signature is delivered in the `X-HEALTHAPI-SIGNATURE` HTTP header. This
    /// is an ECDSA (NIST P256) signature of the JSON payload. Clients must verify this signature using Google Health
    /// API's public key to confirm the payload was sent by the Health API.
    /// </summary>
    public class EndpointAuthorization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Input only. Provides a client-provided secret that will be sent with each notification to the
        /// subscriber endpoint using the "Authorization" header. The value must include the authorization scheme, e.g.,
        /// "Bearer " or "Basic ", as it will be used as the full Authorization header value. This secret is used by the
        /// API to test the endpoint during `CreateSubscriber` and `UpdateSubscriber` calls, and will be sent in the
        /// `Authorization` header for all subsequent webhook notifications to this endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>Output only. Whether the secret is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretSet")]
        public virtual System.Nullable<bool> SecretSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An exercise that stores information about a physical activity.</summary>
    public class Exercise : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Duration excluding pauses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDuration")]
        public virtual object ActiveDuration { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Represents the timestamp of the creation of the exercise.</summary>
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

        /// <summary>Required. Exercise display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Optional. Exercise events that happen during an exercise, such as pause &amp; restarts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exerciseEvents")]
        public virtual System.Collections.Generic.IList<ExerciseEvent> ExerciseEvents { get; set; }

        /// <summary>Optional. Additional exercise metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exerciseMetadata")]
        public virtual ExerciseMetadata ExerciseMetadata { get; set; }

        /// <summary>Required. The type of activity performed during an exercise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exerciseType")]
        public virtual string ExerciseType { get; set; }

        /// <summary>Required. Observed exercise interval</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual SessionTimeInterval Interval { get; set; }

        /// <summary>Required. Summary metrics for this exercise ( )</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricsSummary")]
        public virtual MetricsSummary MetricsSummary { get; set; }

        /// <summary>Optional. Standard free-form notes captured at manual logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>
        /// Optional. Laps or splits recorded within an exercise. Laps could be split based on distance or other
        /// criteria (duration, etc.) Laps should not be overlapping with each other.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitSummaries")]
        public virtual System.Collections.Generic.IList<SplitSummary> SplitSummaries { get; set; }

        /// <summary>
        /// Optional. The default split is 1 km or 1 mile. - if the movement distance is less than the default, then
        /// there are no splits - if the movement distance is greater than or equal to the default, then we have splits
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splits")]
        public virtual System.Collections.Generic.IList<SplitSummary> Splits { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. This is the timestamp of the last update to the exercise.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents instantaneous events that happen during an exercise, such as start, stop, pause, split.
    /// </summary>
    public class ExerciseEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Required. Exercise event time</summary>
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

        /// <summary>Required. Exercise event time offset from UTC</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventUtcOffset")]
        public virtual object EventUtcOffset { get; set; }

        /// <summary>Required. The type of the event, such as start, stop, pause, resume.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exerciseEventType")]
        public virtual string ExerciseEventType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional exercise metadata.</summary>
    public class ExerciseMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Whether the exercise had GPS tracking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasGps")]
        public virtual System.Nullable<bool> HasGps { get; set; }

        /// <summary>Optional. Pool length in millimeters. Only present in the swimming exercises.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poolLengthMillimeters")]
        public virtual System.Nullable<long> PoolLengthMillimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Response for exporting exercise data in TCX format.</summary>
    public class ExportExerciseTcxResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains the exported TCX data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcxData")]
        public virtual string TcxData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Gained elevation measured in floors over the time interval</summary>
    public class Floors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Number of floors in the recorded interval</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Required. Observed interval</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the user's floors.</summary>
    public class FloorsRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sum of the floors count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countSum")]
        public virtual System.Nullable<long> CountSum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a type of health data a user can have data points recorded for. It matches the parent resource of
    /// collection containing data points of the given type. Clients currently do not need to interact with this
    /// resource directly.
    /// </summary>
    public class GoogleDevicesandservicesHealthV4DataType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Identifier. The resource name of the data type. Format: `users/{user}/dataTypes/{data_type}` See
        /// DataPoint.name for examples and possible values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Log message for a webhook notification sent by the Google Health API to a subscriber's endpoint. Includes the
    /// HTTP response received from the endpoint.
    /// </summary>
    public class GoogleDevicesandservicesHealthV4WebhookNotificationCloudLog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Represents the HTTP response. This message includes the status code, reason phrase, headers, and
        /// body.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpResponse")]
        public virtual HttpResponse HttpResponse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A heart rate measurement.</summary>
    public class HeartRate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The heart rate value in beats per minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatsPerMinute")]
        public virtual System.Nullable<long> BeatsPerMinute { get; set; }

        /// <summary>Optional. Metadata about the heart rate sample.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual HeartRateMetadata Metadata { get; set; }

        /// <summary>Required. Observation time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Heart rate metadata.</summary>
    public class HeartRateMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates the user’s level of activity when the heart rate sample was measured</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("motionContext")]
        public virtual string MotionContext { get; set; }

        /// <summary>Optional. Indicates the location of the sensor that measured the heart rate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensorLocation")]
        public virtual string SensorLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the heart rate data type.</summary>
    public class HeartRateRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The average heart rate value in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatsPerMinuteAvg")]
        public virtual System.Nullable<double> BeatsPerMinuteAvg { get; set; }

        /// <summary>The maximum heart rate value in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatsPerMinuteMax")]
        public virtual System.Nullable<double> BeatsPerMinuteMax { get; set; }

        /// <summary>The minimum heart rate value in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatsPerMinuteMin")]
        public virtual System.Nullable<double> BeatsPerMinuteMin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Captures user's heart rate variability (HRV) as measured by the root mean square of successive differences
    /// (RMSSD) between normal heartbeats or by standard deviation of the inter-beat intervals (SDNN).
    /// </summary>
    public class HeartRateVariability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The root mean square of successive differences between normal heartbeats. This is a measure of
        /// heart rate variability used by Fitbit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootMeanSquareOfSuccessiveDifferencesMilliseconds")]
        public virtual System.Nullable<double> RootMeanSquareOfSuccessiveDifferencesMilliseconds { get; set; }

        /// <summary>Required. The time of the heart rate variability measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>Optional. The standard deviation of the heart rate variability measurement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardDeviationMilliseconds")]
        public virtual System.Nullable<double> StandardDeviationMilliseconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the result of the rollup of the user's daily heart rate variability personal range.
    /// </summary>
    public class HeartRateVariabilityPersonalRangeRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The upper bound of the user's average heart rate variability personal range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageHeartRateVariabilityMillisecondsMax")]
        public virtual System.Nullable<double> AverageHeartRateVariabilityMillisecondsMax { get; set; }

        /// <summary>The lower bound of the user's average heart rate variability personal range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageHeartRateVariabilityMillisecondsMin")]
        public virtual System.Nullable<double> AverageHeartRateVariabilityMillisecondsMin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The heart rate zone.</summary>
    public class HeartRateZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The heart rate zone type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateZoneType")]
        public virtual string HeartRateZoneType { get; set; }

        /// <summary>Required. Maximum heart rate for this zone in beats per minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBeatsPerMinute")]
        public virtual System.Nullable<long> MaxBeatsPerMinute { get; set; }

        /// <summary>Required. Minimum heart rate for this zone in beats per minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minBeatsPerMinute")]
        public virtual System.Nullable<long> MinBeatsPerMinute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Body height measurement.</summary>
    public class Height : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Height of the user in millimeters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightMillimeters")]
        public virtual System.Nullable<long> HeightMillimeters { get; set; }

        /// <summary>Required. The time at which the height was recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an HTTP header.</summary>
    public class HttpHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP header key. It is case insensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The HTTP header value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an HTTP response.</summary>
    public class HttpResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP response body. If the body is not expected, it should be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>
        /// The HTTP response headers. The ordering of the headers is significant. Multiple headers with the same key
        /// may present for the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<HttpHeader> Headers { get; set; }

        /// <summary>The HTTP reason phrase, such as "OK" or "Not Found".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The HTTP status code, such as 200 or 404.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<int> Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds information about a user logged hydration.</summary>
    public class HydrationLog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Amount of liquid (ex. water) consumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountConsumed")]
        public virtual VolumeQuantity AmountConsumed { get; set; }

        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual SessionTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the hydration log data type.</summary>
    public class HydrationLogRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rollup for amount consumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountConsumed")]
        public virtual VolumeQuantityRollup AmountConsumed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents details about the Google user's identity.</summary>
    public class Identity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The Google User Identifier in the Google Health APIs. It matches the `{user}` resource ID
        /// segment in the resource name paths, e.g. `users/{user}/dataTypes/steps`. Valid values are strings of 1-63
        /// characters, and valid characters are lowercase and uppercase letters, numbers, and hyphens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthUserId")]
        public virtual string HealthUserId { get; set; }

        /// <summary>
        /// Output only. The legacy Fitbit User identifier. This is the Fitbit ID used in the legacy Fitbit APIs
        /// (v1-v3). It can be referenced by clients migrating from the legacy Fitbit APIs to map their existing
        /// identifiers to the new Google user ID. It **must not** be used for any other purpose. It is not of any use
        /// for new clients using only the Google Health APIs. Valid values are strings of 1-63 characters, and valid
        /// characters are lowercase and uppercase letters, numbers, and hyphens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyUserId")]
        public virtual string LegacyUserId { get; set; }

        /// <summary>Identifier. The resource name of this Identity resource. Format: `users/me/identity`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class Interval : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be
        /// before the end.
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

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be
        /// the same or after the start.
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing raw data points matching the query</summary>
    public class ListDataPointsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data points matching the query</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPoints")]
        public virtual System.Collections.Generic.IList<DataPoint> DataPoints { get; set; }

        /// <summary>Next page token, empty if the response is complete</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSubscribers.</summary>
    public class ListSubscribersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Subscribers from the specified project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscribers")]
        public virtual System.Collections.Generic.IList<Subscriber> Subscribers { get; set; }

        /// <summary>The total number of subscribers matching the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary metrics for an exercise.</summary>
    public class MetricsSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Total active zone minutes for the exercise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeZoneMinutes")]
        public virtual System.Nullable<long> ActiveZoneMinutes { get; set; }

        /// <summary>Optional. Average heart rate during the exercise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageHeartRateBeatsPerMinute")]
        public virtual System.Nullable<long> AverageHeartRateBeatsPerMinute { get; set; }

        /// <summary>Optional. Average pace in seconds per meter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averagePaceSecondsPerMeter")]
        public virtual System.Nullable<double> AveragePaceSecondsPerMeter { get; set; }

        /// <summary>Optional. Average speed in millimeters per second.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averageSpeedMillimetersPerSecond")]
        public virtual System.Nullable<double> AverageSpeedMillimetersPerSecond { get; set; }

        /// <summary>Optional. Total calories burned by the user during the exercise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caloriesKcal")]
        public virtual System.Nullable<double> CaloriesKcal { get; set; }

        /// <summary>Optional. Total distance covered by the user during the exercise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceMillimeters")]
        public virtual System.Nullable<double> DistanceMillimeters { get; set; }

        /// <summary>Optional. Total elevation gain during the exercise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("elevationGainMillimeters")]
        public virtual System.Nullable<double> ElevationGainMillimeters { get; set; }

        /// <summary>Optional. Time spent in each heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateZoneDurations")]
        public virtual TimeInHeartRateZones HeartRateZoneDurations { get; set; }

        /// <summary>
        /// Optional. Mobility workouts specific metrics. Only present in the advanced running exercises.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobilityMetrics")]
        public virtual MobilityMetrics MobilityMetrics { get; set; }

        /// <summary>
        /// Optional. Run VO2 max value for the exercise. Only present in the running exercises at the top level as in
        /// the summary of the whole exercise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runVo2Max")]
        public virtual System.Nullable<double> RunVo2Max { get; set; }

        /// <summary>Optional. Total steps taken during the exercise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual System.Nullable<long> Steps { get; set; }

        /// <summary>
        /// Optional. Number of full pool lengths completed during the exercise. Only present in the swimming exercises
        /// at the top level as in the summary of the whole exercise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSwimLengths")]
        public virtual System.Nullable<double> TotalSwimLengths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobility workouts specific metrics</summary>
    public class MobilityMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Cadence is a measure of the frequency of your foot strikes. Steps / min in real time during
        /// workout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgCadenceStepsPerMinute")]
        public virtual System.Nullable<double> AvgCadenceStepsPerMinute { get; set; }

        /// <summary>
        /// Optional. The ground contact time for a particular stride is the amount of time for which the foot was in
        /// contact with the ground on that stride
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgGroundContactTimeDuration")]
        public virtual object AvgGroundContactTimeDuration { get; set; }

        /// <summary>Optional. Stride length is a measure of the distance covered by a single stride</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgStrideLengthMillimeters")]
        public virtual System.Nullable<long> AvgStrideLengthMillimeters { get; set; }

        /// <summary>
        /// Optional. Distance off the ground your center of mass moves with each stride while running
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgVerticalOscillationMillimeters")]
        public virtual System.Nullable<long> AvgVerticalOscillationMillimeters { get; set; }

        /// <summary>Optional. Vertical oscillation/stride length between [5.0, 11.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avgVerticalRatio")]
        public virtual System.Nullable<double> AvgVerticalRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a sample time of an observed data point.</summary>
    public class ObservationSampleTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The civil time in the timezone the subject is in at the time of the observation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("civilTime")]
        public virtual CivilDateTime CivilTime { get; set; }

        private string _physicalTimeRaw;

        private object _physicalTime;

        /// <summary>Required. The time of the observation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("physicalTime")]
        public virtual string PhysicalTimeRaw
        {
            get => _physicalTimeRaw;
            set
            {
                _physicalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _physicalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PhysicalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PhysicalTimeDateTimeOffset instead.")]
        public virtual object PhysicalTime
        {
            get => _physicalTime;
            set
            {
                _physicalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _physicalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PhysicalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PhysicalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PhysicalTimeRaw);
            set => PhysicalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. The offset of the user's local time during the observation relative to the Coordinated Universal
        /// Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time interval of an observed data point.</summary>
    public class ObservationTimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Observed interval end time in civil time in the timezone the subject is in at the end of the
        /// observed interval
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("civilEndTime")]
        public virtual CivilDateTime CivilEndTime { get; set; }

        /// <summary>
        /// Output only. Observed interval start time in civil time in the timezone the subject is in at the start of
        /// the observed interval
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("civilStartTime")]
        public virtual CivilDateTime CivilStartTime { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Required. Observed interval end time.</summary>
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
        /// Required. The offset of the user's local time at the end of the observation relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUtcOffset")]
        public virtual object EndUtcOffset { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. Observed interval start time.</summary>
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
        /// Required. The offset of the user's local time at the start of the observation relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startUtcOffset")]
        public virtual object StartUtcOffset { get; set; }

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

    /// <summary>A time interval to represent an out-of-bed segment.</summary>
    public class OutOfBedSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Required. Segment end time.</summary>
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
        /// Required. The offset of the user's local time at the end of the segment relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUtcOffset")]
        public virtual object EndUtcOffset { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. Segment tart time.</summary>
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
        /// Required. The offset of the user's local time at the start of the segment relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startUtcOffset")]
        public virtual object StartUtcOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures the user's instantaneous oxygen saturation percentage (SpO2).</summary>
    public class OxygenSaturation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The oxygen saturation percentage. Valid values are from 0 to 100.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentage")]
        public virtual System.Nullable<double> Percentage { get; set; }

        /// <summary>Required. The time at which oxygen saturation was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Profile details.</summary>
    public class Profile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The age in years based on the user's birth date. Updates to this field are currently not
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("age")]
        public virtual System.Nullable<int> Age { get; set; }

        /// <summary>
        /// Output only. The automatically calculated running stride length, in millimeters. The user must consent to
        /// one of the following access scopes to access this field: -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness.readonly` -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRunningStrideLengthMm")]
        public virtual System.Nullable<int> AutoRunningStrideLengthMm { get; set; }

        /// <summary>
        /// Output only. The automatically calculated walking stride length, in millimeters. The user must consent to
        /// one of the following access scopes to access this field: -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness.readonly` -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoWalkingStrideLengthMm")]
        public virtual System.Nullable<int> AutoWalkingStrideLengthMm { get; set; }

        /// <summary>
        /// Output only. The date the user created their account. Updates to this field are currently not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membershipStartDate")]
        public virtual Date MembershipStartDate { get; set; }

        /// <summary>
        /// Identifier. The resource name of this Profile resource. Format: `users/{user}/profile` Example:
        /// `users/1234567890/profile` or `users/me/profile` The {user} ID is a system-generated Google Health API user
        /// ID, a string of 1-63 characters consisting of lowercase and uppercase letters, numbers, and hyphens. The
        /// literal `me` can also be used to refer to the authenticated user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The user's user configured running stride length, in millimeters. The user must consent to one of
        /// the following access scopes to access this field: -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness.readonly` -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userConfiguredRunningStrideLengthMm")]
        public virtual System.Nullable<int> UserConfiguredRunningStrideLengthMm { get; set; }

        /// <summary>
        /// Optional. The user's user configured walking stride length, in millimeters. The user must consent to one of
        /// the following access scopes to access this field: -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness.readonly` -
        /// `https://www.googleapis.com/auth/googlehealth.activity_and_fitness`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userConfiguredWalkingStrideLengthMm")]
        public virtual System.Nullable<int> UserConfiguredWalkingStrideLengthMm { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the list of reconciled DataPoints.</summary>
    public class ReconcileDataPointsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data points matching the query</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPoints")]
        public virtual System.Collections.Generic.IList<ReconciledDataPoint> DataPoints { get; set; }

        /// <summary>Next page token, empty if the response is complete</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reconciled computed or recorded metric.</summary>
    public class ReconciledDataPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data for points in the `active-minutes` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutes")]
        public virtual ActiveMinutes ActiveMinutes { get; set; }

        /// <summary>
        /// Data for points in the `active-zone-minutes` interval data type collection, measured in minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeZoneMinutes")]
        public virtual ActiveZoneMinutes ActiveZoneMinutes { get; set; }

        /// <summary>Data for points in the `activity-level` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevel")]
        public virtual ActivityLevel ActivityLevel { get; set; }

        /// <summary>Data for points in the `altitude` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual Altitude Altitude { get; set; }

        /// <summary>Data for points in the `basal-energy-burned` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basalEnergyBurned")]
        public virtual BasalEnergyBurned BasalEnergyBurned { get; set; }

        /// <summary>Data for points in the `body-fat` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyFat")]
        public virtual BodyFat BodyFat { get; set; }

        /// <summary>Data for points in the `daily-heart-rate-variability` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyHeartRateVariability")]
        public virtual DailyHeartRateVariability DailyHeartRateVariability { get; set; }

        /// <summary>Data for points in the `daily-heart-rate-zones` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyHeartRateZones")]
        public virtual DailyHeartRateZones DailyHeartRateZones { get; set; }

        /// <summary>Data for points in the `daily-oxygen-saturation` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyOxygenSaturation")]
        public virtual DailyOxygenSaturation DailyOxygenSaturation { get; set; }

        /// <summary>Data for points in the `daily-respiratory-rate` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyRespiratoryRate")]
        public virtual DailyRespiratoryRate DailyRespiratoryRate { get; set; }

        /// <summary>Data for points in the `daily-resting-heart-rate` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyRestingHeartRate")]
        public virtual DailyRestingHeartRate DailyRestingHeartRate { get; set; }

        /// <summary>Data for points in the `daily-sleep-temperature-derivations` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailySleepTemperatureDerivations")]
        public virtual DailySleepTemperatureDerivations DailySleepTemperatureDerivations { get; set; }

        /// <summary>Data for points in the `daily-vo2-max` daily data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailyVo2Max")]
        public virtual DailyVO2Max DailyVo2Max { get; set; }

        /// <summary>
        /// Identifier. Data point name, only supported for the subset of identifiable data types. For the majority of
        /// the data types, individual data points do not need to be identified and this field would be empty. Format:
        /// `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}` Example:
        /// `users/abcd1234/dataTypes/sleep/dataPoints/a1b2c3d4-e5f6-7890-1234-567890abcdef` The `{user}` ID is a
        /// system-generated identifier, as described in Identity.health_user_id. The `{data_type}` ID corresponds to
        /// the kebab-case version of the field names in the DataPoint data union field, e.g. `total-calories` for the
        /// `total_calories` field. The `{data_point}` ID can be client-provided or system-generated. If
        /// client-provided, it must be a string of 4-63 characters, containing only lowercase letters, numbers, and
        /// hyphens.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPointName")]
        public virtual string DataPointName { get; set; }

        /// <summary>Data for points in the `distance` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distance")]
        public virtual Distance Distance { get; set; }

        /// <summary>Data for points in the `exercise` session data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exercise")]
        public virtual Exercise Exercise { get; set; }

        /// <summary>Data for points in the `floors` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floors")]
        public virtual Floors Floors { get; set; }

        /// <summary>Data for points in the `heart-rate` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRate")]
        public virtual HeartRate HeartRate { get; set; }

        /// <summary>Data for points in the `heart-rate-variability` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateVariability")]
        public virtual HeartRateVariability HeartRateVariability { get; set; }

        /// <summary>Data for points in the `height` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual Height Height { get; set; }

        /// <summary>Data for points in the `hydration-log` session data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hydrationLog")]
        public virtual HydrationLog HydrationLog { get; set; }

        /// <summary>Data for points in the `oxygen-saturation` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oxygenSaturation")]
        public virtual OxygenSaturation OxygenSaturation { get; set; }

        /// <summary>Data for points in the `respiratory-rate-sleep-summary` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("respiratoryRateSleepSummary")]
        public virtual RespiratoryRateSleepSummary RespiratoryRateSleepSummary { get; set; }

        /// <summary>Data for points in the `run-vo2-max` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runVo2Max")]
        public virtual RunVO2Max RunVo2Max { get; set; }

        /// <summary>Data for points in the `sedentary-period` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sedentaryPeriod")]
        public virtual SedentaryPeriod SedentaryPeriod { get; set; }

        /// <summary>Data for points in the `sleep` session data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sleep")]
        public virtual Sleep Sleep { get; set; }

        /// <summary>Data for points in the `steps` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual Steps Steps { get; set; }

        /// <summary>Data for points in the `swim-lengths-data` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swimLengthsData")]
        public virtual SwimLengthsData SwimLengthsData { get; set; }

        /// <summary>Data for points in the `time-in-heart-rate-zone` interval data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInHeartRateZone")]
        public virtual TimeInHeartRateZone TimeInHeartRateZone { get; set; }

        /// <summary>Data for points in the `vo2-max` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vo2Max")]
        public virtual VO2Max Vo2Max { get; set; }

        /// <summary>Data for points in the `weight` sample data type collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual Weight Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Records respiratory rate details during sleep. Can have multiple per day if the user sleeps multiple times.
    /// </summary>
    public class RespiratoryRateSleepSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Respiratory rate statistics for deep sleep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deepSleepStats")]
        public virtual RespiratoryRateSleepSummaryStatistics DeepSleepStats { get; set; }

        /// <summary>Required. Full respiratory rate statistics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullSleepStats")]
        public virtual RespiratoryRateSleepSummaryStatistics FullSleepStats { get; set; }

        /// <summary>Optional. Respiratory rate statistics for light sleep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lightSleepStats")]
        public virtual RespiratoryRateSleepSummaryStatistics LightSleepStats { get; set; }

        /// <summary>Optional. Respiratory rate statistics for REM sleep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remSleepStats")]
        public virtual RespiratoryRateSleepSummaryStatistics RemSleepStats { get; set; }

        /// <summary>Required. The time at which respiratory rate was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Respiratory rate statistics for a given sleep stage.</summary>
    public class RespiratoryRateSleepSummaryStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Average breaths per minute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breathsPerMinute")]
        public virtual System.Nullable<double> BreathsPerMinute { get; set; }

        /// <summary>Optional. How trustworthy the data is for the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalToNoise")]
        public virtual System.Nullable<double> SignalToNoise { get; set; }

        /// <summary>Optional. Standard deviation of the respiratory rate during sleep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standardDeviation")]
        public virtual System.Nullable<double> StandardDeviation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the rollup value for the daily resting heart rate data type.</summary>
    public class RestingHeartRatePersonalRangeRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The upper bound of the user's daily resting heart rate personal range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatsPerMinuteMax")]
        public virtual System.Nullable<double> BeatsPerMinuteMax { get; set; }

        /// <summary>The lower bound of the user's daily resting heart rate personal range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("beatsPerMinuteMin")]
        public virtual System.Nullable<double> BeatsPerMinuteMin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to roll up data points by physical time intervals.</summary>
    public class RollUpDataPointsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The data source family name to roll up. If empty, data points from all available data sources will
        /// be rolled up. Format: `users/me/dataSourceFamilies/{data_source_family}` The supported values are: -
        /// `users/me/dataSourceFamilies/all-sources` - default value - `users/me/dataSourceFamilies/google-wearables` -
        /// tracker devices - `users/me/dataSourceFamilies/google-sources` - Google first party sources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceFamily")]
        public virtual string DataSourceFamily { get; set; }

        /// <summary>
        /// Optional. The maximum number of data points to return. If unspecified, at most 1440 data points will be
        /// returned. The maximum page size is 10000; values above that will be truncated accordingly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. The next_page_token from a previous request, if any. All other request fields need to be the same
        /// as in the initial request when the page token is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>
        /// Required. Closed-open range of data points that will be rolled up. The maximum range for
        /// `calories-in-heart-rate-zone`, `heart-rate`, `active-minutes` and `total-calories` is 14 days. The maximum
        /// range for all other data types is 90 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual Interval Range { get; set; }

        /// <summary>
        /// Required. The size of the time window to group data points into before applying the aggregation functions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowSize")]
        public virtual object WindowSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the list of rolled up data points.</summary>
    public class RollUpDataPointsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Values for each aggregation time window.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollupDataPoints")]
        public virtual System.Collections.Generic.IList<RollupDataPoint> RollupDataPoints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Value of a rollup for a single physical time interval (aggregation window)</summary>
    public class RollupDataPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Returned by default when rolling up data points from the `active-minutes` data type, or when requested
        /// explicitly using the `active-minutes` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeMinutes")]
        public virtual ActiveMinutesRollupValue ActiveMinutes { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `active-zone-minutes` data type, or when requested
        /// explicitly using the `active-zone-minutes` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeZoneMinutes")]
        public virtual ActiveZoneMinutesRollupValue ActiveZoneMinutes { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `activity-level` data type, or when requested
        /// explicitly using the `activity-level` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityLevel")]
        public virtual ActivityLevelRollupValue ActivityLevel { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `altitude` data type, or when requested explicitly
        /// using the `altitude` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altitude")]
        public virtual AltitudeRollupValue Altitude { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `body-fat` data type, or when requested explicitly
        /// using the `body-fat` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bodyFat")]
        public virtual BodyFatRollupValue BodyFat { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `calories-in-heart-rate-zone` data type, or when
        /// requested explicitly using the `calories-in-heart-rate-zone` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caloriesInHeartRateZone")]
        public virtual CaloriesInHeartRateZoneRollupValue CaloriesInHeartRateZone { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `distance` data type, or when requested explicitly
        /// using the `distance` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distance")]
        public virtual DistanceRollupValue Distance { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>End time of the window this value aggregates over</summary>
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
        /// Returned by default when rolling up data points from the `floors` data type, or when requested explicitly
        /// using the `floors` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floors")]
        public virtual FloorsRollupValue Floors { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `heart-rate` data type, or when requested
        /// explicitly using the `heart-rate` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRate")]
        public virtual HeartRateRollupValue HeartRate { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `hydration-log` data type, or when requested
        /// explicitly using the `hydration-log` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hydrationLog")]
        public virtual HydrationLogRollupValue HydrationLog { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `run-vo2-max` data type, or when requested
        /// explicitly using the `run-vo2-max` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runVo2Max")]
        public virtual RunVO2MaxRollupValue RunVo2Max { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `sedentary-period` data type, or when requested
        /// explicitly using the `sedentary-period` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sedentaryPeriod")]
        public virtual SedentaryPeriodRollupValue SedentaryPeriod { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Start time of the window this value aggregates over</summary>
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
        /// Returned by default when rolling up data points from the `steps` data type, or when requested explicitly
        /// using the `steps` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("steps")]
        public virtual StepsRollupValue Steps { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `swim-lengths-data` data type, or when requested
        /// explicitly using the `swim-lengths-data` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swimLengthsData")]
        public virtual SwimLengthsDataRollupValue SwimLengthsData { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `time-in-heart-rate-zone` data type, or when
        /// requested explicitly using the `time-in-heart-rate-zone` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInHeartRateZone")]
        public virtual TimeInHeartRateZoneRollupValue TimeInHeartRateZone { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `total-calories` data type, or when requested
        /// explicitly using the `total-calories` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCalories")]
        public virtual TotalCaloriesRollupValue TotalCalories { get; set; }

        /// <summary>
        /// Returned by default when rolling up data points from the `weight` data type, or when requested explicitly
        /// using the `weight` rollup type identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual WeightRollupValue Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VO2 max value calculated based on the user's running activity. Value stored in ml/kg/min.</summary>
    public class RunVO2Max : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Run VO2 max value in ml/kg/min.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runVo2Max")]
        public virtual System.Nullable<double> RunVo2Max { get; set; }

        /// <summary>Required. The time at which the metric was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the result of the rollup of the user's daily heart rate variability personal range.
    /// </summary>
    public class RunVO2MaxRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average value of run VO2 max in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateAvg")]
        public virtual System.Nullable<double> RateAvg { get; set; }

        /// <summary>Maximum value of run VO2 max in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateMax")]
        public virtual System.Nullable<double> RateMax { get; set; }

        /// <summary>Minimum value of run VO2 max in the interval..</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rateMin")]
        public virtual System.Nullable<double> RateMin { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// SedentaryPeriod SedentaryPeriod data represents the periods of time that the user was sedentary (i.e. not moving
    /// while wearing the device).
    /// </summary>
    public class SedentaryPeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the user's sedentary periods.</summary>
    public class SedentaryPeriodRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total time user spent sedentary during the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationSum")]
        public virtual object DurationSum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval of session data point, which bundles multiple observed metrics together.
    /// </summary>
    public class SessionTimeInterval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Session end time in civil time in the timezone the subject is in at the end of the session.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("civilEndTime")]
        public virtual CivilDateTime CivilEndTime { get; set; }

        /// <summary>
        /// Output only. Session start time in civil time in the timezone the subject is in at the start of the session.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("civilStartTime")]
        public virtual CivilDateTime CivilStartTime { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Required. The end time of the observed session.</summary>
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
        /// Required. The offset of the user's local time at the end of the session relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUtcOffset")]
        public virtual object EndUtcOffset { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. The start time of the observed session.</summary>
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
        /// Required. The offset of the user's local time at the start of the session relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startUtcOffset")]
        public virtual object StartUtcOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings details.</summary>
    public class Settings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. True if the user's stride length is determined automatically. Updates to this field are currently
        /// not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoStrideEnabled")]
        public virtual System.Nullable<bool> AutoStrideEnabled { get; set; }

        /// <summary>
        /// Optional. The measurement unit defined in the user's account settings. Updates to this field are currently
        /// not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distanceUnit")]
        public virtual string DistanceUnit { get; set; }

        /// <summary>Optional. The measurement unit defined in the user's account settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glucoseUnit")]
        public virtual string GlucoseUnit { get; set; }

        /// <summary>Optional. The measurement unit defined in the user's account settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightUnit")]
        public virtual string HeightUnit { get; set; }

        /// <summary>
        /// Optional. The locale defined in the user's account settings. Updates to this field are currently not
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageLocale")]
        public virtual string LanguageLocale { get; set; }

        /// <summary>
        /// Identifier. The resource name of this Settings resource. Format: `users/{user}/settings` Example:
        /// `users/1234567890/settings` or `users/me/settings` The {user} ID is a system-generated Google Health API
        /// user ID, a string of 1-63 characters consisting of lowercase and uppercase letters, numbers, and hyphens.
        /// The literal `me` can also be used to refer to the authenticated user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The stride length type defined in the user's account settings for running. Updates to this field
        /// are currently not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strideLengthRunningType")]
        public virtual string StrideLengthRunningType { get; set; }

        /// <summary>
        /// Optional. The stride length type defined in the user's account settings for walking. Updates to this field
        /// are currently not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strideLengthWalkingType")]
        public virtual string StrideLengthWalkingType { get; set; }

        /// <summary>Optional. The measurement unit defined in the user's account settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swimUnit")]
        public virtual string SwimUnit { get; set; }

        /// <summary>Optional. The measurement unit defined in the user's account settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temperatureUnit")]
        public virtual string TemperatureUnit { get; set; }

        /// <summary>
        /// Optional. The timezone defined in the user's account settings. This follows the IANA [Time Zone
        /// Database](https://www.iana.org/time-zones). Updates to this field are currently not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// Optional. The user's timezone offset relative to UTC. Updates to this field are currently not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utcOffset")]
        public virtual object UtcOffset { get; set; }

        /// <summary>Optional. The measurement unit defined in the user's account settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterUnit")]
        public virtual string WaterUnit { get; set; }

        /// <summary>Optional. The measurement unit defined in the user's account settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightUnit")]
        public virtual string WeightUnit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A sleep session possibly including stages.</summary>
    public class Sleep : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this sleep observation.</summary>
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

        /// <summary>Required. Observed sleep interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual SessionTimeInterval Interval { get; set; }

        /// <summary>Optional. Sleep metadata: processing, main, manually edited, stages status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual SleepMetadata Metadata { get; set; }

        /// <summary>Optional. “Out of bed” segments that can overlap with sleep stages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfBedSegments")]
        public virtual System.Collections.Generic.IList<OutOfBedSegment> OutOfBedSegments { get; set; }

        /// <summary>
        /// Optional. List of non-overlapping contiguous sleep stage segments that cover the sleep period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stages")]
        public virtual System.Collections.Generic.IList<SleepStage> Stages { get; set; }

        /// <summary>Output only. Sleep summary: metrics and stages summary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual SleepSummary Summary { get; set; }

        /// <summary>Optional. SleepType: classic or stages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this sleep observation.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional information about how the sleep was processed.</summary>
    public class SleepMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Sleep identifier relevant in the context of the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalId")]
        public virtual string ExternalId { get; set; }

        /// <summary>Output only. Some sleeps autodetected by algorithms can be manually edited by users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manuallyEdited")]
        public virtual System.Nullable<bool> ManuallyEdited { get; set; }

        /// <summary>Output only. Naps are sleeps without stages and relatively short durations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nap")]
        public virtual System.Nullable<bool> Nap { get; set; }

        /// <summary>Output only. Sleep and sleep stages algorithms finished processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processed")]
        public virtual System.Nullable<bool> Processed { get; set; }

        /// <summary>Output only. Sleep stages algorithm processing status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stagesStatus")]
        public virtual string StagesStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sleep stage segment.</summary>
    public class SleepStage : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Creation time of this sleep stages segment.</summary>
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

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Required. Sleep stage end time.</summary>
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
        /// Required. The offset of the user's local time at the end of the sleep stage relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUtcOffset")]
        public virtual object EndUtcOffset { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. Sleep stage start time.</summary>
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
        /// Required. The offset of the user's local time at the start of the sleep stage relative to the Coordinated
        /// Universal Time (UTC).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startUtcOffset")]
        public virtual object StartUtcOffset { get; set; }

        /// <summary>Required. Sleep stage type: AWAKE, DEEP, REM, LIGHT etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Last update time of this sleep stages segment.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary> Sleep summary: metrics and stages summary.</summary>
    public class SleepSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Minutes after wake up calculated by restlessness algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutesAfterWakeUp")]
        public virtual System.Nullable<long> MinutesAfterWakeUp { get; set; }

        /// <summary>
        /// Output only. Total number of minutes asleep. For classic sleep it is the sum of ASLEEP stages (excluding
        /// AWAKE and RESTLESS). For "stages" sleep it is the sum of LIGHT, REM and DEEP stages (excluding AWAKE).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutesAsleep")]
        public virtual System.Nullable<long> MinutesAsleep { get; set; }

        /// <summary>Output only. Total number of minutes awake. It is a sum of all AWAKE stages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutesAwake")]
        public virtual System.Nullable<long> MinutesAwake { get; set; }

        /// <summary>Output only. Delta between wake time and bedtime. It is the sum of all stages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutesInSleepPeriod")]
        public virtual System.Nullable<long> MinutesInSleepPeriod { get; set; }

        /// <summary>Output only. Minutes to fall asleep calculated by restlessness algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutesToFallAsleep")]
        public virtual System.Nullable<long> MinutesToFallAsleep { get; set; }

        /// <summary>
        /// Output only. List of summaries (total duration and segment count) per each sleep stage type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stagesSummary")]
        public virtual System.Collections.Generic.IList<StageSummary> StagesSummary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents splits or laps recorded within an exercise. Lap events partition a workout into segments based on
    /// criteria like distance, time, or calories.
    /// </summary>
    public class SplitSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Lap time excluding the pauses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDuration")]
        public virtual object ActiveDuration { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Required. Lap end time</summary>
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

        /// <summary>Required. Lap end time offset from UTC</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endUtcOffset")]
        public virtual object EndUtcOffset { get; set; }

        /// <summary>Required. Summary metrics for this split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricsSummary")]
        public virtual MetricsSummary MetricsSummary { get; set; }

        /// <summary>
        /// Required. Method used to split the exercise laps. Users may manually mark the lap as complete even if the
        /// tracking is automatic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitType")]
        public virtual string SplitType { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. Lap start time</summary>
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

        /// <summary>Required. Lap start time offset from UTC</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startUtcOffset")]
        public virtual object StartUtcOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Total duration and segment count for a stage.</summary>
    public class StageSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of sleep stages segments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Output only. Total duration in minutes of a sleep stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<long> Minutes { get; set; }

        /// <summary>Output only. Sleep stage type: AWAKE, DEEP, REM, LIGHT etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

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

    /// <summary>Step count over the time interval.</summary>
    public class Steps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Number of steps in the recorded interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the steps data type.</summary>
    public class StepsRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of steps in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countSum")]
        public virtual System.Nullable<long> CountSum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>-- Resource Messages -- A subscriber receives notifications from Google Health API.</summary>
    public class Subscriber : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time at which the subscriber was created.</summary>
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
        /// Required. Authorization mechanism for a subscriber endpoint. This is required to ensure the endpoint can be
        /// verified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointAuthorization")]
        public virtual EndpointAuthorization EndpointAuthorization { get; set; }

        /// <summary>
        /// Required. The full HTTPS URI where update notifications will be sent. The URI must be a valid URL and use
        /// HTTPS as the scheme. This endpoint will be verified during CreateSubscriber and UpdateSubscriber calls. See
        /// RPC documentation for verification details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpointUri")]
        public virtual string EndpointUri { get; set; }

        /// <summary>
        /// Identifier. The resource name of the Subscriber. Format: projects/{project}/subscribers/{subscriber} The
        /// {project} ID is a Google Cloud Project ID or Project Number. The {subscriber} ID is user-settable (4-36
        /// characters, matching /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) if provided during creation, or system-generated
        /// otherwise (e.g., a UUID). Example (User-settable subscriber ID): projects/my-project/subscribers/my-sub-123
        /// Example (System-generated subscriber ID):
        /// projects/my-project/subscribers/a1b2c3d4-e5f6-7890-1234-567890abcdef
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Configuration for the subscriber.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberConfigs")]
        public virtual System.Collections.Generic.IList<SubscriberConfig> SubscriberConfigs { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the subscriber was last updated.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for a subscriber. A notification is sent to a subscription ONLY if the subscriber has a config for
    /// the data type.
    /// </summary>
    public class SubscriberConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Supported data types are: "altitude", "distance", "floors", "sleep", "steps", "weight". Values
        /// should be in kebab-case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypes")]
        public virtual System.Collections.Generic.IList<string> DataTypes { get; set; }

        /// <summary>Required. Policy for subscription creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionCreatePolicy")]
        public virtual string SubscriptionCreatePolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Swim lengths data over the time interval.</summary>
    public class SwimLengthsData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>Required. Number of strokes in the lap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strokeCount")]
        public virtual System.Nullable<long> StrokeCount { get; set; }

        /// <summary>Required. Swim stroke type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("swimStrokeType")]
        public virtual string SwimStrokeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the swim lengths data type.</summary>
    public class SwimLengthsDataRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of swim strokes in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strokeCountSum")]
        public virtual System.Nullable<long> StrokeCountSum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time in heart rate zone record. It's an interval spent in specific heart rate zone.</summary>
    public class TimeInHeartRateZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Heart rate zone type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateZoneType")]
        public virtual string HeartRateZoneType { get; set; }

        /// <summary>Required. Observed interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual ObservationTimeInterval Interval { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the time in heart rate zone data type.</summary>
    public class TimeInHeartRateZoneRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of time spent in each heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeInHeartRateZones")]
        public virtual System.Collections.Generic.IList<TimeInHeartRateZoneValue> TimeInHeartRateZones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the total time spent in a specific heart rate zone.</summary>
    public class TimeInHeartRateZoneValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The total time spent in the specified heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heartRateZone")]
        public virtual string HeartRateZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time spent in each heart rate zone.</summary>
    public class TimeInHeartRateZones : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Time spent in light heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lightTime")]
        public virtual object LightTime { get; set; }

        /// <summary>Optional. Time spent in moderate heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moderateTime")]
        public virtual object ModerateTime { get; set; }

        /// <summary>Optional. Time spent in peak heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("peakTime")]
        public virtual object PeakTime { get; set; }

        /// <summary>Optional. Time spent in vigorous heart rate zone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vigorousTime")]
        public virtual object VigorousTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of a day in 24 hour format. Must be greater than or equal to 0 and typically must be less than or
        /// equal to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of an hour. Must be greater than or equal to 0 and less than or equal to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>
        /// Fractions of seconds, in nanoseconds. Must be greater than or equal to 0 and less than or equal to
        /// 999,999,999.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of a minute. Must be greater than or equal to 0 and typically must be less than or equal to 59. An
        /// API may allow the value 60 if it allows leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone. For example "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number. For example "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the user's total calories.</summary>
    public class TotalCaloriesRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sum of the total calories in kilocalories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kcalSum")]
        public virtual System.Nullable<double> KcalSum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VO2 max measurement.</summary>
    public class VO2Max : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The method used to measure the VO2 max value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("measurementMethod")]
        public virtual string MeasurementMethod { get; set; }

        /// <summary>Required. The time at which VO2 max was measured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>Required. VO2 max value measured as in ml consumed oxygen / kg of body weight / min.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vo2Max")]
        public virtual System.Nullable<double> Vo2Max { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the volume quantity.</summary>
    public class VolumeQuantity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Value representing the volume in milliliters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("milliliters")]
        public virtual System.Nullable<double> Milliliters { get; set; }

        /// <summary>Optional. Value representing the user provided unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userProvidedUnit")]
        public virtual string UserProvidedUnit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Rollup for volume quantity.</summary>
    public class VolumeQuantityRollup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The sum of volume in milliliters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("millilitersSum")]
        public virtual System.Nullable<double> MillilitersSum { get; set; }

        /// <summary>Optional. The user provided unit on the last element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userProvidedUnitLast")]
        public virtual string UserProvidedUnitLast { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Body weight measurement.</summary>
    public class Weight : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Standard free-form notes captured at manual logging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; }

        /// <summary>Required. The time at which the weight was measured</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleTime")]
        public virtual ObservationSampleTime SampleTime { get; set; }

        /// <summary>Required. Weight of a user in grams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightGrams")]
        public virtual System.Nullable<double> WeightGrams { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the result of the rollup of the weight data type.</summary>
    public class WeightRollupValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Average weight in grams.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weightGramsAvg")]
        public virtual System.Nullable<double> WeightGramsAvg { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
