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

namespace Google.Apis.RecaptchaEnterprise.v1
{
    /// <summary>The RecaptchaEnterprise Service.</summary>
    public class RecaptchaEnterpriseService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public RecaptchaEnterpriseService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public RecaptchaEnterpriseService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "recaptchaenterprise";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://recaptchaenterprise.googleapis.com/";
        #else
            "https://recaptchaenterprise.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://recaptchaenterprise.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the reCAPTCHA Enterprise API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the reCAPTCHA Enterprise API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for RecaptchaEnterprise requests.</summary>
    public abstract class RecaptchaEnterpriseBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new RecaptchaEnterpriseBaseServiceRequest instance.</summary>
        protected RecaptchaEnterpriseBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes RecaptchaEnterprise parameter list.</summary>
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
            Assessments = new AssessmentsResource(service);
            Keys = new KeysResource(service);
        }

        /// <summary>Gets the Assessments resource.</summary>
        public virtual AssessmentsResource Assessments { get; }

        /// <summary>The "assessments" collection of methods.</summary>
        public class AssessmentsResource
        {
            private const string Resource = "assessments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssessmentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Annotates a previously created Assessment to provide additional information on whether the event turned
            /// out to be authentic or fraudulent.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The resource name of the Assessment, in the format
            /// "projects/{project}/assessments/{assessment}".
            /// </param>
            public virtual AnnotateRequest Annotate(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentRequest body, string name)
            {
                return new AnnotateRequest(service, body, name);
            }

            /// <summary>
            /// Annotates a previously created Assessment to provide additional information on whether the event turned
            /// out to be authentic or fraudulent.
            /// </summary>
            public class AnnotateRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentResponse>
            {
                /// <summary>Constructs a new Annotate request.</summary>
                public AnnotateRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the Assessment, in the format
                /// "projects/{project}/assessments/{assessment}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "annotate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:annotate";

                /// <summary>Initializes Annotate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/assessments/[^/]+$",
                    });
                }
            }

            /// <summary>Creates an Assessment of the likelihood an event is legitimate.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which the assessment will be created, in the format
            /// "projects/{project}".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Assessment body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates an Assessment of the likelihood an event is legitimate.</summary>
            public class CreateRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Assessment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Assessment body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which the assessment will be created, in the format
                /// "projects/{project}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Assessment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assessments";

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

        /// <summary>Gets the Keys resource.</summary>
        public virtual KeysResource Keys { get; }

        /// <summary>The "keys" collection of methods.</summary>
        public class KeysResource
        {
            private const string Resource = "keys";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public KeysResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new reCAPTCHA Enterprise key.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which the key will be created, in the format "projects/{project}".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new reCAPTCHA Enterprise key.</summary>
            public class CreateRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project in which the key will be created, in the format
                /// "projects/{project}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/keys";

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

            /// <summary>Deletes the specified key.</summary>
            /// <param name="name">
            /// Required. The name of the key to be deleted, in the format "projects/{project}/keys/{key}".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes the specified key.</summary>
            public class DeleteRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the key to be deleted, in the format "projects/{project}/keys/{key}".
                /// </summary>
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
                        Pattern = @"^projects/[^/]+/keys/[^/]+$",
                    });
                }
            }

            /// <summary>Returns the specified key.</summary>
            /// <param name="name">
            /// Required. The name of the requested key, in the format "projects/{project}/keys/{key}".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Returns the specified key.</summary>
            public class GetRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the requested key, in the format "projects/{project}/keys/{key}".
                /// </summary>
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
                        Pattern = @"^projects/[^/]+/keys/[^/]+$",
                    });
                }
            }

            /// <summary>Get some aggregated metrics for a Key. This data can be used to build dashboards.</summary>
            /// <param name="name">
            /// Required. The name of the requested metrics, in the format "projects/{project}/keys/{key}/metrics".
            /// </param>
            public virtual GetMetricsRequest GetMetrics(string name)
            {
                return new GetMetricsRequest(service, name);
            }

            /// <summary>Get some aggregated metrics for a Key. This data can be used to build dashboards.</summary>
            public class GetMetricsRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Metrics>
            {
                /// <summary>Constructs a new GetMetrics request.</summary>
                public GetMetricsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the requested metrics, in the format "projects/{project}/keys/{key}/metrics".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getMetrics";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes GetMetrics parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/keys/[^/]+/metrics$",
                    });
                }
            }

            /// <summary>Returns the list of all keys that belong to a project.</summary>
            /// <param name="parent">
            /// Required. The name of the project that contains the keys that will be listed, in the format
            /// "projects/{project}".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Returns the list of all keys that belong to a project.</summary>
            public class ListRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ListKeysResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project that contains the keys that will be listed, in the format
                /// "projects/{project}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. The maximum number of keys to return. Default is 10. Max limit is 1000.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The next_page_token value returned from a previous. ListKeysRequest, if any.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/keys";

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
            /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise. Once a key is migrated, it can be used
            /// from either product. SiteVerify requests are billed as CreateAssessment calls. You must be authenticated
            /// as one of the current owners of the reCAPTCHA Site Key, and your user must have the reCAPTCHA Enterprise
            /// Admin IAM role in the destination project.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the key to be migrated, in the format "projects/{project}/keys/{key}".
            /// </param>
            public virtual MigrateRequest Migrate(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1MigrateKeyRequest body, string name)
            {
                return new MigrateRequest(service, body, name);
            }

            /// <summary>
            /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise. Once a key is migrated, it can be used
            /// from either product. SiteVerify requests are billed as CreateAssessment calls. You must be authenticated
            /// as one of the current owners of the reCAPTCHA Site Key, and your user must have the reCAPTCHA Enterprise
            /// Admin IAM role in the destination project.
            /// </summary>
            public class MigrateRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key>
            {
                /// <summary>Constructs a new Migrate request.</summary>
                public MigrateRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1MigrateKeyRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the key to be migrated, in the format "projects/{project}/keys/{key}".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1MigrateKeyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "migrate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:migrate";

                /// <summary>Initializes Migrate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/keys/[^/]+$",
                    });
                }
            }

            /// <summary>Updates the specified key.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The resource name for the Key in the format "projects/{project}/keys/{key}".</param>
            public virtual PatchRequest Patch(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates the specified key.</summary>
            public class PatchRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The resource name for the Key in the format "projects/{project}/keys/{key}".</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The mask to control which fields of the key get updated. If the mask is not present, all
                /// fields will be updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/keys/[^/]+$",
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
namespace Google.Apis.RecaptchaEnterprise.v1.Data
{
    /// <summary>Settings specific to keys that can be used by Android apps.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AndroidKeySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Android package names of apps allowed to use the key. Example: 'com.companyname.appname'</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedPackageNames")]
        public virtual System.Collections.Generic.IList<string> AllowedPackageNames { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message to annotate an Assessment.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The annotation that will be assigned to the Event. This field can be left empty to provide reasons
        /// that apply to an event without concluding whether the event is legitimate or fraudulent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotation")]
        public virtual string Annotation { get; set; }

        /// <summary>Optional. Optional reasons for the annotation that will be assigned to the Event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
        public virtual System.Collections.Generic.IList<string> Reasons { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Empty response for AnnotateAssessment.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A recaptcha assessment resource.</summary>
    public class GoogleCloudRecaptchaenterpriseV1Assessment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The event being assessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual GoogleCloudRecaptchaenterpriseV1Event Event__ { get; set; }

        /// <summary>
        /// Output only. The resource name for the Assessment in the format
        /// "projects/{project}/assessments/{assessment}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The risk analysis result for the event being assessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskAnalysis")]
        public virtual GoogleCloudRecaptchaenterpriseV1RiskAnalysis RiskAnalysis { get; set; }

        /// <summary>Output only. Properties of the provided event token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenProperties")]
        public virtual GoogleCloudRecaptchaenterpriseV1TokenProperties TokenProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics related to challenges.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ChallengeMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Count of submitted challenge solutions that were incorrect or otherwise deemed suspicious such that a
        /// subsequent challenge was triggered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedCount")]
        public virtual System.Nullable<long> FailedCount { get; set; }

        /// <summary>Count of nocaptchas (successful verification without a challenge) issued.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nocaptchaCount")]
        public virtual System.Nullable<long> NocaptchaCount { get; set; }

        /// <summary>
        /// Count of reCAPTCHA checkboxes or badges rendered. This is mostly equivalent to a count of pageloads for
        /// pages that include reCAPTCHA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageloadCount")]
        public virtual System.Nullable<long> PageloadCount { get; set; }

        /// <summary>
        /// Count of nocaptchas (successful verification without a challenge) plus submitted challenge solutions that
        /// were correct and resulted in verification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passedCount")]
        public virtual System.Nullable<long> PassedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudRecaptchaenterpriseV1Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The expected action for this type of event. This should be the same action provided at token
        /// generation time on client-side platforms already integrated with recaptcha enterprise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedAction")]
        public virtual string ExpectedAction { get; set; }

        /// <summary>
        /// Optional. The site key that was used to invoke reCAPTCHA on your site and generate the token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteKey")]
        public virtual string SiteKey { get; set; }

        /// <summary>
        /// Optional. The user response token provided by the reCAPTCHA client-side integration on your site.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// Optional. The user agent present in the request from the user's device related to this event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>Optional. The IP address in the request from the user's device related to this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIpAddress")]
        public virtual string UserIpAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to keys that can be used by iOS apps.</summary>
    public class GoogleCloudRecaptchaenterpriseV1IOSKeySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// iOS bundle ids of apps allowed to use the key. Example: 'com.companyname.productname.appname'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedBundleIds")]
        public virtual System.Collections.Generic.IList<string> AllowedBundleIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A key used to identify and configure applications (web and/or mobile) that use reCAPTCHA Enterprise.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1Key : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Settings for keys that can be used by Android apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidSettings")]
        public virtual GoogleCloudRecaptchaenterpriseV1AndroidKeySettings AndroidSettings { get; set; }

        /// <summary>The timestamp corresponding to the creation of this Key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Human-readable display name of this key. Modifiable by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Settings for keys that can be used by iOS apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosSettings")]
        public virtual GoogleCloudRecaptchaenterpriseV1IOSKeySettings IosSettings { get; set; }

        /// <summary>See Creating and managing labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The resource name for the Key in the format "projects/{project}/keys/{key}".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Options for user acceptance testing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingOptions")]
        public virtual GoogleCloudRecaptchaenterpriseV1TestingOptions TestingOptions { get; set; }

        /// <summary>Settings for keys that can be used by websites.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webSettings")]
        public virtual GoogleCloudRecaptchaenterpriseV1WebKeySettings WebSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to request to list keys in a project.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ListKeysResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1Key> Keys { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. It is set to empty if no keys remain in results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a single Key.</summary>
    public class GoogleCloudRecaptchaenterpriseV1Metrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metrics will be continuous and in order by dates, and in the granularity of day. Only challenge-based keys
        /// (CHECKBOX, INVISIBLE), will have challenge-based data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challengeMetrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1ChallengeMetrics> ChallengeMetrics { get; set; }

        /// <summary>
        /// Metrics will be continuous and in order by dates, and in the granularity of day. All Key types should have
        /// score-based data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreMetrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1ScoreMetrics> ScoreMetrics { get; set; }

        /// <summary>Inclusive start time aligned to a day (UTC).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The migrate key request message.</summary>
    public class GoogleCloudRecaptchaenterpriseV1MigrateKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Risk analysis result for an event.</summary>
    public class GoogleCloudRecaptchaenterpriseV1RiskAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Reasons contributing to the risk analysis verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
        public virtual System.Collections.Generic.IList<string> Reasons { get; set; }

        /// <summary>
        /// Legitimate event score from 0.0 to 1.0. (1.0 means very likely legitimate traffic while 0.0 means very
        /// likely non-legitimate traffic).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Score distribution.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ScoreDistribution : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map key is score value multiplied by 100. The scores are discrete values between [0, 1]. The maximum number
        /// of buckets is on order of a few dozen, but typically much lower (ie. 10).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreBuckets")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<long>> ScoreBuckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics related to scoring.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ScoreMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Action-based metrics. The map key is the action name which specified by the site owners at time of the
        /// "execute" client-side call. Populated only for SCORE keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMetrics")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRecaptchaenterpriseV1ScoreDistribution> ActionMetrics { get; set; }

        /// <summary>Aggregated score metrics for all traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overallMetrics")]
        public virtual GoogleCloudRecaptchaenterpriseV1ScoreDistribution OverallMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for user acceptance testing.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TestingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return
        /// nocaptcha if NOCAPTCHA, or an unsolvable challenge if CHALLENGE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingChallenge")]
        public virtual string TestingChallenge { get; set; }

        /// <summary>
        /// All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely
        /// legitimate) inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingScore")]
        public virtual System.Nullable<float> TestingScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class GoogleCloudRecaptchaenterpriseV1TokenProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action name provided at token generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>The timestamp corresponding to the generation of the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The hostname of the page on which the token was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Reason associated with the response when valid = false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidReason")]
        public virtual string InvalidReason { get; set; }

        /// <summary>
        /// Whether the provided user response token is valid. When valid = false, the reason could be specified in
        /// invalid_reason or it could also be due to a user failing to solve a challenge or a sitekey mismatch (i.e the
        /// sitekey used to generate the token was different than the one specified in the assessment).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valid")]
        public virtual System.Nullable<bool> Valid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to keys that can be used by websites.</summary>
    public class GoogleCloudRecaptchaenterpriseV1WebKeySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If set to true, it means allowed_domains will not be enforced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAllDomains")]
        public virtual System.Nullable<bool> AllowAllDomains { get; set; }

        /// <summary>
        /// Required. Whether this key can be used on AMP (Accelerated Mobile Pages) websites. This can only be set for
        /// the SCORE integration type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAmpTraffic")]
        public virtual System.Nullable<bool> AllowAmpTraffic { get; set; }

        /// <summary>
        /// Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are
        /// automatically allowed. A valid domain requires a host and must not include any path, port, query or
        /// fragment. Examples: 'example.com' or 'subdomain.example.com'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedDomains")]
        public virtual System.Collections.Generic.IList<string> AllowedDomains { get; set; }

        /// <summary>
        /// Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be
        /// specified for IntegrationTypes CHECKBOX and INVISIBLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challengeSecurityPreference")]
        public virtual string ChallengeSecurityPreference { get; set; }

        /// <summary>Required. Describes how this key is integrated with the website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrationType")]
        public virtual string IntegrationType { get; set; }

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
}
