// Copyright 2023 Google LLC
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

namespace Google.Apis.Forms.v1
{
    /// <summary>The Forms Service.</summary>
    public class FormsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FormsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FormsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Forms = new FormsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "forms";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://forms.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://forms.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Forms API.</summary>
        public class Scope
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Forms forms</summary>
            public static string FormsBody = "https://www.googleapis.com/auth/forms.body";

            /// <summary>See all your Google Forms forms</summary>
            public static string FormsBodyReadonly = "https://www.googleapis.com/auth/forms.body.readonly";

            /// <summary>See all responses to your Google Forms forms</summary>
            public static string FormsResponsesReadonly = "https://www.googleapis.com/auth/forms.responses.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Forms API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public const string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Forms forms</summary>
            public const string FormsBody = "https://www.googleapis.com/auth/forms.body";

            /// <summary>See all your Google Forms forms</summary>
            public const string FormsBodyReadonly = "https://www.googleapis.com/auth/forms.body.readonly";

            /// <summary>See all responses to your Google Forms forms</summary>
            public const string FormsResponsesReadonly = "https://www.googleapis.com/auth/forms.responses.readonly";
        }

        /// <summary>Gets the Forms resource.</summary>
        public virtual FormsResource Forms { get; }
    }

    /// <summary>A base abstract class for Forms requests.</summary>
    public abstract class FormsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FormsBaseServiceRequest instance.</summary>
        protected FormsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Forms parameter list.</summary>
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

    /// <summary>The "forms" collection of methods.</summary>
    public class FormsResource
    {
        private const string Resource = "forms";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FormsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Responses = new ResponsesResource(service);
            Watches = new WatchesResource(service);
        }

        /// <summary>Gets the Responses resource.</summary>
        public virtual ResponsesResource Responses { get; }

        /// <summary>The "responses" collection of methods.</summary>
        public class ResponsesResource
        {
            private const string Resource = "responses";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ResponsesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get one response from the form.</summary>
            /// <param name="formId">Required. The form ID.</param>
            /// <param name="responseId">Required. The response ID within the form.</param>
            public virtual GetRequest Get(string formId, string responseId)
            {
                return new GetRequest(service, formId, responseId);
            }

            /// <summary>Get one response from the form.</summary>
            public class GetRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.FormResponse>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string formId, string responseId) : base(service)
                {
                    FormId = formId;
                    ResponseId = responseId;
                    InitParameters();
                }

                /// <summary>Required. The form ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FormId { get; private set; }

                /// <summary>Required. The response ID within the form.</summary>
                [Google.Apis.Util.RequestParameterAttribute("responseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ResponseId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/forms/{formId}/responses/{responseId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "formId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("responseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "responseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>List a form's responses.</summary>
            /// <param name="formId">Required. ID of the Form whose responses to list.</param>
            public virtual ListRequest List(string formId)
            {
                return new ListRequest(service, formId);
            }

            /// <summary>List a form's responses.</summary>
            public class ListRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.ListFormResponsesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string formId) : base(service)
                {
                    FormId = formId;
                    InitParameters();
                }

                /// <summary>Required. ID of the Form whose responses to list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FormId { get; private set; }

                /// <summary>
                /// Which form responses to return. Currently, the only supported filters are: * timestamp &amp;gt; *N*
                /// which means to get all form responses submitted after (but not at) timestamp *N*. * timestamp
                /// &amp;gt;= *N* which means to get all form responses submitted at and after timestamp *N*. For both
                /// supported filters, timestamp must be formatted in RFC3339 UTC "Zulu" format. Examples:
                /// "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of responses to return. The service may return fewer than this value. If
                /// unspecified or zero, at most 5000 responses are returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token returned by a previous list response. If this field is set, the form and the values of
                /// the filter must be the same as for the original request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/forms/{formId}/responses";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "formId",
                        IsRequired = true,
                        ParameterType = "path",
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
        }

        /// <summary>Gets the Watches resource.</summary>
        public virtual WatchesResource Watches { get; }

        /// <summary>The "watches" collection of methods.</summary>
        public class WatchesResource
        {
            private const string Resource = "watches";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WatchesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Create a new watch. If a watch ID is provided, it must be unused. For each invoking project, the per
            /// form limit is one watch per Watch.EventType. A watch expires seven days after it is created (see
            /// Watch.expire_time).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="formId">Required. ID of the Form to watch.</param>
            public virtual CreateRequest Create(Google.Apis.Forms.v1.Data.CreateWatchRequest body, string formId)
            {
                return new CreateRequest(service, body, formId);
            }

            /// <summary>
            /// Create a new watch. If a watch ID is provided, it must be unused. For each invoking project, the per
            /// form limit is one watch per Watch.EventType. A watch expires seven days after it is created (see
            /// Watch.expire_time).
            /// </summary>
            public class CreateRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.Watch>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Forms.v1.Data.CreateWatchRequest body, string formId) : base(service)
                {
                    FormId = formId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. ID of the Form to watch.</summary>
                [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FormId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Forms.v1.Data.CreateWatchRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/forms/{formId}/watches";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "formId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete a watch.</summary>
            /// <param name="formId">Required. The ID of the Form.</param>
            /// <param name="watchId">Required. The ID of the Watch to delete.</param>
            public virtual DeleteRequest Delete(string formId, string watchId)
            {
                return new DeleteRequest(service, formId, watchId);
            }

            /// <summary>Delete a watch.</summary>
            public class DeleteRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string formId, string watchId) : base(service)
                {
                    FormId = formId;
                    WatchId = watchId;
                    InitParameters();
                }

                /// <summary>Required. The ID of the Form.</summary>
                [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FormId { get; private set; }

                /// <summary>Required. The ID of the Watch to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("watchId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WatchId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/forms/{formId}/watches/{watchId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "formId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watchId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watchId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Return a list of the watches owned by the invoking project. The maximum number of watches is two: For
            /// each invoker, the limit is one for each event type per form.
            /// </summary>
            /// <param name="formId">Required. ID of the Form whose watches to list.</param>
            public virtual ListRequest List(string formId)
            {
                return new ListRequest(service, formId);
            }

            /// <summary>
            /// Return a list of the watches owned by the invoking project. The maximum number of watches is two: For
            /// each invoker, the limit is one for each event type per form.
            /// </summary>
            public class ListRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.ListWatchesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string formId) : base(service)
                {
                    FormId = formId;
                    InitParameters();
                }

                /// <summary>Required. ID of the Form whose watches to list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FormId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/forms/{formId}/watches";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "formId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Renew an existing watch for seven days. The state of the watch after renewal is `ACTIVE`, and the
            /// `expire_time` is seven days from the renewal. Renewing a watch in an error state (e.g. `SUSPENDED`)
            /// succeeds if the error is no longer present, but fail otherwise. After a watch has expired, RenewWatch
            /// returns `NOT_FOUND`.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="formId">Required. The ID of the Form.</param>
            /// <param name="watchId">Required. The ID of the Watch to renew.</param>
            public virtual RenewRequest Renew(Google.Apis.Forms.v1.Data.RenewWatchRequest body, string formId, string watchId)
            {
                return new RenewRequest(service, body, formId, watchId);
            }

            /// <summary>
            /// Renew an existing watch for seven days. The state of the watch after renewal is `ACTIVE`, and the
            /// `expire_time` is seven days from the renewal. Renewing a watch in an error state (e.g. `SUSPENDED`)
            /// succeeds if the error is no longer present, but fail otherwise. After a watch has expired, RenewWatch
            /// returns `NOT_FOUND`.
            /// </summary>
            public class RenewRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.Watch>
            {
                /// <summary>Constructs a new Renew request.</summary>
                public RenewRequest(Google.Apis.Services.IClientService service, Google.Apis.Forms.v1.Data.RenewWatchRequest body, string formId, string watchId) : base(service)
                {
                    FormId = formId;
                    WatchId = watchId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The ID of the Form.</summary>
                [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FormId { get; private set; }

                /// <summary>Required. The ID of the Watch to renew.</summary>
                [Google.Apis.Util.RequestParameterAttribute("watchId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WatchId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Forms.v1.Data.RenewWatchRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "renew";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/forms/{formId}/watches/{watchId}:renew";

                /// <summary>Initializes Renew parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "formId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watchId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watchId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Change the form with a batch of updates.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="formId">Required. The form ID.</param>
        public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Forms.v1.Data.BatchUpdateFormRequest body, string formId)
        {
            return new BatchUpdateRequest(service, body, formId);
        }

        /// <summary>Change the form with a batch of updates.</summary>
        public class BatchUpdateRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.BatchUpdateFormResponse>
        {
            /// <summary>Constructs a new BatchUpdate request.</summary>
            public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Forms.v1.Data.BatchUpdateFormRequest body, string formId) : base(service)
            {
                FormId = formId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The form ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FormId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Forms.v1.Data.BatchUpdateFormRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUpdate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/forms/{formId}:batchUpdate";

            /// <summary>Initializes BatchUpdate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                {
                    Name = "formId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Create a new form using the title given in the provided form message in the request. *Important:* Only the
        /// form.info.title and form.info.document_title fields are copied to the new form. All other fields including
        /// the form description, items and settings are disallowed. To create a new form and add items, you must first
        /// call forms.create to create an empty form with a title and (optional) document title, and then call
        /// forms.update to add the items.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Forms.v1.Data.Form body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Create a new form using the title given in the provided form message in the request. *Important:* Only the
        /// form.info.title and form.info.document_title fields are copied to the new form. All other fields including
        /// the form description, items and settings are disallowed. To create a new form and add items, you must first
        /// call forms.create to create an empty form with a title and (optional) document title, and then call
        /// forms.update to add the items.
        /// </summary>
        public class CreateRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.Form>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Forms.v1.Data.Form body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Forms.v1.Data.Form Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/forms";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>Get a form.</summary>
        /// <param name="formId">Required. The form ID.</param>
        public virtual GetRequest Get(string formId)
        {
            return new GetRequest(service, formId);
        }

        /// <summary>Get a form.</summary>
        public class GetRequest : FormsBaseServiceRequest<Google.Apis.Forms.v1.Data.Form>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string formId) : base(service)
            {
                FormId = formId;
                InitParameters();
            }

            /// <summary>Required. The form ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("formId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string FormId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/forms/{formId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("formId", new Google.Apis.Discovery.Parameter
                {
                    Name = "formId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Forms.v1.Data
{
    /// <summary>The submitted answer for a question.</summary>
    public class Answer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The answers to a file upload question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUploadAnswers")]
        public virtual FileUploadAnswers FileUploadAnswers { get; set; }

        /// <summary>Output only. The grade for the answer if the form was a quiz.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grade")]
        public virtual Grade Grade { get; set; }

        /// <summary>Output only. The question's ID. See also Question.question_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionId")]
        public virtual string QuestionId { get; set; }

        /// <summary>Output only. The specific answers as text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textAnswers")]
        public virtual TextAnswers TextAnswers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A batch of updates to perform on a form. All the specified updates are made or none of them are.
    /// </summary>
    public class BatchUpdateFormRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to return an updated version of the model in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeFormInResponse")]
        public virtual System.Nullable<bool> IncludeFormInResponse { get; set; }

        /// <summary>Required. The update requests of this batch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<Request> Requests { get; set; }

        /// <summary>Provides control over how write requests are executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual WriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a BatchUpdateFormRequest.</summary>
    public class BatchUpdateFormResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Based on the bool request field `include_form_in_response`, a form with all applied mutations/updates is
        /// returned or not. This may be later than the revision ID created by these changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual Form Form { get; set; }

        /// <summary>
        /// The reply of the updates. This maps 1:1 with the update requests, although replies to some requests may be
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replies")]
        public virtual System.Collections.Generic.IList<Response> Replies { get; set; }

        /// <summary>The updated write control after applying the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeControl")]
        public virtual WriteControl WriteControl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A radio/checkbox/dropdown question.</summary>
    public class ChoiceQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of options that a respondent must choose from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual System.Collections.Generic.IList<Option> Options { get; set; }

        /// <summary>
        /// Whether the options should be displayed in random order for different instances of the quiz. This is often
        /// used to prevent cheating by respondents who might be looking at another respondent's screen, or to address
        /// bias in a survey that might be introduced by always putting the same options first or last.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuffle")]
        public virtual System.Nullable<bool> Shuffle { get; set; }

        /// <summary>Required. The type of choice question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Pub/Sub topic.</summary>
    public class CloudPubsubTopic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A fully qualified Pub/Sub topic name to publish the events to. This topic must be owned by the
        /// calling project and already exist in Pub/Sub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single correct answer for a question. For multiple-valued (`CHECKBOX`) questions, several `CorrectAnswer`s may
    /// be needed to represent a single correct response option.
    /// </summary>
    public class CorrectAnswer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The correct answer value. See the documentation for TextAnswer.value for details on how various
        /// value types are formatted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The answer key for a question.</summary>
    public class CorrectAnswers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of correct answers. A quiz response can be automatically graded based on these answers. For
        /// single-valued questions, a response is marked correct if it matches any value in this list (in other words,
        /// multiple correct answers are possible). For multiple-valued (`CHECKBOX`) questions, a response is marked
        /// correct if it contains exactly the values in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answers")]
        public virtual System.Collections.Generic.IList<CorrectAnswer> Answers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Create an item in a form.</summary>
    public class CreateItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The item to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual Item Item { get; set; }

        /// <summary>Required. Where to place the new item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of creating an item.</summary>
    public class CreateItemResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the created item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        /// <summary>
        /// The ID of the question created as part of this item, for a question group it lists IDs of all the questions
        /// created for this item.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionId")]
        public virtual System.Collections.Generic.IList<string> QuestionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Create a new watch.</summary>
    public class CreateWatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The watch object. No ID should be set on this object; use `watch_id` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("watch")]
        public virtual Watch Watch { get; set; }

        /// <summary>
        /// The ID to use for the watch. If specified, the ID must not already be in use. If not specified, an ID is
        /// generated. This value should be 4-63 characters, and valid characters are /a-z-/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("watchId")]
        public virtual string WatchId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A date question. Date questions default to just month + day.</summary>
    public class DateQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to include the time as part of the question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeTime")]
        public virtual System.Nullable<bool> IncludeTime { get; set; }

        /// <summary>Whether to include the year as part of the question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeYear")]
        public virtual System.Nullable<bool> IncludeYear { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Delete an item in a form.</summary>
    public class DeleteItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The location of the item to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

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

    /// <summary>Supplementary material to the feedback.</summary>
    public class ExtraMaterial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Text feedback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual TextLink Link { get; set; }

        /// <summary>Video feedback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("video")]
        public virtual VideoLink Video { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Feedback for a respondent about their response to a question.</summary>
    public class Feedback : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Additional information provided as part of the feedback, often used to point the respondent to more reading
        /// and resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("material")]
        public virtual System.Collections.Generic.IList<ExtraMaterial> Material { get; set; }

        /// <summary>Required. The main text of the feedback.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Info for a single file submitted to a file upload question.</summary>
    public class FileUploadAnswer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The ID of the Google Drive file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileId")]
        public virtual string FileId { get; set; }

        /// <summary>Output only. The file name, as stored in Google Drive on upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileName")]
        public virtual string FileName { get; set; }

        /// <summary>Output only. The MIME type of the file, as stored in Google Drive on upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All submitted files for a FileUpload question.</summary>
    public class FileUploadAnswers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. All submitted files for a FileUpload question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answers")]
        public virtual System.Collections.Generic.IList<FileUploadAnswer> Answers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A file upload question. The API currently does not support creating file upload questions.</summary>
    public class FileUploadQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the Drive folder where uploaded files are stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderId")]
        public virtual string FolderId { get; set; }

        /// <summary>Maximum number of bytes allowed for any single file uploaded to this question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFileSize")]
        public virtual System.Nullable<long> MaxFileSize { get; set; }

        /// <summary>Maximum number of files that can be uploaded for this question in a single response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFiles")]
        public virtual System.Nullable<int> MaxFiles { get; set; }

        /// <summary>File types accepted by this question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<string> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Google Forms document. A form is created in Drive, and deleting a form or changing its access protections is
    /// done via the [Drive API](https://developers.google.com/drive/api/v3/about-sdk).
    /// </summary>
    public class Form : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The form ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formId")]
        public virtual string FormId { get; set; }

        /// <summary>Required. The title and description of the form.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual Info Info { get; set; }

        /// <summary>
        /// Required. A list of the form's items, which can include section headers, questions, embedded media, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Item> Items { get; set; }

        /// <summary>
        /// Output only. The ID of the linked Google Sheet which is accumulating responses from this Form (if such a
        /// Sheet exists).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedSheetId")]
        public virtual string LinkedSheetId { get; set; }

        /// <summary>
        /// Output only. The form URI to share with responders. This opens a page that allows the user to submit
        /// responses but not edit the questions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responderUri")]
        public virtual string ResponderUri { get; set; }

        /// <summary>
        /// Output only. The revision ID of the form. Used in the WriteControl in update requests to identify the
        /// revision on which the changes are based. The format of the revision ID may change over time, so it should be
        /// treated opaquely. A returned revision ID is only guaranteed to be valid for 24 hours after it has been
        /// returned and cannot be shared across users. If the revision ID is unchanged between calls, then the form has
        /// not changed. Conversely, a changed ID (for the same form and user) usually means the form has been updated;
        /// however, a changed ID can also be due to internal factors such as ID format changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>
        /// The form's settings. This must be updated with UpdateSettingsRequest; it is ignored during `forms.create`
        /// and UpdateFormInfoRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual FormSettings Settings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A form response.</summary>
    public class FormResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The actual answers to the questions, keyed by question_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answers")]
        public virtual System.Collections.Generic.IDictionary<string, Answer> Answers { get; set; }

        /// <summary>Output only. Timestamp for the first time the response was submitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The form ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formId")]
        public virtual string FormId { get; set; }

        /// <summary>
        /// Output only. Timestamp for the most recent time the response was submitted. Does not track changes to
        /// grades.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSubmittedTime")]
        public virtual object LastSubmittedTime { get; set; }

        /// <summary>Output only. The email address (if collected) for the respondent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("respondentEmail")]
        public virtual string RespondentEmail { get; set; }

        /// <summary>Output only. The response ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; }

        /// <summary>
        /// Output only. The total number of points the respondent received for their submission Only set if the form
        /// was a quiz and the response was graded. This includes points automatically awarded via autograding adjusted
        /// by any manual corrections entered by the form owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalScore")]
        public virtual System.Nullable<double> TotalScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A form's settings.</summary>
    public class FormSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Settings related to quiz forms and grading.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quizSettings")]
        public virtual QuizSettings QuizSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Grade information associated with a respondent's answer to a question.</summary>
    public class Grade : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Whether the question was answered correctly or not. A zero-point score is not enough to infer
        /// incorrectness, since a correctly answered question could be worth zero points.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correct")]
        public virtual System.Nullable<bool> Correct { get; set; }

        /// <summary>Output only. Additional feedback given for an answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedback")]
        public virtual Feedback Feedback { get; set; }

        /// <summary>Output only. The numeric score awarded for the answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<double> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Grading for a single question</summary>
    public class Grading : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The answer key for the question. Responses are automatically graded based on this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("correctAnswers")]
        public virtual CorrectAnswers CorrectAnswers { get; set; }

        /// <summary>
        /// The feedback displayed for all answers. This is commonly used for short answer questions when a quiz owner
        /// wants to quickly give respondents some sense of whether they answered the question correctly before they've
        /// had a chance to officially grade the response. General feedback cannot be set for automatically graded
        /// multiple choice questions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generalFeedback")]
        public virtual Feedback GeneralFeedback { get; set; }

        /// <summary>
        /// Required. The maximum number of points a respondent can automatically get for a correct answer. This must
        /// not be negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointValue")]
        public virtual System.Nullable<int> PointValue { get; set; }

        /// <summary>
        /// The feedback displayed for correct responses. This feedback can only be set for multiple choice questions
        /// that have correct answers provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whenRight")]
        public virtual Feedback WhenRight { get; set; }

        /// <summary>
        /// The feedback displayed for incorrect responses. This feedback can only be set for multiple choice questions
        /// that have correct answers provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whenWrong")]
        public virtual Feedback WhenWrong { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A grid of choices (radio or check boxes) with each row constituting a separate question. Each row has the same
    /// choices, which are shown as the columns.
    /// </summary>
    public class Grid : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The choices shared by each question in the grid. In other words, the values of the columns. Only
        /// `CHECK_BOX` and `RADIO` choices are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual ChoiceQuestion Columns { get; set; }

        /// <summary>
        /// If `true`, the questions are randomly ordered. In other words, the rows appear in a different order for
        /// every respondent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shuffleQuestions")]
        public virtual System.Nullable<bool> ShuffleQuestions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data representing an image.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A description of the image that is shown on hover and read by screenreaders.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>
        /// Output only. A URI from which you can download the image; this is valid only for a limited time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUri")]
        public virtual string ContentUri { get; set; }

        /// <summary>Properties of an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual MediaProperties Properties { get; set; }

        /// <summary>
        /// Input only. The source URI is the URI used to insert the image. The source URI can be empty when fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual string SourceUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An item containing an image.</summary>
    public class ImageItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The image displayed in the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The general information for a form.</summary>
    public class Info : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the form.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Output only. The title of the document which is visible in Drive. If `Info.title` is empty, `document_title`
        /// may appear in its place in the Google Forms UI and be visible to responders. `document_title` can be set on
        /// create, but cannot be modified by a batchUpdate request. Please use the [Google Drive
        /// API](https://developers.google.com/drive/api/v3/reference/files/update) if you need to programmatically
        /// update `document_title`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentTitle")]
        public virtual string DocumentTitle { get; set; }

        /// <summary>Required. The title of the form which is visible to responders.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single item of the form. `kind` defines which kind of item it is.</summary>
    public class Item : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Displays an image on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageItem")]
        public virtual ImageItem ImageItem { get; set; }

        /// <summary>
        /// The item ID. On creation, it can be provided but the ID must not be already used in the form. If not
        /// provided, a new ID is assigned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemId")]
        public virtual string ItemId { get; set; }

        /// <summary>Starts a new page with a title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageBreakItem")]
        public virtual PageBreakItem PageBreakItem { get; set; }

        /// <summary>Poses one or more questions to the user with a single major prompt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionGroupItem")]
        public virtual QuestionGroupItem QuestionGroupItem { get; set; }

        /// <summary>Poses a question to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionItem")]
        public virtual QuestionItem QuestionItem { get; set; }

        /// <summary>Displays a title and description on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textItem")]
        public virtual TextItem TextItem { get; set; }

        /// <summary>The title of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Displays a video on the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoItem")]
        public virtual VideoItem VideoItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to a ListFormResponsesRequest.</summary>
    public class ListFormResponsesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, there are more responses. To get the next page of responses, provide this as `page_token` in a
        /// future request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The returned form responses. Note: The `formId` field is not returned in the `FormResponse` object for list
        /// requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<FormResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response of a ListWatchesRequest.</summary>
    public class ListWatchesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The returned watches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("watches")]
        public virtual System.Collections.Generic.IList<Watch> Watches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A specific location in a form.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The index of an item in the form. This must be in the range [0..*N*), where *N* is the number of items in
        /// the form.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of the media.</summary>
    public class MediaProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Position of the media.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alignment")]
        public virtual string Alignment { get; set; }

        /// <summary>
        /// The width of the media in pixels. When the media is displayed, it is scaled to the smaller of this value or
        /// the width of the displayed form. The original aspect ratio of the media is preserved. If a width is not
        /// specified when the media is added to the form, it is set to the width of the media source. Width must be
        /// between 0 and 740, inclusive. Setting width to 0 or unspecified is only permitted when updating the media
        /// source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Move an item in a form.</summary>
    public class MoveItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new location for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newLocation")]
        public virtual Location NewLocation { get; set; }

        /// <summary>Required. The location of the item to move.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalLocation")]
        public virtual Location OriginalLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An option for a Choice question.</summary>
    public class Option : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Section navigation type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goToAction")]
        public virtual string GoToAction { get; set; }

        /// <summary>Item ID of section header to go to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goToSectionId")]
        public virtual string GoToSectionId { get; set; }

        /// <summary>Display image as an option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>
        /// Whether the option is "other". Currently only applies to `RADIO` and `CHECKBOX` choice types, but is not
        /// allowed in a QuestionGroupItem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isOther")]
        public virtual System.Nullable<bool> IsOther { get; set; }

        /// <summary>Required. The choice as presented to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A page break. The title and description of this item are shown at the top of the new page.</summary>
    public class PageBreakItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Any question. The specific type of question is known by its `kind`.</summary>
    public class Question : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A respondent can choose from a pre-defined set of options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choiceQuestion")]
        public virtual ChoiceQuestion ChoiceQuestion { get; set; }

        /// <summary>A respondent can enter a date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateQuestion")]
        public virtual DateQuestion DateQuestion { get; set; }

        /// <summary>A respondent can upload one or more files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUploadQuestion")]
        public virtual FileUploadQuestion FileUploadQuestion { get; set; }

        /// <summary>Grading setup for the question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grading")]
        public virtual Grading Grading { get; set; }

        /// <summary>
        /// Read only. The question ID. On creation, it can be provided but the ID must not be already used in the form.
        /// If not provided, a new ID is assigned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionId")]
        public virtual string QuestionId { get; set; }

        /// <summary>Whether the question must be answered in order for a respondent to submit their response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; }

        /// <summary>A row of a QuestionGroupItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowQuestion")]
        public virtual RowQuestion RowQuestion { get; set; }

        /// <summary>A respondent can choose a number from a range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleQuestion")]
        public virtual ScaleQuestion ScaleQuestion { get; set; }

        /// <summary>A respondent can enter a free text response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textQuestion")]
        public virtual TextQuestion TextQuestion { get; set; }

        /// <summary>A respondent can enter a time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeQuestion")]
        public virtual TimeQuestion TimeQuestion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines a question that comprises multiple questions grouped together.</summary>
    public class QuestionGroupItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The question group is a grid with rows of multiple choice questions that share the same options. When `grid`
        /// is set, all questions in the group must be of kind `row`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grid")]
        public virtual Grid Grid { get; set; }

        /// <summary>The image displayed within the question group above the specific questions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>
        /// Required. A list of questions that belong in this question group. A question must only belong to one group.
        /// The `kind` of the group may affect what types of questions are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questions")]
        public virtual System.Collections.Generic.IList<Question> Questions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A form item containing a single question.</summary>
    public class QuestionItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The image displayed within the question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>Required. The displayed question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("question")]
        public virtual Question Question { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings related to quiz forms and grading. These must be updated with the UpdateSettingsRequest.
    /// </summary>
    public class QuizSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether this form is a quiz or not. When true, responses are graded based on question Grading. Upon setting
        /// to false, all question Grading is deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isQuiz")]
        public virtual System.Nullable<bool> IsQuiz { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Renew an existing Watch for seven days.</summary>
    public class RenewWatchRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The kinds of update requests that can be made.</summary>
    public class Request : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Create a new item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createItem")]
        public virtual CreateItemRequest CreateItem { get; set; }

        /// <summary>Delete an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteItem")]
        public virtual DeleteItemRequest DeleteItem { get; set; }

        /// <summary>Move an item to a specified location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moveItem")]
        public virtual MoveItemRequest MoveItem { get; set; }

        /// <summary>Update Form's Info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateFormInfo")]
        public virtual UpdateFormInfoRequest UpdateFormInfo { get; set; }

        /// <summary>Update an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateItem")]
        public virtual UpdateItemRequest UpdateItem { get; set; }

        /// <summary>Updates the Form's settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSettings")]
        public virtual UpdateSettingsRequest UpdateSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single response from an update.</summary>
    public class Response : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of creating an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createItem")]
        public virtual CreateItemResponse CreateItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a question that is part of a question group.</summary>
    public class RowQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The title for the single row in the QuestionGroupItem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A scale question. The user has a range of numeric values to choose from.</summary>
    public class ScaleQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The highest possible value for the scale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("high")]
        public virtual System.Nullable<int> High { get; set; }

        /// <summary>The label to display describing the highest point on the scale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highLabel")]
        public virtual string HighLabel { get; set; }

        /// <summary>Required. The lowest possible value for the scale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("low")]
        public virtual System.Nullable<int> Low { get; set; }

        /// <summary>The label to display describing the lowest point on the scale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowLabel")]
        public virtual string LowLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An answer to a question represented as text.</summary>
    public class TextAnswer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The answer value. Formatting used for different kinds of question: * ChoiceQuestion * `RADIO`
        /// or `DROP_DOWN`: A single string corresponding to the option that was selected. * `CHECKBOX`: Multiple
        /// strings corresponding to each option that was selected. * TextQuestion: The text that the user entered. *
        /// ScaleQuestion: A string containing the number that was selected. * DateQuestion * Without time or year:
        /// MM-DD e.g. "05-19" * With year: YYYY-MM-DD e.g. "1986-05-19" * With time: MM-DD HH:MM e.g. "05-19 14:51" *
        /// With year and time: YYYY-MM-DD HH:MM e.g. "1986-05-19 14:51" * TimeQuestion: String with time or duration in
        /// HH:MM format e.g. "14:51" * RowQuestion within QuestionGroupItem: The answer for each row of a
        /// QuestionGroupItem is represented as a separate Answer. Each will contain one string for `RADIO`-type choices
        /// or multiple strings for `CHECKBOX` choices.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A question's answers as text.</summary>
    public class TextAnswers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Answers to a question. For multiple-value ChoiceQuestions, each answer is a separate value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answers")]
        public virtual System.Collections.Generic.IList<TextAnswer> Answers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A text item.</summary>
    public class TextItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Link for text.</summary>
    public class TextLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Display text for the URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayText")]
        public virtual string DisplayText { get; set; }

        /// <summary>Required. The URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A text-based question.</summary>
    public class TextQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the question is a paragraph question or not. If not, the question is a short text question.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paragraph")]
        public virtual System.Nullable<bool> Paragraph { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A time question.</summary>
    public class TimeQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>`true` if the question is about an elapsed time. Otherwise it is about a time of day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual System.Nullable<bool> Duration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update Form's Info.</summary>
    public class UpdateFormInfoRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The info to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual Info Info { get; set; }

        /// <summary>
        /// Required. Only values named in this mask are changed. At least one field must be specified. The root `info`
        /// is implied and should not be specified. A single `"*"` can be used as short-hand for updating every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update an item in a form.</summary>
    public class UpdateItemRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. New values for the item. Note that item and question IDs are used if they are provided (and are in
        /// the field mask). If an ID is blank (and in the field mask) a new ID is generated. This means you can modify
        /// an item by getting the form via forms.get, modifying your local copy of that item to be how you want it, and
        /// using UpdateItemRequest to write it back, with the IDs being the same (or not in the field mask).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual Item Item { get; set; }

        /// <summary>Required. The location identifying the item to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual Location Location { get; set; }

        /// <summary>Required. Only values named in this mask are changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update Form's FormSettings.</summary>
    public class UpdateSettingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The settings to update with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("settings")]
        public virtual FormSettings Settings { get; set; }

        /// <summary>
        /// Required. Only values named in this mask are changed. At least one field must be specified. The root
        /// `settings` is implied and should not be specified. A single `"*"` can be used as short-hand for updating
        /// every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data representing a video.</summary>
    public class Video : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Properties of a video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual MediaProperties Properties { get; set; }

        /// <summary>Required. A YouTube URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeUri")]
        public virtual string YoutubeUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An item containing a video.</summary>
    public class VideoItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The text displayed below the video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>Required. The video displayed in the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("video")]
        public virtual Video Video { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Link to a video.</summary>
    public class VideoLink : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The display text for the link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayText")]
        public virtual string DisplayText { get; set; }

        /// <summary>The URI of a YouTube video.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeUri")]
        public virtual string YoutubeUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A watch for events for a form. When the designated event happens, a notification will be published to the
    /// specified target. The notification's attributes will include a `formId` key that has the ID of the watched form
    /// and an `eventType` key that has the string of the type. Messages are sent with at-least-once delivery and are
    /// only dropped in extraordinary circumstances. Typically all notifications should be reliably delivered within a
    /// few seconds; however, in some situations notifications may be delayed. A watch expires seven days after it is
    /// created unless it is renewed with watches.renew
    /// </summary>
    public class Watch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Timestamp of when this was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The most recent error type for an attempted delivery. To begin watching the form again a call
        /// can be made to watches.renew which also clears this error information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorType")]
        public virtual string ErrorType { get; set; }

        /// <summary>Required. Which event type to watch for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// Output only. Timestamp for when this will expire. Each watches.renew call resets this to seven days in the
        /// future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>Output only. The ID of this watch. See notes on CreateWatchRequest.watch_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. The current state of the watch. Additional details about suspended watches can be found by
        /// checking the `error_type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Required. Where to send the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual WatchTarget Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The target for notification delivery.</summary>
    public class WatchTarget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A Pub/Sub topic. To receive notifications, the topic must grant publish privileges to the Forms service
        /// account `serviceAccount:forms-notifications@system.gserviceaccount.com`. Only the project that owns a topic
        /// may create a watch with it. Pub/Sub delivery guarantees should be considered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual CloudPubsubTopic Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides control over how write requests are executed.</summary>
    public class WriteControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The revision ID of the form that the write request is applied to. If this is not the latest revision of the
        /// form, the request is not processed and returns a 400 bad request error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredRevisionId")]
        public virtual string RequiredRevisionId { get; set; }

        /// <summary>
        /// The target revision ID of the form that the write request is applied to. If changes have occurred after this
        /// revision, the changes in this update request are transformed against those changes. This results in a new
        /// revision of the form that incorporates both the changes in the request and the intervening changes, with the
        /// server resolving conflicting changes. The target revision ID may only be used to write to recent versions of
        /// a form. If the target revision is too far behind the latest revision, the request is not processed and
        /// returns a 400 (Bad Request Error). The request may be retried after reading the latest version of the form.
        /// In most cases a target revision ID remains valid for several minutes after it is read, but for
        /// frequently-edited forms this window may be shorter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetRevisionId")]
        public virtual string TargetRevisionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
