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
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://recaptchaenterprise.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://recaptchaenterprise.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "recaptchaenterprise";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the reCAPTCHA Enterprise API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the reCAPTCHA Enterprise API.</summary>
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
            Firewallpolicies = new FirewallpoliciesResource(service);
            Keys = new KeysResource(service);
            Relatedaccountgroupmemberships = new RelatedaccountgroupmembershipsResource(service);
            Relatedaccountgroups = new RelatedaccountgroupsResource(service);
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
            /// `projects/{project}/assessments/{assessment}`.
            /// </param>
            public virtual AnnotateRequest Annotate(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentRequest body, string name)
            {
                return new AnnotateRequest(this.service, body, name);
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
                /// `projects/{project}/assessments/{assessment}`.
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
            /// Required. The name of the project in which the assessment is created, in the format
            /// `projects/{project}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Assessment body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
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
                /// Required. The name of the project in which the assessment is created, in the format
                /// `projects/{project}`.
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

        /// <summary>Gets the Firewallpolicies resource.</summary>
        public virtual FirewallpoliciesResource Firewallpolicies { get; }

        /// <summary>The "firewallpolicies" collection of methods.</summary>
        public class FirewallpoliciesResource
        {
            private const string Resource = "firewallpolicies";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FirewallpoliciesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new FirewallPolicy, specifying conditions at which reCAPTCHA Enterprise actions can be
            /// executed. A project may have a maximum of 1000 policies.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project this policy applies to, in the format `projects/{project}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a new FirewallPolicy, specifying conditions at which reCAPTCHA Enterprise actions can be
            /// executed. A project may have a maximum of 1000 policies.
            /// </summary>
            public class CreateRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project this policy applies to, in the format `projects/{project}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/firewallpolicies";

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

            /// <summary>Deletes the specified firewall policy.</summary>
            /// <param name="name">
            /// Required. The name of the policy to be deleted, in the format
            /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes the specified firewall policy.</summary>
            public class DeleteRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the policy to be deleted, in the format
                /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
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
                        Pattern = @"^projects/[^/]+/firewallpolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Returns the specified firewall policy.</summary>
            /// <param name="name">
            /// Required. The name of the requested policy, in the format
            /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Returns the specified firewall policy.</summary>
            public class GetRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the requested policy, in the format
                /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
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
                        Pattern = @"^projects/[^/]+/firewallpolicies/[^/]+$",
                    });
                }
            }

            /// <summary>Returns the list of all firewall policies that belong to a project.</summary>
            /// <param name="parent">
            /// Required. The name of the project to list the policies for, in the format `projects/{project}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Returns the list of all firewall policies that belong to a project.</summary>
            public class ListRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ListFirewallPoliciesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project to list the policies for, in the format `projects/{project}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of policies to return. Default is 10. Max limit is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The next_page_token value returned from a previous. ListFirewallPoliciesRequest, if any.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/firewallpolicies";

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

            /// <summary>Updates the specified firewall policy.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name for the FirewallPolicy in the format
            /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates the specified firewall policy.</summary>
            public class PatchRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name for the FirewallPolicy in the format
                /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The mask to control which fields of the policy get updated. If the mask is not present,
                /// all fields are updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1FirewallPolicy Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/firewallpolicies/[^/]+$",
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

            /// <summary>Reorders all firewall policies.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project to list the policies for, in the format `projects/{project}`.
            /// </param>
            public virtual ReorderRequest Reorder(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ReorderFirewallPoliciesRequest body, string parent)
            {
                return new ReorderRequest(this.service, body, parent);
            }

            /// <summary>Reorders all firewall policies.</summary>
            public class ReorderRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ReorderFirewallPoliciesResponse>
            {
                /// <summary>Constructs a new Reorder request.</summary>
                public ReorderRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ReorderFirewallPoliciesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project to list the policies for, in the format `projects/{project}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ReorderFirewallPoliciesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reorder";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/firewallpolicies:reorder";

                /// <summary>Initializes Reorder parameter list.</summary>
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

            /// <summary>
            /// Adds an IP override to a key. The following restrictions hold: * The maximum number of IP overrides per
            /// key is 100. * For any conflict (such as IP already exists or IP part of an existing IP range), an error
            /// is returned.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the key to which the IP override is added, in the format
            /// `projects/{project}/keys/{key}`.
            /// </param>
            public virtual AddIpOverrideRequest AddIpOverride(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AddIpOverrideRequest body, string name)
            {
                return new AddIpOverrideRequest(this.service, body, name);
            }

            /// <summary>
            /// Adds an IP override to a key. The following restrictions hold: * The maximum number of IP overrides per
            /// key is 100. * For any conflict (such as IP already exists or IP part of an existing IP range), an error
            /// is returned.
            /// </summary>
            public class AddIpOverrideRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AddIpOverrideResponse>
            {
                /// <summary>Constructs a new AddIpOverride request.</summary>
                public AddIpOverrideRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AddIpOverrideRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the key to which the IP override is added, in the format
                /// `projects/{project}/keys/{key}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1AddIpOverrideRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addIpOverride";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:addIpOverride";

                /// <summary>Initializes AddIpOverride parameter list.</summary>
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

            /// <summary>Creates a new reCAPTCHA Enterprise key.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the project in which the key is created, in the format `projects/{project}`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
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
                /// Required. The name of the project in which the key is created, in the format `projects/{project}`.
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
            /// Required. The name of the key to be deleted, in the format `projects/{project}/keys/{key}`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
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
                /// Required. The name of the key to be deleted, in the format `projects/{project}/keys/{key}`.
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
            /// Required. The name of the requested key, in the format `projects/{project}/keys/{key}`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
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
                /// Required. The name of the requested key, in the format `projects/{project}/keys/{key}`.
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
            /// Required. The name of the requested metrics, in the format `projects/{project}/keys/{key}/metrics`.
            /// </param>
            public virtual GetMetricsRequest GetMetrics(string name)
            {
                return new GetMetricsRequest(this.service, name);
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
                /// Required. The name of the requested metrics, in the format `projects/{project}/keys/{key}/metrics`.
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
            /// Required. The name of the project that contains the keys that is listed, in the format
            /// `projects/{project}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
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
                /// Required. The name of the project that contains the keys that is listed, in the format
                /// `projects/{project}`.
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

            /// <summary>Lists all IP overrides for a key.</summary>
            /// <param name="parent">
            /// Required. The parent key for which the IP overrides are listed, in the format
            /// `projects/{project}/keys/{key}`.
            /// </param>
            public virtual ListIpOverridesRequest ListIpOverrides(string parent)
            {
                return new ListIpOverridesRequest(this.service, parent);
            }

            /// <summary>Lists all IP overrides for a key.</summary>
            public class ListIpOverridesRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ListIpOverridesResponse>
            {
                /// <summary>Constructs a new ListIpOverrides request.</summary>
                public ListIpOverridesRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent key for which the IP overrides are listed, in the format
                /// `projects/{project}/keys/{key}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of overrides to return. Default is 10. Max limit is 100. If the number
                /// of overrides is less than the page_size, all overrides are returned. If the page size is more than
                /// 100, it is coerced to 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. The next_page_token value returned from a previous ListIpOverridesRequest, if any.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "listIpOverrides";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}:listIpOverrides";

                /// <summary>Initializes ListIpOverrides parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/keys/[^/]+$",
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
            /// as one of the current owners of the reCAPTCHA Key, and your user must have the reCAPTCHA Enterprise
            /// Admin IAM role in the destination project.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the key to be migrated, in the format `projects/{project}/keys/{key}`.
            /// </param>
            public virtual MigrateRequest Migrate(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1MigrateKeyRequest body, string name)
            {
                return new MigrateRequest(this.service, body, name);
            }

            /// <summary>
            /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise. Once a key is migrated, it can be used
            /// from either product. SiteVerify requests are billed as CreateAssessment calls. You must be authenticated
            /// as one of the current owners of the reCAPTCHA Key, and your user must have the reCAPTCHA Enterprise
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
                /// Required. The name of the key to be migrated, in the format `projects/{project}/keys/{key}`.
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
            /// <param name="name">
            /// Identifier. The resource name for the Key in the format `projects/{project}/keys/{key}`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1Key body, string name)
            {
                return new PatchRequest(this.service, body, name);
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

                /// <summary>
                /// Identifier. The resource name for the Key in the format `projects/{project}/keys/{key}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. The mask to control which fields of the key get updated. If the mask is not present, all
                /// fields are updated.
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

            /// <summary>
            /// Removes an IP override from a key. The following restrictions hold: * If the IP isn't found in an
            /// existing IP override, a `NOT_FOUND` error is returned. * If the IP is found in an existing IP override,
            /// but the override type does not match, a `NOT_FOUND` error is returned.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the key from which the IP override is removed, in the format
            /// `projects/{project}/keys/{key}`.
            /// </param>
            public virtual RemoveIpOverrideRequest RemoveIpOverride(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1RemoveIpOverrideRequest body, string name)
            {
                return new RemoveIpOverrideRequest(this.service, body, name);
            }

            /// <summary>
            /// Removes an IP override from a key. The following restrictions hold: * If the IP isn't found in an
            /// existing IP override, a `NOT_FOUND` error is returned. * If the IP is found in an existing IP override,
            /// but the override type does not match, a `NOT_FOUND` error is returned.
            /// </summary>
            public class RemoveIpOverrideRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1RemoveIpOverrideResponse>
            {
                /// <summary>Constructs a new RemoveIpOverride request.</summary>
                public RemoveIpOverrideRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1RemoveIpOverrideRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the key from which the IP override is removed, in the format
                /// `projects/{project}/keys/{key}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1RemoveIpOverrideRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "removeIpOverride";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:removeIpOverride";

                /// <summary>Initializes RemoveIpOverride parameter list.</summary>
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

            /// <summary>
            /// Returns the secret key related to the specified public key. You must use the legacy secret key only in a
            /// 3rd party integration with legacy reCAPTCHA.
            /// </summary>
            /// <param name="key">
            /// Required. The public key name linked to the requested secret key in the format
            /// `projects/{project}/keys/{key}`.
            /// </param>
            public virtual RetrieveLegacySecretKeyRequest RetrieveLegacySecretKey(string key)
            {
                return new RetrieveLegacySecretKeyRequest(this.service, key);
            }

            /// <summary>
            /// Returns the secret key related to the specified public key. You must use the legacy secret key only in a
            /// 3rd party integration with legacy reCAPTCHA.
            /// </summary>
            public class RetrieveLegacySecretKeyRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1RetrieveLegacySecretKeyResponse>
            {
                /// <summary>Constructs a new RetrieveLegacySecretKey request.</summary>
                public RetrieveLegacySecretKeyRequest(Google.Apis.Services.IClientService service, string key) : base(service)
                {
                    Key = key;
                    InitParameters();
                }

                /// <summary>
                /// Required. The public key name linked to the requested secret key in the format
                /// `projects/{project}/keys/{key}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Key { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "retrieveLegacySecretKey";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+key}:retrieveLegacySecretKey";

                /// <summary>Initializes RetrieveLegacySecretKey parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
                    {
                        Name = "key",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/keys/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Relatedaccountgroupmemberships resource.</summary>
        public virtual RelatedaccountgroupmembershipsResource Relatedaccountgroupmemberships { get; }

        /// <summary>The "relatedaccountgroupmemberships" collection of methods.</summary>
        public class RelatedaccountgroupmembershipsResource
        {
            private const string Resource = "relatedaccountgroupmemberships";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RelatedaccountgroupmembershipsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Search group memberships related to a given account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="project">
            /// Required. The name of the project to search related account group memberships from. Specify the project
            /// name in the following format: `projects/{project}`.
            /// </param>
            public virtual SearchRequest Search(Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1SearchRelatedAccountGroupMembershipsRequest body, string project)
            {
                return new SearchRequest(this.service, body, project);
            }

            /// <summary>Search group memberships related to a given account.</summary>
            public class SearchRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1SearchRelatedAccountGroupMembershipsResponse>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1SearchRelatedAccountGroupMembershipsRequest body, string project) : base(service)
                {
                    Project = project;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project to search related account group memberships from. Specify the
                /// project name in the following format: `projects/{project}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1SearchRelatedAccountGroupMembershipsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/relatedaccountgroupmemberships:search";

                /// <summary>Initializes Search parameter list.</summary>
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
                }
            }
        }

        /// <summary>Gets the Relatedaccountgroups resource.</summary>
        public virtual RelatedaccountgroupsResource Relatedaccountgroups { get; }

        /// <summary>The "relatedaccountgroups" collection of methods.</summary>
        public class RelatedaccountgroupsResource
        {
            private const string Resource = "relatedaccountgroups";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RelatedaccountgroupsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Memberships = new MembershipsResource(service);
            }

            /// <summary>Gets the Memberships resource.</summary>
            public virtual MembershipsResource Memberships { get; }

            /// <summary>The "memberships" collection of methods.</summary>
            public class MembershipsResource
            {
                private const string Resource = "memberships";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MembershipsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get memberships in a group of related accounts.</summary>
                /// <param name="parent">
                /// Required. The resource name for the related account group in the format
                /// `projects/{project}/relatedaccountgroups/{relatedaccountgroup}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>Get memberships in a group of related accounts.</summary>
                public class ListRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ListRelatedAccountGroupMembershipsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The resource name for the related account group in the format
                    /// `projects/{project}/relatedaccountgroups/{relatedaccountgroup}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of accounts to return. The service might return fewer than this
                    /// value. If unspecified, at most 50 accounts are returned. The maximum value is 1000; values above
                    /// 1000 are coerced to 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `ListRelatedAccountGroupMemberships` call. When
                    /// paginating, all other parameters provided to `ListRelatedAccountGroupMemberships` must match the
                    /// call that provided the page token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/memberships";

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
                            Pattern = @"^projects/[^/]+/relatedaccountgroups/[^/]+$",
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

            /// <summary>List groups of related accounts.</summary>
            /// <param name="parent">
            /// Required. The name of the project to list related account groups from, in the format
            /// `projects/{project}`.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List groups of related accounts.</summary>
            public class ListRequest : RecaptchaEnterpriseBaseServiceRequest<Google.Apis.RecaptchaEnterprise.v1.Data.GoogleCloudRecaptchaenterpriseV1ListRelatedAccountGroupsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the project to list related account groups from, in the format
                /// `projects/{project}`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of groups to return. The service might return fewer than this value. If
                /// unspecified, at most 50 groups are returned. The maximum value is 1000; values above 1000 are
                /// coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListRelatedAccountGroups` call. Provide this to
                /// retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListRelatedAccountGroups` must match the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/relatedaccountgroups";

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
        }
    }
}
namespace Google.Apis.RecaptchaEnterprise.v1.Data
{
    /// <summary>Account defender risk assessment.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AccountDefenderAssessment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Labels for this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about account verification, used for identity verification.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AccountVerificationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Endpoints that can be used for identity verification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endpoints")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1EndpointVerificationInfo> Endpoints { get; set; }

        /// <summary>
        /// Optional. Language code preference for the verification message, set as a IETF BCP 47 language code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Output only. Result of the latest account verification challenge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestVerificationResult")]
        public virtual string LatestVerificationResult { get; set; }

        /// <summary>
        /// Username of the account that is being verified. Deprecated. Customers should now provide the `account_id`
        /// field in `event.user_info`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The AddIpOverride request message.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AddIpOverrideRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. IP override added to the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipOverrideData")]
        public virtual GoogleCloudRecaptchaenterpriseV1IpOverrideData IpOverrideData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for AddIpOverride.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AddIpOverrideResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to keys that can be used by Android apps.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AndroidKeySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, allowed_package_names are not enforced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAllPackageNames")]
        public virtual System.Nullable<bool> AllowAllPackageNames { get; set; }

        /// <summary>
        /// Optional. Android package names of apps allowed to use the key. Example: 'com.companyname.appname'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedPackageNames")]
        public virtual System.Collections.Generic.IList<string> AllowedPackageNames { get; set; }

        /// <summary>
        /// Optional. Set to true for keys that are used in an Android application that is available for download in app
        /// stores in addition to the Google Play Store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportNonGoogleAppStoreDistribution")]
        public virtual System.Nullable<bool> SupportNonGoogleAppStoreDistribution { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message to annotate an Assessment.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A stable account identifier to apply to the assessment. This is an alternative to setting
        /// `account_id` in `CreateAssessment`, for example when a stable account identifier is not yet known in the
        /// initial request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// Optional. The annotation that is assigned to the Event. This field can be left empty to provide reasons that
        /// apply to an event without concluding whether the event is legitimate or fraudulent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotation")]
        public virtual string Annotation { get; set; }

        /// <summary>
        /// Optional. A stable hashed account identifier to apply to the assessment. This is an alternative to setting
        /// `hashed_account_id` in `CreateAssessment`, for example when a stable account identifier is not yet known in
        /// the initial request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedAccountId")]
        public virtual string HashedAccountId { get; set; }

        /// <summary>Optional. Reasons for the annotation that are assigned to the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
        public virtual System.Collections.Generic.IList<string> Reasons { get; set; }

        /// <summary>
        /// Optional. If the assessment is part of a payment transaction, provide details on payment lifecycle events
        /// that occur in the transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionEvent")]
        public virtual GoogleCloudRecaptchaenterpriseV1TransactionEvent TransactionEvent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Empty response for AnnotateAssessment.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AnnotateAssessmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains fields that are required to perform Apple-specific integrity checks.</summary>
    public class GoogleCloudRecaptchaenterpriseV1AppleDeveloperId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The Apple developer key ID (10-character string).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>
        /// Required. Input only. A private key (downloaded as a text file with a .p8 file extension) generated for your
        /// Apple Developer account. Ensure that Apple DeviceCheck is enabled for the private key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKey")]
        public virtual string PrivateKey { get; set; }

        /// <summary>
        /// Required. The Apple team ID (10-character string) owning the provisioning profile used to build your
        /// application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teamId")]
        public virtual string TeamId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reCAPTCHA Enterprise assessment resource.</summary>
    public class GoogleCloudRecaptchaenterpriseV1Assessment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Assessment returned by account defender when an account identifier is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountDefenderAssessment")]
        public virtual GoogleCloudRecaptchaenterpriseV1AccountDefenderAssessment AccountDefenderAssessment { get; set; }

        /// <summary>
        /// Optional. Account verification information for identity verification. The assessment event must include a
        /// token and site key to use this feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountVerification")]
        public virtual GoogleCloudRecaptchaenterpriseV1AccountVerificationInfo AccountVerification { get; set; }

        /// <summary>
        /// Optional. The environment creating the assessment. This describes your environment (the system invoking
        /// CreateAssessment), NOT the environment of your user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assessmentEnvironment")]
        public virtual GoogleCloudRecaptchaenterpriseV1AssessmentEnvironment AssessmentEnvironment { get; set; }

        /// <summary>Optional. The event being assessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual GoogleCloudRecaptchaenterpriseV1Event Event__ { get; set; }

        /// <summary>
        /// Output only. Assessment returned when firewall policies belonging to the project are evaluated using the
        /// field firewall_policy_evaluation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewallPolicyAssessment")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallPolicyAssessment FirewallPolicyAssessment { get; set; }

        /// <summary>Output only. Assessment returned by Fraud Prevention when TransactionData is provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fraudPreventionAssessment")]
        public virtual GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessment FraudPreventionAssessment { get; set; }

        /// <summary>Output only. Fraud Signals specific to the users involved in a payment transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fraudSignals")]
        public virtual GoogleCloudRecaptchaenterpriseV1FraudSignals FraudSignals { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name for the Assessment in the format
        /// `projects/{project}/assessments/{assessment}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Assessment returned when a site key, a token, and a phone number as `user_id` are provided.
        /// Account defender and SMS toll fraud protection need to be enabled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneFraudAssessment")]
        public virtual GoogleCloudRecaptchaenterpriseV1PhoneFraudAssessment PhoneFraudAssessment { get; set; }

        /// <summary>
        /// Optional. The private password leak verification field contains the parameters that are used to to check for
        /// leaks privately without sharing user credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privatePasswordLeakVerification")]
        public virtual GoogleCloudRecaptchaenterpriseV1PrivatePasswordLeakVerification PrivatePasswordLeakVerification { get; set; }

        /// <summary>Output only. The risk analysis result for the event being assessed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskAnalysis")]
        public virtual GoogleCloudRecaptchaenterpriseV1RiskAnalysis RiskAnalysis { get; set; }

        /// <summary>Output only. Properties of the provided event token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenProperties")]
        public virtual GoogleCloudRecaptchaenterpriseV1TokenProperties TokenProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The environment creating the assessment. This describes your environment (the system invoking CreateAssessment),
    /// NOT the environment of your user.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1AssessmentEnvironment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Identifies the client module initiating the CreateAssessment request. This can be the link to the
        /// client module's project. Examples include: -
        /// "github.com/GoogleCloudPlatform/recaptcha-enterprise-google-tag-manager" -
        /// "cloud.google.com/recaptcha/docs/implement-waf-akamai" -
        /// "cloud.google.com/recaptcha/docs/implement-waf-cloudflare" - "wordpress.org/plugins/recaptcha-something"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public virtual string Client { get; set; }

        /// <summary>Optional. The version of the client module. For example, "1.0.0".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Bot information and metadata.</summary>
    public class GoogleCloudRecaptchaenterpriseV1Bot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Enumerated field representing the type of bot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("botType")]
        public virtual string BotType { get; set; }

        /// <summary>
        /// Optional. Enumerated string value that indicates the identity of the bot, formatted in kebab-case.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>Information about a verification endpoint that can be used for 2FA.</summary>
    public class GoogleCloudRecaptchaenterpriseV1EndpointVerificationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email address for which to trigger a verification request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        private string _lastVerificationTimeRaw;

        private object _lastVerificationTime;

        /// <summary>Output only. Timestamp of the last successful verification for the endpoint, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastVerificationTime")]
        public virtual string LastVerificationTimeRaw
        {
            get => _lastVerificationTimeRaw;
            set
            {
                _lastVerificationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastVerificationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastVerificationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastVerificationTimeDateTimeOffset instead.")]
        public virtual object LastVerificationTime
        {
            get => _lastVerificationTime;
            set
            {
                _lastVerificationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastVerificationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastVerificationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastVerificationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastVerificationTimeRaw);
            set => LastVerificationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Phone number for which to trigger a verification request. Should be given in E.164 format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// Output only. Token to provide to the client to trigger endpoint verification. It must be used within 15
        /// minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestToken")]
        public virtual string RequestToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The event being assessed.</summary>
    public class GoogleCloudRecaptchaenterpriseV1Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The expected action for this type of event. This should be the same action provided at token
        /// generation time on client-side platforms already integrated with recaptcha enterprise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedAction")]
        public virtual string ExpectedAction { get; set; }

        /// <summary>
        /// Optional. Flag for a reCAPTCHA express request for an assessment without a token. If enabled, `site_key`
        /// must reference an Express site key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("express")]
        public virtual System.Nullable<bool> Express { get; set; }

        /// <summary>
        /// Optional. Flag for enabling firewall policy config assessment. If this flag is enabled, the firewall policy
        /// is evaluated and a suggested firewall action is returned in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewallPolicyEvaluation")]
        public virtual System.Nullable<bool> FirewallPolicyEvaluation { get; set; }

        /// <summary>Optional. The Fraud Prevention setting for this assessment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fraudPrevention")]
        public virtual string FraudPrevention { get; set; }

        /// <summary>
        /// Optional. Deprecated: use `user_info.account_id` instead. Unique stable hashed user identifier for the
        /// request. The identifier must be hashed using hmac-sha256 with stable secret.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedAccountId")]
        public virtual string HashedAccountId { get; set; }

        /// <summary>Optional. HTTP header information about the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<string> Headers { get; set; }

        /// <summary>
        /// Optional. JA3 fingerprint for SSL clients. To learn how to compute this fingerprint, please refer to
        /// https://github.com/salesforce/ja3.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ja3")]
        public virtual string Ja3 { get; set; }

        /// <summary>
        /// Optional. JA4 fingerprint for SSL clients. To learn how to compute this fingerprint, please refer to
        /// https://github.com/FoxIO-LLC/ja4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ja4")]
        public virtual string Ja4 { get; set; }

        /// <summary>Optional. The URI resource the user requested that triggered an assessment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedUri")]
        public virtual string RequestedUri { get; set; }

        /// <summary>
        /// Optional. The site key that was used to invoke reCAPTCHA Enterprise on your site and generate the token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteKey")]
        public virtual string SiteKey { get; set; }

        /// <summary>
        /// Optional. The user response token provided by the reCAPTCHA Enterprise client-side integration on your site.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// Optional. Data describing a payment transaction to be assessed. Sending this data enables reCAPTCHA
        /// Enterprise Fraud Prevention and the FraudPreventionAssessment component in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionData")]
        public virtual GoogleCloudRecaptchaenterpriseV1TransactionData TransactionData { get; set; }

        /// <summary>
        /// Optional. The user agent present in the request from the user's device related to this event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Optional. Information about the user that generates this event, when they can be identified. They are often
        /// identified through the use of an account for logged-in requests or login/registration requests, or by
        /// providing user identifiers for guest actions like checkout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInfo")]
        public virtual GoogleCloudRecaptchaenterpriseV1UserInfo UserInfo { get; set; }

        /// <summary>Optional. The IP address in the request from the user's device related to this event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIpAddress")]
        public virtual string UserIpAddress { get; set; }

        /// <summary>
        /// Optional. Flag for running WAF token assessment. If enabled, the token must be specified, and have been
        /// created by a WAF-enabled key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wafTokenAssessment")]
        public virtual System.Nullable<bool> WafTokenAssessment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to keys that can be used for reCAPTCHA Express.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ExpressKeySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual action. Each action represents what to do if a policy matches.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The user request did not match any policy and should be allowed access to the requested resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allow")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallActionAllowAction Allow { get; set; }

        /// <summary>This action denies access to a given page. The user gets an HTTP error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("block")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallActionBlockAction Block { get; set; }

        /// <summary>
        /// This action injects reCAPTCHA JavaScript code into the HTML page returned by the site backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRecaptchaScript")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallActionIncludeRecaptchaScriptAction IncludeRecaptchaScript { get; set; }

        /// <summary>This action redirects the request to a reCAPTCHA interstitial to attach a token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirect")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallActionRedirectAction Redirect { get; set; }

        /// <summary>
        /// This action sets a custom header but allow the request to continue to the customer backend.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setHeader")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallActionSetHeaderAction SetHeader { get; set; }

        /// <summary>This action transparently serves a different page to an offending user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("substitute")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallActionSubstituteAction Substitute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An allow action continues processing a request unimpeded.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallActionAllowAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A block action serves an HTTP error code a prevents the request from hitting the backend.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallActionBlockAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An include reCAPTCHA script action involves injecting reCAPTCHA JavaScript code into the HTML returned by the
    /// site backend. This reCAPTCHA script is tasked with collecting user signals on the requested web page, issuing
    /// tokens as a cookie within the site domain, and enabling their utilization in subsequent page requests.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallActionIncludeRecaptchaScriptAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A redirect action returns a 307 (temporary redirect) response, pointing the user to a reCAPTCHA interstitial
    /// page to attach a token.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallActionRedirectAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set header action sets a header and forwards the request to the backend. This can be used to trigger custom
    /// protection implemented on the backend.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallActionSetHeaderAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The header key to set in the request to the backend server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>Optional. The header value to set in the request to the backend server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A substitute action transparently serves a different page than the one requested.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallActionSubstituteAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The address to redirect to. The target is a relative path in the current host. Example:
        /// "/blog/404.html".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A FirewallPolicy represents a single matching pattern and resulting actions to take.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The actions that the caller should take regarding user access. There should be at most one
        /// terminal action. A terminal action is any action that forces a response, such as `AllowAction`,
        /// `BlockAction` or `SubstituteAction`. Zero or more non-terminal actions such as `SetHeader` might be
        /// specified. A single policy can contain up to 16 actions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1FirewallAction> Actions { get; set; }

        /// <summary>
        /// Optional. A CEL (Common Expression Language) conditional expression that specifies if this policy applies to
        /// an incoming user request. If this condition evaluates to true and the requested path matched the path
        /// pattern, the associated actions should be executed by the caller. The condition string is checked for CEL
        /// syntax correctness on creation. For more information, see the [CEL spec](https://github.com/google/cel-spec)
        /// and its [language definition](https://github.com/google/cel-spec/blob/master/doc/langdef.md). A condition
        /// has a max length of 500 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; }

        /// <summary>
        /// Optional. A description of what this policy aims to achieve, for convenience purposes. The description can
        /// at most include 256 UTF-8 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Identifier. The resource name for the FirewallPolicy in the format
        /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The path for which this policy applies, specified as a glob pattern. For more information on glob,
        /// see the [manual page](https://man7.org/linux/man-pages/man7/glob.7.html). A path has a max length of 200
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Policy config assessment.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FirewallPolicyAssessment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If the processing of a policy config fails, an error is populated and the firewall_policy is
        /// left empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>
        /// Output only. The policy that matched the request. If more than one policy may match, this is the first
        /// match. If no policy matches the incoming request, the policy field is left empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewallPolicy")]
        public virtual GoogleCloudRecaptchaenterpriseV1FirewallPolicy FirewallPolicy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Assessment for Fraud Prevention.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Assessment of this transaction for behavioral trust.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("behavioralTrustVerdict")]
        public virtual GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentBehavioralTrustVerdict BehavioralTrustVerdict { get; set; }

        /// <summary>
        /// Output only. Assessment of this transaction for risk of being part of a card testing attack.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardTestingVerdict")]
        public virtual GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentCardTestingVerdict CardTestingVerdict { get; set; }

        /// <summary>
        /// Output only. Reasons why the transaction is probably fraudulent and received a high transaction risk score.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskReasons")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentRiskReason> RiskReasons { get; set; }

        /// <summary>Output only. Assessment of this transaction for risk of a stolen instrument.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stolenInstrumentVerdict")]
        public virtual GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentStolenInstrumentVerdict StolenInstrumentVerdict { get; set; }

        /// <summary>
        /// Output only. Probability of this transaction being fraudulent. Summarizes the combined risk of attack
        /// vectors below. Values are from 0.0 (lowest) to 1.0 (highest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionRisk")]
        public virtual System.Nullable<float> TransactionRisk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about behavioral trust of the transaction.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentBehavioralTrustVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Probability of this transaction attempt being executed in a behaviorally trustworthy way.
        /// Values are from 0.0 (lowest) to 1.0 (highest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trust")]
        public virtual System.Nullable<float> Trust { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about card testing fraud, where an adversary is testing fraudulently obtained cards or brute forcing
    /// their details.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentCardTestingVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Probability of this transaction attempt being part of a card testing attack. Values are from
        /// 0.0 (lowest) to 1.0 (highest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("risk")]
        public virtual System.Nullable<float> Risk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Risk reasons applicable to the Fraud Prevention assessment.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentRiskReason : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Risk reasons applicable to the Fraud Prevention assessment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about stolen instrument fraud, where the user is not the legitimate owner of the instrument being
    /// used for the purchase.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudPreventionAssessmentStolenInstrumentVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Probability of this transaction being executed with a stolen instrument. Values are from 0.0
        /// (lowest) to 1.0 (highest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("risk")]
        public virtual System.Nullable<float> Risk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fraud signals describing users and cards involved in the transaction.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudSignals : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Signals describing the payment card or cards used in this transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardSignals")]
        public virtual GoogleCloudRecaptchaenterpriseV1FraudSignalsCardSignals CardSignals { get; set; }

        /// <summary>Output only. Signals describing the end user in this transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSignals")]
        public virtual GoogleCloudRecaptchaenterpriseV1FraudSignalsUserSignals UserSignals { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Signals describing the payment card used in this transaction.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudSignalsCardSignals : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The labels for the payment card in this transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardLabels")]
        public virtual System.Collections.Generic.IList<string> CardLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Signals describing the user involved in this transaction.</summary>
    public class GoogleCloudRecaptchaenterpriseV1FraudSignalsUserSignals : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. This user (based on email, phone, and other identifiers) has been seen on the internet for at
        /// least this number of days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDaysLowerBound")]
        public virtual System.Nullable<int> ActiveDaysLowerBound { get; set; }

        /// <summary>
        /// Output only. Likelihood (from 0.0 to 1.0) this user includes synthetic components in their identity, such as
        /// a randomly generated email address, temporary phone number, or fake shipping address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syntheticRisk")]
        public virtual System.Nullable<float> SyntheticRisk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to keys that can be used by iOS apps.</summary>
    public class GoogleCloudRecaptchaenterpriseV1IOSKeySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, allowed_bundle_ids are not enforced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAllBundleIds")]
        public virtual System.Nullable<bool> AllowAllBundleIds { get; set; }

        /// <summary>
        /// Optional. iOS bundle ids of apps allowed to use the key. Example: 'com.companyname.productname.appname'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedBundleIds")]
        public virtual System.Collections.Generic.IList<string> AllowedBundleIds { get; set; }

        /// <summary>
        /// Optional. Apple Developer account details for the app that is protected by the reCAPTCHA Key. reCAPTCHA
        /// leverages platform-specific checks like Apple App Attest and Apple DeviceCheck to protect your app from
        /// abuse. Providing these fields allows reCAPTCHA to get a better assessment of the integrity of your app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appleDeveloperId")]
        public virtual GoogleCloudRecaptchaenterpriseV1AppleDeveloperId AppleDeveloperId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the IP or IP range override.</summary>
    public class GoogleCloudRecaptchaenterpriseV1IpOverrideData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The IP address to override (can be IPv4, IPv6 or CIDR). The IP override must be a valid IPv4 or
        /// IPv6 address, or a CIDR range. The IP override must be a public IP address. Example of IPv4: 168.192.5.6
        /// Example of IPv6: 2001:0000:130F:0000:0000:09C0:876A:130B Example of IPv4 with CIDR: 168.192.5.0/24 Example
        /// of IPv6 with CIDR: 2001:0DB8:1234::/48
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public virtual string Ip { get; set; }

        /// <summary>Required. Describes the type of IP override.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overrideType")]
        public virtual string OverrideType { get; set; }

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

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp corresponding to the creation of this key.</summary>
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

        /// <summary>Required. Human-readable display name of this key. Modifiable by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Settings for keys that can be used by reCAPTCHA Express.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressSettings")]
        public virtual GoogleCloudRecaptchaenterpriseV1ExpressKeySettings ExpressSettings { get; set; }

        /// <summary>Settings for keys that can be used by iOS apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosSettings")]
        public virtual GoogleCloudRecaptchaenterpriseV1IOSKeySettings IosSettings { get; set; }

        /// <summary>
        /// Optional. See [Creating and managing labels] (https://cloud.google.com/recaptcha/docs/labels).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Identifier. The resource name for the Key in the format `projects/{project}/keys/{key}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. Options for user acceptance testing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingOptions")]
        public virtual GoogleCloudRecaptchaenterpriseV1TestingOptions TestingOptions { get; set; }

        /// <summary>Optional. Settings for WAF</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wafSettings")]
        public virtual GoogleCloudRecaptchaenterpriseV1WafSettings WafSettings { get; set; }

        /// <summary>Settings for keys that can be used by websites.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webSettings")]
        public virtual GoogleCloudRecaptchaenterpriseV1WebKeySettings WebSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to request to list firewall policies belonging to a project.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ListFirewallPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policy details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firewallPolicies")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1FirewallPolicy> FirewallPolicies { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. It is set to empty if no policies remain in results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListIpOverrides.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ListIpOverridesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IP Overrides details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipOverrides")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1IpOverrideData> IpOverrides { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. If this field is empty, no keys remain in the results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

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

    /// <summary>The response to a `ListRelatedAccountGroupMemberships` call.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ListRelatedAccountGroupMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The memberships listed by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedAccountGroupMemberships")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1RelatedAccountGroupMembership> RelatedAccountGroupMemberships { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a `ListRelatedAccountGroups` call.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ListRelatedAccountGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The groups of related accounts listed by the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedAccountGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1RelatedAccountGroup> RelatedAccountGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metrics for a single Key.</summary>
    public class GoogleCloudRecaptchaenterpriseV1Metrics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metrics are continuous and in order by dates, and in the granularity of day. Only challenge-based keys
        /// (CHECKBOX, INVISIBLE) have challenge-based data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challengeMetrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1ChallengeMetrics> ChallengeMetrics { get; set; }

        /// <summary>
        /// Output only. Identifier. The name of the metrics, in the format `projects/{project}/keys/{key}/metrics`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Metrics are continuous and in order by dates, and in the granularity of day. All Key types should have
        /// score-based data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreMetrics")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1ScoreMetrics> ScoreMetrics { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Inclusive start time aligned to a day in the America/Los_Angeles (Pacific) timezone.</summary>
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

    /// <summary>The migrate key request message.</summary>
    public class GoogleCloudRecaptchaenterpriseV1MigrateKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If true, skips the billing check. A reCAPTCHA Enterprise key or migrated key behaves differently
        /// than a reCAPTCHA (non-Enterprise version) key when you reach a quota limit (see
        /// https://cloud.google.com/recaptcha/quotas#quota_limit). To avoid any disruption of your usage, we check that
        /// a billing account is present. If your usage of reCAPTCHA is under the free quota, you can safely skip the
        /// billing check and proceed with the migration. See
        /// https://cloud.google.com/recaptcha/docs/billing-information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipBillingCheck")]
        public virtual System.Nullable<bool> SkipBillingCheck { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Assessment for Phone Fraud</summary>
    public class GoogleCloudRecaptchaenterpriseV1PhoneFraudAssessment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Assessment of this phone event for risk of SMS toll fraud.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("smsTollFraudVerdict")]
        public virtual GoogleCloudRecaptchaenterpriseV1SmsTollFraudVerdict SmsTollFraudVerdict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Private password leak verification info.</summary>
    public class GoogleCloudRecaptchaenterpriseV1PrivatePasswordLeakVerification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. List of prefixes of the encrypted potential password leaks that matched the given parameters.
        /// They must be compared with the client-side decryption prefix of `reencrypted_user_credentials_hash`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedLeakMatchPrefixes")]
        public virtual System.Collections.Generic.IList<string> EncryptedLeakMatchPrefixes { get; set; }

        /// <summary>
        /// Optional. Encrypted Scrypt hash of the canonicalized username+password. It is re-encrypted by the server and
        /// returned through `reencrypted_user_credentials_hash`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedUserCredentialsHash")]
        public virtual string EncryptedUserCredentialsHash { get; set; }

        /// <summary>
        /// Required. Exactly 26-bit prefix of the SHA-256 hash of the canonicalized username. It is used to look up
        /// password leaks associated with that hash prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lookupHashPrefix")]
        public virtual string LookupHashPrefix { get; set; }

        /// <summary>
        /// Output only. Corresponds to the re-encryption of the `encrypted_user_credentials_hash` field. It is used to
        /// match potential password leaks within `encrypted_leak_match_prefixes`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reencryptedUserCredentialsHash")]
        public virtual string ReencryptedUserCredentialsHash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A group of related accounts.</summary>
    public class GoogleCloudRecaptchaenterpriseV1RelatedAccountGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Identifier. The resource name for the related account group in the format
        /// `projects/{project}/relatedaccountgroups/{related_account_group}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A membership in a group of related accounts.</summary>
    public class GoogleCloudRecaptchaenterpriseV1RelatedAccountGroupMembership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique stable account identifier of the member. The identifier corresponds to an `account_id` provided
        /// in a previous `CreateAssessment` or `AnnotateAssessment` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// Deprecated: use `account_id` instead. The unique stable hashed account identifier of the member. The
        /// identifier corresponds to a `hashed_account_id` provided in a previous `CreateAssessment` or
        /// `AnnotateAssessment` call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedAccountId")]
        public virtual string HashedAccountId { get; set; }

        /// <summary>
        /// Required. Identifier. The resource name for this membership in the format
        /// `projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The RemoveIpOverride request message.</summary>
    public class GoogleCloudRecaptchaenterpriseV1RemoveIpOverrideRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. IP override to be removed from the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipOverrideData")]
        public virtual GoogleCloudRecaptchaenterpriseV1IpOverrideData IpOverrideData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for RemoveIpOverride.</summary>
    public class GoogleCloudRecaptchaenterpriseV1RemoveIpOverrideResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The reorder firewall policies request message.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ReorderFirewallPoliciesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list containing all policy names, in the new order. Each name is in the format
        /// `projects/{project}/firewallpolicies/{firewallpolicy}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The reorder firewall policies response message.</summary>
    public class GoogleCloudRecaptchaenterpriseV1ReorderFirewallPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Secret key is used only in legacy reCAPTCHA. It must be used in a 3rd party integration with legacy reCAPTCHA.
    /// </summary>
    public class GoogleCloudRecaptchaenterpriseV1RetrieveLegacySecretKeyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The secret key (also known as shared secret) authorizes communication between your application backend and
        /// the reCAPTCHA Enterprise server to create an assessment. The secret key needs to be kept safe for security
        /// purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacySecretKey")]
        public virtual string LegacySecretKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Risk analysis result for an event.</summary>
    public class GoogleCloudRecaptchaenterpriseV1RiskAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Challenge information for SCORE_AND_CHALLENGE and INVISIBLE keys</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challenge")]
        public virtual string Challenge { get; set; }

        /// <summary>
        /// Output only. Extended verdict reasons to be used for experimentation only. The set of possible reasons is
        /// subject to change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedVerdictReasons")]
        public virtual System.Collections.Generic.IList<string> ExtendedVerdictReasons { get; set; }

        /// <summary>Output only. Reasons contributing to the risk analysis verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
        public virtual System.Collections.Generic.IList<string> Reasons { get; set; }

        /// <summary>
        /// Output only. Legitimate event score from 0.0 to 1.0. (1.0 means very likely legitimate traffic while 0.0
        /// means very likely non-legitimate traffic).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>
        /// Output only. Bots with identities that have been verified by reCAPTCHA and detected in the event.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedBots")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1Bot> VerifiedBots { get; set; }

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
        /// "execute" client-side call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionMetrics")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudRecaptchaenterpriseV1ScoreDistribution> ActionMetrics { get; set; }

        /// <summary>Aggregated score metrics for all traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overallMetrics")]
        public virtual GoogleCloudRecaptchaenterpriseV1ScoreDistribution OverallMetrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message to search related account group memberships.</summary>
    public class GoogleCloudRecaptchaenterpriseV1SearchRelatedAccountGroupMembershipsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The unique stable account identifier used to search connections. The identifier should correspond
        /// to an `account_id` provided in a previous `CreateAssessment` or `AnnotateAssessment` call. Either
        /// hashed_account_id or account_id must be set, but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// Optional. Deprecated: use `account_id` instead. The unique stable hashed account identifier used to search
        /// connections. The identifier should correspond to a `hashed_account_id` provided in a previous
        /// `CreateAssessment` or `AnnotateAssessment` call. Either hashed_account_id or account_id must be set, but not
        /// both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedAccountId")]
        public virtual string HashedAccountId { get; set; }

        /// <summary>
        /// Optional. The maximum number of groups to return. The service might return fewer than this value. If
        /// unspecified, at most 50 groups are returned. The maximum value is 1000; values above 1000 are coerced to
        /// 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// Optional. A page token, received from a previous `SearchRelatedAccountGroupMemberships` call. Provide this
        /// to retrieve the subsequent page. When paginating, all other parameters provided to
        /// `SearchRelatedAccountGroupMemberships` must match the call that provided the page token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a `SearchRelatedAccountGroupMemberships` call.</summary>
    public class GoogleCloudRecaptchaenterpriseV1SearchRelatedAccountGroupMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The queried memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relatedAccountGroupMemberships")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1RelatedAccountGroupMembership> RelatedAccountGroupMemberships { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about SMS toll fraud.</summary>
    public class GoogleCloudRecaptchaenterpriseV1SmsTollFraudVerdict : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Reasons contributing to the SMS toll fraud verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
        public virtual System.Collections.Generic.IList<string> Reasons { get; set; }

        /// <summary>
        /// Output only. Probability of an SMS event being fraudulent. Values are from 0.0 (lowest) to 1.0 (highest).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("risk")]
        public virtual System.Nullable<float> Risk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for user acceptance testing.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TestingOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site return
        /// nocaptcha if NOCAPTCHA, or an unsolvable challenge if CHALLENGE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingChallenge")]
        public virtual string TestingChallenge { get; set; }

        /// <summary>
        /// Optional. All assessments for this Key return this score. Must be between 0 (likely not legitimate) and 1
        /// (likely legitimate) inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testingScore")]
        public virtual System.Nullable<float> TestingScore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of the provided event token.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TokenProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Action name provided at token generation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// Output only. The name of the Android package with which the token was generated (Android keys only).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidPackageName")]
        public virtual string AndroidPackageName { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The timestamp corresponding to the generation of the token.</summary>
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

        /// <summary>Output only. The hostname of the page on which the token was generated (Web keys only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>Output only. Reason associated with the response when valid = false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidReason")]
        public virtual string InvalidReason { get; set; }

        /// <summary>Output only. The ID of the iOS bundle with which the token was generated (iOS keys only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosBundleId")]
        public virtual string IosBundleId { get; set; }

        /// <summary>
        /// Output only. Whether the provided user response token is valid. When valid = false, the reason could be
        /// specified in invalid_reason or it could also be due to a user failing to solve a challenge or a sitekey
        /// mismatch (i.e the sitekey used to generate the token was different than the one specified in the
        /// assessment).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valid")]
        public virtual System.Nullable<bool> Valid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Transaction data associated with a payment protected by reCAPTCHA Enterprise.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TransactionData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Address associated with the payment method when applicable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingAddress")]
        public virtual GoogleCloudRecaptchaenterpriseV1TransactionDataAddress BillingAddress { get; set; }

        /// <summary>Optional. The Bank Identification Number - generally the first 6 or 8 digits of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardBin")]
        public virtual string CardBin { get; set; }

        /// <summary>Optional. The last four digits of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardLastFour")]
        public virtual string CardLastFour { get; set; }

        /// <summary>Optional. The currency code in ISO-4217 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Optional. Information about the payment gateway's response to the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayInfo")]
        public virtual GoogleCloudRecaptchaenterpriseV1TransactionDataGatewayInfo GatewayInfo { get; set; }

        /// <summary>Optional. Items purchased in this transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1TransactionDataItem> Items { get; set; }

        /// <summary>Optional. Information about the user or users fulfilling the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchants")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1TransactionDataUser> Merchants { get; set; }

        /// <summary>
        /// Optional. The payment method for the transaction. The allowed values are: * credit-card * debit-card *
        /// gift-card * processor-{name} (If a third-party is used, for example, processor-paypal) * custom-{name} (If
        /// an alternative method is used, for example, custom-crypto)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentMethod")]
        public virtual string PaymentMethod { get; set; }

        /// <summary>Optional. Destination address if this transaction involves shipping a physical item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingAddress")]
        public virtual GoogleCloudRecaptchaenterpriseV1TransactionDataAddress ShippingAddress { get; set; }

        /// <summary>Optional. The value of shipping in the specified currency. 0 for free or no shipping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shippingValue")]
        public virtual System.Nullable<double> ShippingValue { get; set; }

        /// <summary>
        /// Unique identifier for the transaction. This custom identifier can be used to reference this transaction in
        /// the future, for example, labeling a refund or chargeback event. Two attempts at the same transaction should
        /// use the same transaction id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionId")]
        public virtual string TransactionId { get; set; }

        /// <summary>Optional. Information about the user paying/initiating the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual GoogleCloudRecaptchaenterpriseV1TransactionDataUser User { get; set; }

        /// <summary>Optional. The decimal value of the transaction in the specified currency.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured address format for billing and shipping addresses.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TransactionDataAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The first lines of the address. The first line generally contains the street name and number, and
        /// further lines may include information such as an apartment number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual System.Collections.Generic.IList<string> Address { get; set; }

        /// <summary>Optional. The state, province, or otherwise administrative area of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>Optional. The town/city of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; }

        /// <summary>Optional. The postal or ZIP code of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; }

        /// <summary>Optional. The recipient name, potentially including information such as "care of".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recipient")]
        public virtual string Recipient { get; set; }

        /// <summary>Optional. The CLDR country/region of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about the transaction from the gateway.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TransactionDataGatewayInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. AVS response code from the gateway (available only when reCAPTCHA Enterprise is called after
        /// authorization).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avsResponseCode")]
        public virtual string AvsResponseCode { get; set; }

        /// <summary>
        /// Optional. CVV response code from the gateway (available only when reCAPTCHA Enterprise is called after
        /// authorization).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvvResponseCode")]
        public virtual string CvvResponseCode { get; set; }

        /// <summary>Optional. Gateway response code describing the state of the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayResponseCode")]
        public virtual string GatewayResponseCode { get; set; }

        /// <summary>Optional. Name of the gateway service (for example, stripe, square, paypal).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Line items being purchased in this transaction.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TransactionDataItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. When a merchant is specified, its corresponding account_id. Necessary to populate
        /// marketplace-style transactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merchantAccountId")]
        public virtual string MerchantAccountId { get; set; }

        /// <summary>Optional. The full name of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The quantity of this item that is being purchased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>
        /// Optional. The value per item that the user is paying, in the transaction currency, after discounts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about a user's account involved in the transaction.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TransactionDataUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Unique account identifier for this user. If using account defender, this should match the
        /// hashed_account_id field. Otherwise, a unique and persistent identifier for this account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Optional. The epoch milliseconds of the user's account creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationMs")]
        public virtual System.Nullable<long> CreationMs { get; set; }

        /// <summary>Optional. The email address of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// Optional. Whether the email has been verified to be accessible by the user (OTP or similar).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailVerified")]
        public virtual System.Nullable<bool> EmailVerified { get; set; }

        /// <summary>Optional. The phone number of the user, with country code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// Optional. Whether the phone number has been verified to be accessible by the user (OTP or similar).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneVerified")]
        public virtual System.Nullable<bool> PhoneVerified { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an event in the lifecycle of a payment transaction.</summary>
    public class GoogleCloudRecaptchaenterpriseV1TransactionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// Optional. Timestamp when this transaction event occurred; otherwise assumed to be the time of the API call.
        /// </summary>
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

        /// <summary>Optional. The type of this transaction event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>
        /// Optional. The reason or standardized code that corresponds with this transaction event, if one exists. For
        /// example, a CHARGEBACK event with code 6005.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// Optional. The value that corresponds with this transaction event, if one exists. For example, a refund event
        /// where $5.00 was refunded. Currency is obtained from the original transaction data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An identifier associated with a user.</summary>
    public class GoogleCloudRecaptchaenterpriseV1UserId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. An email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Optional. A phone number. Should use the E.164 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// Optional. A unique username, if different from all the other identifiers and `account_id` that are provided.
        /// Can be a unique login handle or display name for a user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User information associated with a request protected by reCAPTCHA Enterprise.</summary>
    public class GoogleCloudRecaptchaenterpriseV1UserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. For logged-in requests or login/registration requests, the unique account identifier associated
        /// with this user. You can use the username if it is stable (meaning it is the same for every request
        /// associated with the same user), or any stable user ID of your choice. Leave blank for non logged-in actions
        /// or guest checkout.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        private string _createAccountTimeRaw;

        private object _createAccountTime;

        /// <summary>
        /// Optional. Creation time for this account associated with this user. Leave blank for non logged-in actions,
        /// guest checkout, or when there is no account associated with the current user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createAccountTime")]
        public virtual string CreateAccountTimeRaw
        {
            get => _createAccountTimeRaw;
            set
            {
                _createAccountTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createAccountTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateAccountTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateAccountTimeDateTimeOffset instead.")]
        public virtual object CreateAccountTime
        {
            get => _createAccountTime;
            set
            {
                _createAccountTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createAccountTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateAccountTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateAccountTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateAccountTimeRaw);
            set => CreateAccountTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Identifiers associated with this user or request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userIds")]
        public virtual System.Collections.Generic.IList<GoogleCloudRecaptchaenterpriseV1UserId> UserIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to keys that can be used for WAF (Web Application Firewall).</summary>
    public class GoogleCloudRecaptchaenterpriseV1WafSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The WAF feature for which this key is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wafFeature")]
        public virtual string WafFeature { get; set; }

        /// <summary>Required. The WAF service that uses this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wafService")]
        public virtual string WafService { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings specific to keys that can be used by websites.</summary>
    public class GoogleCloudRecaptchaenterpriseV1WebKeySettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If set to true, it means allowed_domains are not enforced.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAllDomains")]
        public virtual System.Nullable<bool> AllowAllDomains { get; set; }

        /// <summary>
        /// Optional. If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported
        /// only for the SCORE integration type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowAmpTraffic")]
        public virtual System.Nullable<bool> AllowAmpTraffic { get; set; }

        /// <summary>
        /// Optional. Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are
        /// automatically allowed. A valid domain requires a host and must not include any path, port, query or
        /// fragment. Examples: 'example.com' or 'subdomain.example.com'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedDomains")]
        public virtual System.Collections.Generic.IList<string> AllowedDomains { get; set; }

        /// <summary>
        /// Optional. Settings for the frequency and difficulty at which this key triggers captcha challenges. This
        /// should only be specified for IntegrationTypes CHECKBOX and INVISIBLE and SCORE_AND_CHALLENGE.
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
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
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
