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

namespace Google.Apis.OSConfig.v1
{
    /// <summary>The OSConfig Service.</summary>
    public class OSConfigService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public OSConfigService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public OSConfigService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "osconfig";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://osconfig.googleapis.com/";
        #else
            "https://osconfig.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://osconfig.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the OS Config API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the OS Config API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for OSConfig requests.</summary>
    public abstract class OSConfigBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new OSConfigBaseServiceRequest instance.</summary>
        protected OSConfigBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes OSConfig parameter list.</summary>
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
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.Empty>
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

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.ListOperationsResponse>
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
            public override string RestPath => "v1/{+name}";

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
                    Pattern = @"^operations$",
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
            PatchDeployments = new PatchDeploymentsResource(service);
            PatchJobs = new PatchJobsResource(service);
        }

        /// <summary>Gets the PatchDeployments resource.</summary>
        public virtual PatchDeploymentsResource PatchDeployments { get; }

        /// <summary>The "patchDeployments" collection of methods.</summary>
        public class PatchDeploymentsResource
        {
            private const string Resource = "patchDeployments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PatchDeploymentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create an OS Config patch deployment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The project to apply this patch deployment to in the form `projects/*`.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.OSConfig.v1.Data.PatchDeployment body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create an OS Config patch deployment.</summary>
            public class CreateRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.PatchDeployment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1.Data.PatchDeployment body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The project to apply this patch deployment to in the form `projects/*`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. A name for the patch deployment in the project. When creating a name the following rules
                /// apply: * Must contain only lowercase letters, numbers, and hyphens. * Must start with a letter. *
                /// Must be between 1-63 characters. * Must end with a number or a letter. * Must be unique within the
                /// project.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("patchDeploymentId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PatchDeploymentId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1.Data.PatchDeployment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/patchDeployments";

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
                    RequestParameters.Add("patchDeploymentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "patchDeploymentId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Delete an OS Config patch deployment.</summary>
            /// <param name="name">
            /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Delete an OS Config patch deployment.</summary>
            public class DeleteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
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
                        Pattern = @"^projects/[^/]+/patchDeployments/[^/]+$",
                    });
                }
            }

            /// <summary>Get an OS Config patch deployment.</summary>
            /// <param name="name">
            /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get an OS Config patch deployment.</summary>
            public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.PatchDeployment>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the patch deployment in the form `projects/*/patchDeployments/*`.
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
                        Pattern = @"^projects/[^/]+/patchDeployments/[^/]+$",
                    });
                }
            }

            /// <summary>Get a page of OS Config patch deployments.</summary>
            /// <param name="parent">Required. The resource name of the parent in the form `projects/*`.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Get a page of OS Config patch deployments.</summary>
            public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.ListPatchDeploymentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The resource name of the parent in the form `projects/*`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. The maximum number of patch deployments to return. Default is 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A pagination token returned from a previous call to ListPatchDeployments that indicates
                /// where this listing should continue from.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/patchDeployments";

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

        /// <summary>Gets the PatchJobs resource.</summary>
        public virtual PatchJobsResource PatchJobs { get; }

        /// <summary>The "patchJobs" collection of methods.</summary>
        public class PatchJobsResource
        {
            private const string Resource = "patchJobs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PatchJobsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                InstanceDetails = new InstanceDetailsResource(service);
            }

            /// <summary>Gets the InstanceDetails resource.</summary>
            public virtual InstanceDetailsResource InstanceDetails { get; }

            /// <summary>The "instanceDetails" collection of methods.</summary>
            public class InstanceDetailsResource
            {
                private const string Resource = "instanceDetails";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstanceDetailsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Get a list of instance details for a given patch job.</summary>
                /// <param name="parent">
                /// Required. The parent for the instances are in the form of `projects/*/patchJobs/*`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Get a list of instance details for a given patch job.</summary>
                public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.ListPatchJobInstanceDetailsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent for the instances are in the form of `projects/*/patchJobs/*`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// A filter expression that filters results listed in the response. This field supports filtering
                    /// results by instance zone, name, state, or `failure_reason`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The maximum number of instance details records to return. Default is 100.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// A pagination token returned from a previous call that indicates where this listing should
                    /// continue from.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instanceDetails";

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
                            Pattern = @"^projects/[^/]+/patchJobs/[^/]+$",
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

            /// <summary>
            /// Cancel a patch job. The patch job must be active. Canceled patch jobs cannot be restarted.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. Name of the patch in the form `projects/*/patchJobs/*`</param>
            public virtual CancelRequest Cancel(Google.Apis.OSConfig.v1.Data.CancelPatchJobRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>
            /// Cancel a patch job. The patch job must be active. Canceled patch jobs cannot be restarted.
            /// </summary>
            public class CancelRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.PatchJob>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1.Data.CancelPatchJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Name of the patch in the form `projects/*/patchJobs/*`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1.Data.CancelPatchJobRequest Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/patchJobs/[^/]+$",
                    });
                }
            }

            /// <summary>Patch VM instances by creating and running a patch job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The project in which to run this patch in the form `projects/*`</param>
            public virtual ExecuteRequest Execute(Google.Apis.OSConfig.v1.Data.ExecutePatchJobRequest body, string parent)
            {
                return new ExecuteRequest(service, body, parent);
            }

            /// <summary>Patch VM instances by creating and running a patch job.</summary>
            public class ExecuteRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.PatchJob>
            {
                /// <summary>Constructs a new Execute request.</summary>
                public ExecuteRequest(Google.Apis.Services.IClientService service, Google.Apis.OSConfig.v1.Data.ExecutePatchJobRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The project in which to run this patch in the form `projects/*`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.OSConfig.v1.Data.ExecutePatchJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "execute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/patchJobs:execute";

                /// <summary>Initializes Execute parameter list.</summary>
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

            /// <summary>
            /// Get the patch job. This can be used to track the progress of an ongoing patch job or review the details
            /// of completed jobs.
            /// </summary>
            /// <param name="name">Required. Name of the patch in the form `projects/*/patchJobs/*`</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Get the patch job. This can be used to track the progress of an ongoing patch job or review the details
            /// of completed jobs.
            /// </summary>
            public class GetRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.PatchJob>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Name of the patch in the form `projects/*/patchJobs/*`</summary>
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
                        Pattern = @"^projects/[^/]+/patchJobs/[^/]+$",
                    });
                }
            }

            /// <summary>Get a list of patch jobs.</summary>
            /// <param name="parent">Required. In the form of `projects/*`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Get a list of patch jobs.</summary>
            public class ListRequest : OSConfigBaseServiceRequest<Google.Apis.OSConfig.v1.Data.ListPatchJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. In the form of `projects/*`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// If provided, this field specifies the criteria that must be met by patch jobs to be included in the
                /// response. Currently, filtering is only available on the patch_deployment field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>The maximum number of instance status to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A pagination token returned from a previous call that indicates where this listing should continue
                /// from.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/patchJobs";

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
namespace Google.Apis.OSConfig.v1.Data
{
    /// <summary>
    /// Apt patching is completed by executing `apt-get update &amp;amp;&amp;amp; apt-get upgrade`. Additional options
    /// can be set to control how this is executed.
    /// </summary>
    public class AptSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of packages to exclude from update. These packages will be excluded</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of packages to be updated. These are the only packages that will be updated. If these
        /// packages are not installed, they will be ignored. This field cannot be specified with any other patch
        /// configuration fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePackages")]
        public virtual System.Collections.Generic.IList<string> ExclusivePackages { get; set; }

