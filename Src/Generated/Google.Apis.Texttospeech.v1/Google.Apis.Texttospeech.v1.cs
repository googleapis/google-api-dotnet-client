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

namespace Google.Apis.Texttospeech.v1
{
    /// <summary>The Texttospeech Service.</summary>
    public class TexttospeechService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TexttospeechService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TexttospeechService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
            Text = new TextResource(this);
            Voices = new VoicesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://texttospeech.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://texttospeech.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "texttospeech";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Text-to-Speech API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Text-to-Speech API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }

        /// <summary>Gets the Text resource.</summary>
        public virtual TextResource Text { get; }

        /// <summary>Gets the Voices resource.</summary>
        public virtual VoicesResource Voices { get; }
    }

    /// <summary>A base abstract class for Texttospeech requests.</summary>
    public abstract class TexttospeechBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TexttospeechBaseServiceRequest instance.</summary>
        protected TexttospeechBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Texttospeech parameter list.</summary>
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
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.Texttospeech.v1.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(this.service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of `1`, corresponding to `Code.CANCELLED`.
        /// </summary>
        public class CancelRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Texttospeech.v1.Data.CancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Texttospeech.v1.Data.CancelOperationRequest Body { get; set; }

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
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        public class DeleteRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1.Data.Empty>
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
                    Pattern = @"^operations/.*$",
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
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1.Data.Operation>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(this.service, name);
                }

                /// <summary>
                /// Lists operations that match the specified filter in the request. If the server doesn't support this
                /// method, it returns `UNIMPLEMENTED`.
                /// </summary>
                public class ListRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1.Data.ListOperationsResponse>
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

            /// <summary>Synthesizes long form text asynchronously.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">The resource states of the request in the form of `projects/*/locations/*`.</param>
            public virtual SynthesizeLongAudioRequest SynthesizeLongAudio(Google.Apis.Texttospeech.v1.Data.SynthesizeLongAudioRequest body, string parent)
            {
                return new SynthesizeLongAudioRequest(this.service, body, parent);
            }

            /// <summary>Synthesizes long form text asynchronously.</summary>
            public class SynthesizeLongAudioRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1.Data.Operation>
            {
                /// <summary>Constructs a new SynthesizeLongAudio request.</summary>
                public SynthesizeLongAudioRequest(Google.Apis.Services.IClientService service, Google.Apis.Texttospeech.v1.Data.SynthesizeLongAudioRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The resource states of the request in the form of `projects/*/locations/*`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Texttospeech.v1.Data.SynthesizeLongAudioRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "synthesizeLongAudio";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:synthesizeLongAudio";

                /// <summary>Initializes SynthesizeLongAudio parameter list.</summary>
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
                }
            }
        }
    }

    /// <summary>The "text" collection of methods.</summary>
    public class TextResource
    {
        private const string Resource = "text";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TextResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input has been processed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SynthesizeRequest Synthesize(Google.Apis.Texttospeech.v1.Data.SynthesizeSpeechRequest body)
        {
            return new SynthesizeRequest(this.service, body);
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input has been processed.
        /// </summary>
        public class SynthesizeRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1.Data.SynthesizeSpeechResponse>
        {
            /// <summary>Constructs a new Synthesize request.</summary>
            public SynthesizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Texttospeech.v1.Data.SynthesizeSpeechRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Texttospeech.v1.Data.SynthesizeSpeechRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "synthesize";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/text:synthesize";

            /// <summary>Initializes Synthesize parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "voices" collection of methods.</summary>
    public class VoicesResource
    {
        private const string Resource = "voices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VoicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns a list of Voice supported for synthesis.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Returns a list of Voice supported for synthesis.</summary>
        public class ListRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1.Data.ListVoicesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Recommended. [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If not
            /// specified, the API will return all supported voices. If specified, the ListVoices call will only return
            /// voices that can be used to synthesize this language_code. For example, if you specify `"en-NZ"`, all
            /// `"en-NZ"` voices will be returned. If you specify `"no"`, both `"no-\*"` (Norwegian) and `"nb-\*"`
            /// (Norwegian Bokmal) voices will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/voices";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Texttospeech.v1.Data
{
    /// <summary>Used for advanced voice options.</summary>
    public class AdvancedVoiceOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Only for Journey voices. If false, the synthesis is context aware and has a higher latency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowLatencyJourneySynthesis")]
        public virtual System.Nullable<bool> LowLatencyJourneySynthesis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of audio data to be synthesized.</summary>
    public class AudioConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format of the audio byte stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioEncoding")]
        public virtual string AudioEncoding { get; set; }

        /// <summary>
        /// Optional. Input only. An identifier which selects 'audio effects' profiles that are applied on (post
        /// synthesized) text to speech. Effects are applied on top of each other in the order they are given. See
        /// [audio profiles](https://cloud.google.com/text-to-speech/docs/audio-profiles) for current supported profile
        /// ids.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectsProfileId")]
        public virtual System.Collections.Generic.IList<string> EffectsProfileId { get; set; }

        /// <summary>
        /// Optional. Input only. Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the
        /// original pitch. -20 means decrease 20 semitones from the original pitch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitch")]
        public virtual System.Nullable<double> Pitch { get; set; }

        /// <summary>
        /// Optional. The synthesis sample rate (in hertz) for this audio. When this is specified in
        /// SynthesizeSpeechRequest, if this is different from the voice's natural sample rate, then the synthesizer
        /// will honor this request by converting to the desired sample rate (which might result in worse audio
        /// quality), unless the specified sample rate is not supported for the encoding chosen, in which case it will
        /// fail the request and return google.rpc.Code.INVALID_ARGUMENT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; }

        /// <summary>
        /// Optional. Input only. Speaking rate/speed, in the range [0.25, 2.0]. 1.0 is the normal native speed
        /// supported by the specific voice. 2.0 is twice as fast, and 0.5 is half as fast. If unset(0.0), defaults to
        /// the native 1.0 speed. Any other values &amp;lt; 0.25 or &amp;gt; 2.0 will return an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakingRate")]
        public virtual System.Nullable<double> SpeakingRate { get; set; }

        /// <summary>
        /// Optional. Input only. Volume gain (in dB) of the normal native volume supported by the specific voice, in
        /// the range [-96.0, 16.0]. If unset, or set to a value of 0.0 (dB), will play at normal native signal
        /// amplitude. A value of -6.0 (dB) will play at approximately half the amplitude of the normal native signal
        /// amplitude. A value of +6.0 (dB) will play at approximately twice the amplitude of the normal native signal
        /// amplitude. Strongly recommend not to exceed +10 (dB) as there's usually no effective increase in loudness
        /// for any value greater than that.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeGainDb")]
        public virtual System.Nullable<double> VolumeGainDb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pronunciation customization for a phrase.</summary>
    public class CustomPronunciationParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The phonetic encoding of the phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneticEncoding")]
        public virtual string PhoneticEncoding { get; set; }

        /// <summary>
        /// The phrase to which the customization is applied. The phrase can be multiple words, such as proper nouns,
        /// but shouldn't span the length of the sentence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phrase")]
        public virtual string Phrase { get; set; }

        /// <summary>The pronunciation of the phrase. This must be in the phonetic encoding specified above.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pronunciation")]
        public virtual string Pronunciation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of pronunciation customizations.</summary>
    public class CustomPronunciations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The pronunciation customizations are applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pronunciations")]
        public virtual System.Collections.Generic.IList<CustomPronunciationParams> Pronunciations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of the custom voice to be synthesized.</summary>
    public class CustomVoiceParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the AutoML model that synthesizes the custom voice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>Optional. Deprecated. The usage of the synthesized audio to be reported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportedUsage")]
        public virtual string ReportedUsage { get; set; }

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

    /// <summary>Metadata for response returned by the `SynthesizeLongAudio` method.</summary>
    public class GoogleCloudTexttospeechV1SynthesizeLongAudioMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>Deprecated. Do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The progress of the most recent processing update in percentage, ie. 70.0%.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercentage")]
        public virtual System.Nullable<double> ProgressPercentage { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

    /// <summary>The message returned to the client by the `ListVoices` method.</summary>
    public class ListVoicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of voices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voices")]
        public virtual System.Collections.Generic.IList<Voice> Voices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of turns for multi-speaker synthesis.</summary>
    public class MultiSpeakerMarkup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Speaker turns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("turns")]
        public virtual System.Collections.Generic.IList<Turn> Turns { get; set; }

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
    /// Contains text input to be synthesized. Either `text` or `ssml` must be supplied. Supplying both or neither
    /// returns google.rpc.Code.INVALID_ARGUMENT. The input size is limited to 5000 bytes.
    /// </summary>
    public class SynthesisInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The pronunciation customizations are applied to the input. If this is set, the input is
        /// synthesized using the given pronunciation customizations. The initial support is for en-us, with plans to
        /// expand to other locales in the future. Instant Clone voices aren't supported. In order to customize the
        /// pronunciation of a phrase, there must be an exact match of the phrase in the input types. If using SSML, the
        /// phrase must not be inside a phoneme tag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPronunciations")]
        public virtual CustomPronunciations CustomPronunciations { get; set; }

        /// <summary>Markup for HD voices specifically. This field may not be used with any other voices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("markup")]
        public virtual string Markup { get; set; }

        /// <summary>The multi-speaker input to be synthesized. Only applicable for multi-speaker synthesis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiSpeakerMarkup")]
        public virtual MultiSpeakerMarkup MultiSpeakerMarkup { get; set; }

        /// <summary>
        /// The SSML document to be synthesized. The SSML document must be valid and well-formed. Otherwise the RPC will
        /// fail and return google.rpc.Code.INVALID_ARGUMENT. For more information, see
        /// [SSML](https://cloud.google.com/text-to-speech/docs/ssml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssml")]
        public virtual string Ssml { get; set; }

        /// <summary>The raw text to be synthesized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for response returned by the `SynthesizeLongAudio` method.</summary>
    public class SynthesizeLongAudioMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>Deprecated. Do not use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The progress of the most recent processing update in percentage, ie. 70.0%.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercentage")]
        public virtual System.Nullable<double> ProgressPercentage { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Time when the request was received.</summary>
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

    /// <summary>The top-level message sent by the client for the `SynthesizeLongAudio` method.</summary>
    public class SynthesizeLongAudioRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioConfig")]
        public virtual AudioConfig AudioConfig { get; set; }

        /// <summary>Required. The Synthesizer requires either plain text or SSML as input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual SynthesisInput Input { get; set; }

        /// <summary>
        /// Required. Specifies a Cloud Storage URI for the synthesis results. Must be specified in the format:
        /// `gs://bucket_name/object_name`, and the bucket must already exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGcsUri")]
        public virtual string OutputGcsUri { get; set; }

        /// <summary>Required. The desired voice of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voice")]
        public virtual VoiceSelectionParams Voice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The top-level message sent by the client for the `SynthesizeSpeech` method.</summary>
    public class SynthesizeSpeechRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Advanced voice options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advancedVoiceOptions")]
        public virtual AdvancedVoiceOptions AdvancedVoiceOptions { get; set; }

        /// <summary>Required. The configuration of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioConfig")]
        public virtual AudioConfig AudioConfig { get; set; }

        /// <summary>Required. The Synthesizer requires either plain text or SSML as input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual SynthesisInput Input { get; set; }

        /// <summary>Required. The desired voice of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voice")]
        public virtual VoiceSelectionParams Voice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message returned to the client by the `SynthesizeSpeech` method.</summary>
    public class SynthesizeSpeechResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The audio data bytes encoded as specified in the request, including the header for encodings that are
        /// wrapped in containers (e.g. MP3, OGG_OPUS). For LINEAR16 audio, we include the WAV header. Note: as with all
        /// bytes fields, protobuffers use a pure binary representation, whereas JSON representations use base64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioContent")]
        public virtual string AudioContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A multi-speaker turn.</summary>
    public class Turn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The speaker of the turn, for example, 'O' or 'Q'. Please refer to documentation for available
        /// speakers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speaker")]
        public virtual string Speaker { get; set; }

        /// <summary>Required. The text to speak.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of a voice supported by the TTS service.</summary>
    public class Voice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The languages that this voice supports, expressed as [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt)
        /// language tags (e.g. "en-US", "es-419", "cmn-tw").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodes")]
        public virtual System.Collections.Generic.IList<string> LanguageCodes { get; set; }

        /// <summary>The name of this voice. Each distinct voice has a unique name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The natural sample rate (in hertz) for this voice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("naturalSampleRateHertz")]
        public virtual System.Nullable<int> NaturalSampleRateHertz { get; set; }

        /// <summary>The gender of this voice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssmlGender")]
        public virtual string SsmlGender { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of Voice Clone feature.</summary>
    public class VoiceCloneParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Created by GenerateVoiceCloningKey.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voiceCloningKey")]
        public virtual string VoiceCloningKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of which voice to use for a synthesis request.</summary>
    public class VoiceSelectionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configuration for a custom voice. If [CustomVoiceParams.model] is set, the service will choose the
        /// custom voice matching the specified configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customVoice")]
        public virtual CustomVoiceParams CustomVoice { get; set; }

        /// <summary>
        /// Required. The language (and potentially also the region) of the voice expressed as a
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag, e.g. "en-US". This should not include a
        /// script tag (e.g. use "cmn-cn" rather than "cmn-Hant-cn"), because the script will be inferred from the input
        /// provided in the SynthesisInput. The TTS service will use this parameter to help choose an appropriate voice.
        /// Note that the TTS service may choose a voice with a slightly different language code than the one selected;
        /// it may substitute a different region (e.g. using en-US rather than en-CA if there isn't a Canadian voice
        /// available), or even a different language, e.g. using "nb" (Norwegian Bokmal) instead of "no" (Norwegian)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The name of the voice. If both the name and the gender are not set, the service will choose a voice based on
        /// the other parameters such as language_code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The preferred gender of the voice. If not set, the service will choose a voice based on the other parameters
        /// such as language_code and name. Note that this is only a preference, not requirement; if a voice of the
        /// appropriate gender is not available, the synthesizer should substitute a voice with a different gender
        /// rather than failing the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssmlGender")]
        public virtual string SsmlGender { get; set; }

        /// <summary>
        /// Optional. The configuration for a voice clone. If [VoiceCloneParams.voice_clone_key] is set, the service
        /// chooses the voice clone matching the specified configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voiceClone")]
        public virtual VoiceCloneParams VoiceClone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
