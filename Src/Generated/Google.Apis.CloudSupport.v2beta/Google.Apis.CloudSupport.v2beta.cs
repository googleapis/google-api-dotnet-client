// Copyright 2022 Google LLC
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

namespace Google.Apis.CloudSupport.v2beta
{
    /// <summary>The CloudSupport Service.</summary>
    public class CloudSupportService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudSupportService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudSupportService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Attachments = new AttachmentsResource(this);
            CaseClassifications = new CaseClassificationsResource(this);
            Cases = new CasesResource(this);
            Media = new MediaResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudsupport";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudsupport.googleapis.com/";
        #else
            "https://cloudsupport.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudsupport.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Support API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Cloud Support API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Attachments resource.</summary>
        public virtual AttachmentsResource Attachments { get; }

        /// <summary>Gets the CaseClassifications resource.</summary>
        public virtual CaseClassificationsResource CaseClassifications { get; }

        /// <summary>Gets the Cases resource.</summary>
        public virtual CasesResource Cases { get; }

        /// <summary>Gets the Media resource.</summary>
        public virtual MediaResource Media { get; }
    }

    /// <summary>A base abstract class for CloudSupport requests.</summary>
    public abstract class CloudSupportBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudSupportBaseServiceRequest instance.</summary>
        protected CloudSupportBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudSupport parameter list.</summary>
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

    /// <summary>The "attachments" collection of methods.</summary>
    public class AttachmentsResource
    {
        private const string Resource = "attachments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AttachmentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Create a file attachment on a case or Cloud resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The resource name of the case to which attachment should be attached.</param>
        public virtual CreateRequest Create(Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent)
        {
            return new CreateRequest(service, body, parent);
        }

        /// <summary>Create a file attachment on a case or Cloud resource.</summary>
        public class CreateRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Attachment>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the case to which attachment should be attached.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}/attachments";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "caseClassifications" collection of methods.</summary>
    public class CaseClassificationsResource
    {
        private const string Resource = "caseClassifications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CaseClassificationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieve valid classifications to be used when creating a support case. The classications are hierarchical,
        /// with each classification containing all levels of the hierarchy, separated by " &amp;gt; ". For example
        /// "Technical Issue &amp;gt; Compute &amp;gt; Compute Engine".
        /// </summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>
        /// Retrieve valid classifications to be used when creating a support case. The classications are hierarchical,
        /// with each classification containing all levels of the hierarchy, separated by " &amp;gt; ". For example
        /// "Technical Issue &amp;gt; Compute &amp;gt; Compute Engine".
        /// </summary>
        public class SearchRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.SearchCaseClassificationsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of cases fetched with each request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// An expression written in the Cloud filter language. If non-empty, then only cases whose fields match the
            /// filter are returned. If empty, then no messages are filtered out.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/caseClassifications:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

    /// <summary>The "cases" collection of methods.</summary>
    public class CasesResource
    {
        private const string Resource = "cases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Attachments = new AttachmentsResource(service);
            Comments = new CommentsResource(service);
        }

        /// <summary>Gets the Attachments resource.</summary>
        public virtual AttachmentsResource Attachments { get; }

        /// <summary>The "attachments" collection of methods.</summary>
        public class AttachmentsResource
        {
            private const string Resource = "attachments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AttachmentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Retrieve all attachments associated with a support case.</summary>
            /// <param name="parent">
            /// Required. The resource name of Case object for which attachments should be listed.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Retrieve all attachments associated with a support case.</summary>
            public class ListRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.ListAttachmentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of Case object for which attachments should be listed.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of attachments fetched with each request. If not provided, the default is 10. The
                /// maximum page size that will be returned is 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/attachments";

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
                        Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
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

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments { get; }

        /// <summary>The "comments" collection of methods.</summary>
        public class CommentsResource
        {
            private const string Resource = "comments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CommentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Add a new comment to the specified Case.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The resource name of Case to which this comment should be added.</param>
            public virtual CreateRequest Create(Google.Apis.CloudSupport.v2beta.Data.Comment body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Add a new comment to the specified Case.</summary>
            public class CreateRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Comment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.Comment body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The resource name of Case to which this comment should be added.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudSupport.v2beta.Data.Comment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/comments";

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
                        Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieve all Comments associated with the Case object.</summary>
            /// <param name="parent">
            /// Required. The resource name of Case object for which comments should be listed.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Retrieve all Comments associated with the Case object.</summary>
            public class ListRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.ListCommentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The resource name of Case object for which comments should be listed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of comments fetched with each request. Defaults to 10.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2beta/{+parent}/comments";

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
                        Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
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

        /// <summary>Close the specified case.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The fully qualified name of the case resource to be closed.</param>
        public virtual CloseRequest Close(Google.Apis.CloudSupport.v2beta.Data.CloseCaseRequest body, string name)
        {
            return new CloseRequest(service, body, name);
        }

        /// <summary>Close the specified case.</summary>
        public class CloseRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Close request.</summary>
            public CloseRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.CloseCaseRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The fully qualified name of the case resource to be closed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.CloseCaseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "close";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:close";

            /// <summary>Initializes Close parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>Create a new case and associate it with the given Cloud resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The name of the Cloud resource under which the case should be created.
        /// </param>
        public virtual CreateRequest Create(Google.Apis.CloudSupport.v2beta.Data.Case body, string parent)
        {
            return new CreateRequest(service, body, parent);
        }

        /// <summary>Create a new case and associate it with the given Cloud resource.</summary>
        public class CreateRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.Case body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The name of the Cloud resource under which the case should be created.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.Case Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}/cases";

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
                    Pattern = @"^[^/]+/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Escalate a case. Escalating a case will initiate the Cloud Support escalation management process. This
        /// operation is only available to certain Customer Care tiers. Go to https://cloud.google.com/support and look
        /// for 'Technical support escalations' in the feature list to find out which tiers are able to perform
        /// escalations.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Required. The fully qualified name of the Case resource to be escalated.</param>
        public virtual EscalateRequest Escalate(Google.Apis.CloudSupport.v2beta.Data.EscalateCaseRequest body, string name)
        {
            return new EscalateRequest(service, body, name);
        }

        /// <summary>
        /// Escalate a case. Escalating a case will initiate the Cloud Support escalation management process. This
        /// operation is only available to certain Customer Care tiers. Go to https://cloud.google.com/support and look
        /// for 'Technical support escalations' in the feature list to find out which tiers are able to perform
        /// escalations.
        /// </summary>
        public class EscalateRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Escalate request.</summary>
            public EscalateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.EscalateCaseRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The fully qualified name of the Case resource to be escalated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.EscalateCaseRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "escalate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:escalate";

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
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>Retrieve the specified case.</summary>
        /// <param name="name">Required. The fully qualified name of a case to be retrieved.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Retrieve the specified case.</summary>
        public class GetRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. The fully qualified name of a case to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Retrieve all cases under the specified parent. Note: Listing cases under an Organization returns only the
        /// cases directly parented by that organization. To retrieve all cases under an organization, including cases
        /// parented by projects under that organization, use `cases.search`.
        /// </summary>
        /// <param name="parent">Required. The fully qualified name of parent resource to list cases under.</param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(service, parent);
        }

        /// <summary>
        /// Retrieve all cases under the specified parent. Note: Listing cases under an Organization returns only the
        /// cases directly parented by that organization. To retrieve all cases under an organization, including cases
        /// parented by projects under that organization, use `cases.search`.
        /// </summary>
        public class ListRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.ListCasesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>Required. The fully qualified name of parent resource to list cases under.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// An expression written in filter language. If non-empty, the query returns the cases that match the
            /// filter. Else, the query doesn't filter the cases. Filter expressions use the following fields with the
            /// operators equals (`=`) and `AND`: - `state`: The accepted values are `OPEN` or `CLOSED`. - `priority`:
            /// The accepted values are `P0`, `P1`, `P2`, `P3`, or `P4`. You can specify multiple values for priority
            /// using the `OR` operator. For example, `priority=P1 OR priority=P2`. - [DEPRECATED] `severity`: The
            /// accepted values are `S0`, `S1`, `S2`, `S3`, or `S4`. - `creator.email`: The email address of the case
            /// creator. Examples: - `state=CLOSED` - `state=OPEN AND creator.email="tester@example.com"` - `state=OPEN
            /// AND (priority=P0 OR priority=P1)`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of cases fetched with each request. Defaults to 10.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}/cases";

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
                    Pattern = @"^[^/]+/[^/]+$",
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
        /// Update the specified case. Only a subset of fields (display_name, description, time_zone,
        /// subscriber_email_addresses, related_resources, severity, priority, primary_contact, and labels) can be
        /// updated.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The resource name for the case.</param>
        public virtual PatchRequest Patch(Google.Apis.CloudSupport.v2beta.Data.Case body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>
        /// Update the specified case. Only a subset of fields (display_name, description, time_zone,
        /// subscriber_email_addresses, related_resources, severity, priority, primary_contact, and labels) can be
        /// updated.
        /// </summary>
        public class PatchRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Case>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.Case body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The resource name for the case.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// A field that represents attributes of a case object that should be updated as part of this request.
            /// Supported values are severity, display_name, and subscriber_email_addresses. If no fields are specified,
            /// all supported fields will be updated. WARNING: If you do not provide a field mask then you may
            /// accidentally clear some fields. For example, if you leave field mask empty and do not provide a value
            /// for subscriber_email_addresses then subscriber_email_addresses will be updated to empty.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.Case Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}";

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
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
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

        /// <summary>Search cases using the specified query.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>Search cases using the specified query.</summary>
        public class SearchRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.SearchCasesResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of cases fetched with each request. The default page size is 10.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token identifying the page of results to return. If unspecified, the first page is retrieved.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// An expression written in filter language. A query uses the following fields with the operators equals
            /// (`=`) and `AND`: - `organization`: An organization name in the form `organizations/`. - `project`: A
            /// project name in the form `projects/`. - `state`: The accepted values are `OPEN` or `CLOSED`. -
            /// `priority`: The accepted values are `P0`, `P1`, `P2`, `P3`, or `P4`. You can specify multiple values for
            /// priority using the `OR` operator. For example, `priority=P1 OR priority=P2`. - [DEPRECATED] `severity`:
            /// The accepted values are `S0`, `S1`, `S2`, `S3`, or `S4`. - `creator.email`: The email address of the
            /// case creator. You must specify eitehr `organization` or `project`. To search across `displayName`,
            /// `description`, and comments, use a global restriction with no keyword or operator. For example, `"my
            /// search"`. To search only cases updated after a certain date, use `update_time` retricted with that
            /// particular date, time, and timezone in ISO datetime format. For example,
            /// `update_time&amp;gt;"2020-01-01T00:00:00-05:00"`. `update_time` only supports the greater than operator
            /// (`&amp;gt;`). Examples: - `organization="organizations/123456789"` - `project="projects/my-project-id"`
            /// - `project="projects/123456789"` - `organization="organizations/123456789" AND state=CLOSED` -
            /// `project="projects/my-project-id" AND creator.email="tester@example.com"` -
            /// `project="projects/my-project-id" AND (priority=P0 OR priority=P1)`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/cases:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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

    /// <summary>The "media" collection of methods.</summary>
    public class MediaResource
    {
        private const string Resource = "media";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Download a file attachment on a case. Note: HTTP requests must append "?alt=media" to the URL.
        /// </summary>
        /// <param name="name">The resource name of the attachment to be downloaded.</param>
        public virtual DownloadRequest Download(string name)
        {
            return new DownloadRequest(service, name);
        }

        /// <summary>
        /// Download a file attachment on a case. Note: HTTP requests must append "?alt=media" to the URL.
        /// </summary>
        public class DownloadRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Media>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>The resource name of the attachment to be downloaded.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+name}:download";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+/attachments/[^/]+$",
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                #if !NET40
                mediaDownloader.Range = null;
                #endif
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            #if !NET40
            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
            #endif
        }

        /// <summary>Create a file attachment on a case or Cloud resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The resource name of the case to which attachment should be attached.</param>
        public virtual UploadRequest Upload(Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent)
        {
            return new UploadRequest(service, body, parent);
        }

        /// <summary>Create a file attachment on a case or Cloud resource.</summary>
        public class UploadRequest : CloudSupportBaseServiceRequest<Google.Apis.CloudSupport.v2beta.Data.Attachment>
        {
            /// <summary>Constructs a new Upload request.</summary>
            public UploadRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The resource name of the case to which attachment should be attached.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "upload";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2beta/{+parent}/attachments";

            /// <summary>Initializes Upload parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^[^/]+/[^/]+/cases/[^/]+$",
                });
            }
        }

        /// <summary>Create a file attachment on a case or Cloud resource.</summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The resource name of the case to which attachment should be attached.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadMediaUpload Upload(Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent, System.IO.Stream stream, string contentType)
        {
            return new UploadMediaUpload(service, body, parent, stream, contentType);
        }

        /// <summary>Upload media upload which supports resumable upload.</summary>
        public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest, Google.Apis.CloudSupport.v2beta.Data.Attachment>
        {
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Required. The resource name of the case to which attachment should be attached.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Constructs a new Upload media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.CloudSupport.v2beta.Data.CreateAttachmentRequest body, string parent, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "v2beta/{+parent}/attachments"), "POST", stream, contentType)
            {
                Parent = parent;
                Body = body;
            }
        }
    }
}
namespace Google.Apis.CloudSupport.v2beta.Data
{
    /// <summary>
    /// An object containing information about the effective user and authenticated principal responsible for an action.
    /// </summary>
    public class Actor : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The name to display for the actor. If not provided, it is inferred from credentials supplied during case
        /// creation. When an email is provided, a display name must also be provided. This will be obfuscated if the
        /// user is a Google Support agent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The email address of the actor. If not provided, it is inferred from credentials supplied during case
        /// creation. If the authenticated principal does not have an email address, one must be provided. When a name
        /// is provided, an email must also be provided. This will be obfuscated if the user is a Google Support agent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>Output only. Whether the actor is a Google support actor.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleSupport")]
        public virtual System.Nullable<bool> GoogleSupport { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a file attached to a support case.</summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time at which the attachment was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Output only. The user who uploaded the attachment. Note, the name and email will be obfuscated if the
        /// attachment was uploaded by Google support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual Actor Creator { get; set; }

        /// <summary>The filename of the attachment (e.g. `"graph.jpg"`).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary>Output only. The MIME type of the attachment (e.g. text/plain).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>Output only. The resource name of the attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The size of the attachment in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeBytes")]
        public virtual System.Nullable<long> SizeBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class Blobstore2Info : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobGeneration")]
        public virtual System.Nullable<long> BlobGeneration { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobId")]
        public virtual string BlobId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadReadHandle")]
        public virtual string DownloadReadHandle { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readToken")]
        public virtual string ReadToken { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uploadMetadataContainer")]
        public virtual string UploadMetadataContainer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A support case.</summary>
    public class Case : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The issue classification applicable to this case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classification")]
        public virtual CaseClassification Classification { get; set; }

        /// <summary>Output only. The time this case was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The user who created the case. Note: The name and email will be obfuscated if the case was created by Google
        /// Support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual Actor Creator { get; set; }

        /// <summary>A broad description of the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The short summary of the issue reported in this case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Whether the case is currently escalated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("escalated")]
        public virtual System.Nullable<bool> Escalated { get; set; }

        /// <summary>The resource name for the case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The priority of this case. If this is set, do not set severity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual string Priority { get; set; }

        /// <summary>The severity of this case. Deprecated. Use priority instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Output only. The current status of the support case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The email addresses to receive updates on this case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriberEmailAddresses")]
        public virtual System.Collections.Generic.IList<string> SubscriberEmailAddresses { get; set; }

        /// <summary>
        /// Whether this case was created for internal API testing and should not be acted on by the support team.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testCase")]
        public virtual System.Nullable<bool> TestCase { get; set; }

        /// <summary>
        /// The timezone of the user who created the support case. It should be in a format IANA recognizes:
        /// https://www.iana.org/time-zones. There is no additional validation done by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>Output only. The time this case was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A classification object with a product type and value.</summary>
    public class CaseClassification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The unique ID for a classification. Must be specified for case creation. To retrieve valid classification
        /// IDs for case creation, use `caseClassifications.search`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the CloseCase endpoint.</summary>
    public class CloseCaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A comment associated with a support case.</summary>
    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The full comment body. Maximum of 120000 characters. This can contain rich text syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        /// <summary>Output only. The time when this comment was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Output only. The user or Google Support agent created this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creator")]
        public virtual Actor Creator { get; set; }

        /// <summary>Output only. The resource name for the comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. An automatically generated plain text version of body with all rich text syntax stripped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plainTextBody")]
        public virtual string PlainTextBody { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class CompositeMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class ContentTypeInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bestGuess")]
        public virtual string BestGuess { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromBytes")]
        public virtual string FromBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromFileName")]
        public virtual string FromFileName { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromHeader")]
        public virtual string FromHeader { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fromUrlPath")]
        public virtual string FromUrlPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the CreateAttachment endpoint.</summary>
    public class CreateAttachmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The attachment to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachment")]
        public virtual Attachment Attachment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffChecksumsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsLocation")]
        public virtual CompositeMedia ChecksumsLocation { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chunkSizeBytes")]
        public virtual System.Nullable<long> ChunkSizeBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffDownloadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectLocation")]
        public virtual CompositeMedia ObjectLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffUploadRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checksumsInfo")]
        public virtual CompositeMedia ChecksumsInfo { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectInfo")]
        public virtual CompositeMedia ObjectInfo { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalObject")]
        public virtual CompositeMedia OriginalObject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DiffVersionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSizeBytes")]
        public virtual System.Nullable<long> ObjectSizeBytes { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectVersion")]
        public virtual string ObjectVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class DownloadParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGzipCompression")]
        public virtual System.Nullable<bool> AllowGzipCompression { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreRange")]
        public virtual System.Nullable<bool> IgnoreRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for the EscalateCase endpoint.</summary>
    public class EscalateCaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The escalation object to be sent with the escalation request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("escalation")]
        public virtual Escalation Escalation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An escalation of a support case.</summary>
    public class Escalation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A free text description to accompany the `reason` field above. Provides additional context on why
        /// the case is being escalated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justification")]
        public virtual string Justification { get; set; }

        /// <summary>Required. The reason why the Case is being escalated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListAttachments endpoint.</summary>
    public class ListAttachmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of attachments associated with the given case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<Attachment> Attachments { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. This should be set in the `page_token` field of subsequent
        /// `cases.attachments.list` requests. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListCases endpoint.</summary>
    public class ListCasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of cases associated with the cloud resource, after any filters have been applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cases")]
        public virtual System.Collections.Generic.IList<Case> Cases { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. This should be set in the `page_token` field of subsequent
        /// `ListCasesRequest` message that is issued. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the ListComments endpoint.</summary>
    public class ListCommentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Comments associated with the given Case.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual System.Collections.Generic.IList<Comment> Comments { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. This should be set in the `page_token` field of subsequent
        /// `ListCommentsRequest` message that is issued. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class Media : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("algorithm")]
        public virtual string Algorithm { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigstoreObjectRef")]
        public virtual string BigstoreObjectRef { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobRef")]
        public virtual string BlobRef { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blobstore2Info")]
        public virtual Blobstore2Info Blobstore2Info { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compositeMedia")]
        public virtual System.Collections.Generic.IList<CompositeMedia> CompositeMedia { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentTypeInfo")]
        public virtual ContentTypeInfo ContentTypeInfo { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosmoBinaryReference")]
        public virtual string CosmoBinaryReference { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32cHash")]
        public virtual System.Nullable<long> Crc32cHash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffChecksumsResponse")]
        public virtual DiffChecksumsResponse DiffChecksumsResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffDownloadResponse")]
        public virtual DiffDownloadResponse DiffDownloadResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadRequest")]
        public virtual DiffUploadRequest DiffUploadRequest { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffUploadResponse")]
        public virtual DiffUploadResponse DiffUploadResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diffVersionResponse")]
        public virtual DiffVersionResponse DiffVersionResponse { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadParameters")]
        public virtual DownloadParameters DownloadParameters { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filename")]
        public virtual string Filename { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hash")]
        public virtual string Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashVerified")]
        public virtual System.Nullable<bool> HashVerified { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inline")]
        public virtual string Inline { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPotentialRetry")]
        public virtual System.Nullable<bool> IsPotentialRetry { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<long> Length { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaId")]
        public virtual string MediaId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual ObjectId ObjectId { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referenceType")]
        public virtual string ReferenceType { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1Hash")]
        public virtual string Sha1Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Hash")]
        public virtual string Sha256Hash { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<ulong> Timestamp { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary># gdata.* are outside protos with mising documentation</summary>
    public class ObjectId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary># gdata.* are outside protos with mising documentation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectName")]
        public virtual string ObjectName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for SearchCaseClassifications endpoint.</summary>
    public class SearchCaseClassificationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The classifications retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseClassifications")]
        public virtual System.Collections.Generic.IList<CaseClassification> CaseClassifications { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. This should be set in the `page_token` field of subsequent
        /// `SearchCaseClassificationsRequest` message that is issued. If unspecified, there are no more results to
        /// retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the SearchCases endpoint.</summary>
    public class SearchCasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Case associated with the cloud resource, after any filters have been applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cases")]
        public virtual System.Collections.Generic.IList<Case> Cases { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. This should be set in the `page_token` field of subsequent
        /// `SearchCaseRequest` message that is issued. If unspecified, there are no more results to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about the operation. Used to lookup the current status.</summary>
    public class WorkflowOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The namespace that the job was scheduled in. Must be included in the workflow metadata so the workflow
        /// status can be retrieved.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>The type of action the operation is classified as.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operationAction")]
        public virtual string OperationAction { get; set; }

        /// <summary>Which version of the workflow service this operation came from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workflowOperationType")]
        public virtual string WorkflowOperationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