        /// <summary>
        /// By changing the type to DIST, the patching is performed using `apt-get dist-upgrade` instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for canceling a patch job.</summary>
    public class CancelPatchJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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

    /// <summary>A step that runs an executable for a PatchJob.</summary>
    public class ExecStep : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ExecStepConfig for all Linux VMs targeted by the PatchJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linuxExecStepConfig")]
        public virtual ExecStepConfig LinuxExecStepConfig { get; set; }

        /// <summary>The ExecStepConfig for all Windows VMs targeted by the PatchJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsExecStepConfig")]
        public virtual ExecStepConfig WindowsExecStepConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common configurations for an ExecStep.</summary>
    public class ExecStepConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Defaults to [0]. A list of possible return values that the execution can return to indicate a success.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedSuccessCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> AllowedSuccessCodes { get; set; }

        /// <summary>A Cloud Storage object containing the executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsObject")]
        public virtual GcsObject GcsObject { get; set; }

        /// <summary>
        /// The script interpreter to use to run the script. If no interpreter is specified the script will be executed
        /// directly, which will likely only succeed for scripts with [shebang lines]
        /// (https://en.wikipedia.org/wiki/Shebang_\(Unix\)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpreter")]
        public virtual string Interpreter { get; set; }

        /// <summary>An absolute path to the executable on the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localPath")]
        public virtual string LocalPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request message to initiate patching across Compute Engine instances.</summary>
    public class ExecutePatchJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the patch job. Length of the description is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name for this patch job. This does not have to be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>If this patch is a dry-run only, instances are contacted but will do nothing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>Duration of the patch job. After the duration ends, the patch job times out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>
        /// Required. Instances to patch, either explicitly or filtered by some criteria such as zone or labels.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual PatchInstanceFilter InstanceFilter { get; set; }

