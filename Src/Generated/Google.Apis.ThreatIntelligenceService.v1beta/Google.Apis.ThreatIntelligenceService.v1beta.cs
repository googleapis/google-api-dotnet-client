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

namespace Google.Apis.ThreatIntelligenceService.v1beta
{
    /// <summary>The ThreatIntelligenceService Service.</summary>
    public class ThreatIntelligenceServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ThreatIntelligenceServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ThreatIntelligenceServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://threatintelligence.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://threatintelligence.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "threatintelligence";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Threat Intelligence API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Threat Intelligence API.</summary>
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

    /// <summary>A base abstract class for ThreatIntelligenceService requests.</summary>
    public abstract class ThreatIntelligenceServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ThreatIntelligenceServiceBaseServiceRequest instance.</summary>
        protected ThreatIntelligenceServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes ThreatIntelligenceService parameter list.</summary>
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
            Alerts = new AlertsResource(service);
            Configurations = new ConfigurationsResource(service);
            Findings = new FindingsResource(service);
        }

        /// <summary>Gets the Alerts resource.</summary>
        public virtual AlertsResource Alerts { get; }

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
                Documents = new DocumentsResource(service);
            }

            /// <summary>Gets the Documents resource.</summary>
            public virtual DocumentsResource Documents { get; }

            /// <summary>The "documents" collection of methods.</summary>
            public class DocumentsResource
            {
                private const string Resource = "documents";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DocumentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a specific document associated with an alert.</summary>
                /// <param name="name">
                /// Required. Name of the alert document to get. Format:
                /// projects/{project}/alerts/{alert}/documents/{document}
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a specific document associated with an alert.</summary>
                public class GetRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.AlertDocument>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the alert document to get. Format:
                    /// projects/{project}/alerts/{alert}/documents/{document}
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

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
                            Pattern = @"^projects/[^/]+/alerts/[^/]+/documents/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Marks an alert as benign - BENIGN.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as a benign. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual BenignRequest Benign(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsBenignRequest body, string name)
            {
                return new BenignRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as benign - BENIGN.</summary>
            public class BenignRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new Benign request.</summary>
                public BenignRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsBenignRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as a benign. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsBenignRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "benign";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:benign";

                /// <summary>Initializes Benign parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Marks an alert as a duplicate of another alert. - DUPLICATE.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as a duplicate. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual DuplicateRequest Duplicate(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsDuplicateRequest body, string name)
            {
                return new DuplicateRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as a duplicate of another alert. - DUPLICATE.</summary>
            public class DuplicateRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new Duplicate request.</summary>
                public DuplicateRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsDuplicateRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as a duplicate. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsDuplicateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "duplicate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:duplicate";

                /// <summary>Initializes Duplicate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// EnumerateAlertFacets returns the facets and the number of alerts that meet the filter criteria and have
            /// that value for each facet.
            /// </summary>
            /// <param name="parent">Required. Parent of the alerts.</param>
            public virtual EnumerateFacetsRequest EnumerateFacets(string parent)
            {
                return new EnumerateFacetsRequest(this.service, parent);
            }

            /// <summary>
            /// EnumerateAlertFacets returns the facets and the number of alerts that meet the filter criteria and have
            /// that value for each facet.
            /// </summary>
            public class EnumerateFacetsRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.EnumerateAlertFacetsResponse>
            {
                /// <summary>Constructs a new EnumerateFacets request.</summary>
                public EnumerateFacetsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Parent of the alerts.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Filter on what alerts will be enumerated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "enumerateFacets";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/alerts:enumerateFacets";

                /// <summary>Initializes EnumerateFacets parameter list.</summary>
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

            /// <summary>Marks an alert as escalated - ESCALATED.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as escalated. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual EscalateRequest Escalate(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsEscalatedRequest body, string name)
            {
                return new EscalateRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as escalated - ESCALATED.</summary>
            public class EscalateRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new Escalate request.</summary>
                public EscalateRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsEscalatedRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as escalated. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsEscalatedRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "escalate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:escalate";

                /// <summary>Initializes Escalate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Marks an alert as a false positive - FALSE_POSITIVE.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as a false positive. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual FalsePositiveRequest FalsePositive(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsFalsePositiveRequest body, string name)
            {
                return new FalsePositiveRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as a false positive - FALSE_POSITIVE.</summary>
            public class FalsePositiveRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new FalsePositive request.</summary>
                public FalsePositiveRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsFalsePositiveRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as a false positive. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsFalsePositiveRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "falsePositive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:falsePositive";

                /// <summary>Initializes FalsePositive parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Get an alert by name.</summary>
            /// <param name="name">Required. Name of the alert to get. Format: projects/{project}/alerts/{alert}</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get an alert by name.</summary>
            public class GetRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the alert to get. Format: projects/{project}/alerts/{alert}</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Get a list of alerts that meet the filter criteria.</summary>
            /// <param name="parent">Required. Parent of the alerts. Format: projects/{project}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Get a list of alerts that meet the filter criteria.</summary>
            public class ListRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.ListAlertsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Parent of the alerts. Format: projects/{project}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Filter criteria.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Order by criteria in the csv format: "field1,field2 desc" or "field1,field2" or "field1
                /// asc, field2".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Optional. Page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. Page token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/alerts";

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

            /// <summary>Marks an alert as not actionable - NOT_ACTIONABLE.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as a not actionable. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual NotActionableRequest NotActionable(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsNotActionableRequest body, string name)
            {
                return new NotActionableRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as not actionable - NOT_ACTIONABLE.</summary>
            public class NotActionableRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new NotActionable request.</summary>
                public NotActionableRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsNotActionableRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as a not actionable. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsNotActionableRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "notActionable";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:notActionable";

                /// <summary>Initializes NotActionable parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Marks an alert as read - READ.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as read. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual ReadRequest Read(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsReadRequest body, string name)
            {
                return new ReadRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as read - READ.</summary>
            public class ReadRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new Read request.</summary>
                public ReadRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsReadRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as read. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsReadRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "read";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:read";

                /// <summary>Initializes Read parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Return the status of a URI submitted to Google WebRisk.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Name of alert to refresh status from WebRisk</param>
            public virtual RefreshUriStatusRequest RefreshUriStatus(Google.Apis.ThreatIntelligenceService.v1beta.Data.RefreshAlertUriStatusRequest body, string name)
            {
                return new RefreshUriStatusRequest(this.service, body, name);
            }

            /// <summary>Return the status of a URI submitted to Google WebRisk.</summary>
            public class RefreshUriStatusRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.RefreshAlertUriStatusResponse>
            {
                /// <summary>Constructs a new RefreshUriStatus request.</summary>
                public RefreshUriStatusRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.RefreshAlertUriStatusRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Name of alert to refresh status from WebRisk</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.RefreshAlertUriStatusRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "refreshUriStatus";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:refreshUriStatus";

                /// <summary>Initializes RefreshUriStatus parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Report the URI associated with an alert to Google WebRisk.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Name of alert to submit to WebRisk.</param>
            public virtual ReportAlertUriRequest ReportAlertUri(Google.Apis.ThreatIntelligenceService.v1beta.Data.ReportAlertUriRequest body, string name)
            {
                return new ReportAlertUriRequest(this.service, body, name);
            }

            /// <summary>Report the URI associated with an alert to Google WebRisk.</summary>
            public class ReportAlertUriRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.ReportAlertUriResponse>
            {
                /// <summary>Constructs a new ReportAlertUri request.</summary>
                public ReportAlertUriRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.ReportAlertUriRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Name of alert to submit to WebRisk.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.ReportAlertUriRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reportAlertUri";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:reportAlertUri";

                /// <summary>Initializes ReportAlertUri parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Marks an alert to closed state - RESOLVED.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as resolved. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual ResolveRequest Resolve(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsResolvedRequest body, string name)
            {
                return new ResolveRequest(this.service, body, name);
            }

            /// <summary>Marks an alert to closed state - RESOLVED.</summary>
            public class ResolveRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new Resolve request.</summary>
                public ResolveRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsResolvedRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as resolved. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsResolvedRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "resolve";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:resolve";

                /// <summary>Initializes Resolve parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Marks an alert as tracked externally - TRACKED_EXTERNALLY.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as tracked externally. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual TrackExternallyRequest TrackExternally(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsTrackedExternallyRequest body, string name)
            {
                return new TrackExternallyRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as tracked externally - TRACKED_EXTERNALLY.</summary>
            public class TrackExternallyRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new TrackExternally request.</summary>
                public TrackExternallyRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsTrackedExternallyRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as tracked externally. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsTrackedExternallyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "trackExternally";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:trackExternally";

                /// <summary>Initializes TrackExternally parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }

            /// <summary>Marks an alert as triaged - TRIAGED.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of the alert to mark as a triaged. Format: projects/{project}/alerts/{alert}
            /// </param>
            public virtual TriageRequest Triage(Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsTriagedRequest body, string name)
            {
                return new TriageRequest(this.service, body, name);
            }

            /// <summary>Marks an alert as triaged - TRIAGED.</summary>
            public class TriageRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Alert>
            {
                /// <summary>Constructs a new Triage request.</summary>
                public TriageRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsTriagedRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the alert to mark as a triaged. Format: projects/{project}/alerts/{alert}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.MarkAlertAsTriagedRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "triage";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:triage";

                /// <summary>Initializes Triage parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/alerts/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Configurations resource.</summary>
        public virtual ConfigurationsResource Configurations { get; }

        /// <summary>The "configurations" collection of methods.</summary>
        public class ConfigurationsResource
        {
            private const string Resource = "configurations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ConfigurationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Revisions = new RevisionsResource(service);
            }

            /// <summary>Gets the Revisions resource.</summary>
            public virtual RevisionsResource Revisions { get; }

            /// <summary>The "revisions" collection of methods.</summary>
            public class RevisionsResource
            {
                private const string Resource = "revisions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RevisionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>List configuration revisions that meet the filter criteria.</summary>
                /// <param name="parent">Required. The name of the Configuration to retrieve Revisions for</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List configuration revisions that meet the filter criteria.</summary>
                public class ListRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.ListConfigurationRevisionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the Configuration to retrieve Revisions for</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional. An AIP-160 filter string</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Optional. Specify ordering of response</summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Optional. Page Size</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A page token provided by the API</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/revisions";

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
                            Pattern = @"^projects/[^/]+/configurations/[^/]+$",
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
            }

            /// <summary>Get a configuration by name.</summary>
            /// <param name="name">
            /// Required. Name of the configuration to get. Format: vaults/{vault}/configurations/{configuration}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get a configuration by name.</summary>
            public class GetRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Configuration>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the configuration to get. Format: vaults/{vault}/configurations/{configuration}
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^projects/[^/]+/configurations/[^/]+$",
                    });
                }
            }

            /// <summary>Get a list of configurations that meet the filter criteria.</summary>
            /// <param name="parent">Required. Parent of the configuration. Format: vaults/{vault}</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Get a list of configurations that meet the filter criteria.</summary>
            public class ListRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.ListConfigurationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Parent of the configuration. Format: vaults/{vault}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Filter criteria.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Order by criteria in the csv format: "field1,field2 desc" or "field1,field2" or "field1
                /// asc, field2".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Optional. Page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. Page token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/configurations";

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

            /// <summary>Creates or updates a configuration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Parent of the configuration.</param>
            public virtual UpsertRequest Upsert(Google.Apis.ThreatIntelligenceService.v1beta.Data.Configuration body, string parent)
            {
                return new UpsertRequest(this.service, body, parent);
            }

            /// <summary>Creates or updates a configuration.</summary>
            public class UpsertRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.UpsertConfigurationResponse>
            {
                /// <summary>Constructs a new Upsert request.</summary>
                public UpsertRequest(Google.Apis.Services.IClientService service, Google.Apis.ThreatIntelligenceService.v1beta.Data.Configuration body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Parent of the configuration.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                private object _publishTime;

                /// <summary>
                /// String representation of <see cref="PublishTimeDateTimeOffset"/>, formatted for inclusion in the
                /// HTTP request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("publishTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PublishTimeRaw { get; private set; }

                /// <summary><seealso cref="object"/> representation of <see cref="PublishTimeRaw"/>.</summary>
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PublishTimeDateTimeOffset instead.")]
                public virtual object PublishTime
                {
                    get => _publishTime;
                    set
                    {
                        PublishTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                        _publishTime = value;
                    }
                }

                public virtual System.DateTimeOffset? PublishTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PublishTimeRaw);
                    set
                    {
                        PublishTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                        _publishTime = value;
                    }
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.ThreatIntelligenceService.v1beta.Data.Configuration Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upsert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/configurations:upsert";

                /// <summary>Initializes Upsert parameter list.</summary>
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
                    RequestParameters.Add("publishTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "publishTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Findings resource.</summary>
        public virtual FindingsResource Findings { get; }

        /// <summary>The "findings" collection of methods.</summary>
        public class FindingsResource
        {
            private const string Resource = "findings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get a finding by name.</summary>
            /// <param name="name">Required. Name of the finding to get.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Get a finding by name.</summary>
            public class GetRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.Finding>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the finding to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
                        Pattern = @"^projects/[^/]+/findings/[^/]+$",
                    });
                }
            }

            /// <summary>Get a list of findings that meet the filter criteria.</summary>
            /// <param name="parent">Required. Parent of the findings.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Get a list of findings that meet the filter criteria.</summary>
            public class ListRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.ListFindingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Parent of the findings.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Filter criteria.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Order by criteria in the csv format: "field1,field2 desc" or "field1,field2" or "field1
                /// asc, field2".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Optional. Page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. Page token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/findings";

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
            /// SearchFindings is a more powerful version of ListFindings that supports complex queries like "findings
            /// for issues" using functions such as `has_issue` and `has_asset` in the query string. Example to search
            /// for findings for a specific issue: `has_issue("name=\"vaults/vault-12345/issues/issue-12345\"")`)
            /// </summary>
            /// <param name="parent">Required. Parent of the findings. Format: vaults/{vault}</param>
            public virtual SearchRequest Search(string parent)
            {
                return new SearchRequest(this.service, parent);
            }

            /// <summary>
            /// SearchFindings is a more powerful version of ListFindings that supports complex queries like "findings
            /// for issues" using functions such as `has_issue` and `has_asset` in the query string. Example to search
            /// for findings for a specific issue: `has_issue("name=\"vaults/vault-12345/issues/issue-12345\"")`)
            /// </summary>
            public class SearchRequest : ThreatIntelligenceServiceBaseServiceRequest<Google.Apis.ThreatIntelligenceService.v1beta.Data.SearchFindingsResponse>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Parent of the findings. Format: vaults/{vault}</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Order by criteria in the csv format: "field1,field2 desc" or "field1,field2" or "field1
                /// asc, field2".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Optional. Page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. Page token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Optional. Query on what findings will be returned. This supports the same filter criteria as
                /// FindingService.ListFindings as well as the following relationship queries `has_issue` and
                /// `has_asset`. Examples: - has_issue("name=\"vaults/vault-12345/issues/issue-12345\"") -
                /// has_asset("name=\"vaults/vault-12345/assets/asset-12345\"")
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/findings:search";

                /// <summary>Initializes Search parameter list.</summary>
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
        }
    }
}
namespace Google.Apis.ThreatIntelligenceService.v1beta.Data
{
    /// <summary>The software that is affected by the vulnerability.</summary>
    public class AffectedSoftware : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The product of the software.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>Optional. The vendor of the software.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendor")]
        public virtual string Vendor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Stateful object representing a group of Findings. Key feature to an Alert is that it expresses the user's intent
    /// towards the findings of that group, even those that haven't occurred yet.
    /// </summary>
    public class Alert : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. AI summary of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiSummary")]
        public virtual string AiSummary { get; set; }

        /// <summary>Output only. Assets that are impacted by this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assets")]
        public virtual System.Collections.Generic.IList<string> Assets { get; set; }

        /// <summary>Output only. Audit information for the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audit")]
        public virtual Audit Audit { get; set; }

        /// <summary>
        /// Output only. The resource names of the Configurations bound to this alert. Format:
        /// projects/{project}/configurations/{configuration}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurations")]
        public virtual System.Collections.Generic.IList<string> Configurations { get; set; }

        /// <summary>Output only. Details object for the alert, not all alerts will have a details object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual AlertDetail Detail { get; set; }

        /// <summary>Output only. A short title for the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. alert name of the alert this alert is a duplicate of. Format: projects/{project}/alerts/{alert}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateOf")]
        public virtual string DuplicateOf { get; set; }

        /// <summary>
        /// Output only. alert names of the alerts that are duplicates of this alert. Format:
        /// projects/{project}/alerts/{alert}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicatedBy")]
        public virtual System.Collections.Generic.IList<string> DuplicatedBy { get; set; }

        /// <summary>
        /// Optional. If included when updating an alert, this should be set to the current etag of the alert. If the
        /// etags do not match, the update will be rejected and an ABORTED error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Output only. External ID for the alert. This is used internally to provide protection against out of order
        /// updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalId")]
        public virtual string ExternalId { get; set; }

        /// <summary>Output only. Findings that are covered by this alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findings")]
        public virtual System.Collections.Generic.IList<string> Findings { get; set; }

        /// <summary>
        /// Identifier. Server generated name for the alert. format is projects/{project}/alerts/{alert}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. High-Precision Priority Analysis for the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityAnalysis")]
        public virtual PriorityAnalysis PriorityAnalysis { get; set; }

        /// <summary>Output only. High-Precision Relevance Analysis verdict for the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevanceAnalysis")]
        public virtual RelevanceAnalysis RelevanceAnalysis { get; set; }

        /// <summary>Output only. High-Precision Severity Analysis for the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityAnalysis")]
        public virtual SeverityAnalysis SeverityAnalysis { get; set; }

        /// <summary>Output only. State of the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }
    }

    /// <summary>Container for different types of alert details.</summary>
    public class AlertDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data Leak alert detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLeak")]
        public virtual DataLeakAlertDetail DataLeak { get; set; }

        /// <summary>
        /// Output only. Name of the detail type. Will be set by the server during creation to the name of the field
        /// that is set in the detail union.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailType")]
        public virtual string DetailType { get; set; }

        /// <summary>Initial Access Broker alert detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialAccessBroker")]
        public virtual InitialAccessBrokerAlertDetail InitialAccessBroker { get; set; }

        /// <summary>Insider Threat alert detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insiderThreat")]
        public virtual InsiderThreatAlertDetail InsiderThreat { get; set; }

        /// <summary>Domain Monitoring alert detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspiciousDomain")]
        public virtual SuspiciousDomainAlertDetail SuspiciousDomain { get; set; }

        /// <summary>Technology Watchlist alert detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetTechnology")]
        public virtual TargetTechnologyAlertDetail TargetTechnology { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A document that is associated with an alert.</summary>
    public class AlertDocument : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. AI summary of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiSummary")]
        public virtual string AiSummary { get; set; }

        /// <summary>Output only. The author of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual string Author { get; set; }

        private string _collectionTimeRaw;

        private object _collectionTime;

        /// <summary>Output only. Time when the origin source collected the intel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionTime")]
        public virtual string CollectionTimeRaw
        {
            get => _collectionTimeRaw;
            set
            {
                _collectionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _collectionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CollectionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CollectionTimeDateTimeOffset instead.")]
        public virtual object CollectionTime
        {
            get => _collectionTime;
            set
            {
                _collectionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _collectionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CollectionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CollectionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CollectionTimeRaw);
            set => CollectionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The content of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the document was created.</summary>
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

        private string _ingestTimeRaw;

        private object _ingestTime;

        /// <summary>Output only. Time when GTI received the intel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingestTime")]
        public virtual string IngestTimeRaw
        {
            get => _ingestTimeRaw;
            set
            {
                _ingestTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _ingestTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="IngestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use IngestTimeDateTimeOffset instead.")]
        public virtual object IngestTime
        {
            get => _ingestTime;
            set
            {
                _ingestTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _ingestTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="IngestTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? IngestTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(IngestTimeRaw);
            set => IngestTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. The language code of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Identifier. Server generated name for the alert document. format is
        /// projects/{project}/alerts/{alert}/documents/{document}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Source of the intel item, e.g. DarkMarket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        private string _sourceUpdateTimeRaw;

        private object _sourceUpdateTime;

        /// <summary>Output only. Time when the intel was last updated by the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUpdateTime")]
        public virtual string SourceUpdateTimeRaw
        {
            get => _sourceUpdateTimeRaw;
            set
            {
                _sourceUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _sourceUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SourceUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SourceUpdateTimeDateTimeOffset instead.")]
        public virtual object SourceUpdateTime
        {
            get => _sourceUpdateTime;
            set
            {
                _sourceUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _sourceUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SourceUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SourceUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SourceUpdateTimeRaw);
            set => SourceUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. URI of the intel item from the source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual string SourceUri { get; set; }

        /// <summary>Output only. The title of the document, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Output only. The translation of the document, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translation")]
        public virtual AlertDocumentTranslation Translation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The translation of an alert document.</summary>
    public class AlertDocumentTranslation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The translated content of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedContent")]
        public virtual string TranslatedContent { get; set; }

        /// <summary>Output only. The translated title of the document.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedTitle")]
        public virtual string TranslatedTitle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Customer defined Configuration for asset discovery.</summary>
    public class AssetDiscoveryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _lastScanCompleteTimeRaw;

        private object _lastScanCompleteTime;

        /// <summary>
        /// Output only. Timestamp of the last scan completed. This field is set by the system and cannot be modified by
        /// the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastScanCompleteTime")]
        public virtual string LastScanCompleteTimeRaw
        {
            get => _lastScanCompleteTimeRaw;
            set
            {
                _lastScanCompleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastScanCompleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastScanCompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastScanCompleteTimeDateTimeOffset instead.")]
        public virtual object LastScanCompleteTime
        {
            get => _lastScanCompleteTime;
            set
            {
                _lastScanCompleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastScanCompleteTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastScanCompleteTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastScanCompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastScanCompleteTimeRaw);
            set => LastScanCompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _lastScanStartTimeRaw;

        private object _lastScanStartTime;

        /// <summary>
        /// Output only. Timestamp of the last scan started - used for scheduling the next scan. This field is set by
        /// the system and cannot be modified by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastScanStartTime")]
        public virtual string LastScanStartTimeRaw
        {
            get => _lastScanStartTimeRaw;
            set
            {
                _lastScanStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastScanStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastScanStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastScanStartTimeDateTimeOffset instead.")]
        public virtual object LastScanStartTime
        {
            get => _lastScanStartTime;
            set
            {
                _lastScanStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastScanStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastScanStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastScanStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastScanStartTimeRaw);
            set => LastScanStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. Frequency at which the scheduled discovery scan should be run. If not specified, the default
        /// frequency is DAILY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scanFrequency")]
        public virtual string ScanFrequency { get; set; }

        /// <summary>Optional. Seed assets that are out of scope for the scheduled discovery scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeExclusionAssets")]
        public virtual System.Collections.Generic.IList<AssetDiscoverySeed> ScopeExclusionAssets { get; set; }

        /// <summary>
        /// Required. Seed assets for the scheduled discovery scan. At least one seed asset is required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seedAssets")]
        public virtual System.Collections.Generic.IList<AssetDiscoverySeed> SeedAssets { get; set; }

        /// <summary>
        /// Required. Workflow to be used for the scheduled discovery scan. If not specified, the default workflow is
        /// EXTERNAL_DISCOVERY.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflow")]
        public virtual string Workflow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Seed assets for asset discovery.</summary>
    public class AssetDiscoverySeed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Type of the seed asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seedType")]
        public virtual string SeedType { get; set; }

        /// <summary>
        /// Required. Value for the seed asset. Could be an IP address, network service, email addresses, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seedValue")]
        public virtual string SeedValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an association with a vulnerability.</summary>
    public class Association : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The ID of the association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Required. The type of the association.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Tracks basic CRUD facts.</summary>
    public class Audit : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time of creation.</summary>
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

        /// <summary>Output only. Agent that created or updated the record, could be a UserId or a JobId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual string Creator { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time of creation or last update.</summary>
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

        /// <summary>Output only. Agent that last updated the record, could be a UserId or a JobId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updater")]
        public virtual string Updater { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sample compromised credential detail.</summary>
    public class CompromisedCredentialsFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Reference to the author this detail was extracted from. This is deprecated and will be removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual string Author { get; set; }

        /// <summary>Optional. Claimed site the credential is intended for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentialService")]
        public virtual string CredentialService { get; set; }

        /// <summary>Optional. Reference to the dark web document. This is deprecated and will be removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("darkWebDoc")]
        public virtual string DarkWebDoc { get; set; }

        /// <summary>
        /// Optional. This will contain a link to the external reference for this credential. If set, this is a link
        /// back to the DTM product to allow customers to get additional context about this finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalReferenceUri")]
        public virtual string ExternalReferenceUri { get; set; }

        /// <summary>
        /// Optional. If the source of the credential was from a file dump this will contain the name of the file the
        /// credential was found in. This can be used by customers for context on where the credential was found and to
        /// try to find other references to the file in the wild.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileDump")]
        public virtual string FileDump { get; set; }

        /// <summary>
        /// Optional. A list of hashes of the file dump. These will be prefixed with the algorithm. Example: "sha256:"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileDumpHashes")]
        public virtual System.Collections.Generic.IList<string> FileDumpHashes { get; set; }

        /// <summary>
        /// Optional. If file_dump is set this will contain the size of the dump file in bytes. File dumps can be very
        /// large.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileDumpSizeBytes")]
        public virtual System.Nullable<long> FileDumpSizeBytes { get; set; }

        /// <summary>
        /// Optional. Reference to the forum this detail was extracted from. This is deprecated and will be removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forum")]
        public virtual string Forum { get; set; }

        /// <summary>Optional. This will indicate the malware family that leaked this credential, if known.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("malwareFamily")]
        public virtual string MalwareFamily { get; set; }

        private string _postedTimeRaw;

        private object _postedTime;

        /// <summary>
        /// Optional. This indicates our best guess as to when the credential was leaked to the particular venue that
        /// triggered this finding. This is not necessarily the time the credential was actually leaked and it may not
        /// always be be accurate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postedTime")]
        public virtual string PostedTimeRaw
        {
            get => _postedTimeRaw;
            set
            {
                _postedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _postedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="PostedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use PostedTimeDateTimeOffset instead.")]
        public virtual object PostedTime
        {
            get => _postedTime;
            set
            {
                _postedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _postedTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="PostedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? PostedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(PostedTimeRaw);
            set => PostedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. If the source of a credential is publicly addressable this will contain a uri to the where the
        /// credential was found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceUri")]
        public virtual string SourceUri { get; set; }

        /// <summary>
        /// Required. This field will always be set and will be used to identify the user named in the credential leak.
        /// In cases where customers are authorized to see the actual user key this will be set to the actual user key.
        /// In cases where the customer is not authorized to see the actual user key this will be set to a hash of the
        /// user key. The hashed value is an intentionally opaque value that is not intended to be used for any other
        /// purpose than to uniquely identify the user in the context of this specific customer, service domain, and
        /// user name. Example: "user@example.com" or "redacted:".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userKey")]
        public virtual string UserKey { get; set; }

        /// <summary>
        /// Optional. Claimed evidence of the password/secret. This will always be hashed. In the event where the
        /// plaintext password is known it will be set to "redacted:" where the same hash will be presented when the
        /// same password is found for the same organization for the same service. Redaction is done by hashing the
        /// password with a salt that is unique to the customer organization and service. In the event where the
        /// plaintext password is not known it will be set to ":" where the algorithm is the hash algorithm used and the
        /// hash is the hash of the password using that algorithm. In the event we don't know the exact algorithm used
        /// we will set it to "hashed:".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSecretEvidence")]
        public virtual string UserSecretEvidence { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A configuration represents a behavior an engine should follow when producing new findings.</summary>
    public class Configuration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Audit information for the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audit")]
        public virtual Audit Audit { get; set; }

        /// <summary>Optional. A description of the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. Domain specific details for the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual ConfigurationDetail Detail { get; set; }

        /// <summary>Output only. Human readable name for the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. Server generated name for the configuration. format is
        /// vaults/{vault}/configurations/{configuration}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Name of the service that provides the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Optional. State of the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. A user-manipulatable version. Does not adhere to a specific format</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Wrapper class that contains the union struct for all the various configuration detail specific classes.
    /// </summary>
    public class ConfigurationDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Asset Discovery detail config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetDiscovery")]
        public virtual AssetDiscoveryConfig AssetDiscovery { get; set; }

        /// <summary>Customer Profile detail config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerProfile")]
        public virtual CustomerProfileConfig CustomerProfile { get; set; }

        /// <summary>
        /// Output only. Name of the detail type. Will be set by the server during creation to the name of the field
        /// that is set in the detail union.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailType")]
        public virtual string DetailType { get; set; }

        /// <summary>Domain Monitoring detail config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainMonitoring")]
        public virtual DomainMonitoringConfig DomainMonitoring { get; set; }

        /// <summary>Initial Access Broker (IAB) detail config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialAccessBroker")]
        public virtual InitialAccessBrokerConfig InitialAccessBroker { get; set; }

        /// <summary>Technology Watchlist detail config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyWatchlist")]
        public virtual TechnologyWatchListConfig TechnologyWatchlist { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ConfigurationRevision is a snapshot of a Configuration at a point in time. It is immutable.</summary>
    public class ConfigurationRevision : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The time the Revision was created</summary>
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
        /// Identifier. The name of the ConfigurationRevision Format: vaults//configurations//revisions/ OR
        /// projects//configurations//revisions/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The snapshot of the configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual Configuration Snapshot { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Citation information for the customer profile.</summary>
    public class CustomerProfileCitation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The citation id for the citation. Should be unique within the profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationId")]
        public virtual string CitationId { get; set; }

        /// <summary>Required. The name of the document the citation is from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual string Document { get; set; }

        private string _retrievalTimeRaw;

        private object _retrievalTime;

        /// <summary>The time the citation was retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalTime")]
        public virtual string RetrievalTimeRaw
        {
            get => _retrievalTimeRaw;
            set
            {
                _retrievalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _retrievalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RetrievalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RetrievalTimeDateTimeOffset instead.")]
        public virtual object RetrievalTime
        {
            get => _retrievalTime;
            set
            {
                _retrievalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _retrievalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RetrievalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RetrievalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RetrievalTimeRaw);
            set => RetrievalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. The source of the citation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>Optional. The url of the citation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A string with citation ids.</summary>
    public class CustomerProfileCitedString : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The citation ids for the string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>Required. The value of the string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Company information for the customer profile.</summary>
    public class CustomerProfileCompany : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The citation ids for the company.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>Required. The name of the company.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("company")]
        public virtual string Company { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomerProfileConfig is the configuration for the customer profile.</summary>
    public class CustomerProfileConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Citations for the organization profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citations")]
        public virtual System.Collections.Generic.IList<CustomerProfileCitation> Citations { get; set; }

        /// <summary>Optional. Contact information for the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactInfo")]
        public virtual System.Collections.Generic.IList<CustomerProfileContactInfo> ContactInfo { get; set; }

        /// <summary>Optional. Executives of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executives")]
        public virtual System.Collections.Generic.IList<CustomerProfilePerson> Executives { get; set; }

        /// <summary>Optional. The industries the organization is involved in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("industries")]
        public virtual System.Collections.Generic.IList<CustomerProfileIndustry> Industries { get; set; }

        /// <summary>Optional. Locations the organization is present or conducts business in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<CustomerProfileLocation> Locations { get; set; }

        /// <summary>Required. The name of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("org")]
        public virtual string Org { get; set; }

        /// <summary>Optional. A summary of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgSummary")]
        public virtual string OrgSummary { get; set; }

        /// <summary>Optional. The parent companies of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentCompanies")]
        public virtual System.Collections.Generic.IList<CustomerProfileCompany> ParentCompanies { get; set; }

        /// <summary>Optional. Product information for the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("products")]
        public virtual System.Collections.Generic.IList<CustomerProfileProduct> Products { get; set; }

        /// <summary>Optional. Security considerations for the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityConsiderations")]
        public virtual CustomerProfileSecurityConsiderations SecurityConsiderations { get; set; }

        /// <summary>Optional. A summarized version of the customer profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual CustomerProfileSummary Summary { get; set; }

        /// <summary>Optional. Technology presence of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologyPresence")]
        public virtual string TechnologyPresence { get; set; }

        /// <summary>Optional. Web presence of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPresences")]
        public virtual System.Collections.Generic.IList<CustomerProfileWebPresence> WebPresences { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contact information for the customer profile.</summary>
    public class CustomerProfileContactInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Optional. The citation ids for the contact information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>The email address of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Optional. The name of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The other contact information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("other")]
        public virtual string Other { get; set; }

        /// <summary>The phone number of the contact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phone")]
        public virtual string Phone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Industry information for the customer profile.</summary>
    public class CustomerProfileIndustry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The citation ids for the industry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>Required. The name of the industry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("industry")]
        public virtual string Industry { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location information for the customer profile.</summary>
    public class CustomerProfileLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The address of the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>Required. The brand of the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>Optional. The citation ids for the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>Optional. The type of location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facilityType")]
        public virtual string FacilityType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Person information for the customer profile.</summary>
    public class CustomerProfilePerson : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The citation ids for the person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>Required. The name of the person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Optional. The title of the person.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Product information for the customer profile.</summary>
    public class CustomerProfileProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The brand of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; }

        /// <summary>Optional. The citation ids for the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>Required. The name of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("product")]
        public virtual string Product { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security considerations for the customer profile.</summary>
    public class CustomerProfileSecurityConsiderations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A series of considerations for the security of the organization, such as "high risk of compromise"
        /// or "vulnerable to cyberbullying".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("considerations")]
        public virtual System.Collections.Generic.IList<string> Considerations { get; set; }

        /// <summary>Optional. A note about the security considerations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A summarized version of the customer profile. Generated by the backend.</summary>
    public class CustomerProfileSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The area the customer serves.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("areaServed")]
        public virtual CustomerProfileCitedString AreaServed { get; set; }

        /// <summary>Optional. A narrative summary of brands.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brands")]
        public virtual CustomerProfileCitedString Brands { get; set; }

        /// <summary>Optional. The entity type of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual CustomerProfileCitedString EntityType { get; set; }

        /// <summary>Optional. The date the customer was founded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("founded")]
        public virtual CustomerProfileCitedString Founded { get; set; }

        /// <summary>Optional. The headquarters of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headquarters")]
        public virtual CustomerProfileCitedString Headquarters { get; set; }

        /// <summary>Optional. The industry the customer is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("industry")]
        public virtual CustomerProfileCitedString Industry { get; set; }

        /// <summary>Optional. A narrative summary of key people.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyPeopleSummary")]
        public virtual CustomerProfileCitedString KeyPeopleSummary { get; set; }

        /// <summary>Optional. The parent company of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentCompany")]
        public virtual CustomerProfileCitedString ParentCompany { get; set; }

        /// <summary>Optional. The primary website of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryWebsite")]
        public virtual CustomerProfileCitedString PrimaryWebsite { get; set; }

        /// <summary>Optional. A narrative summary of products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productsSummary")]
        public virtual CustomerProfileCitedString ProductsSummary { get; set; }

        /// <summary>Optional. A narrative summary of services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicesSummary")]
        public virtual CustomerProfileCitedString ServicesSummary { get; set; }

        /// <summary>Optional. The official name of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual CustomerProfileCitedString Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Web presence information for the customer profile.</summary>
    public class CustomerProfileWebPresence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The citation ids for the web presence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("citationIds")]
        public virtual System.Collections.Generic.IList<string> CitationIds { get; set; }

        /// <summary>Required. The domain name of the web presence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures the specific details of Data Leak alert.</summary>
    public class DataLeakAlertDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Array of ids to accommodate multiple discovery documents</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryDocumentIds")]
        public virtual System.Collections.Generic.IList<string> DiscoveryDocumentIds { get; set; }

        /// <summary>
        /// Required. Data Leak specific severity This will be the string representation of the
        /// DataLeakFindingDetail.Severityenum. (e.g., "LOW", "MEDIUM", "HIGH", "CRITICAL")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detail object for a Data Leak finding.</summary>
    public class DataLeakFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The unique identifier of the document that triggered the Data Leak finding. This ID can be used to
        /// retrieve the content of the document for further analysis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>
        /// Required. Reference to the match score of the Data Leak finding. This is a float value greater than 0 and
        /// less than or equal to 1 calculated by the matching engine based on the similarity of the document and the
        /// user provided configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchScore")]
        public virtual System.Nullable<float> MatchScore { get; set; }

        /// <summary>
        /// Required. The severity of the Data Leak finding. This indicates the potential impact of the threat.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Any account-level configuration options will go here.</summary>
    public class DomainMonitoringConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domains to use as "seeds" for Suspicious Domain Monitoring.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<DomainMonitoringDomain> Domains { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Domain Monitoring "domain"</summary>
    public class DomainMonitoringDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The domain name to match against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// EntityProfile represents the structured profile of a customer entity, containing key identifiers and descriptive
    /// attributes optimized for contextual matching against threat intelligence, particularly Initial Access Broker
    /// (IAB) offerings.
    /// </summary>
    public class EntityProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. List of specific countries of operation. Purpose: Essential for matching geographically targeted
        /// threats (e.g., actor specifies victims in 'DE'). Use ISO 3166-1 alpha-2 codes (e.g., "US", "GB", "JP",
        /// "DE").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<string> Countries { get; set; }

        /// <summary>
        /// Required. List of primary internet domain names associated with the entity. Purpose: Crucial for explicit
        /// matching against domains mentioned in threat intel and can inform semantic matching. Must contain at least
        /// one domain. Example: ["acme.com", "acme.co.uk"]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>
        /// Optional. List of primary industry sectors the entity operates within. Purpose: Crucial for matching
        /// industry-specific threats and understanding attacker motivation. Use standardized GTI Industry
        /// Classification values. Example: ["Technology", "Financial Services", "Healthcare"]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("industries")]
        public virtual System.Collections.Generic.IList<string> Industries { get; set; }

        /// <summary>
        /// Required. Canonical name of the entity (e.g., the legal company name). Purpose: Primary identifier for the
        /// customer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Specific geographic areas of *significant* operational concentration or strategic importance below
        /// the country level, if clearly identifiable and relevant. Purpose: Useful for highly localized threats, less
        /// commonly populated than `countries`. Example: ["Silicon Valley", "Frankfurt am Main Metropolitan Region"]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationalAreas")]
        public virtual System.Collections.Generic.IList<string> OperationalAreas { get; set; }

        /// <summary>
        /// Required. A concise, machine-generated (e.g., LLM) or human-curated summary of the entity. Purpose: Captures
        /// the semantic essence for embedding generation and similarity matching. Should synthesize key aspects like
        /// core business, scale, and market. Example: "Acme Corporation is a large, US-based multinational conglomerate
        /// operating..."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileSummary")]
        public virtual string ProfileSummary { get; set; }

        /// <summary>
        /// Optional. List of primary geopolitical regions where the entity has significant operations. Purpose: Filters
        /// geographically relevant threats. Use standardized names or codes where possible (e.g., "North America",
        /// "EMEA", "APAC", UN M49 codes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>
        /// Optional. List of more granular sub-industries, if applicable and known. Purpose: Provides finer-grained
        /// context for more specific threat matching. Should align with GTI classifications if possible. Example:
        /// ["Semiconductors", "Cloud Computing Services", "Investment Banking"]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subIndustries")]
        public virtual System.Collections.Generic.IList<string> SubIndustries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for EnumerateAlertFacets.</summary>
    public class EnumerateAlertFacetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of facets and the counts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facets")]
        public virtual System.Collections.Generic.IList<Facet> Facets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details the evidence used to determine the relevance verdict.</summary>
    public class Evidence : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of semantic themes or concepts found to be common, related, or aligned between the sources,
        /// supporting the verdict.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonThemes")]
        public virtual System.Collections.Generic.IList<string> CommonThemes { get; set; }

        /// <summary>A list of semantic themes or descriptions unique to one source or semantically distant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("distinctThemes")]
        public virtual System.Collections.Generic.IList<string> DistinctThemes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Facet represents a sub element of a resource for filtering. The results from this method are used to populate
    /// the filterable facets in the UI.
    /// </summary>
    public class Facet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the facet. This is also the string that needs to be used in the filtering expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facet")]
        public virtual string FacetValue { get; set; }

        /// <summary>List of counts for the facet (if categorical).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetCounts")]
        public virtual System.Collections.Generic.IList<FacetCount> FacetCounts { get; set; }

        /// <summary>
        /// The type of the facet. Options include "string", "int", "float", "bool", "enum", "timestamp", "user" and are
        /// useful to show the right sort of UI controls when building a AIP-160 style filtering string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("facetType")]
        public virtual string FacetType { get; set; }

        /// <summary>
        /// Max value of the facet stringified based on type. Will be populated and formatted the same as min_value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual string MaxValue { get; set; }

        /// <summary>
        /// Min value of the facet stringified based on type. This is only populated for facets that have a clear
        /// ordering, for types like enum it will be left empty. Timestamps will be formatted using RFC3339.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual string MinValue { get; set; }

        /// <summary>Total number of records that contain this facet with ANY value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalCount")]
        public virtual System.Nullable<long> TotalCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>FacetCount represents a count of records with each facet value.</summary>
    public class FacetCount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Count of records with the value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<int> Count { get; set; }

        /// <summary>Value of the facet stringified. Timestamps will be formatted using RFC3339.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ‘stateless’ and a point in time event that a check produced a result of interest.</summary>
    public class Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. AI summary of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aiSummary")]
        public virtual string AiSummary { get; set; }

        /// <summary>Optional. Name of the alert that this finding is bound to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alert")]
        public virtual string Alert { get; set; }

        /// <summary>Optional. Optional - asset name if known. Format: vaults/{vault}/assets/{asset}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual string Asset { get; set; }

        /// <summary>Output only. Audit data about the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audit")]
        public virtual Audit Audit { get; set; }

        /// <summary>Optional. Configuration names that are bound to this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurations")]
        public virtual System.Collections.Generic.IList<string> Configurations { get; set; }

        /// <summary>Required. Holder of the domain specific details of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detail")]
        public virtual FindingDetail Detail { get; set; }

        /// <summary>
        /// Required. A short descriptive title for the finding &amp;lt;= 250 chars. EX: "Actor 'baddy' offering $1000
        /// for credentials of 'goodguy'".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. Optional - name of the issue that this finding is bound to. Format: vaults/{vault}/issues/{issue}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual string Issue { get; set; }

        /// <summary>
        /// Identifier. Server generated name for the finding (leave clear during creation). Format:
        /// vaults/{vault}/findings/{finding}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Logical source of this finding (name of the sub-engine).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provider")]
        public virtual string Provider { get; set; }

        /// <summary>Output only. High-Precision Relevance Analysis verdict for the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevanceAnalysis")]
        public virtual RelevanceAnalysis RelevanceAnalysis { get; set; }

        /// <summary>Output only. When identical finding (same labels and same details) has re-occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reoccurrenceTimes")]
        public virtual System.Collections.Generic.IList<object> ReoccurrenceTimes { get; set; }

        /// <summary>
        /// Optional. Deprecated: Use the `severity_analysis` field instead. Base severity score from the finding
        /// source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual System.Nullable<float> Severity { get; set; }

        /// <summary>Output only. High-Precision Severity Analysis verdict for the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityAnalysis")]
        public virtual SeverityAnalysis SeverityAnalysis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Wrapper class that contains the union struct for all the various findings detail specific classes.
    /// </summary>
    public class FindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compromised Credentials detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compromisedCredentials")]
        public virtual CompromisedCredentialsFindingDetail CompromisedCredentials { get; set; }

        /// <summary>Data Leak finding detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLeak")]
        public virtual DataLeakFindingDetail DataLeak { get; set; }

        /// <summary>
        /// Output only. Name of the detail type. Will be set by the server during creation to the name of the field
        /// that is set in the detail union.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailType")]
        public virtual string DetailType { get; set; }

        /// <summary>Inband vulnerability detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inbandVulnerability")]
        public virtual InbandVulnerabilityFindingDetail InbandVulnerability { get; set; }

        /// <summary>Initial Access Broker finding detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialAccessBroker")]
        public virtual InitialAccessBrokerFindingDetail InitialAccessBroker { get; set; }

        /// <summary>Insider Threat finding detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insiderThreat")]
        public virtual InsiderThreatFindingDetail InsiderThreat { get; set; }

        /// <summary>Misconfiguration finding detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("misconfiguration")]
        public virtual MisconfigurationFindingDetail Misconfiguration { get; set; }

        /// <summary>Domain Monitoring finding detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspiciousDomain")]
        public virtual SuspiciousDomainFindingDetail SuspiciousDomain { get; set; }

        /// <summary>Technology Watchlist finding detail type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetTechnology")]
        public virtual TargetTechnologyFindingDetail TargetTechnology { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Fleshed out vulnerability object that includes enough details to fill out a vulnerability specific view for an
    /// issue.
    /// </summary>
    public class InbandVulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The software that is affected by the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("affectedSoftware")]
        public virtual System.Collections.Generic.IList<AffectedSoftware> AffectedSoftware { get; set; }

        /// <summary>Optional. The authors of the vulnerability detection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authors")]
        public virtual System.Collections.Generic.IList<string> Authors { get; set; }

        /// <summary>Required. The CVE ID of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cveId")]
        public virtual string CveId { get; set; }

        /// <summary>Required. The CVSS V3.1 score (Base score)for the vulnerability. ( )</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV31Score")]
        public virtual System.Nullable<float> CvssV31Score { get; set; }

        /// <summary>Optional. Temporal CVSS V3.1 score for the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssV31ScoreTemporal")]
        public virtual System.Nullable<float> CvssV31ScoreTemporal { get; set; }

        /// <summary>Optional. The human readable description. This can be basic HTML formatted text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _disclosureTimeRaw;

        private object _disclosureTime;

        /// <summary>Optional. The date the vulnerability was first disclosed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disclosureTime")]
        public virtual string DisclosureTimeRaw
        {
            get => _disclosureTimeRaw;
            set
            {
                _disclosureTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _disclosureTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DisclosureTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DisclosureTimeDateTimeOffset instead.")]
        public virtual object DisclosureTime
        {
            get => _disclosureTime;
            set
            {
                _disclosureTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _disclosureTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="DisclosureTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DisclosureTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DisclosureTimeRaw);
            set => DisclosureTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. Exploitation state of the vulnerability, for example "Available".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitationState")]
        public virtual string ExploitationState { get; set; }

        /// <summary>Required. The external ID of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalVulnerabilityId")]
        public virtual string ExternalVulnerabilityId { get; set; }

        /// <summary>Optional. Whether this is exploited in the wild.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isExploitedWild")]
        public virtual System.Nullable<bool> IsExploitedWild { get; set; }

        /// <summary>Optional. Reference URLs to the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceUrls")]
        public virtual System.Collections.Generic.IList<string> ReferenceUrls { get; set; }

        /// <summary>
        /// Optional. The human readable remediation recommendation. This can be basic HTML formatted text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual string Remediation { get; set; }

        /// <summary>Optional. Risk rating for the vulnerability, for example "High".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskRating")]
        public virtual string RiskRating { get; set; }

        /// <summary>Optional. Human readable name for the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is a temporary detail type that will be used to support vulnerabilities until the engines start using the
    /// full vulnerability objects. The "Inband" refers to the fact that all vulnerability details are included with
    /// every finding.
    /// </summary>
    public class InbandVulnerabilityFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A short description of the proof of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedProofDetails")]
        public virtual string FormattedProofDetails { get; set; }

        /// <summary>Optional. The URI that lead to this detection, if appropriate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestUri")]
        public virtual string RequestUri { get; set; }

        /// <summary>Required. Vulnerability metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual InbandVulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures the specific details of InitialAccessBroker (IAB) alert.</summary>
    public class InitialAccessBrokerAlertDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Array of ids to accommodate multiple discovery documents</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryDocumentIds")]
        public virtual System.Collections.Generic.IList<string> DiscoveryDocumentIds { get; set; }

        /// <summary>Required. IAB specific severity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>InitialAccessBrokerConfig is specific to Initial Access Broker (IAB) matching scenarios.</summary>
    public class InitialAccessBrokerConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents the comprehensive profile of the customer entity used for matching.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityProfile")]
        public virtual EntityProfile EntityProfile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detail object for an Initial Access Broker (IAB) finding.</summary>
    public class InitialAccessBrokerFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The unique identifier of the document that triggered the IAB finding. This ID can be used to
        /// retrieve the content of the document for further analysis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>
        /// Required. Reference to the match score of the IAB finding. This is a float value between 0 and 1 calculated
        /// by the matching engine based on the similarity of the document and the user provided configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchScore")]
        public virtual System.Nullable<float> MatchScore { get; set; }

        /// <summary>
        /// Required. The severity of the IAB finding. This indicates the potential impact of the threat.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Captures the specific details of InsiderThreat alert.</summary>
    public class InsiderThreatAlertDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Array of ids to accommodate multiple discovery documents</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("discoveryDocumentIds")]
        public virtual System.Collections.Generic.IList<string> DiscoveryDocumentIds { get; set; }

        /// <summary>
        /// Required. InsiderThreat specific severity This will be the string representation of the
        /// InsiderThreatFindingDetail.Severityenum. (e.g., "LOW", "MEDIUM", "HIGH", "CRITICAL")
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detail object for a InsiderThreat finding.</summary>
    public class InsiderThreatFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The unique identifier of the document that triggered the InsiderThreat finding. This ID can be
        /// used to retrieve the content of the document for further analysis.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentId")]
        public virtual string DocumentId { get; set; }

        /// <summary>
        /// Required. Reference to the match score of the InsiderThreat finding. This is a float value greater than 0
        /// and less than or equal to 1 calculated by the matching engine based on the similarity of the document and
        /// the user provided configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchScore")]
        public virtual System.Nullable<float> MatchScore { get; set; }

        /// <summary>
        /// Required. The severity of the InsiderThreat finding. This indicates the potential impact of the threat.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListAlerts.</summary>
    public class ListAlertsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of alerts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alerts")]
        public virtual System.Collections.Generic.IList<Alert> Alerts { get; set; }

        /// <summary>Page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListConfigurationRevisions.</summary>
    public class ListConfigurationRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Configuration Revisions associated with the specified Configuration</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisions")]
        public virtual System.Collections.Generic.IList<ConfigurationRevision> Revisions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListConfigurations.</summary>
    public class ListConfigurationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configurations")]
        public virtual System.Collections.Generic.IList<Configuration> Configurations { get; set; }

        /// <summary>Page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListFindings.</summary>
    public class ListFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findings")]
        public virtual System.Collections.Generic.IList<Finding> Findings { get; set; }

        /// <summary>Page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsBenign.</summary>
    public class MarkAlertAsBenignRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsDuplicate.</summary>
    public class MarkAlertAsDuplicateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Name of the alert to mark as a duplicate of. Format: projects/{project}/alerts/{alert}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateOf")]
        public virtual string DuplicateOf { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsEscalated.</summary>
    public class MarkAlertAsEscalatedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsFalsePositive.</summary>
    public class MarkAlertAsFalsePositiveRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsNotActionable.</summary>
    public class MarkAlertAsNotActionableRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsRead.</summary>
    public class MarkAlertAsReadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsResolved.</summary>
    public class MarkAlertAsResolvedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsTrackedExternally.</summary>
    public class MarkAlertAsTrackedExternallyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MarkAlertAsTriaged.</summary>
    public class MarkAlertAsTriagedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Misconfiguration finding detail.</summary>
    public class MisconfigurationFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The misconfiguration metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("misconfigurationMetadata")]
        public virtual MisconfigurationMetadata MisconfigurationMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Misconfiguration metadata.</summary>
    public class MisconfigurationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the misconfiguration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. A user-friendly name for the misconfiguration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. The identifier for the misconfiguration. This is an internal name generated by the finding
        /// provider.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("misconfigurationId")]
        public virtual string MisconfigurationId { get; set; }

        /// <summary>
        /// Optional. References to external resources that provide more information about the misconfiguration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<MisconfigurationReference> References { get; set; }

        /// <summary>Optional. Recommended remediation steps for the misconfiguration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remediation")]
        public virtual string Remediation { get; set; }

        /// <summary>Optional. The endpoint which was found to have the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerableUri")]
        public virtual string VulnerableUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to an external resource that provides more information about a misconfiguration.</summary>
    public class MisconfigurationReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the reference (e.g., "description", "remediation").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>Required. The URI of the reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured priority analysis for a threat.</summary>
    public class PriorityAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The level of confidence in the given verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual string Confidence { get; set; }

        /// <summary>The level of Priority.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityLevel")]
        public virtual string PriorityLevel { get; set; }

        /// <summary>
        /// Human-readable explanation from the model, detailing why a particular result is considered to have a certain
        /// priority.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasoning")]
        public virtual string Reasoning { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for FetchAlertUriStatus.</summary>
    public class RefreshAlertUriStatusRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for FetchAlertUriStatus.</summary>
    public class RefreshAlertUriStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Status of the alert in WebRisk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured relevance analysis for a threat.</summary>
    public class RelevanceAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The level of confidence in the given verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual string Confidence { get; set; }

        /// <summary>Evidence supporting the verdict, including matched and unmatched items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evidence")]
        public virtual Evidence Evidence { get; set; }

        /// <summary>
        /// Human-readable explanation from the matcher, detailing why a particular result is considered relevant or not
        /// relevant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasoning")]
        public virtual string Reasoning { get; set; }

        /// <summary>The level of relevance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevanceLevel")]
        public virtual string RelevanceLevel { get; set; }

        /// <summary>Indicates whether the threat is considered relevant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relevant")]
        public virtual System.Nullable<bool> Relevant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ReportAlertUri.</summary>
    public class ReportAlertUriRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ReportAlertUri.</summary>
    public class ReportAlertUriResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Status of the alert in WebRisk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for SearchFindings.</summary>
    public class SearchFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findings")]
        public virtual System.Collections.Generic.IList<Finding> Findings { get; set; }

        /// <summary>Page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Structured severity analysis for a threat.</summary>
    public class SeverityAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The level of confidence in the given verdict.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual string Confidence { get; set; }

        /// <summary>
        /// Human-readable explanation from the model, detailing why a particular result is considered to have a certain
        /// severity.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasoning")]
        public virtual string Reasoning { get; set; }

        /// <summary>The level of severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severityLevel")]
        public virtual string SeverityLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The alert detail for a suspicious domain finding.</summary>
    public class SuspiciousDomainAlertDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DNS details of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dns")]
        public virtual SuspiciousDomainDnsDetails Dns { get; set; }

        /// <summary>Required. The suspicious domain name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The GTI details of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtiDetails")]
        public virtual SuspiciousDomainGtiDetails GtiDetails { get; set; }

        /// <summary>Output only. Name of Web Risk submission operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webRiskOperation")]
        public virtual string WebRiskOperation { get; set; }

        /// <summary>Output only. Status of the Web Risk submission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webRiskState")]
        public virtual string WebRiskState { get; set; }

        /// <summary>The whois details of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whois")]
        public virtual SuspiciousDomainWhoIsDetails Whois { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The DNS details of the suspicious domain.</summary>
    public class SuspiciousDomainDnsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DNS records of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dnsRecords")]
        public virtual System.Collections.Generic.IList<SuspiciousDomainDnsRecord> DnsRecords { get; set; }

        private string _retrievalTimeRaw;

        private object _retrievalTime;

        /// <summary>The time the DNS details were retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalTime")]
        public virtual string RetrievalTimeRaw
        {
            get => _retrievalTimeRaw;
            set
            {
                _retrievalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _retrievalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RetrievalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RetrievalTimeDateTimeOffset instead.")]
        public virtual object RetrievalTime
        {
            get => _retrievalTime;
            set
            {
                _retrievalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _retrievalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RetrievalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RetrievalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RetrievalTimeRaw);
            set => RetrievalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The DNS record of the suspicious domain.</summary>
    public class SuspiciousDomainDnsRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the DNS record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("record")]
        public virtual string Record { get; set; }

        /// <summary>The TTL of the DNS record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual System.Nullable<int> Ttl { get; set; }

        /// <summary>The type of the DNS record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The value of the DNS record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A detailed object for a suspicious Domain finding.</summary>
    public class SuspiciousDomainFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DNS details of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dns")]
        public virtual SuspiciousDomainDnsDetails Dns { get; set; }

        /// <summary>Required. The suspicious domain name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The GTI details of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtiDetails")]
        public virtual SuspiciousDomainGtiDetails GtiDetails { get; set; }

        /// <summary>
        /// Required. Reference to the match score of the finding. This is a float value between 0 and 1 calculated by
        /// the matching engine.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchScore")]
        public virtual System.Nullable<float> MatchScore { get; set; }

        /// <summary>Required. The severity of the finding. This indicates the potential impact of the threat.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The whois details of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whois")]
        public virtual SuspiciousDomainWhoIsDetails Whois { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The GTI details of the suspicious domain.</summary>
    public class SuspiciousDomainGtiDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The threat score of the suspicious domain. The threat score is a number between 0 and 100.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threatScore")]
        public virtual System.Nullable<int> ThreatScore { get; set; }

        /// <summary>Output only. The verdict of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verdict")]
        public virtual string Verdict { get; set; }

        /// <summary>VirusTotal link for the domain</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virustotalUri")]
        public virtual string VirustotalUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The whois details of the suspicious domain.</summary>
    public class SuspiciousDomainWhoIsDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _retrievalTimeRaw;

        private object _retrievalTime;

        /// <summary>The time the whois details were retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retrievalTime")]
        public virtual string RetrievalTimeRaw
        {
            get => _retrievalTimeRaw;
            set
            {
                _retrievalTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _retrievalTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RetrievalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RetrievalTimeDateTimeOffset instead.")]
        public virtual object RetrievalTime
        {
            get => _retrievalTime;
            set
            {
                _retrievalTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _retrievalTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RetrievalTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RetrievalTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RetrievalTimeRaw);
            set => RetrievalTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The whois details of the suspicious domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whois")]
        public virtual string Whois { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains details for a technology watchlist alert.</summary>
    public class TargetTechnologyAlertDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The vulnerability match details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilityMatch")]
        public virtual VulnerabilityMatch VulnerabilityMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains details for a technology watchlist finding.</summary>
    public class TargetTechnologyFindingDetail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The vulnerability match details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerabilityMatch")]
        public virtual VulnerabilityMatch VulnerabilityMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TechnologyWatchListAlertThreshold contains the thresholds for alerting.</summary>
    public class TechnologyWatchListAlertThreshold : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The minimum cvss V3 score for the alert. Ex: 7.0. Valid range is [0.0, 10.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssScoreMinimum")]
        public virtual System.Nullable<float> CvssScoreMinimum { get; set; }

        /// <summary>Optional. The minimum epss score for the alert. Ex: 0.8. Valid range is [0.0, 1.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("epssScoreMinimum")]
        public virtual System.Nullable<float> EpssScoreMinimum { get; set; }

        /// <summary>Optional. The exploitation states of the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitationStates")]
        public virtual System.Collections.Generic.IList<string> ExploitationStates { get; set; }

        /// <summary>Optional. The minimum priority for the alert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priorityMinimum")]
        public virtual string PriorityMinimum { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>TechnologyWatchListConfig is the configuration for the technology watchlist.</summary>
    public class TechnologyWatchListConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Alert thresholds to effectively reduce noise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alertThreshold")]
        public virtual TechnologyWatchListAlertThreshold AlertThreshold { get; set; }

        /// <summary>
        /// Optional. List of vendor, technology or cpe fingerprint. example: Microsoft office 360 Apache Server 3.5
        /// cpe:2.3:a:microsoft:outlook:*:*:*:*:*:*:*:*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologies")]
        public virtual System.Collections.Generic.IList<string> Technologies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for UpsertConfiguration.</summary>
    public class UpsertConfigurationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Created configuration ID with server assigned id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configuration")]
        public virtual string Configuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains details about a vulnerability match.</summary>
    public class VulnerabilityMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Associated threat actors, malware, etc. This is embedded as a snapshot because the details of the
        /// association at the time of the vulnerability match are important for context and reporting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associations")]
        public virtual System.Collections.Generic.IList<Association> Associations { get; set; }

        /// <summary>Output only. The collection ID of the vulnerability. Ex: "vulnerability--cve-2025-9876".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionId")]
        public virtual string CollectionId { get; set; }

        /// <summary>
        /// Output only. The CVE ID of the vulnerability. Ex: "CVE-2025-9876". See https://www.cve.org/ for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cveId")]
        public virtual string CveId { get; set; }

        /// <summary>Output only. The CVSS v3 score of the vulnerability. Example: 6.4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvss3Score")]
        public virtual System.Nullable<float> Cvss3Score { get; set; }

        /// <summary>Output only. A description of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The exploitation state of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exploitationState")]
        public virtual string ExploitationState { get; set; }

        /// <summary>Output only. The risk rating of the vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskRating")]
        public virtual string RiskRating { get; set; }

        /// <summary>Output only. The affected technologies. Ex: "Apache Struts".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("technologies")]
        public virtual System.Collections.Generic.IList<string> Technologies { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