        /// <summary>
        /// Patch configuration being applied. If omitted, instances are patched using the default configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchConfig")]
        public virtual PatchConfig PatchConfig { get; set; }

        /// <summary>Rollout strategy of the patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual PatchRollout Rollout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message encapsulating a value that can be either absolute ("fixed") or relative ("percent") to a value.
    /// </summary>
    public class FixedOrPercent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies a fixed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixed")]
        public virtual System.Nullable<int> Fixed__ { get; set; }

        /// <summary>
        /// Specifies the relative value defined as a percentage, which will be multiplied by a reference value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percent")]
        public virtual System.Nullable<int> Percent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud Storage object representation.</summary>
    public class GcsObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Bucket of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Required. Generation number of the Cloud Storage object. This is used to ensure that the ExecStep specified
        /// by this PatchJob does not change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generationNumber")]
        public virtual System.Nullable<long> GenerationNumber { get; set; }

        /// <summary>Required. Name of the Cloud Storage object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Googet patching is performed by running `googet update`.</summary>
    public class GooSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The inventory details of a VM.</summary>
    public class Inventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Inventory items related to the VM keyed by an opaque unique identifier for each inventory item. The
        /// identifier is unique to each distinct and addressable inventory item and will change, when there is a new
        /// package version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IDictionary<string, InventoryItem> Items { get; set; }

        /// <summary>Base level operating system information for the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osInfo")]
        public virtual InventoryOsInfo OsInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single piece of inventory on a VM.</summary>
    public class InventoryItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Software package available to be installed on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availablePackage")]
        public virtual InventorySoftwarePackage AvailablePackage { get; set; }

        /// <summary>When this inventory item was first detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Identifier for this item, unique across items for this VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Software package present on the VM instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installedPackage")]
        public virtual InventorySoftwarePackage InstalledPackage { get; set; }

        /// <summary>The origin of this inventory item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originType")]
        public virtual string OriginType { get; set; }

        /// <summary>The specific type of inventory, correlating to its specific details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>When this inventory item was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Operating system information for the VM.</summary>
    public class InventoryOsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The system architecture of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The VM hostname.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostname")]
        public virtual string Hostname { get; set; }

        /// <summary>The kernel release of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelRelease")]
        public virtual string KernelRelease { get; set; }

        /// <summary>The kernel version of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; }

        /// <summary>
        /// The operating system long name. For example 'Debian GNU/Linux 9' or 'Microsoft Window Server 2019
        /// Datacenter'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longName")]
        public virtual string LongName { get; set; }

        /// <summary>The current version of the OS Config agent running on the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osconfigAgentVersion")]
        public virtual string OsconfigAgentVersion { get; set; }

        /// <summary>The operating system short name. For example, 'windows' or 'debian'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortName")]
        public virtual string ShortName { get; set; }

        /// <summary>The version of the operating system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Software package information of the operating system.</summary>
    public class InventorySoftwarePackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Details of an APT package. For details about the apt package manager, see https://wiki.debian.org/Apt.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aptPackage")]
        public virtual InventoryVersionedPackage AptPackage { get; set; }

        /// <summary>Details of a COS package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cosPackage")]
        public virtual InventoryVersionedPackage CosPackage { get; set; }

        /// <summary>
        /// Details of a Googet package. For details about the googet package manager, see
        /// https://github.com/google/googet.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googetPackage")]
        public virtual InventoryVersionedPackage GoogetPackage { get; set; }

        /// <summary>
        /// Details of a Windows Quick Fix engineering package. See
        /// https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering for info in Windows
        /// Quick Fix Engineering.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("qfePackage")]
        public virtual InventoryWindowsQuickFixEngineeringPackage QfePackage { get; set; }

        /// <summary>
        /// Details of a Windows Update package. See https://docs.microsoft.com/en-us/windows/win32/api/_wua/ for
        /// information about Windows Update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wuaPackage")]
        public virtual InventoryWindowsUpdatePackage WuaPackage { get; set; }

        /// <summary>
        /// Yum package info. For details about the yum package manager, see
        /// https://access.redhat.com/documentation/en-us/red_hat_enterprise_linux/6/html/deployment_guide/ch-yum.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yumPackage")]
        public virtual InventoryVersionedPackage YumPackage { get; set; }

        /// <summary>
        /// Details of a Zypper package. For details about the Zypper package manager, see
        /// https://en.opensuse.org/SDB:Zypper_manual.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypperPackage")]
        public virtual InventoryVersionedPackage ZypperPackage { get; set; }

        /// <summary>
        /// Details of a Zypper patch. For details about the Zypper package manager, see
        /// https://en.opensuse.org/SDB:Zypper_manual.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypperPatch")]
        public virtual InventoryZypperPatch ZypperPatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information related to the a standard versioned package. This includes package info for APT, Yum, Zypper, and
    /// Googet package managers.
    /// </summary>
    public class InventoryVersionedPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The system architecture this package is intended for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>The name of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The version of the package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information related to a Quick Fix Engineering package. Fields are taken from Windows QuickFixEngineering
    /// Interface and match the source names:
    /// https://docs.microsoft.com/en-us/windows/win32/cimwin32prov/win32-quickfixengineering
    /// </summary>
    public class InventoryWindowsQuickFixEngineeringPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short textual description of the QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caption")]
        public virtual string Caption { get; set; }

        /// <summary>A textual description of the QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Unique identifier associated with a particular QFE update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotFixId")]
        public virtual string HotFixId { get; set; }

        /// <summary>Date that the QFE update was installed. Mapped from installed_on field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installTime")]
        public virtual object InstallTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details related to a Windows Update package. Field data and names are taken from Windows Update API IUpdate
    /// Interface: https://docs.microsoft.com/en-us/windows/win32/api/_wua/ Descriptive fields like title, and
    /// description are localized based on the locale of the VM being updated.
    /// </summary>
    public class InventoryWindowsUpdatePackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The categories that are associated with this update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<InventoryWindowsUpdatePackageWindowsUpdateCategory> Categories { get; set; }

        /// <summary>The localized description of the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// A collection of Microsoft Knowledge Base article IDs that are associated with the update package.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kbArticleIds")]
        public virtual System.Collections.Generic.IList<string> KbArticleIds { get; set; }

        /// <summary>The last published date of the update, in (UTC) date and time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDeploymentChangeTime")]
        public virtual object LastDeploymentChangeTime { get; set; }

        /// <summary>A collection of URLs that provide more information about the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moreInfoUrls")]
        public virtual System.Collections.Generic.IList<string> MoreInfoUrls { get; set; }

        /// <summary>The revision number of this update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionNumber")]
        public virtual System.Nullable<int> RevisionNumber { get; set; }

        /// <summary>A hyperlink to the language-specific support information for the update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportUrl")]
        public virtual string SupportUrl { get; set; }

        /// <summary>The localized title of the update package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>Gets the identifier of an update package. Stays the same across revisions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateId")]
        public virtual string UpdateId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Categories specified by the Windows Update.</summary>
    public class InventoryWindowsUpdatePackageWindowsUpdateCategory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The identifier of the windows update category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The name of the windows update category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details related to a Zypper Patch.</summary>
    public class InventoryZypperPatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The category of the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The name of the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchName")]
        public virtual string PatchName { get; set; }

        /// <summary>The severity specified for this patch</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Any summary information provided about this patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summary")]
        public virtual string Summary { get; set; }

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

    /// <summary>A response message for listing patch deployments.</summary>
    public class ListPatchDeploymentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A pagination token that can be used to get the next page of patch deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of patch deployments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchDeployments")]
        public virtual System.Collections.Generic.IList<PatchDeployment> PatchDeployments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing the instances details for a patch job.</summary>
    public class ListPatchJobInstanceDetailsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A pagination token that can be used to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of instance status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchJobInstanceDetails")]
        public virtual System.Collections.Generic.IList<PatchJobInstanceDetails> PatchJobInstanceDetails { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response message for listing patch jobs.</summary>
    public class ListPatchJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A pagination token that can be used to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of patch jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchJobs")]
        public virtual System.Collections.Generic.IList<PatchJob> PatchJobs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a monthly schedule. An example of a valid monthly schedule is "on the third Tuesday of the month" or
    /// "on the 15th of the month".
    /// </summary>
    public class MonthlySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. One day of the month. 1-31 indicates the 1st to the 31st day. -1 indicates the last day of the
        /// month. Months without the target day will be skipped. For example, a schedule to run "every month on the
        /// 31st" will not run in February, April, June, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthDay")]
        public virtual System.Nullable<int> MonthDay { get; set; }

        /// <summary>Required. Week day in a month.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekDayOfMonth")]
        public virtual WeekDayOfMonth WeekDayOfMonth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OS policy assignment operation metadata provided by OS policy assignment API methods that return long running
    /// operations.
    /// </summary>
    public class OSPolicyAssignmentOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OS policy assignment API method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMethod")]
        public virtual string ApiMethod { get; set; }

        /// <summary>
        /// Reference to the `OSPolicyAssignment` API resource. Format:
        /// `projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id@revision_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osPolicyAssignment")]
        public virtual string OsPolicyAssignment { get; set; }

        /// <summary>Rollout start time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutStartTime")]
        public virtual object RolloutStartTime { get; set; }

        /// <summary>State of the rollout</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutState")]
        public virtual string RolloutState { get; set; }

        /// <summary>Rollout update time</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutUpdateTime")]
        public virtual object RolloutUpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sets the time for a one time patch deployment. Timestamp is in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt)
    /// text format.
    /// </summary>
    public class OneTimeSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The desired patch job execution time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("executeTime")]
        public virtual object ExecuteTime { get; set; }

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

    /// <summary>
    /// Patch configuration specifications. Contains details on how to apply the patch(es) to a VM instance.
    /// </summary>
    public class PatchConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Apt update settings. Use this setting to override the default `apt` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apt")]
        public virtual AptSettings Apt { get; set; }

        /// <summary>Goo update settings. Use this setting to override the default `goo` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("goo")]
        public virtual GooSettings Goo { get; set; }

        /// <summary>The `ExecStep` to run after the patch update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postStep")]
        public virtual ExecStep PostStep { get; set; }

        /// <summary>The `ExecStep` to run before the patch update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preStep")]
        public virtual ExecStep PreStep { get; set; }

        /// <summary>Post-patch reboot settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rebootConfig")]
        public virtual string RebootConfig { get; set; }

        /// <summary>Windows update settings. Use this override the default windows patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowsUpdate")]
        public virtual WindowsUpdateSettings WindowsUpdate { get; set; }

        /// <summary>Yum update settings. Use this setting to override the default `yum` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yum")]
        public virtual YumSettings Yum { get; set; }

        /// <summary>Zypper update settings. Use this setting to override the default `zypper` patch rules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zypper")]
        public virtual ZypperSettings Zypper { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Patch deployments are configurations that individual patch jobs use to complete a patch. These configurations
    /// include instance filter, package repository settings, and a schedule. For more information about creating and
    /// managing patch deployments, see [Scheduling patch
    /// jobs](https://cloud.google.com/compute/docs/os-patch-management/schedule-patch-jobs).
    /// </summary>
    public class PatchDeployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Time the patch deployment was created. Timestamp is in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Optional. Description of the patch deployment. Length of the description is limited to 1024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Optional. Duration of the patch. After the duration ends, the patch times out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>Required. VM instances to patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual PatchInstanceFilter InstanceFilter { get; set; }

        /// <summary>
        /// Output only. The last time a patch job was started by this deployment. Timestamp is in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecuteTime")]
        public virtual object LastExecuteTime { get; set; }

        /// <summary>
        /// Unique name for the patch deployment resource in a project. The patch deployment name is in the form:
        /// `projects/{project_id}/patchDeployments/{patch_deployment_id}`. This field is ignored when you create a new
        /// patch deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. Schedule a one-time execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeSchedule")]
        public virtual OneTimeSchedule OneTimeSchedule { get; set; }

        /// <summary>Optional. Patch configuration that is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchConfig")]
        public virtual PatchConfig PatchConfig { get; set; }

        /// <summary>Required. Schedule recurring executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurringSchedule")]
        public virtual RecurringSchedule RecurringSchedule { get; set; }

        /// <summary>Optional. Rollout strategy of the patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual PatchRollout Rollout { get; set; }

        /// <summary>
        /// Output only. Time the patch deployment was last updated. Timestamp is in
        /// [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A filter to target VM instances for patching. The targeted VMs must meet all criteria specified. So if both
    /// labels and zones are specified, the patch job targets only VMs with those labels and in those zones.
    /// </summary>
    public class PatchInstanceFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Target all VM instances in the project. If true, no other criteria is permitted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("all")]
        public virtual System.Nullable<bool> All { get; set; }

        /// <summary>
        /// Targets VM instances matching ANY of these GroupLabels. This allows targeting of disparate groups of VM
        /// instances.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupLabels")]
        public virtual System.Collections.Generic.IList<PatchInstanceFilterGroupLabel> GroupLabels { get; set; }

        /// <summary>
        /// Targets VMs whose name starts with one of these prefixes. Similar to labels, this is another way to group
        /// VMs when targeting configs, for example prefix="prod-".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceNamePrefixes")]
        public virtual System.Collections.Generic.IList<string> InstanceNamePrefixes { get; set; }

        /// <summary>
        /// Targets any of the VM instances specified. Instances are specified by their URI in the form
        /// `zones/[ZONE]/instances/[INSTANCE_NAME]`, `projects/[PROJECT_ID]/zones/[ZONE]/instances/[INSTANCE_NAME]`, or
        /// `https://www.googleapis.com/compute/v1/projects/[PROJECT_ID]/zones/[ZONE]/instances/[INSTANCE_NAME]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<string> Instances { get; set; }

        /// <summary>
        /// Targets VM instances in ANY of these zones. Leave empty to target VM instances in any zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<string> Zones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Targets a group of VM instances by using their [assigned
    /// labels](https://cloud.google.com/compute/docs/labeling-resources). Labels are key-value pairs. A `GroupLabel` is
    /// a combination of labels that is used to target VMs for a patch job. For example, a patch job can target VMs that
    /// have the following `GroupLabel`: `{"env":"test", "app":"web"}`. This means that the patch job is applied to VMs
    /// that have both the labels `env=test` and `app=web`.
    /// </summary>
    public class PatchInstanceFilterGroupLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Compute Engine instance labels that must be present for a VM instance to be targeted by this filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A high level representation of a patch job that is either in progress or has completed. Instance details are not
    /// included in the job. To paginate through instance details, use ListPatchJobInstanceDetails. For more information
    /// about patch jobs, see [Creating patch
    /// jobs](https://cloud.google.com/compute/docs/os-patch-management/create-patch-job).
    /// </summary>
    public class PatchJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time this patch job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Description of the patch job. Length of the description is limited to 1024 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name for this patch job. This is not a unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// If this patch job is a dry run, the agent reports that it has finished without running any updates on the VM
        /// instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dryRun")]
        public virtual System.Nullable<bool> DryRun { get; set; }

        /// <summary>Duration of the patch job. After the duration ends, the patch job times out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>If this patch job failed, this message provides information about the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Summary of instance details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceDetailsSummary")]
        public virtual PatchJobInstanceDetailsSummary InstanceDetailsSummary { get; set; }

        /// <summary>Instances to patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceFilter")]
        public virtual PatchInstanceFilter InstanceFilter { get; set; }

        /// <summary>Unique identifier for this patch job in the form `projects/*/patchJobs/*`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Patch configuration being applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchConfig")]
        public virtual PatchConfig PatchConfig { get; set; }

        /// <summary>Output only. Name of the patch deployment that created this patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patchDeployment")]
        public virtual string PatchDeployment { get; set; }

        /// <summary>
        /// Reflects the overall progress of the patch job in the range of 0.0 being no progress to 100.0 being
        /// complete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentComplete")]
        public virtual System.Nullable<double> PercentComplete { get; set; }

        /// <summary>Rollout strategy being applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rollout")]
        public virtual PatchRollout Rollout { get; set; }

        /// <summary>The current state of the PatchJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Last time this patch job was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Patch details for a VM instance. For more information about reviewing VM instance details, see [Listing all VM
    /// instance details for a specific patch
    /// job](https://cloud.google.com/compute/docs/os-patch-management/manage-patch-jobs#list-instance-details).
    /// </summary>
    public class PatchJobInstanceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of times the agent that the agent attempts to apply the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attemptCount")]
        public virtual System.Nullable<long> AttemptCount { get; set; }

        /// <summary>If the patch fails, this field provides the reason.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureReason")]
        public virtual string FailureReason { get; set; }

        /// <summary>The unique identifier for the instance. This identifier is defined by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceSystemId")]
        public virtual string InstanceSystemId { get; set; }

        /// <summary>The instance name in the form `projects/*/zones/*/instances/*`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Current state of instance patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A summary of the current patch state across all instances that this patch job affects. Contains counts of
    /// instances in different states. These states map to `InstancePatchState`. List patch job instance details to see
    /// the specific states of each instance.
    /// </summary>
    public class PatchJobInstanceDetailsSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of instances that have acked and will start shortly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackedInstanceCount")]
        public virtual System.Nullable<long> AckedInstanceCount { get; set; }

        /// <summary>Number of instances that are applying patches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyingPatchesInstanceCount")]
        public virtual System.Nullable<long> ApplyingPatchesInstanceCount { get; set; }

        /// <summary>Number of instances that are downloading patches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadingPatchesInstanceCount")]
        public virtual System.Nullable<long> DownloadingPatchesInstanceCount { get; set; }

        /// <summary>Number of instances that failed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedInstanceCount")]
        public virtual System.Nullable<long> FailedInstanceCount { get; set; }

        /// <summary>Number of instances that are inactive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inactiveInstanceCount")]
        public virtual System.Nullable<long> InactiveInstanceCount { get; set; }

        /// <summary>
        /// Number of instances that do not appear to be running the agent. Check to ensure that the agent is installed,
        /// running, and able to communicate with the service.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noAgentDetectedInstanceCount")]
        public virtual System.Nullable<long> NoAgentDetectedInstanceCount { get; set; }

        /// <summary>Number of instances notified about patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notifiedInstanceCount")]
        public virtual System.Nullable<long> NotifiedInstanceCount { get; set; }

        /// <summary>Number of instances pending patch job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingInstanceCount")]
        public virtual System.Nullable<long> PendingInstanceCount { get; set; }

        /// <summary>Number of instances that are running the post-patch step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postPatchStepInstanceCount")]
        public virtual System.Nullable<long> PostPatchStepInstanceCount { get; set; }

        /// <summary>Number of instances that are running the pre-patch step.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prePatchStepInstanceCount")]
        public virtual System.Nullable<long> PrePatchStepInstanceCount { get; set; }

        /// <summary>Number of instances rebooting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rebootingInstanceCount")]
        public virtual System.Nullable<long> RebootingInstanceCount { get; set; }

        /// <summary>Number of instances that have started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startedInstanceCount")]
        public virtual System.Nullable<long> StartedInstanceCount { get; set; }

        /// <summary>Number of instances that have completed successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeededInstanceCount")]
        public virtual System.Nullable<long> SucceededInstanceCount { get; set; }

        /// <summary>Number of instances that require reboot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeededRebootRequiredInstanceCount")]
        public virtual System.Nullable<long> SucceededRebootRequiredInstanceCount { get; set; }

        /// <summary>Number of instances that exceeded the time out while applying the patch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timedOutInstanceCount")]
        public virtual System.Nullable<long> TimedOutInstanceCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Patch rollout configuration specifications. Contains details on the concurrency control when applying patch(es)
    /// to all targeted VMs.
    /// </summary>
    public class PatchRollout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number (or percentage) of VMs per zone to disrupt at any given moment. The number of VMs
        /// calculated from multiplying the percentage by the total number of VMs in a zone is rounded up. During
        /// patching, a VM is considered disrupted from the time the agent is notified to begin until patching has
        /// completed. This disruption time includes the time to complete reboot and any post-patch steps. A VM
        /// contributes to the disruption budget if its patching operation fails either when applying the patches,
        /// running pre or post patch steps, or if it fails to respond with a success notification before timing out.
        /// VMs that are not running or do not have an active agent do not count toward this disruption budget. For
        /// zone-by-zone rollouts, if the disruption budget in a zone is exceeded, the patch job stops, because
        /// continuing to the next zone requires completion of the patch process in the previous zone. For example, if
        /// the disruption budget has a fixed value of `10`, and 8 VMs fail to patch in the current zone, the patch job
        /// continues to patch 2 VMs at a time until the zone is completed. When that zone is completed successfully,
        /// patching begins with 10 VMs at a time in the next zone. If 10 VMs in the next zone fail to patch, the patch
        /// job stops.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disruptionBudget")]
        public virtual FixedOrPercent DisruptionBudget { get; set; }

        /// <summary>Mode of the patch rollout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual string Mode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sets the time for recurring patch deployments.</summary>
    public class RecurringSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The end time at which a recurring patch deployment schedule is no longer active.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Required. The frequency unit of this recurring schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frequency")]
        public virtual string Frequency { get; set; }

        /// <summary>Output only. The time the last patch job ran successfully.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExecuteTime")]
        public virtual object LastExecuteTime { get; set; }

        /// <summary>Required. Schedule with monthly executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthly")]
        public virtual MonthlySchedule Monthly { get; set; }

        /// <summary>Output only. The time the next patch job is scheduled to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextExecuteTime")]
        public virtual object NextExecuteTime { get; set; }

        /// <summary>
        /// Optional. The time that the recurring schedule becomes effective. Defaults to `create_time` of the patch
        /// deployment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Required. Time of the day to run a recurring deployment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeOfDay")]
        public virtual TimeOfDay TimeOfDay { get; set; }

        /// <summary>
        /// Required. Defines the time zone that `time_of_day` is relative to. The rules for daylight saving time are
        /// determined by the chosen time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual TimeZone TimeZone { get; set; }

        /// <summary>Required. Schedule with weekly executions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekly")]
        public virtual WeeklySchedule Weekly { get; set; }

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
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a time zone from the [IANA Time Zone Database](https://www.iana.org/time-zones).</summary>
    public class TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IANA Time Zone Database time zone, e.g. "America/New_York".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Optional. IANA Time Zone Database version number, e.g. "2019a".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents one week day in a month. An example is "the 4th Sunday".</summary>
    public class WeekDayOfMonth : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>
        /// Required. Week number in a month. 1-4 indicates the 1st to 4th week of the month. -1 indicates the last week
        /// of the month.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weekOrdinal")]
        public virtual System.Nullable<int> WeekOrdinal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a weekly schedule.</summary>
    public class WeeklySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Day of the week.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Windows patching is performed using the Windows Update Agent.</summary>
    public class WindowsUpdateSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Only apply updates of these windows update classifications. If empty, all updates are applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classifications")]
        public virtual System.Collections.Generic.IList<string> Classifications { get; set; }

        /// <summary>List of KBs to exclude from update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of kbs to be updated. These are the only patches that will be updated. This field must not
        /// be used with other patch configurations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePatches")]
        public virtual System.Collections.Generic.IList<string> ExclusivePatches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Yum patching is performed by executing `yum update`. Additional options can be set to control how this is
    /// executed. Note that not all settings are supported on all platforms.
    /// </summary>
    public class YumSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of packages to exclude from update. These packages are excluded by using the yum `--exclude` flag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of packages to be updated. These are the only packages that will be updated. If these
        /// packages are not installed, they will be ignored. This field must not be specified with any other patch
        /// configuration fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePackages")]
        public virtual System.Collections.Generic.IList<string> ExclusivePackages { get; set; }

        /// <summary>Will cause patch to run `yum update-minimal` instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimal")]
        public virtual System.Nullable<bool> Minimal { get; set; }

        /// <summary>Adds the `--security` flag to `yum update`. Not supported on all platforms.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("security")]
        public virtual System.Nullable<bool> Security { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Zypper patching is performed by running `zypper patch`. See also https://en.opensuse.org/SDB:Zypper_manual.
    /// </summary>
    public class ZypperSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Install only patches with these categories. Common categories include security, recommended, and feature.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>List of patches to exclude from update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludes")]
        public virtual System.Collections.Generic.IList<string> Excludes { get; set; }

        /// <summary>
        /// An exclusive list of patches to be updated. These are the only patches that will be installed using 'zypper
        /// patch patch:' command. This field must not be used with any other patch configuration fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusivePatches")]
        public virtual System.Collections.Generic.IList<string> ExclusivePatches { get; set; }

        /// <summary>
        /// Install only patches with these severities. Common severities include critical, important, moderate, and
        /// low.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severities")]
        public virtual System.Collections.Generic.IList<string> Severities { get; set; }

        /// <summary>Adds the `--with-optional` flag to `zypper patch`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("withOptional")]
        public virtual System.Nullable<bool> WithOptional { get; set; }

        /// <summary>Adds the `--with-update` flag, to `zypper patch`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("withUpdate")]
        public virtual System.Nullable<bool> WithUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
